using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_OOP
{
    public partial class PheDuyetHB : UserControl
    {
        public PheDuyetHB()
        {
            InitializeComponent();
            dataGridView1.DataSource = classGridView();
            txtHBId.Enabled = false;
            txtStudentId.Enabled = false;
        }

        private void PheDuyetHB_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        private DataTable classGridView()
        {
            string query = "select Tinh_trang_HB.MaHB as \"Mã học bổng\", TenHB as \"Tên học bổng\", MaSV as \"Mã sinh viên\" ,TinhTrang as \"Tình trạng\" from Tinh_trang_HB " +
                           "inner join HB on Tinh_trang_HB.MaHB = HB.MaHB ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void DisplayInformation(string maHB, string maSV, string check)
        {
            txtHBId.Text = maHB;
            txtStudentId.Text = maSV;
            cmbCheck.Text = check;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maHB = selectedRow.Cells["Mã học bổng"].Value.ToString();
                string maSV = selectedRow.Cells["Mã sinh viên"].Value.ToString();
                string check = selectedRow.Cells["Tình trạng"].Value.ToString();

                DisplayInformation(maHB, maSV, check);
            }
        }

        private void ConfirmInformation(string maSV, string maHB, string check)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Tinh_trang_HB SET TinhTrang = '" + check + "' WHERE MaSV = '" + maSV + "' AND MaHB = '" + maHB + "'", con))
                { 

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Phê duyệt thành công!");
                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo rằng kết nối sẽ được đóng dù có lỗi hay không
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = classGridView();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string maSV = txtStudentId.Text;
            string maHB = txtHBId.Text;
            string check = cmbCheck.Text;
            ConfirmInformation(maSV, maHB, check);
            InitializeDataGridView();
        }

        public void ResetStatus()
        {
            txtHBId.Text = "";
            txtStudentId.Text = "";
            cmbCheck.Text = "False";
        }
    }
}
