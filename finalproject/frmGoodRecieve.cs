using finalproject.Class;
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
    public partial class frmGoodRecieve : Form
    {
        DataTable tblGoodRecieve;
        public frmGoodRecieve()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtGreID.Text == "")
            {
                MessageBox.Show("Pls enter the agent name to see and change order status", "", MessageBoxButtons.OK);
                return;
            }
            sql = "SELECT * from tblGoodRecieve WHERE 1=1";
            if (txtGreID.Text != "")
                sql += " AND agentID LIKE N'%" + txtGreID.Text + "%'";
            tblGoodRecieve = Function.GetDataToTable(sql);
            if (tblGoodRecieve.Rows.Count == 0)
                MessageBox.Show("There is no import reciept with your input info", "", MessageBoxButtons.OK);
            dgvGre.DataSource = tblGoodRecieve;
            RV();
        }
        private void RV()
        {
            txtGreID.Text = "";
            txtdate.Text = DateTime.Now.ToShortDateString();
            txtStatus.Text = "";
        }

        private void frmGoodRecieve_Load(object sender, EventArgs e)
        {
            txtGreID.Enabled = true;
            txtdate.Enabled = false;
            txtStatus.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT agentID, sellDate, StatusG FROM tblGoodRecieve";
            tblGoodRecieve = Function.GetDataToTable(sql);
            dgvGre.DataSource = tblGoodRecieve;
            dgvGre.Columns[0].HeaderText = "Agent Name";
            dgvGre.Columns[1].HeaderText = "Sell day";
            dgvGre.Columns[2].HeaderText = "Status";
            dgvGre.Columns[0].Width = 80;
            dgvGre.Columns[1].Width = 130;
            dgvGre.Columns[2].Width = 80;
            dgvGre.AllowUserToAddRows = false;
            dgvGre.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvGre_Click(object sender, EventArgs e)
        {
            if (btnSearch.Enabled == false)
            {
                txtGreID.Focus();
                return;
            }
            if (tblGoodRecieve.Rows.Count == 0)
            {
                MessageBox.Show("No data", "", MessageBoxButtons.OK);
                return;
            }
            txtGreID.Text = dgvGre.CurrentRow.Cells["agentID"].Value.ToString();
            txtdate.Text = dgvGre.CurrentRow.Cells["sellDate"].Value.ToString();
            txtStatus.Text = dgvGre.CurrentRow.Cells["StatusG"].Value.ToString();
            btnEdit.Enabled = true;
            txtdate.Enabled = true;
            txtStatus.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql;
            txtGreID.Enabled = false;
            txtdate.Enabled = false;
            if (txtStatus.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pls change order's status", "", MessageBoxButtons.OK);
                return;
            }
            sql = "UPDATE tblGoodRecieve SET StatusG=N'" +
                txtStatus.Text.ToString() +
                "' WHERE AgentID=N'" + txtGreID.Text + "'";
            Class.Function.RunSQL(sql);
            LoadDataGridView();
            RV();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
