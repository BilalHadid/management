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

namespace WindowsFormsApp1
{
    public partial class signupadmin : Form
    {
        public signupadmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadmbck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n = new Form1();
            n.Show();
        }

        private void btnsignadmin_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "Data Source=DESKTOP-396O81C\\SQLSERVER;Initial Catalog=SpairParts;Integrated Security=True";
                SqlConnection lin = new SqlConnection(conn);
                lin.Open();
                string user = txtUSer.Text;
                string cnic = txtCNIC.Text;
                string email = txtEmail.Text;
                string gender;
                if (RDOMALE.Checked == true)
                {
                    gender = RDOMALE.Text;
                }
                else
                {
                    gender = RDBFEMALE.Text;
                }

                string pass = txtpassadm.Text;

                string Query = "insert into LoginAdmin values('" + user + "','" + cnic + "','" + email + "','" + gender + "','" + pass + "')";
                SqlCommand cmd = new SqlCommand(Query, lin);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Succesfully");
                lin.Close();
            }
            catch (DataException en)
            {

                MessageBox.Show("Plese Enter The Correct Value:");
            }
            
            
        }

        private void signupadmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonauto_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int au = r.Next(100000, 999999);
            txtpassadm.Text = Convert.ToString(au);
            txtconfauto.Text = Convert.ToString(au);
            labelauto.Text = ("Your Password is :" + au);
        }

        private void txtconfauto_TextChanged(object sender, EventArgs e)
        {
            if (txtpassadm.Text == txtconfauto.Text)
            {
                lblmessage.Text = "Password Successful Match";
                btnsignadmin.Enabled = true;
            }
            else
            {
                lblmessage.Text = "Password doesn't Match";
                btnsignadmin.Enabled = false;
            }
        }

        private void txtpassadm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        void Pikacho()
        {
            string Bill = "Data Source=DESKTOP-396O81C\\SQLSERVER;Initial Catalog=SpairParts;Integrated Security=True";
            SqlConnection con = new SqlConnection(Bill);
            SqlDataAdapter sda = new SqlDataAdapter("select *from LoginAdmin", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            

        }
        private void Dlt_Click(object sender, EventArgs e)
        {
            string Bill = "Data Source=DESKTOP-396O81C\\SQLSERVER;Initial Catalog=SpairParts;Integrated Security=True";
            SqlConnection con = new SqlConnection(Bill);
            con.Open();
            string query = "Delete from LoginAdmin where pass = '" + txtpassadm + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Deleted");
            Pikacho();
            con.Close();
        }
    }
}
