using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_OOP;
using QLSV_OOP.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLSV_OOP.DAO
{
    public class Tinh_trangHBDAO
    {
        private static Tinh_trangHBDAO instance;

        public static Tinh_trangHBDAO Instance
        {
            get
            {
                if (instance == null) instance = new Tinh_trangHBDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Tinh_trangHBDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        
        public DataTable SearchHB(string maHB, string tenHB, string loai)
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
        public void UpdateHBInfo(string newmaHB, string newtenHB, string newloai)
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
        public void DeleteHB(string maHB)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM HB WHERE MaHB = @MaHB", con))
            {
                cmd.Parameters.AddWithValue("MaHB", maHB);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void AddHBInfo(string newmaHB, string newtenHB, string newloai)
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
        public void DangKyMoi(string maHB, string maSV)
        {
            try
            {
                if (HBDAO.Instance.KiemTraTrung(maSV, maHB))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Tinh_trang_HB (MaSV, MaHB, TinhTrang) VALUES ('" + maSV + "', '" + maHB + "','False')", con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                    MessageBox.Show("Đã đăng ký học bổng thành công!");
                }

                else
                {
                    MessageBox.Show("Học bổng đã được đăng ký", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 547)  // 547 là mã lỗi cho việc vi phạm khóa ngoại
                {
                    MessageBox.Show("Mã học bổng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public DataTable classGridView(string maSV)
        {
            string query = "select Tinh_trang_HB.MaHB as \"Mã học bổng\", TenHB as \"Tên học bổng\", Loai as \"Loại\" from Tinh_trang_HB " +
                           "inner join HB on Tinh_trang_HB.MaHB = HB.MaHB " +
                           "where MaSV = " + maSV + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void XoaHocBong(string maHB, string maSV)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Tinh_trang_HB WHERE MaSV = '" + maSV + "' AND MaHB = '" + maHB + "'", con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public bool CheckXoa(string maHB, string maSV)
        {
            string query = "select TinhTrang from Tinh_trang_HB where MaSV = '" + maSV + "' and MaHB = '" + maHB + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }
        public void ConfirmInformation(string maSV, string maHB, string check)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Tinh_trang_HB SET TinhTrang = '" + check + "' WHERE MaSV = '" + maSV + "' AND MaHB = '" + maHB + "'", con))
                {

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Phê duyệt thành công!");
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
        public DataTable scholarshipGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Tinh_trang_HB", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
