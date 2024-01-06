using QLSV_OOP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_OOP
{
    public partial class QlyHPhan : UserControl
    {
        public QlyHPhan()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtMaHP.Text = "";
            txtTenHP.Text = "";
            cmbKhoiLuong.Text = "";
            InitializeDataGridView();
        }
        
        private void InitializeDataGridView()
        {
            infoHPDataGridView.DataSource = Hoc_phanDAO.Instance.hpGridView();
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoHPDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = infoHPDataGridView.SelectedRows[0];
                string maHP = selectedRow.Cells["MaHP"].Value.ToString();
                string tenHP = selectedRow.Cells["TenHP"].Value.ToString();
                string khoiLuong = selectedRow.Cells["KhoiLuong"].Value.ToString();
                DisplayStudentInfo(maHP, tenHP, khoiLuong);
            }
        }

        private void DisplayStudentInfo(string maHP, string tenHP, string khoiLuong)
        {
            txtMaHP.Text = maHP;
            txtTenHP.Text = tenHP;
            cmbKhoiLuong.Text = khoiLuong;
        }
        private void QlyHPhan_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoHPDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHP = txtMaHP.Text;
            string tenHP = txtTenHP.Text;
            string khoiLuong = cmbKhoiLuong.Text;
            infoHPDataGridView.DataSource = Hoc_phanDAO.Instance.SearchHocPhan(maHP, tenHP, khoiLuong);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHP = txtMaHP.Text;
            string tenHP = txtTenHP.Text;
            string khoiLuong = cmbKhoiLuong.Text;
            Hoc_phanDAO.Instance.UpdateInfoHP(maHP, tenHP, khoiLuong);
            InitializeDataGridView();

        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (infoHPDataGridView.SelectedRows.Count == 1)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoHPDataGridView.SelectedRows[0];
                string maHPToDelete = selectedRow.Cells["MaHP"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                Hoc_phanDAO.Instance.DeleteHocPhan(maHPToDelete);

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
            string maHP = txtMaHP.Text;
            string tenHP = txtTenHP.Text;
            string khoiLuong = cmbKhoiLuong.Text;
            Hoc_phanDAO.Instance.ThemHocPhanMoi(maHP, tenHP, khoiLuong);
            InitializeDataGridView();
        }

        

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }
    }

}
