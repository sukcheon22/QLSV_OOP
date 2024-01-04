using System;
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
    public class HBDAO
    {
        private static HBDAO instance;
        
        public static HBDAO Instance
        {
            get
            {
                if (instance == null) instance = new HBDAO();
                return instance;
            }
            private set => instance = value;
        }
        private HBDAO() { }

        SqlConnection con = new SqlConnection(ConnectionString.connectionString);

        public int NumCompany()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM HB WHERE Loai = 'Doanh nghiep'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumUni()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM HB WHERE Loai = 'Trao doi'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumScholarship()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from HB ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public DataTable scholarshipGridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Tinh_trang_HB", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public int StudentCompany()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) AS SoLuongDat FROM HB JOIN Tinh_trang_HB ON HB.MaHB = Tinh_trang_HB.MaHB WHERE HB.Loai = 'Doanh nghiep' AND Tinh_trang_HB.TinhTrang = 'True';", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int StudentUni()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) AS SoLuongDat FROM HB JOIN Tinh_trang_HB ON HB.MaHB = Tinh_trang_HB.MaHB WHERE HB.Loai = 'Trao doi' AND Tinh_trang_HB.TinhTrang = 'True';", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public int NumScholarshipOK()
        {
            // Gọi hai hàm để lấy số lượng từ hai loại học bổng
            int studentCompany = StudentCompany();
            int studentUni = StudentUni();

            // Tính tổng của hai giá trị
            int totalScholarshipOK = studentCompany + studentUni;

            // Trả về tổng
            return totalScholarshipOK;
        }

    }
}
