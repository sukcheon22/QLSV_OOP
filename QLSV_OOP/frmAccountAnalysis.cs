using System;
using System.Collections.Generic;
using System.ComponentModel;
using QLSV_OOP.DAO;
using QLSV_OOP.DTO;
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
    public partial class frmAccountAnalysis : Form
    {
        public frmAccountAnalysis()
        {
            InitializeComponent();
        }

        private void frmAccountAnalysis_Load(object sender, EventArgs e)
        {
            txtNumAdmin.Text = AccountDAO.Instance.NumAdmin().ToString();
            txtNumStudent.Text = AccountDAO.Instance.NumStudent().ToString();
            txtNumEduEmployee.Text = AccountDAO.Instance.NumEduEmployee().ToString();
            txtNumFinancialEmployee.Text = AccountDAO.Instance.NumFinancialEmployee().ToString();
            txtNumAcc.Text = AccountDAO.Instance.NumAccount().ToString();
            accDataGridView.DataSource = AccountDAO.Instance.accGridView();
            accDataGridView.CellPainting += accDataGridView_CellPainting;

        }

        private void accDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
    }
}
