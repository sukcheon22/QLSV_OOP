namespace QLSV_OOP
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
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStripTuition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTuition
            // 
            this.menuStripTuition.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStripTuition.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripTuition.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTuition.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportFileToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStripTuition.Location = new System.Drawing.Point(0, 0);
            this.menuStripTuition.Name = "menuStripTuition";
            this.menuStripTuition.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripTuition.Size = new System.Drawing.Size(1242, 33);
            this.menuStripTuition.TabIndex = 1;
            this.menuStripTuition.Text = "menuStrip1";
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.exportFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.exportFileToolStripMenuItem.Text = "Xuất file";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.backToolStripMenuItem.Text = "Quay lại";
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Location = new System.Drawing.Point(46, 252);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersWidth = 62;
            this.studentDataGridView.Size = new System.Drawing.Size(1161, 415);
            this.studentDataGridView.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 50);
            this.label1.TabIndex = 13;
            this.label1.Text = "THỐNG KÊ HỌC PHÍ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tổng số tiền đã nộp về";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 168);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 26);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngân hàng sinh viên có số tài khoản nhiều nhất";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1023, 168);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 26);
            this.textBox2.TabIndex = 18;
            // 
            // frmTuitionAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 684);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripTuition);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTuitionAnalysis";
            this.Text = "Thống kê học phí";
            this.menuStripTuition.ResumeLayout(false);
            this.menuStripTuition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTuition;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}