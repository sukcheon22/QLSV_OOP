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
            txtMaQuyen.Text = "";
            infoQuyenDataGridView.DataSource = RoleDAO.quyenGridView();
        }
        public DataTable infoQuyenGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM quyen) AS temp WHERE RowNum >= 2", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            // Bỏ cột thứ 2 (index 1)
            if (dt.Columns.Count > 1)
            {
                dt.Columns.RemoveAt(1);
            }

            return dt;
        }
        private void InitializeDataGridView()
        {
            infoQuyenDataGridView.DataSource = this.infoQuyenGridView();
        }
        private bool[] currentCheckedStates;
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (infoQuyenDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = infoQuyenDataGridView.SelectedRows[0];
                string maQuyen = selectedRow.Cells["MaQuyen"].Value.ToString();
                txtMaQuyen.Text = maQuyen;
                currentCheckedStates = new bool[checkedListBoxQuyen.Items.Count];
                

                // Đặt giá trị cho CheckedListBox dựa trên tên cột
                foreach (string quyenColumnName in new[] { "Cập nhật điểm", "Đăng ký lớp", "Tra cứu TKB", "Tra cứu KQHT",
                                    "Cập nhật thông tin học bổng", "Phê duyệt yêu cầu học bổng", "Đăng ký học bổng", "Cập nhật HTTT",
                                    "Cập nhật công nợ", "Kiểm tra dư nợ", "Thống kê học phí", "Thống kê nợ đọng học phí", "Thống kê điểm", "Thống kê học bổng", "Thống kê lớp học", "Thống kê hình thức thanh toán" })
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
                for (int i = 0; i < checkedListBoxQuyen.Items.Count; i++)
                {
                    currentCheckedStates[i] = checkedListBoxQuyen.GetItemChecked(i);
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
                case "Cập nhật thông tin học bổng":
                    return "CapNhatHB";
                case "Phê duyệt yêu cầu học bổng":
                    return "PheDuyetHB";
                case "Đăng ký học bổng":
                    return "DangKyHB";
                case "Cập nhật HTTT":
                    return "CapNhatTTTT";
                case "Cập nhật công nợ":
                    return "CapNhatCongNo";
                case "Kiểm tra dư nợ":
                    return "KtraDuNo";
                case "Thống kê học phí":
                    return "TkeHocPhi";
                case "Thống kê nợ đọng học phí":
                    return "TkeNoHPhi";
                case "Thống kê điểm":
                    return "TkeDiem";
                case "Thống kê học bổng":
                    return "TkeHB";
                case "Thống kê lớp học":
                    return "TkeLopHoc";
                case "Thống kê hình thức thanh toán":
                    return "TkeHTTT";

                    
                default:
                    return checkedListBoxColumnName;
            }
        }
        
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int selectedIndex = -1;
            if (infoQuyenDataGridView.SelectedRows.Count > 0)
            {
                selectedIndex = infoQuyenDataGridView.SelectedRows[0].Index;
                DataGridViewRow selectedRow = infoQuyenDataGridView.SelectedRows[0];

                // Lặp qua các mục trong CheckedListBox để cập nhật cơ sở dữ liệu
                foreach (string quyenColumnName in new[] { "Cập nhật điểm", "Đăng ký lớp", "Tra cứu TKB", "Tra cứu KQHT",
                            "Cập nhật thông tin học bổng", "Phê duyệt yêu cầu học bổng", "Đăng ký học bổng", "Cập nhật HTTT",
                            "Cập nhật công nợ", "Kiểm tra dư nợ", "Thống kê học phí", "Thống kê nợ đọng học phí", "Thống kê điểm", "Thống kê học bổng", "Thống kê lớp học", "Thống kê hình thức thanh toán" })
                {
                    // Ánh xạ tên cột trong checkedListBoxQuyen sang tên cột trong cơ sở dữ liệu
                    string databaseColumnName = MapColumnName(quyenColumnName);

                    // Kiểm tra xem có phải là tên cột hợp lệ hay không
                    if (!string.IsNullOrEmpty(databaseColumnName))
                    {
                        int columnIndex = checkedListBoxQuyen.Items.IndexOf(quyenColumnName);

                        // Lấy giá trị từ CheckedListBox và cập nhật vào cơ sở dữ liệu
                        bool isChecked = checkedListBoxQuyen.GetItemChecked(columnIndex);
                        UpdateDatabase(selectedRow.Cells["MaQuyen"].Value.ToString(), databaseColumnName, isChecked);
                    }
                }

                // Sau khi cập nhật, làm mới lại DataGridView để hiển thị dữ liệu mới
                InitializeDataGridView();
                // Chọn lại hàng đã chọn trước đó
                if (selectedIndex >= 0 && selectedIndex < infoQuyenDataGridView.Rows.Count)
                {
                    infoQuyenDataGridView.Rows[selectedIndex].Selected = true;
                }
                MessageBox.Show("Xác nhận thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void UpdateDatabase(string maQuyen, string columnName, bool isChecked)
        {
            // Thực hiện cập nhật cơ sở dữ liệu dựa trên giá trị isChecked
            // Sử dụng tham số maQuyen và columnName để xác định nơi cần cập nhật

            // Ví dụ sử dụng SqlCommand để thực hiện cập nhật
            using (SqlCommand cmd = new SqlCommand("UPDATE quyen SET " + columnName + " = @isChecked WHERE MaQuyen = @maQuyen", con))
            {
                cmd.Parameters.AddWithValue("@isChecked", isChecked);
                cmd.Parameters.AddWithValue("@maQuyen", maQuyen);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            infoQuyenDataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (currentCheckedStates != null)
            {
                // Khôi phục lại trạng thái trước đó của các mục trong CheckedListBox
                for (int i = 0; i < checkedListBoxQuyen.Items.Count; i++)
                {
                    checkedListBoxQuyen.SetItemChecked(i, currentCheckedStates[i]);
                }
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
