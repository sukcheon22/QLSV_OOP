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
    public class HBDAO
    {
        private static HBDAO instance;

        public static HBDAO Instance
        {
            get
            {
                if (instance == null) instance = new HBDAO();
                return instance;
            }
            private set => instance = value;
        }
        private HBDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
    }
}
