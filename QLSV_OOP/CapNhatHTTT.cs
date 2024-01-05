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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLSV_OOP
{
    public partial class CapNhatHTTT : UserControl
    {
        public CapNhatHTTT()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtBank.Text = "";
            txtSTK.Text = "";
            InitializeDataGridView();
        }
        
        private void InitializeDataGridView()
        {
            TTdataGridView.DataSource = HTTTDAO.Instance.htttGridView();
        }

        private void CapNhatHTTT_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            TTdataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (TTdataGridView.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = TTdataGridView.SelectedRows[0];
                string nganhang = selectedRow.Cells["TenNH"].Value.ToString();
                string stk = selectedRow.Cells["STK"].Value.ToString();

                // Hiển thị thông tin trong GroupBox
                DisplayHTTTInfo(nganhang, stk);
            }
        }
        private void DisplayHTTTInfo(string nganhang, string stk)
        {
            // Hiển thị thông tin sinh viên trong GroupBox
            txtBank.Text = nganhang;
            txtSTK.Text = stk;
        }
        

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string bank = txtBank.Text;
            string stk = txtSTK.Text;

            TTdataGridView.DataSource = HTTTDAO.Instance.SearchHTTT(bank, stk);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string newbankname = txtBank.Text;
            string newSTK = txtSTK.Text;

            HTTTDAO.Instance.UpdateInfoTTInfo(newbankname, newSTK);

            InitializeDataGridView();
            
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (TTdataGridView.SelectedRows.Count > 0)
            {
                // Lấy giá trị cần xóa từ hàng được chọn
                DataGridViewRow selectedRow = TTdataGridView.SelectedRows[0];
                string stk = selectedRow.Cells["STK"].Value.ToString();

                // Gọi hàm DeleteTaiKhoan để thực hiện xóa từ CSDL
                HTTTDAO.Instance.DeleteHTTT(stk);

                // Cập nhật lại DataGridView sau khi xóa
                InitializeDataGridView();

                MessageBox.Show("Đã xóa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            string newBank = txtBank.Text;
            string newSTK = txtSTK.Text;

             HTTTDAO.Instance.AddHTTT(newBank, newSTK); 

            InitializeDataGridView();
        }
        

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            ResetState();
        }
    }
}
