using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ePOS
{
    public partial class frmMain : Form
    {

        //private string eposConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ePOSdata;Integrated Security=True";
        public static SqlConnection SQLConn = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=ePosData;Integrated Security=True");
        //private string commandString = "";
        private SqlDataAdapter SQLda = new SqlDataAdapter();
        
        //make the datasset static and available to all objects by calling frmMain
        public static DataDataSet SQLds = new DataDataSet();
               
        
        
        public frmMain()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.UserBackColor;
            
            
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmProductsForm frmProducts = new frmProductsForm();
            frmProducts.ShowDialog();

        }

       

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSalesScreen sales = new frmSalesScreen();
            sales.ShowDialog();
        }

        private void createEposDataSet()
        {
            //Fill the Dataset with data from the database

            updateTable("SELECT * FROM tbl_AddHocRefundsDetails", "tbl_AddHocRefundsDetails");
            updateTable("SELECT * FROM tbl_AddHocReturns", "tbl_AddHocRerurns");
            updateTable("SELECT * FROM tbl_AdditionalBarcodes", "tbl_AdditionalBarcodes");
            updateTable("SELECT * FROM tbl_BackGroundColours", "tbl_BackGroundColours");
            updateTable("SELECT * FROM tbl_Barcodes", "tbl_Barcodes");
            updateTable("SELECT * FROM tbl_CurrencyConversion", "tbl_CurrencyConversion");
            updateTable("SELECT * FROM tbl_DefaultScreen", "tbl_DefaultScreen");
            updateTable("SELECT * FROM tbl_Departments", "tbl_Departments"); 
            updateTable("SELECT * FROM tbl_InvoicePayments", "tbl_InvicePayments");
            updateTable("SELECT * FROM tbl_Invoices", "tbl_Invoices");
            updateTable("SELECT * FROM tbl_Items", "tbl_Items");
            updateTable("SELECT * FROM tbl_LayerProtection", "tbl_LayerProtection");
            updateTable("SELECT * FROM tbl_Loyalty", "tbl_Loyalty");
            updateTable("SELECT * FROM tbl_Payments", "tbl_Payments");
            updateTable("SELECT * FROM tbl_SalesLines", "tbl_SalesLines");     
            updateTable("SELECT * FROM tbl_SerialNumbers", "tbl_SerialNumbers");
            updateTable("SELECT * FROM tbl_SetUp", "tbl_SetUp");
            updateTable("SELECT * FROM tbl_Suppliers", "tbl_Suppliers");
            updateTable("SELECT * FROM tbl_TaxDetails", "tbl_TaxDetails");
            updateTable("SELECT * FROM tbl_TextColours", "tbl_TextColours");
            updateTable("SELECT * FROM tbl_Token", "tbl_Token");
            updateTable("SELECT * FROM tbl_ZReset", "tbl_ZReset");


        }

        private void updateTable(string commandString,string table)
        {
            SQLda = new SqlDataAdapter(commandString, SQLConn);
            SQLda.Fill(SQLds, table);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            createEposDataSet();
        }

        private void btnCloseTill_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

    }
}
