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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportFileToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFileToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.exportFileToolStripMenuItem.Text = "Xuất file";
            this.exportFileToolStripMenuItem.Click += new System.EventHandler(this.exportFileToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.backToolStripMenuItem.Text = "Quay lại";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ TÀI KHOẢN";
            // 
            // accDataGridView
            // 
            this.accDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accDataGridView.Location = new System.Drawing.Point(13, 217);
            this.accDataGridView.Name = "accDataGridView";
            this.accDataGridView.Size = new System.Drawing.Size(775, 221);
            this.accDataGridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin:";
            // 
            // txtNumAdmin
            // 
            this.txtNumAdmin.Location = new System.Drawing.Point(91, 13);
            this.txtNumAdmin.Name = "txtNumAdmin";
            this.txtNumAdmin.Size = new System.Drawing.Size(46, 20);
            this.txtNumAdmin.TabIndex = 4;
            this.txtNumAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumStudent
            // 
            this.txtNumStudent.Location = new System.Drawing.Point(91, 46);
            this.txtNumStudent.Name = "txtNumStudent";
            this.txtNumStudent.Size = new System.Drawing.Size(46, 20);
            this.txtNumStudent.TabIndex = 6;
            this.txtNumStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sinh viên:";
            // 
            // txtNumEduEmployee
            // 
            this.txtNumEduEmployee.Location = new System.Drawing.Point(408, 11);
            this.txtNumEduEmployee.Name = "txtNumEduEmployee";
            this.txtNumEduEmployee.Size = new System.Drawing.Size(50, 20);
            this.txtNumEduEmployee.TabIndex = 8;
            this.txtNumEduEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
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
            this.panel1.Location = new System.Drawing.Point(29, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 118);
            this.panel1.TabIndex = 9;
            // 
            // txtNumAcc
            // 
            this.txtNumAcc.Location = new System.Drawing.Point(91, 84);
            this.txtNumAcc.Name = "txtNumAcc";
            this.txtNumAcc.Size = new System.Drawing.Size(46, 20);
            this.txtNumAcc.TabIndex = 12;
            this.txtNumAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng:";
            // 
            // txtNumFinancialEmployee
            // 
            this.txtNumFinancialEmployee.Location = new System.Drawing.Point(408, 48);
            this.txtNumFinancialEmployee.Name = "txtNumFinancialEmployee";
            this.txtNumFinancialEmployee.Size = new System.Drawing.Size(50, 20);
            this.txtNumFinancialEmployee.TabIndex = 10;
            this.txtNumFinancialEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhân viên tài vụ:";
            // 
            // frmAccountAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAccountAnalysis";
            this.Text = "Thống kê tài khoản";
            this.Load += new System.EventHandler(this.frmAccountAnalysis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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