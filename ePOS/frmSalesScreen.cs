using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ePOSClass;
using System.Data.SqlClient;




namespace ePOS
{
    public partial class frmSalesScreen : Form
    {
        private SqlDataAdapter SQLda = new SqlDataAdapter();
        public ArrayList filteredProducts = new ArrayList();
        public ArrayList departments = new ArrayList();
        private ArrayList saleSlip = new ArrayList();
        private int totalItems = 0;
        private double totalRetail = 0;
        private int salesQty = 1;
        private int saleNo = 0;
       
        private bool voidMode = false;
        private bool refundMode = false;
        private bool qtyMode = false;

        //create dataadapter from the dataset tables
        private DataDataSetTableAdapters.tbl_InvoicesTableAdapter datbl_Invoices = new DataDataSetTableAdapters.tbl_InvoicesTableAdapter();


        public frmSalesScreen()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.UserBackColor;
            
            
        }

        private void SalesScreen_Load(object sender, EventArgs e)
        {

            //Update the Vertical Scrollpad with department data

            DataTable departmentsdt = frmMain.SQLds.Tables["tbl_Departments"];
            
            foreach (DataRow row in departmentsdt.Rows)
            {
                departments.Add(row["DepartmentCode"]);
               
            }
            
            verticalScrollPad1.uploadDepartments(departments);
            horizontalScrollPad1.uploadDepartments(departments);
          
            updateMatrix(0);

            // Get latest salesNo

            DataTable invoiceLinesdt = frmMain.SQLds.Tables["tbl_Invoices"];
            DataRow lastSalesRow = invoiceLinesdt.Rows[invoiceLinesdt.Rows.Count-1];
            lblSaleNo.Text = lastSalesRow["SaleNo"].ToString();

            

            textBox1.Focus();

        }

        public void updateMatrix(int index)
        {
            //Update the matrix scrollpad with products
            //IndexedProduct productIndex = new IndexedProduct();
            int productCount = 0;
            DataTable productsdt = frmMain.SQLds.Tables["tbl_Items"];
            
            filteredProducts.Clear();
 
            foreach (DataRow row in productsdt.Rows)
            {

                if (departments[index].ToString() == row["DeptCode"].ToString())
                {

                    filteredProducts.Add(new IndexedProduct(productCount,row["Description"].ToString()));
 
                }
                
                productCount++;
            }

            matrixScrollPad1.uploadDepartments(filteredProducts);
            

        }

        
        private void verticalScrollPad1_ButtonClicked(int index)
        {
            //MessageBox.Show(index.ToString());
            updateMatrix(index);
            matrixScrollPad1.Refresh();
            textBox1.Focus();

        }

        private void horizontalScrollPad1_ButtonClicked(int index)
        {
            //MessageBox.Show(index.ToString());
            
            textBox1.Focus();
            
        }

        private void updateSalesSlip(int index)
        {

            //Update the sales slip with selected product
            DataTable productsdt = frmMain.SQLds.Tables["tbl_Items"];
            DataRow row = productsdt.Rows[index];
            //create a Sales Line object with current details
            SalesLine line = new SalesLine(saleNo,
                                           row["StockRef"].ToString(),
                                           row["Description"].ToString(),
                                           salesQty,
                                           double.Parse(row["RetailPrice"].ToString()),
                                           salesQty*double.Parse(row["RetailPrice"].ToString()),
                                           3.00,
                                           0,
                                           0.00,
                                           DateTime.Now,
                                           row["DeptCode"].ToString(),
                                           false,
                                           false,
                                           int.Parse(row["TaxCode"].ToString()),
                                           double.Parse(row["CostPrice"].ToString()),
                                           row["CatalogueCode"].ToString(),
                                           int.Parse(row["MarkUpPercent"].ToString()),
                                           "00000000"

                                           );

            //add to the textbox
            richTextSales.AppendText(
                line._description
                + "    " 
                + (line._orderQty.ToString())
                + "    "
                + salesQty * double.Parse(row["RetailPrice"].ToString())
                +'\n');
            richTextSales.ScrollToCaret();
            totalItems += 1;
            totalRetail += salesQty * double.Parse(row["RetailPrice"].ToString()); 
            updateLabelTotals();

            //add to the sales slip array.
            saleSlip.Add(line);

            //Reset salesQty if greater than 1
            if (salesQty > 1) salesQty = 1;
        }

        
        private void matrixScrollPad1_ButtonClicked(int index)
        {
            //MessageBox.Show(index.ToString());
            
            // Check till mode
            if (btnVoid.BackColor == Color.Red) 
                { btnVoid.BackColor = Color.PowderBlue;
                voidMode = false;    
                }

            updateSalesSlip(index);
            textBox1.Focus();
            
        }
        
