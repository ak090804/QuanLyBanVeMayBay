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
using System.Data.SqlClient;
using QuanLyChuyenBay_Demo.Models;

namespace QuanLyChuyenBay_Demo.Forms.User
{
    public partial class frmThongTinCaNhan : Form
    {
        DBConnect dbConn;
        private TaiKhoan tk;
        private int listener = 0;

        public frmThongTinCaNhan(DBConnect _dbConn, TaiKhoan tk)
        {
            InitializeComponent();

            dbConn = _dbConn;
            this.tk = tk;
            enableButton();
            txtTaiKhoan.Text = tk.taiKhoan;
            dbConn.openConnect();
        }

        private void fillThongTinCaNhan()
        {
            try
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    dbConn.openConnect();
                    cmd.CommandText = "select * from func_ThongTinKhachHangTheoTaiKhoan('" + txtTaiKhoan.Text + "')";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["NgaySinh"].ToString() == null)
                            {
                                break;
                            }
                            txtHoTen.Text = reader["HoTen"].ToString();
                            txtDiaChi.Text = reader["DiaChi"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtSDT.Text = reader["SoDienThoai"].ToString();
                            guna2DateTimePicker1.Value = Convert.ToDateTime(reader["NgaySinh"].ToString());
                        }
                    }
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);

            }



        }
        private void enableButton()
        {
            if (listener == 0)
            {
                btnDoiMatKhau.Enabled = true;
                btnCapNhatThongTin.Enabled = true;
                btnLuuMatKhau.Enabled = false;
                btnLuuThongTin.Enabled = false;

                //Lam mo textbox
                txtTaiKhoan.Enabled = false;
                txtMatKhau.Enabled = false;
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;

                txtMatKhau.Text = "";
                


                //txtTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
            else if (listener == 1) // Click button doi mat khau
            {

                btnDoiMatKhau.Enabled = false;
                btnLuuMatKhau.Enabled = true;

                txtTaiKhoan.Enabled = false;
                txtMatKhau.Enabled = true;
                listener = 0;
            }

            else if (listener == 2) // Click cap nhat thong tin
            {
                btnCapNhatThongTin.Enabled = false;
                btnLuuThongTin.Enabled = true;

                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
                txtHoTen.Enabled = true;
                txtSDT.Enabled = true;
                listener = 0;
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            listener = 1;
            enableButton();
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                fillThongTinCaNhan();
                listener = 2;
                enableButton();
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);

            }

        }

        private void btnLuuMatKhau_Click(object sender, EventArgs e)
        {
            listener = 0;
            try
            {
                if (tk.MatKhau == txtMatKhau.Text)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Hãy nhập mật khẩu mới");
                }
                else
                {
                    tk.CapNhatTaiKhoan(dbConn, txtTaiKhoan.Text, txtMatKhau.Text);
                    Notification_Helpers.ThongBaoThanhCong(this, "Đổi mật khẩu");
                }

                enableButton();
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }

            enableButton();
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            listener = 0;
            try
            {
                KhachHang kh = new KhachHang(txtHoTen.Text, txtDiaChi.Text, txtEmail.Text, guna2DateTimePicker1.Text, txtTaiKhoan.Text);
                kh.capNhapThongTinKhach(dbConn, txtTaiKhoan.Text);


                enableButton();
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }


            enableButton();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    //Load thong tin khach hang len day.
    // Nho Apply phan quyen ==>  Dang nhap bang tai khoan duoc cap ==> phan quyen trong sql
    // Cac chuc nang: xem thong tin, sua thong tin, xem thong tin hanhkhach da dat cho boi user nay


}
