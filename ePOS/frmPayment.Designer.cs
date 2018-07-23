namespace ePOS
{
    partial class frmPayment
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
            this.btnCash = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCheque = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAmount = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(12, 25);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(97, 58);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            // 
            // btnDebit
            // 
            this.btnDebit.Location = new System.Drawing.Point(126, 25);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(97, 58);
            this.btnDebit.TabIndex = 1;
            this.btnDebit.Text = "Debit Card";
            this.btnDebit.UseVisualStyleBackColor = true;
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(238, 25);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(97, 58);
            this.btnCredit.TabIndex = 2;
            this.btnCredit.Text = "Credit Card";
            this.btnCredit.UseVisualStyleBackColor = true;
            // 
            // btnCheque
            // 
            this.btnCheque.Location = new System.Drawing.Point(341, 25);
            this.btnCheque.Name = "btnCheque";
            this.btnCheque.Size = new System.Drawing.Size(97, 58);
            this.btnCheque.TabIndex = 3;
            this.btnCheque.Text = "Cheque";
            this.btnCheque.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(341, 446);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 58);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(126, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 58);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAmount
            // 
            this.btnAmount.Location = new System.Drawing.Point(12, 124);
            this.btnAmount.Name = "btnAmount";
            this.btnAmount.Size = new System.Drawing.Size(97, 58);
            this.btnAmount.TabIndex = 6;
            this.btnAmount.Text = "Enter Amount";
            this.btnAmount.UseVisualStyleBackColor = true;
            this.btnAmount.Click += new System.EventHandler(this.btnAmount_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(21, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(75, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Payment Type";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(21, 94);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(87, 13);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Payment Amount";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 188);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(97, 58);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1.00";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(11, 252);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(97, 58);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2.00";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(12, 316);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(97, 58);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5.00";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(12, 380);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(97, 58);
            this.btn10.TabIndex = 13;
            this.btn10.Text = "10.00";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(12, 444);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(97, 58);
            this.btn20.TabIndex = 14;
            this.btn20.Text = "20.00";
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(115, 241);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 199);
            this.listBox1.TabIndex = 15;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(123, 225);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 16;
            this.lblMethod.Text = "Method";
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(316, 225);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(43, 13);
            this.lblAmt.TabIndex = 17;
            this.lblAmt.Text = "Amount";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 542);
            this.ControlBox = false;
            this.Controls.Add(this.lblAmt);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCheque);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.btnCash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCheque;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAmount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblAmt;
    }
}