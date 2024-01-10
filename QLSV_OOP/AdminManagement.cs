using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_OOP.DAO;
using QLSV_OOP.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QLSV_OOP
{
    public partial class AdminManagement : UserControl
    {
        public AdminManagement()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtID.Text = "";
            txtAdmin.Text = "";
            InitializeDataGridView();


        }
        private void InitializeDataGridView()
        {
            infoAdminDataGridView.DataSource = AdminDAO.Instance.adGridView();
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoAdminDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = infoAdminDataGridView.SelectedRows[0];
                string maAdmin = selectedRow.Cells["MaAdmin"].Value.ToString();
                string maDD = selectedRow.Cells["MaDD"].Value.ToString();
                
                DisplayStudentInfo(maAdmin, maDD);
            }
        }

        private void DisplayStudentInfo(string maAdmin, string maDD)
        {   
            txtID.Text = maDD;
            txtAdmin.Text = maAdmin;
        }
        private void AdminManagement_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoAdminDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maDD = txtID.Text;
            string maAdmin = txtAdmin.Text;

            infoAdminDataGridView.DataSource = AdminDAO.Instance.SearchAdmin(maAdmin, maDD);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maDD = txtID.Text;
            string maAdmin = txtAdmin.Text;
            AdminDAO.Instance.UpdateInfoAdmin(maDD, maAdmin);
            InitializeDataGridView();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (infoAdminDataGridView.SelectedRows.Count == 1)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoAdminDataGridView.SelectedRows[0];
                string maddToDelete = selectedRow.Cells["Madd"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                AdminDAO.Instance.DeleteAdmin(maddToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }
    }
}
