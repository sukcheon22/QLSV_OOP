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
    }
}
