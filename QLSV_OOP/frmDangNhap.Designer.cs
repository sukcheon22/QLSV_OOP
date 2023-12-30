namespace QLSV_OOP
{
    partial class frmDangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.RadioButton();
            this.btnDaoTao = new System.Windows.Forms.RadioButton();
            this.btnTaiVu = new System.Windows.Forms.RadioButton();
            this.btnSinhVien = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn vai trò đăng nhập";
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSize = true;
            this.btnAdmin.Location = new System.Drawing.Point(48, 144);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(79, 24);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.TabStop = true;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.CheckedChanged += new System.EventHandler(this.btnAdmin_CheckedChanged);
            // 
            // btnDaoTao
            // 
            this.btnDaoTao.AutoSize = true;
            this.btnDaoTao.Location = new System.Drawing.Point(48, 176);
            this.btnDaoTao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDaoTao.Name = "btnDaoTao";
            this.btnDaoTao.Size = new System.Drawing.Size(219, 24);
            this.btnDaoTao.TabIndex = 3;
            this.btnDaoTao.TabStop = true;
            this.btnDaoTao.Text = "Nhân viên Phòng Đào Tạo";
            this.btnDaoTao.UseVisualStyleBackColor = true;
            this.btnDaoTao.CheckedChanged += new System.EventHandler(this.btnDaoTao_CheckedChanged);
            // 
            // btnTaiVu
            // 
            this.btnTaiVu.AutoSize = true;
            this.btnTaiVu.Location = new System.Drawing.Point(48, 209);
            this.btnTaiVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaiVu.Name = "btnTaiVu";
            this.btnTaiVu.Size = new System.Drawing.Size(207, 24);
            this.btnTaiVu.TabIndex = 4;
            this.btnTaiVu.TabStop = true;
            this.btnTaiVu.Text = "Nhân viên Phòng Tài Vụ ";
            this.btnTaiVu.UseVisualStyleBackColor = true;
            this.btnTaiVu.CheckedChanged += new System.EventHandler(this.btnTaiVu_CheckedChanged);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.AutoSize = true;
            this.btnSinhVien.Location = new System.Drawing.Point(48, 241);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(98, 24);
            this.btnSinhVien.TabIndex = 5;
            this.btnSinhVien.TabStop = true;
            this.btnSinhVien.Text = "Sinh viên";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.CheckedChanged += new System.EventHandler(this.btnSinhVien_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên đăng nhập";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật khẩu ";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(215, 300);
            this.txbTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(229, 26);
            this.txbTenDangNhap.TabIndex = 8;
            this.txbTenDangNhap.TextChanged += new System.EventHandler(this.txbTenDangNhap_TextChanged);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(216, 352);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(229, 26);
            this.txbMatKhau.TabIndex = 9;
            this.txbMatKhau.TextChanged += new System.EventHandler(this.txbMatKhau_TextChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(161, 430);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(117, 36);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(370, 430);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 36);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 644);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.btnTaiVu);
            this.Controls.Add(this.btnDaoTao);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btnAdmin;
        private System.Windows.Forms.RadioButton btnDaoTao;
        private System.Windows.Forms.RadioButton btnTaiVu;
        private System.Windows.Forms.RadioButton btnSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}