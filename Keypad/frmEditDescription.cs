using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keypad
{
    public partial class frmEditDescription : Form
    {
        public frmEditDescription(string description)
        {
            InitializeComponent();
            textDescription.Text = description;
            this.AcceptButton = btnOK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        
        private void btnOK_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        public string getDescription()
        {
            
            return this.textDescription.Text;
        }
    }
}
