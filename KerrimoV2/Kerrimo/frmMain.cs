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
    public partial class frmMain : Form
    {

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
        Point dragOffset;
        frmLogin getdataLogin;
        public string getEmployeeData;
        public string getPriviledgeLevel;


        public frmMain(frmLogin dataLogin, string PriviledgeLevel, string EmployeeID)
        {
            
            InitializeComponent();
            getPriviledgeLevel = PriviledgeLevel;
            getdataLogin = dataLogin;
            getEmployeeData = EmployeeID;
            ToolStripStatusLabel4.Text = System.DateTime.Now.ToString();
          
        }

        public void LoadDatabase()
        {
            try
            {
                ConnectionString cs = new ConnectionString();
                SqlConnection connectStudent = new SqlConnection(cs.DBConn);
                connectStudent.Open();

                SqlCommand getEmployeeID = new SqlCommand("Select * from tblUserData where [EMPLOYEE ID] = '" + getEmployeeData + "'", connectStudent);
                SqlDataReader findID = getEmployeeID.ExecuteReader();
                findID.Read();

                connectStudent.Close();
                connectStudent.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (getPriviledgeLevel == "2")
            {
                toolStripUsers.Visible = false;
                
            }
            else  
            {
                
            }
 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDatabase();
            
        }

        private void toolStripPOS_Click(object sender, EventArgs e)
        {
            frmPOS pos = new frmPOS();
            pos.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.PointToScreen(e.Location);

                newLocation.X -= dragOffset.X;
                newLocation.Y -= dragOffset.Y;

                FindForm().Location = newLocation;
            }
        }

        private void toolStripInventory_Click(object sender, EventArgs e)
        {
            frmInventory pos = new frmInventory();
            pos.ShowDialog();
        }



       

        private void toolStripUsers_ButtonClick(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.ShowDialog();
        }

        private void suppliersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSuppliers frm = new frmSuppliers();
            frm.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesLog sl = new frmSalesLog();
            sl.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsLog1 p2 = new frmProductsLog1();
            p2.ShowDialog();
        }

        private void suppliersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSuppliersLog sl = new frmSuppliersLog();
            sl.ShowDialog();
        }


        private void toolStripLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.txtUsername.Text = "";
            frm.txtPassword.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.txtUsername.Focus();
        }

        private void addStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStocks st = new frmStocks();
            st.ShowDialog();
        }

        private void stocksOnHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStocksOnHand st = new frmStocksOnHand();
            st.ShowDialog();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStocksLog st = new frmStocksLog();
            st.ShowDialog();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder frm = new frmPurchaseOrder();
            frm.txtCustomerID.Text = getEmployeeData;
            frm.ShowDialog();
        }

        private void trackOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdersList frm = new frmOrdersList();
            frm.txtCustomerID.Text = getEmployeeData;
            frm.ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminPO frm = new frmAdminPO();
            frm.ShowDialog();
        }

        private void toolStripUsers_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStocks_Click(object sender, EventArgs e)
        {

        }
       
 

        

        

      

       

    }
}
