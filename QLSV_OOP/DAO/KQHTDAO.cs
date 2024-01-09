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
    public class KQHTDAO
    {
        private static KQHTDAO instance;

        public static KQHTDAO Instance
        {
            get
            {
                if (instance == null) instance = new KQHTDAO();
                return instance;
            }
            private set => instance = value;
        }
        private KQHTDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public int NumFailed()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienTruot FROM KQHT WHERE Diem < 1", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumPassed()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienQua FROM KQHT WHERE Diem >= 1;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public DataTable gradeGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from KQHT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        
        public int NumExcellent()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienXuatSac FROM KQHT WHERE dbo.Average(MaSV) >= 3.6;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["SoLuongSinhVienXuatSac"]);
        }
        public int NumGood()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienGioi FROM KQHT WHERE dbo.Average(MaSV) >= 3.2 AND dbo.Average(MaSV) < 3.6;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["SoLuongSinhVienGioi"]);
        }
        public int NumWell()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienKha FROM KQHT WHERE dbo.Average(MaSV) >= 2.8 AND dbo.Average(MaSV) < 3.2;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["SoLuongSinhVienKha"]);
        }
        public int NumBad()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienTrungBinh FROM KQHT WHERE dbo.Average(MaSV) < 2.8;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["SoLuongSinhVienTrungBinh"]);
        }
        public DataTable SearchKQHT(string maHP, string maSV, string diem)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM KQHT WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(maHP))
            {
                query += $"MaHP LIKE '%{maHP}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(maSV))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MaSV LIKE '%{maSV}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(diem))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"Diem = {diem}";
                isFirstCondition = false;
            }

            // Thực hiện truy vấn SQL SELECT với câu truy vấn động
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        public void CapNhatThongTinKQHT(string maHP, string maSV, string diem)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE KQHT SET Diem = @Diem WHERE MaHP = @MaHocPhan AND MaSV = @MaSV", con))
                {
                    cmd.Parameters.AddWithValue("@Diem", diem);
                    cmd.Parameters.AddWithValue("@MaHocPhan", maHP);
                    cmd.Parameters.AddWithValue("@MaSV", maSV);

                    con.Open();
                    int soDongAnhHuong = cmd.ExecuteNonQuery();
                    con.Close();
                    if (soDongAnhHuong > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin KQHT thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có KQHT nào được cập nhật. Có thể không tồn tại Mã Học Phần và Mã Sinh Viên tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public bool KiemTraTrung(string maSV, string maHP)
        {
            string query = "select count(*) from KQHT where MaSV = '" + maSV + "' and MaHP = '" + maHP + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int flag = Convert.ToInt32(dt.Rows[0][0]);
            if (flag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool KiemTraTonTaiMaSV(string maSV)
        {
            string query = "select count(*) from Sinh__vien where MaSV = '" + maSV + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int flag = Convert.ToInt32(dt.Rows[0][0]);
            if (flag == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ThemKQHTMoi(string maHP, string maSV, string diem)
        {

            try
            {
                if (KiemTraTrung(maSV, maHP) && KiemTraTonTaiMaSV(maSV))
                {
                    // Thực hiện câu truy vấn INSERT
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO KQHT (MaHP, MaSV, Diem) VALUES (@MaHocPhan, @MaSinhVien, @Diem)", con))
                    {
                        cmd.Parameters.AddWithValue("@MaHocPhan", maHP);
                        cmd.Parameters.AddWithValue("@MaSinhVien", maSV);
                        cmd.Parameters.AddWithValue("@Diem", diem);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Đã thêm mới thông tin KQHT thành công!");
                }
                else if (!KiemTraTrung(maSV, maHP))
                {
                    MessageBox.Show("Kết quả học tập cho trường hợp này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!KiemTraTonTaiMaSV(maSV)) 
                {
                    MessageBox.Show("Mã sinh viên không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Thông tin KQHT của Mã Học Phần '{maHP}' và Mã Sinh Viên '{maSV}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeleteKQHT(string maHP, string maSV)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM KQHT WHERE MaHP = @MaHocPhan AND MaSV = @MaSinhVien", con))
            {
                cmd.Parameters.AddWithValue("@MaHocPhan", maHP);
                cmd.Parameters.AddWithValue("@MaSinhVien", maSV);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



    }
}
