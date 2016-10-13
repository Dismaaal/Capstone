namespace Kerrimo
{
    partial class frmInventory
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSizeID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGetDataSize = new System.Windows.Forms.Button();
            this.btnUpdateSize = new System.Windows.Forms.Button();
            this.btnDeleteSize = new System.Windows.Forms.Button();
            this.btnSaveSize = new System.Windows.Forms.Button();
            this.btnNewSize = new System.Windows.Forms.Button();
            this.txtPriceSize = new System.Windows.Forms.TextBox();
            this.txtSizeName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtFlavorsID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGetDataF = new System.Windows.Forms.Button();
            this.btnUpdateF = new System.Windows.Forms.Button();
            this.btnDeleteF = new System.Windows.Forms.Button();
            this.btnSaveF = new System.Windows.Forms.Button();
            this.btnNewF = new System.Windows.Forms.Button();
            this.txtFlavorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtDrinkID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGetDataD = new System.Windows.Forms.Button();
            this.btnUpdateD = new System.Windows.Forms.Button();
            this.btnDeleteD = new System.Windows.Forms.Button();
            this.btnSaveD = new System.Windows.Forms.Button();
            this.btnNewD = new System.Windows.Forms.Button();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFlavorsPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDrinksPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1172, 814);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtProductID);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1164, 779);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(31, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(699, 427);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(449, 91);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(132, 30);
            this.txtUnit.TabIndex = 26;
            this.txtUnit.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Image";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(221, 91);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 30);
            this.txtPrice.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price (in Peso)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-113, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Features";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 48);
            this.button1.TabIndex = 24;
            this.button1.Text = "&Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(221, 38);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(395, 30);
            this.txtProductName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(221, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(537, 16);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(155, 30);
            this.txtProductID.TabIndex = 20;
            this.txtProductID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGetData);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(777, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 260);
            this.panel1.TabIndex = 19;
            // 
            // btnGetData
            // 
            this.btnGetData.BackColor = System.Drawing.Color.White;
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetData.Location = new System.Drawing.Point(17, 204);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(113, 39);
            this.btnGetData.TabIndex = 4;
            this.btnGetData.Text = "&Get Data";
            this.btnGetData.UseVisualStyleBackColor = false;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(17, 158);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 39);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(17, 111);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(17, 64);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 39);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Location = new System.Drawing.Point(17, 17);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(113, 39);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSizeID);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1164, 779);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sizes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSizeID
            // 
            this.txtSizeID.Location = new System.Drawing.Point(537, 9);
            this.txtSizeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSizeID.Name = "txtSizeID";
            this.txtSizeID.Size = new System.Drawing.Size(132, 30);
            this.txtSizeID.TabIndex = 1;
            this.txtSizeID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.txtPriceSize);
            this.groupBox2.Controls.Add(this.txtSizeName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(29, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1023, 473);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGetDataSize);
            this.panel2.Controls.Add(this.btnUpdateSize);
            this.panel2.Controls.Add(this.btnDeleteSize);
            this.panel2.Controls.Add(this.btnSaveSize);
            this.panel2.Controls.Add(this.btnNewSize);
            this.panel2.Location = new System.Drawing.Point(617, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 260);
            this.panel2.TabIndex = 20;
            // 
            // btnGetDataSize
            // 
            this.btnGetDataSize.BackColor = System.Drawing.Color.White;
            this.btnGetDataSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetDataSize.Location = new System.Drawing.Point(17, 204);
            this.btnGetDataSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetDataSize.Name = "btnGetDataSize";
            this.btnGetDataSize.Size = new System.Drawing.Size(113, 39);
            this.btnGetDataSize.TabIndex = 4;
            this.btnGetDataSize.Text = "&Get Data";
            this.btnGetDataSize.UseVisualStyleBackColor = false;
            this.btnGetDataSize.Click += new System.EventHandler(this.btnGetDataSize_Click);
            // 
            // btnUpdateSize
            // 
            this.btnUpdateSize.BackColor = System.Drawing.Color.White;
            this.btnUpdateSize.Enabled = false;
            this.btnUpdateSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateSize.Location = new System.Drawing.Point(17, 158);
            this.btnUpdateSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateSize.Name = "btnUpdateSize";
            this.btnUpdateSize.Size = new System.Drawing.Size(113, 39);
            this.btnUpdateSize.TabIndex = 3;
            this.btnUpdateSize.Text = "&Update";
            this.btnUpdateSize.UseVisualStyleBackColor = false;
            this.btnUpdateSize.Click += new System.EventHandler(this.btnUpdateSize_Click);
            // 
            // btnDeleteSize
            // 
            this.btnDeleteSize.BackColor = System.Drawing.Color.White;
            this.btnDeleteSize.Enabled = false;
            this.btnDeleteSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteSize.Location = new System.Drawing.Point(17, 111);
            this.btnDeleteSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteSize.Name = "btnDeleteSize";
            this.btnDeleteSize.Size = new System.Drawing.Size(113, 39);
            this.btnDeleteSize.TabIndex = 2;
            this.btnDeleteSize.Text = "&Delete";
            this.btnDeleteSize.UseVisualStyleBackColor = false;
            this.btnDeleteSize.Click += new System.EventHandler(this.btnDeleteSize_Click);
            // 
            // btnSaveSize
            // 
            this.btnSaveSize.BackColor = System.Drawing.Color.White;
            this.btnSaveSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSize.Location = new System.Drawing.Point(17, 64);
            this.btnSaveSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveSize.Name = "btnSaveSize";
            this.btnSaveSize.Size = new System.Drawing.Size(113, 39);
            this.btnSaveSize.TabIndex = 1;
            this.btnSaveSize.Text = "&Save";
            this.btnSaveSize.UseVisualStyleBackColor = false;
            this.btnSaveSize.Click += new System.EventHandler(this.btnSaveSize_Click);
            // 
            // btnNewSize
            // 
            this.btnNewSize.BackColor = System.Drawing.Color.White;
            this.btnNewSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewSize.Location = new System.Drawing.Point(17, 17);
            this.btnNewSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewSize.Name = "btnNewSize";
            this.btnNewSize.Size = new System.Drawing.Size(113, 39);
            this.btnNewSize.TabIndex = 0;
            this.btnNewSize.Text = "&New";
            this.btnNewSize.UseVisualStyleBackColor = false;
            this.btnNewSize.Click += new System.EventHandler(this.btnNewSize_Click);
            // 
            // txtPriceSize
            // 
            this.txtPriceSize.Location = new System.Drawing.Point(181, 76);
            this.txtPriceSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPriceSize.Name = "txtPriceSize";
            this.txtPriceSize.Size = new System.Drawing.Size(363, 30);
            this.txtPriceSize.TabIndex = 13;
            this.txtPriceSize.TextChanged += new System.EventHandler(this.txtPriceSize_TextChanged);
            // 
            // txtSizeName
            // 
            this.txtSizeName.Location = new System.Drawing.Point(181, 27);
            this.txtSizeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSizeName.Name = "txtSizeName";
            this.txtSizeName.Size = new System.Drawing.Size(363, 30);
            this.txtSizeName.TabIndex = 12;
            this.txtSizeName.TextChanged += new System.EventHandler(this.txtSizeName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Price (in Peso)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Size Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtFlavorsID);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1164, 779);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Flavors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtFlavorsID
            // 
            this.txtFlavorsID.Location = new System.Drawing.Point(387, 5);
            this.txtFlavorsID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlavorsID.Name = "txtFlavorsID";
            this.txtFlavorsID.Size = new System.Drawing.Size(132, 30);
            this.txtFlavorsID.TabIndex = 1;
            this.txtFlavorsID.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFlavorsPrice);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.txtFlavorName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(33, 37);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(724, 326);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flavors Info";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnGetDataF);
            this.panel3.Controls.Add(this.btnUpdateF);
            this.panel3.Controls.Add(this.btnDeleteF);
            this.panel3.Controls.Add(this.btnSaveF);
            this.panel3.Controls.Add(this.btnNewF);
            this.panel3.Location = new System.Drawing.Point(545, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 260);
            this.panel3.TabIndex = 21;
            // 
            // btnGetDataF
            // 
            this.btnGetDataF.BackColor = System.Drawing.Color.White;
            this.btnGetDataF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetDataF.Location = new System.Drawing.Point(17, 204);
            this.btnGetDataF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetDataF.Name = "btnGetDataF";
            this.btnGetDataF.Size = new System.Drawing.Size(113, 39);
            this.btnGetDataF.TabIndex = 4;
            this.btnGetDataF.Text = "&Get Data";
            this.btnGetDataF.UseVisualStyleBackColor = false;
            this.btnGetDataF.Click += new System.EventHandler(this.btnGetDataF_Click);
            // 
            // btnUpdateF
            // 
            this.btnUpdateF.BackColor = System.Drawing.Color.White;
            this.btnUpdateF.Enabled = false;
            this.btnUpdateF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateF.Location = new System.Drawing.Point(17, 158);
            this.btnUpdateF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateF.Name = "btnUpdateF";
            this.btnUpdateF.Size = new System.Drawing.Size(113, 39);
            this.btnUpdateF.TabIndex = 3;
            this.btnUpdateF.Text = "&Update";
            this.btnUpdateF.UseVisualStyleBackColor = false;
            this.btnUpdateF.Click += new System.EventHandler(this.btnUpdateF_Click);
            // 
            // btnDeleteF
            // 
            this.btnDeleteF.BackColor = System.Drawing.Color.White;
            this.btnDeleteF.Enabled = false;
            this.btnDeleteF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteF.Location = new System.Drawing.Point(17, 111);
            this.btnDeleteF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteF.Name = "btnDeleteF";
            this.btnDeleteF.Size = new System.Drawing.Size(113, 39);
            this.btnDeleteF.TabIndex = 2;
            this.btnDeleteF.Text = "&Delete";
            this.btnDeleteF.UseVisualStyleBackColor = false;
            this.btnDeleteF.Click += new System.EventHandler(this.btnDeleteF_Click);
            // 
            // btnSaveF
            // 
            this.btnSaveF.BackColor = System.Drawing.Color.White;
            this.btnSaveF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveF.Location = new System.Drawing.Point(17, 64);
            this.btnSaveF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveF.Name = "btnSaveF";
            this.btnSaveF.Size = new System.Drawing.Size(113, 39);
            this.btnSaveF.TabIndex = 1;
            this.btnSaveF.Text = "&Save";
            this.btnSaveF.UseVisualStyleBackColor = false;
            this.btnSaveF.Click += new System.EventHandler(this.btnSaveF_Click);
            // 
            // btnNewF
            // 
            this.btnNewF.BackColor = System.Drawing.Color.White;
            this.btnNewF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewF.Location = new System.Drawing.Point(17, 17);
            this.btnNewF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewF.Name = "btnNewF";
            this.btnNewF.Size = new System.Drawing.Size(113, 39);
            this.btnNewF.TabIndex = 0;
            this.btnNewF.Text = "&New";
            this.btnNewF.UseVisualStyleBackColor = false;
            this.btnNewF.Click += new System.EventHandler(this.btnNewF_Click);
            // 
            // txtFlavorName
            // 
            this.txtFlavorName.Location = new System.Drawing.Point(173, 32);
            this.txtFlavorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlavorName.Name = "txtFlavorName";
            this.txtFlavorName.Size = new System.Drawing.Size(288, 30);
            this.txtFlavorName.TabIndex = 1;
            this.txtFlavorName.TextChanged += new System.EventHandler(this.txtFlavorName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Flavor Name:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtDrinkID);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1164, 779);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Drinks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtDrinkID
            // 
            this.txtDrinkID.Location = new System.Drawing.Point(327, 5);
            this.txtDrinkID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDrinkID.Name = "txtDrinkID";
            this.txtDrinkID.Size = new System.Drawing.Size(132, 30);
            this.txtDrinkID.TabIndex = 3;
            this.txtDrinkID.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDrinksPrice);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Controls.Add(this.txtDrinkName);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(35, 34);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(728, 415);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Drinks Info";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnGetDataD);
            this.panel4.Controls.Add(this.btnUpdateD);
            this.panel4.Controls.Add(this.btnDeleteD);
            this.panel4.Controls.Add(this.btnSaveD);
            this.panel4.Controls.Add(this.btnNewD);
            this.panel4.Location = new System.Drawing.Point(553, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 260);
            this.panel4.TabIndex = 22;
            // 
            // btnGetDataD
            // 
            this.btnGetDataD.BackColor = System.Drawing.Color.White;
            this.btnGetDataD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetDataD.Location = new System.Drawing.Point(17, 204);
            this.btnGetDataD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetDataD.Name = "btnGetDataD";
            this.btnGetDataD.Size = new System.Drawing.Size(113, 39);
            this.btnGetDataD.TabIndex = 4;
            this.btnGetDataD.Text = "&Get Data";
            this.btnGetDataD.UseVisualStyleBackColor = false;
            this.btnGetDataD.Click += new System.EventHandler(this.btnGetDataD_Click);
            // 
            // btnUpdateD
            // 
            this.btnUpdateD.BackColor = System.Drawing.Color.White;
            this.btnUpdateD.Enabled = false;
            this.btnUpdateD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateD.Location = new System.Drawing.Point(17, 158);
            this.btnUpdateD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateD.Name = "btnUpdateD";
            this.btnUpdateD.Size = new System.Drawing.Size(113, 39);
            this.btnUpdateD.TabIndex = 3;
            this.btnUpdateD.Text = "&Update";
            this.btnUpdateD.UseVisualStyleBackColor = false;
            this.btnUpdateD.Click += new System.EventHandler(this.btnUpdateD_Click);
            // 
            // btnDeleteD
            // 
            this.btnDeleteD.BackColor = System.Drawing.Color.White;
            this.btnDeleteD.Enabled = false;
            this.btnDeleteD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteD.Location = new System.Drawing.Point(17, 111);
            this.btnDeleteD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteD.Name = "btnDeleteD";
            this.btnDeleteD.Size = new System.Drawing.Size(113, 39);
            this.btnDeleteD.TabIndex = 2;
            this.btnDeleteD.Text = "&Delete";
            this.btnDeleteD.UseVisualStyleBackColor = false;
            this.btnDeleteD.Click += new System.EventHandler(this.btnDeleteD_Click);
            // 
            // btnSaveD
            // 
            this.btnSaveD.BackColor = System.Drawing.Color.White;
            this.btnSaveD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveD.Location = new System.Drawing.Point(17, 64);
            this.btnSaveD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveD.Name = "btnSaveD";
            this.btnSaveD.Size = new System.Drawing.Size(113, 39);
            this.btnSaveD.TabIndex = 1;
            this.btnSaveD.Text = "&Save";
            this.btnSaveD.UseVisualStyleBackColor = false;
            this.btnSaveD.Click += new System.EventHandler(this.btnSaveD_Click);
            // 
            // btnNewD
            // 
            this.btnNewD.BackColor = System.Drawing.Color.White;
            this.btnNewD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewD.Location = new System.Drawing.Point(17, 17);
            this.btnNewD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewD.Name = "btnNewD";
            this.btnNewD.Size = new System.Drawing.Size(113, 39);
            this.btnNewD.TabIndex = 0;
            this.btnNewD.Text = "&New";
            this.btnNewD.UseVisualStyleBackColor = false;
            this.btnNewD.Click += new System.EventHandler(this.btnNewD_Click);
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.Location = new System.Drawing.Point(153, 37);
            this.txtDrinkName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.Size = new System.Drawing.Size(299, 30);
            this.txtDrinkName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Drink Name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtFlavorsPrice
            // 
            this.txtFlavorsPrice.Location = new System.Drawing.Point(173, 75);
            this.txtFlavorsPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlavorsPrice.Name = "txtFlavorsPrice";
            this.txtFlavorsPrice.Size = new System.Drawing.Size(363, 30);
            this.txtFlavorsPrice.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Price (in Peso)";
            // 
            // txtDrinksPrice
            // 
            this.txtDrinksPrice.Location = new System.Drawing.Point(153, 77);
            this.txtDrinksPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrinksPrice.Name = "txtDrinksPrice";
            this.txtDrinksPrice.Size = new System.Drawing.Size(363, 30);
            this.txtDrinksPrice.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Price (in Peso)";
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 766);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductID;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnGetData;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnGetDataSize;
        public System.Windows.Forms.Button btnUpdateSize;
        public System.Windows.Forms.Button btnDeleteSize;
        public System.Windows.Forms.Button btnSaveSize;
        public System.Windows.Forms.Button btnNewSize;
        public System.Windows.Forms.TextBox txtPriceSize;
        public System.Windows.Forms.TextBox txtSizeName;
        public System.Windows.Forms.TextBox txtSizeID;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnGetDataF;
        public System.Windows.Forms.Button btnUpdateF;
        public System.Windows.Forms.Button btnDeleteF;
        public System.Windows.Forms.Button btnSaveF;
        public System.Windows.Forms.Button btnNewF;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnGetDataD;
        public System.Windows.Forms.Button btnUpdateD;
        public System.Windows.Forms.Button btnDeleteD;
        public System.Windows.Forms.Button btnSaveD;
        public System.Windows.Forms.Button btnNewD;
        public System.Windows.Forms.TextBox txtFlavorsID;
        public System.Windows.Forms.TextBox txtFlavorName;
        public System.Windows.Forms.TextBox txtDrinkID;
        public System.Windows.Forms.TextBox txtDrinkName;
        public System.Windows.Forms.TextBox txtFlavorsPrice;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtDrinksPrice;
        private System.Windows.Forms.Label label10;
    }
}