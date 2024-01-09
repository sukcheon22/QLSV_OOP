namespace QLSV_OOP
{
    partial class frmStudentAnalysis
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
            this.menuStripStudent = new System.Windows.Forms.MenuStrip();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumCountStudent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumCountK67 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumCountK68 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumCountK65 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumCountK66 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripStudent
            // 
            this.menuStripStudent.BackColor = System.Drawing.Color.Navy;
            this.menuStripStudent.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportFileToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStripStudent.Location = new System.Drawing.Point(0, 0);
            this.menuStripStudent.Name = "menuStripStudent";
            this.menuStripStudent.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStripStudent.Size = new System.Drawing.Size(1165, 26);
            this.menuStripStudent.TabIndex = 1;
            this.menuStripStudent.Text = "menuStrip1";
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFileToolStripMenuItem.ForeColor = System.Drawing.Color.Lavender;
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.exportFileToolStripMenuItem.Text = "Xuất file";
            this.exportFileToolStripMenuItem.Click += new System.EventHandler(this.exportFileToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.Lavender;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.backToolStripMenuItem.Text = "Quay lại";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNumCountStudent);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNumCountK67);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNumCountK68);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNumCountK65);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNumCountK66);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(147, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 145);
            this.panel1.TabIndex = 12;
            // 
            // txtNumCountStudent
            // 
            this.txtNumCountStudent.Enabled = false;
            this.txtNumCountStudent.Location = new System.Drawing.Point(417, 108);
            this.txtNumCountStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCountStudent.Name = "txtNumCountStudent";
            this.txtNumCountStudent.Size = new System.Drawing.Size(68, 22);
            this.txtNumCountStudent.TabIndex = 20;
            this.txtNumCountStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(292, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tổng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(492, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Khóa 68:";
            // 
            // txtNumCountK67
            // 
            this.txtNumCountK67.Enabled = false;
            this.txtNumCountK67.Location = new System.Drawing.Point(645, 16);
            this.txtNumCountK67.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCountK67.Name = "txtNumCountK67";
            this.txtNumCountK67.Size = new System.Drawing.Size(68, 22);
            this.txtNumCountK67.TabIndex = 17;
            this.txtNumCountK67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(492, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Khóa 67:";
            // 
            // txtNumCountK68
            // 
            this.txtNumCountK68.Enabled = false;
            this.txtNumCountK68.Location = new System.Drawing.Point(645, 62);
            this.txtNumCountK68.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCountK68.Name = "txtNumCountK68";
            this.txtNumCountK68.Size = new System.Drawing.Size(68, 22);
            this.txtNumCountK68.TabIndex = 16;
            this.txtNumCountK68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(492, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(12, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Khóa 66:";
            // 
            // txtNumCountK65
            // 
            this.txtNumCountK65.Enabled = false;
            this.txtNumCountK65.Location = new System.Drawing.Point(165, 16);
            this.txtNumCountK65.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCountK65.Name = "txtNumCountK65";
            this.txtNumCountK65.Size = new System.Drawing.Size(68, 22);
            this.txtNumCountK65.TabIndex = 10;
            this.txtNumCountK65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khóa 65:";
            // 
            // txtNumCountK66
            // 
            this.txtNumCountK66.Enabled = false;
            this.txtNumCountK66.Location = new System.Drawing.Point(165, 62);
            this.txtNumCountK66.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCountK66.Name = "txtNumCountK66";
            this.txtNumCountK66.Size = new System.Drawing.Size(68, 22);
            this.txtNumCountK66.TabIndex = 8;
            this.txtNumCountK66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 7;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Location = new System.Drawing.Point(53, 261);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersWidth = 62;
            this.studentDataGridView.Size = new System.Drawing.Size(1051, 272);
            this.studentDataGridView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "THỐNG KÊ SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmStudentAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmStudentAnalysis";
            this.Text = "Thống kê sinh viên";
            this.Load += new System.EventHandler(this.frmStudentAnalysis_Load);
            this.menuStripStudent.ResumeLayout(false);
            this.menuStripStudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripStudent;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumCountK66;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumCountK65;
        private System.Windows.Forms.TextBox txtNumCountStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumCountK67;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumCountK68;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}