﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_OOP;
using QLSV_OOP.DAO;
using QLSV_OOP.DTO;

namespace QLSV_OOP
{
    public partial class frmTaiVu : Form
    {
        Account account;
        QuanLyHTTT quanLyHTTT = new QuanLyHTTT();
        CapNhatCongNo capNhatCongNo = new CapNhatCongNo();
        public frmTaiVu(Account acc)
        {
            InitializeComponent();
            ToolStripMenuItem daotao = RoleDAO.CreateDaoTao();
            ToolStripMenuItem hocbong = RoleDAO.CreateHB();
            ToolStripMenuItem taivu = RoleDAO.CreateTaiVu();
            ToolStripMenuItem thongke = RoleDAO.CreateThongKe();
            ToolStripMenuItem quanly = RoleDAO.CreateQuanLy();
            menuStrip1.Items.AddRange(new ToolStripItem[] { daotao, hocbong, taivu, quanly, thongke });
            string roleid = acc.RoleID;
            List<string> itemsSelected = CustomizeMenuStrip.Instance.RetrieveRole(roleid);
            CustomizeMenuStrip.Instance.Customize(menuStrip1, itemsSelected);
            menuStrip1.ForeColor = Color.Lavender;
            string userid = acc.UserID;
            Nhan_vien nhanVien = Nhan_vienDAO.Instance.GetNhanVienbyUserID(userid);
            CustomizeMenuStrip.Instance.CustomizeAccount(menuStrip2, nhanVien.StaffName);
            //CustomizeMenuStrip.Instance.SignOut.Click += new System.EventHandler(this.SignOut);
            CustomizeMenuStrip.Instance.SignOut.Click += SignOut;
            CustomizeMenuStrip.Instance.ChangePassword.Click += ChangePassword;
            CustomizeMenuStrip.Instance.HoTen.ForeColor = Color.Yellow;
            CustomizeMenuStrip.Instance.HoTen.Click += HoTen_Clicked;
            CustomizeMenuStrip.Instance.HoTen.MouseLeave += HoTen_MouseLeave;
            //capNhatHTTT.Click += CapNhatHTTT_Clicked;
            //capNhatCongNo.Click += CapNhatCongNo_Clicked;
            RoleDAO.CapNhatDiemClicked += CapNhatDiem_Clicked;
            RoleDAO.Instance.DKLop.Click += DkyLop_Clicked;
            RoleDAO.TCuuTKBClicked += TCuuTK_Clicked;
            RoleDAO.TCuuKQHTClicked += TCuuKQHT_Clicked;
            RoleDAO.QuanLyTTHBClicked += QuanLyTTHB_Clicked;
            RoleDAO.PheDuyetYCHBClicked += PheDuyetYCHB_Clicked;
            RoleDAO.Instance.DKHB.Click += DKHocBongB_Clicked;
            RoleDAO.QuanLyHTTTClicked += QuanLyHTTT_Clicked;
            RoleDAO.CapNhatCongNoClicked += CapNhatCongNo_Clicked;
            RoleDAO.TTinDuNoClicked += TTinDuNo_Clicked;
            RoleDAO.Instance.TKeNoHPhi.Click += NoDongHocPhi_Clicked;
            RoleDAO.Instance.TKeDiem.Click += TkeDiem_Clicked;
            RoleDAO.Instance.TKeHB.Click += TkeHocBong_Clicked;
            RoleDAO.Instance.TKeHocPhi.Click += HocPhi_Clicked;
            RoleDAO.Instance.TKeHTTT.Click += HTThanhToan_Clicked;
            RoleDAO.Instance.TKeLopHoc.Click += LopHoc_Clicked;
            panel1.Controls.Add(quanLyHTTT);
            panel1.Controls.Add(capNhatCongNo);
            quanLyHTTT.Location = new System.Drawing.Point(0, 0);
            capNhatCongNo.Location = new System.Drawing.Point(0, 0);
            foreach (Control control in panel1.Controls)
            {
                control.Visible = false;
            }
        }

        public void HoTen_Clicked(object sender, EventArgs e)
        {
            CustomizeMenuStrip.Instance.HoTen.ForeColor = Color.Navy;
        }

        public void HoTen_MouseLeave(object sender, EventArgs e)
        {
            CustomizeMenuStrip.Instance.HoTen.ForeColor = Color.Yellow;
        }

        private void TkeHocBong_Clicked(object sender, EventArgs e)
        {
            FunctionMenuStrip.Instance.ScholarshipAnalysis(this);
        }

        private void TTinDuNo_Clicked(object sender, EventArgs e)
        {

        }
        private void CapNhatDiem_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện CapNhatDiemClicked xảy ra
        }

        private void DkyLop_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện DkyLopClicked xảy ra
        }

        private void TCuuTK_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện TCuuTKBClicked xảy ra
        }

        private void TCuuKQHT_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện TCuuKQHTClicked xảy ra
        }

        private void QuanLyTTHB_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện CapNhatTTHBClicked xảy ra
        }

        private void PheDuyetYCHB_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện PheDuyetYCHBClicked xảy ra
        }

        private void DKHocBongB_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện DKHocBongBClicked xảy ra
        }

        private void QuanLyHTTT_Clicked(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                control.Visible = false;
            }
            quanLyHTTT.Visible = true;
        }

        private void CapNhatCongNo_Clicked(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                control.Visible = false;
            }
            capNhatCongNo.Visible = true;
        }

        private void KTraDuNo_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện KTraDuNoClicked xảy ra
        }

        private void HocPhi_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện HocPhiClicked xảy ra
            FunctionMenuStrip.Instance.TuitionAnalysis(this);
        }

        private void NoDongHocPhi_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện NoDongHocPhiClicked xảy ra
            FunctionMenuStrip.Instance.TuitionOweAnalysis(this);
        }
        private void TkeDiem_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện TkeDiemClicked xảy ra
            FunctionMenuStrip.Instance.GradeAnalysis(this);
        }



        private void LopHoc_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện LopHocClicked xảy ra
            FunctionMenuStrip.Instance.ClassAnalysis(this);
        }

        private void HTThanhToan_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện HTThanhToanClicked xảy ra
            FunctionMenuStrip.Instance.HTTTAnalysis(this);
        }

        
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmTaiVu_Load(object sender, EventArgs e)
        {

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
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmTaiVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
