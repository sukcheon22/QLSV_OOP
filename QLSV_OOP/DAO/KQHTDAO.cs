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
    public class KQHTDAO
    {
        private static KQHTDAO instance;

        public static KQHTDAO Instance
        {
            get
            {
                if (instance == null) instance = new KQHTDAO();
                return instance;
            }
            private set => instance = value;
        }
        private KQHTDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public int NumFailed()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienTruot FROM KQHT WHERE Diem < 1", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumPassed()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienQua FROM KQHT WHERE Diem >= 1;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public DataTable gradeGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from KQHT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        
        public int NumExcellent()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienXuatSac FROM KQHT WHERE dbo.Average(MaSV) >= 3.6;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["SoLuongSinhVienXuatSac"]);
        }
        public int NumGood()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienGioi FROM KQHT WHERE dbo.Average(MaSV) >= 3.2 AND dbo.Average(MaSV) < 3.6;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["SoLuongSinhVienGioi"]);
        }
        public int NumWell()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienKha FROM KQHT WHERE dbo.Average(MaSV) >= 2.8 AND dbo.Average(MaSV) < 3.2;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["SoLuongSinhVienKha"]);
        }
        public int NumBad()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(DISTINCT MaSV) AS SoLuongSinhVienTrungBinh FROM KQHT WHERE dbo.Average(MaSV) < 2.8;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["SoLuongSinhVienTrungBinh"]);
        }




    }
}
