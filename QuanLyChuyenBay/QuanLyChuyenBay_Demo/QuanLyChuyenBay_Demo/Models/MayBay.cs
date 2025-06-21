using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class MayBay
    {

        public string TenMayBay { get; set; }
        public int SucChuaToiDa { get; set; }
        public MayBay(string pTenMayBay, int pSucChuaToiDa)
        {
            TenMayBay = pTenMayBay;
            SucChuaToiDa = pSucChuaToiDa;
        }


        // Phương thức để thêm máy bay mới
        public bool ThemMayBay(DBConnect dbConn)
        {
            try
            {
                if (KiemTraTonTaiMayBay(dbConn))
                {
                    throw new Exception("Máy bay với tên '" + TenMayBay + "' đã tồn tại!");
                }

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_ThemMayBay";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TenMayBay", TenMayBay);
                    cmd.Parameters.AddWithValue("@SucChuaToiDa", SucChuaToiDa);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        dbConn.closeConnect();
                        return true;
                    }
                    catch (SqlException sqlEx)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Phương thức kiểm tra xem máy bay đã tồn tại hay chưa
        public bool KiemTraTonTaiMayBay(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "SELECT dbo.fn_KiemTraTonTaiMayBay(@TenMayBay)";
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@TenMayBay", TenMayBay);

                    var result = cmd.ExecuteScalar();
                    dbConn.closeConnect();

                    // Nếu kết quả là 1 thì máy bay đã tồn tại
                    return result != null && Convert.ToInt32(result) == 1;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Phương thức để xóa máy bay
        public bool XoaMayBay(DBConnect dbConn, string pMaMayBay)
        {
            try
            {
                // Kiểm tra xem máy bay có đang được sử dụng không
                if (KiemTraMayBayDuocDung(dbConn, pMaMayBay))
                {
                    throw new Exception("Máy bay này đang được sử dụng trong chuyến bay, không thể xóa!");
                }

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_XoaMayBay";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaMayBay", pMaMayBay);

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Phương thức để kiểm tra xem máy bay có đang được sử dụng trong chuyến bay nào không
        public bool KiemTraMayBayDuocDung(DBConnect dbConn, string pMaMayBay)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "SELECT dbo.fn_KiemTraMayBayDuocDung(@MaMayBay)";
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@MaMayBay", pMaMayBay);

                    var result = cmd.ExecuteScalar();
                    dbConn.closeConnect();

                    // Nếu kết quả là 1 thì máy bay đang được sử dụng
                    return result != null && Convert.ToInt32(result) == 1;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool SuaThongTinMayBay(DBConnect dbConn, string pMaMayBay)
        {
            try
            {
                if (KiemTraTonTaiMayBay(dbConn))
                {
                    throw new Exception("Máy bay với tên '" + TenMayBay + "' đã tồn tại! Không thể sửa!");
                }

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaTTMayBay";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền các tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaMayBay", pMaMayBay);
                    cmd.Parameters.AddWithValue("@TenMayBay", TenMayBay);
                    cmd.Parameters.AddWithValue("@SucChuaToiDa", SucChuaToiDa);

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
