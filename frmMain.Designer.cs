namespace CoffeeShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.newShopTsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openShopTsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveShopTsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveShopAsTsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.addProductTsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.addCategoryTsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSettingsMenu = new System.Windows.Forms.ToolStripButton();
            this.tsHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutTsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpTsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.categoryListView = new System.Windows.Forms.ListView();
            this.lstViewName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewNbProducts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNewPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFileMenu,
            this.tsEditMenu,
            this.tsSettingsMenu,
            this.tsHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(998, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsFileMenu
            // 
            this.tsFileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newShopTsItem,
            this.openShopTsItem,
            this.toolStripSeparator2,
            this.saveShopTsItem,
            this.saveShopAsTsItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.tsFileMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsFileMenu.Image")));
            this.tsFileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFileMenu.Name = "tsFileMenu";
            this.tsFileMenu.Size = new System.Drawing.Size(41, 22);
            this.tsFileMenu.Text = "FILE";
            // 
            // newShopTsItem
            // 
            this.newShopTsItem.Image = global::CoffeeShop.Properties.Resources.new_shop;
            this.newShopTsItem.Name = "newShopTsItem";
            this.newShopTsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newShopTsItem.Size = new System.Drawing.Size(225, 22);
            this.newShopTsItem.Text = "New Shop";
            this.newShopTsItem.Click += new System.EventHandler(this.newShopTsItem_Click);
            // 
            // openShopTsItem
            // 
            this.openShopTsItem.Image = global::CoffeeShop.Properties.Resources.open_shop;
            this.openShopTsItem.Name = "openShopTsItem";
            this.openShopTsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openShopTsItem.Size = new System.Drawing.Size(225, 22);
            this.openShopTsItem.Text = "Open Shop";
            this.openShopTsItem.Click += new System.EventHandler(this.openShopTsItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // saveShopTsItem
            // 
            this.saveShopTsItem.Image = global::CoffeeShop.Properties.Resources.save_shop;
            this.saveShopTsItem.Name = "saveShopTsItem";
            this.saveShopTsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveShopTsItem.Size = new System.Drawing.Size(225, 22);
            this.saveShopTsItem.Text = "Save Shop";
            this.saveShopTsItem.Click += new System.EventHandler(this.saveShopTsItem_Click);
            // 
            // saveShopAsTsItem
            // 
            this.saveShopAsTsItem.Image = global::CoffeeShop.Properties.Resources.save_shop;
            this.saveShopAsTsItem.Name = "saveShopAsTsItem";
            this.saveShopAsTsItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveShopAsTsItem.Size = new System.Drawing.Size(225, 22);
            this.saveShopAsTsItem.Text = "Save Shop As...";
            this.saveShopAsTsItem.Click += new System.EventHandler(this.saveShopAsTsItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::CoffeeShop.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsEditMenu
            // 
            this.tsEditMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsEditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductTsItem,
            this.toolStripSeparator4,
            this.addCategoryTsItem});
            this.tsEditMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsEditMenu.Image")));
            this.tsEditMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditMenu.Name = "tsEditMenu";
            this.tsEditMenu.Size = new System.Drawing.Size(44, 22);
            this.tsEditMenu.Text = "EDIT";
            // 
            // addProductTsItem
            // 
            this.addProductTsItem.Image = global::CoffeeShop.Properties.Resources.add_product;
            this.addProductTsItem.Name = "addProductTsItem";
            this.addProductTsItem.Size = new System.Drawing.Size(185, 22);
            this.addProductTsItem.Text = "Add Coffee Product";
            this.addProductTsItem.Click += new System.EventHandler(this.addProductTsItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(182, 6);
            // 
            // addCategoryTsItem
            // 
            this.addCategoryTsItem.Image = global::CoffeeShop.Properties.Resources.add_category;
            this.addCategoryTsItem.Name = "addCategoryTsItem";
            this.addCategoryTsItem.Size = new System.Drawing.Size(185, 22);
            this.addCategoryTsItem.Text = "Add Coffee Category";
            this.addCategoryTsItem.Click += new System.EventHandler(this.addCategoryTsItem_Click);
            // 
            // tsSettingsMenu
            // 
            this.tsSettingsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSettingsMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsSettingsMenu.Image")));
            this.tsSettingsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSettingsMenu.Name = "tsSettingsMenu";
            this.tsSettingsMenu.Size = new System.Drawing.Size(63, 22);
            this.tsSettingsMenu.Text = "SETTINGS";
            this.tsSettingsMenu.Click += new System.EventHandler(this.tsSettingsMenu_Click);
            // 
            // tsHelp
            // 
            this.tsHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTsItem,
            this.toolStripSeparator3,
            this.helpTsItem});
            this.tsHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsHelp.Image")));
            this.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(48, 22);
            this.tsHelp.Text = "HELP";
            // 
            // aboutTsItem
            // 
            this.aboutTsItem.Image = global::CoffeeShop.Properties.Resources.about;
            this.aboutTsItem.Name = "aboutTsItem";
            this.aboutTsItem.Size = new System.Drawing.Size(107, 22);
            this.aboutTsItem.Text = "About";
            this.aboutTsItem.Click += new System.EventHandler(this.aboutTsItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(104, 6);
            // 
            // helpTsItem
            // 
            this.helpTsItem.Image = global::CoffeeShop.Properties.Resources.help;
            this.helpTsItem.Name = "helpTsItem";
            this.helpTsItem.Size = new System.Drawing.Size(107, 22);
            this.helpTsItem.Text = "Help";
            this.helpTsItem.Click += new System.EventHandler(this.helpTsItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.categoryListView);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvProducts);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(998, 625);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 1;
            // 
            // categoryListView
            // 
            this.categoryListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.lstViewId,
            this.lstViewName,
            this.lstViewNbProducts});
            this.categoryListView.FullRowSelect = true;
            this.categoryListView.GridLines = true;
            this.categoryListView.Location = new System.Drawing.Point(10, 34);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(314, 577);
            this.categoryListView.TabIndex = 2;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.View = System.Windows.Forms.View.Details;
            this.categoryListView.SelectedIndexChanged += new System.EventHandler(this.categoryListView_SelectedIndexChanged);
            // 
            // lstViewName
            // 
            this.lstViewName.Text = "Name";
            this.lstViewName.Width = 140;
            // 
            // lstViewNbProducts
            // 
            this.lstViewNbProducts.Text = "Number of Products";
            this.lstViewNbProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstViewNbProducts.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(94, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CATEGORIES";
            // 
            // lstViewId
            // 
            this.lstViewId.Text = "ID";
            this.lstViewId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(285, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUCTS";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colPrice,
            this.colNewPrice,
            this.colQty,
            this.colDetails,
            this.colEdit,
            this.colDelete});
            this.dgvProducts.Location = new System.Drawing.Point(8, 34);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.ShowCellErrors = false;
            this.dgvProducts.ShowEditingIcon = false;
            this.dgvProducts.ShowRowErrors = false;
            this.dgvProducts.Size = new System.Drawing.Size(653, 577);
            this.dgvProducts.TabIndex = 4;
            // 
            // colId
            // 
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 40;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 75;
            // 
            // colNewPrice
            // 
            this.colNewPrice.HeaderText = "Reduced Price";
            this.colNewPrice.Name = "colNewPrice";
            this.colNewPrice.ReadOnly = true;
            this.colNewPrice.Width = 75;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 60;
            // 
            // colDetails
            // 
            this.colDetails.HeaderText = "Details";
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            this.colDetails.Width = 50;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 60;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 70;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CoffeeShop.Properties.Resources.add_category;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 11;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CoffeeShop.Properties.Resources.add_category;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(251, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 12;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::CoffeeShop.Properties.Resources.exit;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(294, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 13;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 650);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsFileMenu;
        private System.Windows.Forms.ToolStripMenuItem newShopTsItem;
        private System.Windows.Forms.ToolStripMenuItem openShopTsItem;
        private System.Windows.Forms.ToolStripMenuItem saveShopTsItem;
        private System.Windows.Forms.ToolStripMenuItem saveShopAsTsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutTsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem helpTsItem;
        private System.Windows.Forms.ToolStripButton tsSettingsMenu;
        private System.Windows.Forms.ToolStripDropDownButton tsEditMenu;
        private System.Windows.Forms.ToolStripMenuItem addProductTsItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryTsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView categoryListView;
        private System.Windows.Forms.ColumnHeader lstViewName;
        private System.Windows.Forms.ColumnHeader lstViewNbProducts;
        private System.Windows.Forms.ColumnHeader lstViewId;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewButtonColumn colDetails;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

