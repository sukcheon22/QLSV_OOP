using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_OOP.DAO;
using QLSV_OOP.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace QLSV_OOP
{
    public partial class StudentManagement : UserControl
    {
        public StudentManagement()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtID.Text = "";
            txtTen.Text = "";
            txtIDStu.Text = "";
            txtSDT.Text = "";
            cmbKhoa.Text = "";
            cmbQue.Text = "";
            infoStuDataGridView.DataSource = Sinh_VienDAO.Instance.svGridView();


        }
        public DataTable infoStuGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Sinh__vien", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            infoStuDataGridView.DataSource = this.infoStuGridView();
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoStuDataGridView.SelectedRows.Count > 0)
            {  
                DataGridViewRow selectedRow = infoStuDataGridView.SelectedRows[0];
                string maSV = selectedRow.Cells["MaSV"].Value.ToString();
                string maDD = selectedRow.Cells["MaDD"].Value.ToString();
                string tenSV = selectedRow.Cells["TenSV"].Value.ToString();
                string khoa = selectedRow.Cells["Khoa"].Value.ToString();
                string que = selectedRow.Cells["Que"].Value.ToString();
                string sdt = selectedRow.Cells["SDT"].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                DisplayStudentInfo(maSV, maDD, tenSV, khoa, que, sdt, ngaySinh);
            }
        }

        private void DisplayStudentInfo(string maSV, string maDD, string tenSV, string khoa, string que, string sdt, DateTime ngaySinh)
        { 
            txtIDStu.Text = maSV;
            txtID.Text = maDD;
            txtTen.Text = tenSV;
            cmbKhoa.Text = khoa;
            cmbQue.Text = que;
            txtSDT.Text = sdt;
            birthDateTimePicker.Value = ngaySinh;
        }
        private void StudentManagement_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoStuDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private DataTable SearchSinhVien(string maSV, string maDD, string tenSV, string khoa, string que, string sdt)
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSV = txtIDStu.Text;
            string maDD = txtID.Text;
            string tenSV = txtTen.Text;
            string khoa = cmbKhoa.Text;
            string que = cmbQue.Text;
            string sdt = txtSDT.Text;

            infoStuDataGridView.DataSource = SearchSinhVien(maSV, maDD, tenSV, khoa, que, sdt);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maDD = txtID.Text;
            string maSV = txtIDStu.Text;
            string newTenSV = txtTen.Text;
            string newKhoa = cmbKhoa.Text;
            string newQue = cmbQue.Text;
            DateTime newNgaySinh = birthDateTimePicker.Value;
            string newSDT = txtSDT.Text;
            UpdateInfoStudent(maDD, maSV, newTenSV, newKhoa, newQue, newSDT, newNgaySinh);
            InitializeDataGridView();
            
        }
        private void UpdateInfoStudent(string maDD, string maSV, string newTenSV, string newKhoa, string newQue, string newSDT, DateTime newNgaySinh)
        {
            try
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

 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (infoStuDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoStuDataGridView.SelectedRows[0];
                string maddToDelete = selectedRow.Cells["Madd"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                DeleteSinhVien(maddToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        private void DeleteSinhVien(string madd)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Sinh__vien WHERE Madd = @Madd", con))
            {
                cmd.Parameters.AddWithValue("@Madd", madd);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtIDStu.Text = "";
            txtTen.Text = "";
            cmbKhoa.Text = "";
            cmbQue.Text = "";
            birthDateTimePicker.Value = DateTime.Today;
            txtSDT.Text = "";
        }

        private void infoStuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
