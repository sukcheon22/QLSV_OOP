using QLSV_OOP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
