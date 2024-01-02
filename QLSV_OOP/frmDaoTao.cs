using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_OOP.DTO;
using QLSV_OOP;
using QLSV_OOP.DAO;
using System.Security.Principal;

namespace QLSV_OOP
{
    public partial class frmDaoTao : Form
    {
        Account account;
        public frmDaoTao(Account acc)
        {
            InitializeComponent();
            ToolStripMenuItem daotao = RoleDAO.CreateDaoTao();
            ToolStripMenuItem hocbong = RoleDAO.CreateHB();
            ToolStripMenuItem taivu = RoleDAO.CreateTaiVu();
            ToolStripMenuItem thongke = RoleDAO.CreateThongKe();
            menuStrip1.Items.AddRange(new ToolStripItem[] { daotao, hocbong, taivu, thongke });
            string roleid = acc.RoleID;
            List<string> itemsSelected = CustomizeMenuStrip.Instance.RetrieveRole(roleid);
            CustomizeMenuStrip.Instance.Customize(menuStrip1, itemsSelected);
            ToolStripMenuItem qly = new ToolStripMenuItem("Quản lý");
            ToolStripMenuItem qlyLop = new ToolStripMenuItem("Quản lý lớp");
            ToolStripMenuItem qlyHP = new ToolStripMenuItem("Quản lý học phần");
            qly.DropDownItems.AddRange(new ToolStripItem[] { qlyLop, qlyHP });
            menuStrip1.Items.Add(qly);
            string userid = acc.UserID;
            Nhan_vien nhanVien = Nhan_vienDAO.Instance.GetNhanVienbyUserID(userid);
            CustomizeMenuStrip.Instance.CustomizeAccount(menuStrip2, nhanVien.StaffName);
            //CustomizeMenuStrip.Instance.SignOut.Click += new System.EventHandler(this.SignOut);
            CustomizeMenuStrip.Instance.SignOut.Click += SignOut;
            CustomizeMenuStrip.Instance.ChangePassword.Click += ChangePassword;

            RoleDAO.CapNhatDiemClicked += CapNhatDiem_Clicked;
            RoleDAO.DkyLopClicked += DkyLop_Clicked;
            RoleDAO.TCuuTKBClicked += TCuuTK_Clicked;
            RoleDAO.TCuuKQHTClicked += TCuuKQHT_Clicked;
            RoleDAO.CapNhatTTHBClicked += CapNhatTTHB_Clicked;
            RoleDAO.PheDuyetYCHBClicked += PheDuyetYCHB_Clicked;
            RoleDAO.DKHocBongClicked += DKHocBongB_Clicked;
            RoleDAO.CapNhatHTTTClicked += CapNhatHTTT_Clicked;
            RoleDAO.CapNhatCongNoClicked += CapNhatCongNo_Clicked;
            RoleDAO.KTraDuNoClicked += KTraDuNo_Clicked;
            RoleDAO.HocPhiClicked += HocPhi_Clicked;
            RoleDAO.NoDongHocPhiClicked += NoDongHocPhi_Clicked;
            RoleDAO.TkeDiemClicked += TkeDiem_Clicked;
            RoleDAO.HocBongClicked += HocBong_Clicked;
            RoleDAO.LopHocClicked += LopHoc_Clicked;
            RoleDAO.HTThanhToanClicked += HTThanhToan_Clicked;

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

        private void CapNhatTTHB_Clicked(object sender, EventArgs e)
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

        private void CapNhatHTTT_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện CapNhatHTTTClicked xảy ra
        }

        private void CapNhatCongNo_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện CapNhatCongNoClicked xảy ra
        }

        private void KTraDuNo_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện KTraDuNoClicked xảy ra
        }

        private void HocPhi_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện HocPhiClicked xảy ra
        }

       
        private void NoDongHocPhi_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện NoDongHocPhiClicked xảy ra
        }
        private void TkeDiem_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện TkeDiemClicked xảy ra
        }

        private void HocBong_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện HocBongClicked xảy ra
        }

        private void LopHoc_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện LopHocClicked xảy ra
        }

        private void HTThanhToan_Clicked(object sender, EventArgs e)
        {
            // Xử lý logic khi sự kiện HTThanhToanClicked xảy ra
        }

        private void frmDaoTao_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        private void frmDaoTao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
