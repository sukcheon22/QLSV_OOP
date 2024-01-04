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
            infoHPDataGridView.DataSource = Hoc_phanDAO.Instance.hpGridView();
        }
        public DataTable infoHPGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Hoc_phan", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            infoHPDataGridView.DataSource = this.infoHPGridView();
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoHPDataGridView.SelectedRows.Count > 0)
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
        private DataTable SearchHocPhan(string maHP, string tenHP, string khoiLuong)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM Hoc_phan WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(maHP))
            {
                query += $"MaHP LIKE '%{maHP}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(tenHP))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TenHP LIKE '%{tenHP}%'";
                isFirstCondition = false;
            }
            if (!string.IsNullOrEmpty(khoiLuong))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"KhoiLuong = {khoiLuong} ";

            }
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHP = txtMaHP.Text;
            string tenHP = txtTenHP.Text;
            string khoiLuong = cmbKhoiLuong.Text;
            infoHPDataGridView.DataSource = SearchHocPhan(maHP, tenHP, khoiLuong);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHP = txtMaHP.Text;
            string tenHP = txtTenHP.Text;
            string khoiLuong = cmbKhoiLuong.Text;
            UpdateInfoHP(maHP, tenHP, khoiLuong);
            InitializeDataGridView();

        }
        private void UpdateInfoHP(string maHP, string tenHP, string khoiLuong)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Hoc_phan SET TenHP = @TenHP, KhoiLuong = @KhoiLuong WHERE MaHP = @MaHP", con))
                {
                    cmd.Parameters.AddWithValue("@TenHP", tenHP);
                    cmd.Parameters.AddWithValue("@KhoiLuong", khoiLuong);
                    cmd.Parameters.AddWithValue("@MaHP", maHP);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin học phần thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có học phần nào được cập nhật. Có thể không tồn tại Mã HP tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo rằng kết nối sẽ được đóng dù có lỗi hay không
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (infoHPDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoHPDataGridView.SelectedRows[0];
                string maHPToDelete = selectedRow.Cells["MaHP"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                DeleteHocPhan(maHPToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        private void DeleteHocPhan(string maHP)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Hoc_phan WHERE MaHP = @MaHP", con))
            {
                cmd.Parameters.AddWithValue("@MaHP", maHP);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHP = txtMaHP.Text;
            string tenHP = txtTenHP.Text;
            string khoiLuong = cmbKhoiLuong.Text;
            ThemHocPhanMoi(maHP, tenHP, khoiLuong);
            InitializeDataGridView();
        }

        private void ThemHocPhanMoi(string maHP, string tenHP, string khoiLuong)
        {
            try
            {
                // Thực hiện câu truy vấn INSERT
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Hoc_phan (MaHP, TenHP, KhoiLuong) VALUES (@MaHP, @TenHP, @KhoiLuong)", con))
                {
                    cmd.Parameters.AddWithValue("@MaHP", maHP);
                    cmd.Parameters.AddWithValue("@TenHP", tenHP);
                    cmd.Parameters.AddWithValue("@KhoiLuong", khoiLuong);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Đã thêm lớp học mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Mã lớp '{maHP}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khác (nếu có)
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo rằng kết nối sẽ được đóng dù có lỗi hay không
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }
    }

}
