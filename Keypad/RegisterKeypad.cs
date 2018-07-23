using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keypad
{
    public partial class RegisterKeypad : GenericKeypad
    {
        public RegisterKeypad()
        {
            InitializeComponent();
        }

        //Create a DialogResult property
        [Browsable(true), DefaultValue(typeof(System.Windows.Forms.DialogResult))]
        public DialogResult DialogResult { get; set; }


        private void btn1_Click(object sender, EventArgs e)
        {
            CharButtonPressed('1');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CharButtonPressed('2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CharButtonPressed('3');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CharButtonPressed('4');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CharButtonPressed('5');
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CharButtonPressed('6');
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CharButtonPressed('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CharButtonPressed('8');
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            CharButtonPressed('9');
        }

        private void btn00_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            CharButtonPressed('0');
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CharButtonPressed('C');
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            CharButtonPressed('E');
        }

        public void disableBtnDot()
        {
            btnDot.Enabled = false;

        }

        public void disableBtn00()
        {
            btn00.Enabled = false;
        }

        private void RegisterKeypad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //Escape Key Pressed
                
                CharButtonPressed('C');
                
            }
        }



        
    }
}
