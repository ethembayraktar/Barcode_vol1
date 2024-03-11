using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2.Classes;
using System.Drawing.Design;
namespace WindowsFormsApp2
{
    public partial class AdminKategoriİşlemleri : Form
    {
        public AdminKategoriİşlemleri()
        {
            InitializeComponent();
        }

        public void LoadCategories()
        {
            SqlCommand commandListCategories = new SqlCommand("Select * from TableCategory", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            SqlDataAdapter da = new SqlDataAdapter(commandListCategories);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void AdminKategoriİşlemleri_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            SqlCommand commandAddCategory = new SqlCommand("Insert into TableCategory(CategoryName) values(@pname)", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandAddCategory.Parameters.AddWithValue("pname",tboxCategoryName.Text);
            commandAddCategory.ExecuteNonQuery();
            LoadCategories();
        }

        string SelectedID;
        string SelectedName;
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("delete from TableCategory where CategoryID=@pid",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandDelete.Parameters.AddWithValue("@pid",Convert.ToInt32(SelectedID));
            commandDelete.ExecuteNonQuery();
            LoadCategories();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SelectedID = dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString();
            SelectedName= dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            lblSelectedID.Text=SelectedName ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
            
        }
    }
}
