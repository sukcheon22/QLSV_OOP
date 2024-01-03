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
using QLSV_OOP.DTO;
using QLSV_OOP.DAO;

namespace QLSV_OOP
{
    public partial class frmClassRegistration : Form
    {
        string MaSV;
        public frmClassRegistration(Sinh_Vien sinhVien)
        {
            
            InitializeComponent();
            empDataGridView.DataSource = classGridView(sinhVien.StudentID);
            MaSV = sinhVien.StudentID;
        }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        private DataTable classGridView(string maSV)
        {
            string query = "select Lop_hoc.MaLH as \"Mã lớp học\",TenHP as \"Tên học phần\", Hoc_phan.MaHP as \"Mã học phần\", KhoiLuong as \"Số tín chỉ\", BatDau as \"Bắt đầu\", KetThuc as \"Kết thúc\", Thu as \"Thứ\" from Hoc_phan " +
                "inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                "inner join Dang_ky on Dang_ky.MaLH = Lop_hoc.MaLH " +
                "where MaSV = " + maSV + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void InitializeDataGridView()
        {
            empDataGridView.DataSource = classGridView(MaSV);
        }

        
        private void frmClassRegistration_Load(object sender, EventArgs e)
        {

        }

        private void empDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maLH = txtChoose.Text;
            string maSV = MaSV;
            DangKyMoi(maLH, maSV);
            InitializeDataGridView();
        }

        private void DangKyMoi(string maLop, string maSV)
        {
            try
            {
                string query = "select KhoiLuong from Hoc_phan " +
                               "inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                               "where MaLH = " + maLop + ";";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int khoiLuong = Convert.ToInt32(dt.Rows[0][0]);
                if (Lop_hocDAO.Instance.CountTinChi(maSV) + khoiLuong <= 24 && Lop_hocDAO.Instance.KiemTraTrung(maSV, maLop)) 
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Dang_ky (MaSV, MaLH) VALUES ('" + maSV +"', '"+ maLop +"')", con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    
                        con.Close();
                    }
                    MessageBox.Show("Đã đăng ký thêm lớp học mới thành công!");
                }
                else if (Lop_hocDAO.Instance.CountTinChi(maSV) + khoiLuong > 24)
                {
                    MessageBox.Show("Số tín đăng ký đã vượt quá 24 tín chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Lop_hocDAO.Instance.KiemTraTrung(maSV, maLop))
                {
                    MessageBox.Show("Lớp học đã được đăng ký", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 547)  // 547 là mã lỗi cho việc vi phạm khóa ngoại
                {
                    MessageBox.Show("Mã lớp học không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void XoaLopHoc(string maLH, string maSV)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Dang_ky WHERE MaLH = " + maLH + " AND MaSV = " + maSV, con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (empDataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = empDataGridView.SelectedRows[0];
                string maLH = selectedRow.Cells["Mã lớp học"].Value.ToString();

                
                XoaLopHoc(maLH, MaSV);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
