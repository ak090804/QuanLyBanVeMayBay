using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Forms.User;
using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmGiaoDienKhach : Form
    {
        frmThongTinCaNhan frm_thongTinCaNhan;
        frmQuanLyPhieuDat frm_DatVe;
        frmQuanLyHoaDon frm_HoaDon;
        private readonly DBConnect dbConn;
        private TaiKhoan tk;

        public frmGiaoDienKhach(TaiKhoan tk, DBConnect conn)
        {
            InitializeComponent();
            this.dbConn = conn;

            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.AutoSize = false;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(1160, 580);  
            this.MaximumSize = new System.Drawing.Size(1160, 580);  

            this.tk = tk;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Notification_Helpers.ThongBaoThoat(this);
        }

        bool sidebar_Expand = true;
        private void sidebarTrans_Tick(object sender, EventArgs e)
        {
            if (sidebar_Expand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 59)
                {
                    sidebar_Expand = false;
                    sidebarTrans.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 212)
                {
                    sidebar_Expand = true;
                    sidebarTrans.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTrans.Start();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            if (frm_thongTinCaNhan == null)
            {
                frm_thongTinCaNhan = new frmThongTinCaNhan(dbConn, tk);
                frm_thongTinCaNhan.FormClosed += frm_thongTinCaNhan_FormClose;
                frm_thongTinCaNhan.MdiParent = this;
                frm_thongTinCaNhan.Dock = DockStyle.Fill;
                frm_thongTinCaNhan.Show();
            }
            else
            {
                frm_thongTinCaNhan.Activate();
            }
        }

        private void frm_thongTinCaNhan_FormClose(object sender, FormClosedEventArgs e)
        {
            frm_thongTinCaNhan = null;
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (frm_DatVe == null)
            {
                frm_DatVe = new frmQuanLyPhieuDat(dbConn,tk);
                frm_DatVe.FormClosed += frmDatVeUser_FormClosed;
                frm_DatVe.MdiParent = this;
                frm_DatVe.Dock = DockStyle.Fill;
                frm_DatVe.Show();
            }
            else
            {
                frm_DatVe.Activate();
            }
        }

        private void frmDatVeUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_DatVe = null;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (frm_HoaDon == null)
            {
                frm_HoaDon = new frmQuanLyHoaDon(dbConn,tk);
                frm_HoaDon.FormClosed += frmHoaDonUser_FormClosed;
                frm_HoaDon.MdiParent = this;
                frm_HoaDon.Dock = DockStyle.Fill;
                frm_HoaDon.Show();
            }
            else
            {
                frm_HoaDon.Activate();
            }
        }

        private void frmHoaDonUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_HoaDon = null;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap form = new frmDangNhap();
            form.Show();
        }

        private void frmGiaoDienKhach_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
            //Form form = new frmDangNhap();
            //form.Show();
        }
    }
}
