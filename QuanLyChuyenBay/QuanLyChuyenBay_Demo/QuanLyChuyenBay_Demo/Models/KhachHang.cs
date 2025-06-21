using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class KhachHang
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string NgaySinh { get; set; }
        public string SDT { get; set; }

        public KhachHang(string pHoTen, string pDiaChi, string pEmail, string pNgaySinh, string pSDT)
        {
            HoTen = pHoTen;
            DiaChi = pDiaChi;
            Email = pEmail;
            NgaySinh = pNgaySinh;
            SDT = pSDT;
        }

        public void capNhapThongTinKhach(DBConnect dbConn, string maKH)
        {
            try
            {
                dbConn.openConnect();

                // Tạo lệnh SQL để gọi stored procedure.
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dbConn.conn;
                cmd.CommandText = "sp_UpdateKhachHang";
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cần thiết cho stored procedure.
                cmd.Parameters.AddWithValue("@HoTen", HoTen ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh == null ? (object)DBNull.Value : DateTime.Parse(NgaySinh));
                cmd.Parameters.AddWithValue("@SoDienThoai", SDT ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", maKH);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                // Đảm bảo đóng kết nối sau khi xong.
                if (dbConn.conn.State == ConnectionState.Open)
                {
                    dbConn.closeConnect();
                }
            }
        }
    }
}
