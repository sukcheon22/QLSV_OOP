namespace QLSV_OOP
{
    partial class CNTThocbong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxScholarshipType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScholarshipName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScholarshipID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.scholarshipDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scholarshipDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxScholarshipType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtScholarshipName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtScholarshipID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(19, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1155, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học bổng";
            // 
            // boxScholarshipType
            // 
            this.boxScholarshipType.FormattingEnabled = true;
            this.boxScholarshipType.Items.AddRange(new object[] {
            "Doanh nghiep",
            "Trao doi"});
            this.boxScholarshipType.Location = new System.Drawing.Point(929, 34);
            this.boxScholarshipType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxScholarshipType.Name = "boxScholarshipType";
            this.boxScholarshipType.Size = new System.Drawing.Size(167, 28);
            this.boxScholarshipType.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(780, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Loại học bổng";
            // 
            // txtScholarshipName
            // 
            this.txtScholarshipName.Location = new System.Drawing.Point(538, 36);
            this.txtScholarshipName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScholarshipName.Name = "txtScholarshipName";
            this.txtScholarshipName.Size = new System.Drawing.Size(155, 26);
            this.txtScholarshipName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên học bổng";
            // 
            // txtScholarshipID
            // 
            this.txtScholarshipID.Location = new System.Drawing.Point(147, 38);
            this.txtScholarshipID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScholarshipID.Name = "txtScholarshipID";
            this.txtScholarshipID.Size = new System.Drawing.Size(155, 26);
            this.txtScholarshipID.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "Mã học bổng";
            // 
            // scholarshipDataGridView
            // 
            this.scholarshipDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scholarshipDataGridView.Location = new System.Drawing.Point(286, 139);
            this.scholarshipDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scholarshipDataGridView.Name = "scholarshipDataGridView";
            this.scholarshipDataGridView.RowHeadersWidth = 51;
            this.scholarshipDataGridView.RowTemplate.Height = 24;
            this.scholarshipDataGridView.Size = new System.Drawing.Size(889, 508);
            this.scholarshipDataGridView.TabIndex = 1;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(76, 151);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(126, 61);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.Location = new System.Drawing.Point(76, 544);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(126, 61);
            this.buttonQuayLai.TabIndex = 3;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(76, 354);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(126, 61);
            this.buttonXoa.TabIndex = 4;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(76, 251);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(126, 61);
            this.buttonSua.TabIndex = 5;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(76, 452);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(126, 61);
            this.buttonTimKiem.TabIndex = 6;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // CNTThocbong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.scholarshipDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CNTThocbong";
            this.Size = new System.Drawing.Size(1194, 669);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scholarshipDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox boxScholarshipType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScholarshipName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScholarshipID;
        private System.Windows.Forms.DataGridView scholarshipDataGridView;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonTimKiem;
    }
}
