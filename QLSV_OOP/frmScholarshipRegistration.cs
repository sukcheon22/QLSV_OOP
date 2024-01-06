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
            empDataGridView.DataSource = Tinh_trangHBDAO.Instance.classGridView(sinhVien.StudentID);
            MaSV = sinhVien.StudentID;
        }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeDataGridView()
        {
            empDataGridView.DataSource = Tinh_trangHBDAO.Instance.classGridView(MaSV);
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maHB = txtScholarshipID.Text;
            string maSV = MaSV;
            Tinh_trangHBDAO.Instance.DangKyMoi(maHB, maSV);
            InitializeDataGridView();
        }



        private void empDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (empDataGridView.SelectedRows.Count == 1)
                {
                    // Lấy giá trị cần xóa từ hàng được chọn
                    DataGridViewRow selectedRow = empDataGridView.SelectedRows[0];
                    string maHB = selectedRow.Cells["Mã học bổng"].Value.ToString();
                    if (Tinh_trangHBDAO.Instance.CheckXoa(maHB, MaSV))
                    {
                        MessageBox.Show("Học bổng đã được duyệt, không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Tinh_trangHBDAO.Instance.XoaHocBong(maHB, MaSV);
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

        
    }
}
