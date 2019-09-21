using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelHR.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void buttonother_Click(object sender, EventArgs e)
        {
            panelother.Visible = false;
        }

        private void buttonhr_Click(object sender, EventArgs e)
        {
            panelHR.Visible = false;
        }

        private void buttonother_Click_1(object sender, EventArgs e)
        {
            panelother.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact IT Department");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsigad_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupadmin f = new signupadmin();
            f.Show();
        }

        private void btnlogadm_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=DESKTOP-396O81C\\SQLSERVER;Initial Catalog=SpairParts;Integrated Security=True";
            SqlConnection lin = new SqlConnection(conn);
           
                string User = txtuser.Text;
                string pass = txtpass.Text;
           
            
            string query = "SELECT * from LoginAdmin Where UserN = '" + User + "' AND pass = '" + pass + "'";
            SqlCommand cmd = new SqlCommand(query,lin);
            lin.Open();
            SqlDataReader rd;
           
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                
                ADMINSIGN n = new ADMINSIGN();
                n.Show();
               
            }
            else
            
                MessageBox.Show("INCORRECT LOGIN");
            lin.Close();
            rd.Close();
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpasshr_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBoxhr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxhr.Checked)
            {
                txtpasshr.UseSystemPasswordChar = false;
            }
            else
            {
                txtpasshr.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBoxother.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxother.UseSystemPasswordChar = true;
            }
        }

        private void btnsigHR_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignHR n = new SignHR();
            n.Show();
        }

        private void btnsigother_Click(object sender, EventArgs e)
        {

        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text==" Enter User Name")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text=="")
            {
                txtuser.Text = " Enter User Name";
                txtuser.ForeColor = Color.Gray;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
           
        }

        private void pass_Enter(object sender, EventArgs e)
        {
           
        }
    }
    
}
