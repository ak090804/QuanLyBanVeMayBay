using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmDangNhap : Form
    {
        //DBConnect dbConn = new DBConnect("ADUYLAAI", "QuanLyChuyenBay","sa","123");
        TaiKhoan tk;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Notification_Helpers.ThongBaoThoat(this);
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Viet ham kiem tra tai khoan o day
                tk = new TaiKhoan(txtUser.Text, txtPass.Text);

                DBConnect conn = new DBConnect("ADUYLAAI", "QuanLyBanVeMayBay", "Admin", "Admin@123"); //Thay bằng user chỉ kiểm tra TaiKhoan

                Form form;
                if (tk.taiKhoan == "sa")
                {
                    conn = new DBConnect("ADUYLAAI", "QuanLyBanVeMayBay", "sa", "123456");
                    form = new frmMain(conn);
                    form.Show();

                }
                if (tk.taiKhoan == "Admin")
                {
                    if (conn.ktraTaiKhoan("TaiKhoan", tk.taiKhoan, tk.MatKhau))
                    {
                        form = new frmMain(conn);
                        form.Show();

                    }
                    else
                    {
                        Notification_Helpers.ThongBao(this, "Sai Mật Khẩu");
                    }
                }
                else
                {
                    if (conn.ktraTaiKhoan("TaiKhoan", tk.taiKhoan, tk.MatKhau))
                    {
                        conn = new DBConnect("ADUYLAAI", "QuanLyBanVeMayBay", tk.taiKhoan, tk.MatKhau);
                        form = new frmGiaoDienKhach(tk, conn);
                        form.Show();
                    }
                    else
                    {
                        Notification_Helpers.ThongBao(this, "Sai Mật Khẩu");
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmDangKy form = new frmDangKy();
            form.Show();
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //private void llblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{

        //    try
        //    {   
        //        string taiKhoan = CacHamKiemTra.KiemTraChuoiRong(txtNewUser.Text);
        //        string matKhau = CacHamKiemTra.KiemTraChuoiRong(txtNewPass1.Text);
        //        string nhapLaiMatKhau = CacHamKiemTra.KiemTraChuoiRong(txtNewPass2.Text);
        //        string SDT = CacHamKiemTra.KiemTraChuoiRong(txtPhone.Text);
        //        if (nhapLaiMatKhau != matKhau) throw new Exception("Mật khẩu mới không trùng nhau");
        //        TaiKhoan tk = new TaiKhoan(taiKhoan, matKhau);
        //        if (tk.TaoTaiKhoan(new DBConnect(),SDT))
        //        {
        //            Notification_Helpers.ThongBaoThanhCong(this, "Tạo tài khoản");
        //        }
        //        else
        //        {
        //            throw new Exception("Tạo tài khoản thất bại");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Notification_Helpers.ThongBaoLoi(this, ex.Message);
        //    }
        //}

        //private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Kiểm tra nếu ký tự nhập vào không phải là số và không phải là phím backspace
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        //    {
        //        e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập
        //    }
        //}

        // Kiem tra dang nhap ==> neu la admin thi ref toi form main.
        // Neu la user thi ref toi frmGiaoDienKhachHang
    }
}
