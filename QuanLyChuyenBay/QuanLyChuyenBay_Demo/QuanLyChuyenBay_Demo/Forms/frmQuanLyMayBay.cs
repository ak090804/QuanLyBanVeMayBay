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
    public partial class frmQuanLyMayBay : Form
    {
        private DBConnect dbConn;
        public frmQuanLyMayBay(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }

        private void emptyData()
        {
            lblMamaybayIP.Text = "[MaMayBay]";
            txtTenmaybay.Clear();
            txtSucchua.Clear();

            txtTenmaybay.Focus();
        }

        private void loadAllData()
        {
            FIllData.fillDataGridView(dataGridViewDanhSachMayBay, dbConn, "select * from MayBay", "MayBay");
        }

        private void frmQuanLyMayBay_Load(object sender, EventArgs e)
        {
            loadAllData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MayBay tmp = new MayBay(CacHamKiemTra.KiemTraChuoiRong(txtTenmaybay.Text), int.Parse(CacHamKiemTra.KiemTraChuoiRong(txtSucchua.Text)));

                if (tmp.ThemMayBay(dbConn))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm máy bay");
                    emptyData();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Thêm máy bay thất bại");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
        private void fillData(DataGridViewRow rows)
        {
            lblMamaybayIP.Text = FIllData.GetValueDGVRows(rows, "MaMayBay");

            txtTenmaybay.Text = FIllData.GetValueDGVRows(rows, "TenMayBay");

            txtSucchua.Text = FIllData.GetValueDGVRows(rows, "SucChuaToiDa");

        }

        private void dataGridViewDanhSachMayBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emptyData();
            fillData(dataGridViewDanhSachMayBay.Rows[e.RowIndex]);
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            emptyData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                MayBay tmp = new MayBay(CacHamKiemTra.KiemTraChuoiRong(txtTenmaybay.Text), int.Parse(CacHamKiemTra.KiemTraChuoiRong(txtSucchua.Text)));
                string maMayBay = "";
                if (lblMamaybayIP.Text != "[MaMayBay]")
                {
                    maMayBay = CacHamKiemTra.KiemTraChuoiRong(lblMamaybayIP.Text);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn máy bay để xóa");
                }

                if (tmp.XoaMayBay(dbConn, maMayBay))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa máy bay");
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
                MayBay tmp = new MayBay(CacHamKiemTra.KiemTraChuoiRong(txtTenmaybay.Text), int.Parse(CacHamKiemTra.KiemTraChuoiRong(txtSucchua.Text)));
                string maMayBay = lblMamaybayIP.Text;
                if (CacHamKiemTra.KiemTraChuoiRong(txtTenmaybay.Text) == "")
                {
                    txtTenmaybay.Clear();
                    txtSucchua.Clear();
                }
                else
                {
                    if (tmp.SuaThongTinMayBay(dbConn, maMayBay))
                    {
                        Notification_Helpers.ThongBaoThanhCong(this, "Sửa thông tin máy bay thành công");
                        emptyData();
                        loadAllData();
                    }
                    else
                    {
                        Notification_Helpers.ThongBaoLoi(this, "Không thể sửa thông tin máy bay");
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

        private void lblSucchua_Click(object sender, EventArgs e)
        {

        }
    }
}
