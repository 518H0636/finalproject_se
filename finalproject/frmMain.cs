using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void goodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect();
            Application.Exit();
        }

        private void mnuCategory_Click(object sender, EventArgs e)
        {
            frmCategory frmCate = new frmCategory();
            frmCate.ShowDialog();
        }

        private void mnuEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeList frmEmp = new frmEmployeeList();
            frmEmp.Show();
        }

        private void mnuAgent_Click(object sender, EventArgs e)
        {
            frmAgent frmAgent = new frmAgent();
            frmAgent.Show();
        }

        private void mnuGood_Click(object sender, EventArgs e)
        {
            frmGood frmGood = new frmGood();
            frmGood.Show();
        }

        private void mnuReceiptR_Click(object sender, EventArgs e)
        {
            frmGoodRecieve frmGoodRecieve = new frmGoodRecieve();
            frmGoodRecieve.Show();
        }
    }
}
