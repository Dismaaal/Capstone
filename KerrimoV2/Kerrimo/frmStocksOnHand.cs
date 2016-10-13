using System;
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
    public partial class frmStocksOnHand : Form
    {
        SqlDataReader rdr = null;
        SqlConnection con = null;
        SqlCommand cmd = null;
        ConnectionString cs = new ConnectionString();
        public frmStocksOnHand()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String sql = "SELECT Supplies_List.SuppliesID,SuppliesName,Unit,Price,sum(Quantity),sum(Price*Quantity) from Temp_Stock,Supplies_List where Temp_Stock.SuppliesID=Supplies_List.SuppliesID group by Supplies_List.SuppliesID,suppliesname,Price,unit,Quantity having(Quantity>0)  order by SuppliesName";
                cmd = new SqlCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
                }
                foreach (DataGridViewRow r in this.dataGridView1.Rows)
                {
                    if (Convert.ToInt32(r.Cells[4].Value) < 100)
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(r.Cells[4].Value) < 200 && Convert.ToInt32(r.Cells[4].Value) >= 100)
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmStocksOnHand_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSuppliesName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String sql = "SELECT Supplies_List.SuppliesID,SuppliesName,Unit,Price,sum(Quantity),sum(Price*Quantity) from Temp_Stock,Supplies_List where Temp_Stock.SuppliesID=Supplies_List.SuppliesID and SuppliesName like '" + txtSuppliesName.Text + "%' group by Supplies_List.SuppliesID,suppliesname,Price,unit,Quantity having(Quantity>0)  order by SuppliesName";
                cmd = new SqlCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
                }
                foreach (DataGridViewRow r in this.dataGridView1.Rows)
                {
                    if (Convert.ToInt32(r.Cells[4].Value) < 100)
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(r.Cells[4].Value) < 200 && Convert.ToInt32(r.Cells[4].Value) >= 100)
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
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

                rowsTotal = dataGridView1.RowCount - 1;
                colsTotal = dataGridView1.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView1.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView1.Rows[I].Cells[j].Value;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                rptStocks rpt = new rptStocks();
                //The report you created.
                cmd = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                KERRIMOproj myDS = new KERRIMOproj();
                //The DataSet you created.
                con = new SqlConnection(cs.DBConn);
                cmd.Connection = con;
                cmd.CommandText = "SELECT Supplies_List.SuppliesID,SuppliesName,Unit,Price,sum(Quantity),sum(Price*Quantity) from Temp_Stock,Supplies_List where Temp_Stock.SuppliesID=Supplies_List.SuppliesID and SuppliesName like '" + txtSuppliesName.Text + "&' group by Supplies_List.SuppliesID,suppliesname,Price,unit,Quantity having(Quantity>0)  order by SuppliesName";
                cmd.CommandType = CommandType.Text;
                myDA.SelectCommand = cmd;
                myDA.Fill(myDS, "temp_Stock");
                myDA.Fill(myDS, "Supplies_List");
                rpt.SetDataSource(myDS);
                frmStockReport frm = new frmStockReport();
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                StockOnHand rpt = new StockOnHand();
                //The report you created.
                cmd = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                KERRIMOproj myDS = new KERRIMOproj();
                //The DataSet you created.
                SqlConnection con = new SqlConnection(cs.DBConn);
                cmd.Connection = con;
                cmd.CommandText = "SELECT * from Supplies_List";
                cmd.CommandType = CommandType.Text;
                myDA.SelectCommand = cmd;
                myDA.Fill(myDS, "Supplies_List");
                //myDA.Fill(myDS, "Stock");
                //myDA.Fill(myDS, "Customer");
                rpt.SetDataSource(myDS);
                frmSOHReport frm = new frmSOHReport();
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
