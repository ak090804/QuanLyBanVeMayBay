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
    public partial class frmQuanLyTienIch : Form
    {
        private DBConnect dbConn;
        public frmQuanLyTienIch(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }
        private void emptyData()
        {
            lblMatienichIP.Text = "[MaMayBay]";
            txtTentienich.Clear();
            txtGiatienich.Clear();
            cboLoaiTienIch.Text = "";

            txtTentienich.Focus();
        }

        private void loadAllData()
        {
            FIllData.fillDataGridView(dataGridViewDanhSachTienIch, dbConn, "select t.MaTienIch, t.TenTienIch, t.GiaTienIch, l.TenLoaiTienIch from TienIch t, LoaiTienIch l where t.MaLoaiTienIch = l.MaLoaiTienIch", "TienIch");
            LoadCBO();
        }
        private void LoadCBO()
        {
            FIllData.fillDataCbo(cboLoaiTienIch, dbConn, "SELECT * FROM LoaiTienIch", "TenLoaiTienIch", "MaLoaiTienIch");

        }

        private void frmQuanLyTienIch_Load(object sender, EventArgs e)
        {
            loadAllData();
        }
        private string GetRealDataOfComboBox(ComboBox cbo)
        {
            ComboBoxItem cbi = (ComboBoxItem)cbo.SelectedItem;
            return cbi.Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                TienIch tmp = new TienIch(CacHamKiemTra.KiemTraChuoiRong(txtTentienich.Text), float.Parse(CacHamKiemTra.KiemTraChuoiRong(txtGiatienich.Text)), int.Parse(GetRealDataOfComboBox(cboLoaiTienIch)));

                if (tmp.ThemTienIch(dbConn))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm tiện ích");
                    emptyData();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Thêm tiện ích thất bại");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void fillData(DataGridViewRow rows)
        {
            lblMatienichIP.Text = FIllData.GetValueDGVRows(rows, "MaTienIch");

            txtTentienich.Text = FIllData.GetValueDGVRows(rows, "TenTienIch");

            txtGiatienich.Text = FIllData.GetValueDGVRows(rows, "GiaTienIch");

            cboLoaiTienIch.Text = FIllData.GetValueDGVRows(rows, "TenLoaiTienIch");

        }

        private void dataGridViewDanhSachMayBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emptyData();
            fillData(dataGridViewDanhSachTienIch.Rows[e.RowIndex]);
        }

        private void dataGridViewDanhSachTienIch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emptyData();
            fillData(dataGridViewDanhSachTienIch.Rows[e.RowIndex]);
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            emptyData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                TienIch tmp = new TienIch(CacHamKiemTra.KiemTraChuoiRong(txtTentienich.Text), float.Parse(CacHamKiemTra.KiemTraChuoiRong(txtGiatienich.Text)), int.Parse(GetRealDataOfComboBox(cboLoaiTienIch)));
                string maTienIch = "";
                if (lblMatienichIP.Text != "[MaTienIch]")
                {
                    maTienIch = CacHamKiemTra.KiemTraChuoiRong(lblMatienichIP.Text);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn tiện ích để xóa");
                }

                if (tmp.XoaTienIch(dbConn, maTienIch))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa tiện ích");
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
                TienIch tmp = new TienIch(CacHamKiemTra.KiemTraChuoiRong(txtTentienich.Text), float.Parse(CacHamKiemTra.KiemTraChuoiRong(txtGiatienich.Text)), int.Parse(GetRealDataOfComboBox(cboLoaiTienIch)));
                string maTienIch = lblMatienichIP.Text;
                if (CacHamKiemTra.KiemTraChuoiRong(txtTentienich.Text) == "")
                {
                    txtTentienich.Clear();
                    txtGiatienich.Clear();
                }
                else
                {
                    if (tmp.SuaThongTinTienIch(dbConn, maTienIch))
                    {
                        Notification_Helpers.ThongBaoThanhCong(this, "Sửa thông tin tiện ích thành công");
                        emptyData();
                        loadAllData();
                    }
                    else
                    {
                        Notification_Helpers.ThongBaoLoi(this, "Không thể sửa thông tin tiện ích");
                    }
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


    }
}
