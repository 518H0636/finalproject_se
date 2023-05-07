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
    public partial class frmAgent : Form
    {
        DataTable tblAgent;
        public frmAgent()
        {
            InitializeComponent();
        }

        private void frmAgent_Load(object sender, EventArgs e)
        {
            txtAgentID.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblAgent";
            tblAgent = Function.GetDataToTable(sql);
            dgvAgent.DataSource = tblAgent;
            dgvAgent.Columns[0].HeaderText = "Agent ID";
            dgvAgent.Columns[1].HeaderText = "Agent Name";
            dgvAgent.Columns[2].HeaderText = "Phone Number";
            dgvAgent.Columns[3].HeaderText = "Agent Adress";
            dgvAgent.Columns[4].HeaderText = "Password";
            dgvAgent.Columns[0].Width = 100;
            dgvAgent.Columns[1].Width = 150;
            dgvAgent.Columns[2].Width = 150;
            dgvAgent.Columns[3].Width = 150;
            dgvAgent.Columns[4].Width = 150;
            dgvAgent.AllowUserToAddRows = false;
            dgvAgent.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvAgent_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                txtAgentID.Focus();
                return;
            }
            if (tblAgent.Rows.Count == 0)
            {
                MessageBox.Show("No data", "Notification", MessageBoxButtons.OK);
                return;
            }
            txtAgentID.Text = dgvAgent.CurrentRow.Cells["agentID"].Value.ToString();
            txtAgentName.Text = dgvAgent.CurrentRow.Cells["agentName"].Value.ToString();
            mtbPhone.Text = dgvAgent.CurrentRow.Cells["phoneNum"].Value.ToString();
            txtAgentAdress.Text = dgvAgent.CurrentRow.Cells["agentAdress"].Value.ToString();
            txtPass.Text = dgvAgent.CurrentRow.Cells["agentPass"].Value.ToString();
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
            txtAgentID.Enabled = true;
            txtAgentID.Focus();
        }

        private void RV()
        {
            txtAgentID.Enabled = true;
            txtAgentID.Text = "";
            txtAgentName.Text = "";
            txtAgentAdress.Text = "";
            mtbPhone.Text = "";
            txtPass.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtAgentID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter the agent ID", "Notification", MessageBoxButtons.OK);
                txtAgentID.Focus();
                return;
            }
            if (txtAgentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter agent's Name", "Notification", MessageBoxButtons.OK);
                txtAgentName.Focus();
                return;
            }
            if (mtbPhone.Text == "")
            {
                MessageBox.Show("Pls enter agent's phone", "Notification", MessageBoxButtons.OK);
                mtbPhone.Focus();
                return;
            }
            if (txtAgentAdress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter agent's adress", "Notification", MessageBoxButtons.OK);
                txtAgentAdress.Focus();
                return;
            }
            if (txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter agent's password", "Notification", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            sql = "SELECT agentID FROM tblAgent WHERE agentID=N'" + txtAgentID.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Already exit agent ID", "Notification", MessageBoxButtons.OK);
                txtAgentID.Focus(); 
                return;
            }
            sql = "INSERT INTO tblAgent VALUES (N'" + txtAgentID.Text.Trim() +
                "',N'" + txtAgentName.Text.Trim() + "',N'" + mtbPhone.Text.Trim() + "',N'" + txtAgentAdress.Text.Trim()+ "','" + txtPass.Text + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
            RV();
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtAgentID.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblAgent.Rows.Count == 0)
            {
                MessageBox.Show("No data", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtAgentID.Text.Trim() == "")
            {
                MessageBox.Show("You dont have anyything to delete", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Confirm Delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblAgent WHERE agentID=N'" + txtAgentID.Text + "'";
                Function.SqlDel(sql);
                LoadDataGridView();
                RV();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblAgent.Rows.Count == 0)
            {
                MessageBox.Show("No data", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtAgentID.Text == "")
            {
                MessageBox.Show("Pls choose somthing to edit", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtAgentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter agent's Name", "Notification", MessageBoxButtons.OK);
                txtAgentName.Focus();
                return;
            }
            if (mtbPhone.Text == "")
            {
                MessageBox.Show("Pls enter agent's phone", "Notification", MessageBoxButtons.OK);
                mtbPhone.Focus();
                return;
            }
            if (txtAgentAdress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter agent's adress", "Notification", MessageBoxButtons.OK);
                txtAgentAdress.Focus();
                return;
            }
            if (txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls enter agent's password", "Notification", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            sql = "UPDATE tblAgent SET agentName=N'" + txtAgentName.Text.Trim().ToString() + "',phoneNum='" + mtbPhone.Text.ToString() + "',agentAdress=N'" +
                txtAgentAdress.Text.Trim().ToString() + "',agentPass='" + txtPass.Text.ToString() +
                "' WHERE agentID=N'" + txtAgentID.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            RV();
        }
    }
}
