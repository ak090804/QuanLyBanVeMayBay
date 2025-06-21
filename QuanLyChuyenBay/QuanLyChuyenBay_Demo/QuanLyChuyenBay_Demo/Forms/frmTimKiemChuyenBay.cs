using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmTimKiemChuyenBay : Form
    {
        private DBConnect dbConn;

        public frmTimKiemChuyenBay(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }

        private void loadAllData()
        {
            LoadCBO();
            string cauTruyVan = @"SELECT 
    c.MaChuyenBay,
    h.TenHangHangKhong,
    CASE 
        WHEN (SELECT COUNT(ctv.MaVe) 
              FROM ChiTietVe ctv 
              WHERE ctv.MaChuyenBay = c.MaChuyenBay 
                AND ctv.MaVe NOT IN (SELECT v.MaVe 
                                     FROM Ve v 
                                     WHERE v.MaHanhKhach IS NOT NULL)
             ) > 0 THEN CAST((SELECT COUNT(ctv.MaVe) 
                              FROM ChiTietVe ctv 
                              WHERE ctv.MaChuyenBay = c.MaChuyenBay 
                                AND ctv.MaVe NOT IN (SELECT v.MaVe 
                                                     FROM Ve v 
                                                     WHERE v.MaHanhKhach IS NOT NULL)
                             ) AS NVARCHAR)
        ELSE N'Hết vé'
    END AS SoLuongVe,
    l.TenLoTrinh,
    m.TenMayBay,
    c.GiaBay,
    c.NgayGioDi,
    c.NgayGioDen
FROM ChuyenBay c
JOIN HangHangKhong h ON c.MaHangHangKhong = h.MaHangHangKhong
JOIN LoTrinh l ON c.MaLoTrinh = l.MaLoTrinh
JOIN MayBay m ON c.MaMayBay = m.MaMayBay;
";
            FIllData.fillDataGridView(dataGridViewDanhSachChuyenBay, dbConn, cauTruyVan,"CacChuyenBay");
            dTPNgayDi.ShowCheckBox = true;  // Hiển thị checkbox để người dùng có thể chọn hay không chọn ngày.

        }

        private void LoadCBO()
        {
            // Load dữ liệu cho cboHangHangKhong từ bảng HangHangKhong
            FIllData.fillDataCbo(cboHangHangKhong, dbConn, "SELECT * FROM HangHangKhong", "TenHangHangKhong", "MaHangHangKhong");

            // Load dữ liệu cho cboTrangThai từ bảng TrangThaiChuyenBay
            FIllData.fillDataCbo(cboTrangThai, dbConn, "SELECT * FROM TrangThaiChuyenBay", "TenTrangThaiChuyenBay", "MaTrangThaiChuyenBay");

            // Load dữ liệu cho cboTenLoTrinh từ bảng LoTrinh
            FIllData.fillDataCbo(cboLoTrinh, dbConn, "SELECT * FROM LoTrinh", "TenLoTrinh", "MaLoTrinh");

            // Load dữ liệu cho cboTenmaybay từ bảng MayBay
            FIllData.fillDataCbo(cboTenMayBay, dbConn, "SELECT * FROM MayBay", "TenMayBay", "MaMayBay");
        }

        private void frmTimKiemChuyenBay_Load(object sender, EventArgs e)
        {
            loadAllData();
        }

        private string GetRealDataOfComboBox(ComboBox cbo)
        {
            ComboBoxItem cbi = (ComboBoxItem)cbo.SelectedItem;
            return cbi.Value.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị thực từ các ComboBox
            int? maHangHangKhong = null;
            int? maTrangThaiChuyenBay = null;
            int? maLoTrinh = null;
            int? maMayBay = null;
            DateTime? ngayDi = null;

            // Kiểm tra các ComboBox đã được chọn hay chưa và gán giá trị
            if (cboHangHangKhong.SelectedItem != null)
                maHangHangKhong = int.Parse(GetRealDataOfComboBox(cboHangHangKhong));

            if (cboTrangThai.SelectedItem != null)
                maTrangThaiChuyenBay = int.Parse(GetRealDataOfComboBox(cboTrangThai));

            if (cboLoTrinh.SelectedItem != null)
                maLoTrinh = int.Parse(GetRealDataOfComboBox(cboLoTrinh));

            if (cboTenMayBay.SelectedItem != null)
                maMayBay = int.Parse(GetRealDataOfComboBox(cboTenMayBay));

            // Kiểm tra DateTimePicker
            if (dTPNgayDi.Checked)
                ngayDi = dTPNgayDi.Value; // Nếu có chọn ngày thì lấy giá trị
            else
                ngayDi = null; // Nếu không chọn thì gán null

            // Mở kết nối đến cơ sở dữ liệu
            try
            {
                dbConn.openConnect();

                using (SqlCommand cmd = new SqlCommand("sp_TimKiemChuyenBay2", dbConn.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Truyền các tham số vào thủ tục
                    cmd.Parameters.AddWithValue("@MaHangHangKhong", maHangHangKhong.HasValue ? (object)maHangHangKhong.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaTrangThaiChuyenBay", maTrangThaiChuyenBay.HasValue ? (object)maTrangThaiChuyenBay.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaLoTrinh", maLoTrinh.HasValue ? (object)maLoTrinh.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaMayBay", maMayBay.HasValue ? (object)maMayBay.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@NgayDi", ngayDi.HasValue ? (object)ngayDi.Value : DBNull.Value);

                    // Thực hiện thủ tục và lấy dữ liệu
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridViewDanhSachChuyenBay.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy chuyến bay nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConn.closeConnect();
            }
        }

        
    }
}
