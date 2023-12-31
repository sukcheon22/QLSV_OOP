﻿using System;
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
using Microsoft.Office.Core;

namespace QLSV_OOP
{
    public partial class frmClassAnalysis : Form
    {
        public frmClassAnalysis()
        {
            InitializeComponent();
        }
        private void frmClassAnalysis_Load(object sender, EventArgs e)
        {
            classDataGridView.DataSource = Lop_hocDAO.Instance.classGridView();
        }
        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Sheets[1];

                // Xuất dữ liệu từ DataGridView
                for (int i = 0; i < classDataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = classDataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < classDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < classDataGridView.Columns.Count; j++)
                    {
                        if (j == 4 || j == 5) 
                        {
                            
                            if (classDataGridView[j, i].Value != null)
                            {
                                
                                DateTime timeValue = DateTime.Parse(classDataGridView[j, i].Value.ToString());
                                worksheet.Cells[i + 2, j + 1] = timeValue.ToString("HH:mm:ss");
                            }
                        }
                        else
                        {
                            // Xuất giá trị không phải thời gian
                            worksheet.Cells[i + 2, j + 1] = classDataGridView[j, i].Value;
                        }
                    }
                }

                // Lưu file Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
                saveFileDialog.FileName = "LopHoc_ThongKe.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void classDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
