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
    public partial class frmScholarshipAnalysis : Form
    {
        public frmScholarshipAnalysis()
        {
            InitializeComponent();
        }
        private void frmScholarshipAnalysis_Load(object sender, EventArgs e)
        {
            txtNumCompany.Text = HBDAO.Instance.NumCompany().ToString();
            txtNumUni.Text = HBDAO.Instance.NumUni().ToString();
            txtNumScholarship.Text = HBDAO.Instance.NumScholarship().ToString();
            txtStudentCompany.Text = HBDAO.Instance.StudentCompany().ToString();
            txtStudentUni.Text = HBDAO.Instance.StudentUni().ToString();           
            txtNumScholarshipOK.Text = HBDAO.Instance.NumScholarshipOK().ToString();

            scholarshipDataGridView.DataSource = HBDAO.Instance.scholarshipGridView();
        }
        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Xuất dữ liệu từ DataGridView
            for (int i = 0; i < scholarshipDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = scholarshipDataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < scholarshipDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < scholarshipDataGridView.Columns.Count; j++)
                {
                    // Kiểm tra nếu cột là MaSV (giả sử là cột đầu tiên, điều chỉnh nếu cần)
                    if (scholarshipDataGridView.Columns[j].Name == "MaSV")
                    {
                        // Thiết lập định dạng ô là Văn bản cho cột MaSV
                        worksheet.Cells[i + 2, j + 1].NumberFormat = "@";

                        // In giá trị của cột MaSV để kiểm tra
                        Console.WriteLine(scholarshipDataGridView[j, i].Value);
                    }

                    // Ghi giá trị của ô vào bảng tính Excel
                    worksheet.Cells[i + 2, j + 1] = scholarshipDataGridView[j, i].Value;
                }
            }

            // Thêm thông tin thống kê
            int rowIndex = scholarshipDataGridView.Rows.Count + 4;
            worksheet.Cells[rowIndex, 1] = "Thống kê học bổng:";

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Số doanh nghiệp cấp học bổng:";
            worksheet.Cells[rowIndex, 2] = HBDAO.Instance.NumCompany().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Số trường đại học cấp học bổng trao đổi:";
            worksheet.Cells[rowIndex, 2] = HBDAO.Instance.NumUni().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Tổng số học bổng: ";
            worksheet.Cells[rowIndex, 2] = HBDAO.Instance.NumScholarship().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Số học bổng doanh nghiệp đã đạt:";
            worksheet.Cells[rowIndex, 2] = HBDAO.Instance.StudentCompany().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Số học bổng trao đổi đã đạt:";
            worksheet.Cells[rowIndex, 2] = HBDAO.Instance.StudentUni().ToString();

            rowIndex++;
            worksheet.Cells[rowIndex, 1] = "Tổng số học bổng đã đạt:";
            worksheet.Cells[rowIndex, 2] = HBDAO.Instance.NumScholarshipOK().ToString();


            // Lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
            saveFileDialog.FileName = "HocBong_ThongKe.xlsx";

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
