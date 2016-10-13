using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Kerrimo
{
    public partial class frmSupplies : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

        public frmSupplies()
        {
            InitializeComponent();
        }
        private void auto()
        {
            txtSuppliesID.Text = "SL-" + GetUniqueKey(6);
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

        private void Reset()
        {
            txtSuppliesID.Text = "";
            txtProductID.Text = "";
            txtSuppliesName.Text = "";
            txtUnit.Text = "";
            txtPrice.Text = "";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtSuppliesName.Focus();
        }

        private void frmSupplies_Load(object sender, EventArgs e)
        {

        }

        private void txtSuppliesName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSuppliesName.Text == "")
            {
                MessageBox.Show("Please enter supplies name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuppliesName.Focus();
                return;
            }

            if (txtUnit.Text == "")
            {
                MessageBox.Show("Please enter unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnit.Focus();
            }

            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select SuppliesName from Supplies_List where SuppliesName='" + txtSuppliesName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Supplies Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSuppliesName.Text = "";
                    txtSuppliesName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                auto();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "insert into Supplies_List(SuppliesID,SuppliesName,Price,Unit,ProductID) VALUES('"+txtSuppliesID.Text + "','" + txtSuppliesName.Text + "','" + txtPrice.Text + "','" + txtUnit.Text +"','" +txtProductID.Text + "')";
                //string cb = "insert into Product(ProductID,ProductName,Price,Image) VALUES ('" + txtProductID.Text + "','" + txtProductName.Text + "','" + txtPrice.Text + "',@d2)";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT distinct SuppliesName FROM Supplies_List", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Supplies_List");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["SuppliesName"].ToString());

                }
                txtSuppliesName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSuppliesName.AutoCompleteCustomSource = col;
                txtSuppliesName.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete_records();
        }
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from Supplies_List where SuppliesID='" + txtSuppliesID.Text + "'";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    Autocomplete();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    Autocomplete();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSuppliesName.Text == "")
            {
                MessageBox.Show("Please enter Supply name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuppliesName.Focus();
                return;
            }
            if (txtUnit.Text == "")
            {
                MessageBox.Show("Please enter Unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnit.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update Supplies_List set SuppliesID='" + txtSuppliesID.Text + "',Price=" + txtPrice.Text + " + ,Unit='" + txtUnit.Text + "',SuppliesName='" + txtSuppliesName.Text + "',ProductID='" + txtProductID.Text + "' Where [SuppliesID]='" + txtSuppliesID.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductsLog1 frm = new frmProductsLog1();
            frm.Show();
            frm.GetData();
        }

    }
}
