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
            InitializeDataGridView();


        }
        private void InitializeDataGridView()
        {
            infoStuDataGridView.DataSource = Sinh_VienDAO.Instance.svGridView();
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoStuDataGridView.SelectedRows.Count == 1)
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSV = txtIDStu.Text;
            string maDD = txtID.Text;
            string tenSV = txtTen.Text;
            string khoa = cmbKhoa.Text;
            string que = cmbQue.Text;
            string sdt = txtSDT.Text;

            infoStuDataGridView.DataSource = Sinh_VienDAO.Instance.SearchSinhVien(maSV, maDD, tenSV, khoa, que, sdt);
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
            Sinh_VienDAO.Instance.UpdateInfoStudent(maDD, maSV, newTenSV, newKhoa, newQue, newSDT, newNgaySinh);
            InitializeDataGridView();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (infoStuDataGridView.SelectedRows.Count == 1)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoStuDataGridView.SelectedRows[0];
                string maddToDelete = selectedRow.Cells["Madd"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                Sinh_VienDAO.Instance.DeleteSinhVien(maddToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
 
        private void quaylai_Click(object sender, EventArgs e)
        {
            ResetState();
        }

        private void infoStuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
