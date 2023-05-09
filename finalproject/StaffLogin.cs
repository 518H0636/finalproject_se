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
using DevExpress.Pdf.Native.BouncyCastle.Ocsp;
using finalproject.Class;

namespace finalproject
{
    public partial class StaffLogin : Form
    {
        DataTable tblEmployee;
        public StaffLogin()
        {
            InitializeComponent();
        }
     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String empID, empPass;
            empID = textBox1.Text;
            empPass= textBox2.Text;
            try
            {
                String sql = "SELECT empID, empPass FROM tblEmployee WHERE empID= '" + textBox1.Text + "' AND empPass= '" + textBox2.Text+"'";
                Class.Function.Connect();
                tblEmployee= Class.Function.GetDataToTable(sql);
                if (tblEmployee.Rows.Count > 0)
                {
                    empID = textBox1.Text;
                    empPass = textBox2.Text;

                    frmMain frmMain= new frmMain();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid log in","",MessageBoxButtons.OK);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
