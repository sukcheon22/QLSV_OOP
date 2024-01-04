using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLSV_OOP.DTO;
using QLSV_OOP;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Text;

namespace QLSV_OOP.DAO
{
    public class HTTTDAO
    {
        private static HTTTDAO instance;
        public static HTTTDAO Instance
        {
            get
            {
                if (instance == null) instance = new HTTTDAO();
                return instance;
            }
            private set => instance = value;
        }
        private HTTTDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        public DataTable htttGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from HTTT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
