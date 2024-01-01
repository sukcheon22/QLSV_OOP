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
using QLSV_OOP.DAO;
using QLSV_OOP.DTO;

namespace QLSV_OOP
{
    public partial class AccountManagement : UserControl
    {
        public AccountManagement()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtID.Text = ""; 
            txtTen.Text = "";
            cmbRole.Text = "";
            txtPass.Text = "";
            infoAccDataGridView.DataSource = AccountDAO.Instance.accGridView();                          

            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mới từ TextBoxes
            string userid = txtID.Text;
            string username = txtTen.Text;
            string password = txtPass.Text;
            string roleid = cmbRole.Text;
            infoAccDataGridView.DataSource = SearchTaiKhoan(userid, username, password, roleid);
            

            

            
        }
        private DataTable SearchTaiKhoan(string madd, string username, string password, string maquyen)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM Tai_khoan WHERE ";
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
        public DataTable infoAccGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Tai_khoan", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            infoAccDataGridView.DataSource = this.infoAccGridView();
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoAccDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoAccDataGridView.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = infoAccDataGridView.SelectedRows[0];
                string madd = selectedRow.Cells["MaDD"].Value.ToString();
                string username = selectedRow.Cells["Username"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                string maquyen = selectedRow.Cells["MaQuyen"].Value.ToString() ;

                // Hiển thị thông tin trong GroupBox
                DisplayStudentInfo(madd, username, password, maquyen);
            }
        }

        private void DisplayStudentInfo(string madd, string username, string password, string maquyen)
        {
            // Hiển thị thông tin sinh viên trong GroupBox
            txtID.Text = madd;
            txtTen.Text = username;
            txtPass.Text = password;
            cmbRole.Text = maquyen;
            // ...Thêm các thuộc tính khác tương ứng
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mới từ TextBoxes
            string userid = txtID.Text;
            string newusername = txtTen.Text;
            string newpassword = txtPass.Text;

            // Gọi hàm cập nhật thông tin sinh viên
            UpdateInfoAccInfo(userid, newusername, newpassword);

            // Cập nhật lại DataGridView sau khi cập nhật CSDL
            InitializeDataGridView();

            
        }
        

        private void UpdateInfoAccInfo(string userid, string newusername, string newpassword)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Tai_khoan SET Username = @Name , Password = @Password WHERE MaDD = @Madd", con))
                {
                    cmd.Parameters.AddWithValue("@Name", newusername);
                    cmd.Parameters.AddWithValue("@Password", newpassword);
                    cmd.Parameters.AddWithValue("@Madd", userid);

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
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (infoAccDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoAccDataGridView.SelectedRows[0];
                string maddToDelete = selectedRow.Cells["Madd"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                DeleteTaiKhoan(maddToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        private void DeleteTaiKhoan(string madd)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Tai_khoan WHERE Madd = @Madd", con))
            {
                cmd.Parameters.AddWithValue("@Madd", madd);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ form
            string newUserId = txtID.Text;
            string newUsername = txtTen.Text;
            string newPassword = txtPass.Text;
            string newRole = cmbRole.Text;
            

            // Gọi hàm để thêm tài khoản mới
            ThemTaiKhoanMoi(newUserId, newUsername, newPassword, newRole);

            // Làm mới DataGridView
            InitializeDataGridView();

            
                
            
        }

        private void ThemTaiKhoanMoi(string userId, string username, string password, string role)
        {
            // Thêm một tài khoản mới vào cơ sở dữ liệu
            // Sử dụng SqlCommand để thực hiện câu truy vấn INSERT
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Tai_khoan (Madd, Username, Password, MaQuyen) VALUES (@Madd, @Username, @Password, @MaQuyen)", con))
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
                    ThemSinhVienMoi(userId);
                }
                else if (role == "QNV")
                {
                    //ThemNhanVienMoi(userId);
                }
                MessageBox.Show("Đã thêm tài khoản mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Mã sinh viên '{userId}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void ThemSinhVienMoi(string madd)
        {
            using (SqlCommand cmdNhanVien = new SqlCommand(
                  "INSERT INTO Sinh__vien (MaSV, MaDD, TenSV, Khoa, Que, SDT, NgaySinh) VALUES " +
                  "(" +
                  "0, " +
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
            //CAST(RAND() * 1000000 AS INT) ""CAST(RAND() * 1000000 AS NVARCHAR(255)) ""CAST(CEILING(RAND() * 5 + 63) AS INT)
            //CAST(RAND() * 1000000 AS NVARCHAR(255)) "" CAST(RAND() * 1000000 AS NVARCHAR(255))
        }
    }
}
