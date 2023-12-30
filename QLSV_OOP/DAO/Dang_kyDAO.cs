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
    public class Dang_kyDAO
    {
        private static Dang_kyDAO instance;

        public static Dang_kyDAO Instance
        {
            get
            {
                if (instance == null) instance = new Dang_kyDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Dang_kyDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
    }
}
