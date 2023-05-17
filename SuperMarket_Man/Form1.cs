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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Sellername = "";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IP8KTE5\SQLEXPRESS;Initial Catalog=Test_DB;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void ClearLevel_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PassTb.Text = "";

        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == ""|| PassTb.Text == "")
            {
                MessageBox.Show("Enter The Name And Password");
            }
            else
            {
                if (RoleCb.SelectedIndex > -1)
                {
                    if (RoleCb.SelectedItem.ToString()=="ADMIN")
                    {
                        if (UnameTb.Text == "Admin" && PassTb.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are Admin, Enter thre correct Id and Password");
                        }
                    }
                    else
                    {
                       // MessageBox.Show("You are in the seller section");
                       con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from SellerTb1 where SellerName='"+UnameTb.Text+"' and SellerPass='"+PassTb.Text+"'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString()=="1")
                        {
                            Sellername = UnameTb.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username And Password");
                        }
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select A Role");
                }
            }
        }
    }
}
