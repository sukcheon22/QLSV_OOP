using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_OOP.DTO
{
    public class KQHT
    {
        public KQHT(string studentID, string subjectID, int diem)
        {
            this.StudentID = studentID;
            this.SubjectID = subjectID;
            this.Diem = diem;
        }
        public KQHT(DataRow row)
        {
            this.StudentID = row["MaSV"].ToString();
            this.SubjectID = row["MaHP"].ToString();
            this.Diem = (int)row["Diem"];
        }

        private string studentID;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private string subjectID;

        public string SubjectID
        {
            get { return subjectID; }
            set { subjectID = value; }
        }

        private int diem;

        public int Diem
        {
            get { return diem; }
            set { diem = value; }
        }
    }
}
