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
    public partial class frmTuitionAnalysis : Form
    {
        public frmTuitionAnalysis()
        {
            InitializeComponent();
        }  
        
        private void frmTuitionAnalysis_Load(object sender, EventArgs e)
        {
            txtSumMoney.Text = Hoc_phiDAO.Instance.SumMoney().ToString();
            txtMostBank.Text = Hoc_phiDAO.Instance.MostBank().ToString();
            tuitionDataGridView.DataSource = Hoc_phiDAO.Instance.tuitionGridView();
        }
        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Xuất dữ liệu từ DataGridView
            for (int i = 0; i < tuitionDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = tuitionDataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < tuitionDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < tuitionDataGridView.Columns.Count; j++)
                {
                    // Kiểm tra nếu cột là MaSV (giả sử là cột đầu tiên, điều chỉnh nếu cần)
                    if (tuitionDataGridView.Columns[j].Name == "MaSV")
                    {
                        // Thiết lập định dạng ô là Văn bản cho cột MaSV
                        worksheet.Cells[i + 2, j + 1].NumberFormat = "@";

                        // In giá trị của cột MaSV để kiểm tra
                        Console.WriteLine(tuitionDataGridView[j, i].Value);
                    }

                    // Ghi giá trị của ô vào bảng tính Excel
                    worksheet.Cells[i + 2, j + 1] = tuitionDataGridView[j, i].Value;
                }
            }

            // Thêm thông tin thống kê
            int rowIndex = tuitionDataGridView.Rows.Count + 4;
            worksheet.Cells[rowIndex, 1] = "Thống kê học phí:";

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Tổng số tiền đã nộp về:";
            worksheet.Cells[rowIndex, 2] = Hoc_phiDAO.Instance.SumMoney().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Ngân hàng được sinh viên sử dụng nhiều nhất:";
            worksheet.Cells[rowIndex, 2] = Hoc_phiDAO.Instance.MostBank().ToString();

            


            // Lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
            saveFileDialog.FileName = "HocPhi_ThongKe.xlsx";

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
