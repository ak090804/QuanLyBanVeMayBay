using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class TienIch
    {
        public string TenTienIch { get; set; }
        public float GiaTienIch { get; set; }
        public int MaLoaiSanPham { get; set; }
        public TienIch(string pTenTienIch, float pGiaTienIch, int pmaLoaiSanPham)
        {
            TenTienIch = pTenTienIch;
            GiaTienIch = pGiaTienIch;
            MaLoaiSanPham = pmaLoaiSanPham;
        }

        // Phương thức để thêm Tien ich mới
        public bool ThemTienIch(DBConnect dbConn)
        {
            try
            {
                if (KiemTraTonTaiTienIch(dbConn))
                {
                    throw new Exception("Tiện ích với tên '" + TenTienIch + "' đã tồn tại!");
                }

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_ThemTienIch";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TenTienIch", TenTienIch);
                    cmd.Parameters.AddWithValue("@GiaTienIch", GiaTienIch);
                    cmd.Parameters.AddWithValue("@MaLoaiTienIch", MaLoaiSanPham);

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

        // Phương thức kiểm tra xem Tien ich đã tồn tại hay chưa
        public bool KiemTraTonTaiTienIch(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "SELECT dbo.fn_KiemTraTonTaiTienIch(@TenTienIch)";
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@TenTienIch", TenTienIch);

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

        // Phương thức để xóa TienIch
        public bool XoaTienIch(DBConnect dbConn, string pMaTienIch)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_XoaTienIch";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaTienIch", pMaTienIch);

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

        public bool SuaThongTinTienIch(DBConnect dbConn, string pMaTienIch)
        {
            try
            {
                if (KiemTraTonTaiTienIch(dbConn))
                {
                    throw new Exception("Tiện ích với tên '" + TenTienIch + "' đã tồn tại! Không thể sửa!");
                }

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaTienIch";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền các tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaTienIch", pMaTienIch);
                    cmd.Parameters.AddWithValue("@TenTienIch", TenTienIch);
                    cmd.Parameters.AddWithValue("@GiaTienIch", GiaTienIch);
                    cmd.Parameters.AddWithValue("@MaLoaiTienIch", MaLoaiSanPham);


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
