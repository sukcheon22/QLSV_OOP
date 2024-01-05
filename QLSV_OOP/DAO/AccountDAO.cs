using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLSV_OOP.DTO;
using QLSV_OOP;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Text;
using System.Windows.Forms;

namespace QLSV_OOP.DAO
{
    public class AccountDAO
    {
        
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set => instance = value;
        }
        private AccountDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        
        public bool Login(string username, string password, string roleid)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tai_khoan WHERE Username ='" + username + "' AND Password='" + password + "' AND MaQuyen= '"+ roleid +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
                
            }
            else { return false; }
            
        }

        public Account GetAccountByUserName(string userName)
        {
            SqlDataAdapter sa = new SqlDataAdapter("SELECT * FROM tai_khoan WHERE Username = '" + userName + "'", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        public bool UpdatePassword(string username, string oldPassword, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                string query = "UPDATE tai_khoan SET Password = @NewPassword WHERE Username = @UserName AND Password = @OldPassword";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@OldPassword", oldPassword); // Mật khẩu cũ
                command.Parameters.AddWithValue("@NewPassword", newPassword); // Mật khẩu mới

                int rowsAffected = command.ExecuteNonQuery();
                
                return rowsAffected > 0;
            }
        }

        public int NumAdmin()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tai_khoan WHERE MaQuyen = 'QAD'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumStudent()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tai_khoan WHERE MaQuyen = 'QSV'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumEduEmployee()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tai_khoan where MaQuyen = 'QDT'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumFinancialEmployee()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tai_khoan where MaQuyen = 'QTV'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumAccount()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tai_khoan ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public DataTable accGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from tai_khoan", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable SearchTaiKhoan(string madd, string username, string password, string maquyen)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM tai_khoan WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(madd))
            {
                query += $"MaDD LIKE '%{madd}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(username))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"Username LIKE '%{username}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(password))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"Password LIKE '%{password}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(maquyen))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"MaQuyen LIKE '%{maquyen}%'";
            }

            // Thực hiện truy vấn SQL SELECT với câu truy vấn động
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        public void UpdateInfoAccInfo(string userid, string newusername, string newpassword, string roleid)
        {
            try
            {
                string roleOld = "";
                SqlDataAdapter sda = new SqlDataAdapter("SELECT MaQuyen from tai_khoan where MaDD = '" + userid + "';", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    roleOld = Convert.ToString(dt.Rows[0][0]);
                }
                using (SqlCommand cmd = new SqlCommand("UPDATE tai_khoan SET Username = @Name , Password = @Password WHERE MaDD = @Madd", con))
                {
                    cmd.Parameters.AddWithValue("@Name", newusername);
                    cmd.Parameters.AddWithValue("@Password", newpassword);
                    cmd.Parameters.AddWithValue("@Madd", userid);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        if (roleid == roleOld)
                        {
                            MessageBox.Show("Đã cập nhật thông tin tài khoản thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thay đổi quyền. Vui lòng xóa tài khoản để cập nhật quyền mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có tài khoản nào được cập nhật. Có thể không tồn tại Mã DD tương ứng hoặc Mã DD không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                  
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ThemTaiKhoanMoi(string userId, string username, string password, string role)
        {
            // Thêm một tài khoản mới vào cơ sở dữ liệu
            // Sử dụng SqlCommand để thực hiện câu truy vấn INSERT
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tai_khoan (Madd, Username, Password, MaQuyen) VALUES (@Madd, @Username, @Password, @MaQuyen)", con))
                {
                    cmd.Parameters.AddWithValue("@Madd", userId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@MaQuyen", role);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }
                if (role == "QSV")
                {
                    Sinh_VienDAO.Instance.ThemSinhVienMoi(userId);
                }
                else if (role == "QDT")
                {
                    Nhan_vienDAO.Instance.ThemNhanVienDaoTaoMoi(userId);
                }
                else if (role == "QTV")
                {
                    Nhan_vienDAO.Instance.ThemNhanVienTaiVuMoi(userId);
                }

                MessageBox.Show("Đã thêm tài khoản mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Mã '{userId}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void DeleteTaiKhoan(string madd)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM tai_khoan WHERE Madd = @Madd", con))
            {
                cmd.Parameters.AddWithValue("@Madd", madd);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


    }

}
