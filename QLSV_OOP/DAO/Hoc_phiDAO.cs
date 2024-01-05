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
    public class Hoc_phiDAO
    {
        private static Hoc_phiDAO instance;

        public static Hoc_phiDAO Instance
        {
            get
            {
                if (instance == null) instance = new Hoc_phiDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Hoc_phiDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public int SumMoney()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(TienTT) FROM Hoc_phi", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public string MostBank()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 1 TenNH FROM Hoc_phi GROUP BY TenNH ORDER BY COUNT(TenNH) DESC;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToString(dt.Rows[0][0]);
        }
        public DataTable tuitionGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Hoc_phi", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public int DuNoHPhi(string maSV)
        {
            string query = "select (select sum(KhoiLuong) from Hoc_phan " +
                "inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                "inner join Dang_ky on Lop_hoc.MaLH = Dang_ky.MaLH " +
                "group by (MaSV) " +
                "having MaSV =" + maSV + ") * 500000 - sum(TienTT) from Hoc_phi " +
                "inner join Sinh__vien on Hoc_phi.MaSV = Sinh__vien.MaSV " +
                "group by Sinh__vien.MaSV " +
                "having Sinh__vien.MaSV = " + maSV + ";";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }


        public string NumStudentOwe()
        {
            string query = "select count(distinct Sinh__vien.MaSV) as NumStudentsOwe " +
                           "from Hoc_phi " +
                           "inner join Sinh__vien on Hoc_phi.MaSV = Sinh__vien.MaSV " +
                           "group by Sinh__vien.MaSV " +
                           "having (select sum(KhoiLuong) * 500000 from Hoc_phan " +
                           "inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                           "inner join Dang_ky on Lop_hoc.MaLH = Dang_ky.MaLH " +
                           "where Dang_ky.MaSV = Sinh__vien.MaSV) - sum(TienTT) > 0;";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToString(dt.Rows.Count);
        }

        public DataTable tuitionoweGridView()
        {
            string query = "select Hoc_phi.MaSV, (select sum(KhoiLuong) * 500000 from Hoc_phan inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP inner join Dang_ky on Lop_hoc.MaLH = Dang_ky.MaLH where Dang_ky.MaSV = Hoc_phi.MaSV) - sum(TienTT) as SoTienConNo from Hoc_phi inner join Sinh__vien on Hoc_phi.MaSV = Sinh__vien.MaSV group by Hoc_phi.MaSV having (select sum(KhoiLuong) * 500000 from Hoc_phan inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP inner join Dang_ky on Lop_hoc.MaLH = Dang_ky.MaLH where Dang_ky.MaSV = Hoc_phi.MaSV) - sum(TienTT) > 0;";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable SearchCongNo(string maThanhToan, string stk, string maSinhVien, string tienThanhToan, string nganHang)
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
        public void UpdateCongNoInfo(string newmaThanhToan, string newmaSinhVien, string newnganHang, string newstk, string newtienThanhToan)
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
        public void DeleteCongNo(string maThanhToan)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Hoc_phi WHERE MaTT = @maThanhToan", con))
            {
                cmd.Parameters.AddWithValue("@maThanhToan", maThanhToan);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void AddCongNoInfo(string newmaThanhToan, string newmaSinhVien, string newnganHang, string newstk, string newtienThanhToan)
        {
            try
            {
                if (IsPaymentIDExists(newmaThanhToan))
                {
                    MessageBox.Show("Mã thanh toán đã tồn tại. Vui lòng chọn một mã thanh toán khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng thực thi nếu Mã thanh toán đã tồn tại
                }
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
        private bool IsPaymentIDExists(string maThanhToan)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Hoc_phi WHERE MaTT = @MaTT", con))
            {
                cmd.Parameters.AddWithValue("@MaTT", maThanhToan);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                return count > 0;
            }

        }

    }
}
