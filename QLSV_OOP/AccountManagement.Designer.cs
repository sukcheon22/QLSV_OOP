﻿namespace QLSV_OOP
{
    partial class AccountManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoAccDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grbTTinAcc = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoAccDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbTTinAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infoAccDataGridView);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grbTTinAcc);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 551);
            this.panel1.TabIndex = 0;
            // 
            // infoAccDataGridView
            // 
            this.infoAccDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infoAccDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.infoAccDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoAccDataGridView.Location = new System.Drawing.Point(15, 270);
            this.infoAccDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoAccDataGridView.Name = "infoAccDataGridView";
            this.infoAccDataGridView.RowHeadersWidth = 51;
            this.infoAccDataGridView.RowTemplate.Height = 24;
            this.infoAccDataGridView.Size = new System.Drawing.Size(629, 266);
            this.infoAccDataGridView.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(629, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.MediumBlue;
            this.btnReturn.ForeColor = System.Drawing.Color.Lavender;
            this.btnReturn.Location = new System.Drawing.Point(522, 23);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 45);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumBlue;
            this.btnThem.ForeColor = System.Drawing.Color.Lavender;
            this.btnThem.Location = new System.Drawing.Point(27, 23);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 46);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumBlue;
            this.btnXoa.ForeColor = System.Drawing.Color.Lavender;
            this.btnXoa.Location = new System.Drawing.Point(279, 22);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Lavender;
            this.btnTimKiem.Location = new System.Drawing.Point(398, 23);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(88, 45);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Lavender;
            this.btnSua.Location = new System.Drawing.Point(156, 23);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 45);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grbTTinAcc
            // 
            this.grbTTinAcc.Controls.Add(this.txtTen);
            this.grbTTinAcc.Controls.Add(this.txtID);
            this.grbTTinAcc.Controls.Add(this.txtPass);
            this.grbTTinAcc.Controls.Add(this.cmbRole);
            this.grbTTinAcc.Controls.Add(this.label4);
            this.grbTTinAcc.Controls.Add(this.label3);
            this.grbTTinAcc.Controls.Add(this.label2);
            this.grbTTinAcc.Controls.Add(this.label1);
            this.grbTTinAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTinAcc.Location = new System.Drawing.Point(15, 18);
            this.grbTTinAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTTinAcc.Name = "grbTTinAcc";
            this.grbTTinAcc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTTinAcc.Size = new System.Drawing.Size(629, 128);
            this.grbTTinAcc.TabIndex = 0;
            this.grbTTinAcc.TabStop = false;
            this.grbTTinAcc.Text = "Thông tin tài khoản";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(133, 84);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(137, 22);
            this.txtTen.TabIndex = 7;
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
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(421, 84);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(137, 22);
            this.txtPass.TabIndex = 5;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "",
            "QAD",
            "QDT",
            "QTV",
            "QSV"});
            this.cmbRole.Location = new System.Drawing.Point(421, 37);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(137, 24);
            this.cmbRole.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(311, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(311, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã định danh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountManagement";
            this.Size = new System.Drawing.Size(692, 597);
            this.Load += new System.EventHandler(this.AccountManagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoAccDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grbTTinAcc.ResumeLayout(false);
            this.grbTTinAcc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbTTinAcc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtID;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView infoAccDataGridView;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label5;
    }
}
