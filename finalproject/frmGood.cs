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
    public partial class frmGood : Form
    {
        DataTable tblGood;
        public frmGood()
        {
            InitializeComponent();
        }

        private void frmGood_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from tblCategory";
            txtGoodID.Enabled = false;
            btnSave.Enabled = false;
            LoadDataGridView();
            Function.FillCombo(sql, cboCategory, "cateID", "cateName");
            cboCategory.SelectedIndex = -1;
            RV();
        }
        private void RV()
        {
            txtGoodID.Text = "";
            txtGoodName.Text = "";
            cboCategory.Text = "";
            txtAmount.Text = "0";
            txtUnitPrice.Text = "0";
            txtUnitSold.Text = "0";
            txtAmount.Enabled = true;
            txtUnitPrice.Enabled = false;
            txtUnitSold.Enabled = false;;
            txtNote.Text = "";
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblGood";
            tblGood = Function.GetDataToTable(sql);
            dgvGood.DataSource = tblGood;
            dgvGood.Columns[0].HeaderText = "Goods ID";
            dgvGood.Columns[1].HeaderText = "Goods Name";
            dgvGood.Columns[2].HeaderText = "Category";
            dgvGood.Columns[3].HeaderText = "Amount";
            dgvGood.Columns[4].HeaderText = "Unit price";
            dgvGood.Columns[5].HeaderText = "Unit sold";
            dgvGood.Columns[6].HeaderText = "Note";
            dgvGood.Columns[0].Width = 85;
            dgvGood.Columns[1].Width = 135;
            dgvGood.Columns[2].Width = 85;
            dgvGood.Columns[3].Width = 85;
            dgvGood.Columns[4].Width = 110;
            dgvGood.Columns[5].Width = 110;
            dgvGood.Columns[6].Width = 250;
            dgvGood.AllowUserToAddRows = false;
            dgvGood.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvGood_Click(object sender, EventArgs e)
        {
            string CateID;
            string sql;
            if (btnAdd.Enabled == false)
            {
                txtGoodID.Focus();
                return;
            }
            if (tblGood.Rows.Count == 0)
            {
                MessageBox.Show("No data", "", MessageBoxButtons.OK);
                return;
            }
            txtGoodID.Text = dgvGood.CurrentRow.Cells["goodID"].Value.ToString();
            txtGoodName.Text = dgvGood.CurrentRow.Cells["goodName"].Value.ToString();
            CateID = dgvGood.CurrentRow.Cells["cateID"].Value.ToString();
            sql = "SELECT cateName FROM tblCategory WHERE cateID=N'" + CateID + "'";
            cboCategory.Text = Function.FieldValues(sql);
            txtAmount.Text = dgvGood.CurrentRow.Cells["goodAmount"].Value.ToString();
            txtUnitPrice.Text = dgvGood.CurrentRow.Cells["unitPrice"].Value.ToString();
            txtUnitSold.Text = dgvGood.CurrentRow.Cells["unitSold"].Value.ToString();
            sql = "SELECT importnote FROM tblGood WHERE goodID = N'" + txtGoodID.Text + "'";
            txtNote.Text = Function.FieldValues(sql);
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            RV();
            txtGoodID.Enabled = true;
            txtGoodID.Focus();
            txtAmount.Enabled = true;
            txtUnitPrice.Enabled = true;
            txtUnitSold.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtGoodID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter goods ID", "", MessageBoxButtons.OK);
                txtGoodID.Focus();
                return;
            }
            if (txtGoodName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter goods name", "", MessageBoxButtons.OK);
                txtGoodName.Focus();
                return;
            }
            if (cboCategory.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter the category", "", MessageBoxButtons.OK);
                cboCategory.Focus();
                return;
            }
            sql = "SELECT goodID FROM tblGood WHERE goodID=N'" + txtGoodID.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Pls enter anther goods ID", "", MessageBoxButtons.OK);
                txtGoodID.Focus();
                return;
            }
            sql = "INSERT INTO tblGood(goodID,goodName,cateID,goodAmount,unitPrice,unitSold,importnote) VALUES(N'"
                + txtGoodID.Text.Trim() + "',N'" + txtGoodName.Text.Trim() +
                "',N'" + cboCategory.SelectedValue.ToString() +
                "'," + txtAmount.Text.Trim() + "," + txtUnitPrice.Text +
                "," + txtUnitSold.Text + ",N'" + txtNote.Text.Trim() + "')";

            Function.RunSQL(sql);
            LoadDataGridView();
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtGoodID.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtGoodID.Text == "")
            {
                MessageBox.Show("Pls choose something to edit", "", MessageBoxButtons.OK);
                txtGoodID.Focus();
                return;
            }
            if (txtGoodName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter goods's name", "", MessageBoxButtons.OK);
                txtGoodName.Focus();
                return;
            }
            if (cboCategory.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls choose category", "", MessageBoxButtons.OK);
                cboCategory.Focus();
                return;
            }
            sql = "UPDATE tblGood SET goodName=N'" + txtGoodName.Text.Trim().ToString() +
                "',cateID=N'" + cboCategory.SelectedValue.ToString() +
                "',SoLuong=" + txtAmount.Text + "',importnote=N'" + txtNote.Text + "' WHERE goodID=N'" + txtGoodID.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            RV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtGoodID.Text == "")
            {
                MessageBox.Show("Pls choose something to delete", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Confirm Delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblGood WHERE goodID=N'" + txtGoodID.Text + "'";
                Function.SqlDel(sql);
                LoadDataGridView();
                RV();
            }
        }

        private void btnWareReShow_Click(object sender, EventArgs e)
        {
            txtGoodID.Enabled = false;
            txtGoodName.Enabled = false;
            txtAmount.Enabled = false;
            cboCategory.Enabled = false;
            string sql;
            if (txtNote.Text == "")
            {
                MessageBox.Show("Pls enter the note to show import receipt", "", MessageBoxButtons.OK);
                return;
            }
            sql = "SELECT * from tblGood WHERE 1=1";
            if (txtNote.Text != "")
                sql += " AND importnote LIKE N'%" + txtNote.Text + "%'";
            tblGood = Function.GetDataToTable(sql);
            if (tblGood.Rows.Count == 0)
                MessageBox.Show("There is no import reciept with your input info", "", MessageBoxButtons.OK);
            dgvGood.DataSource = tblGood;
            RV();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT goodID,goodName,cateID,goodAmount,unitPrice,unitSold,importnote FROM tblGood";
            tblGood = Function.GetDataToTable(sql);
            dgvGood.DataSource = tblGood;
        }
    }
}
