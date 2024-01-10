using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_OOP.DTO;

namespace QLSV_OOP.DAO
{
    internal class AdminDAO
    {
        private static AdminDAO instance;

        public static AdminDAO Instance
        {
            get
            {
                if (instance == null) instance = new AdminDAO();
                return instance;
            }
            private set => instance = value;
        }
        private AdminDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public DataTable adGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Admin", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable SearchAdmin(string maAdmin, string maDD)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM Admin WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(maAdmin))
            {
                query += $"MaAdmin LIKE '%{maAdmin}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(maDD))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MaDD LIKE '%{maDD}%'";
                isFirstCondition = false;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        public bool KiemTraTrung(string maAdmin, string maDD)
        {
            string query = "select count(*) from Admin where MaAdmin = '" + maAdmin + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int flag = Convert.ToInt32(dt.Rows[0][0]);

            string query1 = "select MaAdmin from Admin where MaDD = '" + maDD + "';";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            string maADCheck = Convert.ToString(dt1.Rows[0][0]);
            if (flag == 0 || maAdmin == maADCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdateInfoAdmin(string maDD, string maAdmin)
        {
            try
            {
                if (KiemTraTrung(maAdmin, maDD))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Admin SET MaAdmin = @MaAdmin WHERE MaDD = @MaDD", con))
                    {
                        
                        cmd.Parameters.AddWithValue("@MaAdmin", maAdmin);
                        cmd.Parameters.AddWithValue("@MaDD", maDD);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã cập nhật thông tin Admin thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không có Admin nào được cập nhật. Có thể không tồn tại Mã Admin tương ứng hoặc Mã DD không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã Admin hoặc Mã Định danh đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeleteAdmin(string madd)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Admin WHERE Madd = @Madd", con))
            {
                cmd.Parameters.AddWithValue("@Madd", madd);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            AccountDAO.Instance.DeleteTaiKhoan(madd);
        }
        public void ThemAdminMoi(string madd)
        {
            using (SqlCommand cmdAdmin = new SqlCommand(
                  "INSERT INTO Admin (MaAdmin, MaDD) VALUES " +
                  "(" +
                  "@MaDD, " +
                  "@Madd " +
                  ")", con))
            {
                cmdAdmin.Parameters.AddWithValue("@Madd", madd);

                con.Open();
                cmdAdmin.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
