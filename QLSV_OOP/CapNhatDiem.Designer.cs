namespace QLSV_OOP
{
    partial class CapNhatDiem
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.infoGradeDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDiem = new System.Windows.Forms.ComboBox();
            this.cmbMaHP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoGradeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(57, 356);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 49);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiemKQHT_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(57, 194);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 49);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSuaKQHT_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(57, 277);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 49);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoaKQHT_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(57, 430);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(112, 49);
            this.btnQuayLai.TabIndex = 17;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(57, 114);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 49);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThemKQHT_Click);
            // 
            // infoGradeDataGridView
            // 
            this.infoGradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoGradeDataGridView.Location = new System.Drawing.Point(243, 105);
            this.infoGradeDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoGradeDataGridView.Name = "infoGradeDataGridView";
            this.infoGradeDataGridView.RowHeadersWidth = 51;
            this.infoGradeDataGridView.RowTemplate.Height = 24;
            this.infoGradeDataGridView.Size = new System.Drawing.Size(789, 406);
            this.infoGradeDataGridView.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDiem);
            this.groupBox1.Controls.Add(this.cmbMaHP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(5, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1027, 86);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm";
            // 
            // cmbDiem
            // 
            this.cmbDiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiem.FormattingEnabled = true;
            this.cmbDiem.Items.AddRange(new object[] {
            "",
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbDiem.Location = new System.Drawing.Point(809, 30);
            this.cmbDiem.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiem.Name = "cmbDiem";
            this.cmbDiem.Size = new System.Drawing.Size(160, 24);
            this.cmbDiem.TabIndex = 12;
            // 
            // cmbMaHP
            // 
            this.cmbMaHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaHP.FormattingEnabled = true;
            this.cmbMaHP.Location = new System.Drawing.Point(144, 30);
            this.cmbMaHP.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaHP.Name = "cmbMaHP";
            this.cmbMaHP.Size = new System.Drawing.Size(160, 24);
            this.cmbMaHP.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Điểm";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(477, 30);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(137, 22);
            this.txtMaSV.TabIndex = 8;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã sinh viên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 18);
            this.label14.TabIndex = 1;
            this.label14.Text = "Mã học phần";
            // 
            // CapNhatDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.infoGradeDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CapNhatDiem";
            this.Size = new System.Drawing.Size(1039, 526);
            this.Load += new System.EventHandler(this.CapNhatDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoGradeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView infoGradeDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbMaHP;
        private System.Windows.Forms.ComboBox cmbDiem;
    }
}
