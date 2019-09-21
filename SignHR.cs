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

namespace WindowsFormsApp1
{
    public partial class SignHR : Form
    {
        public SignHR()
        {
            InitializeComponent();
        }

        private void SignHR_Load(object sender, EventArgs e)
        {

        }

        private void txtconfauto_TextChanged(object sender, EventArgs e)
        {
            if (txtpassadm.Text==txtconfauto.Text)
            {
                lblMessageco.Text = "Password Successful Match";
                btnSignHR.Enabled = true;
            }
            else
            {
                lblMessageco.Text = "Password doesn't Match";
                btnSignHR.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int au = r.Next(100000, 999999);
            txtpassadm.Text = Convert.ToString(au);
            txtconfauto.Text = Convert.ToString(au);
            lblautopass.Text = ("Your password is :" + au);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n = new Form1();
            n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class gol:Button
    {
        public gol()
        {
            GraphicsPath n = new GraphicsPath();
            n.AddEllipse(0, 0, 75,75);
            this.Region = new Region(n);

        }
    }
}
