using System;
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
    public class Hoc_phiDAO
    {
        private static Hoc_phiDAO instance;

        public static Hoc_phiDAO Instance
        {
            get
            {
                if (instance == null) instance = new Hoc_phiDAO();
                return instance;
            }
            private set => instance = value;
        }
        private Hoc_phiDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public int SumMoney()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(TienTT) FROM Hoc_phi", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public string MostBank()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 1 TenNH FROM Hoc_phi GROUP BY TenNH ORDER BY COUNT(TenNH) DESC;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToString(dt.Rows[0][0]);
        }
        public DataTable tuitionGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Hoc_phi", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public int NumStudentOwe()
        {
            // Bước 1: Lấy tổng học phí từ bảng Hoc_phan
            int totalFee = 0;
            using (SqlConnection con = new SqlConnection("Your_Connection_String"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(KhoiLuong) FROM Hoc_phan", con);
                totalFee = Convert.ToInt32(cmd.ExecuteScalar()) * 500000;
            }

            // Bước 2: Lấy tổng số tiền đã đóng của mỗi sinh viên từ stored procedure TotalPaid
            int totalPaidAmount = 0;
            using (SqlConnection con = new SqlConnection("Your_Connection_String"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TotalPaid", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        totalPaidAmount += Convert.ToInt32(reader["TotalPaid"]);
                    }
                }
            }

            // Bước 3: So sánh và thống kê số sinh viên còn nợ học phí
            int numOweStudents = 0;

            if (totalPaidAmount < totalFee)
            {
                // Sinh viên còn nợ học phí
                numOweStudents++;
            }

            return numOweStudents;
        }


        public int DuNoHPhi(string maSV)
        {
            string query = "select (select sum(KhoiLuong) from Hoc_phan " +
                "inner join Lop_hoc on Hoc_phan.MaHP = Lop_hoc.MaHP " +
                "inner join Dang_ky on Lop_hoc.MaLH = Dang_ky.MaLH " +
                "group by (MaSV) " +
                "having MaSV =" + maSV+ ") * 500000 - sum(TienTT) from Hoc_phi " +
                "inner join Sinh__vien on Hoc_phi.MaSV = Sinh__vien.MaSV " +
                "group by Sinh__vien.MaSV " +
                "having Sinh__vien.MaSV = " + maSV + ";";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
    }
}
