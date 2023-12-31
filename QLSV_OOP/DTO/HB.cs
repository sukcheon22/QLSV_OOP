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
        public HB(string hbID, string hbName, string loaiHB)
        {
            this.HBID = hbID;
            this.HBName = hbName;
            this.LoaiHB = loaiHB;
        }
        public HB(DataRow row)
        {
            this.HBID = row["MaHB"].ToString();
            this.HBName = row["TenHB"].ToString();
            this.LoaiHB = row["Loai"].ToString();
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
        private string loaiHB;

        public string LoaiHB
        {
            get { return loaiHB; }
            set { loaiHB = value; }
        }
    }
}
