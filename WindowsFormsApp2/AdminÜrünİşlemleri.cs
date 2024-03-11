using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Classes;
using System.Data.SqlClient;
using System.Data.Common;
using AForge.Video.DirectShow;
using ZXing;
namespace WindowsFormsApp2
{
   
    public partial class AdminÜrünİşlemleri : Form
    {
        public AdminÜrünİşlemleri()
        {
            InitializeComponent();
        }

        public void LoadProducts()
        {
            SqlCommand cmd = new SqlCommand("select ProductID,ProductPrice,ProductName,ProductBarcode,CategoryName from TableProduct inner join TableCategory on TableProduct.ProductCategory=TableCategory.CategoryID", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgProduct.DataSource = dt;
        }
        public void LoadCategory()
        {
            SqlCommand commandLoadCategories = new SqlCommand("select * from TableCategory",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            cmbBoxCategory.DisplayMember = "CategoryName";
            cmbBoxCategory.ValueMember = "CategoryID";
            SqlDataAdapter daLoadCategories = new SqlDataAdapter(commandLoadCategories);
            DataTable dtLoadCategories = new DataTable();
            daLoadCategories.Fill(dtLoadCategories);
            cmbBoxCategory.DataSource = dtLoadCategories;
        }
        private void AdminÜrünİşlemleri_Load(object sender, EventArgs e)
        {
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo cihaz in Cihazlar)
            {
                cmbKamera.Items.Add(cihaz.Name);    
            }
            cmbKamera.SelectedIndex = 0;
            LoadProducts();
            LoadCategory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("insert into TableProduct(ProductName,ProductCategory,ProductPrice,ProductBarcode) values(@pname,@pcategory,@pprice,@pbarcode)",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandAdd.Parameters.AddWithValue("@pname",tboxProductName.Text);
            commandAdd.Parameters.AddWithValue("@pcategory",Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandAdd.Parameters.AddWithValue("@pprice", tboxProductPrice.Text);
            commandAdd.Parameters.AddWithValue("@pbarcode", tboxProductBarcode.Text);

            commandAdd.ExecuteNonQuery();

            IncreaseCategoryCount();
            LoadProducts();
            MessageBox.Show("ÜRÜN EKLENDİ");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete  from TableProduct where ProductID=@pid", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection (SqlConnectionClass.connect);
            commandDelete.Parameters.AddWithValue("@pid",Convert.ToInt32(Convert.ToInt32( SelectedID))  );
            commandDelete.ExecuteNonQuery ();
            DecreaseCategoryCount();
            LoadProducts();
            MessageBox.Show("ÜRÜN SİLİNDİ");
        }
        string SelectedID;
        string SelectedName;
        private void dgProduct_SelectionChanged(object sender, EventArgs e)
        {
            SelectedID = dgProduct.CurrentRow.Cells["ProductID"].Value.ToString();
            SelectedName = dgProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            lblSelectedID.Text = SelectedName   ;
        }

        public void IncreaseCategoryCount()
        {
            SqlCommand commandincrease = new SqlCommand("update TableCategory set CategoryCount+=1 where CategoryID=@pid",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandincrease.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandincrease.ExecuteNonQuery();
        }

        public void DecreaseCategoryCount()
        {
            SqlCommand commandincrease = new SqlCommand("update TableCategory set CategoryCount-=1 where CategoryID=@pid", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandincrease.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandincrease.ExecuteNonQuery();
        }


        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);
            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap GoruntulenenBarkod = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader okuyucu = new BarcodeReader();
            var sonuc = okuyucu.Decode(GoruntulenenBarkod);
            if(sonuc != null) 
            {
                textBox1.Invoke(new MethodInvoker(delegate()
                {
                    textBox1.Text=sonuc.ToString();
                }
                ));
                kameram.Stop();
            }
            PictureBox1.Image = GoruntulenenBarkod;
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kameram != null && kameram.IsRunning)
            {
                kameram.Stop();
            }
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            if (kameram != null && kameram.IsRunning)
            {
                kameram.Stop();
            }
        }
    }
}
