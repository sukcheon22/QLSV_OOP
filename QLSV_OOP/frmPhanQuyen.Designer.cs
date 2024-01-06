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
            this.infoQuyenDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStripHB = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label14 = new System.Windows.Forms.Label();
            this.checkedListBoxQuyen = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMaQuyen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoQuyenDataGridView)).BeginInit();
            this.menuStripHB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý phân quyền";
            // 
            // infoQuyenDataGridView
            // 
            this.infoQuyenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoQuyenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoQuyenDataGridView.Location = new System.Drawing.Point(307, 114);
            this.infoQuyenDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoQuyenDataGridView.Name = "infoQuyenDataGridView";
            this.infoQuyenDataGridView.RowHeadersWidth = 51;
            this.infoQuyenDataGridView.RowTemplate.Height = 24;
            this.infoQuyenDataGridView.Size = new System.Drawing.Size(721, 409);
            this.infoQuyenDataGridView.TabIndex = 2;
            // 
            // menuStripHB
            // 
            this.menuStripHB.BackColor = System.Drawing.Color.Navy;
            this.menuStripHB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripHB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStripHB.Location = new System.Drawing.Point(0, 0);
            this.menuStripHB.Name = "menuStripHB";
            this.menuStripHB.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.menuStripHB.Size = new System.Drawing.Size(1052, 30);
            this.menuStripHB.TabIndex = 14;
            this.menuStripHB.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.Lavender;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.backToolStripMenuItem.Text = "Quay lại";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(12, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "Mã quyền";
            // 
            // checkedListBoxQuyen
            // 
            this.checkedListBoxQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxQuyen.FormattingEnabled = true;
            this.checkedListBoxQuyen.Items.AddRange(new object[] {
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
            this.checkedListBoxQuyen.Location = new System.Drawing.Point(15, 158);
            this.checkedListBoxQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxQuyen.Name = "checkedListBoxQuyen";
            this.checkedListBoxQuyen.Size = new System.Drawing.Size(249, 270);
            this.checkedListBoxQuyen.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(15, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Navy;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Lavender;
            this.btnHuy.Location = new System.Drawing.Point(176, 475);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 48);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.Enabled = false;
            this.txtMaQuyen.Location = new System.Drawing.Point(131, 114);
            this.txtMaQuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Size = new System.Drawing.Size(132, 22);
            this.txtMaQuyen.TabIndex = 21;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 537);
            this.Controls.Add(this.txtMaQuyen);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBoxQuyen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.menuStripHB);
            this.Controls.Add(this.infoQuyenDataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmPhanQuyen";
            this.Text = "Phân quyền";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoQuyenDataGridView)).EndInit();
            this.menuStripHB.ResumeLayout(false);
            this.menuStripHB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView infoQuyenDataGridView;
        private System.Windows.Forms.MenuStrip menuStripHB;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox checkedListBoxQuyen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMaQuyen;
    }
}