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
            empDataGridView.DataSource = Dang_kyDAO.Instance.classGridView(sinhVien.StudentID);
            MaSV = sinhVien.StudentID;
        }


        private void InitializeDataGridView()
        {
            empDataGridView.DataSource = Dang_kyDAO.Instance.classGridView(MaSV);
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
            Dang_kyDAO.Instance.DangKyMoi(maLH, maSV);
            InitializeDataGridView();
        }

 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (empDataGridView.SelectedRows.Count == 1)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = empDataGridView.SelectedRows[0];
                string maLH = selectedRow.Cells["Mã lớp học"].Value.ToString();

                
                Dang_kyDAO.Instance.XoaLopHoc(maLH, MaSV);

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

        private void txtChoose_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
