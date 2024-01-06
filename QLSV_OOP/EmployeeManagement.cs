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
using System.Security.Cryptography;

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
            InitializeDataGridView();


        }
        
        private void InitializeDataGridView()
        {
            infoNVDataGridView.DataSource = Nhan_vienDAO.Instance.empGridView();
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoNVDataGridView.SelectedRows.Count == 1)
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
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maNV = txtIDNhanVien.Text;
            string maDD = txtID.Text;
            string tenNV = txtTen.Text;
            string vitri = cmbViTri.Text;
            string que = cmbQue.Text;
            string sdt = txtSDT.Text;
            infoNVDataGridView.DataSource = Nhan_vienDAO.Instance.SearchNhanVien(maNV, maDD, tenNV, vitri, que, sdt);
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

            Nhan_vienDAO.Instance.UpdateInfoEmployee(maDD, maNV, newTenNV, newViTri, newQue, newSDT, newNgaySinh);
            InitializeDataGridView();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (infoNVDataGridView.SelectedRows.Count == 1)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoNVDataGridView.SelectedRows[0];
                string maddToDelete = selectedRow.Cells["Madd"].Value.ToString();

                
                Nhan_vienDAO.Instance.DeleteNhanVien(maddToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        private void quayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }
    }
}
