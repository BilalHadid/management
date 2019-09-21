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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=DESKTOP-396O81C\\SQLSERVER;Initial Catalog=SpairPartsUnderData;Integrated Security=True";
            SqlConnection link = new SqlConnection(conn);
            link.Open();

            string Id = txtID.Text;
            string Date = dtp.Text;
            string Head = txtHead.Text;
            string Contact = mtbContact.Text;
            string Name = txtName.Text;
            string Ammount = txtAmmount.Text;

            string card;
            if (radioButton1.Checked==true)
            {
                card = radioButton1.Text;
            }
            else
            {
                card = radioButton2.Text;
            }

            string Query = "insert into Account values('" + Date + "','" + Head + "''" + Contact + "','" + Name + "''" + Ammount + "','" + card + "')";
            SqlCommand cmd = new SqlCommand(Query, link);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Successfully Enter");
            
            link.Close();
        }
    }
}
