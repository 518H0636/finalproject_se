namespace finalproject
{
    partial class frmGoodRecieve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Employee = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGreID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGre = new System.Windows.Forms.DataGridView();
            this.Employee.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGre)).BeginInit();
            this.SuspendLayout();
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.groupBox3);
            this.Employee.Controls.Add(this.groupBox2);
            this.Employee.Location = new System.Drawing.Point(49, 61);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(763, 190);
            this.Employee.TabIndex = 20;
            this.Employee.TabStop = false;
            this.Employee.Text = "Check info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.txtdate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtGreID);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(18, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 163);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(27, 99);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(335, 50);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(129, 69);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(233, 22);
            this.txtdate.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sell date";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(129, 41);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(233, 22);
            this.txtStatus.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Status";
            // 
            // txtGreID
            // 
            this.txtGreID.Location = new System.Drawing.Point(129, 11);
            this.txtGreID.Name = "txtGreID";
            this.txtGreID.Size = new System.Drawing.Size(233, 22);
            this.txtGreID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Agent ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(445, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 163);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(35, 99);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(225, 35);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(35, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(225, 35);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "DELIVERY STATUS MANAGER";
            // 
            // dgvGre
            // 
            this.dgvGre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGre.Location = new System.Drawing.Point(49, 257);
            this.dgvGre.Name = "dgvGre";
            this.dgvGre.RowHeadersWidth = 51;
            this.dgvGre.RowTemplate.Height = 24;
            this.dgvGre.Size = new System.Drawing.Size(763, 176);
            this.dgvGre.TabIndex = 18;
            this.dgvGre.Click += new System.EventHandler(this.dgvGre_Click);
            // 
            // frmGoodRecieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGre);
            this.Name = "frmGoodRecieve";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmGoodRecieve";
            this.Load += new System.EventHandler(this.frmGoodRecieve_Load);
            this.Employee.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Employee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGreID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
    }
}