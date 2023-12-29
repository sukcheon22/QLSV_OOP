namespace QLSV_OOP
{
    partial class frmStudentAnalysis
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
            this.xuấtFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumEduEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumHB = new System.Windows.Forms.TextBox();
            this.textNumSubFailed = new System.Windows.Forms.TextBox();
            this.textNumMoneyLeft = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtFileToolStripMenuItem,
            this.quayLạiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xuấtFileToolStripMenuItem
            // 
            this.xuấtFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuấtFileToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.xuấtFileToolStripMenuItem.Name = "xuấtFileToolStripMenuItem";
            this.xuấtFileToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.xuấtFileToolStripMenuItem.Text = "Xuất file";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayLạiToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.quayLạiToolStripMenuItem.Text = "Quay lại";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textNumMoneyLeft);
            this.panel1.Controls.Add(this.textNumSubFailed);
            this.panel1.Controls.Add(this.textNumHB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNumEduEmployee);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(165, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 182);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chưa hoàn thành học phí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Học bổng đã đạt:";
            // 
            // txtNumEduEmployee
            // 
            this.txtNumEduEmployee.Location = new System.Drawing.Point(237, 76);
            this.txtNumEduEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumEduEmployee.Name = "txtNumEduEmployee";
            this.txtNumEduEmployee.Size = new System.Drawing.Size(76, 26);
            this.txtNumEduEmployee.TabIndex = 8;
            this.txtNumEduEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chưa hoàn thành hết các học phần:";
            // 
            // accDataGridView
            // 
            this.accDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accDataGridView.Location = new System.Drawing.Point(60, 326);
            this.accDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accDataGridView.Name = "accDataGridView";
            this.accDataGridView.RowHeadersWidth = 62;
            this.accDataGridView.Size = new System.Drawing.Size(1182, 340);
            this.accDataGridView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "THỐNG KÊ SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNumHB
            // 
            this.textNumHB.Location = new System.Drawing.Point(237, 21);
            this.textNumHB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNumHB.Name = "textNumHB";
            this.textNumHB.Size = new System.Drawing.Size(76, 26);
            this.textNumHB.TabIndex = 10;
            this.textNumHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNumSubFailed
            // 
            this.textNumSubFailed.Location = new System.Drawing.Point(760, 21);
            this.textNumSubFailed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNumSubFailed.Name = "textNumSubFailed";
            this.textNumSubFailed.Size = new System.Drawing.Size(76, 26);
            this.textNumSubFailed.TabIndex = 11;
            this.textNumSubFailed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNumMoneyLeft
            // 
            this.textNumMoneyLeft.Location = new System.Drawing.Point(760, 76);
            this.textNumMoneyLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNumMoneyLeft.Name = "textNumMoneyLeft";
            this.textNumMoneyLeft.Size = new System.Drawing.Size(76, 26);
            this.textNumMoneyLeft.TabIndex = 12;
            this.textNumMoneyLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmStudentAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmStudentAnalysis";
            this.Text = "Thống kê sinh viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xuấtFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumEduEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView accDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumMoneyLeft;
        private System.Windows.Forms.TextBox textNumSubFailed;
        private System.Windows.Forms.TextBox textNumHB;
    }
}