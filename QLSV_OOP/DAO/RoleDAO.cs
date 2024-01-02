using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLSV_OOP
{
    public class RoleDAO
    {
        public static event EventHandler TkeDiemClicked;
        public static event EventHandler TkeHocBongClicked;
        public static event EventHandler TTinDuNoClicked;
        public static ToolStripMenuItem CreateDaoTao()
        {
            ToolStripMenuItem daotao = new ToolStripMenuItem("Đào Tạo");
            ToolStripMenuItem CapNhatDiem = new ToolStripMenuItem("Cập nhật điểm");
            ToolStripMenuItem DangKyLop = new ToolStripMenuItem("Đăng ký lớp");
            ToolStripMenuItem TraCuuTKB = new ToolStripMenuItem("Tra cứu TKB");
            ToolStripMenuItem TraKQHT = new ToolStripMenuItem("Tra cứu KQHT");
            daotao.DropDownItems.Add(CapNhatDiem);
            daotao.DropDownItems.Add(DangKyLop);
            daotao.DropDownItems.Add(TraCuuTKB);
            daotao.DropDownItems.Add(TraKQHT);
            return daotao;
        }
        
        public static ToolStripMenuItem CreateHB()
        {
            ToolStripMenuItem hb = new ToolStripMenuItem("Học Bổng");
            ToolStripMenuItem CapNhatHB = new ToolStripMenuItem("Cập nhật thông tin học bổng");
            ToolStripMenuItem PheDuyetHB = new ToolStripMenuItem("Phê duyệt yêu cầu học bổng");
            ToolStripMenuItem DangKyHB = new ToolStripMenuItem("Đăng ký học bổng");
            hb.DropDownItems.Add(CapNhatHB);
            hb.DropDownItems.Add(PheDuyetHB);
            hb.DropDownItems.Add(DangKyHB);
            return hb;
        }

        public static ToolStripMenuItem CreateTaiVu()
        {
            ToolStripMenuItem taivu = new ToolStripMenuItem("Tài Vụ");
            ToolStripMenuItem CapNhatTTTT = new ToolStripMenuItem("Cập nhật HTTT");
            ToolStripMenuItem CapNhatCongNo = new ToolStripMenuItem("Cập nhật công nợ");
            ToolStripMenuItem KtraDuNo = new ToolStripMenuItem("Kiểm tra dư nợ");
            taivu.DropDownItems.Add(CapNhatTTTT);
            taivu.DropDownItems.Add(CapNhatCongNo);
            taivu.DropDownItems.Add(KtraDuNo);
            KtraDuNo.Click += TTinDuNo_Clicked;
            return taivu;
        }

        public static ToolStripMenuItem CreateThongKe()
        {
            ToolStripMenuItem tke = new ToolStripMenuItem("Thống Kê");
            ToolStripMenuItem TkeHocPhi = new ToolStripMenuItem("Học phí");
            ToolStripMenuItem TkeNoHPhi = new ToolStripMenuItem("Nợ đọng học phí");
            ToolStripMenuItem TkeDiem = new ToolStripMenuItem("Điểm");
            ToolStripMenuItem TkeHB = new ToolStripMenuItem("Học bổng");
            ToolStripMenuItem TkeLopHoc = new ToolStripMenuItem("Lớp học");
            ToolStripMenuItem TkeHTTT = new ToolStripMenuItem("Hình thức thanh toán");
            tke.DropDownItems.Add(TkeHocPhi);
            tke.DropDownItems.Add(TkeNoHPhi);
            tke.DropDownItems.Add(TkeDiem);
            tke.DropDownItems.Add(TkeHB);
            tke.DropDownItems.Add(TkeLopHoc);
            tke.DropDownItems.Add(TkeHTTT);
            TkeDiem.Click += TkeDiem_Clicked;
            TkeHB.Click += TkeHocBong_Clicked;
            return tke;
        }

        private static void TkeDiem_Clicked(object sender, EventArgs e)
        {
            TkeDiemClicked?.Invoke(sender, e);
        }

        private static void TkeHocBong_Clicked(object sender, EventArgs e)
        {
            TkeHocBongClicked?.Invoke(sender, e);
        }

        private static void TTinDuNo_Clicked(object sender, EventArgs e)
        {
           TTinDuNoClicked?.Invoke(sender, e);
        }



    }
}
