using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Keypad
{
    public partial class HorizontalScrollPad : GenericKeypad
    {
        private ArrayList Departments;
        private int scrollPos=0;
        
        public HorizontalScrollPad()
        {
            InitializeComponent();
        }

        private void updateButtons()
        {

            if (scrollPos + 0 < Departments.Count) { button2.Text = Departments[scrollPos + 0].ToString(); } else { button2.Text = ""; }
            if (scrollPos + 1 < Departments.Count) { button3.Text = Departments[scrollPos + 1].ToString(); } else { button3.Text = ""; }
            if (scrollPos + 2 < Departments.Count) { button4.Text = Departments[scrollPos + 2].ToString(); } else { button4.Text = ""; }
            if (scrollPos + 3 < Departments.Count) { button5.Text = Departments[scrollPos + 3].ToString(); } else { button5.Text = ""; }
            if (scrollPos + 4 < Departments.Count) { button6.Text = Departments[scrollPos + 4].ToString(); } else { button6.Text = ""; }
            if (scrollPos + 5 < Departments.Count) { button7.Text = Departments[scrollPos + 5].ToString(); } else { button7.Text = ""; }
            if (scrollPos + 6 < Departments.Count) { button8.Text = Departments[scrollPos + 6].ToString(); } else { button8.Text = ""; }

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (scrollPos + 0 < Departments.Count) ReturnIntIndex(scrollPos + 0);
            resetButtonColor();
            setButtonColor(button2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (scrollPos + 1 < Departments.Count) ReturnIntIndex(scrollPos + 1);
            resetButtonColor();
            setButtonColor(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (scrollPos + 2 < Departments.Count) ReturnIntIndex(scrollPos + 2);
            resetButtonColor();
            setButtonColor(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (scrollPos + 3 < Departments.Count) ReturnIntIndex(scrollPos + 3);
            resetButtonColor();
            setButtonColor(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (scrollPos + 4 < Departments.Count) ReturnIntIndex(scrollPos + 4);
            resetButtonColor();
            setButtonColor(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (scrollPos + 5 < Departments.Count) ReturnIntIndex(scrollPos + 5);
            resetButtonColor();
            setButtonColor(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (scrollPos + 6 < Departments.Count) ReturnIntIndex(scrollPos + 6);
            resetButtonColor();
            setButtonColor(button8); ;
        }


        private void btnUp_Click_1(object sender, EventArgs e)
        {
            CharButtonPressed('U');
            if (scrollPos > 6) scrollPos -= 7;
            
            resetButtonColor();
            updateButtons();
        }

        private void btnDown_Click_1(object sender, EventArgs e)
        {
            CharButtonPressed('D');
            if (scrollPos < Departments.Count - 7) scrollPos += 7;
            
            resetButtonColor();
            updateButtons();
        }

        private void setButtonColor(Button sender)
        {

            sender.BackColor = Color.Orange;
        }


        private void resetButtonColor()
        {
            button2.BackColor = Color.Khaki;
            button3.BackColor = Color.Khaki;
            button4.BackColor = Color.Khaki;
            button5.BackColor = Color.Khaki;
            button6.BackColor = Color.Khaki;
            button7.BackColor = Color.Khaki;
            button8.BackColor = Color.Khaki;

        }


        public void uploadDepartments(ArrayList depts)
        {
            scrollPos = 0;
            Departments = depts;
            updateButtons();
        }




    }

    
    
}
