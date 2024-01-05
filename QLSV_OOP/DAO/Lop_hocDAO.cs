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
    public class Lop_hocDAO
    {
        private static Lop_hocDAO instance;

        public static Lop_hocDAO Instance
        {
            get
            {
                if (instance == null) instance = new Lop_hocDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Lop_hocDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public DataTable classGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Lop_hoc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public int CountTinChi(string maSV)
        {
            string query = "select sum(KhoiLuong) from Hoc_phan " +
                "inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                "inner join Dang_ky on Dang_ky.MaLH = Lop_hoc.MaLH " +
                "where MaSV = " + maSV + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public bool KiemTraTrung(string maSV, string maLop)
        {
            string query = "select count(*) from Dang_ky where MaSV = " + maSV + " and MaLH = " + maLop + ";";
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
        public DataTable SearchLopHoc(string maLop, string maHocPhan, string soTiet, string soLuong, string batDau, string ketThuc, string thu)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM Lop_hoc WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(maLop))
            {
                query += $"MaLH LIKE '%{maLop}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(maHocPhan))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MaHP LIKE '%{maHocPhan}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(soTiet))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"ThoiGian = {soTiet}";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(soLuong))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"SoLuong = {soLuong}";
                isFirstCondition = false;
            }



            // Thực hiện truy vấn SQL SELECT với câu truy vấn động
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        public void UpdateInfoLopHoc(string maLop, string maHocPhan, string soTiet, string soLuong, string batDau, string ketThuc, string thu)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Lop_hoc SET MaHP = @MaHocPhan, ThoiGian = @SoTiet, SoLuong = @SoLuong, BatDau = @BatDau, KetThuc = @KetThuc, Thu = @Thu WHERE MaLH = @MaLop", con))
                {
                    cmd.Parameters.AddWithValue("@MaHocPhan", maHocPhan);
                    cmd.Parameters.AddWithValue("@SoTiet", soTiet);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@BatDau", batDau);
                    cmd.Parameters.AddWithValue("@KetThuc", ketThuc);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.Parameters.AddWithValue("@Thu", thu);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin lớp học thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có lớp học nào được cập nhật. Có thể không tồn tại Mã Lớp tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void ThemLopHocMoi(string maLop, string maHocPhan, string soTiet, string soLuong, string batDau, string ketThuc, string thu)
        {
            try
            {
                // Thực hiện câu truy vấn INSERT
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Lop_hoc (MaLH, MaHP, ThoiGian, SoLuong, BatDau, KetThuc, Thu) VALUES (@MaLop, @MaHocPhan, @SoTiet, @SoLuong, @BatDau, @KetThuc, @Thu)", con))
                {
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.Parameters.AddWithValue("@MaHocPhan", maHocPhan);
                    cmd.Parameters.AddWithValue("@SoTiet", soTiet);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@BatDau", batDau);
                    cmd.Parameters.AddWithValue("@KetThuc", ketThuc);
                    cmd.Parameters.AddWithValue("@Thu", thu);

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
                    MessageBox.Show($"Mã lớp '{maLop}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeleteLopHoc(string maLop)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Lop_hoc WHERE MaLH = @MaLop", con))
            {
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
