using QLSV_OOP.DAO;
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

namespace QLSV_OOP
{
    public partial class CapNhatCongNo : UserControl
    {
        public CapNhatCongNo()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtPaidID.Text = "";
            txtStudentID.Text = "";
            txtMoney.Text = "";
            txtSTK.Text = "";
            boxBank.Text = "";
            InitializeDataGridView();
        }
        
        private void InitializeDataGridView()
        {
            tuitionDataGridView.DataSource = Hoc_phiDAO.Instance.tuitionGridView();
        }
        private void CapNhatCongNo_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            tuitionDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (tuitionDataGridView.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = tuitionDataGridView.SelectedRows[0];
                string maThanhToan = selectedRow.Cells["MaTT"].Value.ToString();
                string stk = selectedRow.Cells["STK"].Value.ToString();
                string maSinhVien = selectedRow.Cells["MaSV"].Value.ToString();
                string tienThanhToan = selectedRow.Cells["TienTT"].Value.ToString();
                string nganHang = selectedRow.Cells["TenNH"].Value.ToString();

                // Hiển thị thông tin trong GroupBox
                DisplayCongNoInfo(maThanhToan, stk, maSinhVien, tienThanhToan, nganHang);
            }
        }
        private void DisplayCongNoInfo(string maThanhToan, string stk, string maSinhVien, string tienThanhToan, string nganHang)
        {
            // Hiển thị thông tin sinh viên trong GroupBox
            txtPaidID.Text = maThanhToan;
            txtSTK.Text = stk;
            txtStudentID.Text = maSinhVien;
            txtMoney.Text = tienThanhToan;
            boxBank.Text = maThanhToan;
        }
        


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maThanhToan = txtPaidID.Text;
            string stk = txtSTK.Text;
            string maSinhVien = txtStudentID.Text;
            string tienThanhToan = txtMoney.Text;
            string nganHang = boxBank.Text;

            tuitionDataGridView.DataSource = Hoc_phiDAO.Instance.SearchCongNo(maThanhToan, stk, maSinhVien, tienThanhToan, nganHang);
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            string newmaThanhToan = txtPaidID.Text;
            string newstk = txtPaidID.Text;
            string newmaSinhVien = txtStudentID.Text;
            string newtienThanhToan = txtMoney.Text;
            string newnganHang = boxBank.Text;

            Hoc_phiDAO.Instance.UpdateCongNoInfo(newmaThanhToan, newmaSinhVien, newnganHang, newstk, newtienThanhToan);

            InitializeDataGridView();

        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tuitionDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = tuitionDataGridView.SelectedRows[0];
                string tuitionToDelete = selectedRow.Cells["MaTT"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                Hoc_phiDAO.Instance.DeleteCongNo(tuitionToDelete);

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
            string newmaThanhToan = txtPaidID.Text;
            string newstk = txtPaidID.Text;
            string newmaSinhVien = txtStudentID.Text;
            string newtienThanhToan = txtMoney.Text;
            string newnganHang = boxBank.Text;

            Hoc_phiDAO.Instance.AddCongNoInfo(newmaThanhToan, newmaSinhVien, newnganHang, newstk, newtienThanhToan);

            InitializeDataGridView();
        }
        
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
