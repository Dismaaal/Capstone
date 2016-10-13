namespace Kerrimo
{
    partial class frmPurchaseOrder
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
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSQty = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtAQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuppliesID = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiscountPer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPaymentDue = new System.Windows.Forms.TextBox();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtTaxAmt = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtTaxPer = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.lblPriviledge = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(744, 15);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(132, 22);
            this.txtOrderNo.TabIndex = 1;
            this.txtOrderNo.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(509, 26);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Supplies";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(907, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "label1";
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(911, 55);
            this.ListView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(841, 179);
            this.ListView1.TabIndex = 4;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Supplies ID";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 279;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddOrder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSQty);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAQty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSupplyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(665, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplies Details";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.Silver;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOrder.Location = new System.Drawing.Point(481, 149);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(100, 28);
            this.btnAddOrder.TabIndex = 12;
            this.btnAddOrder.Text = "Add to Orders";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sale Qty.";
            // 
            // txtSQty
            // 
            this.txtSQty.Location = new System.Drawing.Point(471, 71);
            this.txtSQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSQty.Name = "txtSQty";
            this.txtSQty.Size = new System.Drawing.Size(132, 27);
            this.txtSQty.TabIndex = 9;
            this.txtSQty.TextChanged += new System.EventHandler(this.txtSQty_TextChanged);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(471, 112);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(132, 27);
            this.txtTotalAmount.TabIndex = 8;
            // 
            // txtAQty
            // 
            this.txtAQty.Location = new System.Drawing.Point(199, 149);
            this.txtAQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAQty.Name = "txtAQty";
            this.txtAQty.Size = new System.Drawing.Size(109, 27);
            this.txtAQty.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Available Qty";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(176, 103);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 27);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(176, 60);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(132, 27);
            this.txtUnit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit";
            // 
            // txtSupplyName
            // 
            this.txtSupplyName.Location = new System.Drawing.Point(147, 27);
            this.txtSupplyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplyName.Name = "txtSupplyName";
            this.txtSupplyName.Size = new System.Drawing.Size(353, 27);
            this.txtSupplyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supply Name";
            // 
            // txtSuppliesID
            // 
            this.txtSuppliesID.Location = new System.Drawing.Point(575, 15);
            this.txtSuppliesID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSuppliesID.Name = "txtSuppliesID";
            this.txtSuppliesID.Size = new System.Drawing.Size(132, 22);
            this.txtSuppliesID.TabIndex = 6;
            this.txtSuppliesID.Visible = false;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.cmbStatus);
            this.Panel2.Controls.Add(this.cmbPaymentType);
            this.Panel2.Controls.Add(this.label20);
            this.Panel2.Controls.Add(this.label18);
            this.Panel2.Controls.Add(this.txtRemarks);
            this.Panel2.Controls.Add(this.label7);
            this.Panel2.Controls.Add(this.txtDiscountAmount);
            this.Panel2.Controls.Add(this.label17);
            this.Panel2.Controls.Add(this.txtDiscountPer);
            this.Panel2.Controls.Add(this.label9);
            this.Panel2.Controls.Add(this.txtPaymentDue);
            this.Panel2.Controls.Add(this.txtTotalPayment);
            this.Panel2.Controls.Add(this.Label19);
            this.Panel2.Controls.Add(this.payment);
            this.Panel2.Controls.Add(this.txtTotal);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.txtTaxAmt);
            this.Panel2.Controls.Add(this.Label24);
            this.Panel2.Controls.Add(this.txtTaxPer);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.txtSubTotal);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Location = new System.Drawing.Point(911, 242);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(842, 272);
            this.Panel2.TabIndex = 114;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Confirmed",
            "Shipped",
            "Delivered",
            "Returned"});
            this.cmbStatus.Location = new System.Drawing.Point(623, 233);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(181, 24);
            this.cmbStatus.TabIndex = 4;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbPaymentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "COD",
            "Debit Card",
            "Credit Card",
            "By Check",
            "By DD",
            "Online"});
            this.cmbPaymentType.Location = new System.Drawing.Point(623, 194);
            this.cmbPaymentType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(181, 24);
            this.cmbPaymentType.TabIndex = 3;
            this.cmbPaymentType.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(496, 233);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 18);
            this.label20.TabIndex = 121;
            this.label20.Text = "Status";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(496, 197);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 18);
            this.label18.TabIndex = 120;
            this.label18.Text = "Payment Type";
            this.label18.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(500, 39);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtRemarks.Size = new System.Drawing.Size(304, 141);
            this.txtRemarks.TabIndex = 118;
            this.txtRemarks.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 119;
            this.label7.Text = "Remarks";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(293, 101);
            this.txtDiscountAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(105, 22);
            this.txtDiscountAmount.TabIndex = 7;
            this.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(232, 101);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 26);
            this.label17.TabIndex = 101;
            this.label17.Text = "%";
            // 
            // txtDiscountPer
            // 
            this.txtDiscountPer.Location = new System.Drawing.Point(155, 102);
            this.txtDiscountPer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiscountPer.Name = "txtDiscountPer";
            this.txtDiscountPer.Size = new System.Drawing.Size(68, 22);
            this.txtDiscountPer.TabIndex = 1;
            this.txtDiscountPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPer.TextChanged += new System.EventHandler(this.txtDiscountPer_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 99;
            this.label9.Text = "Discount";
            // 
            // txtPaymentDue
            // 
            this.txtPaymentDue.Location = new System.Drawing.Point(155, 225);
            this.txtPaymentDue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaymentDue.Name = "txtPaymentDue";
            this.txtPaymentDue.ReadOnly = true;
            this.txtPaymentDue.Size = new System.Drawing.Size(107, 22);
            this.txtPaymentDue.TabIndex = 8;
            this.txtPaymentDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(155, 185);
            this.txtTotalPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(107, 22);
            this.txtTotalPayment.TabIndex = 2;
            this.txtTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(25, 225);
            this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(106, 18);
            this.Label19.TabIndex = 96;
            this.Label19.Text = "Payment Due";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(25, 186);
            this.payment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(110, 18);
            this.payment.TabIndex = 95;
            this.payment.Text = "Total Payment";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(155, 144);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(107, 22);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(25, 144);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(93, 18);
            this.Label16.TabIndex = 94;
            this.Label16.Text = "Grand Total";
            // 
            // txtTaxAmt
            // 
            this.txtTaxAmt.Location = new System.Drawing.Point(293, 58);
            this.txtTaxAmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaxAmt.Name = "txtTaxAmt";
            this.txtTaxAmt.ReadOnly = true;
            this.txtTaxAmt.Size = new System.Drawing.Size(105, 22);
            this.txtTaxAmt.TabIndex = 6;
            this.txtTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.White;
            this.Label24.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.Black;
            this.Label24.Location = new System.Drawing.Point(232, 58);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(29, 26);
            this.Label24.TabIndex = 92;
            this.Label24.Text = "%";
            // 
            // txtTaxPer
            // 
            this.txtTaxPer.Location = new System.Drawing.Point(155, 59);
            this.txtTaxPer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaxPer.Name = "txtTaxPer";
            this.txtTaxPer.Size = new System.Drawing.Size(68, 22);
            this.txtTaxPer.TabIndex = 0;
            this.txtTaxPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxPer.TextChanged += new System.EventHandler(this.txtTaxPer_TextChanged);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(27, 63);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(59, 18);
            this.Label15.TabIndex = 90;
            this.Label15.Text = "VAT+ST";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(155, 17);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(244, 22);
            this.txtSubTotal.TabIndex = 5;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(25, 20);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(73, 18);
            this.Label14.TabIndex = 77;
            this.Label14.Text = "Sub Total";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(236, 181);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(469, 22);
            this.txtCustomerName.TabIndex = 121;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpInvoiceDate.Enabled = false;
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(236, 97);
            this.dtpInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(159, 28);
            this.dtpInvoiceDate.TabIndex = 119;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(236, 139);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(245, 22);
            this.txtCustomerID.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 116;
            this.label10.Text = "Customer ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 19);
            this.label11.TabIndex = 117;
            this.label11.Text = "Customer Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 19);
            this.label12.TabIndex = 118;
            this.label12.Text = "Order Date";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.Purple;
            this.Label13.Location = new System.Drawing.Point(68, 47);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(90, 28);
            this.Label13.TabIndex = 115;
            this.Label13.Text = "Orders";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Purple;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.btnPrint);
            this.Panel1.Controls.Add(this.btnRemove);
            this.Panel1.Controls.Add(this.NewRecord);
            this.Panel1.Controls.Add(this.Save);
            this.Panel1.ForeColor = System.Drawing.Color.Black;
            this.Panel1.Location = new System.Drawing.Point(728, 71);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(174, 254);
            this.Panel1.TabIndex = 122;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(17, 185);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(132, 58);
            this.btnPrint.TabIndex = 112;
            this.btnPrint.Text = "&Print Receipt";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(19, 68);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 53);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // NewRecord
            // 
            this.NewRecord.BackColor = System.Drawing.Color.White;
            this.NewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewRecord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.ForeColor = System.Drawing.Color.Black;
            this.NewRecord.Location = new System.Drawing.Point(19, 10);
            this.NewRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(131, 53);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = false;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click_1);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(19, 124);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 54);
            this.Save.TabIndex = 1;
            this.Save.Text = "&Place Order";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // lblPriviledge
            // 
            this.lblPriviledge.AutoSize = true;
            this.lblPriviledge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriviledge.Location = new System.Drawing.Point(341, 15);
            this.lblPriviledge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriviledge.Name = "lblPriviledge";
            this.lblPriviledge.Size = new System.Drawing.Size(76, 22);
            this.lblPriviledge.TabIndex = 123;
            this.lblPriviledge.Text = "label21";
            this.lblPriviledge.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Delete);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(733, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 187);
            this.panel3.TabIndex = 135;
            this.panel3.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(19, 139);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 36);
            this.btnUpdate.TabIndex = 100;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "&New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.White;
            this.Delete.Enabled = false;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(19, 96);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 36);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1807, 523);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPriviledge);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.txtSuppliesID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOrderNo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPurchaseOrder";
            this.Text = "frmPurchaseOrder";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSuppliesID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUnit;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtOrderNo;
        public System.Windows.Forms.TextBox txtSupplyName;
        public System.Windows.Forms.TextBox txtSQty;
        public System.Windows.Forms.TextBox txtTotalAmount;
        public System.Windows.Forms.TextBox txtAQty;
        internal System.Windows.Forms.Panel Panel2;
        public System.Windows.Forms.ComboBox cmbStatus;
        public System.Windows.Forms.ComboBox cmbPaymentType;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label18;
        public System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtDiscountAmount;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox txtDiscountPer;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtPaymentDue;
        internal System.Windows.Forms.TextBox txtTotalPayment;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label payment;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtTaxAmt;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtTaxPer;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtSubTotal;
        internal System.Windows.Forms.Label Label14;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        public System.Windows.Forms.TextBox txtCustomerID;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Button NewRecord;
        internal System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblPriviledge;
        internal System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListView ListView1;
        public System.Windows.Forms.Button btnAddOrder;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Panel Panel1;
        public System.Windows.Forms.Panel panel3;
    }
}