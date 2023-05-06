namespace finalproject
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGood = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReceiptR = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReceiptS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoodS = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuManagement,
            this.mnuReceipt,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(36, 9, 0, 9);
            this.menuStrip1.Size = new System.Drawing.Size(800, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(52, 29);
            this.mnuFile.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // mnuManagement
            // 
            this.mnuManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCategory,
            this.mnuEmployee,
            this.mnuAgent,
            this.mnuGood});
            this.mnuManagement.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuManagement.Name = "mnuManagement";
            this.mnuManagement.Size = new System.Drawing.Size(131, 29);
            this.mnuManagement.Text = "Management";
            // 
            // mnuCategory
            // 
            this.mnuCategory.Name = "mnuCategory";
            this.mnuCategory.Size = new System.Drawing.Size(158, 26);
            this.mnuCategory.Text = "Category";
            // 
            // mnuEmployee
            // 
            this.mnuEmployee.Name = "mnuEmployee";
            this.mnuEmployee.Size = new System.Drawing.Size(158, 26);
            this.mnuEmployee.Text = "Employee";
            // 
            // mnuAgent
            // 
            this.mnuAgent.Name = "mnuAgent";
            this.mnuAgent.Size = new System.Drawing.Size(158, 26);
            this.mnuAgent.Text = "Agent";
            // 
            // mnuGood
            // 
            this.mnuGood.Name = "mnuGood";
            this.mnuGood.Size = new System.Drawing.Size(158, 26);
            this.mnuGood.Text = "Good";
            // 
            // mnuReceipt
            // 
            this.mnuReceipt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReceiptR});
            this.mnuReceipt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReceipt.Name = "mnuReceipt";
            this.mnuReceipt.Size = new System.Drawing.Size(83, 29);
            this.mnuReceipt.Text = "Receipt";
            this.mnuReceipt.Click += new System.EventHandler(this.goodToolStripMenuItem_Click);
            // 
            // mnuReceiptR
            // 
            this.mnuReceiptR.Name = "mnuReceiptR";
            this.mnuReceiptR.Size = new System.Drawing.Size(224, 30);
            this.mnuReceiptR.Text = "Delivery Slip";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReceiptS,
            this.mnuGoodS});
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // mnuReceiptS
            // 
            this.mnuReceiptS.Name = "mnuReceiptS";
            this.mnuReceiptS.Size = new System.Drawing.Size(142, 26);
            this.mnuReceiptS.Text = "Receipt";
            // 
            // mnuGoodS
            // 
            this.mnuGoodS.Name = "mnuGoodS";
            this.mnuGoodS.Size = new System.Drawing.Size(142, 26);
            this.mnuGoodS.Text = "Good";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "WAREHOUSE MANAGEMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(36F, 69F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Name = "frmMain";
            this.Text = "Warehouse Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManagement;
        private System.Windows.Forms.ToolStripMenuItem mnuCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuAgent;
        private System.Windows.Forms.ToolStripMenuItem mnuGood;
        private System.Windows.Forms.ToolStripMenuItem mnuReceipt;
        private System.Windows.Forms.ToolStripMenuItem mnuReceiptR;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReceiptS;
        private System.Windows.Forms.ToolStripMenuItem mnuGoodS;
        private System.Windows.Forms.Label label1;
    }
}

