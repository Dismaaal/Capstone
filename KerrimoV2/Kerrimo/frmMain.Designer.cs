namespace Kerrimo
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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripPOS = new System.Windows.Forms.ToolStripButton();
            this.toolStripInventory = new System.Windows.Forms.ToolStripButton();
            this.toolStripUsers = new System.Windows.Forms.ToolStripDropDownButton();
            this.suppliersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRecords = new System.Windows.Forms.ToolStripDropDownButton();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStocks = new System.Windows.Forms.ToolStripDropDownButton();
            this.stocksOnHandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLogout = new System.Windows.Forms.ToolStripButton();
            this.lblTitleMain = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.LogoSmall = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSmall)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPOS,
            this.toolStripInventory,
            this.toolStripUsers,
            this.toolStripRecords,
            this.toolStripStocks,
            this.toolStripLogout});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 114);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripMenu.Size = new System.Drawing.Size(627, 89);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripPOS
            // 
            this.toolStripPOS.AutoSize = false;
            this.toolStripPOS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPOS.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPOS.Image")));
            this.toolStripPOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripPOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPOS.Name = "toolStripPOS";
            this.toolStripPOS.Size = new System.Drawing.Size(90, 86);
            this.toolStripPOS.Text = "Point of Sales";
            this.toolStripPOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripPOS.Click += new System.EventHandler(this.toolStripPOS_Click);
            // 
            // toolStripInventory
            // 
            this.toolStripInventory.AutoSize = false;
            this.toolStripInventory.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripInventory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripInventory.Image")));
            this.toolStripInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripInventory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInventory.Name = "toolStripInventory";
            this.toolStripInventory.Size = new System.Drawing.Size(90, 86);
            this.toolStripInventory.Text = "Inventory";
            this.toolStripInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripInventory.Click += new System.EventHandler(this.toolStripInventory_Click);
            // 
            // toolStripUsers
            // 
            this.toolStripUsers.AutoSize = false;
            this.toolStripUsers.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersToolStripMenuItem1,
            this.usersToolStripMenuItem1});
            this.toolStripUsers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUsers.Image")));
            this.toolStripUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUsers.Name = "toolStripUsers";
            this.toolStripUsers.ShowDropDownArrow = false;
            this.toolStripUsers.Size = new System.Drawing.Size(90, 86);
            this.toolStripUsers.Text = "Users";
            this.toolStripUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripUsers.Click += new System.EventHandler(this.toolStripUsers_Click);
            // 
            // suppliersToolStripMenuItem1
            // 
            this.suppliersToolStripMenuItem1.Name = "suppliersToolStripMenuItem1";
            this.suppliersToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.suppliersToolStripMenuItem1.Text = "Suppliers";
            this.suppliersToolStripMenuItem1.Click += new System.EventHandler(this.suppliersToolStripMenuItem1_Click);
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.usersToolStripMenuItem1.Text = "Users";
            this.usersToolStripMenuItem1.Click += new System.EventHandler(this.usersToolStripMenuItem1_Click);
            // 
            // toolStripRecords
            // 
            this.toolStripRecords.AutoSize = false;
            this.toolStripRecords.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRecords.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.stocksToolStripMenuItem,
            this.suppliersToolStripMenuItem2});
            this.toolStripRecords.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRecords.Image")));
            this.toolStripRecords.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripRecords.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRecords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRecords.Name = "toolStripRecords";
            this.toolStripRecords.ShowDropDownArrow = false;
            this.toolStripRecords.Size = new System.Drawing.Size(90, 86);
            this.toolStripRecords.Text = "Records";
            this.toolStripRecords.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stocksToolStripMenuItem.Text = "Stocks";
            this.stocksToolStripMenuItem.Click += new System.EventHandler(this.stocksToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem2
            // 
            this.suppliersToolStripMenuItem2.Name = "suppliersToolStripMenuItem2";
            this.suppliersToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.suppliersToolStripMenuItem2.Text = "Suppliers";
            this.suppliersToolStripMenuItem2.Click += new System.EventHandler(this.suppliersToolStripMenuItem2_Click);
            // 
            // toolStripStocks
            // 
            this.toolStripStocks.AutoSize = false;
            this.toolStripStocks.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStocks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStocks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stocksOnHandToolStripMenuItem,
            this.addStocksToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.invoiceToolStripMenuItem});
            this.toolStripStocks.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStocks.Image")));
            this.toolStripStocks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripStocks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStocks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStocks.Name = "toolStripStocks";
            this.toolStripStocks.ShowDropDownArrow = false;
            this.toolStripStocks.Size = new System.Drawing.Size(90, 86);
            this.toolStripStocks.Text = "Stocks";
            this.toolStripStocks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripStocks.Click += new System.EventHandler(this.toolStripStocks_Click);
            // 
            // stocksOnHandToolStripMenuItem
            // 
            this.stocksOnHandToolStripMenuItem.Name = "stocksOnHandToolStripMenuItem";
            this.stocksOnHandToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.stocksOnHandToolStripMenuItem.Text = "Stocks on Hand";
            this.stocksOnHandToolStripMenuItem.Click += new System.EventHandler(this.stocksOnHandToolStripMenuItem_Click);
            // 
            // addStocksToolStripMenuItem
            // 
            this.addStocksToolStripMenuItem.Name = "addStocksToolStripMenuItem";
            this.addStocksToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addStocksToolStripMenuItem.Text = "Add Stocks";
            this.addStocksToolStripMenuItem.Click += new System.EventHandler(this.addStocksToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackOrderToolStripMenuItem});
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            this.purchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem_Click);
            // 
            // trackOrderToolStripMenuItem
            // 
            this.trackOrderToolStripMenuItem.Name = "trackOrderToolStripMenuItem";
            this.trackOrderToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.trackOrderToolStripMenuItem.Text = "Track Order";
            this.trackOrderToolStripMenuItem.Click += new System.EventHandler(this.trackOrderToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // toolStripLogout
            // 
            this.toolStripLogout.AutoSize = false;
            this.toolStripLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLogout.Image")));
            this.toolStripLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLogout.Name = "toolStripLogout";
            this.toolStripLogout.Size = new System.Drawing.Size(90, 86);
            this.toolStripLogout.Text = "Point of Sales";
            this.toolStripLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLogout.Click += new System.EventHandler(this.toolStripLogout_Click);
            // 
            // lblTitleMain
            // 
            this.lblTitleMain.AutoSize = true;
            this.lblTitleMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.lblTitleMain.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMain.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitleMain.Location = new System.Drawing.Point(274, 8);
            this.lblTitleMain.Name = "lblTitleMain";
            this.lblTitleMain.Size = new System.Drawing.Size(64, 23);
            this.lblTitleMain.TabIndex = 3;
            this.lblTitleMain.Text = "MENU";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnClose.Location = new System.Drawing.Point(588, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LogoSmall
            // 
            this.LogoSmall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoSmall.BackgroundImage")));
            this.LogoSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoSmall.Location = new System.Drawing.Point(0, -1);
            this.LogoSmall.Name = "LogoSmall";
            this.LogoSmall.Size = new System.Drawing.Size(76, 35);
            this.LogoSmall.TabIndex = 2;
            this.LogoSmall.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.lblUser,
            this.ToolStripStatusLabel3,
            this.ToolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 91);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(627, 23);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(111, 18);
            this.ToolStripStatusLabel1.Text = "Logged in As :";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Image = ((System.Drawing.Image)(resources.GetObject("lblUser.Image")));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(175, 18);
            this.lblUser.Text = "ToolStripStatusLabel2";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(151, 18);
            this.ToolStripStatusLabel3.Spring = true;
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripStatusLabel4.Image")));
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(175, 18);
            this.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem1_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(627, 203);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTitleMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LogoSmall);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSmall)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripPOS;
        private System.Windows.Forms.Label lblTitleMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox LogoSmall;
        private System.Windows.Forms.ToolStripButton toolStripInventory;
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel lblUser;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripRecords;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripUsers;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripLogout;
        private System.Windows.Forms.ToolStripDropDownButton toolStripStocks;
        private System.Windows.Forms.ToolStripMenuItem stocksOnHandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;

    }
}