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
            Con.ConnectionString = Properties.Settings.Default.Warehouseco;
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
                MessageBox.Show("Connect successfully");
            }
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
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Function.Con;
            dap.SelectCommand.CommandText = sql; 
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
    }
}
