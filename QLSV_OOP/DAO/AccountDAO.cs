﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLSV_OOP.DTO;
using QLSV_OOP;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Text;

namespace QLSV_OOP.DAO
{
    public class AccountDAO
    {
        
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set => instance = value;
        }
        private AccountDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        
        public bool Login(string username, string password, string roleid)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Tai_khoan WHERE Username ='" + username + "' AND Password='" + password + "' AND MaQuyen= '"+ roleid +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
                
            }
            else { return false; }
            
        }

        public Account GetAccountByUserName(string userName)
        {
            SqlDataAdapter sa = new SqlDataAdapter("SELECT * FROM tai_khoan WHERE Username = '" + userName + "'", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        public bool UpdatePassword(string username, string oldPassword, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                string query = "UPDATE tai_khoan SET Password = @NewPassword WHERE Username = @UserName AND Password = @OldPassword";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@OldPassword", oldPassword); // Mật khẩu cũ
                command.Parameters.AddWithValue("@NewPassword", newPassword); // Mật khẩu mới

                int rowsAffected = command.ExecuteNonQuery();
                
                return rowsAffected > 0;
            }
        }

        public int NumAdmin()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Tai_khoan WHERE MaQuyen = 'QAD'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumStudent()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Tai_khoan WHERE MaQuyen = 'QSV'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumEduEmployee()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tai_khoan where MaQuyen = 'QDT'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumFinancialEmployee()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tai_khoan where MaQuyen = 'QTV'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumAccount()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tai_khoan ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public DataTable accGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from tai_khoan", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }

}
