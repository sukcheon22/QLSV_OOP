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
    public partial class frmGradeAnalysis : Form
    {
        public frmGradeAnalysis()
        {
            InitializeComponent();
        }

        private void frmGradeAnalysis_Load(object sender, EventArgs e)
        {
            txtNumExcellent.Text = KQHTDAO.Instance.NumExcellent().ToString();
            txtNumGood.Text = KQHTDAO.Instance.NumGood().ToString();
            txtNumWell.Text = KQHTDAO.Instance.NumWell().ToString();
            txtNumBad.Text = KQHTDAO.Instance.NumBad().ToString();
            gradeDataGridView.DataSource = KQHTDAO.Instance.gradeGridView();
        }
        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Xuất dữ liệu từ DataGridView
            for (int i = 0; i < gradeDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = gradeDataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < gradeDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < gradeDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = gradeDataGridView[j, i].Value;
                }
            }

            // Thêm thông tin thống kê
            int rowIndex = gradeDataGridView.Rows.Count + 4;
            worksheet.Cells[rowIndex, 1] = "Thống kê số sinh viên theo điểm trung bình:";

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Xuất sắc:";
            worksheet.Cells[rowIndex, 2] = KQHTDAO.Instance.NumExcellent().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Giỏi:";
            worksheet.Cells[rowIndex, 2] = KQHTDAO.Instance.NumGood().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Khá:";
            worksheet.Cells[rowIndex, 2] = KQHTDAO.Instance.NumWell().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Trung bình:";
            worksheet.Cells[rowIndex, 2] = KQHTDAO.Instance.NumBad().ToString();

            
            // Lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
            saveFileDialog.FileName = "Diem_ThongKe.xlsx";

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
