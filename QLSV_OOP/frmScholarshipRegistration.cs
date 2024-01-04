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
    public partial class frmScholarshipRegistration : Form
    {
        string MaSV;
        public frmScholarshipRegistration(Sinh_Vien sinhVien)
        {
            InitializeComponent();
            empDataGridView.DataSource = classGridView(sinhVien.StudentID);
            MaSV = sinhVien.StudentID;
        }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        private DataTable classGridView(string maSV)
        {
            string query = "select Tinh_trang_HB.MaHB as \"Mã học bổng\", TenHB as \"Tên học bổng\", Loai as \"Loại\" from Tinh_trang_HB "+
                           "inner join HB on Tinh_trang_HB.MaHB = HB.MaHB " +
                           "where MaSV = "+ maSV +";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeDataGridView()
        {
            empDataGridView.DataSource = classGridView(MaSV);
        }

        private void DangKyMoi(string maHB, string maSV)
        {
            try
            {
                if (HBDAO.Instance.KiemTraTrung(maSV, maHB))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Tinh_trang_HB (MaSV, MaHB, TinhTrang) VALUES ('" + maSV + "', '" + maHB + "','False')", con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                    MessageBox.Show("Đã đăng ký học bổng thành công!");
                }
                
                else 
                {
                    MessageBox.Show("Học bổng đã được đăng ký", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                if (ex.Number == 547)  // 547 là mã lỗi cho việc vi phạm khóa ngoại
                {
                    MessageBox.Show("Mã học bổng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maHB = txtScholarshipID.Text;
            string maSV = MaSV;
            DangKyMoi(maHB, maSV);
            InitializeDataGridView();
        }



        private void empDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void XoaHocBong(string maHB, string maSV)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Tinh_trang_HB WHERE MaSV = '" + maSV + "' AND MaHB = '" + maHB + "'", con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private bool CheckXoa(string maHB, string maSV)
        {
            string query = "select TinhTrang from Tinh_trang_HB where MaSV = '" + maSV + "' and MaHB = '" + maHB + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToBoolean(dt.Rows[0][0]);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (empDataGridView.SelectedRows.Count > 0)
                {
                    // Lấy giá trị cần xóa từ hàng được chọn
                    DataGridViewRow selectedRow = empDataGridView.SelectedRows[0];
                    string maHB = selectedRow.Cells["Mã học bổng"].Value.ToString();
                    if (CheckXoa(maHB, MaSV))
                    {
                        MessageBox.Show("Học bổng đã được duyệt, không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        XoaHocBong(maHB, MaSV);
                        InitializeDataGridView();
                        MessageBox.Show("Đã xóa thông tin thành công!");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa!");
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

        private void frmScholarshipRegistration_Load(object sender, EventArgs e)
        {

        }

        private void frmScholarshipRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
