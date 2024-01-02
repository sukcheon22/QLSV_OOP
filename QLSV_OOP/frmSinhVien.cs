using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_OOP;
using QLSV_OOP.DTO;
using QLSV_OOP.DAO;

namespace QLSV_OOP
{
    public partial class frmSinhVien : Form
    {
        //private Account loginAccount;

        Account account;
        TTinDuNo ttinDuNo;
        public frmSinhVien(Account acc)
        {
            InitializeComponent();
            
            account = acc;  
            ToolStripMenuItem daotao = RoleDAO.CreateDaoTao();
            ToolStripMenuItem hocbong = RoleDAO.CreateHB();
            ToolStripMenuItem taivu = RoleDAO.CreateTaiVu();
            ToolStripMenuItem thongke = RoleDAO.CreateThongKe();
            menuStrip1.Items.AddRange(new ToolStripItem[] {daotao, hocbong, taivu, thongke});
            string roleid = acc.RoleID;
            List<string> itemsSelected = CustomizeMenuStrip.Instance.RetrieveRole(roleid);
            //List<string> itemsSelected = new List<string>{ "Đào Tạo","Đăng ký lớp", "Đào Tạo", "Cập nhật điểm"};
            CustomizeMenuStrip.Instance.Customize(menuStrip1, itemsSelected);
            string userid = acc.UserID;
            Sinh_Vien sinhVien = Sinh_VienDAO.Instance.GetSinhVienbyUserID(userid);
            CustomizeMenuStrip.Instance.CustomizeAccount(menuStrip2, sinhVien.FullName);
            //CustomizeMenuStrip.Instance.SignOut.Click += new System.EventHandler(this.SignOut);
            CustomizeMenuStrip.Instance.SignOut.Click += SignOut;
            CustomizeMenuStrip.Instance.ChangePassword.Click += ChangePassword;
            RoleDAO.TkeHocBongClicked += TkeHocBong_Clicked;
            ttinDuNo = new TTinDuNo(sinhVien.StudentID);
            this.panel1.Controls.Add(ttinDuNo);
            ttinDuNo.Location = new System.Drawing.Point(0, 0);
            foreach (Control control in panel1.Controls)
            {
                control.Visible = false;
            }    
            RoleDAO.TTinDuNoClicked += TTinDuNo_Clicked;
        }

        
        public void TTinDuNo_Clicked(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                control.Visible = false;
            }
            ttinDuNo.Visible = true;
        }
        private void TkeHocBong_Clicked(object sender, EventArgs e)
        {
            FunctionMenuStrip.Instance.ScholarshipAnalysis(this);
        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void SignOut(object sender, EventArgs e)
        {
           //this.Close();
           FunctionMenuStrip.Instance.SignOut(this);
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            FunctionMenuStrip.Instance.ChangePassword(this, account);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
