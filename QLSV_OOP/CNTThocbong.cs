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
    public partial class CNTThocbong : UserControl
    {
        public CNTThocbong()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtMaHB.Text = "";
            txtTenHB.Text = "";
            infoHBDataGridView.DataSource = Tinh_trangHBDAO.Instance.HBGridView();
            
        }
        public DataTable infoHBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from HB", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            infoHBDataGridView.DataSource = this.infoHBGridView();
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoHBDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = infoHBDataGridView.SelectedRows[0];
                string maHB = selectedRow.Cells["MaHB"].Value.ToString();
                string tenHB = selectedRow.Cells["TenHB"].Value.ToString();
                string loai = selectedRow.Cells["Loai"].Value.ToString();
                DisplayHBInfo(maHB, tenHB, loai);
            }
        }

        private void DisplayHBInfo(string maHB, string tenHB, string loai)
        {
            txtMaHB.Text = maHB;
            txtTenHB.Text = tenHB;
            cmbLoaiHB.Text = loai;
        }
        private void CNTThocbong_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoHBDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
    }
}
