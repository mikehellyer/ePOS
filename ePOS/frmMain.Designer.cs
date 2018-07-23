namespace ePOS
{
    partial class frmMain
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
            this.grpMenuHeading = new System.Windows.Forms.GroupBox();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnCloseTill = new System.Windows.Forms.Button();
            this.lbNo1 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpMenuHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuHeading
            // 
            this.grpMenuHeading.Controls.Add(this.lblMainMenu);
            this.grpMenuHeading.Location = new System.Drawing.Point(168, 70);
            this.grpMenuHeading.Name = "grpMenuHeading";
            this.grpMenuHeading.Size = new System.Drawing.Size(757, 97);
            this.grpMenuHeading.TabIndex = 0;
            this.grpMenuHeading.TabStop = false;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(251, 33);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(200, 37);
            this.lblMainMenu.TabIndex = 1;
            this.lblMainMenu.Text = "MAIN MENU";
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(426, 204);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(195, 44);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "&Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(426, 277);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(195, 44);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "&Products";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnCloseTill
            // 
            this.btnCloseTill.Location = new System.Drawing.Point(422, 422);
            this.btnCloseTill.Name = "btnCloseTill";
            this.btnCloseTill.Size = new System.Drawing.Size(195, 44);
            this.btnCloseTill.TabIndex = 3;
            this.btnCloseTill.Text = "&CloseTill";
            this.btnCloseTill.UseVisualStyleBackColor = true;
            this.btnCloseTill.Click += new System.EventHandler(this.btnCloseTill_Click);
            // 
            // lbNo1
            // 
            this.lbNo1.AutoSize = true;
            this.lbNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNo1.Location = new System.Drawing.Point(176, 297);
            this.lbNo1.Name = "lbNo1";
            this.lbNo1.Size = new System.Drawing.Size(204, 24);
            this.lbNo1.TabIndex = 6;
            this.lbNo1.Text = "Keeping ePOS Simple!";
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(424, 353);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(195, 44);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "&Reports and Setup";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ePOS.Properties.Resources.theEpos;
            this.pictureBox1.Location = new System.Drawing.Point(180, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.lbNo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseTill);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.grpMenuHeading);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The ePOS Thing !";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMenuHeading.ResumeLayout(false);
            this.grpMenuHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuHeading;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnCloseTill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNo1;
        private System.Windows.Forms.Button btnReports;

    }
}

