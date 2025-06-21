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
    public partial class frmMain : Form
    {
        DBConnect dbConn;
        public frmMain(DBConnect _dbConn)
        {
            InitializeComponent();
            pnlBody.Resize += PnlBody_Resize;
            this.dbConn = _dbConn;
        }

        private void PnlBody_Resize(object sender, EventArgs e)
        {
            // Cập nhật kích thước của form con khi pnlBody thay đổi kích thước
            if (pnlBody.Controls.Count > 0 && pnlBody.Controls[0] is Form activeForm)
            {
                activeForm.Width = pnlBody.Width;
                activeForm.Height = pnlBody.Height;
            }
        }
        public void showForm(Form form)
        {
            pnlBody.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlBody.Controls.Add(form);
            form.Show();
        }

        private void LogOut_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap form = new frmDangNhap();
            form.Show();
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notification_Helpers.ThongBaoThoat(this);
        }

        private void QlyTaiKhoan_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan form = new frmQuanLyTaiKhoan(dbConn);
            showForm(form);
        }

        private void QlyHanhKhach_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHanhKhach form = new frmQuanLyHanhKhach(dbConn);
            showForm(form);
        }

        private void QlyCB_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyChuyenBay form = new frmQuanLyChuyenBay(dbConn);
            showForm(form);
        }

        private void QlyMayBay_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMayBay form = new frmQuanLyMayBay(dbConn);
            showForm(form);
        }

        private void QlyTienIch_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTienIch form = new frmQuanLyTienIch(dbConn);
            showForm(form);
        }

        private void QlyPhieuDat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyPhieuDat form = new frmQuanLyPhieuDat(dbConn);
            showForm(form);
        }

        private void QlyVe_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyVe form = new frmQuanLyVe(dbConn);
            showForm(form);
        }

        private void QlyHD_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHoaDon form = new frmQuanLyHoaDon(dbConn);
            showForm(form);
        }

        private void QlyGiamGia_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyGiamGia form = new frmQuanLyGiamGia(dbConn);
            showForm(form);
        }

        private void giaoDienKhachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan("Admin", "Admin@123");
            
            Form form = new frmGiaoDienKhach(tk,dbConn);

      

            form.Show();
        }

        private void TimKiemChuyenBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemChuyenBay form = new frmTimKiemChuyenBay(dbConn);
            form.Show();
        }

		private void ThongKe_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmThongKe form=new frmThongKe(dbConn); 
            form.Show();   
		}

        private void saoLưuCSDL_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaoLuu form=new frmSaoLuu(dbConn);
            form.Show();
        }
    }
}
