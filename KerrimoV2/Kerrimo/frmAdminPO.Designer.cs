namespace Kerrimo
{
    partial class frmAdminPO
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
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label8 = new System.Windows.Forms.Label();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.Button7 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtSaleQty = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtAvailableQty = new System.Windows.Forms.TextBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Unit Price";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader3.Width = 90;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Total Amount";
            this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader5.Width = 120;
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
            this.Panel2.Controls.Add(this.label8);
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
            this.Panel2.Location = new System.Drawing.Point(684, 410);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(567, 221);
            this.Panel2.TabIndex = 131;
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
            this.cmbStatus.Location = new System.Drawing.Point(416, 186);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(137, 21);
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
            this.cmbPaymentType.Location = new System.Drawing.Point(416, 155);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(137, 21);
            this.cmbPaymentType.TabIndex = 3;
            this.cmbPaymentType.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(321, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 16);
            this.label20.TabIndex = 121;
            this.label20.Text = "Status";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(321, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 16);
            this.label18.TabIndex = 120;
            this.label18.Text = "Payment Type";
            this.label18.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(324, 29);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtRemarks.Size = new System.Drawing.Size(229, 115);
            this.txtRemarks.TabIndex = 118;
            this.txtRemarks.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 119;
            this.label7.Text = "Remarks";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(220, 82);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(80, 20);
            this.txtDiscountAmount.TabIndex = 7;
            this.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(174, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 21);
            this.label17.TabIndex = 101;
            this.label17.Text = "%";
            // 
            // txtDiscountPer
            // 
            this.txtDiscountPer.Location = new System.Drawing.Point(116, 83);
            this.txtDiscountPer.Name = "txtDiscountPer";
            this.txtDiscountPer.Size = new System.Drawing.Size(52, 20);
            this.txtDiscountPer.TabIndex = 1;
            this.txtDiscountPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 99;
            this.label8.Text = "Discount";
            // 
            // txtPaymentDue
            // 
            this.txtPaymentDue.Location = new System.Drawing.Point(116, 183);
            this.txtPaymentDue.Name = "txtPaymentDue";
            this.txtPaymentDue.ReadOnly = true;
            this.txtPaymentDue.Size = new System.Drawing.Size(81, 20);
            this.txtPaymentDue.TabIndex = 8;
            this.txtPaymentDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(116, 150);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(81, 20);
            this.txtTotalPayment.TabIndex = 2;
            this.txtTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(19, 183);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(85, 16);
            this.Label19.TabIndex = 96;
            this.Label19.Text = "Payment Due";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(19, 151);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(90, 16);
            this.payment.TabIndex = 95;
            this.payment.Text = "Total Payment";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(116, 117);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(81, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(19, 117);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(76, 16);
            this.Label16.TabIndex = 94;
            this.Label16.Text = "Grand Total";
            // 
            // txtTaxAmt
            // 
            this.txtTaxAmt.Location = new System.Drawing.Point(220, 47);
            this.txtTaxAmt.Name = "txtTaxAmt";
            this.txtTaxAmt.ReadOnly = true;
            this.txtTaxAmt.Size = new System.Drawing.Size(80, 20);
            this.txtTaxAmt.TabIndex = 6;
            this.txtTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.White;
            this.Label24.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.Black;
            this.Label24.Location = new System.Drawing.Point(174, 47);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(23, 21);
            this.Label24.TabIndex = 92;
            this.Label24.Text = "%";
            // 
            // txtTaxPer
            // 
            this.txtTaxPer.Location = new System.Drawing.Point(116, 48);
            this.txtTaxPer.Name = "txtTaxPer";
            this.txtTaxPer.Size = new System.Drawing.Size(52, 20);
            this.txtTaxPer.TabIndex = 0;
            this.txtTaxPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(20, 51);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(50, 16);
            this.Label15.TabIndex = 90;
            this.Label15.Text = "VAT+ST";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(116, 14);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(184, 20);
            this.txtSubTotal.TabIndex = 5;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(19, 16);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(60, 16);
            this.Label14.TabIndex = 77;
            this.Label14.Text = "Sub Total";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Purple;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.btnUpdate);
            this.Panel1.Controls.Add(this.NewRecord);
            this.Panel1.Controls.Add(this.Delete);
            this.Panel1.Controls.Add(this.Save);
            this.Panel1.Location = new System.Drawing.Point(565, 41);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(112, 152);
            this.Panel1.TabIndex = 134;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(14, 113);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 29);
            this.btnUpdate.TabIndex = 100;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // NewRecord
            // 
            this.NewRecord.BackColor = System.Drawing.Color.White;
            this.NewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewRecord.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.Location = new System.Drawing.Point(14, 8);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(84, 29);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = false;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.White;
            this.Delete.Enabled = false;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(14, 78);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(84, 29);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(14, 43);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(84, 29);
            this.Save.TabIndex = 1;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Silver;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(683, 637);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 29);
            this.btnRemove.TabIndex = 132;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Silver;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(775, 637);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 29);
            this.btnPrint.TabIndex = 133;
            this.btnPrint.Text = "&Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(428, 10);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 135;
            this.txtProductID.Visible = false;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Qty.";
            this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader4.Width = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 138;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(370, 103);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(132, 26);
            this.txtTotalAmount.TabIndex = 93;
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.Silver;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.Location = new System.Drawing.Point(522, 27);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(87, 23);
            this.Button7.TabIndex = 6;
            this.Button7.Text = "&Add To Cart";
            this.Button7.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtTotalAmount);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Button7);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtProductName);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.txtSaleQty);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.txtPrice);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.txtAvailableQty);
            this.GroupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(26, 199);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(651, 147);
            this.GroupBox1.TabIndex = 129;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Details";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(26, 106);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(59, 16);
            this.Label11.TabIndex = 89;
            this.Label11.Text = "Sale Qty.";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(26, 33);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(92, 16);
            this.Label5.TabIndex = 74;
            this.Label5.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(138, 28);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(364, 26);
            this.txtProductName.TabIndex = 1;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(26, 67);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(62, 16);
            this.Label12.TabIndex = 87;
            this.Label12.Text = "Unit Price";
            // 
            // txtSaleQty
            // 
            this.txtSaleQty.Location = new System.Drawing.Point(138, 99);
            this.txtSaleQty.Name = "txtSaleQty";
            this.txtSaleQty.Size = new System.Drawing.Size(89, 26);
            this.txtSaleQty.TabIndex = 4;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(271, 67);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(88, 16);
            this.Label9.TabIndex = 75;
            this.Label9.Text = "Available Qty";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(138, 64);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(89, 26);
            this.txtPrice.TabIndex = 3;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(271, 106);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(84, 16);
            this.Label10.TabIndex = 76;
            this.Label10.Text = "Total Amount";
            // 
            // txtAvailableQty
            // 
            this.txtAvailableQty.Location = new System.Drawing.Point(370, 64);
            this.txtAvailableQty.Name = "txtAvailableQty";
            this.txtAvailableQty.ReadOnly = true;
            this.txtAvailableQty.Size = new System.Drawing.Size(89, 26);
            this.txtAvailableQty.TabIndex = 5;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(148, 94);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(120, 24);
            this.dtpInvoiceDate.TabIndex = 124;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(148, 129);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(185, 20);
            this.txtCustomerID.TabIndex = 125;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(148, 160);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(353, 20);
            this.txtCustomerName.TabIndex = 126;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(349, 64);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(29, 21);
            this.Button4.TabIndex = 128;
            this.Button4.Text = "<";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(349, 130);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(29, 21);
            this.Button1.TabIndex = 127;
            this.Button1.Text = "<";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(148, 63);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(185, 20);
            this.txtInvoiceNo.TabIndex = 123;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(23, 66);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 16);
            this.Label4.TabIndex = 121;
            this.Label4.Text = "Invoice No.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(23, 130);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(78, 16);
            this.Label1.TabIndex = 119;
            this.Label1.Text = "Customer ID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(23, 163);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(102, 16);
            this.Label2.TabIndex = 120;
            this.Label2.Text = "Customer Name";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(23, 98);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 16);
            this.Label3.TabIndex = 122;
            this.Label3.Text = "Invoice Date";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.White;
            this.Label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.Purple;
            this.Label13.Location = new System.Drawing.Point(22, 24);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(71, 25);
            this.Label13.TabIndex = 118;
            this.Label13.Text = "Billing";
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Product Name";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 270;
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.columnHeader6,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.ListView1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(26, 352);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(651, 314);
            this.ListView1.TabIndex = 130;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Product ID";
            this.columnHeader6.Width = 80;
            // 
            // frmAdminPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 676);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.ListView1);
            this.Name = "frmAdminPO";
            this.Text = "frmAdminPO";
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
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
        internal System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button NewRecord;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Button Save;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.TextBox txtProductID;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        public System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtTotalAmount;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtProductName;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtSaleQty;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtAvailableQty;
        internal System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        public System.Windows.Forms.TextBox txtCustomerID;
        public System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtInvoiceNo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        public System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}