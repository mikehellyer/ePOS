namespace ePOS
{
    partial class frmProductsForm
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
            this.lblProducts = new System.Windows.Forms.Label();
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.grpFooter = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMenuHeading.SuspendLayout();
            this.grpLeft.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.grpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMenuHeading
            // 
            this.grpMenuHeading.Controls.Add(this.lblProducts);
            this.grpMenuHeading.Location = new System.Drawing.Point(150, 71);
            this.grpMenuHeading.Name = "grpMenuHeading";
            this.grpMenuHeading.Size = new System.Drawing.Size(757, 97);
            this.grpMenuHeading.TabIndex = 1;
            this.grpMenuHeading.TabStop = false;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(199, 30);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(418, 37);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "PRODUCT MAINTENANCE";
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.btnDelivery);
            this.grpLeft.Controls.Add(this.btnView);
            this.grpLeft.Controls.Add(this.btnDelete);
            this.grpLeft.Controls.Add(this.btnModify);
            this.grpLeft.Controls.Add(this.btnAdd);
            this.grpLeft.Location = new System.Drawing.Point(150, 174);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(359, 362);
            this.grpLeft.TabIndex = 2;
            this.grpLeft.TabStop = false;
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(84, 295);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(195, 44);
            this.btnDelivery.TabIndex = 6;
            this.btnDelivery.Text = "&Stock Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(84, 233);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(195, 44);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "&View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 44);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(84, 91);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(195, 44);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(195, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpRight
            // 
            this.grpRight.Controls.Add(this.btnSuppliers);
            this.grpRight.Controls.Add(this.btnCategory);
            this.grpRight.Location = new System.Drawing.Point(525, 174);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(382, 362);
            this.grpRight.TabIndex = 3;
            this.grpRight.TabStop = false;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(84, 91);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(195, 44);
            this.btnSuppliers.TabIndex = 6;
            this.btnSuppliers.Text = "Supplier &Codes";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(84, 19);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(195, 44);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Category/Dept C&odes";
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // grpFooter
            // 
            this.grpFooter.Controls.Add(this.btnExit);
            this.grpFooter.Location = new System.Drawing.Point(150, 542);
            this.grpFooter.Name = "grpFooter";
            this.grpFooter.Size = new System.Drawing.Size(757, 54);
            this.grpFooter.TabIndex = 4;
            this.grpFooter.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(297, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.grpFooter);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpLeft);
            this.Controls.Add(this.grpMenuHeading);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.grpMenuHeading.ResumeLayout(false);
            this.grpMenuHeading.PerformLayout();
            this.grpLeft.ResumeLayout(false);
            this.grpRight.ResumeLayout(false);
            this.grpFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuHeading;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.GroupBox grpFooter;
        private System.Windows.Forms.Button btnExit;
    }
}