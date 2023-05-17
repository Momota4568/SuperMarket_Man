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
    public partial class CATEGORYFORM : Form
    {
        public CATEGORYFORM()
        {
            InitializeComponent();
        }
SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IP8KTE5\SQLEXPRESS;Initial Catalog=Test_DB;Integrated Security=True");
        private void CatAdd_Click(object sender, EventArgs e)
        {
         try
            {
                con.Open();
                string query = "insert into CategoryTb1 values(" + CatidTb.Text + ",'" + CatNameTb.Text + "','" + CatDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                con.Close();
                populate();
            } catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       private void populate()
        {
            try
            {
                con.Open();
                string query = "select * from CategoryTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CatDGV.DataSource = ds.Tables[0];
                con.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CATEGORYFORM_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatidTb.Text= CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void CatDeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatidTb.Text=="")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from CategoryTb1 where Catid=" + CatidTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                        
                    con.Close();
                    populate();

                }
            }catch(Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void CatEditBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatidTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Messing Information");
                }
                else
                {
                    con.Open();
                    string query = "update CategoryTb1 set CatName='" + CatNameTb.Text + "', CatDesc='" + CatDescTb.Text + "' where Catid=" + CatidTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfully updated");
                    con.Close();
                    populate();
                }
            }catch(Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void CatProBtn_Click(object sender, EventArgs e)
        {
           ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }

        private void CatlogoutLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
