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
            tuitionDataGridView.DataSource = Hoc_phiDAO.Instance.tuitionGridView();
        }
        public DataTable infoTuitionGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Hoc_phi", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            tuitionDataGridView.DataSource = this.infoTuitionGridView();
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
        private DataTable SearchCongNo(string maThanhToan, string stk, string maSinhVien, string tienThanhToan, string nganHang)
        {
            string query = "SELECT * FROM Hoc_phi WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(maThanhToan))
            {
                query += $"MaTT LIKE '%{maThanhToan}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(stk))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"STK LIKE '%{stk}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(maSinhVien))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MaSV LIKE '%{maSinhVien}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(tienThanhToan))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TienTT LIKE '%{tienThanhToan}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(nganHang))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TenNH LIKE '%{nganHang}%'";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maThanhToan = txtPaidID.Text;
            string stk = txtPaidID.Text;
            string maSinhVien = txtStudentID.Text;
            string tienThanhToan = txtMoney.Text;
            string nganHang = boxBank.Text;

            tuitionDataGridView.DataSource = SearchCongNo(maThanhToan, stk, maSinhVien, tienThanhToan, nganHang);
            InitializeDataGridView();
        }
        private void UpdateCongNoInfo(string newmaThanhToan, string newmaSinhVien, string newnganHang, string newstk, string newtienThanhToan)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Hoc_phi SET MaTT = @MaTT, MaSV = @MaSV, TenNH = @TenNH, STK = @STK, TienTT = @TienTT WHERE MaTT = @MaTT", con))
                {
                    cmd.Parameters.AddWithValue("@MaTT", newmaThanhToan);
                    cmd.Parameters.AddWithValue("@MaSV", newmaSinhVien);
                    cmd.Parameters.AddWithValue("@TenNH", newnganHang);
                    cmd.Parameters.AddWithValue("@STK", newstk);
                    cmd.Parameters.AddWithValue("@TienTT", newtienThanhToan);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin học phí thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có thông tin học phí nào được cập nhật. Có thể không tìm thấy thông tin tương ứng hoặc điều kiện cập nhật không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string newmaThanhToan = txtPaidID.Text;
            string newstk = txtPaidID.Text;
            string newmaSinhVien = txtStudentID.Text;
            string newtienThanhToan = txtMoney.Text;
            string newnganHang = boxBank.Text;

            UpdateCongNoInfo(newmaThanhToan, newmaSinhVien, newnganHang, newstk, newtienThanhToan);

            InitializeDataGridView();

        }
        private void DeleteCongNo(string maThanhToan)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Hoc_phi WHERE MaTT = @maThanhToan", con))
            {
                cmd.Parameters.AddWithValue("@maThanhToan", maThanhToan);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tuitionDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = tuitionDataGridView.SelectedRows[0];
                string tuitionToDelete = selectedRow.Cells["MaTT"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                DeleteCongNo(tuitionToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        private void AddCongNoInfo(string newmaThanhToan, string newmaSinhVien, string newnganHang, string newstk, string newtienThanhToan)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Hoc_phi (MaTT, MaSV, TenNH, STK, TienTT) VALUES (@MaTT, @MaSV, @TenNH, @STK, @TienTT)", con))
                {
                    cmd.Parameters.AddWithValue("@MaTT", newmaThanhToan);
                    cmd.Parameters.AddWithValue("@MaSV", newmaSinhVien);
                    cmd.Parameters.AddWithValue("@TenNH", newnganHang);
                    cmd.Parameters.AddWithValue("@STK", newstk);
                    cmd.Parameters.AddWithValue("@TienTT", newtienThanhToan);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Đã thêm thông tin công nợ học phí thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string newmaThanhToan = txtPaidID.Text;
            string newstk = txtPaidID.Text;
            string newmaSinhVien = txtStudentID.Text;
            string newtienThanhToan = txtMoney.Text;
            string newnganHang = boxBank.Text;

            AddCongNoInfo(newmaThanhToan, newmaSinhVien, newnganHang, newstk, newtienThanhToan);

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
