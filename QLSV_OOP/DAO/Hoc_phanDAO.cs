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
    public class Hoc_phanDAO
    {
        private static Hoc_phanDAO instance;

        public static Hoc_phanDAO Instance
        {
            get
            {
                if (instance == null) instance = new Hoc_phanDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Hoc_phanDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public DataTable hpGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Hoc_phan", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable GetHocPhanDataForComboBox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("A", typeof(string));
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();

                    // Thay đổi truy vấn để lấy thông tin về HocPhan
                    string query = "SELECT MaHP FROM Hoc_Phan";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                DataRow rowBlank = dt.NewRow();
                rowBlank["A"] = "";
                dt.Rows.InsertAt(rowBlank, 0);
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine(ex.Message);
            }

            return dt;
        }
        public DataTable SearchHocPhan(string maHP, string tenHP, string khoiLuong)
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
        public void UpdateInfoHP(string maHP, string tenHP, string khoiLuong)
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
        public void DeleteHocPhan(string maHP)
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
        public void ThemHocPhanMoi(string maHP, string tenHP, string khoiLuong)
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
    }
}
