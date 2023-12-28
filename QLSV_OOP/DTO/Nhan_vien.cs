using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_OOP.DTO
{
    public class Nhan_vien
    {
        public Nhan_vien(string staffID, string identifier, string staffName, string position, string homeTown, string phoneNumber, DateTime? birth)
        {
            this.StaffID = staffID;
            this.Identifier = identifier;
            this.StaffName = staffName;
            this.Position = position;
            this.HomeTown = homeTown;
            this.PhoneNumber = phoneNumber;
            this.Birth = birth;
        }
        public Nhan_vien(DataRow row)
        {
            this.StaffID = row["MaNV"].ToString();
            this.Identifier = row["MaDD"].ToString();
            this.StaffName = row["TenNV"].ToString();
            this.Position = row["ViTri"].ToString();
            this.HomeTown = row["Que"].ToString();
            this.PhoneNumber = row["SDT"].ToString();
            this.Birth = (DateTime?)row["NgaySinh"];
        }

        private string staffID;

        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        private string identifier;

        public string Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }

        private string staffName;

        public string StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }

        private string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        private string homeTown;

        public string HomeTown
        {
            get { return homeTown; }
            set { homeTown = value; }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private DateTime? birth;

        public DateTime? Birth
        {
            get { return birth; }
            set { birth = value; }
        }
    }
}
