using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminKategoriİşlemleri categoryPage=new AdminKategoriİşlemleri();
            categoryPage.Show();    
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminÜrünİşlemleri adm = new AdminÜrünİşlemleri();
            adm.Show();
        }
    }
}
