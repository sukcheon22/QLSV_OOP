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
            txtNumTuition.Text = HBDAO.Instance.NumTuition().ToString();
            txtStudentCompany.Text = HBDAO.Instance.StudentCompany().ToString();
            txtStudentUni.Text = HBDAO.Instance.StudentUni().ToString();
            // Lấy giá trị từ txtStudentCompany và txtStudentUni, sau đó chuyển đổi sang kiểu số nguyên
            int studentCompany = int.Parse(txtStudentCompany.Text);
            int studentUni = int.Parse(txtStudentUni.Text);

            // Tính tổng của hai giá trị
            int totalTuitionOK = studentCompany + studentUni;

            // Gán giá trị tổng vào txtNumTuitionOK
            txtNumTuitionOK.Text = totalTuitionOK.ToString();

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
                    worksheet.Cells[i + 2, j + 1] = scholarshipDataGridView[j, i].Value;
                }
            }


        }
    }
}
