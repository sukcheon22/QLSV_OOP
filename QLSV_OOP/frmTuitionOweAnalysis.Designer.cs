namespace QLSV_OOP
{
    partial class frmTuitionOweAnalysis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumCountK65 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripOweTuition = new System.Windows.Forms.MenuStrip();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.menuStripOweTuition.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNumCountK65);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(157, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 145);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // txtNumCountK65
            // 
            this.txtNumCountK65.Location = new System.Drawing.Point(468, 20);
            this.txtNumCountK65.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumCountK65.Name = "txtNumCountK65";
            this.txtNumCountK65.Size = new System.Drawing.Size(68, 22);
            this.txtNumCountK65.TabIndex = 10;
            this.txtNumCountK65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số sinh viên chưa hoàn thành học phí:";
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
            this.studentDataGridView.Location = new System.Drawing.Point(64, 256);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersWidth = 62;
            this.studentDataGridView.Size = new System.Drawing.Size(867, 282);
            this.studentDataGridView.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "THỐNG KÊ NỢ HỌC PHÍ";
            // 
            // menuStripOweTuition
            // 
            this.menuStripOweTuition.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStripOweTuition.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripOweTuition.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportFileToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStripOweTuition.Location = new System.Drawing.Point(0, 0);
            this.menuStripOweTuition.Name = "menuStripOweTuition";
            this.menuStripOweTuition.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStripOweTuition.Size = new System.Drawing.Size(1004, 28);
            this.menuStripOweTuition.TabIndex = 19;
            this.menuStripOweTuition.Text = "menuStrip1";
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.exportFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.exportFileToolStripMenuItem.Text = "Xuất file";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.backToolStripMenuItem.Text = "Quay lại";
            // 
            // frmTuitionOweAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 578);
            this.Controls.Add(this.menuStripOweTuition);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTuitionOweAnalysis";
            this.Text = "Thống kê nợ học phí";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.menuStripOweTuition.ResumeLayout(false);
            this.menuStripOweTuition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumCountK65;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStripOweTuition;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}