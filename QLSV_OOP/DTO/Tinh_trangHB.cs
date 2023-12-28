using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_OOP.DTO
{
    public class Tinh_trangHB
    {
        public Tinh_trangHB(string studentID, string hbID, bool status)
        {
            this.StudentID = studentID;
            this.HBID = hbID;
            this.Status = status;
        }
        public Tinh_trangHB(DataRow row)
        {
            this.StudentID = row["MaSV"].ToString();
            this.HBID = row["MaHB"].ToString();
            this.Status = (bool)row["TinhTrang"];
        }

        private string studentID;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private string hbID;

        public string HBID
        {
            get { return hbID; }
            set { hbID = value; }
        }

        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
