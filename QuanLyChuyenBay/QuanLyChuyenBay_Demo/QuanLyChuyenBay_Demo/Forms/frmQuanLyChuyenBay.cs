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
    public partial class frmQuanLyChuyenBay : Form
    {
        private DBConnect dbConn;
        public frmQuanLyChuyenBay(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }
        private void emptyData()
        {
            lblMaChuyenBayIP.Text = "[MaChuyenBay]";
            cboHangHangKhong.Text = "";
            cboTrangThai.Text = "";
            cboTenLoTrinh.Text = "";
            cboTenmaybay.Text = "";
            txtGiabay.Clear();

            cboHangHangKhong.Focus();
        }

        private void loadAllData()
        {
            LoadCBO();
            FIllData.fillDataGridView(dataGridViewDanhSachChuyenBay, dbConn, "SELECT c.MaChuyenBay, h.TenHangHangKhong, t.TenTrangThaiChuyenBay, l.TenLoTrinh, m.TenMayBay, c.GiaBay, c.NgayGioDi, c.NgayGioDen FROM ChuyenBay c, HangHangKhong h, TrangThaiChuyenBay t, LoTrinh l, MayBay m WHERE c.MaHangHangKhong = h.MaHangHangKhong AND c.MaTrangThaiChuyenBay = t.MaTrangThaiChuyenBay AND c.MaLoTrinh = l.MaLoTrinh AND c.MaMayBay = m.MaMayBay", "ChuyenBay");
        }

        private void frmQuanLyChuyenBay_Load(object sender, EventArgs e)
        {
            loadAllData();
        }
        private void fillData(DataGridViewRow rows)
        {
            lblMaChuyenBayIP.Text = FIllData.GetValueDGVRows(rows, "MaChuyenBay");

            cboHangHangKhong.Text = FIllData.GetValueDGVRows(rows, "TenHangHangKhong");

            cboTrangThai.Text = FIllData.GetValueDGVRows(rows, "TenTrangThaiChuyenBay");

            cboTenLoTrinh.Text = FIllData.GetValueDGVRows(rows, "TenLoTrinh");

            cboTenmaybay.Text = FIllData.GetValueDGVRows(rows, "TenMayBay");

            txtGiabay.Text = FIllData.GetValueDGVRows(rows, "GiaBay");

            string ngayGioDiString = FIllData.GetValueDGVRows(rows, "NgayGioDi");
            string ngayGioDenString = FIllData.GetValueDGVRows(rows, "NgayGioDen");

            if (DateTime.TryParse(ngayGioDiString, out DateTime ngayGioDi))
            {
                dTPNgayGioDi.Value = ngayGioDi;
            }

            if (DateTime.TryParse(ngayGioDenString, out DateTime ngayGioDen))
            {
                dTPNgayGioDen.Value = ngayGioDen;
            }
        }

        private void dataGridViewDanhSachChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emptyData();
            fillData(dataGridViewDanhSachChuyenBay.Rows[e.RowIndex]);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Chắc chắn rằng các giá trị tham số được truyền đúng
                int MaHangHangKhong = int.Parse(GetRealDataOfComboBox(cboHangHangKhong));
                int MaTrangThaiChuyenBay = int.Parse(GetRealDataOfComboBox(cboTrangThai));
                int MaLoTrinh = int.Parse(GetRealDataOfComboBox(cboTenLoTrinh));
                int MaMayBay = int.Parse(GetRealDataOfComboBox(cboTenmaybay));
                float GiaBay = float.Parse(CacHamKiemTra.KiemTraChuoiRong(txtGiabay.Text));
                DateTime NgayGioDi = dTPNgayGioDi.Value;
                DateTime NgayGioDen = dTPNgayGioDen.Value;

                // Kiểm tra ràng buộc ngày giờ đến phải sau ngày giờ đi
                if (NgayGioDen <= NgayGioDi)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Ngày giờ đến phải sau ngày giờ đi.");
                    return;
                }

                 
                ChuyenBay tmp = new ChuyenBay(MaHangHangKhong, MaTrangThaiChuyenBay, MaLoTrinh, MaMayBay, GiaBay, NgayGioDi, NgayGioDen);

                // Kiểm tra thêm chuyến bay mới
                if (tmp.ThemMoiChuyenBay(dbConn))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm chuyến bay");
                    emptyData();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Thêm chuyến bay thất bại");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
        private string GetRealDataOfComboBox(ComboBox cbo)
        {
            ComboBoxItem cbi = (ComboBoxItem)cbo.SelectedItem;
            return cbi.Value.ToString();
        }
        private void LoadCBO()
        {
             FIllData.fillDataCbo(cboHangHangKhong, dbConn, "SELECT * FROM HangHangKhong", "TenHangHangKhong", "MaHangHangKhong");

             FIllData.fillDataCbo(cboTrangThai, dbConn, "SELECT * FROM TrangThaiChuyenBay", "TenTrangThaiChuyenBay", "MaTrangThaiChuyenBay");

             FIllData.fillDataCbo(cboTenLoTrinh, dbConn, "SELECT * FROM LoTrinh", "TenLoTrinh", "MaLoTrinh");

             FIllData.fillDataCbo(cboTenmaybay, dbConn, "SELECT * FROM MayBay", "TenMayBay", "MaMayBay");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ChuyenBay tmp = new ChuyenBay(
                                    int.Parse(GetRealDataOfComboBox(cboHangHangKhong)),
                                    int.Parse(GetRealDataOfComboBox(cboTrangThai)),
                                    int.Parse(GetRealDataOfComboBox(cboTenLoTrinh)),
                                    int.Parse(GetRealDataOfComboBox(cboTenmaybay)),
                                    float.Parse(CacHamKiemTra.KiemTraChuoiRong(txtGiabay.Text)),
                                    dTPNgayGioDi.Value,
                                    dTPNgayGioDen.Value
                );
                int maChuyenBay = 0;
                if (lblMaChuyenBayIP.Text != "[maChuyenBay]")
                {
                    maChuyenBay = int.Parse(CacHamKiemTra.KiemTraChuoiRong(lblMaChuyenBayIP.Text));
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn chuyến bay để xóa");
                }

                if (tmp.XoaChuyenBay(dbConn, maChuyenBay))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa chuyến bay");
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
                DateTime NgayGioDi = dTPNgayGioDi.Value;
                DateTime NgayGioDen = dTPNgayGioDen.Value;

                // Kiểm tra ràng buộc ngày giờ đến phải sau ngày giờ đi
                if (NgayGioDen <= NgayGioDi)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Ngày giờ đến phải sau ngày giờ đi.");
                    return;
                }
                ChuyenBay tmp = new ChuyenBay(
                     int.Parse(GetRealDataOfComboBox(cboHangHangKhong)),
                     int.Parse(GetRealDataOfComboBox(cboTrangThai)),
                     int.Parse(GetRealDataOfComboBox(cboTenLoTrinh)),
                     int.Parse(GetRealDataOfComboBox(cboTenmaybay)),
                     float.Parse(CacHamKiemTra.KiemTraChuoiRong(txtGiabay.Text)),
                     NgayGioDi,
                     NgayGioDen
                );
                int maChuyenBay = int.Parse(lblMaChuyenBayIP.Text);
                if (CacHamKiemTra.KiemTraChuoiRong(cboHangHangKhong.Text) == "")
                {
                    emptyData();
                }
                else
                {
                    if (tmp.SuaTTChuyenBay(dbConn, maChuyenBay))
                    {
                        Notification_Helpers.ThongBaoThanhCong(this, "Sửa thông tin chuyến bay thành công");
                        emptyData();
                        loadAllData();
                    }
                    else
                    {
                        Notification_Helpers.ThongBaoLoi(this, "Không thể sửa thông tin chuyến bay");
                    }
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            emptyData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
