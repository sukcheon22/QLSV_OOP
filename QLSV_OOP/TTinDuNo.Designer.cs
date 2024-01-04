namespace QLSV_OOP
{
    partial class TTinDuNo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbTTinDuNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số tiền học phí chưa thanh toán";
            // 
            // txbTTinDuNo
            // 
            this.txbTTinDuNo.Location = new System.Drawing.Point(319, 39);
            this.txbTTinDuNo.Name = "txbTTinDuNo";
            this.txbTTinDuNo.Size = new System.Drawing.Size(221, 22);
            this.txbTTinDuNo.TabIndex = 15;
            this.txbTTinDuNo.TextChanged += new System.EventHandler(this.txbTTinDuNo_TextChanged);
            // 
            // TTinDuNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbTTinDuNo);
            this.Controls.Add(this.label2);
            this.Name = "TTinDuNo";
            this.Size = new System.Drawing.Size(661, 106);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTTinDuNo;
    }
}
