using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class HoaDon
    {
        public int MaHoaDonMoi { get; private set; }
        public int MaPhieuDat { get; set; }
        public decimal TongTien { get; private set; }

        public HoaDon(int maPhieuDat)
        {
            MaPhieuDat = maPhieuDat;
        }

        public HoaDon(string _maHoaDon)
        {
            MaHoaDonMoi = int.Parse(_maHoaDon);
        }
        // Hàm thêm hóa đơn
        public bool ThemHoaDon(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_ThemHoaDon";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Tham số đầu vào
                    cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);

                    // Tham số đầu ra
                    SqlParameter tongTienParam = new SqlParameter("@TongTien", System.Data.SqlDbType.Decimal)
                    {
                        Direction = System.Data.ParameterDirection.Output,
                        Precision = 18,
                        Scale = 2
                    };
                    cmd.Parameters.Add(tongTienParam);

                    SqlParameter maHoaDonMoiParam = new SqlParameter("@MaHoaDonMoi", System.Data.SqlDbType.Int)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    cmd.Parameters.Add(maHoaDonMoiParam);

                    // Thực thi proc
                    cmd.ExecuteNonQuery();

                    // Lấy giá trị trả về
                    TongTien = (decimal)tongTienParam.Value;
                    MaHoaDonMoi = (int)maHoaDonMoiParam.Value;

                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Hàm sửa hóa đơn
        public bool SuaHoaDon(DBConnect dbConn, string maHoaDon, int? maPhieuDatMoi = null)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaHoaDon";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Tham số đầu vào
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                    // Kiểm tra nếu maPhieuDatMoi có giá trị
                    if (maPhieuDatMoi.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuDat", maPhieuDatMoi.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuDat", DBNull.Value);
                    }

                    // Thực thi proc
                    cmd.ExecuteNonQuery();

                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        // Hàm xóa hóa đơn
        public bool XoaHoaDon(DBConnect dbConn, string maHoaDon)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_XoaHoaDon";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Tham số đầu vào
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                    // Thực thi proc
                    cmd.ExecuteNonQuery();

                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public decimal TinhTongTienTamThoi(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "SELECT dbo.func_TinhTongTien(@MaPhieuDat)";
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Tham số đầu vào
                    cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);

                    // Lấy kết quả từ SQL
                    object result = cmd.ExecuteScalar();
                    dbConn.closeConnect();

                    // Kiểm tra và trả về giá trị
                    if (result != null && result != DBNull.Value)
                    {
                        return (decimal)result;
                    }
                    else
                    {
                        return 0; // Trường hợp không tìm thấy tổng tiền
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }


        public bool ThanhToan(DBConnect dbConn, string maHoaDon, int? maPhieuDatMoi = null)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_CapNhatThanhToan";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Tham số đầu vào
                    cmd.Parameters.AddWithValue("@MaHD", maHoaDon);

                    // Thực thi proc
                    cmd.ExecuteNonQuery();

                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
