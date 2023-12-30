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
    public class KQHTDAO
    {
        private static KQHTDAO instance;

        public static KQHTDAO Instance
        {
            get
            {
                if (instance == null) instance = new KQHTDAO();
                return instance;
            }
            private set => instance = value;
        }
        private KQHTDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
    }
}
