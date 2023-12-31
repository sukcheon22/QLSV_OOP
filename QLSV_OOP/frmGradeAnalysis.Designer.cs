namespace QLSV_OOP
{
    partial class frmGradeAnalysis
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
            this.gradeDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFailed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumStudent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumPassed = new System.Windows.Forms.TextBox();
            this.menuStripAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAccount
            // 
            this.menuStripAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStripAccount.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportFileToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStripAccount.Location = new System.Drawing.Point(0, 0);
            this.menuStripAccount.Name = "menuStripAccount";
            this.menuStripAccount.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStripAccount.Size = new System.Drawing.Size(800, 24);
            this.menuStripAccount.TabIndex = 10;
            this.menuStripAccount.Text = "menuStrip1";
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.exportFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.exportFileToolStripMenuItem.Text = "Xuất file";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.backToolStripMenuItem.Text = "Quay lại";
            // 
            // gradeDataGridView
            // 
            this.gradeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeDataGridView.Location = new System.Drawing.Point(13, 223);
            this.gradeDataGridView.Name = "gradeDataGridView";
            this.gradeDataGridView.RowHeadersWidth = 51;
            this.gradeDataGridView.Size = new System.Drawing.Size(775, 221);
            this.gradeDataGridView.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "THỐNG KÊ KẾT QUẢ HỌC TẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số SV trượt ít nhất 1 môn học:";
            // 
            // txtNumFailed
            // 
            this.txtNumFailed.Location = new System.Drawing.Point(263, 13);
            this.txtNumFailed.Name = "txtNumFailed";
            this.txtNumFailed.Size = new System.Drawing.Size(46, 20);
            this.txtNumFailed.TabIndex = 4;
            this.txtNumFailed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số SV chưa trượt môn học nào:";
            // 
            // txtNumStudent
            // 
            this.txtNumStudent.Location = new System.Drawing.Point(91, 46);
            this.txtNumStudent.Name = "txtNumStudent";
            this.txtNumStudent.Size = new System.Drawing.Size(46, 20);
            this.txtNumStudent.TabIndex = 6;
            this.txtNumStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNumPassed);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNumFailed);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNumStudent);
            this.panel1.Location = new System.Drawing.Point(115, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 118);
            this.panel1.TabIndex = 13;
            // 
            // txtNumPassed
            // 
            this.txtNumPassed.Location = new System.Drawing.Point(263, 48);
            this.txtNumPassed.Name = "txtNumPassed";
            this.txtNumPassed.Size = new System.Drawing.Size(46, 20);
            this.txtNumPassed.TabIndex = 7;
            this.txtNumPassed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGradeAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripAccount);
            this.Controls.Add(this.gradeDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmGradeAnalysis";
            this.Text = "frmGradeAnalysis";
            this.Load += new System.EventHandler(this.frmGradeAnalysis_Load);
            this.menuStripAccount.ResumeLayout(false);
            this.menuStripAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView gradeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFailed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumPassed;
    }
}