namespace QLSV_OOP
{
    partial class frmPhanQuyen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStripHB = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStripHB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý phân quyền";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 409);
            this.dataGridView1.TabIndex = 2;
            // 
            // menuStripHB
            // 
            this.menuStripHB.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStripHB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripHB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStripHB.Location = new System.Drawing.Point(0, 0);
            this.menuStripHB.Name = "menuStripHB";
            this.menuStripHB.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.menuStripHB.Size = new System.Drawing.Size(1052, 26);
            this.menuStripHB.TabIndex = 14;
            this.menuStripHB.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.backToolStripMenuItem.Text = "Quay lại";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "Mã quyền";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "QDT",
            "QTV",
            "QSV"});
            this.comboBox4.Location = new System.Drawing.Point(126, 115);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(138, 24);
            this.comboBox4.TabIndex = 16;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cập nhật điểm",
            "Đăng ký lớp",
            "Tra cứu TKB",
            "Tra cứu KQHT",
            "Cập nhật thông tin học bổng",
            "Phê duyệt yêu cầu học bổng",
            "Đăng ký học bổng",
            "Cập nhật HTTT",
            "Cập nhật công nợ",
            "Kiểm tra dư nợ",
            "Thống kê học phí",
            "Thống kê nợ đọng học phí",
            "Thống kê điểm",
            "Thống kê học bổng",
            "Thống kê lớp học",
            "Thống kê hình thức thanh toán"});
            this.checkedListBox1.Location = new System.Drawing.Point(15, 158);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(249, 308);
            this.checkedListBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 536);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.menuStripHB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStripHB.ResumeLayout(false);
            this.menuStripHB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStripHB;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}