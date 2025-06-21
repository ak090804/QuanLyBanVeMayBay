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
    public partial class frmQuanLyTaiKhoan : Form
    {
        private DBConnect dbConn;
        public frmQuanLyTaiKhoan(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }

        private void emptyData()
        {
            txtMatKhau.Clear();
            txtTaiKhoan.Clear();
            lblMaTaiKhoan.Text = "[MaTaiKhoan]";

            txtTaiKhoan.Focus();
        }

        private void loadAllData()
        {
            FIllData.fillDataGridView(dgvTaiKhoan, dbConn, "select * from TaiKhoan", "TaiKhoan");
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loadAllData();
        }

        private void btnLoadTaiKhoan_Click(object sender, EventArgs e)
        {
            emptyData();
            loadAllData();
        }

        private bool KiemTraTextBoxTrong()
        {
            if (CacHamKiemTra.KiemTraChuoiRong(txtMatKhau.Text) == "" && CacHamKiemTra.KiemTraChuoiRong(txtTaiKhoan.Text) == "")
            {
                return true;
            }
            return false;
        }

        private int randNum(){
            Random random = new Random();

            int randomNumber = random.Next();
            return randomNumber;
        }
        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tmp = new TaiKhoan(CacHamKiemTra.KiemTraChuoiRong(txtTaiKhoan.Text), CacHamKiemTra.KiemTraChuoiRong(txtMatKhau.Text));

                if (tmp.TaoTaiKhoan(dbConn,""))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Tạo tài khoản");
                    emptyData();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Tạo tài khoản thất bại");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void fillData(DataGridViewRow rows)
        {
            lblMaTaiKhoan.Text = FIllData.GetValueDGVRows(rows, "MaTaiKhoan");

            txtMatKhau.Text = FIllData.GetValueDGVRows(rows, "MatKhau");

            txtTaiKhoan.Text = FIllData.GetValueDGVRows(rows, "TenTaiKhoan");

        }
        private void dgvTaiKhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            emptyData();
            fillData(dgvTaiKhoan.Rows[e.RowIndex]);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tmp = new TaiKhoan(CacHamKiemTra.KiemTraChuoiRong(txtTaiKhoan.Text), CacHamKiemTra.KiemTraChuoiRong(txtMatKhau.Text));
                string maTaiKhoan = "";
                if (lblMaTaiKhoan.Text != "[MaTaiKhoan]")
                {
                    maTaiKhoan = CacHamKiemTra.KiemTraChuoiRong(lblMaTaiKhoan.Text);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this,"Vui lòng chọn tài khoản để xóa");
                }

                if (tmp.XoaTaiKhoan(dbConn,maTaiKhoan))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa tài khoản");
                    emptyData();
                    loadAllData();
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tmp = new TaiKhoan(CacHamKiemTra.KiemTraChuoiRong(txtTaiKhoan.Text), CacHamKiemTra.KiemTraChuoiRong(txtMatKhau.Text));
                if (tmp.MatKhau == txtMatKhau.Text)
                {
                    Notification_Helpers.ThongBao(this,"Bạn chưa nhập mật khẩu mới!");
                    txtMatKhau.Clear();
                }
                else if (CacHamKiemTra.KiemTraChuoiRong(txtMatKhau.Text) =="")
                {
                    txtMatKhau.Clear();
                }
                else
                {
                    if (tmp.CapNhatTaiKhoan(dbConn))
                    {
                        Notification_Helpers.ThongBaoThanhCong(this, "Đổi mật khẩu");
                        emptyData();
                        loadAllData();
                    }
                    else
                    {
                        Notification_Helpers.ThongBaoLoi(this, "Không thể đổi mật khẩu");
                    }
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        

        private void btnGoQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tmp = new TaiKhoan(CacHamKiemTra.KiemTraChuoiRong(txtTaiKhoan.Text), CacHamKiemTra.KiemTraChuoiRong(txtMatKhau.Text));
                string maTaiKhoan = "";
                if (lblMaTaiKhoan.Text != "[MaTaiKhoan]")
                {
                    maTaiKhoan = CacHamKiemTra.KiemTraChuoiRong(lblMaTaiKhoan.Text);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn tài khoản để gỡ quyền");
                }

                if (tmp.GoQuyen())
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Gỡ quyền");
                    emptyData();
                    loadAllData();
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tmp = new TaiKhoan(CacHamKiemTra.KiemTraChuoiRong(txtTaiKhoan.Text), CacHamKiemTra.KiemTraChuoiRong(txtMatKhau.Text));
                string maTaiKhoan = "";
                if (lblMaTaiKhoan.Text != "[MaTaiKhoan]")
                {
                    maTaiKhoan = CacHamKiemTra.KiemTraChuoiRong(lblMaTaiKhoan.Text);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn tài khoản để cấp quyền");
                }

                if (tmp.ThemQuyenMember())
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Cấp quyền");
                    emptyData();
                    loadAllData();
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
    }
}
