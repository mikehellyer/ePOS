using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ePOS
{
    public partial class frmProductsForm : Form
    {
        public frmProductsForm()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.UserBackColor;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct addProducts = new AddProduct();
            addProducts.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmModifyProduct modifyProducts = new frmModifyProduct();
            modifyProducts.ShowDialog();
        }
    }
}
