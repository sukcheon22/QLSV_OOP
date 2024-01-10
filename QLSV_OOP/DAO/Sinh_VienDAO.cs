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
    public class Sinh_VienDAO
    {
        private static Sinh_VienDAO instance;

        public static Sinh_VienDAO Instance
        {
            get
            {
                if (instance == null) instance = new Sinh_VienDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Sinh_VienDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public Sinh_Vien GetSinhVienbyUserID(string userid)
        {
            SqlDataAdapter sa = new SqlDataAdapter("SELECT * FROM Sinh__vien WHERE MaDD = '" + userid + "'", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                return new Sinh_Vien(item);
            }

            return null;
        }

        public int NumK65()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sinh__vien WHERE Khoa = '65'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumK66()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sinh__vien WHERE Khoa = '66'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumK67()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sinh__vien WHERE Khoa = '67'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumK68()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sinh__vien WHERE Khoa = '68'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumStudent()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sinh__vien ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public DataTable svGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Sinh__vien", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void ThemSinhVienMoi(string madd)
        {
            using (SqlCommand cmdNhanVien = new SqlCommand(
                  "INSERT INTO Sinh__vien (MaSV, MaDD, TenSV, Khoa, Que, SDT, NgaySinh) VALUES " +
                  "(" +
                  "@Madd, " +
                  "@Madd, " +
                  "0, " +
                  "0, " +
                  "0, " +
                  "0, " +
                  "DATEADD(DAY, -CAST(RAND() * 3652 AS INT), GETDATE())" +
                  ")", con))
            {
                cmdNhanVien.Parameters.AddWithValue("@Madd", madd);

                con.Open();
                cmdNhanVien.ExecuteNonQuery();
                con.Close();
            }
        }
        public DataTable SearchSinhVien(string maSV, string maDD, string tenSV, string khoa, string que, string sdt)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM Sinh__vien WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(maSV))
            {
                query += $"MaSV LIKE '%{maSV}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(maDD))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MaDD LIKE '%{maDD}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(tenSV))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TenSV LIKE '%{tenSV}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(khoa))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"Khoa = {khoa}";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(que))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"Que LIKE '%{que}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(sdt))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"SDT LIKE '%{sdt}%'";

            }



            // Thực hiện truy vấn SQL SELECT với câu truy vấn động
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        public bool KiemTraTrung(string maSV, string maDD)
        {
            string query = "select count(*) from Sinh__vien where MaSV = '" + maSV + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int flag = Convert.ToInt32(dt.Rows[0][0]);

            string query1 = "select MaSV from Sinh__vien where MaDD = '" + maDD + "';";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            string maSVCheck = Convert.ToString(dt1.Rows[0][0]);
            if (flag == 0 || maSV == maSVCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdateInfoStudent(string maDD, string maSV, string newTenSV, string newKhoa, string newQue, string newSDT, DateTime newNgaySinh)
        {
            try
            {
                if (KiemTraTrung(maSV, maDD))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Sinh__vien SET MaSV = @MaSV, TenSV = @TenSV, Khoa = @Khoa, Que = @Que, SDT = @SDT, NgaySinh = @NgaySinh WHERE MaDD = @MaDD", con))
                    {
                        cmd.Parameters.AddWithValue("@TenSV", newTenSV);
                        cmd.Parameters.AddWithValue("@Khoa", newKhoa);
                        cmd.Parameters.AddWithValue("@Que", newQue);
                        cmd.Parameters.AddWithValue("@SDT", newSDT);
                        cmd.Parameters.AddWithValue("@NgaySinh", newNgaySinh.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaDD", maDD);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã cập nhật thông tin sinh viên thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không có sinh viên nào được cập nhật. Có thể không tồn tại Mã SV tương ứng hoặc Mã DD không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã sinh viên hoặc Mã Định danh đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeleteSinhVien(string madd)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Sinh__vien WHERE Madd = @Madd", con))
            {
                cmd.Parameters.AddWithValue("@Madd", madd);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            AccountDAO.Instance.DeleteTaiKhoan(madd);
        }
    }
}
