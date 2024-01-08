using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLSV_OOP.DAO;

namespace QLSV_OOP
{
    public class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance
        {
            get
            {
                if (instance == null) instance = new RoleDAO();
                return instance;
            }
            private set => instance = value;
        }
        private RoleDAO() { }

        public static event EventHandler CapNhatDiemClicked;
        //public static event EventHandler DkyLopClicked;
        public static event EventHandler TCuuTKBClicked;
        public static event EventHandler TCuuKQHTClicked;
        public static event EventHandler CapNhatTTHBClicked;
        public static event EventHandler PheDuyetYCHBClicked;
        //public static event EventHandler DKHocBongClicked;
        public static event EventHandler CapNhatHTTTClicked;
        public static event EventHandler CapNhatCongNoClicked;
        //public static event EventHandler KTraDuNoClicked;
        


        //public static event EventHandler TkeHocBongClicked;
        public static event EventHandler TTinDuNoClicked;

        public ToolStripMenuItem DKLop;
        public static ToolStripMenuItem CreateDaoTao()
        {
            ToolStripMenuItem daotao = new ToolStripMenuItem("Đào Tạo");

            ToolStripMenuItem CapNhatDiem = new ToolStripMenuItem("Cập nhật điểm");
            CapNhatDiem.Click += CapNhatDiem_Clicked;

            ToolStripMenuItem DangKyLop = new ToolStripMenuItem("Đăng ký lớp");
            RoleDAO.Instance.DKLop = DangKyLop;

            ToolStripMenuItem TraCuuTKB = new ToolStripMenuItem("Tra cứu TKB");
            TraCuuTKB.Click += TCuuTKB_Clicked;

            ToolStripMenuItem TraKQHT = new ToolStripMenuItem("Tra cứu KQHT");
            TraKQHT.Click += TCuuKQHT_Clicked;

            daotao.DropDownItems.Add(CapNhatDiem);
            daotao.DropDownItems.Add(DangKyLop);
            daotao.DropDownItems.Add(TraCuuTKB);
            daotao.DropDownItems.Add(TraKQHT);

            return daotao;
        }
        public ToolStripMenuItem DKHB;
        public static ToolStripMenuItem CreateHB()
        {
            ToolStripMenuItem hb = new ToolStripMenuItem("Học Bổng");

            ToolStripMenuItem CapNhatHB = new ToolStripMenuItem("Cập nhật thông tin học bổng");
            CapNhatHB.Click += CapNhatTTHB_Clicked;

            ToolStripMenuItem PheDuyetHB = new ToolStripMenuItem("Phê duyệt yêu cầu học bổng");
            PheDuyetHB.Click += PheDuyetYCHB_Clicked;

            ToolStripMenuItem DangKyHB = new ToolStripMenuItem("Đăng ký học bổng");
            RoleDAO.Instance.DKHB = DangKyHB;

            hb.DropDownItems.Add(CapNhatHB);
            hb.DropDownItems.Add(PheDuyetHB);
            hb.DropDownItems.Add(DangKyHB);

            return hb;
        }

        public static ToolStripMenuItem CreateTaiVu()
        {
            ToolStripMenuItem taivu = new ToolStripMenuItem("Tài Vụ");

            ToolStripMenuItem CapNhatTTTT = new ToolStripMenuItem("Cập nhật HTTT");
            CapNhatTTTT.Click += CapNhatHTTT_Clicked;

            ToolStripMenuItem CapNhatCongNo = new ToolStripMenuItem("Cập nhật công nợ");
            CapNhatCongNo.Click += CapNhatCongNo_Clicked;

            ToolStripMenuItem KtraDuNo = new ToolStripMenuItem("Kiểm tra dư nợ");
            

            taivu.DropDownItems.Add(CapNhatTTTT);
            taivu.DropDownItems.Add(CapNhatCongNo);
            taivu.DropDownItems.Add(KtraDuNo);
            KtraDuNo.Click += TTinDuNo_Clicked;
            return taivu;
        }

        public ToolStripMenuItem TKeDiem;
        public ToolStripMenuItem TKeHocPhi;
        public ToolStripMenuItem TKeNoHPhi;
        public ToolStripMenuItem TKeHB;
        public ToolStripMenuItem TKeLopHoc;
        public ToolStripMenuItem TKeHTTT;
        public static ToolStripMenuItem CreateThongKe()
        {
            ToolStripMenuItem tke = new ToolStripMenuItem("Thống Kê");

            ToolStripMenuItem TkeHocPhi = new ToolStripMenuItem("Học phí");
            RoleDAO.Instance.TKeHocPhi = TkeHocPhi;

            ToolStripMenuItem TkeNoHPhi = new ToolStripMenuItem("Nợ đọng học phí");
            RoleDAO.Instance.TKeNoHPhi = TkeNoHPhi;

            ToolStripMenuItem TkeDiem = new ToolStripMenuItem("Điểm");
            

            ToolStripMenuItem TkeHB = new ToolStripMenuItem("Học bổng");
            

            ToolStripMenuItem TkeLopHoc = new ToolStripMenuItem("Lớp học");
            RoleDAO.Instance.TKeLopHoc = TkeLopHoc;

            ToolStripMenuItem TkeHTTT = new ToolStripMenuItem("Hình thức thanh toán");
            RoleDAO.Instance.TKeHTTT = TkeHTTT;
            RoleDAO.Instance.TKeDiem = TkeDiem; 
            tke.DropDownItems.Add(TkeHocPhi);
            tke.DropDownItems.Add(TkeNoHPhi);
            tke.DropDownItems.Add(TkeDiem);
            tke.DropDownItems.Add(TkeHB);
            tke.DropDownItems.Add(TkeLopHoc);
            tke.DropDownItems.Add(TkeHTTT);
            //TkeDiem.Click += TkeDiem_Clicked;
            RoleDAO.Instance.TKeHB = TkeHB;

            
            return tke;
          
        }
        public static DataTable quyenGridView()
        {
            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM quyen) AS temp WHERE RowNum >= 2", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        private static void CapNhatDiem_Clicked(object sender, EventArgs e)
        {
            CapNhatDiemClicked?.Invoke(sender, e);
        }

        

        private static void TCuuTKB_Clicked(object sender, EventArgs e)
        {
            TCuuTKBClicked?.Invoke(sender, e);
        }

        private static void TCuuKQHT_Clicked(object sender, EventArgs e)
        {
            TCuuKQHTClicked?.Invoke(sender, e);
        }

        private static void CapNhatTTHB_Clicked(object sender, EventArgs e)
        {
            CapNhatTTHBClicked?.Invoke(sender, e);
        }

        private static void PheDuyetYCHB_Clicked(object sender, EventArgs e)
        {
            PheDuyetYCHBClicked?.Invoke(sender, e);
        }

        

        private static void CapNhatHTTT_Clicked(object sender, EventArgs e)
        {
            CapNhatHTTTClicked?.Invoke(sender, e);
        }

        private static void CapNhatCongNo_Clicked(object sender, EventArgs e)
        {
            CapNhatCongNoClicked?.Invoke(sender, e);
        }


        private static void TTinDuNo_Clicked(object sender, EventArgs e)
        {
           TTinDuNoClicked?.Invoke(sender, e);
        }


        


    }
}
