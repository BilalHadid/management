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
    public partial class Product : Form
    {
        public Product()
        {
            
            InitializeComponent();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtCatogary.Text== " Enter Quantity")
            {
                txtCatogary.Text = "";

                txtCatogary.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {

            if (txtCatogary.Text == "")
            {
                txtCatogary.Text = " Enter Quantity";

                txtCatogary.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string contr = "Data Source=DESKTOP-396O81C\\SQLSERVER;Initial Catalog=SpairPartsUnderData;Integrated Security=True";
                SqlConnection conn = new SqlConnection(contr);
                conn.Open();
                string ID = txtId.Text;
                string Catogary = txtCatogary.Text;
                string Name = cmbName.Text;


                string Query = "insert into products values('" + Catogary + "','" + Name + "')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Successfully Enter");
                GradeView();
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtCatogary.Clear();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Plese enter few words!");
            }
        }
       
        private void LVProduct_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        void GradeView()
        {
            string contr = "Data Source=DESKTOP-396O81C\\SQLSERVER;Initial Catalog=SpairPartsUnderData;Integrated Security=True";
            SqlConnection conn = new SqlConnection(contr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Products", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvproduct.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
           
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {
            GradeView();
        }

        private void txtCatogary_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

