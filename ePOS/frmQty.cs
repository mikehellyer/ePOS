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
    public partial class frmQty : Form
    {
        private double _value = 0.0;
        private int _qty = 0;
        private Boolean firstTime = true;

        public frmQty(string mode)
        {
            InitializeComponent();
            if (mode == "qty")
            {
                lblMessage.Text = "Enter Qty";
                registerKeypad1.disableBtn00();
                registerKeypad1.disableBtnDot();
                

            }
            else
                if (mode == "currency") lblMessage.Text = "Enter Amount";
        }



        public int resultQty
        {
            get { return _qty; }
            private set { _qty = value; }
        }
        
        private void registerKeypad1_Load(object sender, EventArgs e)
        {
            
        }


        private void registerKeypad1_CharButtonClicked(object sender, KeyPressEventArgs e)
        {
              DialogResult = registerKeypad1.DialogResult;

              
              //if this is the first time empty the value text
              if (firstTime) 
              { 
                  txtValue.Text = "";
                  firstTime = false;
              }
              
             
            //If the enter key or cancel has NOT been clicked 
            if ((e.KeyChar != 'E') && (e.KeyChar != 'C'))
              {
                if (txtValue.Text.Length < 8) txtValue.Text += e.KeyChar;
                  
              }
              else
              //if the cancel key HAS been clicked
              if (e.KeyChar == 'C')
              {

                  txtValue.Text = "1";
                  this.Close();
              }

              //MessageBox.Show(txtValue.Text);
              if (txtValue.Text != "") resultQty = int.Parse(txtValue.Text.ToString());
              else resultQty = 1;
   
              
        }
    }
}
