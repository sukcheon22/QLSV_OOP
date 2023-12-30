namespace QLSV_OOP
{
    partial class frmAccountAnalysis
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
            this.menuStripAccount = new System.Windows.Forms.MenuStrip();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.accDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumAdmin = new System.Windows.Forms.TextBox();
            this.txtNumStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumEduEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumAcc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumFinancialEmployee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStripAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAccount
            // 
            this.menuStripAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStripAccount.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripAccount.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportFileToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStripAccount.Location = new System.Drawing.Point(0, 0);
            this.menuStripAccount.Name = "menuStripAccount";
            this.menuStripAccount.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripAccount.Size = new System.Drawing.Size(1200, 33);
            this.menuStripAccount.TabIndex = 0;
            this.menuStripAccount.Text = "menuStrip1";
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.exportFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.exportFileToolStripMenuItem.Text = "Xuất file";
            this.exportFileToolStripMenuItem.Click += new System.EventHandler(this.exportFileToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.backToolStripMenuItem.Text = "Quay lại";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ TÀI KHOẢN";
            // 
            // accDataGridView
            // 
            this.accDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accDataGridView.Location = new System.Drawing.Point(19, 334);
            this.accDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accDataGridView.Name = "accDataGridView";
            this.accDataGridView.RowHeadersWidth = 51;
            this.accDataGridView.Size = new System.Drawing.Size(1162, 340);
            this.accDataGridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin:";
            // 
            // txtNumAdmin
            // 
            this.txtNumAdmin.Location = new System.Drawing.Point(136, 20);
            this.txtNumAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumAdmin.Name = "txtNumAdmin";
            this.txtNumAdmin.Size = new System.Drawing.Size(67, 26);
            this.txtNumAdmin.TabIndex = 4;
            this.txtNumAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumStudent
            // 
            this.txtNumStudent.Location = new System.Drawing.Point(136, 71);
            this.txtNumStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumStudent.Name = "txtNumStudent";
            this.txtNumStudent.Size = new System.Drawing.Size(67, 26);
            this.txtNumStudent.TabIndex = 6;
            this.txtNumStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sinh viên:";
            // 
            // txtNumEduEmployee
            // 
            this.txtNumEduEmployee.Location = new System.Drawing.Point(612, 18);
            this.txtNumEduEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumEduEmployee.Name = "txtNumEduEmployee";
            this.txtNumEduEmployee.Size = new System.Drawing.Size(73, 26);
            this.txtNumEduEmployee.TabIndex = 8;
            this.txtNumEduEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhân viên đào tạo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNumAcc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNumFinancialEmployee);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNumEduEmployee);
            this.panel1.Controls.Add(this.txtNumAdmin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNumStudent);
            this.panel1.Location = new System.Drawing.Point(44, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 181);
            this.panel1.TabIndex = 9;
            // 
            // txtNumAcc
            // 
            this.txtNumAcc.Location = new System.Drawing.Point(136, 129);
            this.txtNumAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumAcc.Name = "txtNumAcc";
            this.txtNumAcc.Size = new System.Drawing.Size(67, 26);
            this.txtNumAcc.TabIndex = 12;
            this.txtNumAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng:";
            // 
            // txtNumFinancialEmployee
            // 
            this.txtNumFinancialEmployee.Location = new System.Drawing.Point(612, 74);
            this.txtNumFinancialEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumFinancialEmployee.Name = "txtNumFinancialEmployee";
            this.txtNumFinancialEmployee.Size = new System.Drawing.Size(73, 26);
            this.txtNumFinancialEmployee.TabIndex = 10;
            this.txtNumFinancialEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhân viên tài vụ:";
            // 
            // frmAccountAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripAccount);
            this.MainMenuStrip = this.menuStripAccount;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAccountAnalysis";
            this.Text = "Thống kê tài khoản";
            this.Load += new System.EventHandler(this.frmAccountAnalysis_Load);
            this.menuStripAccount.ResumeLayout(false);
            this.menuStripAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView accDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumAdmin;
        private System.Windows.Forms.TextBox txtNumStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumEduEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumFinancialEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumAcc;
        private System.Windows.Forms.Label label6;
    }
}