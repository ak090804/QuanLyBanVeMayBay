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
using System.Data.SqlClient;


namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmQuanLyGiamGia : Form
    {
        private DBConnect dbConn;
        public frmQuanLyGiamGia(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }
        private void emptyData()
        {
            lblMaGiamGiaIP.Text = "[MaGiamGia]";
            cboCode.Text = "";
            cboMucGiamGia.Text = "";
            cboCode.Focus();
        }

        private void loadAllData()
        {
            FIllData.fillDataGridView(dataGridViewDanhSachGiamGia, dbConn, "select * from GiamGia ", "GiamGia");
        }

        private void loadCboCode()
        {
            dbConn.openConnect();
            string cauTruyVan = "SELECT code, code FROM GiamGia";  
            FIllData.fillDataCbo(cboCode, dbConn, cauTruyVan, "code", "code");
            dbConn.closeConnect();
        }
        private void loadCboMucGiamGia()
        {
            dbConn.openConnect();
            string cauTruyVan = "SELECT mucGiamGia, mucGiamGia FROM GiamGia";  
            FIllData.fillDataCbo(cboMucGiamGia, dbConn, cauTruyVan, "mucGiamGia", "mucGiamGia");
            dbConn.closeConnect();
        }

        private void frmQuanLyGiamGia_Load(object sender, EventArgs e)
        {
            loadAllData();
            loadCboCode();
            loadCboMucGiamGia();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                GiamGia tmp = new GiamGia(CacHamKiemTra.KiemTraChuoiRong(cboCode.Text), float.Parse(CacHamKiemTra.KiemTraChuoiRong(cboMucGiamGia.Text)));

                if (tmp.ThemMaGiamGia(dbConn))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm mã giảm giá thành công");
                    emptyData();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Thêm mã thành công thất bại");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void fillData(DataGridViewRow rows)
        {
            lblMaGiamGiaIP.Text = FIllData.GetValueDGVRows(rows, "MaGiamGia");

            cboCode.Text = FIllData.GetValueDGVRows(rows, "Code");

            cboMucGiamGia.Text = FIllData.GetValueDGVRows(rows, "MucGiamGia");

        }

        private void dataGridViewDanhSachGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emptyData();
            fillData(dataGridViewDanhSachGiamGia.Rows[e.RowIndex]);
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            emptyData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                GiamGia tmp = new GiamGia(CacHamKiemTra.KiemTraChuoiRong(cboCode.Text), float.Parse(CacHamKiemTra.KiemTraChuoiRong(cboMucGiamGia.Text))); string maGiamGia = "";
                if (lblMaGiamGiaIP.Text != "[MaGiamGia]")
                {
                    maGiamGia = CacHamKiemTra.KiemTraChuoiRong(lblMaGiamGiaIP.Text);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn mã giảm giá để xóa");
                }

                if (tmp.XoaMaGiamGia(dbConn, maGiamGia))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa mã giảm giá thành công");
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
                GiamGia tmp = new GiamGia(CacHamKiemTra.KiemTraChuoiRong(cboCode.Text), float.Parse(CacHamKiemTra.KiemTraChuoiRong(cboMucGiamGia.Text)));
                string maGiamGia = lblMaGiamGiaIP.Text.ToString();
                if (CacHamKiemTra.KiemTraChuoiRong(cboCode.Text) == "")
                {
                    cboCode.Text = "";
                    cboMucGiamGia.Text = "";
                }
                else
                {
                    try
                    {
                        tmp.SuaMaGiamGia(dbConn, maGiamGia);
                        Notification_Helpers.ThongBaoThanhCong(this, "Sửa mã giảm giá thành công");
                        emptyData();
                        loadAllData();
                    }
                    catch (Exception ex)
                    {
                        throw;
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

