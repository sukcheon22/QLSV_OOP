using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_OOP.DTO
{
    public class Hoc_phi
    {
        public Hoc_phi(string code, string studentID, string bankName, string stk, int money)
        {
            this.Code = code;
            this.StudentID = studentID;
            this.BankName = bankName;
            this.STK = stk;
            this.Money = money;
        }
        public Hoc_phi(DataRow row)
        {
            this.Code = row["MaTT"].ToString();
            this.StudentID = row["MaSV"].ToString();
            this.BankName = row["TenNH"].ToString();
            this.STK = row["STK"].ToString();
            this.Money = (int)row["TienTT"];
        }

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string studentID;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private string bankName;

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }

        private string stk;

        public string STK
        {
            get { return stk; }
            set { stk = value; }
        }

        private int money;

        public int Money
        {
            get { return money; }
            set { money = value; }
        }
    }
}
