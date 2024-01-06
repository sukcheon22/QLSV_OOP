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
    public partial class CNTThocbong : UserControl
    {
        public CNTThocbong()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtMaHB.Text = "";
            txtTenHB.Text = "";
            cmbLoaiHB.Text = "";
            InitializeDataGridView();
            
        }
        
        private void InitializeDataGridView()
        {
            infoHBDataGridView.DataSource = HBDAO.Instance.HBGridView();
        }
        private void CNTThocbong_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoHBDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoHBDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = infoHBDataGridView.SelectedRows[0];
                string maHB = selectedRow.Cells["MaHB"].Value.ToString();
                string tenHB = selectedRow.Cells["TenHB"].Value.ToString();
                string loai = selectedRow.Cells["Loai"].Value.ToString();
                DisplayHBInfo(maHB, tenHB, loai);
            }
        }

        private void DisplayHBInfo(string maHB, string tenHB, string loai)
        {
            txtMaHB.Text = maHB;
            txtTenHB.Text = tenHB;
            cmbLoaiHB.Text = loai;
        }
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHB = txtMaHB.Text;
            string tenHB = txtTenHB.Text;
            string loai = cmbLoaiHB.Text;

            infoHBDataGridView.DataSource = Tinh_trangHBDAO.Instance.SearchHB(maHB, tenHB, loai);
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            string newmaHB = txtMaHB.Text;
            string newtenHB = txtTenHB.Text;
            string newloai = cmbLoaiHB.Text;

            Tinh_trangHBDAO.Instance.UpdateHBInfo(newmaHB, newtenHB, newloai);
            InitializeDataGridView();
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (infoHBDataGridView.SelectedRows.Count == 1)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoHBDataGridView.SelectedRows[0];
                string hbToDelete = selectedRow.Cells["MaHB"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                Tinh_trangHBDAO.Instance.DeleteHB(hbToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            string newmaHB = txtMaHB.Text;
            string newtenHB = txtTenHB.Text;
            string newloai = cmbLoaiHB.Text;

            Tinh_trangHBDAO.Instance.AddHBInfo(newmaHB, newtenHB, newloai);

            InitializeDataGridView();
        }
        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }



    }
}
