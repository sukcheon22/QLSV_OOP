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

namespace QLSV_OOP
{
    public partial class CapNhatDiem : UserControl
    {
        public CapNhatDiem()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            cmbMaHP.Text = "";
            txtMaSV.Text = "";
            cmbDiem.Text = "";
            infoGradeDataGridView.DataSource = KQHTDAO.Instance.gradeGridView();
            LoadDataIntoComboBox();
        }
        private void LoadDataIntoComboBox()
        {
            // Gọi hàm để lấy DataTable từ cơ sở dữ liệu
            DataTable hocPhanDataTable = GetHocPhanDataForComboBox();

            // Gán DataTable làm nguồn dữ liệu cho ComboBox
            cmbMaHP.DataSource = hocPhanDataTable;

            // Chọn cột cần hiển thị trong ComboBox
            cmbMaHP.DisplayMember = "MaHP";

            // (Optional) Chọn giá trị đầu tiên nếu có
            if (cmbMaHP.Items.Count > 0)
            {
                cmbMaHP.SelectedIndex = 0;
            }
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
        public DataTable infoLopGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from KQHT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            infoGradeDataGridView.DataSource = this.infoLopGridView();
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoGradeDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = infoGradeDataGridView.SelectedRows[0];
                string maSV  = selectedRow.Cells["MaSV"].Value.ToString();
                string maHP = selectedRow.Cells["MaHP"].Value.ToString();
                string diem = selectedRow.Cells["Diem"].Value.ToString();
                DisplayGradeInfo(maSV, maHP, diem);
            }
        }

        private void DisplayGradeInfo(string maSV, string maHP, string diem)
        {
            cmbDiem.Text = diem;
            cmbMaHP.Text = maHP;
            txtMaSV.Text = maSV;
        }

        private void CapNhatDiem_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
            InitializeDataGridView();
            infoGradeDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
        private DataTable SearchKQHT(string maHP, string maSV, string diem)
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

        private void btnTimKiemKQHT_Click(object sender, EventArgs e)
        {
            string maHP = cmbMaHP.Text;
            string maSV = txtMaSV.Text;
            string diem = cmbDiem.Text;

            // Gọi hàm tìm kiếm và đặt kết quả vào DataGridView
            infoGradeDataGridView.DataSource = SearchKQHT(maHP, maSV, diem);
        }


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }
        private void btnSuaKQHT_Click(object sender, EventArgs e)
        {
            string maHP = cmbMaHP.Text;
            string maSV = txtMaSV.Text;
            string diem = cmbDiem.Text;

            CapNhatThongTinKQHT(maHP, maSV, diem);
            InitializeDataGridView(); 
        }

        private void CapNhatThongTinKQHT(string maHP, string maSV, string diem)
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
        private void btnThemKQHT_Click(object sender, EventArgs e)
        {
            string maHP = cmbMaHP.Text;
            string maSV = txtMaSV.Text;
            string diem = cmbDiem.Text;

            // Gọi hàm để thêm mới KQHT
            ThemKQHTMoi(maHP, maSV, diem);

            // Làm mới DataGridView hoặc thực hiện các bước khác cần thiết
            InitializeDataGridView();
        }

        private void ThemKQHTMoi(string maHP, string maSV, string diem)
        {
            try
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
        private void btnXoaKQHT_Click(object sender, EventArgs e)
        {
            if (infoGradeDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoGradeDataGridView.SelectedRows[0];
                string maHPToDelete = selectedRow.Cells["MaHP"].Value.ToString();
                string maSVToDelete = selectedRow.Cells["MaSV"].Value.ToString();

                // Gọi hàm DeleteKQHT để thực hiện xóa từ CSDL
                DeleteKQHT(maHPToDelete, maSVToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin KQHT thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }

        private void DeleteKQHT(string maHP, string maSV)
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
