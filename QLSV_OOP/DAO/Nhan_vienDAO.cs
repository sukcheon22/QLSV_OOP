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
    }
}
