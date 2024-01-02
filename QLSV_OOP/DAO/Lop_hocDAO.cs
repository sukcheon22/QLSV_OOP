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
    public class Lop_hocDAO
    {
        private static Lop_hocDAO instance;

        public static Lop_hocDAO Instance
        {
            get
            {
                if (instance == null) instance = new Lop_hocDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Lop_hocDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public DataTable classGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Lop_hoc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
