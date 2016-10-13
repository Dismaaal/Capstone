using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace Kerrimo
{
    public partial class frmPOS : Form
    {
        ConnectionString cs = new ConnectionString();
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();

        #region getOrder
        public string sizee;
        public string amount;
        public string flavoramount;
        public string drinkamount;
        public string sizeamount;
        public string categoryname;
        public string sizename;
        public string flavorname;
        public string drinkname;
        public string valuee;
        public string productid;
        public string productids;
        public string productidf;
        public string productidd;
        public void Value(string value)
        {
            valuee = value;

        }

        public void Flavorname(string flavor)
        {
            flavorname = flavor;
        }
        public void Drinkname(string drink)
        {
            drinkname = drink; 
        }

        public void Size(string size)
        {
            sizename = size;
        }

        public void ProductId(string id)
        {
            productid = id;
        }
        public void ProductIDs(string id)
        {
            productids = id;
        }
        public void ProductIDd(string id)
        {
            productidd = id;
        }
        public void ProductIDf(string id)
        {
            productidf = id;
        }
        public void Category(string id)
        {
            categoryname = id;
        }

        #endregion
        private void Reset()
        {
            txtInvoiceNo.Text = "";
            lblDate.Text = DateTime.Today.ToString();
            txtDesc.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            ListView1.Items.Clear();
            DisposeControl();
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            txtTotalPayment.Text = "";
            txtChange.Text = "";
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            ListView1.Enabled = true;
            btnPrint.Enabled = false;
            btnPay.Enabled = false;
            txtTaxPer.Enabled = false;
            txtDiscountPer.Enabled = false;
            txtTotalPayment.Enabled = false;
            txtQuantity.Enabled = true;
        }
        public frmPOS()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Today.ToString();
            AddButtons();
            
        }
        private void auto()
        {
            txtInvoiceNo.Text = "OD-" + GetUniqueKey(8);

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
        //===================================Function to fill datagrid view==================================
        private static Image ResizeImage(Image image, Size size)
        {
            Image img = new Bitmap(image, size);

            return img;
        }
  

        public void AddButtons()
        {
            SqlConnection myConnection = default(SqlConnection);
            myConnection = new SqlConnection(cs.DBConn);
            myConnection.Open();
            //string getCategory = "SELECT * FROM tblCategory";
            SqlDataAdapter dataCategory = new SqlDataAdapter("SELECT * FROM Product", myConnection);
            DataTable dt = new DataTable();
            dataCategory.Fill(dt);
            try
            {
               
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Button btn = new Button();
                    btn.Text = dt.Rows[i][1].ToString();
                    btn.Size = new System.Drawing.Size(100, 100);
                    btn.ForeColor = Color.Black;


                    byte[] data = (byte[])dt.Rows[i][3];
                    MemoryStream ms = new MemoryStream(data);
                    btn.Image = Image.FromStream(ms);
                    btn.Image = ResizeImage(btn.Image, btn.Size);
                        
                    btn.Tag = dt.Rows[i][0];
                    flpCategories.Controls.Add(btn);
                    this.Controls.Add(flpCategories);
                    btn.Click += addSize;

                   
                }
         
                
            }
            catch
            {
                //foreach(DataRow row in dt.Rows)
                //{
                //    if (row.IsNull("categoryImage"))
                //      throw new Exception("Empty value!");
                //}
            }

        }
           
        public int getCategoryId;
        public void addSize(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            string id1 = button1.Tag.ToString();
            ProductId(id1);
            txtProductID.Text = productid;

            Button button = (Button)sender;
            string id = button.Text;
            Category(id);
            //lblDisplay.Text = categoryname;

            // refresh buttons
            List<Control> listControls = flpProducts.Controls.Cast<Control>().ToList();

            foreach (Control control in listControls)
            {
                flpProducts.Controls.Remove(control);
                control.Dispose();
            }

            SqlConnection myConnection1 = default(SqlConnection);
            myConnection1 = new SqlConnection(cs.DBConn);
            myConnection1.Open();
            //string getCategory = "SELECT * FROM tblCategory";
            SqlDataAdapter dataCategory = new SqlDataAdapter("SELECT * FROM Size", myConnection1);
            DataTable dt = new DataTable();
            dataCategory.Fill(dt);
            try
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Button btn = new Button();
                    btn.Text = dt.Rows[i][1].ToString();
                    btn.Size = new System.Drawing.Size(100, 100);
                    btn.ForeColor = Color.Black;

                    //byte[] data = (byte[])dt.Rows[i][2];
                    //MemoryStream ms = new MemoryStream(data);
                    //btn.Image = Image.FromStream(ms);
                    //btn.Image = ResizeImage(btn.Image, btn.Size);

                    btn.Tag = dt.Rows[i][0];
                    flpProducts.Controls.Add(btn);
                    this.Controls.Add(flpCategories);
                    btn.Click += addFlavor;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
           public void addFlavor(object sender, EventArgs e)
           {
               Button button1 = (Button)sender;
               string id1 = button1.Tag.ToString();
               ProductIDs(id1);

               Button button = (Button)sender;
               string size = button.Text;
               Size(size);
               //lblDisplay.Text = sizename;

               List<Control> listControls = flpFlavors.Controls.Cast<Control>().ToList();

               foreach (Control control in listControls)
               {
                   flpFlavors.Controls.Remove(control);
                   control.Dispose();
               }
               
               SqlConnection myConnection1 = default(SqlConnection);
               myConnection1 = new SqlConnection(cs.DBConn);
               myConnection1.Open();
               SqlDataAdapter dataCategory = new SqlDataAdapter("SELECT * FROM tblFlavorCat", myConnection1);
               DataTable dt = new DataTable();
               dataCategory.Fill(dt);
               try
               {

                   for (int i = 0; i < dt.Rows.Count; i++)
                   {
                       RadioButton btn = new RadioButton();
                       btn.Text = dt.Rows[i][1].ToString();
                      // btn.Size = new System.Drawing.Size(20, 20);
                       btn.ForeColor = Color.Black;

                       //byte[] data = (byte[])dt.Rows[i][2];
                       //MemoryStream ms = new MemoryStream(data);
                       //btn.Image = Image.FromStream(ms);
                       //btn.Image = ResizeImage(btn.Image, btn.Size);

                       btn.Tag = dt.Rows[i][0].ToString();
                       flpFlavors.Controls.Add(btn);
                       this.Controls.Add(flpFlavors);
                       btn.Click += addDrink;
                   }
               }
               catch
               {
                   MessageBox.Show("Error");
               }
           }
           public void getPrice()
           {
               SqlConnection myConnection = default(SqlConnection);
               myConnection = new SqlConnection(cs.DBConn);
               myConnection.Open();
            //auto();
            SqlCommand getflavorPrice = new SqlCommand("select * from tblFlavorCat where flavorName ='" + flavorname + "'", myConnection);
            SqlDataReader loginReader2 = getflavorPrice.ExecuteReader();
            while (loginReader2.Read())
            {
                flavoramount = loginReader2["FlavorPrice"].ToString();
            }
            myConnection.Close();
            myConnection.Open();

            SqlCommand getDrinkPrice = new SqlCommand("select * from tblDrinkCat where drinkName ='" + drinkname + "'", myConnection);
            SqlDataReader loginReader3 = getDrinkPrice.ExecuteReader();
            while (loginReader3.Read())
            {
                flavoramount = loginReader3["DrinkPrice"].ToString();
            }
            myConnection.Close();
            myConnection.Open();

            SqlCommand getPrice = new SqlCommand(" select * from Product where ProductName ='" + categoryname + "'", myConnection);
               SqlDataReader loginReader = getPrice.ExecuteReader();
               while (loginReader.Read())
               {
                   amount = loginReader["Price"].ToString();
               }
               myConnection.Close();
               myConnection.Open();

                   SqlCommand getSize = new SqlCommand(" select * from Size where SizeName ='" + sizename + "'", myConnection);
                   SqlDataReader loginReader1 = getSize.ExecuteReader();
                   while (loginReader1.Read())
                   {
                       sizee = loginReader1["SizeName"].ToString();
                       sizeamount = loginReader1["SizePrice"].ToString();
                       if (sizename == sizee )
                       {

                           int val1 = 0;
                           int val2 = 0;
                    int val3 = 0;
                    int val4 = 0;
                           int.TryParse(sizeamount, out val2);
                           int.TryParse(amount, out val1);
                    int.TryParse(drinkamount, out val3);
                    int.TryParse(flavoramount, out val4);
                           int I = (val1 + val2 + val3 + val4);
                           string value = I.ToString();
                           Value(value);
                       }
                       else
                       {
                           MessageBox.Show("Error");
                       }
                   }
                   myConnection.Close();
               }
               
           
           public void addDrink(object sender, EventArgs e)
           {
               RadioButton button1 = (RadioButton)sender;
               string id1 = button1.Tag.ToString();
               ProductIDf(id1);

               RadioButton button = (RadioButton)sender;
               string flavor = button.Text;
               Flavorname(flavor);
               //lblDisplay.Text = flavorname;

               List<Control> listControls = flpDrinks.Controls.Cast<Control>().ToList();

               foreach (Control control in listControls)
               {
                   flpDrinks.Controls.Remove(control);
                   control.Dispose();
               }
               
               SqlConnection myConnection = default(SqlConnection);
               myConnection = new SqlConnection(cs.DBConn);
               myConnection.Open();
               SqlDataAdapter dataCategory = new SqlDataAdapter("SELECT * FROM tblDrinkCat", myConnection);
               DataTable dt = new DataTable();
               dataCategory.Fill(dt);
               try
               {

                   for (int i = 0; i < dt.Rows.Count; i++)
                   {
                       RadioButton btn = new RadioButton();
                       btn.Text = dt.Rows[i][1].ToString();
                       //btn.Size = new System.Drawing.Size(20, 20);
                       btn.ForeColor = Color.Black;

                       //byte[] data = (byte[])dt.Rows[i][2];
                       //MemoryStream ms = new MemoryStream(data);
                       //btn.Image = Image.FromStream(ms);
                       //btn.Image = ResizeImage(btn.Image, btn.Size);

                       btn.Tag = dt.Rows[i][0];
                       flpDrinks.Controls.Add(btn);
                       this.Controls.Add(flpDrinks);
                       
                       btn.Click += endButton;
                       
                       
                       
                   }
               }
               catch
               {
                   MessageBox.Show("Error");
               }
           }
           public void endButton(object sender, EventArgs e)
           {
               
               RadioButton button2 = (RadioButton)sender;
               string id1 = button2.Tag.ToString();
               ProductIDd(id1);

               RadioButton button1 = (RadioButton)sender;
               string drink = button1.Text;
               Drinkname(drink);
               //lblDisplay.Text = drinkname;
               txtDesc.Text = categoryname + " " + sizename + " " + flavorname + " " + drinkname;
            getPrice();
            txtPrice.Text = valuee;
           }

           public void DisposeControl()
           {
               
                   flpDrinks.Controls.Clear();
                   flpFlavors.Controls.Clear();
                   flpProducts.Controls.Clear();

           }

           public void Calculate()
           {
               if (txtTaxPer.Text != "")
               {
                   txtTaxAmt.Text = Convert.ToInt32((Convert.ToInt32(txtTotal.Text) * Convert.ToDouble(txtTaxPer.Text) / 100)).ToString();

               }
               if (txtDiscountPer.Text != "")
               {
                   txtDiscountAmount.Text = Convert.ToInt32(((Convert.ToInt32(txtTotal.Text) + Convert.ToInt32(txtTaxAmt.Text)) * Convert.ToDouble(txtDiscountPer.Text) / 100)).ToString();
               }

               int val1 = 0;
               int val2 = 0;
               int val3 = 0;
               int val4 = 0;
               int val5 = 0;
               int.TryParse(txtTaxAmt.Text, out val1);
               int.TryParse(txtTotal.Text, out val2);
               int.TryParse(txtDiscountAmount.Text, out val3);
               int.TryParse(txtGrandTotal.Text, out val4);
               int.TryParse(txtTotalPayment.Text, out val5);
               val4 = val1 + val2 - val3;
               txtGrandTotal.Text = val4.ToString();
               //int I = (val4 - val5);
               //txtChange.Text = I.ToString();
               
               //int val4 = 0;
               
               
               //int.TryParse(txtSubTotal.Text, out val2);
              
               //int.TryParse(txtTotal.Text, out val4);

               //val4 = val4;
               //txtTotal.Text = val4.ToString();
               


           }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

            int val1 = 0;
            int val2 = 0;
            int.TryParse(valuee, out val1);
            int.TryParse(txtQuantity.Text, out val2);
            int I = (val1 * val2);
            txtSubTotal.Text = I.ToString();
        }

           public double subtot()
           {
               int i = 0;
               int j = 0;
               int k = 0;
               i = 0;
               j = 0;
               k = 0;


               try
               {

                   j = ListView1.Items.Count;
                   for (i = 0; i <= j - 1; i++)
                   {
                       k = k + Convert.ToInt32(ListView1.Items[i].SubItems[5].Text);
                   }

               }

               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               return k;

           }

           private void btnAdd_Click(object sender, EventArgs e)
           {
               try
               {
                  
                 
                       if (ListView1.Items.Count == 0)
                       {

                           ListViewItem lst = new ListViewItem();
                           lst.SubItems.Add(txtProductID.Text);
                           lst.SubItems.Add(txtDesc.Text);                         
                           lst.SubItems.Add(valuee);
                           lst.SubItems.Add(txtQuantity.Text);
                           lst.SubItems.Add(txtSubTotal.Text);
                           lst.SubItems.Add(productid);
                           lst.SubItems.Add(productids);
                           lst.SubItems.Add(productidf);
                           lst.SubItems.Add(productidd);
                           ListView1.Items.Add(lst);
                           txtTotal.Text = subtot().ToString();

                           Calculate();
                           DisposeControl();
                           txtProductID.Text = "";
                           txtQuantity.Text = "";
                           txtSubTotal.Text = "";
                           txtDesc.Text = "";
                           txtPrice.Text = "";
                           btnPay.Enabled = true;
                           btnDelete.Enabled = true;
                           txtTaxPer.Enabled = true;
                           txtDiscountPer.Enabled = true;
                           txtTotalPayment.Enabled = true;
                           txtQuantity.Enabled = false;


                    return;
                       }
                       
                       for (int j = 0; j <= ListView1.Items.Count - 1; j++)
                       {
                           if (ListView1.Items[j].SubItems[1].Text == txtProductID.Text)
                           {
                               ListView1.Items[j].SubItems[1].Text = txtProductID.Text;
                               ListView1.Items[j].SubItems[2].Text = txtDesc.Text;
                               ListView1.Items[j].SubItems[3].Text = valuee;
                               ListView1.Items[j].SubItems[4].Text = (Convert.ToInt32(ListView1.Items[j].SubItems[4].Text) + Convert.ToInt32(txtQuantity.Text)).ToString();
                               ListView1.Items[j].SubItems[5].Text = (Convert.ToInt32(ListView1.Items[j].SubItems[5].Text) + Convert.ToInt32(txtSubTotal.Text)).ToString();
                               ListView1.Items[j].SubItems[6].Text = productid;
                               ListView1.Items[j].SubItems[6].Text = productids;
                               ListView1.Items[j].SubItems[6].Text = productidf;
                               ListView1.Items[j].SubItems[6].Text = productidd;
                               Calculate();
                               DisposeControl();
                               txtProductID.Text = "";
                               txtQuantity.Text = "";
                               txtSubTotal.Text = "";
                               txtDesc.Text = "";
                               txtPrice.Text = "";
                               btnPay.Enabled = true;
                               btnDelete.Enabled = true;
                        txtTaxPer.Enabled = true;
                        txtDiscountPer.Enabled = true;
                        txtTotalPayment.Enabled = true;
                        txtQuantity.Enabled = false;
                        return;

                           }
                       }
                                ListViewItem lst1 = new ListViewItem();
                                lst1.SubItems.Add(txtProductID.Text);
                                lst1.SubItems.Add(txtDesc.Text);
                                lst1.SubItems.Add(valuee);
                                lst1.SubItems.Add(txtQuantity.Text);
                                lst1.SubItems.Add(txtSubTotal.Text);
                                lst1.SubItems.Add(productid);
                                lst1.SubItems.Add(productids);
                                lst1.SubItems.Add(productidf);
                                lst1.SubItems.Add(productidd);
                                ListView1.Items.Add(lst1);
                                txtTotal.Text = subtot().ToString();
                                Calculate();
                                DisposeControl();
                                txtProductID.Text = "";
                                txtQuantity.Text = "";
                                txtSubTotal.Text = "";
                                txtDesc.Text = "";
                                txtPrice.Text = "";
                                btnPay.Enabled = true;
                                btnDelete.Enabled = true;
                txtTaxPer.Enabled = true;
                txtDiscountPer.Enabled = true;
                txtTotalPayment.Enabled = true;
                txtQuantity.Enabled = false;

                return;
                   
                   

               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
          
           
           }

           

           private void lblDisplay_Click(object sender, EventArgs e)
           {

           }

           private void textBox1_TextChanged(object sender, EventArgs e)
           {
               
              
           }

           private void txtQuantity_Validating(object sender, CancelEventArgs e)
           {
            int parsedvalue;
            if (!int.TryParse(txtQuantity.Text, out parsedvalue) && txtQuantity.Text != null)
            {
                MessageBox.Show("This is a number only field", "Error");
                txtQuantity.Text = "";
                txtQuantity.Focus();
                return;
            }
            else
            {
                int val1 = 0;
                int val2 = 0;

                int.TryParse(txtQuantity.Text, out val2);
                if (val2 < val1)
                {
                    MessageBox.Show("Selling quantities are more than available quantities", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Text = "";
                    txtSubTotal.Text = "";
                    txtQuantity.Focus();
                    return;
                }
            }
           }

           private void txtTotalPayment_Validating(object sender, CancelEventArgs e)
           {
               int val1 = 0;
               int val2 = 0;
               int.TryParse(txtGrandTotal.Text, out val1);
               int.TryParse(txtTotalPayment.Text, out val2);
               if (val2 < val1)
               {
                   MessageBox.Show("Insufficient funds", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtTotalPayment.Text = "";
                   txtTotalPayment.Focus();
                   return;
               }
           }

           private void btnPay_Click(object sender, EventArgs e)
           {
               if (txtTotalPayment.Text == "")
               {
                   MessageBox.Show("Insufficient funds", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtTotalPayment.Focus();
               }

               try 
               {
               int val1 = 0;
               int val2 = 0;
               int.TryParse(txtGrandTotal.Text, out val1);
               int.TryParse(txtTotalPayment.Text, out val2);
               if (val2 < val1)
               {
                   MessageBox.Show("Insufficient funds", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtTotalPayment.Text = "";
                   txtTotalPayment.Focus();
                   return;
               }
               int I = (val2 - val1);
               txtChange.Text = I.ToString();


               auto();

               SqlConnection myConnection = default(SqlConnection);
               myConnection = new SqlConnection(cs.DBConn);
               myConnection.Open();

               //string cb = "insert Into Invoice_Info(InvoiceNo,InvoiceDate,Total,TotalPayment,Change) VALUES ('" + txtInvoiceNo.Text + "','" + lblDate.Text + "','" + txtTotal.Text + "','" + txtTotalPayment.Text + "','" + txtChange.Text +"')";
               string cb = "insert Into Invoice_Info(InvoiceNo,InvoiceDate,Total,VATPer,VATAmount,DiscountPer,DiscountAmount,GrandTotal,TotalPayment,Change) VALUES ('" + txtInvoiceNo.Text + "','" + lblDate.Text + "','" + txtTotal.Text + "','" + txtTaxPer.Text + "','" + txtTaxAmt.Text + "','"+ txtDiscountPer.Text +"','"+ txtDiscountAmount.Text +"','" + txtGrandTotal.Text + "','" + txtTotalPayment.Text + "','" + txtChange.Text + "')";
               cmd = new SqlCommand(cb);
               cmd.Connection = myConnection;
               cmd.ExecuteReader();
               if (myConnection.State == ConnectionState.Open)
               {
                   myConnection.Close();
               }

               myConnection.Close();
               for (int i = 0; i <= ListView1.Items.Count - 1; i++)
               {
                   myConnection = new SqlConnection(cs.DBConn);

                   string cd = "insert Into ProductSold(InvoiceNo,ProductID,ProductName,Quantity,Price,TotalAmount) VALUES (@d1,@d2,@d3,@d4,@d5,@d6)";
                   cmd = new SqlCommand(cd);
                   cmd.Connection = myConnection;
                   cmd.Parameters.AddWithValue("d1", txtInvoiceNo.Text);
                   cmd.Parameters.AddWithValue("d2", ListView1.Items[i].SubItems[1].Text);
                   cmd.Parameters.AddWithValue("d3", ListView1.Items[i].SubItems[2].Text);
                   cmd.Parameters.AddWithValue("d4", ListView1.Items[i].SubItems[4].Text);
                   cmd.Parameters.AddWithValue("d5", ListView1.Items[i].SubItems[3].Text);
                   cmd.Parameters.AddWithValue("d6", ListView1.Items[i].SubItems[5].Text);
                   myConnection.Open();
                   cmd.ExecuteNonQuery();
                   myConnection.Close();
               }
               for (int i = 0; i <= ListView1.Items.Count - 1; i++)
               {
                   myConnection = new SqlConnection(cs.DBConn);
                   myConnection.Open();
                   string cb1 = "update temp_stock set Quantity = Quantity - " + ListView1.Items[i].SubItems[4].Text + " where ProductID= '" + ListView1.Items[i].SubItems[6].Text + "'";
                   string cb2 = "update temp_stock set Quantity = Quantity - " + ListView1.Items[i].SubItems[4].Text + " where ProductID= '" + ListView1.Items[i].SubItems[7].Text + "'";
                   string cb3 = "update temp_stock set Quantity = Quantity - " + ListView1.Items[i].SubItems[4].Text + " where ProductID= '" + ListView1.Items[i].SubItems[8].Text + "'";
                   string cb4 = "update temp_stock set Quantity = Quantity - " + ListView1.Items[i].SubItems[4].Text + " where ProductID= '" + ListView1.Items[i].SubItems[9].Text + "'";
                   string cb5 = "update temp_stock set Quantity = Quantity - " + ListView1.Items[i].SubItems[4].Text + " where ProductID IS NULL";
                   cmd = new SqlCommand(cb1);
                   cmd.Connection = myConnection;
                   cmd.ExecuteNonQuery();
                   cmd = new SqlCommand(cb2);
                   cmd.Connection = myConnection;
                   cmd.ExecuteNonQuery();
                   cmd = new SqlCommand(cb3);
                   cmd.Connection = myConnection;
                   cmd.ExecuteNonQuery();
                   cmd = new SqlCommand(cb4);
                   cmd.Connection = myConnection;
                   cmd.ExecuteNonQuery();
                   cmd = new SqlCommand(cb5);
                   cmd.Connection = myConnection;
                   cmd.ExecuteNonQuery();
                   myConnection.Close();
               }

               btnPrint.Enabled = true;
                btnPay.Enabled = false;
                btnAdd.Enabled = false;
               
                MessageBox.Show("Successfully Placed \n Change is: " + txtChange.Text, "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           

           private void btnDelete_Click(object sender, EventArgs e)
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
                       txtTotal.Text = subtot().ToString();
                       Calculate();
                   }

                   //btnDelete.Enabled = false;
                   //if (ListView1.Items.Count == 0)
                   //{
                   //    txtTotal.Text = "";
                   //}
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           }

           private void txtTotal_TextChanged(object sender, EventArgs e)
           {

           }

           private void frmPOS_Load(object sender, EventArgs e)
           {

           }
          
            
           private void btnNew_Click(object sender, EventArgs e)
           {
               Reset();
           }

           private void txtTaxPer_TextChanged(object sender, EventArgs e)
           {
            //string.IsNullOrEmpty(txtTaxPer.Text)  || 
            int parsedvalue;
                if(!int.TryParse(txtTaxPer.Text, out parsedvalue))
                {
                    //txtTaxAmt.Text = "";
                    //txtTotal.Text = "";
                    //return;

                MessageBox.Show("Input Numbers Only", "Input Error");
                txtTaxPer.Text = "";
                txtTaxPer.Focus();
                return;
                }
            else {
                Calculate();
            }
           
        }
             

           private void txtDiscountPer_TextChanged(object sender, EventArgs e)
           {
            int parsedvalue;
                if (!int.TryParse(txtDiscountPer.Text, out parsedvalue))
                {
                MessageBox.Show("Input Numbers Only", "Input Error");
                txtDiscountPer.Text = "";
                txtDiscountPer.Focus();
                return;
                }
            else { Calculate(); }
                

        }

           private void btnPrint_Click(object sender, EventArgs e)
           {
               try
               {
                   Cursor = Cursors.WaitCursor;
                   timer1.Enabled = true;
                   rptInvoice rpt = new rptInvoice();
                   //The report you created.
                   cmd = new SqlCommand();
                   SqlDataAdapter myDA = new SqlDataAdapter();
                   KERRIMOproj myDS = new KERRIMOproj();
                   //The DataSet you created.
                   SqlConnection con = new SqlConnection(cs.DBConn);
                   cmd.Connection = con;
                   cmd.CommandText = "SELECT * from invoice_info,productsold where invoice_info.invoiceno=productsold.invoiceno and Invoice_info.invoiceNo='" + txtInvoiceNo.Text + "'";
                   cmd.CommandType = CommandType.Text;
                   myDA.SelectCommand = cmd;
                   myDA.Fill(myDS, "Invoice_Info");
                   myDA.Fill(myDS, "ProductSold");
                   //myDA.Fill(myDS, "Customer");
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

           private void flpCategories_Paint(object sender, PaintEventArgs e)
           {

           }


        }
    }

