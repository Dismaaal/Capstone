using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Kerrimo
{
    public partial class frmRegistration : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

        private void auto()
        {
            lblEmpID.Text = "E-" + GetUniqueKey(6);
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

        public frmRegistration()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtUsername.Text = "";
            cmbUserType.SelectedIndex = -1;
            txtPassword.Text = "";
            txtContact_no.Text = "";
            txtName.Text = "";
            txtEmail_Address.Text = "";
            txtBranch.Text = "";
            btnRegister.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            txtUsername.Focus();
            lblusertype.Text = "";
        }
        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT USERNAME FROM tblUserData", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tblUserData");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["USERNAME"].ToString());

                }
                txtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtUsername.AutoCompleteCustomSource = col;
                txtUsername.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (cmbUserType.Text == "")
            {
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserType.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtContact_no.Text == "")
            {
                MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact_no.Focus();
                return;
            }
            if (txtEmail_Address.Text == "")
            {
                MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail_Address.Focus();
                return;
            }
            if (txtBranch.Text == "")
            {
                MessageBox.Show("Please enter branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBranch.Focus();
                return;
            }
            if (cmbUserType.Text == "Admin")
            {
                lblusertype.Text = "1";
            }
            else
            {
                lblusertype.Text = "2";
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select USERNAME from tblUserData where username=@find";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "USERNAME"));
                cmd.Parameters["@find"].Value = txtUsername.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtUsername.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct1 = "select Email from tblUserData where Email='" + txtEmail_Address.Text + "'";

                cmd = new SqlCommand(ct1);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Email ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail_Address.Text = "";
                    txtEmail_Address.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();
                auto();
                string ePass = Helper.ComputeHash(txtPassword.Text, "SHA512", null);    
                string cb = "insert into tblUserData ([Employee ID],Username,Password,[Priviledge Level],UsertYpe,Contact,Email,Name,JoiningDate,BRANCH) VALUES ('" + lblEmpID.Text + "','" + txtUsername.Text + "','" + ePass + "','" + lblusertype.Text + "','" + cmbUserType.Text + "','" + txtContact_no.Text + "','" + txtEmail_Address.Text + "','" + txtName.Text + "','" + System.DateTime.Now + "','" + txtBranch.Text + "')";
            
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnRegister.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                if (txtUsername.Text == "admin")
                {
                    MessageBox.Show("Admin Account can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "delete from tblUserData where Username='" + txtUsername.Text + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Autocomplete();
                    Reset();
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

        private void cmbUserType_TextChanged(object sender, EventArgs e)
        {
            if (cmbUserType.Text == "Admin")
            {

            }
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select username from tblUserData where username='" + txtUsername.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Username not available", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!rdr.Read())
                {
                    MessageBox.Show("Username available", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();

                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_Address_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail_Address.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail_Address.Text))
                {
                    MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail_Address.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9_]");
            if (txtUsername.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtUsername.Text))
                {
                    MessageBox.Show("only letters,numbers and underscore is allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate_record.Enabled = true;
            try
            {
                txtUsername.Text = txtUsername.Text.TrimEnd();
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                //cmd.CommandText = "SELECT Usertype,password,name,[CONTACT],email FROM registration WHERE username = '" + txtUsername.Text.Trim() + "'";
                //cmd.CommandText = "SELECT usertype,name,contact,email,branch,tblUserData.[PASSWORD] FROM tblUserData INNER JOIN tblUserData on tblUserData.[EMPLOYEE ID]=tblUserData.[EMPLOYEE ID] WHERE username = '" + txtUsername.Text.Trim() + "'";
                cmd.CommandText = "SELECT [EMPLOYEE ID],Usertype,password,name,[CONTACT],email,branch,[PRIVILEDGE LEVEL] FROM tblUserData WHERE username = '" + txtUsername.Text.Trim() + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    lblEmpID.Text = (rdr.GetString(0).Trim());                   
                    cmbUserType.Text = (rdr.GetString(1).Trim());
                    txtPassword.Text = (rdr.GetString(2).Trim());
                    txtName.Text = (rdr.GetString(3).Trim());
                    txtContact_no.Text = (rdr.GetString(4).Trim());
                    txtEmail_Address.Text = (rdr.GetString(5).Trim());
                    txtBranch.Text = (rdr.GetString(6).Trim());
                    lblusertype.Text = (rdr.GetInt32(7).ToString().Trim());                       
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (cmbUserType.Text == "")
            {
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserType.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtContact_no.Text == "")
            {
                MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact_no.Focus();
                return;
            }
            if (txtEmail_Address.Text == "")
            {
                MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail_Address.Focus();
                return;
            }
            if (txtBranch.Text == "")
            {
                MessageBox.Show("Please enter branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBranch.Focus();
                return;
            }
            if (cmbUserType.Text == "Admin")
            {
                lblusertype.Text = "1";
            }
            else
            {
                lblusertype.Text = "2";
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update tblUserData set usertype='" + cmbUserType.Text + "',[PRIVILEDGE LEVEL]='" + lblusertype.Text.ToString() + "', password='" + txtPassword.Text + "',[CONTACT]='" + txtContact_no.Text + "',email='" + txtEmail_Address.Text + "',name='" + txtName.Text + "',branch='" + txtBranch.Text + "' where username='" + txtUsername.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Successfully updated", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnUpdate_record.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            frmUsersLog frm = new frmUsersLog();
            frm.dataGridView1.DataSource = frm.GetData();
            frm.Show();
        }

        private void lblusertype_Click(object sender, EventArgs e)
        {

        }
    }
}
