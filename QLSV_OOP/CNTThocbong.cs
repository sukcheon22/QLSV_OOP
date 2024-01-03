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
    public partial class CNTThocbong : UserControl
    {
        public CNTThocbong()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public void ResetState()
        {
            txtScholarshipID.Text = "";
            txtScholarshipName.Text = "";
            boxScholarshipType.Text = "";
            scholarshipDataGridView.DataSource = HBDAO.Instance.scholarshipGridView();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string scholarshipID = txtScholarshipID.Text;
            string scholarshipName = txtScholarshipName.Text;
            string scholarshipType = boxScholarshipType.Text;
            scholarshipDataGridView.DataSource = SearchHocBong(scholarshipID, scholarshipName, scholarshipType);

        }
        private DataTable SearchHocBong(string scholarshipID, string scholarshipName, string scholarshipType)
        {
            // Tạo câu truy vấn SQL động dựa trên số lượng thuộc tính đã nhập
            string query = "SELECT * FROM HB WHERE ";
            bool isFirstCondition = true;

            if (!string.IsNullOrEmpty(scholarshipID))
            {
                query += $"MaHB LIKE '%{scholarshipID}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(scholarshipName))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"TenHB LIKE '%{scholarshipName}%'";
                isFirstCondition = false;
            }

            if (!string.IsNullOrEmpty(scholarshipType))
            {
                if (!isFirstCondition)
                    query += " AND ";
                query += $"Loai LIKE '%{scholarshipType}%'";
                isFirstCondition = false;
            }

            // Thực hiện truy vấn SQL SELECT với câu truy vấn động
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        public DataTable infoScholarshipGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from HB", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void InitializeDataGridView()
        {
            scholarshipDataGridView.DataSource = this.infoScholarshipGridView();
        }
    }
}
