﻿namespace QLSV_OOP
{
    partial class frmTuitionAnalysis
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
            this.menuStripTuition = new System.Windows.Forms.MenuStrip();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuitionDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMostBank = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStripTuition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTuition
            // 
            this.menuStripTuition.BackColor = System.Drawing.Color.Navy;
            this.menuStripTuition.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTuition.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportFileToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStripTuition.Location = new System.Drawing.Point(0, 0);
            this.menuStripTuition.Name = "menuStripTuition";
            this.menuStripTuition.Size = new System.Drawing.Size(1104, 28);
            this.menuStripTuition.TabIndex = 1;
            this.menuStripTuition.Text = "menuStrip1";
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
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
            // tuitionDataGridView
            // 
            this.tuitionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tuitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tuitionDataGridView.Location = new System.Drawing.Point(41, 202);
            this.tuitionDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.tuitionDataGridView.Name = "tuitionDataGridView";
            this.tuitionDataGridView.RowHeadersWidth = 62;
            this.tuitionDataGridView.Size = new System.Drawing.Size(1032, 332);
            this.tuitionDataGridView.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "THỐNG KÊ HỌC PHÍ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tổng số tiền đã nộp về";
            // 
            // txtSumMoney
            // 
            this.txtSumMoney.Enabled = false;
            this.txtSumMoney.Location = new System.Drawing.Point(253, 134);
            this.txtSumMoney.Name = "txtSumMoney";
            this.txtSumMoney.Size = new System.Drawing.Size(175, 22);
            this.txtSumMoney.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(478, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngân hàng sinh viên có số tài khoản nhiều nhất";
            // 
            // txtMostBank
            // 
            this.txtMostBank.Enabled = false;
            this.txtMostBank.Location = new System.Drawing.Point(909, 134);
            this.txtMostBank.Name = "txtMostBank";
            this.txtMostBank.Size = new System.Drawing.Size(150, 22);
            this.txtMostBank.TabIndex = 18;
            // 
            // frmTuitionAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 547);
            this.Controls.Add(this.txtMostBank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSumMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tuitionDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripTuition);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTuitionAnalysis";
            this.Text = "Thống kê học phí";
            this.Load += new System.EventHandler(this.frmTuitionAnalysis_Load);
            this.menuStripTuition.ResumeLayout(false);
            this.menuStripTuition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTuition;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView tuitionDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMostBank;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}