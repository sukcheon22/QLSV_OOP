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
    public partial class frmTuitionOweAnalysis : Form
    {
        public frmTuitionOweAnalysis()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTuitionOweAnalysis_Load(object sender, EventArgs e)
        {
            txtNumStudentOwe.Text = Hoc_phiDAO.Instance.NumStudentOwe().ToString();
        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
