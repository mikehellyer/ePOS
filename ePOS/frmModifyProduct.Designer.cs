namespace ePOS
{
    partial class frmModifyProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifyProduct));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.tbl_ItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new ePOS.DataDataSet();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.txtVATRate = new System.Windows.Forms.TextBox();
            this.lblVATRate = new System.Windows.Forms.Label();
            this.cmbTaxCode = new System.Windows.Forms.ComboBox();
            this.tbl_TaxDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.txtMinOrderQty = new System.Windows.Forms.TextBox();
            this.lblMinOrderQty = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTaxCode = new System.Windows.Forms.Label();
            this.txtBoxCostprice = new System.Windows.Forms.TextBox();
            this.txtMinStockLevel = new System.Windows.Forms.TextBox();
            this.lblMinStockLevel = new System.Windows.Forms.Label();
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.cmbBarcode = new System.Windows.Forms.ComboBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbSupplierCode = new System.Windows.Forms.ComboBox();
            this.tbl_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEnterSupplierCode = new System.Windows.Forms.Label();
            this.cmbDeptCode = new System.Windows.Forms.ComboBox();
            this.tbl_DepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDeptCode = new System.Windows.Forms.Label();
            this.txtReorder = new System.Windows.Forms.TextBox();
            this.lblCatalogue = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.grpFooter = new System.Windows.Forms.GroupBox();
            this.grpMenuHeading = new System.Windows.Forms.GroupBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.tbl_ItemsTableAdapter = new ePOS.DataDataSetTableAdapters.tbl_ItemsTableAdapter();
            this.tableAdapterManager = new ePOS.DataDataSetTableAdapters.TableAdapterManager();
            this.tbl_DepartmentsTableAdapter = new ePOS.DataDataSetTableAdapters.tbl_DepartmentsTableAdapter();
            this.tbl_SuppliersTableAdapter = new ePOS.DataDataSetTableAdapters.tbl_SuppliersTableAdapter();
            this.tbl_TaxDetailsTableAdapter = new ePOS.DataDataSetTableAdapters.tbl_TaxDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_TaxDetailsBindingSource)).BeginInit();
            this.grpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DepartmentsBindingSource)).BeginInit();
            this.grpFooter.SuspendLayout();
            this.grpMenuHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(654, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(654, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Enter += new System.EventHandler(this.btnSave_Enter);
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ItemsBindingSource, "RetailPrice", true));
            this.txtRetailPrice.Location = new System.Drawing.Point(12, 345);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(136, 20);
            this.txtRetailPrice.TabIndex = 11;
            this.txtRetailPrice.Leave += new System.EventHandler(this.txtRetailPrice_Leave);
            this.txtRetailPrice.Enter += new System.EventHandler(this.txtRetailPrice_Enter);
            // 
            // tbl_ItemsBindingSource
            // 
            this.tbl_ItemsBindingSource.AllowNew = true;
            this.tbl_ItemsBindingSource.DataMember = "tbl_Items";
            this.tbl_ItemsBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Location = new System.Drawing.Point(14, 329);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(61, 13);
            this.lblRetailPrice.TabIndex = 21;
            this.lblRetailPrice.Text = "Retail Price";
            // 
            // txtVATRate
            // 
            this.txtVATRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ItemsBindingSource, "VATRate", true));
            this.txtVATRate.Location = new System.Drawing.Point(366, 294);
            this.txtVATRate.Name = "txtVATRate";
            this.txtVATRate.Size = new System.Drawing.Size(108, 20);
            this.txtVATRate.TabIndex = 10;
            this.txtVATRate.Leave += new System.EventHandler(this.txtVATRate_Leave);
            this.txtVATRate.Enter += new System.EventHandler(this.txtVATRate_Enter);
            // 
            // lblVATRate
            // 
            this.lblVATRate.AutoSize = true;
            this.lblVATRate.Location = new System.Drawing.Point(363, 278);
            this.lblVATRate.Name = "lblVATRate";
            this.lblVATRate.Size = new System.Drawing.Size(65, 13);
            this.lblVATRate.TabIndex = 19;
            this.lblVATRate.Text = "VAT Rate %";
            // 
            // cmbTaxCode
            // 
            this.cmbTaxCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ItemsBindingSource, "TaxCode", true));
            this.cmbTaxCode.DataSource = this.tbl_TaxDetailsBindingSource;
            this.cmbTaxCode.DisplayMember = "TaxCode";
            this.cmbTaxCode.FormattingEnabled = true;
            this.cmbTaxCode.Location = new System.Drawing.Point(199, 294);
            this.cmbTaxCode.Name = "cmbTaxCode";
            this.cmbTaxCode.Size = new System.Drawing.Size(121, 21);
            this.cmbTaxCode.TabIndex = 9;
            this.cmbTaxCode.Leave += new System.EventHandler(this.cmbTaxCode_Leave);
            this.cmbTaxCode.Enter += new System.EventHandler(this.cmbTaxCode_Enter);
            // 
            // tbl_TaxDetailsBindingSource
            // 
            this.tbl_TaxDetailsBindingSource.DataMember = "tbl_TaxDetails";
            this.tbl_TaxDetailsBindingSource.DataSource = this.dataDataSet;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(9, 279);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(55, 13);
            this.lblCostPrice.TabIndex = 15;
            this.lblCostPrice.Text = "Cost Price";
            // 
            // txtMinOrderQty
            // 
            this.txtMinOrderQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ItemsBindingSource, "MinimumOrderQty", true));
            this.txtMinOrderQty.Location = new System.Drawing.Point(199, 226);
            this.txtMinOrderQty.Name = "txtMinOrderQty";
            this.txtMinOrderQty.Size = new System.Drawing.Size(136, 20);
            this.txtMinOrderQty.TabIndex = 7;
            this.txtMinOrderQty.Leave += new System.EventHandler(this.txtMinOrderQty_Leave);
            this.txtMinOrderQty.Enter += new System.EventHandler(this.txtMinOrderQty_Enter);
            // 
            // lblMinOrderQty
            // 
            this.lblMinOrderQty.AutoSize = true;
            this.lblMinOrderQty.Location = new System.Drawing.Point(196, 210);
            this.lblMinOrderQty.Name = "lblMinOrderQty";
            this.lblMinOrderQty.Size = new System.Drawing.Size(75, 13);
            this.lblMinOrderQty.TabIndex = 13;
            this.lblMinOrderQty.Text = "Min Order Qty:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(297, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Products Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTaxCode
            // 
            this.lblTaxCode.AutoSize = true;
            this.lblTaxCode.Location = new System.Drawing.Point(196, 279);
            this.lblTaxCode.Name = "lblTaxCode";
            this.lblTaxCode.Size = new System.Drawing.Size(53, 13);
            this.lblTaxCode.TabIndex = 17;
            this.lblTaxCode.Text = "Tax Code";
            // 
            // txtBoxCostprice
            // 
            this.txtBoxCostprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ItemsBindingSource, "CostPrice", true));
            this.txtBoxCostprice.Location = new System.Drawing.Point(12, 295);
            this.txtBoxCostprice.Name = "txtBoxCostprice";
            this.txtBoxCostprice.Size = new System.Drawing.Size(136, 20);
            this.txtBoxCostprice.TabIndex = 8;
            this.txtBoxCostprice.Leave += new System.EventHandler(this.txtBoxCostprice_Leave);
            this.txtBoxCostprice.Enter += new System.EventHandler(this.txtBoxCostprice_Enter);
            // 
            // txtMinStockLevel
            // 
            this.txtMinStockLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ItemsBindingSource, "MinimumStockLevel", true));
            this.txtMinStockLevel.Location = new System.Drawing.Point(12, 226);
            this.txtMinStockLevel.Name = "txtMinStockLevel";
            this.txtMinStockLevel.Size = new System.Drawing.Size(136, 20);
            this.txtMinStockLevel.TabIndex = 6;
            this.txtMinStockLevel.Leave += new System.EventHandler(this.txtMinStockLevel_Leave);
            this.txtMinStockLevel.Enter += new System.EventHandler(this.txtMinStockLevel_Enter);
            // 
            // lblMinStockLevel
            // 
            this.lblMinStockLevel.AutoSize = true;
            this.lblMinStockLevel.Location = new System.Drawing.Point(9, 210);
            this.lblMinStockLevel.Name = "lblMinStockLevel";
            this.lblMinStockLevel.Size = new System.Drawing.Size(84, 13);
            this.lblMinStockLevel.TabIndex = 11;
            this.lblMinStockLevel.Text = "Min Stock Level";
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.cmbBarcode);
            this.grpLeft.Controls.Add(this.bindingNavigator1);
            this.grpLeft.Controls.Add(this.btnCancel);
            this.grpLeft.Controls.Add(this.btnSave);
            this.grpLeft.Controls.Add(this.txtRetailPrice);
            this.grpLeft.Controls.Add(this.lblRetailPrice);
            this.grpLeft.Controls.Add(this.txtVATRate);
            this.grpLeft.Controls.Add(this.lblVATRate);
            this.grpLeft.Controls.Add(this.cmbTaxCode);
            this.grpLeft.Controls.Add(this.lblTaxCode);
            this.grpLeft.Controls.Add(this.txtBoxCostprice);
            this.grpLeft.Controls.Add(this.lblCostPrice);
            this.grpLeft.Controls.Add(this.txtMinOrderQty);
            this.grpLeft.Controls.Add(this.lblMinOrderQty);
            this.grpLeft.Controls.Add(this.txtMinStockLevel);
            this.grpLeft.Controls.Add(this.lblMinStockLevel);
            this.grpLeft.Controls.Add(this.cmbSupplierCode);
            this.grpLeft.Controls.Add(this.lblEnterSupplierCode);
            this.grpLeft.Controls.Add(this.cmbDeptCode);
            this.grpLeft.Controls.Add(this.lblDeptCode);
            this.grpLeft.Controls.Add(this.txtReorder);
            this.grpLeft.Controls.Add(this.lblCatalogue);
            this.grpLeft.Controls.Add(this.txtDescription);
            this.grpLeft.Controls.Add(this.lblDescription);
            this.grpLeft.Controls.Add(this.lblBarcode);
            this.grpLeft.Location = new System.Drawing.Point(140, 134);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(757, 380);
            this.grpLeft.TabIndex = 10;
            this.grpLeft.TabStop = false;
            // 
            // cmbBarcode
            // 
            this.cmbBarcode.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBarcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ItemsBindingSource, "StockRef", true));
            this.cmbBarcode.DataSource = this.tbl_ItemsBindingSource;
            this.cmbBarcode.DisplayMember = "StockRef";
            this.cmbBarcode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbBarcode.FormattingEnabled = true;
            this.cmbBarcode.Location = new System.Drawing.Point(12, 71);
            this.cmbBarcode.Name = "cmbBarcode";
            this.cmbBarcode.Size = new System.Drawing.Size(148, 21);
            this.cmbBarcode.TabIndex = 1;
            this.cmbBarcode.SelectionChangeCommitted += new System.EventHandler(this.cmbBarcode_SelectionChangeCommitted);
            this.cmbBarcode.SelectedIndexChanged += new System.EventHandler(this.cmbBarcode_SelectedIndexChanged);
            this.cmbBarcode.Leave += new System.EventHandler(this.cmbBarcode_Leave);
            this.cmbBarcode.Enter += new System.EventHandler(this.cmbBarcode_Enter);
            this.cmbBarcode.SelectedValueChanged += new System.EventHandler(this.cmbBarcode_SelectedValueChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BindingSource = this.tbl_ItemsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(211, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(276, 31);
            this.bindingNavigator1.TabIndex = 25;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // cmbSupplierCode
            // 
            this.cmbSupplierCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_ItemsBindingSource, "SupplierCode", true));
            this.cmbSupplierCode.DataSource = this.tbl_SuppliersBindingSource;
            this.cmbSupplierCode.DisplayMember = "SupplierCode";
            this.cmbSupplierCode.FormattingEnabled = true;
            this.cmbSupplierCode.Location = new System.Drawing.Point(366, 172);
            this.cmbSupplierCode.Name = "cmbSupplierCode";
            this.cmbSupplierCode.Size = new System.Drawing.Size(121, 21);
            this.cmbSupplierCode.TabIndex = 5;
            this.cmbSupplierCode.ValueMember = "SupplierCode";
            this.cmbSupplierCode.Leave += new System.EventHandler(this.cmbSupplierCode_Leave);
            this.cmbSupplierCode.Enter += new System.EventHandler(this.cmbSupplierCode_Enter);
            // 
            // tbl_SuppliersBindingSource
            // 
            this.tbl_SuppliersBindingSource.DataMember = "tbl_Suppliers";
            this.tbl_SuppliersBindingSource.DataSource = this.dataDataSet;
            // 
            // lblEnterSupplierCode
            // 
            this.lblEnterSupplierCode.AutoSize = true;
            this.lblEnterSupplierCode.Location = new System.Drawing.Point(363, 156);
            this.lblEnterSupplierCode.Name = "lblEnterSupplierCode";
            this.lblEnterSupplierCode.Size = new System.Drawing.Size(101, 13);
            this.lblEnterSupplierCode.TabIndex = 9;
            this.lblEnterSupplierCode.Text = "Enter Supplier Code";
            // 
            // cmbDeptCode
            // 
            this.cmbDeptCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ItemsBindingSource, "DeptCode", true));
            this.cmbDeptCode.DataSource = this.tbl_DepartmentsBindingSource;
            this.cmbDeptCode.DisplayMember = "DepartmentCode";
            this.cmbDeptCode.FormattingEnabled = true;
            this.cmbDeptCode.Location = new System.Drawing.Point(199, 172);
            this.cmbDeptCode.Name = "cmbDeptCode";
            this.cmbDeptCode.Size = new System.Drawing.Size(121, 21);
            this.cmbDeptCode.TabIndex = 4;
            this.cmbDeptCode.ValueMember = "DepartmentCode";
            this.cmbDeptCode.Leave += new System.EventHandler(this.cmbDeptCode_Leave);
            this.cmbDeptCode.Enter += new System.EventHandler(this.cmbDeptCode_Enter);
            // 
            // tbl_DepartmentsBindingSource
            // 
            this.tbl_DepartmentsBindingSource.DataMember = "tbl_Departments";
            this.tbl_DepartmentsBindingSource.DataSource = this.dataDataSet;
            // 
            // lblDeptCode
            // 
            this.lblDeptCode.AutoSize = true;
            this.lblDeptCode.Location = new System.Drawing.Point(196, 156);
            this.lblDeptCode.Name = "lblDeptCode";
            this.lblDeptCode.Size = new System.Drawing.Size(86, 13);
            this.lblDeptCode.TabIndex = 7;
            this.lblDeptCode.Text = "Enter Dept Code";
            // 
            // txtReorder
            // 
            this.txtReorder.Location = new System.Drawing.Point(12, 172);
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.Size = new System.Drawing.Size(136, 20);
            this.txtReorder.TabIndex = 3;
            this.txtReorder.Leave += new System.EventHandler(this.txtReorder_Leave);
            this.txtReorder.Enter += new System.EventHandler(this.txtReorder_Enter);
            // 
            // lblCatalogue
            // 
            this.lblCatalogue.AutoSize = true;
            this.lblCatalogue.Location = new System.Drawing.Point(9, 156);
            this.lblCatalogue.Name = "lblCatalogue";
            this.lblCatalogue.Size = new System.Drawing.Size(73, 13);
            this.lblCatalogue.TabIndex = 5;
            this.lblCatalogue.Text = "Reorder Code";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ItemsBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(9, 124);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(337, 20);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 108);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(9, 55);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(151, 13);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "Enter Barcode / Product Code";
            // 
            // grpFooter
            // 
            this.grpFooter.Controls.Add(this.btnExit);
            this.grpFooter.Location = new System.Drawing.Point(140, 520);
            this.grpFooter.Name = "grpFooter";
            this.grpFooter.Size = new System.Drawing.Size(757, 54);
            this.grpFooter.TabIndex = 11;
            this.grpFooter.TabStop = false;
            // 
            // grpMenuHeading
            // 
            this.grpMenuHeading.Controls.Add(this.lblProducts);
            this.grpMenuHeading.Location = new System.Drawing.Point(140, 49);
            this.grpMenuHeading.Name = "grpMenuHeading";
            this.grpMenuHeading.Size = new System.Drawing.Size(757, 79);
            this.grpMenuHeading.TabIndex = 9;
            this.grpMenuHeading.TabStop = false;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(199, 30);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(307, 37);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "MODIFY PRODUCT";
            this.lblProducts.Click += new System.EventHandler(this.lblProducts_Click);
            // 
            // tbl_ItemsTableAdapter
            // 
            this.tbl_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_AddHocRefundsDetailsTableAdapter = null;
            this.tableAdapterManager.tbl_AddHocReturnsTableAdapter = null;
            this.tableAdapterManager.tbl_AdditionalBarcodesTableAdapter = null;
            this.tableAdapterManager.tbl_BackGroundColoursTableAdapter = null;
            this.tableAdapterManager.tbl_BarcodesTableAdapter = null;
            this.tableAdapterManager.tbl_CurrencyConversionTableAdapter = null;
            this.tableAdapterManager.tbl_DefaultScreenTableAdapter = null;
            this.tableAdapterManager.tbl_DepartmentsTableAdapter = this.tbl_DepartmentsTableAdapter;
            this.tableAdapterManager.tbl_InvoicePaymentsTableAdapter = null;
            this.tableAdapterManager.tbl_InvoicesTableAdapter = null;
            this.tableAdapterManager.tbl_ItemsTableAdapter = this.tbl_ItemsTableAdapter;
            this.tableAdapterManager.tbl_LayerProtectionTableAdapter = null;
            this.tableAdapterManager.tbl_LoyaltyTableAdapter = null;
            this.tableAdapterManager.tbl_PaymentsTableAdapter = null;
            this.tableAdapterManager.tbl_SalesLinesTableAdapter = null;
            this.tableAdapterManager.tbl_SerialNumbersTableAdapter = null;
            this.tableAdapterManager.tbl_SetUpTableAdapter = null;
            this.tableAdapterManager.tbl_SuppliersTableAdapter = this.tbl_SuppliersTableAdapter;
            this.tableAdapterManager.tbl_TaxDetailsTableAdapter = this.tbl_TaxDetailsTableAdapter;
            this.tableAdapterManager.tbl_TextColoursTableAdapter = null;
            this.tableAdapterManager.tbl_TokenTableAdapter = null;
            this.tableAdapterManager.tbl_ZResetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ePOS.DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_DepartmentsTableAdapter
            // 
            this.tbl_DepartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_SuppliersTableAdapter
            // 
            this.tbl_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_TaxDetailsTableAdapter
            // 
            this.tbl_TaxDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.grpLeft);
            this.Controls.Add(this.grpFooter);
            this.Controls.Add(this.grpMenuHeading);
            this.Name = "ModifyProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyProduct";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_TaxDetailsBindingSource)).EndInit();
            this.grpLeft.ResumeLayout(false);
            this.grpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_SuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DepartmentsBindingSource)).EndInit();
            this.grpFooter.ResumeLayout(false);
            this.grpMenuHeading.ResumeLayout(false);
            this.grpMenuHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.TextBox txtVATRate;
        private System.Windows.Forms.Label lblVATRate;
        private System.Windows.Forms.ComboBox cmbTaxCode;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.TextBox txtMinOrderQty;
        private System.Windows.Forms.Label lblMinOrderQty;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTaxCode;
        private System.Windows.Forms.TextBox txtBoxCostprice;
        private System.Windows.Forms.TextBox txtMinStockLevel;
        private System.Windows.Forms.Label lblMinStockLevel;
        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.ComboBox cmbSupplierCode;
        private System.Windows.Forms.Label lblEnterSupplierCode;
        private System.Windows.Forms.ComboBox cmbDeptCode;
        private System.Windows.Forms.Label lblDeptCode;
        private System.Windows.Forms.TextBox txtReorder;
        private System.Windows.Forms.Label lblCatalogue;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.GroupBox grpFooter;
        private System.Windows.Forms.GroupBox grpMenuHeading;
        private System.Windows.Forms.Label lblProducts;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource tbl_ItemsBindingSource;
        private ePOS.DataDataSetTableAdapters.tbl_ItemsTableAdapter tbl_ItemsTableAdapter;
        private ePOS.DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private ePOS.DataDataSetTableAdapters.tbl_DepartmentsTableAdapter tbl_DepartmentsTableAdapter;
        private System.Windows.Forms.BindingSource tbl_DepartmentsBindingSource;
        private ePOS.DataDataSetTableAdapters.tbl_SuppliersTableAdapter tbl_SuppliersTableAdapter;
        private System.Windows.Forms.BindingSource tbl_SuppliersBindingSource;
        private ePOS.DataDataSetTableAdapters.tbl_TaxDetailsTableAdapter tbl_TaxDetailsTableAdapter;
        private System.Windows.Forms.BindingSource tbl_TaxDetailsBindingSource;
        private System.Windows.Forms.ComboBox cmbBarcode;
    }
}