        private void horizontalScrollPad1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

     

      

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                //Scan for a product
                //DataTable productsdt = dataDataSet.Tables["Items_tbl"];
                DataTable productsdt = frmMain.SQLds.Tables["tbl_Items"];
                filteredProducts.Clear();
                int productIndex = 0;
                foreach (DataRow row in productsdt.Rows)
                {

                    if (textBox1.Text == row["StockRef"].ToString())
                    {
                        
                        //richTextSales.AppendText(row["Description"].ToString()+'\n');
                        updateSalesSlip(productIndex);
                        
                       
                    }
                    productIndex += 1;
                }

                textBox1.Text = "";
                
            }
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            richTextSales.Text = "";
            totalRetail = 0;
            totalItems = 0;
            updateLabelTotals();
            textBox1.Focus();
            //Write a blank cancelled invoice to frmMain.SQLds.Tables["tbl_Invoices"]
            DataRow newRow = frmMain.SQLds.Tables["tbl_Invoices"].NewRow();

            
            newRow["InvoiceNo"] = 1;
            newRow["Date"] = DateTime.Now;
            newRow["GoodsSold"] = 0.0;
            newRow["TaxPaid"] = 0.0;
            newRow["SaleTotal"] = 0.0;
            newRow["SaleType"] = "Cancelled";
            newRow["LastRefund"] = DBNull.Value ;
            newRow["LastRefundAmount"] = 0.0;
            newRow["CustBalance"] = 0.0;
            newRow["CustID"] = 0;
            newRow["Time"] = DBNull.Value;
            newRow["Pos"] = 1;
            newRow["AmountTendered"] = 0.0;
            newRow["SaleCompleted"] = 0;
            newRow["TotalSaleDiscount"] = 0.0;
            
            // add a new row to the dataset
            frmMain.SQLds.Tables["tbl_Invoices"].Rows.Add(newRow);
            
            
            //go ahead and update
            datbl_Invoices.Update(frmMain.SQLds);
            this.Close();
        }

       private void updateLabelTotals()
       {
           lblItemCount.Text = totalItems.ToString();
          
           lblSubTotalAmount.Text = totalRetail.ToString();
       }


        private void richTextSales_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVoid_Click(object sender, EventArgs e)
        { 
            Button btn = sender as Button;   
           //thisupColor = btn.BackColor;

            if (btn.BackColor == Color.PowderBlue) { btn.BackColor = Color.Red; } else { btn.BackColor = Color.PowderBlue; }
            if (voidMode == false) voidMode = true; else voidMode = false;
            textBox1.Focus();
        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            
            frmQty qty = new frmQty("qty");
            if (qty.ShowDialog(this) == DialogResult.OK)
            {  
                salesQty = qty.resultQty;
                
            }
            
            qty.Dispose();

            textBox1.Focus();
            //MessageBox.Show(salesQty.ToString());
        }

        private void btnLastReceipt_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void btnAccountSale_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void btnFinishSale_Click(object sender, EventArgs e)
        {

            //frmQty qty = new frmQty("qty");
            frmPayment payment = new frmPayment(saleSlip);
            payment.ShowDialog();
            textBox1.Focus();
        }

        private void btnOpenTill_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            textBox1.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            textBox1.Focus();
        }

        private void verticalScrollPad1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void verticalScrollPad1_ArrowButtonClicked(object sender, KeyPressEventArgs e)
        {
            textBox1.Focus();
        }

        private void matrixScrollPad1_ArrowButtonClicked(object sender, KeyPressEventArgs e)
        {
            textBox1.Focus();
        }

        private void horizontalScrollPad1_ArrowButtonClicked(object sender, KeyPressEventArgs e)
        {
            textBox1.Focus();
        }

        private void richTextSales_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void btnSaleRefund_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (btn.BackColor == Color.PowderBlue) { btn.BackColor = Color.Red; } else { btn.BackColor = Color.PowderBlue; }
            if (refundMode == false) refundMode = true; else refundMode = false;
            textBox1.Focus();
        }


        

        
    }

   

   
}
