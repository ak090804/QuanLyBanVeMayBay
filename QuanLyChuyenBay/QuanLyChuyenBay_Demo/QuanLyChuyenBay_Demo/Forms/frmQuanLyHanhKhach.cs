using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;
using TheArtOfDevHtmlRenderer.Adapters;


namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmQuanLyHanhKhach : Form
    {
        private DBConnect dbConn;
        public frmQuanLyHanhKhach(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }
        private void emptyData()
        {
            lblMaHanhKhachOutPut.Text = "[MaHanhKhach]";
            txtHoten.Clear();
            txtDiachi.Clear();
            txtQuoctich.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            dateTimePickerNgaysinh.Value = DateTime.Now;
            txtSodienthoai.Clear();
            txtEmail.Clear();
            txtCCCD_Passport.Clear();
            cboTenkhachhang.SelectedIndex = -1;

            txtHoten.Focus();
        }
        private string GetRealDataOfComboBox(ComboBox cbo)
        {
            ComboBoxItem cbi = (ComboBoxItem)cbo.SelectedItem;
            return cbi.Value.ToString();
        }
        private void loadAllData()
        {
            LoadCBO();
            FIllData.fillDataGridView(dataGridViewDanhSachHangKhach, dbConn, "SELECT * FROM HanhKhach", "HanhKhach");
            
        }
        private void LoadCBO()
        {
            FIllData.fillDataCbo(cboTenkhachhang, dbConn, "SELECT * FROM KhachHang", "HoTen", "MaKhachHang");
        }

        private void fillData(DataGridViewRow rows)
        {
            lblMaHanhKhachOutPut.Text = FIllData.GetValueDGVRows(rows, "MaHanhKhach");
            txtHoten.Text = FIllData.GetValueDGVRows(rows, "HoTen");
            txtDiachi.Text = FIllData.GetValueDGVRows(rows, "DiaChi");
            txtQuoctich.Text = FIllData.GetValueDGVRows(rows, "QuocTich");
            string gioiTinh = FIllData.GetValueDGVRows(rows, "GioiTinh");
            if (gioiTinh == "Nam") radNam.Checked = true;
            if (gioiTinh == "Nữ") radNu.Checked = true;

            string ngaySinh = FIllData.GetValueDGVRows(rows, "NgaySinh");
            if (DateTime.TryParse(ngaySinh, out DateTime dateValue))
            {
                dateTimePickerNgaysinh.Value = dateValue;
            }

            txtSodienthoai.Text = FIllData.GetValueDGVRows(rows, "SoDienThoai");
            txtEmail.Text = FIllData.GetValueDGVRows(rows, "Email");
            txtCCCD_Passport.Text = FIllData.GetValueDGVRows(rows, "CCCD_Passport");
            //cboTenkhachhang.Text = FIllData.GetValueDGVRows(rows, "MaKhachHang");
            // Lấy mã khách hàng từ DataGridView
            string maKhachHang = FIllData.GetValueDGVRows(rows, "MaKhachHang");

            // Duyệt qua các mục trong ComboBox để tìm tên khách hàng tương ứng với mã khách hàng
            for (int i = 0; i < cboTenkhachhang.Items.Count; i++)
            {
                ComboBoxItem item = (ComboBoxItem)cboTenkhachhang.Items[i];
                if (item.Value.ToString() == maKhachHang)  
                {
                    cboTenkhachhang.SelectedIndex = i;
                }
            }
        }

        private bool KiemTraRong()
        {
            // Kiểm tra các TextBox
            if (string.IsNullOrEmpty(txtHoten.Text))
            {
                Notification_Helpers.ThongBaoLoi(this, "Họ tên không được để trống.");
                txtHoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                Notification_Helpers.ThongBaoLoi(this, "Địa chỉ không được để trống.");
                txtDiachi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtQuoctich.Text))
            {
                Notification_Helpers.ThongBaoLoi(this, "Quốc tịch không được để trống.");
                txtQuoctich.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSodienthoai.Text))
            {
                Notification_Helpers.ThongBaoLoi(this, "Số điện thoại không được để trống.");
                txtSodienthoai.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Notification_Helpers.ThongBaoLoi(this, "Email không được để trống.");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCCCD_Passport.Text))
            {
                Notification_Helpers.ThongBaoLoi(this, "CCCD/Passport không được để trống.");
                txtCCCD_Passport.Focus();
                return false;
            }

            // Kiểm tra các ComboBox
            if (string.IsNullOrEmpty(cboTenkhachhang.Text))
            {
                Notification_Helpers.ThongBaoLoi(this, "Tên khách hàng không được để trống.");
                cboTenkhachhang.Focus();
                return false;
            }

            // Kiểm tra các RadioButton (Giới tính)
            if (!radNam.Checked && !radNu.Checked)
            {
                Notification_Helpers.ThongBaoLoi(this, "Giới tính không được để trống.");
                return false;
            }

            // Kiểm tra ngày sinh
            if (dateTimePickerNgaysinh.Value == null || dateTimePickerNgaysinh.Value == DateTime.MinValue)
            {
                Notification_Helpers.ThongBaoLoi(this, "Ngày sinh không được để trống.");
                dateTimePickerNgaysinh.Focus();
                return false;
            }

            return true;  
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                 string hoTen = CacHamKiemTra.KiemTraChuoiRong(txtHoten.Text); 
                string diaChi = txtDiachi.Text;  
                string quocTich = txtQuoctich.Text;  
                string gioiTinh = radNam.Checked ? "Nam" : radNu.Checked ? "Nữ" : "";  
                string ngaySinh = dateTimePickerNgaysinh.Value.ToString("yyyy-MM-dd");  
                string soDienThoai = txtSodienthoai.Text; 
                string email = txtEmail.Text;  
                string cccd = txtCCCD_Passport.Text;  
                int maKhachHang = int.Parse(GetRealDataOfComboBox(cboTenkhachhang));
                

                 HanhKhach hk = new HanhKhach(
                    hoTen,
                    diaChi,
                    gioiTinh,
                    quocTich,
                    ngaySinh,
                    soDienThoai,
                    email,
                    cccd,
                    maKhachHang
                );


                // Thêm hành khách vào cơ sở dữ liệu
                if (hk.ThemHanhKhach(dbConn))
                {
                     Notification_Helpers.ThongBaoThanhCong(this, "Thêm hành khách");
                    emptyData();  
                    loadAllData(); 
                }
                else
                {
                     Notification_Helpers.ThongBao(this, "Thêm hành khách thất bại.");
                }
            }
            catch (Exception ex)
            {
                 Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void dataGridViewDanhSachHangKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emptyData();
            fillData(dataGridViewDanhSachHangKhach.Rows[e.RowIndex]);
        }

        private void frmQuanLyHanhKhach_Load(object sender, EventArgs e)
        {
            loadAllData();  
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            emptyData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maHanhKhach = 0;

                // Kiểm tra nếu mã hành khách có hợp lệ
                if (lblMaHanhKhachOutPut.Text != "[Mã hành khách]")
                {
                    maHanhKhach = int.Parse(CacHamKiemTra.KiemTraChuoiRong(lblMaHanhKhachOutPut.Text));
                }


                HanhKhach hanhKhach = new HanhKhach();

                // Nếu chưa đặt vé, tiến hành xóa hành khách
                if (hanhKhach.XoaHanhKhach(dbConn, maHanhKhach))
                {
                     Notification_Helpers.ThongBaoThanhCong(this, "Xóa hành khách thành công.");
                    emptyData();    
                    loadAllData();     
                }
                else
                {
                     Notification_Helpers.ThongBao(this, "Không thể xóa hành khách này.");
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
                 int maHanhKhach = 0;

                if (lblMaHanhKhachOutPut.Text != "[Mã hành khách]")
                {
                    maHanhKhach = int.Parse(CacHamKiemTra.KiemTraChuoiRong(lblMaHanhKhachOutPut.Text));
                }

                 string hoTen = !string.IsNullOrWhiteSpace(txtHoten.Text) ? txtHoten.Text : FIllData.GetValueDGVRows(dataGridViewDanhSachHangKhach.CurrentRow, "HoTen");
                string diaChi = !string.IsNullOrWhiteSpace(txtDiachi.Text) ? txtDiachi.Text : FIllData.GetValueDGVRows(dataGridViewDanhSachHangKhach.CurrentRow, "DiaChi");
                string quocTich = !string.IsNullOrWhiteSpace(txtQuoctich.Text) ? txtQuoctich.Text : FIllData.GetValueDGVRows(dataGridViewDanhSachHangKhach.CurrentRow, "QuocTich");
                string gioiTinh = radNam.Checked ? "Nam" : radNu.Checked ? "Nữ" : FIllData.GetValueDGVRows(dataGridViewDanhSachHangKhach.CurrentRow, "GioiTinh");
                DateTime ngaySinh = dateTimePickerNgaysinh.Value != DateTime.MinValue ? dateTimePickerNgaysinh.Value : DateTime.Parse(FIllData.GetValueDGVRows(dataGridViewDanhSachHangKhach.CurrentRow, "NgaySinh"));
                string soDienThoai = !string.IsNullOrWhiteSpace(txtSodienthoai.Text) ? txtSodienthoai.Text : FIllData.GetValueDGVRows(dataGridViewDanhSachHangKhach.CurrentRow, "SoDienThoai");
                string email = !string.IsNullOrWhiteSpace(txtEmail.Text) ? txtEmail.Text : FIllData.GetValueDGVRows(dataGridViewDanhSachHangKhach.CurrentRow, "Email");
                string cccdPassport = !string.IsNullOrWhiteSpace(txtCCCD_Passport.Text) ? txtCCCD_Passport.Text : FIllData.GetValueDGVRows(dataGridViewDanhSachHangKhach.CurrentRow, "CCCD_Passport");

                // Lấy mã khách hàng từ ComboBox hoặc giữ giá trị cũ
                int maKhachHang = cboTenkhachhang.SelectedValue != null
                    ? int.Parse(cboTenkhachhang.SelectedValue.ToString())
                    : int.Parse(FIllData.GetValueDGVRows(dataGridViewDanhSachHangKhach.CurrentRow, "MaKhachHang"));

                 HanhKhach hanhKhach = new HanhKhach(hoTen, diaChi, gioiTinh, quocTich, ngaySinh.ToString("yyyy-MM-dd"), soDienThoai, email, cccdPassport, maKhachHang);

                // Gọi phương thức sửa thông tin hành khách
                if (hanhKhach.SuaHanhKhach(dbConn, maHanhKhach))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Cập nhật hành khách thành công!");
                    emptyData();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Cập nhật hành khách thất bại!");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        
    }
}
