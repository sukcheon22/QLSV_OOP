﻿namespace QLSV_OOP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumBad = new System.Windows.Forms.TextBox();
            this.txtNumWell = new System.Windows.Forms.TextBox();
            this.txtNumGood = new System.Windows.Forms.TextBox();
            this.txtNumExcellent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gradeDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportFileToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1242, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
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
            this.backToolStripMenuItem.Size = new System.Drawing.Size(98, 32);
            this.backToolStripMenuItem.Text = "Quay lại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "THỐNG KÊ ĐIỂM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumBad);
            this.groupBox1.Controls.Add(this.txtNumWell);
            this.groupBox1.Controls.Add(this.txtNumGood);
            this.groupBox1.Controls.Add(this.txtNumExcellent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(46, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1132, 102);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điểm trung bình sinh viên";
            // 
            // txtNumBad
            // 
            this.txtNumBad.Location = new System.Drawing.Point(1034, 49);
            this.txtNumBad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumBad.Name = "txtNumBad";
            this.txtNumBad.Size = new System.Drawing.Size(73, 26);
            this.txtNumBad.TabIndex = 15;
            this.txtNumBad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumWell
            // 
            this.txtNumWell.Location = new System.Drawing.Point(738, 49);
            this.txtNumWell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumWell.Name = "txtNumWell";
            this.txtNumWell.Size = new System.Drawing.Size(73, 26);
            this.txtNumWell.TabIndex = 14;
            this.txtNumWell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumGood
            // 
            this.txtNumGood.Location = new System.Drawing.Point(408, 49);
            this.txtNumGood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumGood.Name = "txtNumGood";
            this.txtNumGood.Size = new System.Drawing.Size(73, 26);
            this.txtNumGood.TabIndex = 13;
            this.txtNumGood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumExcellent
            // 
            this.txtNumExcellent.Location = new System.Drawing.Point(135, 49);
            this.txtNumExcellent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumExcellent.Name = "txtNumExcellent";
            this.txtNumExcellent.Size = new System.Drawing.Size(73, 26);
            this.txtNumExcellent.TabIndex = 12;
            this.txtNumExcellent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(897, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trung bình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Khá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Giỏi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Xuất sắc";
            // 
            // gradeDataGridView
            // 
            this.gradeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeDataGridView.Location = new System.Drawing.Point(46, 256);
            this.gradeDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradeDataGridView.Name = "gradeDataGridView";
            this.gradeDataGridView.RowHeadersWidth = 51;
            this.gradeDataGridView.Size = new System.Drawing.Size(1132, 411);
            this.gradeDataGridView.TabIndex = 14;
            // 
            // frmGradeAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 684);
            this.Controls.Add(this.gradeDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGradeAnalysis";
            this.Text = "frmGradeAnalysis";
            this.Load += new System.EventHandler(this.frmGradeAnalysis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumBad;
        private System.Windows.Forms.TextBox txtNumWell;
        private System.Windows.Forms.TextBox txtNumGood;
        private System.Windows.Forms.TextBox txtNumExcellent;
        private System.Windows.Forms.DataGridView gradeDataGridView;
    }
}