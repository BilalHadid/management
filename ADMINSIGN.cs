using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ADMINSIGN : Form
    {
        public ADMINSIGN()
        {
            InitializeComponent();
        }

        private void ADMINSIGN_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AdminPanel a = new AdminPanel();
            a.Show();
        }

        private void purchaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void getDemandListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDemandadmin n = new GetDemandadmin();
            n.Show();
        }

        private void dataBaseRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRecover D = new DataRecover();
            D.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Caregory C = new Caregory();
            C.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product P=new Product();
            P.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            Account A = new Account();
            A.Show();
            
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            Sale S = new Sale();
            S.Show();
        }

        private void purchace_Click(object sender, EventArgs e)
        {
            Purchase P = new Purchase();
            P.Show();
        }

        private void Ammount_Click(object sender, EventArgs e)
        {
            Ammount Am = new Ammount();
            Am.Show();
        }

        private void Expence_Click(object sender, EventArgs e)
        {

        }

        private void btnAccHead_Click(object sender, EventArgs e)
        {
            AccountHead Ah = new AccountHead();
            Ah.Show();
        }

        private void btnAccMotor_Click(object sender, EventArgs e)
        {
            AccountMotor Am = new AccountMotor();
            Am.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
