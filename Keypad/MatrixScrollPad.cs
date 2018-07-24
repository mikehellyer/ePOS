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
    public partial class MatrixScrollPad : GenericKeypad
    {
        private ArrayList Departments;
        private ArrayList optional_button_data; //store this is the tag field of each button
        private DataTable data_table;
        private int scrollPos = 0;
        
        public MatrixScrollPad()
        {
            InitializeComponent();
            SetAllControlsBackColor(this);
            
            
        }


        // Reset all the controls to the user's default Control color. 
        private void SetAllControlsBackColor(Control control)
        {
            control.BackColor = Color.DodgerBlue;
            //control.BackColor = SystemColors.Control;
            //control.ForeColor = SystemColors.ControlText;
            if (control.HasChildren)
            {
                // Recursively call this method for each child control.
                foreach (Control childControl in control.Controls)
                {
                    SetAllControlsBackColor(childControl);
                }
            }
        }


        
        private void updateButtons()
        {

            //button1
            if (scrollPos + 0 < Departments.Count) 
            { button1.Text = Departments[scrollPos + 0].ToString();
              //button1.Tag = optional_button_data[scrollPos + 0].ToString();
            } else 
            { 
                button1.Text = "";
                button1.Tag = "";
            }
            //button2
            if (scrollPos + 1 < Departments.Count)
            {
                button2.Text = Departments[scrollPos + 1].ToString();
                //button2.Tag = optional_button_data[scrollPos + 1].ToString();
            }
            else
            {
                button2.Text = "";
                button2.Tag = "";
            }

            //button3
            if (scrollPos + 2 < Departments.Count)
            {
                button3.Text = Departments[scrollPos + 2].ToString();
                //button3.Tag = optional_button_data[scrollPos + 2].ToString();
            }
            else
            {
                button3.Text = "";
                button3.Tag = "";
            }

            //button4
            if (scrollPos + 3 < Departments.Count)
            {
                button4.Text = Departments[scrollPos + 3].ToString();
                //button4.Tag = optional_button_data[scrollPos + 3].ToString();
            }
            else
            {
                button4.Text = "";
                button4.Tag = "";
            }

            //button5
            if (scrollPos + 4 < Departments.Count)
            {
                button5.Text = Departments[scrollPos + 4].ToString();
                //button5.Tag = optional_button_data[scrollPos + 4].ToString();
            }
            else
            {
                button5.Text = "";
                button5.Tag = "";
            }

            //button6
            if (scrollPos + 5 < Departments.Count)
            {
                button6.Text = Departments[scrollPos + 5].ToString();
                //button6.Tag = optional_button_data[scrollPos + 5].ToString();
            }
            else
            {
                button6.Text = "";
                button6.Tag = "";
            }
            
            //button7
            if (scrollPos + 6 < Departments.Count)
            {
                button7.Text = Departments[scrollPos + 6].ToString();
                //button7.Tag = optional_button_data[scrollPos + 6].ToString();
            }
            else
            {
                button7.Text = "";
                button7.Tag = "";
            }

            //button8
            if (scrollPos + 7 < Departments.Count)
            {
                button8.Text = Departments[scrollPos + 7].ToString();
                //button8.Tag = optional_button_data[scrollPos + 7].ToString();
            }
            else
            {
                button8.Text = "";
                button8.Tag = "";
            }

            //button9
            if (scrollPos + 8 < Departments.Count)
            {
                button9.Text = Departments[scrollPos + 8].ToString();
                //button9.Tag = optional_button_data[scrollPos + 8].ToString();
            }
            else
            {
                button9.Text = "";
                button9.Tag = "";
            }

            //button10
            if (scrollPos + 9 < Departments.Count)
            {
                button10.Text = Departments[scrollPos + 9].ToString();
                //button10.Tag = optional_button_data[scrollPos + 9].ToString();
            }
            else
            {
                button10.Text = "";
                button10.Tag = "";
            }

            //button11
            if (scrollPos + 10 < Departments.Count)
            {
                button11.Text = Departments[scrollPos + 10].ToString();
                //button11.Tag = optional_button_data[scrollPos + 10].ToString();
            }
            else
            {
                button11.Text = "";
                button11.Tag = "";
            }

            //button12
            if (scrollPos + 11 < Departments.Count)
            {
                button12.Text = Departments[scrollPos + 11].ToString();
                //button12.Tag = optional_button_data[scrollPos + 11].ToString();
            }
            else
            {
                button12.Text = "";
                button12.Tag = "";
            }

            //button13
            if (scrollPos + 12 < Departments.Count)
            {
                button13.Text = Departments[scrollPos + 12].ToString();
                //button13.Tag = optional_button_data[scrollPos + 12].ToString();
            }
            else
            {
                button13.Text = "";
                button13.Tag = "";
            }

            //button14
            if (scrollPos + 13 < Departments.Count)
            {
                button14.Text = Departments[scrollPos + 13].ToString();
                //button14.Tag = optional_button_data[scrollPos + 13].ToString();
            }
            else
            {
                button14.Text = "";
                button14.Tag = "";
            }

            //button15
            if (scrollPos + 14 < Departments.Count)
            {
                button15.Text = Departments[scrollPos + 14].ToString();
                //button15.Tag = optional_button_data[scrollPos + 14].ToString();
            }
            else
            {
                button15.Text = "";
                button15.Tag = "";
            }

            //button16
            if (scrollPos + 15 < Departments.Count)
            {
                button16.Text = Departments[scrollPos + 15].ToString();
                //button16.Tag = optional_button_data[scrollPos + 15].ToString();
            }
            else
            {
                button16.Text = "";
                button16.Tag = "";
            }

            //button17
            if (scrollPos + 16 < Departments.Count)
            {
                button17.Text = Departments[scrollPos + 16].ToString();
                //button17.Tag = optional_button_data[scrollPos + 16].ToString();
            }
            else
            {
                button17.Text = "";
                button17.Tag = "";
            }

            //button18
            if (scrollPos + 17 < Departments.Count)
            {
                button18.Text = Departments[scrollPos + 17].ToString();
                //button18.Tag = optional_button_data[scrollPos + 17].ToString();
            }
            else
            {
                button18.Text = "";
                button18.Tag = "";
            }

            //button19
            if (scrollPos + 18 < Departments.Count)
            {
                button19.Text = Departments[scrollPos + 18].ToString();
                //button19.Tag = optional_button_data[scrollPos + 18].ToString();
            }
            else
            {
                button19.Text = "";
                button19.Tag = "";
            }

            //button20
            if (scrollPos + 19 < Departments.Count)
            {
                button20.Text = Departments[scrollPos + 19].ToString();
                //button20.Tag = optional_button_data[scrollPos + 19].ToString();
            }
            else
            {
                button20.Text = "";
                button20.Tag = "";
            }

            //button21
            if (scrollPos + 20 < Departments.Count)
            {
                button21.Text = Departments[scrollPos + 20].ToString();
               // button21.Tag = optional_button_data[scrollPos + 20].ToString();
            }
            else
            {
                button21.Text = "";
                button21.Tag = "";
            }
            
            //button22
            if (scrollPos + 21 < Departments.Count)
            {
                button22.Text = Departments[scrollPos + 21].ToString();
                //button22.Tag = optional_button_data[scrollPos + 21].ToString();
            }
            else
            {
                button22.Text = "";
                button22.Tag = "";
            }
            //if (scrollPos + 1 < Departments.Count) { button2.Text = Departments[scrollPos + 1].ToString(); } else { button2.Text = ""; }
            //if (scrollPos + 2 < Departments.Count) { button3.Text = Departments[scrollPos + 2].ToString(); } else { button3.Text = ""; }
            //if (scrollPos + 3 < Departments.Count) { button4.Text = Departments[scrollPos + 3].ToString(); } else { button4.Text = ""; }
            //if (scrollPos + 4 < Departments.Count) { button5.Text = Departments[scrollPos + 4].ToString(); } else { button5.Text = ""; }
            //if (scrollPos + 5 < Departments.Count) { button6.Text = Departments[scrollPos + 5].ToString(); } else { button6.Text = ""; }
            //if (scrollPos + 6 < Departments.Count) { button7.Text = Departments[scrollPos + 6].ToString(); } else { button7.Text = ""; }
            //if (scrollPos + 7 < Departments.Count) { button8.Text = Departments[scrollPos + 7].ToString(); } else { button8.Text = ""; }

            //if (scrollPos + 8 < Departments.Count) { button9.Text = Departments[scrollPos + 8].ToString(); } else { button9.Text = ""; }
            //if (scrollPos + 9 < Departments.Count) { button10.Text = Departments[scrollPos + 9].ToString(); } else { button10.Text = ""; }
            //if (scrollPos + 10 < Departments.Count) { button11.Text = Departments[scrollPos + 10].ToString(); } else { button11.Text = ""; }
            //if (scrollPos + 11 < Departments.Count) { button12.Text = Departments[scrollPos + 11].ToString(); } else { button12.Text = ""; }
            //if (scrollPos + 12 < Departments.Count) { button13.Text = Departments[scrollPos + 12].ToString(); } else { button13.Text = ""; }
            //if (scrollPos + 13 < Departments.Count) { button14.Text = Departments[scrollPos + 13].ToString(); } else { button14.Text = ""; }
            //if (scrollPos + 14 < Departments.Count) { button15.Text = Departments[scrollPos + 14].ToString(); } else { button15.Text = ""; }
            //if (scrollPos + 15 < Departments.Count) { button16.Text = Departments[scrollPos + 15].ToString(); } else { button16.Text = ""; }

            //if (scrollPos + 16 < Departments.Count) { button17.Text = Departments[scrollPos + 16].ToString(); } else { button17.Text = ""; }
            //if (scrollPos + 17 < Departments.Count) { button18.Text = Departments[scrollPos + 17].ToString(); } else { button18.Text = ""; }
            //if (scrollPos + 18 < Departments.Count) { button19.Text = Departments[scrollPos + 18].ToString(); } else { button19.Text = ""; }
            //if (scrollPos + 19 < Departments.Count) { button20.Text = Departments[scrollPos + 19].ToString(); } else { button20.Text = ""; }
            //if (scrollPos + 20 < Departments.Count) { button21.Text = Departments[scrollPos + 20].ToString(); } else { button21.Text = ""; }
            //if (scrollPos + 21 < Departments.Count) { button22.Text = Departments[scrollPos + 21].ToString(); } else { button22.Text = ""; }
        
        }

        public void uploadDepartments(ArrayList depts)
        {
            scrollPos = 0;

            Departments = depts;
            updateButtons();
        }

        public void uploadDataTable(DataTable table)
        {
            scrollPos = 0;
            data_table = table;
            Departments = new ArrayList();
            optional_button_data = new ArrayList();
            foreach(DataRow row in data_table.Rows)
            {
                MessageBox.Show(row["description"].ToString());
                Departments.Add(row[1].ToString());
                optional_button_data.Add(row[0].ToString());
                
            }

            updateButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 0 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 0).ToString());
            if (scrollPos + 0 < Departments.Count) ReturnStringIndex((string)(button1.Tag));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 1 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 1).ToString());
            if (scrollPos + 1 < Departments.Count) ReturnStringIndex((string)(button2.Tag));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 2 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 2).ToString());
            if (scrollPos + 2 < Departments.Count) ReturnStringIndex((string)(button3.Tag));       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 3 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 3).ToString());
            if (scrollPos + 3 < Departments.Count) ReturnStringIndex((string)(button4.Tag));    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 4 < Departments.Count) ReturnStringIndex(calculateDepartm7entIndex(scrollPos + 4).ToString());
            if (scrollPos + 4 < Departments.Count) ReturnStringIndex((string)(button5.Tag));      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 5 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 5).ToString());
            if (scrollPos + 5 < Departments.Count) ReturnStringIndex((string)(button6.Tag));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 6 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 6).ToString());
            if (scrollPos + 6 < Departments.Count) ReturnStringIndex((string)(button7.Tag));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 7 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 7).ToString());
            if (scrollPos + 7 < Departments.Count) ReturnStringIndex((string)(button8.Tag)); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 8 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 8).ToString());
            if (scrollPos + 8 < Departments.Count) ReturnStringIndex((string)(button9.Tag));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 9 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 9).ToString());
            if (scrollPos + 9 < Departments.Count) ReturnStringIndex((string)(button10.Tag));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 10 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 10).ToString());
            if (scrollPos + 10 < Departments.Count) ReturnStringIndex((string)(button11.Tag));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 11 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 11).ToString());
            if (scrollPos + 11 < Departments.Count) ReturnStringIndex((string)(button12.Tag));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 12 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 12).ToString());
            if (scrollPos + 12 < Departments.Count) ReturnStringIndex((string)(button13.Tag));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 13 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 13).ToString());
            if (scrollPos + 13 < Departments.Count) ReturnStringIndex((string)(button14.Tag));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 14 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 14).ToString());
            if (scrollPos + 14 < Departments.Count) ReturnStringIndex((string)(button15.Tag));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 15 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 15).ToString());
            if (scrollPos + 15 < Departments.Count) ReturnStringIndex((string)(button16.Tag));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 16 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 16).ToString());
            if (scrollPos + 16 < Departments.Count) ReturnStringIndex((string)(button17.Tag));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 17 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 17).ToString());
            if (scrollPos + 17 < Departments.Count) ReturnStringIndex((string)(button18.Tag));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 18 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 18).ToString());
            if (scrollPos + 18 < Departments.Count) ReturnStringIndex((string)(button19.Tag));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 19 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 19).ToString());
            if (scrollPos + 19 < Departments.Count) ReturnStringIndex((string)(button20.Tag));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 20 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 20).ToString());
            if (scrollPos + 20 < Departments.Count) ReturnStringIndex((string)(button21.Tag));
        }
        
        private void button22_Click(object sender, EventArgs e)
        {
            //if (scrollPos + 21 < Departments.Count) ReturnStringIndex(calculateDepartmentIndex(scrollPos + 21).ToString());
            if (scrollPos + 21 < Departments.Count) ReturnStringIndex((string)(button22.Tag));        
        }
       

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CharButtonPressed('L');
            if (scrollPos > 21) scrollPos -= 22;
            updateButtons();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CharButtonPressed('R');
            if (scrollPos < Departments.Count - 22) scrollPos += 22;
            updateButtons();
        }

        private int calculateDepartmentIndex(int departmentIndex)
        {
           
            //parse the string returned from current department for index
            string element = Departments[departmentIndex].ToString();   
            string[] holder = (element.Split(new char[] { ' ' }));
            return departmentIndex;
  
        }


       
    }
}
