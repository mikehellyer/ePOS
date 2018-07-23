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
    public partial class frmModifyProduct : Form
    {
        public frmModifyProduct()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.UserBackColor;
           

        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.tblTaxDetails' table. You can move, or remove it, as needed.
            this.tbl_TaxDetailsTableAdapter.Fill(this.dataDataSet.tbl_TaxDetails);
            // TODO: This line of code loads data into the 'dataDataSet.tblSuppliers' table. You can move, or remove it, as needed.
            this.tbl_SuppliersTableAdapter.Fill(this.dataDataSet.tbl_Suppliers);
            // TODO: This line of code loads data into the 'dataDataSet.tblDepartments' table. You can move, or remove it, as needed.
            this.tbl_DepartmentsTableAdapter.Fill(this.dataDataSet.tbl_Departments);
            // TODO: This line of code loads data into the 'dataDataSet.Spec_tbl' table. You can move, or remove it, as needed.
            this.tbl_ItemsTableAdapter.Fill(this.dataDataSet.tbl_Items);

            cmbBarcode.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBarcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void cmbBarcode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        

        private void cmbBarcode_SelectedValueChanged(object sender, EventArgs e)
        {
            dataDataSet.EnforceConstraints = false;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Enter(object sender, EventArgs e)
        {

        }

        private void cmbBarcode_Enter(object sender, EventArgs e)
        {
            cmbBarcode.BackColor = Color.Yellow;
          
        }

        private void cmbBarcode_Leave(object sender, EventArgs e)
        {
            cmbBarcode.BackColor = Color.White;
            
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            txtDescription.BackColor = Color.White;
        }

        private void txtReorder_Leave(object sender, EventArgs e)
        {
            txtReorder.BackColor = Color.White;
        }

        private void cmbDeptCode_Leave(object sender, EventArgs e)
        {
            cmbDeptCode.BackColor = Color.White;
        }

        private void cmbSupplierCode_Leave(object sender, EventArgs e)
        {
            cmbSupplierCode.BackColor = Color.White;
        }

        private void txtMinStockLevel_Leave(object sender, EventArgs e)
        {

           txtMinStockLevel.BackColor = Color.White;
        }

        private void txtMinOrderQty_Leave(object sender, EventArgs e)
        {
            txtMinOrderQty.BackColor = Color.White;
        }

        private void txtBoxCostprice_Leave(object sender, EventArgs e)
        {
            txtBoxCostprice.BackColor = Color.White;
        }

        private void cmbTaxCode_Leave(object sender, EventArgs e)
        {
            cmbTaxCode.BackColor = Color.White;
        }

        
        private void txtVATRate_Leave(object sender, EventArgs e)
        {
            txtVATRate.BackColor = Color.White;
        }

        private void txtRetailPrice_Leave(object sender, EventArgs e)
        {
            txtRetailPrice.BackColor = Color.White;
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            txtDescription.BackColor = Color.Yellow;
        }

        private void txtReorder_Enter(object sender, EventArgs e)
        {
            txtReorder.BackColor = Color.Yellow;
        }

        private void cmbDeptCode_Enter(object sender, EventArgs e)
        {
            cmbDeptCode.BackColor = Color.Yellow;
        }

        private void cmbSupplierCode_Enter(object sender, EventArgs e)
        {
            cmbSupplierCode.BackColor = Color.Yellow;
        }

        private void txtMinStockLevel_Enter(object sender, EventArgs e)
        {
            txtMinStockLevel.BackColor = Color.Yellow;
        }

        private void txtMinOrderQty_Enter(object sender, EventArgs e)
        {
            txtMinOrderQty.BackColor = Color.Yellow;
        }

        private void txtBoxCostprice_Enter(object sender, EventArgs e)
        {
            txtBoxCostprice.BackColor = Color.Yellow;
        }

        private void cmbTaxCode_Enter(object sender, EventArgs e)
        {
            cmbTaxCode.BackColor = Color.Yellow;
        }

       

        private void txtRetailPrice_Enter(object sender, EventArgs e)
        {
            txtRetailPrice.BackColor = Color.Yellow;
        }

        private void txtVATRate_Enter(object sender, EventArgs e)
        {
            txtVATRate.BackColor = Color.Yellow;
        }

        


        
    }
}
