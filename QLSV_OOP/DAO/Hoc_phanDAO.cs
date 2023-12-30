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
    public class Hoc_phanDAO
    {
        private static Hoc_phanDAO instance;

        public static Hoc_phanDAO Instance
        {
            get
            {
                if (instance == null) instance = new Hoc_phanDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Hoc_phanDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
    }
}
