namespace QLSV_OOP
{
    partial class frmAdmin
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
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeManagement1 = new QLSV_OOP.EmployeeManagement();
            this.accountManagement1 = new QLSV_OOP.AccountManagement();
            this.studentManagement1 = new QLSV_OOP.StudentManagement();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.analyzeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItemSignOut});
            this.personalToolStripMenuItem.ForeColor = System.Drawing.Color.Lavender;
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.personalToolStripMenuItem.Text = "Cá nhân";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            this.personalToolStripMenuItem.MouseLeave += new System.EventHandler(this.personalToolStripMenuItem_MouseLeave);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.changePasswordToolStripMenuItem.Text = "Đổi mật khẩu";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItemSignOut
            // 
            this.toolStripMenuItemSignOut.ForeColor = System.Drawing.Color.Navy;
            this.toolStripMenuItemSignOut.Name = "toolStripMenuItemSignOut";
            this.toolStripMenuItemSignOut.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItemSignOut.Text = "Đăng xuất";
            this.toolStripMenuItemSignOut.Click += new System.EventHandler(this.toolStripMenuItemSignOut_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.authorizeToolStripMenuItem});
            this.manageToolStripMenuItem.ForeColor = System.Drawing.Color.Lavender;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.manageToolStripMenuItem.Text = "Quản lý";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            this.manageToolStripMenuItem.MouseLeave += new System.EventHandler(this.manageToolStripMenuItem_MouseLeave);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.accountToolStripMenuItem.Text = "Tài khoản";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.employeeToolStripMenuItem.Text = "Nhân viên";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.studentToolStripMenuItem.Text = "Sinh viên";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // authorizeToolStripMenuItem
            // 
            this.authorizeToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.authorizeToolStripMenuItem.Name = "authorizeToolStripMenuItem";
            this.authorizeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.authorizeToolStripMenuItem.Text = "Phân quyền";
            this.authorizeToolStripMenuItem.Click += new System.EventHandler(this.authorizeToolStripMenuItem_Click);
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem1,
            this.employeeToolStripMenuItem1,
            this.studentToolStripMenuItem1});
            this.analyzeToolStripMenuItem.ForeColor = System.Drawing.Color.Lavender;
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.analyzeToolStripMenuItem.Text = "Thống kê";
            this.analyzeToolStripMenuItem.Click += new System.EventHandler(this.analyzeToolStripMenuItem_Click);
            this.analyzeToolStripMenuItem.MouseLeave += new System.EventHandler(this.analyzeToolStripMenuItem_MouseLeave);
            // 
            // accountToolStripMenuItem1
            // 
            this.accountToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            this.accountToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.accountToolStripMenuItem1.Text = "Tài khoản";
            this.accountToolStripMenuItem1.Click += new System.EventHandler(this.accountToolStripMenuItem1_Click);
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.employeeToolStripMenuItem1.Text = "Nhân viên";
            this.employeeToolStripMenuItem1.Click += new System.EventHandler(this.employeeToolStripMenuItem1_Click);
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.studentToolStripMenuItem1.Text = "Sinh viên";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.employeeManagement1);
            this.panel1.Controls.Add(this.accountManagement1);
            this.panel1.Controls.Add(this.studentManagement1);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 577);
            this.panel1.TabIndex = 1;
            // 
            // employeeManagement1
            // 
            this.employeeManagement1.Location = new System.Drawing.Point(-1, 0);
            this.employeeManagement1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeManagement1.Name = "employeeManagement1";
            this.employeeManagement1.Size = new System.Drawing.Size(1057, 530);
            this.employeeManagement1.TabIndex = 2;
            this.employeeManagement1.Load += new System.EventHandler(this.employeeManagement1_Load);
            // 
            // accountManagement1
            // 
            this.accountManagement1.Location = new System.Drawing.Point(0, 0);
            this.accountManagement1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountManagement1.Name = "accountManagement1";
            this.accountManagement1.Size = new System.Drawing.Size(757, 538);
            this.accountManagement1.TabIndex = 1;
            // 
            // studentManagement1
            // 
            this.studentManagement1.Location = new System.Drawing.Point(0, 0);
            this.studentManagement1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentManagement1.Name = "studentManagement1";
            this.studentManagement1.Size = new System.Drawing.Size(1056, 538);
            this.studentManagement1.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSignOut;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private StudentManagement studentManagement1;
        private AccountManagement accountManagement1;
        private EmployeeManagement employeeManagement1;
    }
}