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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.accDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ TÀI KHOẢN";
            // 
            // accDataGridView
            // 
            this.accDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accDataGridView.Location = new System.Drawing.Point(17, 267);
            this.accDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.accDataGridView.Name = "accDataGridView";
            this.accDataGridView.RowHeadersWidth = 51;
            this.accDataGridView.Size = new System.Drawing.Size(1033, 272);
            this.accDataGridView.TabIndex = 2;
            this.accDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin:";
            // 
            // txtNumAdmin
            // 
            this.txtNumAdmin.Enabled = false;
            this.txtNumAdmin.Location = new System.Drawing.Point(121, 16);
            this.txtNumAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumAdmin.Name = "txtNumAdmin";
            this.txtNumAdmin.Size = new System.Drawing.Size(60, 22);
            this.txtNumAdmin.TabIndex = 4;
            this.txtNumAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumStudent
            // 
            this.txtNumStudent.Enabled = false;
            this.txtNumStudent.Location = new System.Drawing.Point(121, 57);
            this.txtNumStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumStudent.Name = "txtNumStudent";
            this.txtNumStudent.Size = new System.Drawing.Size(60, 22);
            this.txtNumStudent.TabIndex = 6;
            this.txtNumStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sinh viên:";
            // 
            // txtNumEduEmployee
            // 
            this.txtNumEduEmployee.Enabled = false;
            this.txtNumEduEmployee.Location = new System.Drawing.Point(544, 14);
            this.txtNumEduEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumEduEmployee.Name = "txtNumEduEmployee";
            this.txtNumEduEmployee.Size = new System.Drawing.Size(65, 22);
            this.txtNumEduEmployee.TabIndex = 8;
            this.txtNumEduEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(336, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
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
            this.panel1.Location = new System.Drawing.Point(163, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 145);
            this.panel1.TabIndex = 9;
            // 
            // txtNumAcc
            // 
            this.txtNumAcc.Enabled = false;
            this.txtNumAcc.Location = new System.Drawing.Point(121, 103);
            this.txtNumAcc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumAcc.Name = "txtNumAcc";
            this.txtNumAcc.Size = new System.Drawing.Size(60, 22);
            this.txtNumAcc.TabIndex = 12;
            this.txtNumAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng:";
            // 
            // txtNumFinancialEmployee
            // 
            this.txtNumFinancialEmployee.Enabled = false;
            this.txtNumFinancialEmployee.Location = new System.Drawing.Point(544, 59);
            this.txtNumFinancialEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumFinancialEmployee.Name = "txtNumFinancialEmployee";
            this.txtNumFinancialEmployee.Size = new System.Drawing.Size(65, 22);
            this.txtNumFinancialEmployee.TabIndex = 10;
            this.txtNumFinancialEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumFinancialEmployee.TextChanged += new System.EventHandler(this.txtNumFinancialEmployee_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(336, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhân viên tài vụ:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.backToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.Lavender;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.exportToolStripMenuItem.Text = "Xuất file";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportFileToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem1.ForeColor = System.Drawing.Color.Lavender;
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(79, 24);
            this.backToolStripMenuItem1.Text = "Quay lại";
            this.backToolStripMenuItem1.Click += new System.EventHandler(this.backToolStripMenuItem1_Click);
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.exportFileToolStripMenuItem.Text = "Xuất file";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.quayLạiToolStripMenuItem.Text = "Quay lại";
            // 
            // frmAccountAnalysis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAccountAnalysis";
            this.Text = "Thống kê tài khoản";
            this.Load += new System.EventHandler(this.frmAccountAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem1;
    }
}