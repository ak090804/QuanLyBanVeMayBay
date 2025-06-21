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
    public class Ve
    {
        public int MaVe { get; set; }
        public int? MaHanhKhach { get; set; }
        public int MaChuyenBay { get; set; }

        public int MaHangGhe { get; set; }
        public int MaTTV { get; set; } // Ticket Status (1 = Đã đặt)

        // Constructor

        public Ve(int? maHanhKhach, int maChuyenBay, int maHangGhe)
        {
            MaHanhKhach = maHanhKhach;
            MaChuyenBay = maChuyenBay;

            MaHangGhe = maHangGhe;
            MaTTV = 1;
        }
        public Ve(int? maHanhKhach, int maChuyenBay, int maHangGhe, int maTTV)
        {
            MaHanhKhach = maHanhKhach;
            MaChuyenBay = maChuyenBay;
           
            MaHangGhe = maHangGhe;
            MaTTV = maTTV; 
        }

        public Ve()
        {
                
        }

       
        public bool TaoVe(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_TaoVe";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Kiểm tra nếu MaHanhKhach là null, thay thế bằng DBNull.Value
                    if (MaHanhKhach.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@MaHK", MaHanhKhach.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@MaHK", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
                    cmd.Parameters.AddWithValue("@MaHangGhe", MaHangGhe);

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



        public bool XoaVe(DBConnect dbConn, int mave)
        {
            try
            {
                // Kiểm tra xem chuyến bay đã bán vé hay chưa
                if (KiemTraVeCoDuocDat(dbConn, mave))
                {
                    throw new Exception("Ves này đa được đặt không thể xóa!");
                }
                

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_XoaVe";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaVe", mave);

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
        public bool KiemTraVeCoDuocDat(DBConnect dbConn, int MaVe)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "SELECT dbo.fn_KiemTraVeTrongPhieuDat(@MaVe)";
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Truyền tham số cho hàm kiểm tra
                    cmd.Parameters.AddWithValue("@MaVe", MaVe);

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

        public bool SuaTTVe(DBConnect dbConn, int mave)
        {
            try
            {

                

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaVeVaChiTiet";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaVe", mave);

                    cmd.Parameters.AddWithValue("@MaHK", MaHanhKhach);
                    cmd.Parameters.AddWithValue("@MaTTV", MaTTV);
                    cmd.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
                    cmd.Parameters.AddWithValue("@MaHangGhe", MaHangGhe);

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
   

