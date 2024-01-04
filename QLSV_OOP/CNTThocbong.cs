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
    public partial class CNTThocbong : UserControl
    {
        public CNTThocbong()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtMaHB.Text = "";
            txtTenHB.Text = "";
            cmbLoaiHB.Text = "";
            infoHBDataGridView.DataSource = Tinh_trangHBDAO.Instance.HBGridView();
            
        }
        public DataTable infoHBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from HB", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            infoHBDataGridView.DataSource = this.infoHBGridView();
        }
        private void CNTThocbong_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoHBDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoHBDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = infoHBDataGridView.SelectedRows[0];
                string maHB = selectedRow.Cells["MaHB"].Value.ToString();
                string tenHB = selectedRow.Cells["TenHB"].Value.ToString();
                string loai = selectedRow.Cells["Loai"].Value.ToString();
                DisplayHBInfo(maHB, tenHB, loai);
            }
        }

        private void DisplayHBInfo(string maHB, string tenHB, string loai)
        {
            txtMaHB.Text = maHB;
            txtTenHB.Text = tenHB;
            cmbLoaiHB.Text = loai;
        }
        private DataTable SearchHB(string maHB, string tenHB, string loai)
        {
            string query = "SELECT * FROM HB WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(maHB))
            {
                query += $"MaHB LIKE '%{maHB}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(tenHB))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TenHB LIKE '%{tenHB}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(loai))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"Loai LIKE '%{loai}%'";
                isFirstCondition = false;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHB = txtMaHB.Text;
            string tenHB = txtTenHB.Text;
            string loai = cmbLoaiHB.Text;

            infoHBDataGridView.DataSource = SearchHB(maHB, tenHB, loai);
        }
        private void UpdateHBInfo(string newmaHB, string newtenHB, string newloai)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE HB SET TenHB = @TenHB, Loai = @Loai WHERE MaHB = @MaHB", con))
                {
                    cmd.Parameters.AddWithValue("@MaHB", newmaHB);
                    cmd.Parameters.AddWithValue("@TenHB", newtenHB);
                    cmd.Parameters.AddWithValue("@Loai", newloai);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin học bổng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có học bổng nào được cập nhật. Có thể không tìm thấy thông tin tương ứng hoặc điều kiện cập nhật không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string newmaHB = txtMaHB.Text;
            string newtenHB = txtTenHB.Text;
            string newloai = cmbLoaiHB.Text;

            UpdateHBInfo(newmaHB, newtenHB, newloai);
            InitializeDataGridView();
        }
        private void DeleteHB(string maHB)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM HB WHERE MaHB = @MaHB", con))
            {
                cmd.Parameters.AddWithValue("MaHB", maHB);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (infoHBDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoHBDataGridView.SelectedRows[0];
                string hbToDelete = selectedRow.Cells["MaHB"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                DeleteHB(hbToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        private void AddHBInfo(string newmaHB, string newtenHB, string newloai)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO HB (MaHB, TenHB, Loai) VALUES (@MaHB, @TenHB, @Loai)", con))
                {
                    cmd.Parameters.AddWithValue("@MaHB", newmaHB);
                    cmd.Parameters.AddWithValue("@TenHB", newtenHB);
                    cmd.Parameters.AddWithValue("@Loai", newloai);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Đã thêm học bổng mới thành công!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show($"Mã học bổng '{newmaHB}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            string newmaHB = txtMaHB.Text;
            string newtenHB = txtTenHB.Text;
            string newloai = cmbLoaiHB.Text;

            AddHBInfo(newmaHB, newtenHB, newloai);

            InitializeDataGridView();
        }
        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }



    }
}
