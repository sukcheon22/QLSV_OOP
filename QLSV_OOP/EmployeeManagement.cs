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
    public partial class EmployeeManagement : UserControl
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtID.Text = "";
            txtTen.Text = "";
            txtIDNhanVien.Text = "";
            txtSDT.Text = "";
            cmbViTri.Text = "";
            cmbQue.Text = "";
            infoNVDataGridView.DataSource = Nhan_vienDAO.Instance.empGridView();


        }
        public DataTable infoNVGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Nhan_vien", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            infoNVDataGridView.DataSource = this.infoNVGridView();
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoNVDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = infoNVDataGridView.SelectedRows[0];
                string maNV = selectedRow.Cells["MaNV"].Value.ToString();
                string maDD = selectedRow.Cells["MaDD"].Value.ToString();
                string tenNV = selectedRow.Cells["TenNV"].Value.ToString();
                string vitri = selectedRow.Cells["ViTri"].Value.ToString();
                string que = selectedRow.Cells["Que"].Value.ToString();
                string sdt = selectedRow.Cells["SDT"].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                DisplayEmployeeInfo(maNV, maDD, tenNV, vitri, que, sdt, ngaySinh);
            }
        }

        private void DisplayEmployeeInfo(string maNV, string maDD, string tenNV, string vitri, string que, string sdt, DateTime ngaySinh)
        {
            txtIDNhanVien.Text = maNV;
            txtID.Text = maDD;
            txtTen.Text = tenNV;
            cmbViTri.Text = vitri;
            cmbQue.Text = que;
            txtSDT.Text = sdt;
            birthDateTimePicker.Value = ngaySinh;
        }
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoNVDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private DataTable SearchNhanVien(string maNV, string maDD, string tenNV, string vitri, string que, string sdt)
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maNV = txtIDNhanVien.Text;
            string maDD = txtID.Text;
            string tenNV = txtTen.Text;
            string vitri = cmbViTri.Text;
            string que = cmbQue.Text;
            string sdt = txtSDT.Text;

            infoNVDataGridView.DataSource = SearchNhanVien(maNV, maDD, tenNV, vitri, que, sdt);
        }
        private bool IsMaNhanVienExist(string maNV)
        {
            // Kiểm tra xem mã nhân viên đã tồn tại hay chưa
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Nhan_vien WHERE MaNV = @MaNV", con))
            {
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                return count > 0;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maDD = txtID.Text;
            string maNV = txtIDNhanVien.Text;
            string newTenNV = txtTen.Text;
            string newViTri = cmbViTri.Text;
            string newQue = cmbQue.Text;
            DateTime newNgaySinh = birthDateTimePicker.Value;
            string newSDT = txtSDT.Text;

            UpdateInfoEmployee(maDD, maNV, newTenNV, newViTri, newQue, newSDT, newNgaySinh);
            InitializeDataGridView();

        }
        private void UpdateInfoEmployee(string maDD, string maNV, string newTenNV, string newViTri, string newQue, string newSDT, DateTime newNgaySinh)
        {
            try
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
            if (infoNVDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoNVDataGridView.SelectedRows[0];
                string maddToDelete = selectedRow.Cells["Madd"].Value.ToString();

                
                DeleteNhanVien(maddToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        private void DeleteNhanVien(string madd)
        {
            // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ CSDL
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Nhan_vien WHERE Madd = @Madd", con))
            {
                cmd.Parameters.AddWithValue("@Madd", madd);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            XoaTaiKhoanNhanVien(madd);
        }
        private void XoaTaiKhoanNhanVien(string madd)
        {
            
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Tai_khoan WHERE MaDD = @Madd", con))
            {
                cmd.Parameters.AddWithValue("@Madd", madd);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void quayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }
    }
}
