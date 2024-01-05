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
    public class Nhan_vienDAO
    {
        private static Nhan_vienDAO instance;

        public static Nhan_vienDAO Instance
        {
            get
            {
                if (instance == null) instance = new Nhan_vienDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Nhan_vienDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public Nhan_vien GetNhanVienbyUserID(string userid)
        {
            SqlDataAdapter sa = new SqlDataAdapter("SELECT * FROM Nhan_vien WHERE MaDD = '" + userid + "'", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                return new Nhan_vien(item);
            }

            return null;
        }
        public int NumDaoTao()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Nhan_vien WHERE ViTri = 'Dao Tao'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumTaiVu()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Nhan_vien WHERE ViTri = 'Tai Vu'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int NumTong()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Nhan_vien ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public DataTable empGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Nhan_vien", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable SearchNhanVien(string maNV, string maDD, string tenNV, string vitri, string que, string sdt)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM Nhan_vien WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(maNV))
            {
                query += $"MaNV LIKE '%{maNV}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(maDD))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MaDD LIKE '%{maDD}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(tenNV))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TenNV LIKE '%{tenNV}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(vitri))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"ViTri LIKE '%{vitri}%'";
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
        
        public bool KiemTraTrung(string maNV, string maDD)
        {
            string query = "select count(*) from Nhan_vien where MaNV = '" + maNV + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int flag = Convert.ToInt32(dt.Rows[0][0]);

            string query1 = "select MaNV from Nhan_vien where MaDD = '" + maDD + "';";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            string maNVCheck = Convert.ToString(dt1.Rows[0][0]);
            if (flag == 0 || maNV == maNVCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdateInfoEmployee(string maDD, string maNV, string newTenNV, string newViTri, string newQue, string newSDT, DateTime newNgaySinh)
        {
            try
            {
                if (KiemTraTrung(maNV, maDD))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Nhan_vien SET MaNV = @MaNV, TenNV = @TenNV, ViTri = @ViTri, Que = @Que, SDT = @SDT, NgaySinh = @NgaySinh WHERE MaDD = @MaDD", con))
                    {
                        cmd.Parameters.AddWithValue("@TenNV", newTenNV);
                        cmd.Parameters.AddWithValue("@ViTri", newViTri);
                        cmd.Parameters.AddWithValue("@Que", newQue);
                        cmd.Parameters.AddWithValue("@SDT", newSDT);
                        cmd.Parameters.AddWithValue("@NgaySinh", newNgaySinh.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@MaDD", maDD);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã cập nhật thông tin nhân viên thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không có nhân viên nào được cập nhật. Có thể không tồn tại Mã NV tương ứng hoặc Mã DD không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void ThemNhanVienDaoTaoMoi(string madd)
        {
            using (SqlCommand cmdNhanVien = new SqlCommand(
                  "INSERT INTO Nhan_vien (MaNV, MaDD, TenNV, ViTri, Que, SDT, NgaySinh) VALUES " +
                  "(" +
                  "@Madd, " +
                  "@Madd, " +
                  "0, " +
                  "@Daotao, " +
                  "0, " +
                  "0, " +
                  "DATEADD(DAY, -CAST(RAND() * 3652 AS INT), GETDATE())" +
                  ")", con))
            {
                cmdNhanVien.Parameters.AddWithValue("@Madd", madd);
                cmdNhanVien.Parameters.AddWithValue("@Daotao", "Dao tao");


                con.Open();
                cmdNhanVien.ExecuteNonQuery();
                con.Close();
            }

        }
        public void ThemNhanVienTaiVuMoi(string madd)
        {
            using (SqlCommand cmdNhanVien = new SqlCommand(
                  "INSERT INTO Nhan_vien (MaNV, MaDD, TenNV, ViTri, Que, SDT, NgaySinh) VALUES " +
                  "(" +
                  "@Madd, " +
                  "@Madd, " +
                  "0, " +
                  "@Taivu, " +
                  "0, " +
                  "0, " +
                  "DATEADD(DAY, -CAST(RAND() * 3652 AS INT), GETDATE())" +
                  ")", con))
            {
                cmdNhanVien.Parameters.AddWithValue("@Madd", madd);
                cmdNhanVien.Parameters.AddWithValue("@Taivu", "Tai vu");

                con.Open();
                cmdNhanVien.ExecuteNonQuery();
                con.Close();
            }
            
        }
        public void DeleteNhanVien(string madd)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Nhan_vien WHERE Madd = @Madd", con))
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
