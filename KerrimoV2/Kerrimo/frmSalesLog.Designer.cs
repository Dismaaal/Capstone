namespace Kerrimo
{
    partial class frmSalesLog
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpInvoiceDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpInvoiceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(8, 99);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(1017, 540);
            this.DataGridView1.TabIndex = 20;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.Location = new System.Drawing.Point(-1, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1312, 665);
            this.TabControl1.TabIndex = 2;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.label9);
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Controls.Add(this.DataGridView1);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1304, 632);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "By Order Date";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1126, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.TextBox3);
            this.GroupBox3.Controls.Add(this.TextBox2);
            this.GroupBox3.Controls.Add(this.TextBox1);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Location = new System.Drawing.Point(1031, 91);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(265, 142);
            this.GroupBox3.TabIndex = 21;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Total";
            this.GroupBox3.Visible = false;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(127, 99);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(124, 26);
            this.TextBox3.TabIndex = 25;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(127, 62);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(124, 26);
            this.TextBox2.TabIndex = 25;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(127, 26);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(124, 26);
            this.TextBox1.TabIndex = 24;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(18, 102);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(90, 18);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Total Change";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(18, 66);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 18);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Total Payment";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(18, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 18);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Amount";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Purple;
            this.GroupBox2.Controls.Add(this.button8);
            this.GroupBox2.Controls.Add(this.Button3);
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Controls.Add(this.Button2);
            this.GroupBox2.Location = new System.Drawing.Point(354, 7);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(431, 87);
            this.GroupBox2.TabIndex = 19;
            this.GroupBox2.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(318, 21);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 48);
            this.button8.TabIndex = 23;
            this.button8.Text = "&View Report";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(218, 19);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(94, 55);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "&Export Excel";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.White;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(18, 26);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(94, 40);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "&Get Data";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.White;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(118, 26);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(94, 40);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "&Reset";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dtpInvoiceDateTo);
            this.GroupBox1.Controls.Add(this.dtpInvoiceDateFrom);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(8, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(331, 87);
            this.GroupBox1.TabIndex = 18;
            this.GroupBox1.TabStop = false;
            // 
            // dtpInvoiceDateTo
            // 
            this.dtpInvoiceDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpInvoiceDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDateTo.Location = new System.Drawing.Point(190, 42);
            this.dtpInvoiceDateTo.Name = "dtpInvoiceDateTo";
            this.dtpInvoiceDateTo.Size = new System.Drawing.Size(120, 26);
            this.dtpInvoiceDateTo.TabIndex = 107;
            // 
            // dtpInvoiceDateFrom
            // 
            this.dtpInvoiceDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpInvoiceDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDateFrom.Location = new System.Drawing.Point(24, 42);
            this.dtpInvoiceDateFrom.Name = "dtpInvoiceDateFrom";
            this.dtpInvoiceDateFrom.Size = new System.Drawing.Size(120, 26);
            this.dtpInvoiceDateFrom.TabIndex = 106;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(20, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 18);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "From";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(186, 18);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(24, 18);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "To";
            // 
            // frmSalesLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 664);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmSalesLog";
            this.Text = "SalesLog";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        public System.Windows.Forms.Label label9;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button button8;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DateTimePicker dtpInvoiceDateTo;
        internal System.Windows.Forms.DateTimePicker dtpInvoiceDateFrom;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;

    }
}