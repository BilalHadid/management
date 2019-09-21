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
    public partial class Caregory : Form
    {
        public Caregory()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                txtCategory.Text = "Enter Catogary Name";

                txtCategory.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtCategory.Text == "Enter Catogary Name")
            {
                txtCategory.Text = "";

                txtCategory.ForeColor = Color.Black;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string conn = "Data Source=DESKTOP-396O81C\\SQLSERVER;Initial Catalog=SpairPartsUnderData;Integrated Security=True";
                SqlConnection lin = new SqlConnection(conn);
                lin.Open();
                string Id = txtID.Text;
                string Catogary = txtCategory.Text;
                string Query = "insert into Category values('" + Catogary + "')";
                SqlCommand cmd = new SqlCommand(Query, lin);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Succesfully");

                GradeView();
                lin.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please Check Again Letter");
            }
               
          

        }
        void GradeView()
        {
            string contr = "Data Source=DESKTOP-396O81C\\SQLSERVER;Initial Catalog=SpairPartsUnderData;Integrated Security=True";
            SqlConnection conn = new SqlConnection(contr);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Category", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DgvCAtegory.DataSource = dt;
        }

        private void dgvCatogary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtCategory.Clear();
            }
            catch ( Exception ex)
            {

                MessageBox.Show("Please Write a Few words!");
            }
        }

        private void DgvCAtegory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = DgvCAtegory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCategory.Text = DgvCAtegory.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
        }

        private void Caregory_Load(object sender, EventArgs e)
        {
            GradeView();
        }
    }
}
