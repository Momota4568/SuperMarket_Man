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
using System.Data.SqlClient;

namespace SuperMarket_Man
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IP8KTE5\SQLEXPRESS;Initial Catalog=Test_DB;Integrated Security=True");
        private void populate()
        {
            try
            {
                con.Open();
                string query = "select ProdName, ProdQty from ProductTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProdDGV1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void populatebills()
        {
            try
            {
                con.Open();
                string query = "select * from BillTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                BillsDGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            fillcombo();
            SellerNameLbl.Text = Form1.Sellername;

        }
        
        private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            ProdNameTxt.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdQtyTxt.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
                
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateLbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        int Grdtotal = 0, n=0;

        private void SProAddBTN_Click(object sender, EventArgs e)
        {
            if (BillTxt.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into BillTb1 values(" + BillTxt.Text + ",'" + SellerNameLbl + "','" + DateLbl.Text + "','" + AmtLbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    con.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SprintBTN_Click(object sender, EventArgs e)
        {

        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // flag = 1;
        }

        private void RegBTN_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

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
            //ProCatCB.ValueMember = "CatName";
            //ProCatCB.DataSource = dt;
            con.Close();
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (ProdNameTxt.Text == "" || ProdQtyTxt.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProdPriceTxt.Text) * Convert.ToInt32(ProdQtyTxt.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ORDERDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdNameTxt.Text;
                newRow.Cells[2].Value = ProdPriceTxt.Text;
                newRow.Cells[3].Value = ProdQtyTxt.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPriceTxt.Text) * Convert.ToInt32(ProdQtyTxt.Text);
                ORDERDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                AmtLbl.Text = "" + Grdtotal;

            }
        }
    }
}
