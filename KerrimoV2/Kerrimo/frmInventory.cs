using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Kerrimo
{
    public partial class frmInventory : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

        private void auto()
        {
            txtProductID.Text = "P-" + GetUniqueKey(6);
        }
        private void autos()
        {
            txtSizeID.Text = "P-" + GetUniqueKey(6);
        }
        private void autof()
        {
            txtFlavorsID.Text = "P-" + GetUniqueKey(6);
        }
        private void autod()
        {
            txtDrinkID.Text = "P-" + GetUniqueKey(6);
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
            txtProductName.Text = "";
            txtSizeName.Text = "";
            txtPrice.Text = "";
            txtPriceSize.Text = "";
            txtDrinkID.Text = "";
            txtSizeID.Text = "";
            txtDrinkName.Text = "";
            txtFlavorsID.Text = "";
            txtFlavorName.Text = "";
            txtDrinksPrice.Text = "";
            txtFlavorsPrice.Text = "";
            pictureBox1.Image = null;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtProductName.Focus();

            btnDeleteSize.Enabled = false;
            btnUpdateSize.Enabled = false;
            btnSaveSize.Enabled = true;

            btnDeleteD.Enabled = false;
            btnUpdateD.Enabled = false;
            btnSaveD.Enabled = true;

            btnDeleteF.Enabled = false;
            btnUpdateF.Enabled = false;
            btnSaveF.Enabled = true;
        }

        public frmInventory()
        {
            InitializeComponent();
        }

        private void btnViewAllProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please enter product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
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
                string ct = "select ProductName from Product where ProductName='" + txtProductName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Product Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Text = "";
                    txtProductName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                auto();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                // string cb = "insert into Supplies_List(SuppliesID,SuppliesName,Price,Unit) VALUES('"+txtProductID.Text + "','" + txtProductName.Text + "','" + txtPrice.Text + "','" + txtUnit.Text +"')";
                string cb = "insert into Product(ProductID,ProductName,Price,Image) VALUES ('" + txtProductID.Text + "','" + txtProductName.Text + "','" + txtPrice.Text + "',@d2)";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;

                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d2", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnSave.Enabled = false;
                Save();
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
                SqlCommand cmd = new SqlCommand("SELECT distinct ProductName FROM product", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Product");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["productname"].ToString());

                }
                txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProductName.AutoCompleteCustomSource = col;
                txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please enter product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
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
                string cb = "Update Product set ProductName='" + txtProductName.Text + "',price=" + txtPrice.Text + ",Image=@d2 Where ProductID='" + txtProductID.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d2", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
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
            frmProductsLog frm = new frmProductsLog();
            frm.Show();
            frm.GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;

                _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                _with1.FilterIndex = 4;
                //Reset the file name
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal

            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
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

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from product where productID='" + txtProductID.Text + "'";
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

        private void frmInventory_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNewSize_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSaveSize_Click(object sender, EventArgs e)
        {
            if (txtSizeName.Text == "")
            {
                MessageBox.Show("Please enter size name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }

            if (txtPriceSize.Text == "")
            {
                MessageBox.Show("Please enter price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select SizeName from Size where SizeName ='" + txtSizeName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Size Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSizeName.Text = "";
                    txtSizeName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                autos();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                // string cb = "insert into Supplies_List(SuppliesID,SuppliesName,Price,Unit) VALUES('"+txtProductID.Text + "','" + txtProductName.Text + "','" + txtPrice.Text + "','" + txtUnit.Text +"')";
                string cb = "insert into Size([id],SizeName,SizePrice) VALUES ('" + txtSizeID.Text + "','" + txtSizeName.Text + "','" + txtPriceSize.Text + "')";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnSave.Enabled = false;
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records_Size();
            }
        }
        private void delete_records_Size()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from Size where SizeName='" + txtSizeName.Text + "'";
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
        private void delete_records_Flavor()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from tblFlavorCat where flavorName='" + txtFlavorName.Text + "'";
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

            private void delete_records_Drink()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from tblDrinkCat where drinkName='" + txtDrinkName.Text + "'";
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

        private void btnUpdateSize_Click(object sender, EventArgs e)
        {
            if (txtSizeName.Text == "")
            {
                MessageBox.Show("Please enter Size name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            if (txtPriceSize.Text == "")
            {
                MessageBox.Show("Please enter price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update Size set SizeName='" + txtSizeName.Text + "',SizePrice=" + txtPriceSize.Text + " Where [ID]='" + txtSizeID.Text + "'";
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

        private void btnGetDataSize_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSizeLog frm = new frmSizeLog();
            frm.Show();
            frm.GetData();
        }

        private void txtSizeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtFlavorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnNewF_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSaveF_Click(object sender, EventArgs e)
        {
            if (txtFlavorName.Text == "")
            {
                MessageBox.Show("Please enter flavor name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFlavorName.Focus();
                return;
            }
            if (txtFlavorsPrice.Text == "")
            {
                MessageBox.Show("Please enter flavor price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFlavorsPrice.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select FlavorName from tblFlavorCat where FlavorName ='" + txtFlavorName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Flavor Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSizeName.Text = "";
                    txtSizeName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                autof();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                // string cb = "insert into Supplies_List(SuppliesID,SuppliesName,Price,Unit) VALUES('"+txtProductID.Text + "','" + txtProductName.Text + "','" + txtPrice.Text + "','" + txtUnit.Text +"')";
                string cb = "insert into tblFlavorCat(flavorCatId,flavorName,FlavorPrice) VALUES ('" + txtFlavorsID.Text + "','" + txtFlavorName.Text + "','" + txtFlavorsPrice.Text + "')";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnSave.Enabled = false;
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteF_Click(object sender, EventArgs e)
        {
            delete_records_Flavor();
        }

        private void btnUpdateF_Click(object sender, EventArgs e)
        {
            if (txtFlavorName.Text == "")
            {
                MessageBox.Show("Please enter Flavor name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFlavorsPrice.Focus();
                return;
            }
            if(txtFlavorsPrice.Text == "")
            {
                MessageBox.Show("Please enter Flavor price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFlavorsPrice.Focus();
                return;
            }
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update tblFlavorCat set FlavorName='" + txtFlavorName.Text + "' ,FlavorPrice='" + txtFlavorsPrice.Text + "' Where [flavorCatId]='" + txtFlavorsID.Text + "'";
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

        private void btnGetDataF_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFlavorLog frm = new frmFlavorLog();
            frm.Show();
            frm.GetData();
        }

        private void btnNewD_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSaveD_Click(object sender, EventArgs e)
        {
            if (txtDrinkName.Text == "")
            {
                MessageBox.Show("Please enter Drink name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDrinkName.Focus();
                return;
            }
            if (txtDrinksPrice.Text =="")
            {
                MessageBox.Show("Please enter Drink price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDrinksPrice.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select DrinkName from tblDrinkCat where DrinkName ='" + txtDrinkName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Drink Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSizeName.Text = "";
                    txtSizeName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                autod();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                // string cb = "insert into Supplies_List(SuppliesID,SuppliesName,Price,Unit) VALUES('"+txtProductID.Text + "','" + txtProductName.Text + "','" + txtPrice.Text + "','" + txtUnit.Text +"')";
                string cb = "insert into tblDrinkCat(drinkCatId,drinkName,DrinkPrice) VALUES ('" + txtDrinkID.Text + "','" + txtDrinkName.Text + "','" + txtDrinksPrice.Text + "' )";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnSave.Enabled = false;
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteD_Click(object sender, EventArgs e)
        {
            delete_records_Drink();
        }

        private void btnUpdateD_Click(object sender, EventArgs e)
        {
            if (txtDrinkName.Text == "")
            {
                MessageBox.Show("Please enter Drink name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDrinkName.Focus();
                return;
            }
            if (txtDrinksPrice.Text =="")
            {

                MessageBox.Show("Please enter Drink price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDrinksPrice.Focus();
                return;
            }

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update tblDrinkCat set DrinkName='" + txtDrinkName.Text + "',DrinkPrice='" + txtDrinksPrice.Text +"' Where [drinkCatId]='" + txtDrinkID.Text + "'";
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

        private void btnGetDataD_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmDrinkLog frm = new frmDrinkLog();
            frm.Show();
            frm.GetData();
        }

        private void Save()
        {
            frmSupplies frm = new frmSupplies();
            if (txtProductName.Text != "")
            {
                frm.txtProductID.Text = txtProductID.Text;
                frm.ShowDialog();
            }
            else if (txtSizeName.Text != "")
            {
                frm.txtProductID.Text = txtSizeID.Text;
                frm.ShowDialog();
            }
            else if (txtFlavorName.Text != "")
            {
                frm.txtProductID.Text = txtFlavorsID.Text;
                frm.ShowDialog();
            }
            else if (txtDrinkName.Text != "")
            {
                frm.txtProductID.Text = txtDrinkID.Text;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error");
            }
         

        }

        private void txtPriceSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

