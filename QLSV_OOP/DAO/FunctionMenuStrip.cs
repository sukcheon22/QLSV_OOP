using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV_OOP.DTO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QLSV_OOP.DAO
{
    public class FunctionMenuStrip
    {
        private static FunctionMenuStrip instance;

        public static FunctionMenuStrip Instance
        {
            get
            {
                if (instance == null) instance = new FunctionMenuStrip();
                return instance;
            }
            private set => instance = value;
        }
        private FunctionMenuStrip() { }

       
        public void SignOut(Form form)
        {
            form.Close();
        }
        
        public void ChangePassword(Form form, Account account) 
        {
            form.Hide();
            frmChangePassword f = new frmChangePassword(account);
            f.ShowDialog();
            form.Show();
        }
        
        public void AccountAnalysis(Form form)
        {
            form.Hide();
            frmAccountAnalysis f = new frmAccountAnalysis();
            f.ShowDialog();
            form.Show();
        }

        public void StudentAnalysis(Form form)
        {
            form.Hide();
            frmStudentAnalysis f = new frmStudentAnalysis();
            f.ShowDialog();
            form.Show();
        }

        public void EmployeeAnalysis(Form form)
        {
            form.Hide();
            frmEmployeeAnalysis f = new frmEmployeeAnalysis();
            f.ShowDialog();
            form.Show();
        }

        public void ScholarshipAnalysis(Form form)
        {
            form.Hide();
            frmScholarshipAnalysis f = new frmScholarshipAnalysis();
            f.ShowDialog();
            form.Show();
        }
        public void GradeAnalysis(Form form)
        {
            form.Hide();
            frmGradeAnalysis f = new frmGradeAnalysis();
            f.ShowDialog();
            form.Show();
        }

        public void ClassAnalysis(Form form)
        {
            form.Hide();
            frmClassAnalysis f = new frmClassAnalysis();
            f.ShowDialog();
            form.Show();
        }

       public void TuitionAnalysis(Form form)
        {
            form.Hide();
            frmTuitionAnalysis f = new frmTuitionAnalysis();
            f.ShowDialog();
            form.Show();
        }

        public void RoleChanging(Form form)
        {
            form.Hide();
            frmPhanQuyen f = new frmPhanQuyen();
            f.ShowDialog();
            form.Show();
        }

        public void ClassRegistration(Form form, Sinh_Vien sinhVien)
        {
            form.Hide();
            frmClassRegistration f = new frmClassRegistration(sinhVien);
            f.ShowDialog();
            form.Show();
        }

        public void ScholarshipRegistration(Form form, Sinh_Vien sinhVien)
        {
            form.Hide();
            frmScholarshipRegistration f = new frmScholarshipRegistration(sinhVien);
            f.ShowDialog();
            form.Show();
        }

        public void TuitionOweAnalysis(Form form)
        {
            form.Hide();
            frmTuitionOweAnalysis f = new frmTuitionOweAnalysis();
            f.ShowDialog();
            form.Show();
        }

        public void HTTTAnalysis (Form form)
        {
            form.Hide();
            frmHTTTAnalysis f = new frmHTTTAnalysis();
            f.ShowDialog();
            form.Show();
        }
    }
}
