using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kerrimo
{
    public partial class frmLogin : Form
    {
       

        public frmLogin()
        {
            InitializeComponent();
        }
        //Used to move the form
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);

        }

        #region properties

        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string PriviledgeLevel
        {
            get { return lblPriviledge.Text; }
            set { lblPriviledge.Text = value; }
        }
        public string EmployeeID;
        int count = 0;
        #endregion
        ConnectionString cs = new ConnectionString();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
             if (txtPassword.Text == "")
             {
                 MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtPassword.Focus();
                 return;
             }

             try
             {
                 SqlConnection myConnection = default(SqlConnection);
                 myConnection = new SqlConnection(cs.DBConn);
                 myConnection.Open();
                using (SqlCommand cmd = new SqlCommand("Select USERNAME,PASSWORD from tblUserData where USERNAME=@USERNAME", myConnection))
                {
                    cmd.Parameters.AddWithValue("@USERNAME", txtUsername.Text);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    string un = dt.Rows[0]["USERNAME"].ToString();
                    string password = dt.Rows[0]["PASSWORD"].ToString();
                    bool flag = Helper.VerifyHash(txtPassword.Text, "SHA512", password);

                    if (un == txtUsername.Text && flag == true)
                    {
                        SqlCommand checkCredentialsLogin = new SqlCommand("Select * from tblUserData where USERNAME = '" + Username + "' and PASSWORD ='" +password + "' COLLATE Latin1_General_CS_AS", myConnection);
                        SqlDataReader loginReader = checkCredentialsLogin.ExecuteReader();

                        while (loginReader.Read())
                        {
                            count++;
                            PriviledgeLevel = loginReader["PRIVILEDGE LEVEL"].ToString();
                            EmployeeID = loginReader["EMPLOYEE ID"].ToString();
                            int i;
                            ProgressBar1.Visible = true;
                            ProgressBar1.Maximum = 5000;
                            ProgressBar1.Minimum = 0;
                            ProgressBar1.Value = 4;
                            ProgressBar1.Step = 1;

                            for (i = 0; i <= 5000; i++)
                            {
                                ProgressBar1.PerformStep();
                            }

                        }
                        if (count == 1)
                        {
                            MessageBox.Show("Login Success!");
                            this.Hide();
                            frmNewMain main = new frmNewMain(this, PriviledgeLevel, EmployeeID);
                            main.lblUser.Text = txtUsername.Text;

                            main.Show();
                            count = 0;
                        }
                        //Form frmMain = new frmMain(this, PriviledgeLevel, EmployeeID);
                        else if (count == 2)
                        {
                            MessageBox.Show("Login Success!");
                            this.Hide();
                            frmNewMain main = new frmNewMain(this, PriviledgeLevel, EmployeeID);
                            main.lblUser.Text = txtUsername.Text;

                            main.Show();
                            count = 0;
                        }

                        else
                        {
                            MessageBox.Show("Invalid Login");
                            count = 0;
                            Password = "";
                        }


                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                        count = 0;
                        Password = "";
                    }
                    myConnection.Close();
                    myConnection.Dispose();
                }
              

            }
             catch (Exception)
             {
                MessageBox.Show("Invalid Login");
                count = 0;
                Password = "";
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ProgressBar1.Visible = false;
            txtUsername.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(null, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        
    }
}
