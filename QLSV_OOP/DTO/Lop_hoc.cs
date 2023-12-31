using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_OOP.DTO
{
    public class Lop_hoc
    {
        public Lop_hoc(string classID, string subjectID, int time, int numberSV, DateTime? batDau, DateTime? ketThuc, int thu)
        {
            this.ClassID = classID;
            this.SubjectID = subjectID;
            this.Time = time;
            this.NumberSV = numberSV;
            this.BatDau = batDau;
            this.KetThuc = ketThuc;
            this.Thu = thu;
        }
        public Lop_hoc(DataRow row)
        {
            this.ClassID = row["MaLH"].ToString();
            this.SubjectID = row["MaHP"].ToString();
            this.Time = (int)row["ThoiGian"];
            this.NumberSV = (int)row["SoLuong"];
            this.BatDau = (DateTime?)row["BatDau"];
            this.KetThuc = (DateTime?)row["KetThuc"];
            this.Thu = (int)row["Thu"];
        }

        private string classID;

        public string ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        private string subjectID;

        public string SubjectID
        {
            get { return subjectID; }
            set { subjectID = value; }
        }

        private int time;

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        private int numberSV;

        public int NumberSV
        {
            get { return numberSV; }
            set { numberSV = value; }
        }

        private DateTime? batDau;
        public DateTime? BatDau { get { return batDau; } set { batDau = value; } }

        private DateTime? ketThuc;
        public DateTime? KetThuc { get { return ketThuc; } set { ketThuc = value; } }

        private int thu;
        public int Thu { get { return thu; } set {  thu = value; } }
    }
}
