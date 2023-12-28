using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_OOP.DTO
{
    internal class HB
    {
        public HB(string hbID, string hbName)
        {
            this.HBID = hbID;
            this.HBName = hbName;
        }
        public HB(DataRow row)
        {
            this.HBID = row["MaHB"].ToString();
            this.HBName = row["TenHB"].ToString();
        }

        private string hbID;

        public string HBID
        {
            get { return hbID; }
            set { hbID = value; }
        }

        private string hbName;

        public string HBName
        {
            get { return hbName; }
            set { hbName = value; }
        }
    }
}
