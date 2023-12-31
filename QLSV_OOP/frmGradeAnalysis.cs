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
            txtNumFailed.Text = KQHTDAO.Instance.NumFailed().ToString();
            txtNumPassed.Text = KQHTDAO.Instance.NumPassed().ToString();
            gradeDataGridView.DataSource = KQHTDAO.Instance.gradeGridView();
        }
    }
}
