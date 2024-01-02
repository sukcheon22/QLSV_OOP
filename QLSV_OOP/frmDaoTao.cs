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
            
            RoleDAO.TkeDiemClicked += TkeDiem_Clicked;
            RoleDAO.TkeHocBongClicked += TkeHocBong_Clicked;
        }
        
        private void TkeHocBong_Clicked(object sender, EventArgs e)
        {
            FunctionMenuStrip.Instance.ScholarshipAnalysis(this);
        }
        private void TkeDiem_Clicked(object sender, EventArgs e)
        {
        //    đưa từ functionmenustrip vào
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
