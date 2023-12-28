using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_OOP.DAO;
using QLSV_OOP.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLSV_OOP
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txbTenDangNhap.Text;
            string password = txbMatKhau.Text;
            string check = "";
            check = RoleCheck(check);
            if (Login(username,password, check))
             {
                //Account loginAccount = AccountDAO.Instance.GetAccountByUserName(username);

                this.Hide();  
                if (check == "QAD")
                {
                    Account loginAccount = AccountDAO.Instance.GetAccountByUserName(username);
                    frmAdmin f = new frmAdmin(loginAccount);
                    f.ShowDialog();  
                }  
                else if (check == "QSV")
                {
                    Account loginAccount1 = AccountDAO.Instance.GetAccountByUserName(username);
                    frmSinhVien f = new frmSinhVien(loginAccount1);
                    f.ShowDialog();
                }
                else if (check == "QDT")
                {
                    Account loginAccount2 = AccountDAO.Instance.GetAccountByUserName(username);
                    frmDaoTao f = new frmDaoTao(loginAccount2);
                    f.ShowDialog();
                }    
                else
                {
                    Account loginAccount3 = AccountDAO.Instance.GetAccountByUserName(username);
                    frmTaiVu f = new frmTaiVu(loginAccount3);
                    f.ShowDialog();
                }    
                this.Show();
               
            }    
             else 
             {
                 MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
             } 
            
        }
        bool Login(string username, string password, string roleid)
        {
            return AccountDAO.Instance.Login(username, password, roleid);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txbTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDaoTao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTaiVu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSinhVien_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        public string RoleCheck(string check)
        {
            if (btnAdmin.Checked)
            {
                check = "QAD";
                
            }
            else if (btnDaoTao.Checked)
            {
                check = "QDT";
            }
            else if (btnTaiVu.Checked)
            {
                check = "QTV"; 
            }
            else if (btnSinhVien.Checked)
            {
                check = "QSV";
            }
            return check;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
