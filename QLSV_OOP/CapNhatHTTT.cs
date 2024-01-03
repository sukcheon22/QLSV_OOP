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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLSV_OOP
{
    public partial class CapNhatHTTT : UserControl
    {
        public CapNhatHTTT()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtBank.Text = "";
            txtSTK.Text = "";
            TTdataGridView.DataSource = HTTTDAO.Instance.htttGridView();
        }
        public DataTable infoTTGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from HTTT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            TTdataGridView.DataSource = this.infoTTGridView();
        }

        private void CapNhatHTTT_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            TTdataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (TTdataGridView.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = TTdataGridView.SelectedRows[0];
                string nganhang = selectedRow.Cells["TenNH"].Value.ToString();
                string stk = selectedRow.Cells["STK_Truong"].Value.ToString();

                // Hiển thị thông tin trong GroupBox
                DisplayStudentInfo(nganhang, stk);
            }
        }
        private void DisplayStudentInfo(string nganhang, string stk)
        {
            // Hiển thị thông tin sinh viên trong GroupBox
            txtBank.Text = nganhang;
            txtSTK.Text = stk;
        }
        private DataTable SearchHTTT(string nganhang, string stk)
        {
            string query = "SELECT * FROM HTTT WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(nganhang))
            {
                query += $"TenNH LIKE '%{nganhang}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(stk))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"STK_Truong LIKE '%{stk}%'";
                isFirstCondition = false;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string bank = txtBank.Text;
            string stk = txtSTK.Text;

            TTdataGridView.DataSource = SearchHTTT(bank, stk);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string newbankname = txtBank.Text;
            string newSTK = txtSTK.Text;

            UpdateInfoTTInfo(newbankname, newSTK);

            InitializeDataGridView();
            
        }
        private void UpdateInfoTTInfo(string newbankname, string newSTK)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE HTTT SET STK_Truong = @STK_Truong WHERE TenNH = @TenNH", con))
                {
                    cmd.Parameters.AddWithValue("@TenNH", newbankname);
                    cmd.Parameters.AddWithValue("@STK_Truong", newSTK);

                    // Thêm điều kiện cập nhật (ví dụ: WHERE TenNH = 'Tên Ngân Hàng' AND STK_Truong = 'Số Tài Khoản')
                    // Điều kiện này phải phản ánh cấu trúc chính xác của bảng HTTT trong cơ sở dữ liệu của bạn.

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã cập nhật thông tin hình thức thanh toán thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có hình thức thanh toán nào được cập nhật. Có thể không tìm thấy thông tin tương ứng hoặc điều kiện cập nhật không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (TTdataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = TTdataGridView.SelectedRows[0];
                string bankToDelete = selectedRow.Cells["TenNH"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                DeleteHTTT(bankToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        private void DeleteHTTT(string nganghang)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM HTTT WHERE TenNH = @Bank", con))
            {
                cmd.Parameters.AddWithValue("@Bank", nganghang);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string newBank = txtBank.Text;
            string newSTK = txtSTK.Text;

            AddHTTT(newBank, newSTK); 

            InitializeDataGridView();
        }
        private void AddHTTT(string bank, string STK)
        {
            // Thêm một hình thức thanh toán mới vào cơ sở dữ liệu
            // Sử dụng SqlCommand để thực hiện câu truy vấn INSERT
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO HTTT (TenNH, STK_Truong) VALUES (@TenNH, @STK_Truong)", con))
                {
                    cmd.Parameters.AddWithValue("@TenNH", bank);
                    cmd.Parameters.AddWithValue("@STK_Truong", STK);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Đã thêm hình thức thanh toán mới thành công!");
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 2627)  // 2627 là mã lỗi cho việc vi phạm ràng buộc duy nhất (unique constraint)
                {
                    MessageBox.Show($"Số tài khoản '{STK}' đã tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }
    }
}
