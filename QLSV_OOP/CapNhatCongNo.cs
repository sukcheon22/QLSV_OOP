using QLSV_OOP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_OOP
{
    public partial class CapNhatCongNo : UserControl
    {
        public CapNhatCongNo()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtPaidID.Text = "";
            txtStudentID.Text = "";
            txtMoney.Text = "";
            txtSTK.Text = "";
            boxBank.Text = "";
            tuitionDataGridView.DataSource = Hoc_phiDAO.Instance.tuitionGridView();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
