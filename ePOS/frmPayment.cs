using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ePOS
{
    public partial class frmPayment : Form
    {
        
        //create dataadapter for the dataset tables
        private DataDataSetTableAdapters.tbl_SalesLinesTableAdapter datbl_SalesLines = new DataDataSetTableAdapters.tbl_SalesLinesTableAdapter();
        
        public frmPayment(ArrayList salesSlip)
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAmount_Click(object sender, EventArgs e)
        {
            frmQty payment = new frmQty("currency");
            payment.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // write salesSlip to database.
            //salsSlip is an Array of saleslines
        }
    }
}
