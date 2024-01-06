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
using QLSV_OOP.DAO;

namespace QLSV_OOP
{
    public partial class CapNhatDiem : UserControl
    {
        public CapNhatDiem()
        {
            InitializeComponent();
            
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            cmbMaHP.Text = "";
            txtMaSV.Text = "";
            cmbDiem.Text = "";
            InitializeDataGridView();
            LoadDataIntoComboBox();
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
        
        
        private void InitializeDataGridView()
        {
            infoGradeDataGridView.DataSource = KQHTDAO.Instance.gradeGridView();
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoGradeDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = infoGradeDataGridView.SelectedRows[0];
                string maSV  = selectedRow.Cells["MaSV"].Value.ToString();
                string maHP = selectedRow.Cells["MaHP"].Value.ToString();
                string diem = selectedRow.Cells["Diem"].Value.ToString();
                DisplayGradeInfo(maSV, maHP, diem);
            }
        }

        private void DisplayGradeInfo(string maSV, string maHP, string diem)
        {
            cmbDiem.Text = diem;
            cmbMaHP.Text = maHP;
            txtMaSV.Text = maSV;
        }

        private void CapNhatDiem_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
            InitializeDataGridView();
            infoGradeDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
        

        private void btnTimKiemKQHT_Click(object sender, EventArgs e)
        {
            string maHP = cmbMaHP.Text;
            string maSV = txtMaSV.Text;
            string diem = cmbDiem.Text;

            // Gọi hàm tìm kiếm và đặt kết quả vào DataGridView
            infoGradeDataGridView.DataSource = KQHTDAO.Instance.SearchKQHT(maHP, maSV, diem);
        }


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }
        private void btnSuaKQHT_Click(object sender, EventArgs e)
        {
            string maHP = cmbMaHP.Text;
            string maSV = txtMaSV.Text;
            string diem = cmbDiem.Text;

            KQHTDAO.Instance.CapNhatThongTinKQHT(maHP, maSV, diem);
            InitializeDataGridView(); 
        }

        
        private void btnThemKQHT_Click(object sender, EventArgs e)
        {
            string maHP = cmbMaHP.Text;
            string maSV = txtMaSV.Text;
            string diem = cmbDiem.Text;

            // Gọi hàm để thêm mới KQHT
            KQHTDAO.Instance.ThemKQHTMoi(maHP, maSV, diem);

            // Làm mới DataGridView hoặc thực hiện các bước khác cần thiết
            InitializeDataGridView();
        }

        
        private void btnXoaKQHT_Click(object sender, EventArgs e)
        {
            if (infoGradeDataGridView.SelectedRows.Count == 1)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = infoGradeDataGridView.SelectedRows[0];
                string maHPToDelete = selectedRow.Cells["MaHP"].Value.ToString();
                string maSVToDelete = selectedRow.Cells["MaSV"].Value.ToString();

                // Gọi hàm DeleteKQHT để thực hiện xóa từ CSDL
                KQHTDAO.Instance.DeleteKQHT(maHPToDelete, maSVToDelete);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin KQHT thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }

        

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
