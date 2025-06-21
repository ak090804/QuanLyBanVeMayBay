using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyChuyenBay_Demo.Helpers
{
    public class Notification_Helpers
    {
        public static void ThongBaoLoi(Form owner, string pLoi)
        {
            MessageBox.Show(owner, "Lỗi: " + pLoi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public static void ThongBaoThanhCong(Form owner, string pThanhCong)
        {
            MessageBox.Show(owner, pThanhCong + " thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ThongBaoThoat(Form owner)
        {
            DialogResult r;
            r = MessageBox.Show(owner, "Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void ThongBao(Form owner, string pThongBao)
        {
            MessageBox.Show(owner, pThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
