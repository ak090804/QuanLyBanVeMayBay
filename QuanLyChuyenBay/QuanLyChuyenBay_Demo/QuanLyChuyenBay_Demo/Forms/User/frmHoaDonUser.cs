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

namespace QuanLyChuyenBay_Demo.Forms.User
{
    public partial class frmHoaDonUser : Form
    {
        DBConnect dbConn;
        TaiKhoan tk;
        public frmHoaDonUser(DBConnect _dbConn, TaiKhoan tk)
        {
            InitializeComponent();

            dbConn = _dbConn;
            this.tk = tk;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string cauTruyVan = "exec sp_xuatHoaDonUser '" + tk.taiKhoan + "'";
                FIllData.fillDataGridView(dgvHoaDon, dbConn, cauTruyVan, "HoaDonUser");
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnTamTinh_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        //Cac chuc nang: xem danh sach hoa don
        //Thanh toan hoa don

    }
}
