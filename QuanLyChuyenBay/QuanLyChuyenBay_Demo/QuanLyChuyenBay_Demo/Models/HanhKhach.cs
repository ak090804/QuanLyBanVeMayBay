using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class HanhKhach
    {
        public int MaHanhKhach { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string QuocTich { get; set; }
        public string NgaySinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string CCCD_Passport { get; set; }
        public int MaKhachHang { get; set; }
        public HanhKhach(string pHoTen, string pDiaChi, string pGioTinh, string pQuocTich, string pNgaySinh, string pSDT, string pEmail, string pCCCD_Passport,int pMaKhachHang)
        {
            HoTen = pHoTen;
            DiaChi = pDiaChi;
            GioiTinh = pGioTinh;
            QuocTich = pQuocTich;
            NgaySinh = pNgaySinh;
            SDT = pSDT;
            Email = pEmail;
            CCCD_Passport = pCCCD_Passport;
            MaKhachHang= pMaKhachHang;  
        }
        public HanhKhach()
        {

        }

        public bool ThemHanhKhach(DBConnect dbConn)
        {
            try
            {

               

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_ThemHanhKhach";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@HoTen", HoTen);
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@QuocTich", QuocTich);
                    cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    cmd.Parameters.AddWithValue("@SoDienThoai", SDT);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@CCCD_Passport", CCCD_Passport);
                    cmd.Parameters.AddWithValue("@MaKhachHang",MaKhachHang);


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
        public bool KiemTraHanhKhachCoDatVe(DBConnect dbConn, int maHanhKhach)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "SELECT dbo.fn_KiemTraHanhKhachCoDatVe(@MaHanhKhach)";
                    cmd.CommandType = System.Data.CommandType.Text;

                     cmd.Parameters.AddWithValue("@MaHanhKhach", maHanhKhach);

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
        public bool XoaHanhKhach(DBConnect dbConn, int maHanhKhach)
        {
            try
            {
                 if (KiemTraHanhKhachCoDatVe(dbConn, maHanhKhach))
                {
                    throw new Exception("Hành khách này đã đặt vé, không thể xóa!");
                }

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_XoaHanhKhach";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                     cmd.Parameters.AddWithValue("@MaHanhKhach", maHanhKhach);

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
        public bool SuaHanhKhach(DBConnect dbConn,int mahanhkhach)
        {
            try
            {



                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaHanhKhach";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                     cmd.Parameters.AddWithValue("@MaHanhKhach", mahanhkhach);

                    cmd.Parameters.AddWithValue("@HoTen", HoTen);
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@QuocTich", QuocTich);
                    cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    cmd.Parameters.AddWithValue("@SoDienThoai",SDT);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@CCCD_Passport", CCCD_Passport);
                    cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);

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
