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
    public partial class frmTuitionOweAnalysis : Form
    {
        public frmTuitionOweAnalysis()
        {
            InitializeComponent();
        }
      

        private void frmTuitionOweAnalysis_Load(object sender, EventArgs e)
        {
            txtNumStudentOwe.Text = Hoc_phiDAO.Instance.NumStudentOwe();
            tuitionOweDataGridView.DataSource = Hoc_phiDAO.Instance.tuitionoweGridView();
        }
        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Xuất dữ liệu từ DataGridView
            for (int i = 0; i < tuitionOweDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = tuitionOweDataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < tuitionOweDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < tuitionOweDataGridView.Columns.Count; j++)
                {
                    // Kiểm tra nếu cột là MaSV (giả sử là cột đầu tiên, điều chỉnh nếu cần)
                    if (tuitionOweDataGridView.Columns[j].Name == "MaSV")
                    {
                        // Thiết lập định dạng ô là Văn bản cho cột MaSV
                        worksheet.Cells[i + 2, j + 1].NumberFormat = "@";

                        // In giá trị của cột MaSV để kiểm tra
                        Console.WriteLine(tuitionOweDataGridView[j, i].Value);
                    }

                    // Ghi giá trị của ô vào bảng tính Excel
                    worksheet.Cells[i + 2, j + 1] = tuitionOweDataGridView[j, i].Value;
                }
            }

            
            // Lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
            saveFileDialog.FileName = "NoHocPhi_ThongKe.xlsx";

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
