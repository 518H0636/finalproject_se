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

        private void dgvCate_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                txtCateID.Focus();
                return;
            }
            if (tblCategory.Rows.Count == 0)
            {
                MessageBox.Show("No data!", "Notification", MessageBoxButtons.OK);
                return;
            }
            txtCateID.Text = dgvCate.CurrentRow.Cells["cateID"].Value.ToString();
            txtCateName.Text = dgvCate.CurrentRow.Cells["cateName"].Value.ToString();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            RV();
            txtCateID.Enabled = true;
            txtCateID.Focus();
        }

        private void RV()
        {
            txtCateID.Text = "";
            txtCateName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                string sql;
                if (txtCateID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Pls enter the category ID", "Notification", MessageBoxButtons.OK);
                    txtCateID.Focus();
                    return;
                }
                if (txtCateName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Pls enter the category name", "Notification", MessageBoxButtons.OK);
                    txtCateName.Focus();
                    return;
                }
                sql = "Select cateID From tblCategory where cateID=N'" + txtCateID.Text.Trim() + "'";
                if (Class.Function.CheckKey(sql))
                {
                    MessageBox.Show("This category ID already exits", "Notification", MessageBoxButtons.OK);
                    txtCateID.Focus();
                    return;
                }

                sql = "INSERT INTO tblCategory VALUES(N'" +
                    txtCateID.Text + "',N'" + txtCateName.Text + "')";
                Class.Function.RunSQL(sql);
                LoadDataGridView();
                RV();
                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                txtCateID.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCategory.Rows.Count == 0)
            {
                MessageBox.Show("No data", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtCateID.Text == "")
            {
                MessageBox.Show("Choose somthing to edit first", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtCateName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls write the category name to edit", "Notification", MessageBoxButtons.OK);
                return;
            }
            sql = "UPDATE tblCategory SET cateName=N'" +
                txtCateName.Text.ToString() +
                "' WHERE cateName=N'" + txtCateName.Text + "'";
            Class.Function.RunSQL(sql);
            LoadDataGridView();
            RV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCategory.Rows.Count == 0)
            {
                MessageBox.Show("No data", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtCateID.Text == "")
            {
                MessageBox.Show("PLs choose something to delete", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Confirm Delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblCategory WHERE cateID=N'" + txtCateID.Text + "'";
                Class.Function.SqlDel(sql);
                LoadDataGridView();
                RV();
            }
        }
    }
}
