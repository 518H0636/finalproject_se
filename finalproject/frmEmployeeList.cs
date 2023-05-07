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
    public partial class frmEmployeeList : Form
    {
        DataTable tblEmployee;
        public frmEmployeeList()
        {
            InitializeComponent();
        }

        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
            txtEmpID.Enabled = false;
            btnSave.Enabled = false;
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT empID,empName,empPhonenum FROM tblEmployee";
            tblEmployee = Function.GetDataToTable(sql);
            dgvEmployee.DataSource = tblEmployee;
            dgvEmployee.Columns[0].HeaderText = "Employee ID";
            dgvEmployee.Columns[1].HeaderText = "Employee Name";
            dgvEmployee.Columns[2].HeaderText = "Employee Phone";
            dgvEmployee.Columns[0].Width = 100;
            dgvEmployee.Columns[1].Width = 150;
            dgvEmployee.Columns[2].Width = 100;
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                txtEmpID.Focus();
                return;
            }
            if (tblEmployee.Rows.Count == 0)
            {
                MessageBox.Show("No data", "Notification", MessageBoxButtons.OK);
                return;
            }
            txtEmpID.Text = dgvEmployee.CurrentRow.Cells["empID"].Value.ToString();
            txtEmpName.Text = dgvEmployee.CurrentRow.Cells["empName"].Value.ToString();
            mtbPhone.Text = dgvEmployee.CurrentRow.Cells["empPhonenum"].Value.ToString();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void RV()
        {
            txtEmpID.Text = "";
            txtEmpName.Text = "";
            mtbPhone.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            RV();
            txtEmpID.Enabled = true;
            txtEmpID.Focus();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblEmployee.Rows.Count == 0)
            {
                MessageBox.Show("No data", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtEmpID.Text == "")
            {
                MessageBox.Show("Pls choose something to edit", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtEmpName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter employee name", "Notification", MessageBoxButtons.OK);
                txtEmpName.Focus();
                return;
            }
            if (mtbPhone.Text == "")
            {
                MessageBox.Show("Pls enter employee phone", "Notification", MessageBoxButtons.OK);
                mtbPhone.Focus();
                return;
            }
            sql = "UPDATE tblEmployee SET  empName=N'" + txtEmpName.Text.Trim().ToString() +
                    "',empPhonenum='" + mtbPhone.Text.ToString() +
                    "' WHERE empID=N'" + txtEmpID.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            RV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtEmpID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter the employee ID", "Notification", MessageBoxButtons.OK);
                txtEmpID.Focus();
                return;
            }
            if (txtEmpName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter the employee name", "Notification", MessageBoxButtons.OK);
                txtEmpName.Focus();
                return;
            }
            if (mtbPhone.Text == "")
            {
                MessageBox.Show("Pls enter the employee phone number", "Notification", MessageBoxButtons.OK);
                mtbPhone.Focus();
                return;
            }
            sql = "SELECT empID FROM tblEmployee WHERE empID=N'" + txtEmpID.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Already exit, pls end another employee ID", "Notification", MessageBoxButtons.OK);
                txtEmpID.Focus();
                txtEmpID.Text = "";
                return;
            }
            sql = "INSERT INTO tblEmployee(empID,empName,empPhonenum) VALUES (N'" + txtEmpID.Text.Trim() + "',N'" + txtEmpName.Text.Trim() + "',N'" + mtbPhone.Text + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
            RV();
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtEmpID.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblEmployee.Rows.Count == 0)
            {
                MessageBox.Show("No data", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtEmpID.Text == "")
            {
                MessageBox.Show("You dont have anything to delete yet", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Confirm Delete?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblEmployee WHERE empID=N'" + txtEmpID.Text + "'";
                Function.SqlDel(sql);
                LoadDataGridView();
                RV();
            }
        }
    }
}
