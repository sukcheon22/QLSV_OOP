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
using QLSV_OOP.DAO;
using QLSV_OOP.DTO;
namespace QLSV_OOP
{
    public partial class TTinDuNo : UserControl
    {
        public TTinDuNo(string maSV)
        {
            InitializeComponent();
            txbTTinDuNo.Text = Hoc_phiDAO.Instance.DuNoHphi(maSV).ToString();

        }
        private void txbTTinDuNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
