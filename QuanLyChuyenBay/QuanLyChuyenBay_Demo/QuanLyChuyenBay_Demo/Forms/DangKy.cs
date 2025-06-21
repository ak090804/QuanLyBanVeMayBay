using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào không phải là số và không phải là phím backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập
            }
        }

        private void btnCNA_Click(object sender, EventArgs e)
        {
            try
            {
                string taiKhoan = CacHamKiemTra.KiemTraChuoiRong(txtNewUser.Text);
                string matKhau = CacHamKiemTra.KiemTraChuoiRong(txtNewPass1.Text);
                string nhapLaiMatKhau = CacHamKiemTra.KiemTraChuoiRong(txtNewPass2.Text);
                string SDT = CacHamKiemTra.KiemTraChuoiRong(txtPhone.Text);
                if (nhapLaiMatKhau != matKhau) throw new Exception("Mật khẩu mới không trùng nhau");
                TaiKhoan tk = new TaiKhoan(taiKhoan, matKhau);
                if (tk.TaoTaiKhoan(new DBConnect(), SDT))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Tạo tài khoản");
                    frmDangNhap form = new frmDangNhap();
                    form.Show();
                }
                else
                {
                    throw new Exception("Tạo tài khoản thất bại");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDangNhap form = new frmDangNhap();
            form.Show();
            this.Close();

        }
    }
}
