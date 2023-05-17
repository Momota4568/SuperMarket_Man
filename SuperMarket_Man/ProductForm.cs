using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket_Man
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IP8KTE5\SQLEXPRESS;Initial Catalog=Test_DB;Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
private void fillcombo()
        {
            //this method will bind the combobox with the dataset
            con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTb1", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatNme", typeof(string));
            dt.Load(rdr);
            ProCatCB.ValueMember = "CatName";
            ProCatCB.DataSource= dt;
            con.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();


        }

        private void ProAddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into ProductTb1 values(" +ProdIdTXT.Text+ ",'" + ProdNameTxt.Text + "','" +ProdQuaTxt.Text+ "','" +ProdPricTxt.Text+ "' ,'" + ProCatCB.SelectedValue.ToString()+ "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                con.Close();
                 populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            try
            {
                con.Open();
                string query = "select * from ProductTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProdDGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ProCatBTN_Click(object sender, EventArgs e)
        {
            CATEGORYFORM cat = new CATEGORYFORM();
            cat.Show();
            this.Hide();
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTXT.Text= ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTxt.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQuaTxt.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPricTxt.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            ProCatCB.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void ProdEditBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdIdTXT.Text == "" || ProdNameTxt.Text == "" || ProdQuaTxt.Text == "" || ProdPricTxt.Text == "" || ProCatCB.Text == "")
                {
                    MessageBox.Show("Messing Information");
                }
                else
                {
                    con.Open();
                    string query = "update  ProductTb1 set ProdName='" +ProdNameTxt.Text+ "', ProdQty='" +ProdQuaTxt.Text+ "' , ProdPrice='" +ProdPricTxt.Text+ "' , ProdCat='" +ProCatCB.Text+ "' where Prodid=" +ProdIdTXT.Text+ "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product successfully updated");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdDeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdIdTXT.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from ProductTb1 where Prodid=" + ProdIdTXT.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");

                    con.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProCatCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrologoutLbl_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }
    }
}
