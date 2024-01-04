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
    public partial class TraCuuTKB : UserControl
    {
        
        public TraCuuTKB(string maSV)
        {
            InitializeComponent();
            dataGridView1.DataSource = classGridView(maSV); 
        }
        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        private DataTable classGridView(string maSV)
        {
            string query = "select TenHP as \"Tên học phần\", Hoc_phan.MaHP as \"Mã học phần\", BatDau as \"Bắt đầu\", KetThuc as \"Kết thúc\", Thu as \"Thứ\" from Hoc_phan " +
                "inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                "inner join Dang_ky on Dang_ky.MaLH = Lop_hoc.MaLH " +
                "where MaSV = " + maSV +";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
