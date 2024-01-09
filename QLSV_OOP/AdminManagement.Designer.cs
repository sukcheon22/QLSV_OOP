namespace QLSV_OOP
{
    partial class AdminManagement
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
            this.label5 = new System.Windows.Forms.Label();
            this.grbTTinAdmin = new System.Windows.Forms.GroupBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.infoAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.grbTTinAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoAdminDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "QUẢN LÝ ADMIN";
            // 
            // grbTTinAdmin
            // 
            this.grbTTinAdmin.Controls.Add(this.txtAdmin);
            this.grbTTinAdmin.Controls.Add(this.txtID);
            this.grbTTinAdmin.Controls.Add(this.label3);
            this.grbTTinAdmin.Controls.Add(this.label1);
            this.grbTTinAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTinAdmin.Location = new System.Drawing.Point(3, 67);
            this.grbTTinAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTTinAdmin.Name = "grbTTinAdmin";
            this.grbTTinAdmin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTTinAdmin.Size = new System.Drawing.Size(651, 95);
            this.grbTTinAdmin.TabIndex = 4;
            this.grbTTinAdmin.TabStop = false;
            this.grbTTinAdmin.Text = "Thông tin tài khoản";
            // 
            // txtAdmin
            // 
            this.txtAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.Location = new System.Drawing.Point(421, 38);
            this.txtAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(137, 22);
            this.txtAdmin.TabIndex = 7;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(311, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Admin";
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
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.MediumBlue;
            this.btnQuayLai.ForeColor = System.Drawing.Color.Lavender;
            this.btnQuayLai.Location = new System.Drawing.Point(11, 489);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(99, 46);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumBlue;
            this.btnXoa.ForeColor = System.Drawing.Color.Lavender;
            this.btnXoa.Location = new System.Drawing.Point(11, 290);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumBlue;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Lavender;
            this.btnTimKiem.Location = new System.Drawing.Point(11, 383);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 46);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSua.ForeColor = System.Drawing.Color.Lavender;
            this.btnSua.Location = new System.Drawing.Point(11, 197);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 46);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // infoAdminDataGridView
            // 
            this.infoAdminDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoAdminDataGridView.Location = new System.Drawing.Point(142, 179);
            this.infoAdminDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoAdminDataGridView.Name = "infoAdminDataGridView";
            this.infoAdminDataGridView.RowHeadersWidth = 51;
            this.infoAdminDataGridView.RowTemplate.Height = 24;
            this.infoAdminDataGridView.Size = new System.Drawing.Size(512, 395);
            this.infoAdminDataGridView.TabIndex = 5;
            // 
            // AdminManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoAdminDataGridView);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grbTTinAdmin);
            this.Controls.Add(this.label5);
            this.Name = "AdminManagement";
            this.Size = new System.Drawing.Size(670, 597);
            this.grbTTinAdmin.ResumeLayout(false);
            this.grbTTinAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoAdminDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbTTinAdmin;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView infoAdminDataGridView;
    }
}
