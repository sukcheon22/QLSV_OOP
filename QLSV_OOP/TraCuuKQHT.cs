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
    public partial class TraCuuKQHT : UserControl
    {
        string MaSV;
        public TraCuuKQHT(string maSV)
        {
            InitializeComponent();
            dataGridView1.DataSource = classGridView(maSV);
            MaSV = maSV;
        }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        
        private DataTable classGridView(string maSV)
        {
            string query = "select Hoc_phan.MaHP as \"Mã học phần\", TenHP as \"Học phần\", Diem as \"Điểm\" from Hoc_phan " +
                "inner join KQHT on Hoc_phan.MaHP = KQHT.MaHP " +
                "where MaSV = " + maSV +";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private DataTable SearchHP(string maSV, string txtMaHP)
        {
            string query = "select Hoc_phan.MaHP as \"Mã học phần\", TenHP as \"Học phần\", Diem as \"Điểm\" from Hoc_phan " +
                "inner join KQHT on Hoc_phan.MaHP = KQHT.MaHP " +
                "where MaSV = " + maSV + " and Hoc_phan.MaHP like " + $"'%{txtMaHP}%';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtHP = new DataTable();
            sda.Fill(dtHP);
            return dtHP;
        }
        private void TraCuuKQHT_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SearchHP(MaSV, txtMaHP.Text.ToString());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = classGridView(MaSV);
        }
    }
}
