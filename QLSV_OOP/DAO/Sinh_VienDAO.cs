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
    public class Sinh_VienDAO
    {
        private static Sinh_VienDAO instance;

        public static Sinh_VienDAO Instance
        {
            get
            {
                if (instance == null) instance = new Sinh_VienDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Sinh_VienDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public Sinh_Vien GetSinhVienbyUserID(string userid)
        {
            SqlDataAdapter sa = new SqlDataAdapter("SELECT * FROM Sinh__vien WHERE MaDD = '" + userid + "'", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                return new Sinh_Vien(item);
            }

            return null;
        }

        public int NumK65()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sinh__vien WHERE Khoa = '65'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumK66()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sinh__vien WHERE Khoa = '66'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumK67()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sinh__vien WHERE Khoa = '67'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumK68()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sinh__vien WHERE Khoa = '68'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumStudent()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sinh__vien ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public DataTable accGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Sinh__vien", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
