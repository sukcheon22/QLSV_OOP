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
        
    }
}
