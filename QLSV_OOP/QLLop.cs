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
            InitializeDataGridView();
            LoadDataIntoComboBox();
        }
        
        private void InitializeDataGridView()
        {
            infoLopDataGridView.DataSource = Lop_hocDAO.Instance.classGridView();
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoLopDataGridView.SelectedRows.Count == 1)
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

        
        private void LoadDataIntoComboBox()
        {
            // Gọi hàm để lấy DataTable từ cơ sở dữ liệu
            DataTable hocPhanDataTable = Hoc_phanDAO.Instance.GetHocPhanDataForComboBox();

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
            infoLopDataGridView.DataSource = Lop_hocDAO.Instance.SearchLopHoc(maLop, maHocPhan, soTiet, soLuong, batDau, ketThuc, thu);
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
            Lop_hocDAO.Instance.UpdateInfoLopHoc(maLH, maHP, soTiet, soLuong, batDau, ketThuc, thu);
            InitializeDataGridView();

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
             Lop_hocDAO.Instance.ThemLopHocMoi(maLH, maHP, soTiet, soLuong, batDau, ketThuc, thu);

            // Làm mới DataGridView hoặc thực hiện các bước khác cần thiết
            InitializeDataGridView();
        }

        
        private void btnXoaLopHoc_Click(object sender, EventArgs e)
        {
            if (infoLopDataGridView.SelectedRows.Count == 1)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoLopDataGridView.SelectedRows[0];
                string maLopToDelete = selectedRow.Cells["MaLH"].Value.ToString();

                // Gọi hàm DeleteLopHoc để thực hiện xóa từ CSDL
                Lop_hocDAO.Instance.DeleteLopHoc(maLopToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin lớp học thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }

        


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }

        private void cmbMaHP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void infoLopDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
