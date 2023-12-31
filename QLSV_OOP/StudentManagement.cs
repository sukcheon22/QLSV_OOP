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
    public partial class StudentManagement : UserControl
    {
        public StudentManagement()
        {
            InitializeComponent();
        }
        public void ResetState()
        {
            txtID.Text = "";
            txtTen.Text = "";
            txtIDStu.Text = "";
            txtSDT.Text = "";
            cmbKhoa.Text = "";
            cmbQue.Text = "";
            infoStuDataGridView.DataSource = null;


        }
    }
}
