using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmQuanLyHoaDon : Form
    {
        private DBConnect dbConn;
        private TaiKhoan tk;
        public frmQuanLyHoaDon(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }

        public frmQuanLyHoaDon(DBConnect dbConn, TaiKhoan tk)
        {
            InitializeComponent();
            this.dbConn = dbConn;
            this.tk = tk;
        }
        private void emptyData()
        {
            lblMaHoaDonIP.Text = "[MaHoaDon]";
            txtMaPhieuDat.Clear();
            lblTongTienIP.Text = "[TongTien]";
            txtMaPhieuDat.Focus();
        }
        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            loadAllData();
        }
        private void loadAllData()
        {
            if (tk == null)
            {
                FIllData.fillDataGridView(dataGridViewDanhSachHoaDon, dbConn, "select MaHoaDon, MaPhieuDat, TongTien, TenTTHD from HOADON, TrangThaiHoaDon where HOADON.MaTTHD = TrangThaiHoaDon.MaTTHD", "HoaDon");
            }
            else
            {
                FIllData.fillDataGridView(dataGridViewDanhSachHoaDon, dbConn, @"SELECT hd.MaHoaDon, hd.MaPhieuDat, hd.TongTien, tthd.TenTTHD
                                                                                 FROM HoaDon hd
                                                                                 JOIN PhieuDat pd ON pd.MaPhieuDat = hd.MaPhieuDat
                                                                                  JOIN KhachHang kh ON kh.MaKhachHang = pd.MaKhachHang
                                                                                   JOIN TrangThaiHoaDon tthd ON tthd.MaTTHD = hd.MaTTHD
                                                                                JOIN TaiKhoan tk ON tk.MaTaiKhoan = kh.MaTaiKhoan
                                                                                WHERE tk.TenTaiKhoan = '" +tk.taiKhoan + "';", "HoaDon");


            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon tmp = new HoaDon(int.Parse(CacHamKiemTra.KiemTraChuoiRong(txtMaPhieuDat.Text)));

                if (tmp.ThemHoaDon(dbConn))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm hóa đơn thành công");
                    emptyData();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Thêm hóa đơn thất bại");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void fillData(DataGridViewRow rows)
        {
            lblMaHoaDonIP.Text = FIllData.GetValueDGVRows(rows, "MaHoaDon");

            txtMaPhieuDat.Text = FIllData.GetValueDGVRows(rows, "MaPhieuDat");

            lblTongTienIP.Text = FIllData.GetValueDGVRows(rows, "TongTien");
        }
        private void dataGridViewDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emptyData();
            fillData(dataGridViewDanhSachHoaDon.Rows[e.RowIndex]);
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            emptyData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon tmp = new HoaDon(int.Parse(CacHamKiemTra.KiemTraChuoiRong(txtMaPhieuDat.Text)));
                string maHoaDon = "";
                if (lblMaHoaDonIP.Text != "[MaHoaDon]")
                {
                    maHoaDon = CacHamKiemTra.KiemTraChuoiRong(lblMaHoaDonIP.Text);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn hóa đơn để xóa");
                }

                if (tmp.XoaHoaDon(dbConn, maHoaDon))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa hóa đơn");
                    emptyData();
                    loadAllData();
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã phiếu đặt mới
                int? maPhieuDatMoi = null;
                if (!string.IsNullOrWhiteSpace(txtMaPhieuDat.Text))
                {
                    maPhieuDatMoi = int.Parse(txtMaPhieuDat.Text);
                }

                // Lấy mã hóa đơn hiện tại
                string maHoaDon = lblMaHoaDonIP.Text;

                // Kiểm tra nếu mã hóa đơn đã được chọn
                if (maHoaDon == "[MaHoaDon]")
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn hóa đơn để sửa");
                    return;
                }

                HoaDon tmp = new HoaDon(maPhieuDatMoi.GetValueOrDefault());
                bool result = tmp.SuaHoaDon(dbConn, maHoaDon, maPhieuDatMoi);

                if (result)
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Sửa hóa đơn thành công");
                    emptyData();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Không thể sửa hóa đơn");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            int maPhieuDat;
            if (!int.TryParse(txtMaPhieuDat.Text, out maPhieuDat))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu đặt hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBConnect dbConn = new DBConnect();
                HoaDon hoaDon = new HoaDon(maPhieuDat);

                decimal tongTienTamThoi = hoaDon.TinhTongTienTamThoi(dbConn);

                lblTongTienIP.Text = tongTienTamThoi.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaPhieuDat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
           

         
            string maHoaDon = lblMaHoaDonIP.Text;

            // Kiểm tra nếu mã hóa đơn đã được chọn
            if (maHoaDon == "[MaHoaDon]")
            {
                Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn hóa đơn để thanh toán");
                return;
            }

            HoaDon tmp = new HoaDon(int.Parse(maHoaDon));
            bool result = tmp.ThanhToan(dbConn,maHoaDon);

            if (result)
            {
                Notification_Helpers.ThongBaoThanhCong(this, "Thanh tóa hóa đơn");
                emptyData();
                loadAllData();
            }
            else
            {
                Notification_Helpers.ThongBaoLoi(this, "Không thể thanh toán");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhSachHoaDon.SelectedRows.Count > 0)
            {
                // Lấy MaHoaDon từ dòng được chọn
                string maHoaDon = dataGridViewDanhSachHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value.ToString();

                DBConnect dbConnect = new DBConnect();

                // Tạo một instance của formChiTietHoaDon
                frmChiTietHoaDon frmChiTietHoaDon = new frmChiTietHoaDon(dbConnect, maHoaDon);

                // Hiển thị formChiTietHoaDon
                frmChiTietHoaDon.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
