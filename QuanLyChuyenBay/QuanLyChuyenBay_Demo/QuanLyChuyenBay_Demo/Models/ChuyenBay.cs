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
    public class ChuyenBay
    {
        public int MaHangHangKhong { get; set; }
        public int MaTrangThaiChuyenBay { get; set; }
        public int MaLoTrinh { get; set; }
        public int MaMayBay { get; set; }
        public float GiaBay { get; set; }
        public DateTime NgayGioDi { get; set; }
        public DateTime NgayGioDen { get; set; }
        public ChuyenBay(int pMaHangHangKhong, int pMaTrangThaiChuyenBay, int pMaLoTrinh, int pMaMayBay, float pGiaBay, DateTime pNgayGioDi, DateTime pNgayGioDen)
        {
            MaHangHangKhong = pMaHangHangKhong;
            MaTrangThaiChuyenBay = pMaTrangThaiChuyenBay;
            MaLoTrinh = pMaLoTrinh;
            MaMayBay = pMaMayBay;
            GiaBay = pGiaBay;
            NgayGioDi = pNgayGioDi;
            NgayGioDen = pNgayGioDen;
        }

        public ChuyenBay() { }


        // Phương thức thêm mới chuyến bay
        public bool ThemMoiChuyenBay(DBConnect dbConn)
        {
            try
            {

                if (KiemTraTonTaiChuyenBay(dbConn))
                {
                    throw new Exception("Chuyến bay bạn vừa thêm đã tồn tại! Không thể thêm");
                }

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_ThemMoiChuyenBay";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@MaHangHangKhong", MaHangHangKhong);
                    cmd.Parameters.AddWithValue("@MaTrangThaiChuyenBay", MaTrangThaiChuyenBay);
                    cmd.Parameters.AddWithValue("@MaLoTrinh", MaLoTrinh);
                    cmd.Parameters.AddWithValue("@MaMayBay", MaMayBay);
                    cmd.Parameters.AddWithValue("@GiaBay", GiaBay);
                    cmd.Parameters.AddWithValue("@NgayGioDi", NgayGioDi);
                    cmd.Parameters.AddWithValue("@NgayGioDen", NgayGioDen);

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

        // Phương thức kiểm tra tồn tại chuyến bay
        public bool KiemTraTonTaiChuyenBay(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "SELECT dbo.fn_KiemTraTonTaiChuyenBay(@MaHangHangKhong, @MaTrangThaiChuyenBay, @MaLoTrinh, @MaMayBay)";
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Truyền các tham số cho hàm kiểm tra
                    cmd.Parameters.AddWithValue("@MaHangHangKhong", MaHangHangKhong);
                    cmd.Parameters.AddWithValue("@MaTrangThaiChuyenBay", MaTrangThaiChuyenBay);
                    cmd.Parameters.AddWithValue("@MaLoTrinh", MaLoTrinh);
                    cmd.Parameters.AddWithValue("@MaMayBay", MaMayBay);

                    // Thực hiện kiểm tra
                    bool exists = (bool)cmd.ExecuteScalar();
                    dbConn.closeConnect();
                    return exists;
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw;
            }
        }

        // Phương thức xóa chuyến bay
        public bool XoaChuyenBay(DBConnect dbConn, int pMaChuyenBay)
        {
            try
            {
                // Kiểm tra xem chuyến bay đã bán vé hay chưa
                if (KiemTraChuyenBayBanVeChua(dbConn, pMaChuyenBay))
                {
                    throw new Exception("Chuyến bay này đã bán vé, không thể xóa!");
                }

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_XoaChuyenBay";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaChuyenBay", pMaChuyenBay);

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw;
            }
        }

        // Phương thức kiểm tra chuyến bay đã bán vé chưa
        public bool KiemTraChuyenBayBanVeChua(DBConnect dbConn, int pMaChuyenBay)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "SELECT dbo.fn_KiemTraChuyenBayBanVeChua(@MaChuyenBay)";
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Truyền tham số cho hàm kiểm tra
                    cmd.Parameters.AddWithValue("@MaChuyenBay", pMaChuyenBay);

                    // Thực hiện kiểm tra
                    bool exists = (bool)cmd.ExecuteScalar();
                    dbConn.closeConnect();
                    return exists;
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw;
            }
        }

        // Phương thức sửa thông tin chuyến bay
        public bool SuaTTChuyenBay(DBConnect dbConn, int maChuyenBay)
        {
            try
            {

                if (KiemTraTonTaiChuyenBay(dbConn))
                {
                    throw new Exception("Chuyến bay bạn vừa sửa đã tồn tại! Không thể sửa");
                }

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaTTChuyenBay";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaChuyenBay", maChuyenBay);
                    cmd.Parameters.AddWithValue("@MaHangHangKhong", MaHangHangKhong);
                    cmd.Parameters.AddWithValue("@MaTrangThaiChuyenBay", MaTrangThaiChuyenBay);
                    cmd.Parameters.AddWithValue("@MaLoTrinh", MaLoTrinh);
                    cmd.Parameters.AddWithValue("@MaMayBay", MaMayBay);
                    cmd.Parameters.AddWithValue("@GiaBay", GiaBay);
                    cmd.Parameters.AddWithValue("@NgayGioDi", NgayGioDi);
                    cmd.Parameters.AddWithValue("@NgayGioDen", NgayGioDen);


                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw;
            }
        }

        



    }
}
