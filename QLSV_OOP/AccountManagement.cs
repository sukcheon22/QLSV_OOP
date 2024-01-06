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

namespace QLSV_OOP
{
    public partial class AccountManagement : UserControl
    {
        public AccountManagement()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtID.Text = ""; 
            txtTen.Text = "";
            cmbRole.Text = "";
            txtPass.Text = "";
            InitializeDataGridView();                         
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mới từ TextBoxes
            string userid = txtID.Text;
            string username = txtTen.Text;
            string password = txtPass.Text;
            string roleid = cmbRole.Text;
            infoAccDataGridView.DataSource = AccountDAO.Instance.SearchTaiKhoan(userid, username, password, roleid); 
        }
        
        private void InitializeDataGridView()
        {
            infoAccDataGridView.DataSource = AccountDAO.Instance.accGridView();
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoAccDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoAccDataGridView.SelectedRows.Count == 1)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = infoAccDataGridView.SelectedRows[0];
                string madd = selectedRow.Cells["MaDD"].Value.ToString();
                string username = selectedRow.Cells["Username"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                string maquyen = selectedRow.Cells["MaQuyen"].Value.ToString() ;

                // Hiển thị thông tin trong GroupBox
                DisplayStudentInfo(madd, username, password, maquyen);
            }
        }

        private void DisplayStudentInfo(string madd, string username, string password, string maquyen)
        {
            // Hiển thị thông tin sinh viên trong GroupBox
            txtID.Text = madd;
            txtTen.Text = username;
            txtPass.Text = password;
            cmbRole.Text = maquyen;
            // ...Thêm các thuộc tính khác tương ứng
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mới từ TextBoxes
            string userid = txtID.Text;
            string newusername = txtTen.Text;
            string newpassword = txtPass.Text;
            string roleid = cmbRole.Text;
            // Gọi hàm cập nhật thông tin sinh viên
            AccountDAO.Instance.UpdateInfoAccInfo(userid, newusername, newpassword, roleid);

            // Cập nhật lại DataGridView sau khi cập nhật CSDL
            InitializeDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (infoAccDataGridView.SelectedRows.Count == 1)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoAccDataGridView.SelectedRows[0];
                string maddToDelete = selectedRow.Cells["Madd"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                AccountDAO.Instance.DeleteTaiKhoan(maddToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ form
            string newUserId = txtID.Text;
            string newUsername = txtTen.Text;
            string newPassword = txtPass.Text;
            string newRole = cmbRole.Text;
            

            // Gọi hàm để thêm tài khoản mới
            AccountDAO.Instance.ThemTaiKhoanMoi(newUserId, newUsername, newPassword, newRole);

            // Làm mới DataGridView
            InitializeDataGridView();  
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ResetState();
        }
    }
}
