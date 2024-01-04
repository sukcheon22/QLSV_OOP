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
    public class Tinh_trangHBDAO
    {
        private static Tinh_trangHBDAO instance;

        public static Tinh_trangHBDAO Instance
        {
            get
            {
                if (instance == null) instance = new Tinh_trangHBDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Tinh_trangHBDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public DataTable HBGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from HB", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
