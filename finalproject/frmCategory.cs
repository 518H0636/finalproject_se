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
using finalproject.Class;

namespace finalproject
{
    public partial class frmCategory : Form
    {
        DataTable tblCategory;
        public frmCategory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            txtCateID.Enabled = false;
            btnSave.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT CateID, cateName FROM tblCategory";
            tblCategory = Class.Function.GetDataToTable(sql);
            dgvCate.DataSource = tblCategory;           
            dgvCate.Columns[0].HeaderText = "Mã chất liệu";
            dgvCate.Columns[1].HeaderText = "Mã chất liệu";
            dgvCate.Columns[0].Width = 100;
            dgvCate.Columns[1].Width = 300;
            dgvCate.AllowUserToAddRows = false; 
            dgvCate.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
