using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_OOP.DTO
{
    public class Dang_ky
    {
        public Dang_ky(string studentID, string classID)
        {
            this.StudentID = studentID;
            this.ClassID = classID;
        }
        public Dang_ky(DataRow row)
        {
            this.StudentID = row["MaSV"].ToString();
            this.ClassID = row["MaLH"].ToString();
        }

        private string studentID;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private string classID;

        public string ClassID
        {
            get { return classID; }
            set { classID = value; }
        }
    }
}
