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
    public partial class frmStudentAnalysis : Form
    {
        public frmStudentAnalysis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmStudentAnalysis_Load(object sender, EventArgs e)
        {
            txtNumCountK65.Text = Sinh_VienDAO.Instance.NumK65().ToString();
            txtNumCountK66.Text = Sinh_VienDAO.Instance.NumK66().ToString();
            txtNumCountK67.Text = Sinh_VienDAO.Instance.NumK67().ToString();
            txtNumCountK68.Text = Sinh_VienDAO.Instance.NumK68().ToString();
            txtNumCountStudent.Text = Sinh_VienDAO.Instance.NumStudent().ToString();
            studentDataGridView.DataSource = Sinh_VienDAO.Instance.accGridView();
        }

        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Xuất dữ liệu từ DataGridView
            for (int i = 0; i < studentDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = studentDataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < studentDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < studentDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = studentDataGridView[j, i].Value;
                }
            }
            
            int rowIndex = studentDataGridView.Rows.Count + 4;
            worksheet.Cells[rowIndex, 1] = "Thống kê số sinh viên theo khóa:";

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Khóa 65:";
            worksheet.Cells[rowIndex, 2] = Sinh_VienDAO.Instance.NumK65().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Khóa 66:";
            worksheet.Cells[rowIndex, 2] = Sinh_VienDAO.Instance.NumK66().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Khóa 67:";
            worksheet.Cells[rowIndex, 2] = Sinh_VienDAO.Instance.NumK67().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Khóa 68:";
            worksheet.Cells[rowIndex, 2] = Sinh_VienDAO.Instance.NumK68().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Tổng:";
            worksheet.Cells[rowIndex, 2] = Sinh_VienDAO.Instance.NumStudent().ToString();


            // Lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
            saveFileDialog.FileName = "SinhVien_ThongKe.xlsx";

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
