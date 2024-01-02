using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV_OOP;
using QLSV_OOP.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLSV_OOP.DAO
{
    public class Hoc_phiDAO
    {
        private static Hoc_phiDAO instance;

        public static Hoc_phiDAO Instance
        {
            get
            {
                if (instance == null) instance = new Hoc_phiDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Hoc_phiDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public int SumMoney()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(TienTT) FROM Hoc_phi", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public string MostBank()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 1 TenNH FROM Hoc_phi GROUP BY TenNH ORDER BY COUNT(TenNH) DESC;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToString(dt.Rows[0][0]);
        }
        public DataTable tuitionGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Hoc_phi", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public int DuNoHPhi(string maSV)
        {
            string query = "select (select sum(KhoiLuong) from Hoc_phan " +
                "inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                "inner join Dang_ky on Lop_hoc.MaLH = Dang_ky.MaLH " +
                "group by (MaSV) " +
                "having MaSV =" + maSV + ") * 500000 - sum(TienTT) from Hoc_phi " +
                "inner join Sinh__vien on Hoc_phi.MaSV = Sinh__vien.MaSV " +
                "group by Sinh__vien.MaSV " +
                "having Sinh__vien.MaSV = " + maSV + ";";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }


        public string NumStudentOwe()
        {
            string query = "select count(distinct Sinh__vien.MaSV) as NumStudentsOwe " +
                           "from Hoc_phi " +
                           "inner join Sinh__vien on Hoc_phi.MaSV = Sinh__vien.MaSV " +
                           "group by Sinh__vien.MaSV " +
                           "having (select sum(KhoiLuong) * 500000 from Hoc_phan " +
                           "inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                           "inner join Dang_ky on Lop_hoc.MaLH = Dang_ky.MaLH " +
                           "where Dang_ky.MaSV = Sinh__vien.MaSV) - sum(TienTT) > 0;";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToString(dt.Rows.Count);
        }

        public DataTable tuitionoweGridView()
        {
            string query = "select Hoc_phi.MaSV, (select sum(KhoiLuong) * 500000 from Hoc_phan inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP inner join Dang_ky on Lop_hoc.MaLH = Dang_ky.MaLH where Dang_ky.MaSV = Hoc_phi.MaSV) - sum(TienTT) as SoTienConNo from Hoc_phi inner join Sinh__vien on Hoc_phi.MaSV = Sinh__vien.MaSV group by Hoc_phi.MaSV having (select sum(KhoiLuong) * 500000 from Hoc_phan inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP inner join Dang_ky on Lop_hoc.MaLH = Dang_ky.MaLH where Dang_ky.MaSV = Hoc_phi.MaSV) - sum(TienTT) > 0;";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }


    }
}
