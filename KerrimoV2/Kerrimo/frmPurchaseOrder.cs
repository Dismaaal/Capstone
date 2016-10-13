using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;
using System.Data.SqlClient;

namespace Kerrimo
{
    public partial class frmPurchaseOrder : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        frmProductsLog3 frm;
   
     

       

 
        private void auto()
        {
            txtOrderNo.Text = "ON-" + GetUniqueKey(8);

        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
      
        private void GetCustData()
        {
           
            con = new SqlConnection(cs.DBConn);
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT [EMPLOYEE ID],[NAME] FROM tblUserData WHERE [EMPLOYEE ID]= '" + txtCustomerID.Text.Trim() + "'";
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                txtCustomerID.Text = (rdr.GetString(0).Trim());
                txtCustomerName.Text = (rdr.GetString(1).Trim());
            }

            if ((rdr != null))
            {
                rdr.Close();
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public frmPurchaseOrder()
        {
            InitializeComponent();
            frm = new frmProductsLog3(this);
          
            

        }
        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
           
            GetCustData();
            panel3.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
            frm.label1.Text = label8.Text;
            frm.ShowDialog();
        }

        public void Calculate()
        {
            if (txtTaxPer.Text != "")
            {
                txtTaxAmt.Text = Convert.ToInt32((Convert.ToInt32(txtSubTotal.Text) * Convert.ToDouble(txtTaxPer.Text) / 100)).ToString();

            }
            if (txtDiscountPer.Text != "")
            {
                txtDiscountAmount.Text = Convert.ToInt32(((Convert.ToInt32(txtSubTotal.Text) + Convert.ToInt32(txtTaxAmt.Text)) * Convert.ToDouble(txtDiscountPer.Text) / 100)).ToString();
            }
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
            int val4 = 0;
            int val5 = 0;
            int.TryParse(txtTaxAmt.Text, out val1);
            int.TryParse(txtSubTotal.Text, out val2);
            int.TryParse(txtDiscountAmount.Text, out val3);
            int.TryParse(txtTotal.Text, out val4);
            int.TryParse(txtTotalPayment.Text, out val5);
            val4 = val1 + val2 - val3;
            txtTotal.Text = val4.ToString();
            int I = (val4 - val5);
            txtPaymentDue.Text = I.ToString();


        }

        public double subtot()
        {
            int i = 0;
            int j = 0;
            double k = 0;
            i = 0;
            j = 0;
            k = 0;


            try
            {

                j = ListView1.Items.Count;
                for (i = 0; i <= j - 1; i++)
                {
                    k = k + Convert.ToDouble(ListView1.Items[i].SubItems[6].Text);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return k;

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplyName.Text == "")
                {
                    MessageBox.Show("Please retrieve Supply Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSupplyName.Focus();
                    return;
                }

                if (txtUnit.Text == "")
                {
                    MessageBox.Show("Please retrieve Unit", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtSQty.Text == "")
                {
                    MessageBox.Show("Please enter no. of buy quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSQty.Focus();
                    return;
                }
                int SaleQty = Convert.ToInt32(txtSQty.Text);
                if (SaleQty <= 0)
                {
                    MessageBox.Show("no. of sale quantity can not be negative or zero", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSQty.Focus();
                    return;
                }

                if (ListView1.Items.Count == 0)
                {

                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add(txtSuppliesID.Text);
                    lst.SubItems.Add(txtSupplyName.Text);
                    lst.SubItems.Add(txtSQty.Text);
                    lst.SubItems.Add(txtUnit.Text);
                    lst.SubItems.Add(txtPrice.Text);
                    lst.SubItems.Add(txtTotalAmount.Text);
                    ListView1.Items.Add(lst);
                    txtSubTotal.Text = subtot().ToString();

                    Calculate();
                    txtSupplyName.Text = "";
                    txtSuppliesID.Text = "";
                    txtUnit.Text = "";
                    txtPrice.Text = "";
                    txtAQty.Text = "";
                    txtSQty.Text = "";
                    txtTotalAmount.Text = "";
                    //txtProduct.Text = "";
                    return;
                }

                for (int j = 0; j <= ListView1.Items.Count - 1; j++)
                {
                    if (ListView1.Items[j].SubItems[1].Text == txtSuppliesID.Text)
                    {
                        ListView1.Items[j].SubItems[1].Text = txtSuppliesID.Text;
                        ListView1.Items[j].SubItems[2].Text = txtSupplyName.Text;
                        ListView1.Items[j].SubItems[4].Text = txtUnit.Text;
                        ListView1.Items[j].SubItems[5].Text = txtPrice.Text;
                        ListView1.Items[j].SubItems[3].Text = (Convert.ToInt32(ListView1.Items[j].SubItems[3].Text) + Convert.ToInt32(txtSQty.Text)).ToString();
                        ListView1.Items[j].SubItems[6].Text = (Convert.ToDecimal(ListView1.Items[j].SubItems[6].Text) + Convert.ToDecimal(txtTotalAmount.Text)).ToString();
                        txtSubTotal.Text = subtot().ToString();
                        Calculate();
                        txtSupplyName.Text = "";
                        txtSuppliesID.Text = "";
                        txtUnit.Text = "";
                        txtPrice.Text = "";
                        txtAQty.Text = "";
                        txtSQty.Text = "";
                        txtTotalAmount.Text = "";
                        return;

                    }
                }

                ListViewItem lst1 = new ListViewItem();

                lst1.SubItems.Add(txtSuppliesID.Text);
                lst1.SubItems.Add(txtSupplyName.Text);
                lst1.SubItems.Add(txtSQty.Text);
                lst1.SubItems.Add(txtUnit.Text);
                lst1.SubItems.Add(txtPrice.Text);         
                lst1.SubItems.Add(txtTotalAmount.Text);
                ListView1.Items.Add(lst1);
                txtSubTotal.Text = subtot().ToString();
                Calculate();
                txtSupplyName.Text = "";
                txtSuppliesID.Text = "";
                txtUnit.Text = "";
                txtPrice.Text = "";
                txtAQty.Text = "";
                txtSQty.Text = "";
                txtTotalAmount.Text = "";
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int val2 = 0;
        int val3 = 0;
        private void txtSQty_TextChanged(object sender, EventArgs e)
        {
            
            int.TryParse(txtAQty.Text, out val3);
            decimal val1 = 0;
            
            var parsed = decimal.TryParse(txtPrice.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture.NumberFormat,
                out val1);
            int.TryParse(txtSQty.Text, out val2);
            decimal I = (val1 * val2);
            txtTotalAmount.Text = I.ToString();
            if (val3 < val2)
            {
                MessageBox.Show("Insufficient Stocks","Input Error");
            }
        }
        private void Reset()
        {
            txtOrderNo.Text = "";
            txtSuppliesID.Text = "";
            txtSupplyName.Text = "";
            txtUnit.Text = "";
            txtPrice.Text = "";
            txtSQty.Text = "";
            txtAQty.Text = "";
            txtTotalAmount.Text = "";

            cmbPaymentType.Text = "";
            dtpInvoiceDate.Text = DateTime.Today.ToString();
           // txtCustomerID.Text = "";
           // txtCustomerName.Text = "";
            txtPrice.Text = "";
            txtTotalAmount.Text = "";
            ListView1.Items.Clear();
            txtDiscountAmount.Text = "";
            txtDiscountPer.Text = "";

            txtSubTotal.Text = "";
            txtTaxPer.Text = "";
            txtTaxAmt.Text = "";
            txtTotal.Text = "";
            txtTotalPayment.Text = "";
            txtPaymentDue.Text = "";
          
            Save.Enabled = true;
            btnRemove.Enabled = false;
            ListView1.Enabled = true;
            btnAddOrder.Enabled = true;

        }



        private void NewRecord_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListView1.Items.Count == 0)
                {
                    MessageBox.Show("No items to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int itmCnt = 0;
                    int i = 0;
                    int t = 0;

                    ListView1.FocusedItem.Remove();
                    itmCnt = ListView1.Items.Count;
                    t = 1;

                    for (i = 1; i <= itmCnt + 1; i++)
                    {
                        //Dim lst1 As New ListViewItem(i)
                        //ListView1.Items(i).SubItems(0).Text = t
                        t = t + 1;

                    }
                    txtSubTotal.Text = subtot().ToString();
                    Calculate();
                }

                btnRemove.Enabled = false;
                if (ListView1.Items.Count == 0)
                {
                    txtSubTotal.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (val3 < val2)
            {
                MessageBox.Show("Insufficient Stocks", "Input Error");
            }
            try
            {
             auto();
               
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert Into PO(OrderNo,OrderDate,[EMPLOYEE ID],SubTotal,VATPer,VATAmount,DiscountPer,DiscountAmount,GrandTotal,TotalPayment,PaymentDue,Status,Remarks) VALUES ('" + txtOrderNo.Text + "','" + dtpInvoiceDate.Text + "','" + txtCustomerID.Text + "','" + txtSubTotal.Text + "','" + txtTaxPer.Text + "','" + txtTaxAmt.Text + "','"+ txtDiscountPer.Text +"','"+ txtDiscountAmount.Text +"','" + txtTotal.Text + "','" + txtTotalPayment.Text + "','" + txtPaymentDue.Text + "','Confirmed','" + txtRemarks.Text +"')";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Close();


                for (int i = 0; i <= ListView1.Items.Count - 1; i++)
                {
                    con = new SqlConnection(cs.DBConn);

                    string cd = "insert Into SO(OrderNo,SuppliesID,SuppliesName,Unit,Price,Quantity,TotalAmount) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)";
                    cmd = new SqlCommand(cd);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("d1", txtOrderNo.Text);
                    cmd.Parameters.AddWithValue("d2", ListView1.Items[i].SubItems[1].Text);
                    cmd.Parameters.AddWithValue("d3", ListView1.Items[i].SubItems[2].Text);
                    cmd.Parameters.AddWithValue("d4", ListView1.Items[i].SubItems[4].Text);
                    cmd.Parameters.AddWithValue("d5", ListView1.Items[i].SubItems[5].Text);
                    cmd.Parameters.AddWithValue("d6", ListView1.Items[i].SubItems[3].Text);
                    cmd.Parameters.AddWithValue("d7", ListView1.Items[i].SubItems[6].Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
     
                Save.Enabled = false;
                btnPrint.Enabled = true;
               // GetData();
                MessageBox.Show("Successfully Placed", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                rptOrder rpt = new rptOrder();
                //The report you created.
                cmd = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                KERRIMOproj myDS = new KERRIMOproj();
                myDS.EnforceConstraints = false;
                //The DataSet you created.
                con = new SqlConnection(cs.DBConn);
                cmd.Connection = con;
                cmd.CommandText = "SELECT * from Supplies_List,PO,SO,tblUserData where PO.OrderNo=SO.OrderNo and PO.[EMPLOYEE ID]=tblUserData.[EMPLOYEE ID] and SO.SuppliesID=Supplies_List.SuppliesID and PO.OrderNo='" + txtOrderNo.Text + "'";
                cmd.CommandType = CommandType.Text;
                myDA.SelectCommand = cmd;
                myDA.Fill(myDS, "Supplies_List");
                myDA.Fill(myDS, "PO");
                myDA.Fill(myDS, "SO");
                myDA.Fill(myDS, "tblUserData");
                rpt.SetDataSource(myDS);
                frmInvoiceReport frm = new frmInvoiceReport();
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String cb = "update PO set [EMPLOYEE ID]='" + txtCustomerID.Text + "', VATPer=" + txtTaxPer.Text + ",VATAmount=" + txtTaxAmt.Text + ",DiscountPer=" + txtDiscountPer.Text + ",DiscountAmount=" + txtDiscountAmount.Text + ",GrandTotal= " + txtTotal.Text + ",TotalPayment= " + txtTotalPayment.Text + ",PaymentDue= " + txtPaymentDue.Text + ",Remarks='" + txtRemarks.Text + "',Status='" + cmbStatus.Text + "' where OrderNo= '" + txtOrderNo.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();

                //GetData();
                btnUpdate.Enabled = false;
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }

        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq1 = "delete from SO where OrderNo='" + txtOrderNo.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from PO where OrderNo='" + txtOrderNo.Text + "'";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtTaxPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTaxPer.Text))
                {
                    txtTaxAmt.Text = "";
                    txtTotal.Text = "";
                    return;
                }
                Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiscountPer_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }





    }

