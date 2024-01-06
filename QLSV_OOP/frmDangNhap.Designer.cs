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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn vai trò đăng nhập";
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSize = true;
            this.btnAdmin.Location = new System.Drawing.Point(43, 113);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(66, 20);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.TabStop = true;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.CheckedChanged += new System.EventHandler(this.btnAdmin_CheckedChanged);
            // 
            // btnDaoTao
            // 
            this.btnDaoTao.AutoSize = true;
            this.btnDaoTao.Location = new System.Drawing.Point(43, 139);
            this.btnDaoTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDaoTao.Name = "btnDaoTao";
            this.btnDaoTao.Size = new System.Drawing.Size(186, 20);
            this.btnDaoTao.TabIndex = 3;
            this.btnDaoTao.TabStop = true;
            this.btnDaoTao.Text = "Nhân viên Phòng Đào Tạo";
            this.btnDaoTao.UseVisualStyleBackColor = true;
            this.btnDaoTao.CheckedChanged += new System.EventHandler(this.btnDaoTao_CheckedChanged);
            // 
            // btnTaiVu
            // 
            this.btnTaiVu.AutoSize = true;
            this.btnTaiVu.Location = new System.Drawing.Point(43, 165);
            this.btnTaiVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiVu.Name = "btnTaiVu";
            this.btnTaiVu.Size = new System.Drawing.Size(175, 20);
            this.btnTaiVu.TabIndex = 4;
            this.btnTaiVu.TabStop = true;
            this.btnTaiVu.Text = "Nhân viên Phòng Tài Vụ ";
            this.btnTaiVu.UseVisualStyleBackColor = true;
            this.btnTaiVu.CheckedChanged += new System.EventHandler(this.btnTaiVu_CheckedChanged);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.AutoSize = true;
            this.btnSinhVien.Location = new System.Drawing.Point(43, 191);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(82, 20);
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
            this.label3.Location = new System.Drawing.Point(39, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên đăng nhập";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật khẩu ";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(201, 226);
            this.txbTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(159, 22);
            this.txbTenDangNhap.TabIndex = 8;
            this.txbTenDangNhap.TextChanged += new System.EventHandler(this.txbTenDangNhap_TextChanged);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(201, 267);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(159, 22);
            this.txbMatKhau.TabIndex = 9;
            this.txbMatKhau.UseSystemPasswordChar = true;
            this.txbMatKhau.TextChanged += new System.EventHandler(this.txbMatKhau_TextChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Navy;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Lavender;
            this.btnDangNhap.Location = new System.Drawing.Point(42, 330);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(104, 44);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Navy;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Lavender;
            this.btnThoat.Location = new System.Drawing.Point(256, 330);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 44);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.txbMatKhau);
            this.panel1.Controls.Add(this.txbTenDangNhap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSinhVien);
            this.panel1.Controls.Add(this.btnTaiVu);
            this.panel1.Controls.Add(this.btnDaoTao);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 514);
            this.panel1.TabIndex = 12;
            // 
            // frmDangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(824, 514);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}