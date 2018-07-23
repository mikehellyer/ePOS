namespace ePOS
{
    partial class frmQty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.registerKeypad1 = new Keypad.RegisterKeypad();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(103, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(88, 24);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Enter Qty";
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.Black;
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.Yellow;
            this.txtValue.Location = new System.Drawing.Point(12, 40);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(280, 41);
            this.txtValue.TabIndex = 2;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValue.WordWrap = false;
            // 
            // registerKeypad1
            // 
            this.registerKeypad1.buttons = 0;
            this.registerKeypad1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.registerKeypad1.Location = new System.Drawing.Point(12, 93);
            this.registerKeypad1.Name = "registerKeypad1";
            this.registerKeypad1.Size = new System.Drawing.Size(281, 282);
            this.registerKeypad1.TabIndex = 0;
            this.registerKeypad1.Load += new System.EventHandler(this.registerKeypad1_Load);
            this.registerKeypad1.CharButtonClicked += new System.Windows.Forms.KeyPressEventHandler(this.registerKeypad1_CharButtonClicked);
            // 
            // frmQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 387);
            this.ControlBox = false;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.registerKeypad1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Keypad.RegisterKeypad registerKeypad1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtValue;
    }
}