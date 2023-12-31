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
    }
}
