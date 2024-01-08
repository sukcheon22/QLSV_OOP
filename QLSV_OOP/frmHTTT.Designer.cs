namespace QLSV_OOP
{
    partial class frmHTTTAnalysis
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
            this.htttDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htttDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportFileToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1104, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "THỐNG KÊ HÌNH THỨC THANH TOÁN";
            // 
            // htttDataGridView
            // 
            this.htttDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.htttDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.htttDataGridView.Location = new System.Drawing.Point(49, 109);
            this.htttDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.htttDataGridView.Name = "htttDataGridView";
            this.htttDataGridView.RowHeadersWidth = 51;
            this.htttDataGridView.Size = new System.Drawing.Size(1006, 408);
            this.htttDataGridView.TabIndex = 15;
            // 
            // frmHTTTAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 547);
            this.Controls.Add(this.htttDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "frmHTTTAnalysis";
            this.Text = "Thống kê hình thức thanh toán";
            this.Load += new System.EventHandler(this.frmHTTTAnalysis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htttDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView htttDataGridView;
    }
}