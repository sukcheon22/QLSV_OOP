using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_OOP
{
    public partial class frmPhanQuyen : Form
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            cmbMaQuyen.Text = "";
            infoQuyenDataGridView.DataSource = RoleDAO.quyenGridView();
        }
        public DataTable infoQuyenGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from quyen", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            infoQuyenDataGridView.DataSource = this.infoQuyenGridView();
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoQuyenDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = infoQuyenDataGridView.SelectedRows[0];
                string maQuyen = selectedRow.Cells["MaQuyen"].Value.ToString();
                cmbMaQuyen.Text = maQuyen;

                // Đặt giá trị cho CheckedListBox dựa trên tên cột
                foreach (string quyenColumnName in new[] { "CapNhatDiem", "DangKyLop", "TraCuuTKB", "TraKQHT",
                                    "CapNhatHB", "PheDuyetHB", "DangKyHB", "CapNhatTTTT",
                                    "CapNhatCongNo", "KtraDuNo", "TkeHocPhi", "TkeNoHPhi", "TkeDiem", "TkeHB", "TkeLopHoc", "TkeHTTT" })
                {
                    // Ánh xạ tên cột trong checkedListBoxQuyen sang tên cột trong cơ sở dữ liệu
                    string databaseColumnName = MapColumnName(quyenColumnName);

                    // Kiểm tra xem có phải là tên cột hợp lệ hay không
                    if (!string.IsNullOrEmpty(databaseColumnName))
                    {
                        int columnIndex = checkedListBoxQuyen.Items.IndexOf(quyenColumnName);

                        // Lấy giá trị trực tiếp từ DataGridView và đặt checked cho item tương ứng trong checkedListBoxQuyen
                        bool isChecked = Convert.ToBoolean(selectedRow.Cells[databaseColumnName].Value);
                        checkedListBoxQuyen.SetItemChecked(columnIndex, isChecked);
                    }
                }
            }
        }
        private string MapColumnName(string checkedListBoxColumnName)
        {
            // Thực hiện ánh xạ tên cột, ví dụ: "Thong Ke Hoc Phi" -> "TkeHocPhi"
            switch (checkedListBoxColumnName)
            {
                case "Cập nhật điểm":
                    return "CapNhatDiem";
                case "Đăng ký lớp":
                    return "DangKyLop";
                case "Tra cứu TKB":
                    return "TraCuuTKB";
                case "Tra cứu KQHT":
                    return "TraKQHT";
                case "":
                    
                default:
                    return checkedListBoxColumnName;
            }
        }


        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoQuyenDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }
    }
}
