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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnauto_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int ever = r.Next(100000, 999999);
            lblmessage.Text = "Password is " + ever;
            txtPass.Text = Convert.ToString(ever);
        }

        private void txtonlycom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtonlycom_Enter(object sender, EventArgs e)
        {

            
        }

        private void txtonlycom_Leave(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmNewUser_Click(object sender, EventArgs e)
        {
            
        }

        private void yetry_click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string con = "Data Source=DESKTOP-396O81C\\SQLSERVER;Initial Catalog=SpairPartsUnderData;Integrated Security=True";
                SqlConnection link = new SqlConnection(con);
                link.Open();
                string Date = DTPADminPanel.Text;
                string update = cmbUser.Text;
                string Id = txtonlycom.Text;
                string name = txtusername.Text;
                string Pass = txtPass.Text;
                string Cont = mtbContact.Text;
                string cnic = mtbcnic.Text;
                
                string gender;
                if (radioButton1.Checked == true)
                {
                    gender = radioButton1.Text;
                }
                else
                {
                    gender = radioButton2.Text;
                }
                string Query = "insert into AdminPanelSp values('" + Date + "','" + update + "','" + name + "','" + Pass + "','" + Cont + "','" + cnic + "','" + gender + "')";
                SqlCommand cmd = new SqlCommand(Query, link);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Succesfully");
                link.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void buttonref_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtusername.Clear();
                txtPass.Clear();
                mtbContact.Clear();
                mtbcnic.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
           
        }
    }
    }

