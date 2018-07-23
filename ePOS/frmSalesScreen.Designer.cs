namespace ePOS
{
    partial class frmSalesScreen
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
            this.richTextSales = new System.Windows.Forms.RichTextBox();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnFinishSale = new System.Windows.Forms.Button();
            this.btnLastReceipt = new System.Windows.Forms.Button();
            this.btnOpenTill = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDiscounts = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnAccountSale = new System.Windows.Forms.Button();
            this.btnQty = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubTotalAmount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.horizontalScrollPad1 = new Keypad.HorizontalScrollPad();
            this.matrixScrollPad1 = new Keypad.MatrixScrollPad();
            this.verticalScrollPad1 = new Keypad.VerticalScrollPad();
            this.btnRefund = new System.Windows.Forms.Button();
            this.lblTillNo = new System.Windows.Forms.Label();
            this.lblPOS = new System.Windows.Forms.Label();
            this.lblSaleTitle = new System.Windows.Forms.Label();
            this.lblSaleNo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextSales
            // 
            this.richTextSales.Location = new System.Drawing.Point(115, 30);
            this.richTextSales.Name = "richTextSales";
            this.richTextSales.ReadOnly = true;
            this.richTextSales.Size = new System.Drawing.Size(377, 339);
            this.richTextSales.TabIndex = 3;
            this.richTextSales.TabStop = false;
            this.richTextSales.Text = "";
            this.richTextSales.TextChanged += new System.EventHandler(this.richTextSales_TextChanged);
            this.richTextSales.Click += new System.EventHandler(this.richTextSales_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCancelSale.Location = new System.Drawing.Point(115, 530);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(117, 51);
            this.btnCancelSale.TabIndex = 4;
            this.btnCancelSale.TabStop = false;
            this.btnCancelSale.Text = "CANCEL SALE";
            this.btnCancelSale.UseVisualStyleBackColor = false;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // btnFinishSale
            // 
            this.btnFinishSale.BackColor = System.Drawing.Color.PowderBlue;
            this.btnFinishSale.Location = new System.Drawing.Point(492, 530);
            this.btnFinishSale.Name = "btnFinishSale";
            this.btnFinishSale.Size = new System.Drawing.Size(117, 51);
            this.btnFinishSale.TabIndex = 5;
            this.btnFinishSale.TabStop = false;
            this.btnFinishSale.Text = "FINISH SALE";
            this.btnFinishSale.UseVisualStyleBackColor = false;
            this.btnFinishSale.Click += new System.EventHandler(this.btnFinishSale_Click);
            // 
            // btnLastReceipt
            // 
            this.btnLastReceipt.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLastReceipt.Location = new System.Drawing.Point(653, 474);
            this.btnLastReceipt.Name = "btnLastReceipt";
            this.btnLastReceipt.Size = new System.Drawing.Size(117, 51);
            this.btnLastReceipt.TabIndex = 6;
            this.btnLastReceipt.TabStop = false;
            this.btnLastReceipt.Text = "PRINT LAST RECEIPT";
            this.btnLastReceipt.UseVisualStyleBackColor = false;
            this.btnLastReceipt.Click += new System.EventHandler(this.btnLastReceipt_Click);
            // 
            // btnOpenTill
            // 
            this.btnOpenTill.BackColor = System.Drawing.Color.PowderBlue;
            this.btnOpenTill.Location = new System.Drawing.Point(653, 530);
            this.btnOpenTill.Name = "btnOpenTill";
            this.btnOpenTill.Size = new System.Drawing.Size(117, 51);
            this.btnOpenTill.TabIndex = 7;
            this.btnOpenTill.TabStop = false;
            this.btnOpenTill.Text = "OPEN TILL DRAWER";
            this.btnOpenTill.UseVisualStyleBackColor = false;
            this.btnOpenTill.Click += new System.EventHandler(this.btnOpenTill_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.PowderBlue;
            this.btnFind.Location = new System.Drawing.Point(775, 474);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(117, 51);
            this.btnFind.TabIndex = 8;
            this.btnFind.TabStop = false;
            this.btnFind.Text = "FIND ITEM";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDiscounts
            // 
            this.btnDiscounts.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDiscounts.Location = new System.Drawing.Point(775, 530);
            this.btnDiscounts.Name = "btnDiscounts";
            this.btnDiscounts.Size = new System.Drawing.Size(117, 51);
            this.btnDiscounts.TabIndex = 9;
            this.btnDiscounts.TabStop = false;
            this.btnDiscounts.Text = "DISCOUNTS";
            this.btnDiscounts.UseVisualStyleBackColor = false;
            this.btnDiscounts.Click += new System.EventHandler(this.btnDiscounts_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVoid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnVoid.Location = new System.Drawing.Point(366, 473);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(117, 51);
            this.btnVoid.TabIndex = 10;
            this.btnVoid.TabStop = false;
            this.btnVoid.Text = "VOID ITEM";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnAccountSale
            // 
            this.btnAccountSale.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAccountSale.Location = new System.Drawing.Point(366, 530);
            this.btnAccountSale.Name = "btnAccountSale";
            this.btnAccountSale.Size = new System.Drawing.Size(117, 51);
            this.btnAccountSale.TabIndex = 11;
            this.btnAccountSale.TabStop = false;
            this.btnAccountSale.Text = "SALE ON ACCOUNT";
            this.btnAccountSale.UseVisualStyleBackColor = false;
            this.btnAccountSale.Click += new System.EventHandler(this.btnAccountSale_Click);
            // 
            // btnQty
            // 
            this.btnQty.BackColor = System.Drawing.Color.PowderBlue;
            this.btnQty.Location = new System.Drawing.Point(492, 473);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(117, 51);
            this.btnQty.TabIndex = 12;
            this.btnQty.TabStop = false;
            this.btnQty.Text = "QTY";
            this.btnQty.UseVisualStyleBackColor = false;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSubTotalAmount);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Location = new System.Drawing.Point(317, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 47);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "£";
            // 
            // lblSubTotalAmount
            // 
            this.lblSubTotalAmount.AutoSize = true;
            this.lblSubTotalAmount.Location = new System.Drawing.Point(115, 15);
            this.lblSubTotalAmount.Name = "lblSubTotalAmount";
            this.lblSubTotalAmount.Size = new System.Drawing.Size(28, 13);
            this.lblSubTotalAmount.TabIndex = 2;
            this.lblSubTotalAmount.Text = "0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(8, 15);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(56, 13);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "Sub Total:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblItemCount);
            this.panel2.Controls.Add(this.lblItems);
            this.panel2.Location = new System.Drawing.Point(115, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 47);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(134, 15);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(13, 13);
            this.lblItemCount.TabIndex = 1;
            this.lblItemCount.Text = "0";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(67, 15);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(35, 13);
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "Items:";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(199, 436);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(112, 13);
            this.lblPrompt.TabIndex = 15;
            this.lblPrompt.Text = "Scan In Product Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // horizontalScrollPad1
            // 
            this.horizontalScrollPad1.buttons = 0;
            this.horizontalScrollPad1.Location = new System.Drawing.Point(115, 587);
            this.horizontalScrollPad1.Name = "horizontalScrollPad1";
            this.horizontalScrollPad1.Size = new System.Drawing.Size(798, 54);
            this.horizontalScrollPad1.TabIndex = 2;
            this.horizontalScrollPad1.TabStop = false;
            this.horizontalScrollPad1.Load += new System.EventHandler(this.horizontalScrollPad1_Load);
            this.horizontalScrollPad1.CharButtonClicked += new System.Windows.Forms.KeyPressEventHandler(this.horizontalScrollPad1_ArrowButtonClicked);
            this.horizontalScrollPad1.ButtonClicked += new Keypad.GenericKeypad.IntegerReturnEventHandler(this.horizontalScrollPad1_ButtonClicked);
            // 
            // matrixScrollPad1
            // 
            this.matrixScrollPad1.BackColor = System.Drawing.Color.DodgerBlue;
            this.matrixScrollPad1.buttons = 0;
            this.matrixScrollPad1.Location = new System.Drawing.Point(612, 30);
            this.matrixScrollPad1.Name = "matrixScrollPad1";
            this.matrixScrollPad1.Size = new System.Drawing.Size(289, 438);
            this.matrixScrollPad1.TabIndex = 1;
            this.matrixScrollPad1.TabStop = false;
            this.matrixScrollPad1.CharButtonClicked += new System.Windows.Forms.KeyPressEventHandler(this.matrixScrollPad1_ArrowButtonClicked);
            this.matrixScrollPad1.ButtonClicked += new Keypad.GenericKeypad.IntegerReturnEventHandler(this.matrixScrollPad1_ButtonClicked);
            // 
            // verticalScrollPad1
            // 
            this.verticalScrollPad1.buttons = 0;
            this.verticalScrollPad1.Location = new System.Drawing.Point(495, 30);
            this.verticalScrollPad1.Name = "verticalScrollPad1";
            this.verticalScrollPad1.Size = new System.Drawing.Size(120, 444);
            this.verticalScrollPad1.TabIndex = 0;
            this.verticalScrollPad1.TabStop = false;
            this.verticalScrollPad1.Load += new System.EventHandler(this.verticalScrollPad1_Load);
            this.verticalScrollPad1.CharButtonClicked += new System.Windows.Forms.KeyPressEventHandler(this.verticalScrollPad1_ArrowButtonClicked);
            this.verticalScrollPad1.ButtonClicked += new Keypad.GenericKeypad.IntegerReturnEventHandler(this.verticalScrollPad1_ButtonClicked);
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRefund.Location = new System.Drawing.Point(243, 530);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(117, 51);
            this.btnRefund.TabIndex = 16;
            this.btnRefund.TabStop = false;
            this.btnRefund.Text = "REFUND";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnSaleRefund_Click);
            // 
            // lblTillNo
            // 
            this.lblTillNo.AutoSize = true;
            this.lblTillNo.Location = new System.Drawing.Point(96, 43);
            this.lblTillNo.Name = "lblTillNo";
            this.lblTillNo.Size = new System.Drawing.Size(13, 13);
            this.lblTillNo.TabIndex = 17;
            this.lblTillNo.Text = "1";
            // 
            // lblPOS
            // 
            this.lblPOS.AutoSize = true;
            this.lblPOS.Location = new System.Drawing.Point(12, 43);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(40, 13);
            this.lblPOS.TabIndex = 18;
            this.lblPOS.Text = "Till No:";
            // 
            // lblSaleTitle
            // 
            this.lblSaleTitle.AutoSize = true;
            this.lblSaleTitle.Location = new System.Drawing.Point(12, 74);
            this.lblSaleTitle.Name = "lblSaleTitle";
            this.lblSaleTitle.Size = new System.Drawing.Size(48, 13);
            this.lblSaleTitle.TabIndex = 19;
            this.lblSaleTitle.Text = "Sale No:";
            // 
            // lblSaleNo
            // 
            this.lblSaleNo.AutoSize = true;
            this.lblSaleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleNo.Location = new System.Drawing.Point(95, 74);
            this.lblSaleNo.Name = "lblSaleNo";
            this.lblSaleNo.Size = new System.Drawing.Size(14, 13);
            this.lblSaleNo.TabIndex = 20;
            this.lblSaleNo.Text = "0";
            this.lblSaleNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSalesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.ControlBox = false;
            this.Controls.Add(this.lblSaleNo);
            this.Controls.Add(this.lblSaleTitle);
            this.Controls.Add(this.lblPOS);
            this.Controls.Add(this.lblTillNo);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQty);
            this.Controls.Add(this.btnAccountSale);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnDiscounts);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnOpenTill);
            this.Controls.Add(this.btnLastReceipt);
            this.Controls.Add(this.btnFinishSale);
            this.Controls.Add(this.btnCancelSale);
            this.Controls.Add(this.richTextSales);
            this.Controls.Add(this.horizontalScrollPad1);
            this.Controls.Add(this.matrixScrollPad1);
            this.Controls.Add(this.verticalScrollPad1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SalesScreen";
            this.Load += new System.EventHandler(this.SalesScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Keypad.VerticalScrollPad verticalScrollPad1;
        private Keypad.MatrixScrollPad matrixScrollPad1;
        private Keypad.HorizontalScrollPad horizontalScrollPad1;
        private System.Windows.Forms.RichTextBox richTextSales;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Button btnFinishSale;
        private System.Windows.Forms.Button btnLastReceipt;
        private System.Windows.Forms.Button btnOpenTill;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDiscounts;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnAccountSale;
        private System.Windows.Forms.Button btnQty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblSubTotalAmount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Label lblTillNo;
        private System.Windows.Forms.Label lblPOS;
        private System.Windows.Forms.Label lblSaleTitle;
        private System.Windows.Forms.Label lblSaleNo;

    }
}