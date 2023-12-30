using System;
using System.Collections.Generic;
using System.ComponentModel;
using QLSV_OOP.DAO;
using QLSV_OOP.DTO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLSV_OOP
{
    public partial class frmEmployeeAnalysis : Form
    {
        public frmEmployeeAnalysis()
        {
            InitializeComponent();
        }

        private void frmEmployeeAnalysis_Load(object sender, EventArgs e)
        {
            txtNumEduEmployee.Text = Nhan_vienDAO.Instance.NumDaoTao().ToString();
            txtNumFinancialEmployee.Text = Nhan_vienDAO.Instance.NumTaiVu().ToString();
            txtNumEmployee.Text = Nhan_vienDAO.Instance.NumTong().ToString();
            empDataGridView.DataSource = Nhan_vienDAO.Instance.empGridView();
        }
        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Xuất dữ liệu từ DataGridView
            for (int i = 0; i < empDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = empDataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < empDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < empDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = empDataGridView[j, i].Value;
                }
            }

            // Thêm thông tin thống kê
            int rowIndex = empDataGridView.Rows.Count + 4;
            worksheet.Cells[rowIndex, 1] = "Thống kê số nhân viên theo phòng ban:";

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Nhân viên đào tạo:";
            worksheet.Cells[rowIndex, 2] = Nhan_vienDAO.Instance.NumDaoTao().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Nhân viên tài vụ:";
            worksheet.Cells[rowIndex, 2] = Nhan_vienDAO.Instance.NumTaiVu().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Tổng số nhân viên:";
            worksheet.Cells[rowIndex, 2] = Nhan_vienDAO.Instance.NumTong().ToString();


            // Lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
            saveFileDialog.FileName = "NhanVien_ThongKe.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
