﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace Kerrimo
{
    public partial class frmOrdersList : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
        SqlDataReader rdr;

        public frmOrdersList()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (DataGridView3.DataSource == null)
            {
                MessageBox.Show("Sorry nothing to export into excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;

                rowsTotal = DataGridView3.RowCount - 1;
                colsTotal = DataGridView3.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = DataGridView3.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = DataGridView3.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }  
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            DataGridView3.DataSource = null;
            GroupBox4.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                GroupBox3.Visible = true;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(OrderNo) as [Order No],RTRIM(OrderDate) as [Order Date],RTRIM(PO.[Employee id]) as [Employee ID],RTRIM(Name) as [Customer Name],RTRIM(SubTotal) as [SubTotal],RTRIM(VATPer) as [Vat+ST %],RTRIM(VATAmount) as [VAT+ST Amount],RTRIM(DiscountPer) as [Discount %],RTRIM(DiscountAmount) as [Discount Amount],RTRIM(GrandTotal) as [Grand Total],RTRIM(TotalPayment) as [Total Payment],RTRIM(PaymentDue) as [Payment Due],RTRIM(Status) as [Status],Remarks from PO,tblUserData where PO.[Employee ID]=tblUserData.[Employee ID] and OrderDate between @d1 and @d2 and tblUserData.[Employee ID]='" + txtCustomerID.Text + "' order by OrderDate desc", con);
                cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "OrderDate").Value = dtpInvoiceDateFrom.Value.Date;
                cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "OrderDate").Value = dtpInvoiceDateTo.Value.Date;
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "PO");
                myDA.Fill(myDataSet, "tblUserData");
                DataGridView1.DataSource = myDataSet.Tables["tblUserData"].DefaultView;
                DataGridView1.DataSource = myDataSet.Tables["PO"].DefaultView;
                Int64 sum = 0;
                Int64 sum1 = 0;
                Int64 sum2 = 0;

                foreach (DataGridViewRow r in this.DataGridView1.Rows)
                {
                    Int64 i = Convert.ToInt64(r.Cells[9].Value);
                    Int64 j = Convert.ToInt64(r.Cells[10].Value);
                    Int64 k = Convert.ToInt64(r.Cells[11].Value);
                    sum = sum + i;
                    sum1 = sum1 + j;
                    sum2 = sum2 + k;

                }
                TextBox1.Text = sum.ToString();
                TextBox2.Text = sum1.ToString();
                TextBox3.Text = sum2.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TabControl1_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = null;
            dtpInvoiceDateFrom.Text = DateTime.Today.ToString();
            dtpInvoiceDateTo.Text = DateTime.Today.ToString();
            GroupBox3.Visible = false;
            DataGridView3.DataSource = null;
            GroupBox4.Visible = false;
        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void DataGridView3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (DataGridView3.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                DataGridView3.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                GroupBox4.Visible = true;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(OrderNo) as [Order No],RTRIM(OrderDate) as [Order Date],RTRIM(PO.[EMPLOYEE ID]) as [Employee ID],RTRIM(Name) as [Customer Name],RTRIM(SubTotal) as [SubTotal],RTRIM(VATPer) as [Vat+ST %],RTRIM(VATAmount) as [VAT+ST Amount],RTRIM(DiscountPer) as [Discount %],RTRIM(DiscountAmount) as [Discount Amount],RTRIM(GrandTotal) as [Grand Total],RTRIM(TotalPayment) as [Total Payment],RTRIM(PaymentDue) as [Payment Due],RTRIM(Status) as [Status],Remarks from PO,tblUserData where PO.[EMPLOYEE ID]=tblUserData.[EMPLOYEE ID] and tblUserData.[EMPLOYEE ID]='" + txtCustomerID.Text + "' order by Name,OrderDate", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "PO");
                myDA.Fill(myDataSet, "tblUserData");
                DataGridView3.DataSource = myDataSet.Tables["tblUserData"].DefaultView;
                DataGridView3.DataSource = myDataSet.Tables["PO"].DefaultView;
                Int64 sum = 0;
                Int64 sum1 = 0;
                Int64 sum2 = 0;

                foreach (DataGridViewRow r in this.DataGridView3.Rows)
                {
                    Int64 i = Convert.ToInt64(r.Cells[9].Value);
                    Int64 j = Convert.ToInt64(r.Cells[10].Value);
                    Int64 k = Convert.ToInt64(r.Cells[11].Value);
                    sum = sum + i;
                    sum1 = sum1 + j;
                    sum2 = sum2 + k;
                }
                TextBox6.Text = sum.ToString();
                TextBox5.Text = sum1.ToString();
                TextBox4.Text = sum2.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (DataGridView1.DataSource == null)
            {
                MessageBox.Show("Sorry nothing to export into excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;

                rowsTotal = DataGridView1.RowCount - 1;
                colsTotal = DataGridView1.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = DataGridView1.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = DataGridView1.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = null;
            dtpInvoiceDateFrom.Text = DateTime.Today.ToString();
            dtpInvoiceDateTo.Text = DateTime.Today.ToString();
            GroupBox3.Visible = false;
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = DataGridView1.SelectedRows[0];
                this.Hide();
                frmPurchaseOrder frmSales = new frmPurchaseOrder();
                // or simply use column name instead of index
                // dr.Cells["id"].Value.ToString();
                frmSales.Panel1.Visible = false;
                frmSales.panel3.Visible = true;
                frmSales.Show();
                frmSales.txtOrderNo.Text = dr.Cells[0].Value.ToString();
                frmSales.dtpInvoiceDate.Text = dr.Cells[1].Value.ToString();
                frmSales.txtCustomerID.Text = dr.Cells[2].Value.ToString();
                frmSales.txtCustomerName.Text = dr.Cells[3].Value.ToString();
                frmSales.txtSubTotal.Text = dr.Cells[4].Value.ToString();
                frmSales.txtTaxPer.Text = dr.Cells[5].Value.ToString();
                frmSales.txtTaxAmt.Text = dr.Cells[6].Value.ToString();
                frmSales.txtDiscountPer.Text = dr.Cells[7].Value.ToString();
                frmSales.txtDiscountAmount.Text = dr.Cells[8].Value.ToString();
                frmSales.txtTotal.Text = dr.Cells[9].Value.ToString();
                frmSales.txtTotalPayment.Text = dr.Cells[10].Value.ToString();
                frmSales.txtPaymentDue.Text = dr.Cells[11].Value.ToString();
                //frmSales.cmbPaymentType.Text = dr.Cells[12].Value.ToString();
                frmSales.cmbStatus.Text = dr.Cells[12].Value.ToString();
                frmSales.txtRemarks.Text = dr.Cells[13].Value.ToString();
                frmSales.btnUpdate.Enabled = true;
                frmSales.Delete.Enabled = true;
                frmSales.btnPrint.Enabled = true;
                frmSales.Save.Enabled = false;
                //frmSales.label6.Text = label9.Text;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT Supplies_List.SuppliesID,SO.SuppliesName,SO.Price,SO.Quantity,SO.TotalAmount from PO,SO,Supplies_List where PO.OrderNo=SO.OrderNo and Supplies_List.SuppliesID=SO.SuppliesID and PO.OrderNo='" + dr.Cells[0].Value.ToString() + "'", con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add(rdr[0].ToString().Trim());
                    lst.SubItems.Add(rdr[1].ToString().Trim());
                    lst.SubItems.Add(rdr[2].ToString().Trim());
                    lst.SubItems.Add(rdr[3].ToString().Trim());
                    lst.SubItems.Add(rdr[4].ToString().Trim());
                    frmSales.ListView1.Items.Add(lst);
                }
                frmSales.ListView1.Enabled = false;
                frmSales.btnAddOrder.Enabled = false;
                frmSales.btnAdd.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = DataGridView3.SelectedRows[0];
                this.Hide();
                frmPurchaseOrder frmSales = new frmPurchaseOrder();
                // or simply use column name instead of index
                // dr.Cells["id"].Value.ToString();
                frmSales.Panel1.Visible = false;
                frmSales.panel3.Visible = true;
                frmSales.Show();
                frmSales.txtOrderNo.Text = dr.Cells[0].Value.ToString();
                frmSales.dtpInvoiceDate.Text = dr.Cells[1].Value.ToString();
                frmSales.txtCustomerID.Text = dr.Cells[2].Value.ToString();
                frmSales.txtCustomerName.Text = dr.Cells[3].Value.ToString();
                frmSales.txtSubTotal.Text = dr.Cells[4].Value.ToString();
                frmSales.txtTaxPer.Text = dr.Cells[5].Value.ToString();
                frmSales.txtTaxAmt.Text = dr.Cells[6].Value.ToString();
                frmSales.txtDiscountPer.Text = dr.Cells[7].Value.ToString();
                frmSales.txtDiscountAmount.Text = dr.Cells[8].Value.ToString();
                frmSales.txtTotal.Text = dr.Cells[9].Value.ToString();
                frmSales.txtTotalPayment.Text = dr.Cells[10].Value.ToString();
                frmSales.txtPaymentDue.Text = dr.Cells[11].Value.ToString();
                //frmSales.cmbPaymentType.Text = dr.Cells[12].Value.ToString();
                frmSales.cmbStatus.Text = dr.Cells[12].Value.ToString();
                frmSales.txtRemarks.Text = dr.Cells[13].Value.ToString();
                frmSales.btnUpdate.Enabled = true;
                frmSales.Delete.Enabled = true;
                frmSales.btnPrint.Enabled = true;
                frmSales.Save.Enabled = false;
                frmSales.button2.Enabled = false;
                
                //frmSales.label6.Text = label9.Text;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT Supplies_List.SuppliesID,SO.SuppliesName,SO.Price,SO.Quantity,SO.TotalAmount from PO,SO,Supplies_List where PO.OrderNo=SO.OrderNo and Supplies_List.SuppliesID=SO.SuppliesID and PO.OrderNo='" + dr.Cells[0].Value.ToString() + "'", con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add(rdr[0].ToString().Trim());
                    lst.SubItems.Add(rdr[1].ToString().Trim());
                    lst.SubItems.Add(rdr[2].ToString().Trim());
                    lst.SubItems.Add(rdr[3].ToString().Trim());
                    lst.SubItems.Add(rdr[4].ToString().Trim());
                    frmSales.ListView1.Items.Add(lst);
                }
                frmSales.ListView1.Enabled = false;
                frmSales.btnAddOrder.Enabled = false;
                frmSales.btnAdd.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
    }
}
