using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuyenBay_Demo.Helpers;
using System.Data;

namespace QuanLyChuyenBay_Demo.Models
{
    internal class PhieuDat
    {
        public int MaPhieuDat { get; set; }
        public int MaKhachHang { get; set; }
        public DateTime NgayDat { get; set; }
        public int SoLuongHanhKhach { get; set; }
        public int mave { get; set; }
        public PhieuDat() { }

        public PhieuDat(int maKhachHang, DateTime ngayDat)
        {
            MaKhachHang = maKhachHang;
            NgayDat = ngayDat;
        }

      


        public bool TaoPhieuDat(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();  

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_TaoPhieuDat";  
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang); 
                    cmd.Parameters.AddWithValue("@NgayDat", NgayDat);  

                     SqlParameter outputParameter = new SqlParameter("@MaPhieuDat", SqlDbType.Int);
                    outputParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParameter);

                    try
                    {
                         cmd.ExecuteNonQuery();

                         MaPhieuDat = Convert.ToInt32(outputParameter.Value);

                        dbConn.closeConnect();  

                         return true;
                    }
                    catch (SqlException sqlEx)
                    {
                         throw new Exception("Lỗi khi tạo phiếu đặt: " + sqlEx.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                 throw new Exception("Lỗi khi thực thi tạo phiếu đặt: " + ex.Message);
            }
        }

        public bool TaoChiTietPhieuDat(DBConnect dbConn, string maHK)
        {
            try
            {
                dbConn.openConnect();   

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_TaoChiTietPhieuDat"; 
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat); // Mã phiếu đặt
                    cmd.Parameters.AddWithValue("@MaVe",mave ); // Mã vé
                    cmd.Parameters.AddWithValue("@MaHK", maHK);

                    try
                    {
                         cmd.ExecuteNonQuery();
                        dbConn.closeConnect();  
                        return true;  
                    }
                    catch (SqlException sqlEx)
                    {
                         throw new Exception("Lỗi khi tạo chi tiết phiếu đặt: " + sqlEx.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                 throw new Exception("Lỗi khi thực thi tạo chi tiết phiếu đặt: " + ex.Message);
            }
        }
        public bool KiemTraPhiuDatCoHoaDon(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "dbo.fn_KiemTraPhiuDatCoHoaDon";  
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);

                    object result = cmd.ExecuteScalar(); 
                    dbConn.closeConnect();
                    return Convert.ToBoolean(result);  
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw new Exception("Lỗi khi kiểm tra hóa đơn: " + ex.Message);
            }
        }

        // Kiểm tra phiếu đặt có liên kết với tiện ích
        public bool KiemTraPhiuDatCoTienIch(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "dbo.fn_KiemTraPhiuDatCoTienIch";  
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);

                    object result = cmd.ExecuteScalar();  
                    dbConn.closeConnect();
                    return Convert.ToBoolean(result);  
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw new Exception("Lỗi khi kiểm tra tiện ích: " + ex.Message);
            }
        }
        public bool XoaPhieuDat(DBConnect dbConn)
        {
            try
            {
                 SqlCommand cmd = new SqlCommand("sp_XoaPhieuDat", dbConn.conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);

                 if (KiemTraPhiuDatCoHoaDon(dbConn))
                {
                    Notification_Helpers.ThongBaoLoi(null, "Không thể xóa phiếu đặt vì đã có hóa đơn.");
                    return false;
                }

                if (KiemTraPhiuDatCoTienIch(dbConn))
                {
                    Notification_Helpers.ThongBaoLoi(null, "Không thể xóa phiếu đặt vì đã có tiện ích.");
                    return false;
                }

                dbConn.openConnect();
                cmd.ExecuteNonQuery();
                dbConn.closeConnect();

                return true;  
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw new Exception("Lỗi khi xóa phiếu đặt: " + ex.Message);
            }
        }
        public bool SuaPhieuDat(DBConnect dbConn, int maPhieuDat)
        {
            try
            {
                 dbConn.openConnect();

                 using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaPhieuDat";  
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    cmd.Parameters.AddWithValue("@MaPhieuDat", maPhieuDat);  
                    cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);  
                    cmd.Parameters.AddWithValue("@NgayDat", NgayDat);          

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();

                     dbConn.closeConnect();

                    return true;   
                }
            }
            catch (Exception ex)
            {
                 dbConn.closeConnect();
                throw new Exception("Lỗi khi sửa phiếu đặt: " + ex.Message);
            }
        }
        public bool XoaVeTrongChiTietPhieuDat(DBConnect dbConn, int maPhieuDat,int maVe)
        {
            try
            {
               
                

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_XoaVeTrongPhieuDat"; // Gọi stored procedure đã tạo
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaPhieuDat", maPhieuDat); // Mã phiếu đặt
                    cmd.Parameters.AddWithValue("@MaVe", maVe); // Mã phiếu đặt



                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();

                    return true;
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw new Exception("Lỗi khi xóa vé trong chi tiết phiếu đặt: " + ex.Message);
            }
        }
        public bool SuaVeTrongPhieuDat(DBConnect dbConn, int maphieudat,int mave)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaChiTietVeTrongPhieuDat";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền các tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaPhieuDat", maphieudat);
                    cmd.Parameters.AddWithValue("@MaVe", mave);  // Cập nhật mã vé

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa vé: " + ex.Message);
            }
        }






    }




}
