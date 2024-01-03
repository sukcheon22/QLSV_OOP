﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV_OOP;
using QLSV_OOP.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLSV_OOP.DAO
{
    public class Lop_hocDAO
    {
        private static Lop_hocDAO instance;

        public static Lop_hocDAO Instance
        {
            get
            {
                if (instance == null) instance = new Lop_hocDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Lop_hocDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public DataTable classGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Lop_hoc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public int CountTinChi(string maSV)
        {
            string query = "select sum(KhoiLuong) from Hoc_phan " +
                "inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                "inner join Dang_ky on Dang_ky.MaLH = Lop_hoc.MaLH " +
                "where MaSV = " + maSV + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public bool KiemTraTrung(string maSV, string maLop)
        {
            string query = "select count(*) from Dang_ky where MaSV = " + maSV + " and MaLH = " + maLop + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int flag = Convert.ToInt32(dt.Rows[0][0]);
            if (flag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
