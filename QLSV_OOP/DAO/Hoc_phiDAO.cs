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

        public int DuNoHphi(string masv)
        {
            string query = "select ( select sum(KhoiLuong) from Dang_ky " +
                "inner join Lop_hoc on Dang_ky.MaLH = Lop_hoc.MaLH " +
                "inner join Hoc_phan on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                "group by (MaSV) " +
                "having MaSV = " + masv +
                ") * 500000 - sum(TienTT) from Hoc_phi " +
                "inner join Sinh__vien on Sinh__vien.MaSV = Hoc_phi.MaSV " +
                "group by (Hoc_phi.MaSV) " +
                "having Hoc_phi.MaSV = "+ masv +";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
    }
}
