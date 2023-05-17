using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SuperMarket_Man
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IP8KTE5\SQLEXPRESS;Initial Catalog=Test_DB;Integrated Security=True");
        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sellerId.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            sellerName.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            sellerAge.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            sellerPhone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            sellerPass.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void populate()
        {
            try
            {
                con.Open();
                string query = "select * from SellerTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                SellerDGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            populate();
        }
        
            private void sellerDeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerId.Text == "")
                {
                    MessageBox.Show("Select The Seller to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from SellerTb1 where Sellerid=" + sellerId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");

                    con.Close();
                    populate();
                    sellerId.Text = "";
                    sellerName.Text = "";
                    sellerAge.Text = "";
                    sellerPhone.Text = "";
                    sellerPass.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void SellerEditBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerId.Text == "" || sellerName.Text == "" || sellerAge.Text == "" || sellerPhone.Text == "" || sellerPass.Text == "")
                {
                    MessageBox.Show("Messing Information");
                }
                else
                {
                    con.Open();
                    string query = "update  SellerTb1 set SellerName='" + sellerName.Text + "', SellerAge='" + sellerAge.Text + "' , SellerPhone='" + sellerPhone.Text + "' , SellerPass='" + sellerPass.Text + "' where Sellerid=" + sellerId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller successfully updated");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerAddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into SellerTb1 values(" + sellerId.Text + ",'" + sellerName.Text + "','" + sellerAge.Text + "','" + sellerPhone.Text + "' ,'" + sellerPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                con.Close();
                populate();
                sellerId.Text = "";
                sellerName.Text = "";
                sellerAge.Text = "";
                sellerPhone.Text = "";
                sellerPass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductFormExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void CatBTN_Click(object sender, EventArgs e)
        {
            CATEGORYFORM cat = new CATEGORYFORM();
            cat.Show();
            this.Hide();
        }

        private void MSlogoutLbl_Click(object sender, EventArgs e)
        {
            Form1 log  =    new Form1();
            log.Show();
            this.Hide();
        }
    }
}
