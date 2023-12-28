using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_OOP.DTO
{
    internal class Admin
    {
        public Admin(string adminID, string userID)
        {
            this.AdminID = adminID;
            this.UserID = userID;
        }
        public Admin(DataRow row)
        {
            this.AdminID = row["MaAdmin"].ToString();
            this.UserID = row["MaDD"].ToString();
        }

        private string adminID;

        public string AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }

        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
    }
}
