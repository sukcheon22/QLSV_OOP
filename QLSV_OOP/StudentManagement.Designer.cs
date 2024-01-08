namespace QLSV_OOP
{
    partial class StudentManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoStuDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.quaylai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbQue = new System.Windows.Forms.ComboBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDStu = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoStuDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infoStuDataGridView);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 526);
            this.panel1.TabIndex = 1;
            // 
            // infoStuDataGridView
            // 
            this.infoStuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoStuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoStuDataGridView.Location = new System.Drawing.Point(15, 241);
            this.infoStuDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoStuDataGridView.Name = "infoStuDataGridView";
            this.infoStuDataGridView.RowHeadersWidth = 51;
            this.infoStuDataGridView.RowTemplate.Height = 24;
            this.infoStuDataGridView.Size = new System.Drawing.Size(1021, 266);
            this.infoStuDataGridView.TabIndex = 4;
            this.infoStuDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infoStuDataGridView_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.quaylai);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 151);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1021, 75);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // quaylai
            // 
            this.quaylai.BackColor = System.Drawing.Color.MediumBlue;
            this.quaylai.ForeColor = System.Drawing.Color.Lavender;
            this.quaylai.Location = new System.Drawing.Point(796, 19);
            this.quaylai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(99, 46);
            this.quaylai.TabIndex = 4;
            this.quaylai.Text = "Quay lại";
            this.quaylai.UseVisualStyleBackColor = false;
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumBlue;
            this.btnXoa.ForeColor = System.Drawing.Color.Lavender;
            this.btnXoa.Location = new System.Drawing.Point(559, 19);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumBlue;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Lavender;
            this.btnTimKiem.Location = new System.Drawing.Point(123, 19);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 46);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSua.ForeColor = System.Drawing.Color.Lavender;
            this.btnSua.Location = new System.Drawing.Point(330, 19);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 46);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbQue);
            this.groupBox2.Controls.Add(this.birthDateTimePicker);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtIDStu);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.cmbKhoa);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1021, 142);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sinh viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(877, 37);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(137, 22);
            this.txtSDT.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(779, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số điện thoại";
            // 
            // cmbQue
            // 
            this.cmbQue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQue.FormattingEnabled = true;
            this.cmbQue.Items.AddRange(new object[] {
            "",
            "An Giang",
            "Ba Ria-Vung Tau",
            "Bac Giang",
            "Bac Kan",
            "Bac Lieu",
            "Bac Ninh",
            "Ben Tre",
            "Binh Dinh",
            "Binh Duong",
            "Binh Phuoc",
            "Binh Thuan",
            "Ca Mau",
            "Can Tho",
            "Cao Bang",
            "Da Nang",
            "Dak Lak",
            "Dak Nong",
            "Dien Bien",
            "Dong Nai",
            "Dong Thap",
            "Gia Lai",
            "Ha Giang",
            "Ha Nam",
            "Ha Tinh",
            "Hai Duong",
            "Hai Phong ",
            "Hanoi ",
            "Hau Giang",
            "Hoa Binh",
            "Hung Yen",
            "Khanh Hoa",
            "Kien Giang",
            "Kon Tum",
            "Lai Chau",
            "Lam Dong",
            "Lang Son",
            "Lao Cai",
            "Long An",
            "Nam Dinh",
            "Nghe An",
            "Ninh Binh",
            "Ninh Thuan",
            "Phu Tho",
            "Phu Yen",
            "Quang Binh",
            "Quang Nam",
            "Quang Ngai",
            "Quang Ninh",
            "Quang Tri",
            "Soc Trang",
            "Son La",
            "Tay Ninh",
            "Thai Binh",
            "Thai Nguyen",
            "Thanh Hoa",
            "Thua Thien-Hue",
            "Tien Giang",
            "TP Ho Chi Minh",
            "Tra Vinh",
            "Tuyen Quang",
            "Vinh Long",
            "Vinh Phuc",
            "Yen Bai"});
            this.cmbQue.Location = new System.Drawing.Point(611, 84);
            this.cmbQue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbQue.Name = "cmbQue";
            this.cmbQue.Size = new System.Drawing.Size(137, 24);
            this.cmbQue.TabIndex = 11;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.CustomFormat = "yyyy-mm-dd";
            this.birthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateTimePicker.Location = new System.Drawing.Point(611, 37);
            this.birthDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(137, 22);
            this.birthDateTimePicker.TabIndex = 10;
            this.birthDateTimePicker.Value = new System.DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(531, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Quê quán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(531, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ngày sinh";
            // 
            // txtIDStu
            // 
            this.txtIDStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDStu.Location = new System.Drawing.Point(133, 84);
            this.txtIDStu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDStu.Name = "txtIDStu";
            this.txtIDStu.Size = new System.Drawing.Size(137, 22);
            this.txtIDStu.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(133, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(137, 22);
            this.txtID.TabIndex = 6;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(369, 37);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(137, 22);
            this.txtTen.TabIndex = 5;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Items.AddRange(new object[] {
            "",
            "64",
            "65",
            "66",
            "67",
            "68"});
            this.cmbKhoa.Location = new System.Drawing.Point(369, 84);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(137, 24);
            this.cmbKhoa.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(311, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Khóa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(311, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Họ tên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(5, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Mã số sinh viên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(5, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã định danh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentManagement";
            this.Size = new System.Drawing.Size(1061, 578);
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoStuDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbQue;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDStu;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView infoStuDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.Label label5;
    }
}
