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
    public partial class GenericKeypad : UserControl
    {
        //This is how to create your own eventhandler
        public delegate void IntegerReturnEventHandler(int index);
        public delegate void StringReturnEventHandler(string index);
        
        int _buttons;
        string _button;
        
        public GenericKeypad()
        {
            InitializeComponent();
        }

        #region Events
        
        //set up events to allow returning of ints or strings
        public event KeyPressEventHandler CharButtonClicked;
        public event IntegerReturnEventHandler ButtonClicked;
        public event StringReturnEventHandler button_returns_string; 


        #endregion Events

        #region Methods
        
        //Maps CharButtonPressed to WhatToSend
        public void CharButtonPressed(char WhatToSend)
        {
            KeyPressEventHandler handler = CharButtonClicked;
            if (handler != null)
            {
                handler(this,new KeyPressEventArgs(WhatToSend));
            }
        }
        
        public void ReturnIntIndex(int WhatToSend)
        {
            
            if(ButtonClicked != null)
            {
                ButtonClicked(WhatToSend);
            }
        }
        
        public void ReturnStringIndex(string WhatToSend)
        {
            if (button_returns_string != null)
            {
                button_returns_string(WhatToSend);
            }

        }

        #endregion Methods

        public int buttons
        {
            get
            {
                return _buttons;
            }
            set
            {
                _buttons = value;
            }
        }
        
        public string button
        {
            get
            {
                return _button;
            }
            set
            {
                _button = value;
            }
        }


    }

    public class Super_Button : System.Windows.Forms.Button
    {
        string Text2 { get; set; }
    }
}
