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
    public partial class frmAccountAnalysis : Form
    {
        public frmAccountAnalysis()
        {
            InitializeComponent();
        }

        private void frmAccountAnalysis_Load(object sender, EventArgs e)
        {
            txtNumAdmin.Text = AccountDAO.Instance.NumAdmin().ToString();
            txtNumStudent.Text = AccountDAO.Instance.NumStudent().ToString();
            txtNumEduEmployee.Text = AccountDAO.Instance.NumEduEmployee().ToString();
            txtNumFinancialEmployee.Text = AccountDAO.Instance.NumFinancialEmployee().ToString();
            txtNumAcc.Text = AccountDAO.Instance.NumAccount().ToString();
            accDataGridView.DataSource = AccountDAO.Instance.accGridView();
            

        }

        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Xuất dữ liệu từ DataGridView
            for (int i = 0; i < accDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = accDataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < accDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < accDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = accDataGridView[j, i].Value;
                }
            }

            // Thêm thông tin thống kê
            int rowIndex = accDataGridView.Rows.Count + 4;
            worksheet.Cells[rowIndex, 1] = "Thống kê số tài khoản theo loại:";

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Admin:";
            worksheet.Cells[rowIndex, 2] = AccountDAO.Instance.NumAdmin().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Sinh viên:";
            worksheet.Cells[rowIndex, 2] = AccountDAO.Instance.NumStudent().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Nhân viên đào tạo:";
            worksheet.Cells[rowIndex, 2] = AccountDAO.Instance.NumEduEmployee().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Nhân viên tài vụ:";
            worksheet.Cells[rowIndex, 2] = AccountDAO.Instance.NumEduEmployee().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Tổng:";
            worksheet.Cells[rowIndex, 2] = AccountDAO.Instance.NumAccount().ToString();


            // Lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
            saveFileDialog.FileName = "DanhSachTaiKhoan_ThongKe.xlsx";

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
