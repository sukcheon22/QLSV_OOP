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
    public class Nhan_vienDAO
    {
        private static Nhan_vienDAO instance;

        public static Nhan_vienDAO Instance
        {
            get
            {
                if (instance == null) instance = new Nhan_vienDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Nhan_vienDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public int NumDaoTao()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Nhan_vien WHERE ViTri = 'Dao Tao'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumTaiVu()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Nhan_vien WHERE ViTri = 'Tai Vu'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int NumTong()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Nhan_vien ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public DataTable empGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Nhan_vien", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }


}
