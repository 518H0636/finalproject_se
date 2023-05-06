using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finalproject.Class
{
    internal class Function
    {
        public static SqlConnection Con;

        public static void Connect()
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\Warehousemanagement.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            Con.Open();
            if (Con.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Can't connect");
        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }
    }
}
