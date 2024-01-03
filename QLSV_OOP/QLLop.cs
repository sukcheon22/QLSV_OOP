using QLSV_OOP.DAO;
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

namespace QLSV_OOP
{
    public partial class QLLop : UserControl
    {
        public QLLop()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtMaLop.Text = "";
            cmbMaHP.Text = "";
            cmbSoTiet.Text = "";
            txtSoLuong.Text = "";
            cmbThu.Text = "";
            infoLopDataGridView.DataSource = Lop_hocDAO.Instance.classGridView();
            LoadDataIntoComboBox();
        }
        public DataTable infoLopGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Lop_hoc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            infoLopDataGridView.DataSource = this.infoLopGridView();
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoLopDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = infoLopDataGridView.SelectedRows[0];
                string maLH = selectedRow.Cells["MaLH"].Value.ToString();
                string maHP = selectedRow.Cells["MaHP"].Value.ToString();
                string thoiGian = selectedRow.Cells["ThoiGian"].Value.ToString();
                string soLuong = selectedRow.Cells["SoLuong"].Value.ToString();

                // Lấy giờ/phút/giây từ cơ sở dữ liệu
                TimeSpan batDauTime = (TimeSpan)selectedRow.Cells["BatDau"].Value;
                TimeSpan ketThucTime = (TimeSpan)selectedRow.Cells["KetThuc"].Value;

                // Tạo đối tượng DateTime với ngày mặc định và giờ/phút/giây từ cơ sở dữ liệu
                DateTime defaultDate = DateTime.Today;
                DateTime batDau = defaultDate.Add(batDauTime);
                DateTime ketThuc = defaultDate.Add(ketThucTime);
                string thu = selectedRow.Cells["Thu"].Value.ToString();

                DisplayStudentInfo(maLH, maHP, thoiGian, soLuong, batDau, ketThuc, thu);
            }
        }

        private void DisplayStudentInfo(string maLH, string maHP, string thoiGian, string soLuong, DateTime batDau, DateTime ketThuc, string thu)
        {
            txtMaLop.Text = maLH;
            cmbMaHP.Text = maHP;
            cmbSoTiet.Text = thoiGian;
            txtSoLuong.Text = soLuong;
            startDateTimePicker.Value = batDau;
            endDateTimePicker.Value = ketThuc;
            cmbThu.Text = thu;
        }
        private void QLLop_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
            InitializeDataGridView();
            infoLopDataGridView.SelectionChanged += DataGridView_SelectionChanged;
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
        private DataTable SearchLopHoc(string maLop, string maHocPhan, string soTiet, string soLuong, string batDau, string ketThuc, string thu)
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

        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string maHocPhan = cmbMaHP.Text;
            string soTiet = cmbSoTiet.Text;
            string soLuong = txtSoLuong.Text;
            string batDau = startDateTimePicker.Value.ToString("HH:mm:ss");
            string ketThuc = endDateTimePicker.Value.ToString("HH:mm:ss");
            string thu = cmbThu.Text;

            // Gọi hàm tìm kiếm và đặt kết quả vào DataGridView
            infoLopDataGridView.DataSource = SearchLopHoc(maLop, maHocPhan, soTiet, soLuong, batDau, ketThuc, thu);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLH = txtMaLop.Text;
            string maHP = cmbMaHP.Text;
            string soTiet = cmbSoTiet.Text;
            string soLuong = txtSoLuong.Text;
            string batDau = startDateTimePicker.Value.ToString("HH:mm:ss");
            string ketThuc = endDateTimePicker.Value.ToString("HH:mm:ss");
            string thu = cmbThu.Text;
            UpdateInfoLopHoc(maLH, maHP, soTiet, soLuong, batDau, ketThuc, thu);
            InitializeDataGridView();

        }
        private void UpdateInfoLopHoc(string maLop, string maHocPhan, string soTiet, string soLuong, string batDau, string ketThuc, string thu)
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
        private void btnThemLopHoc_Click(object sender, EventArgs e)
        {
            string maLH = txtMaLop.Text;
            string maHP = cmbMaHP.Text;
            string soTiet = cmbSoTiet.Text;
            string soLuong = txtSoLuong.Text;
            string batDau = startDateTimePicker.Value.ToString("HH:mm:ss");
            string ketThuc = endDateTimePicker.Value.ToString("HH:mm:ss");
            string thu = cmbThu.Text;

            // Gọi hàm để thêm lớp học mới
            ThemLopHocMoi(maLH, maHP, soTiet, soLuong, batDau, ketThuc, thu);

            // Làm mới DataGridView hoặc thực hiện các bước khác cần thiết
            InitializeDataGridView();
        }

        private void ThemLopHocMoi(string maLop, string maHocPhan, string soTiet, string soLuong, string batDau, string ketThuc, string thu)
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
        private void btnXoaLopHoc_Click(object sender, EventArgs e)
        {
            if (infoLopDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoLopDataGridView.SelectedRows[0];
                string maLopToDelete = selectedRow.Cells["MaLH"].Value.ToString();

                // Gọi hàm DeleteLopHoc để thực hiện xóa từ CSDL
                DeleteLopHoc(maLopToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin lớp học thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }

        private void DeleteLopHoc(string maLop)
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }

        private void cmbMaHP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
