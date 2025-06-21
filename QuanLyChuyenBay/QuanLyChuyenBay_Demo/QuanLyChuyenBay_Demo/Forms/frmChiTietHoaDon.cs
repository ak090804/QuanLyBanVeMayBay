using QuanLyChuyenBay_Demo.Helpers;
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
    public partial class frmChiTietHoaDon : Form
    {
        private DBConnect dbConn;
        private string _maHoaDon;

        public frmChiTietHoaDon(DBConnect dbConn, string maHoaDon)
        {
            InitializeComponent();
            this.dbConn = dbConn;
            _maHoaDon = maHoaDon;
        }

        

        private void LoadChiTietHoaDon(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();

                // Thực hiện truy vấn SQL để lấy thông tin chi tiết hóa đơn
                string query = @"SELECT kh.HoTen AS HoTen, hd.MaHoaDon, SoLuongHanhKhach as SoLuongVe, pd.NgayDat, cb.NgayGioDi AS NgayDi, cb.NgayGioDen AS NgayDen, hd.TongTien
                                FROM HoaDon hd
                                JOIN PhieuDat pd ON hd.MaPhieuDat = pd.MaPhieuDat
                                JOIN Ve ve ON pd.MaKhachHang = ve.MaHanhKhach
                                JOIN ChiTietVe ctv ON ve.MaVe = ctv.MaVe
                                JOIN ChuyenBay cb ON ctv.MaChuyenBay = cb.MaChuyenBay
                                JOIN KhachHang kh ON pd.MaKhachHang = kh.MaKhachHang
                                WHERE hd.MaHoaDon = @IdHoaDon;
                                ";



                using (SqlCommand cmd = new SqlCommand(query, dbConn.conn))
                {
                    cmd.Parameters.AddWithValue("@IdHoaDon", _maHoaDon);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Gán dữ liệu vào các label
                            lblMaHoaDonOP.Text = reader["MaHoaDon"].ToString();
                            lblTenKhachHangOP.Text = reader["HoTen"].ToString();
                            VeOP.Text = reader["SoLuongVe"].ToString();
                            lblNgayDatOP.Text = Convert.ToDateTime(reader["NgayDat"]).ToString("dd/MM/yyyy");
                            lblNgayDiOP.Text = Convert.ToDateTime(reader["NgayDi"]).ToString("dd/MM/yyyy HH:mm:ss");
                            lblNgayDenOP.Text = Convert.ToDateTime(reader["NgayDen"]).ToString("dd/MM/yyyy HH:mm:ss");
                            lblTongTienOP.Text = Convert.ToDecimal(reader["TongTien"]).ToString("C");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin chi tiết hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadChiTietHoaDon(dbConn);

        }

        
    }
}
