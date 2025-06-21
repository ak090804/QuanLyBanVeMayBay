using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuyenBay_Demo.Helpers;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyChuyenBay_Demo.Models
{
    public class TaiKhoan
    {
        public string taiKhoan { get; set; }
        public string MatKhau { get; set; }
        public TaiKhoan(string pTaiKhoan, string pMatKhau)
        {
            taiKhoan = pTaiKhoan;
            MatKhau = pMatKhau;
        }

        public bool TaoTaiKhoan(DBConnect dbConn,string sdt)
        {
            if (dbConn.checkExist("TaiKhoan", "TenTaiKhoan", taiKhoan))
                throw new Exception("Đã tồn tại người dùng với tên tài khoản '" + taiKhoan + "'");
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_CreateTaiKhoan"; //Goi SP co san trong SQL
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; //Chuyen loai cmd

                    cmd.Parameters.AddWithValue("@TenTaiKhoan", taiKhoan); // Truyen du lieu
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
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

       

        public bool XoaTaiKhoan(DBConnect dBConnect, string pMaTaiKhoan)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dBConnect.conn;
                    dBConnect.openConnect();
                    cmd.CommandText = "sp_XoaTaiKhoan";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaTaiKhoan", pMaTaiKhoan);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        dBConnect.closeConnect();
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

        public bool CapNhatTaiKhoan(DBConnect dbConn)
        {
            dbConn.openConnect();
            if (dbConn.checkExist("TaiKhoan", "TenTaiKhoan", taiKhoan))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = dbConn.conn;
                        cmd.CommandText = "sp_DoiMatKhau";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TenTaiKhoan", taiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw;
                }
            }
            return false;
        }

        public void doiMatKhauLogin(DBConnect dbConn, string taiKhoan, string matKhau)
        {
            dbConn.openConnect();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_DoiMatKhauLogin";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@LoginName", taiKhoan);
                    cmd.Parameters.AddWithValue("@NewPassword", matKhau);

                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool GoQuyen()
        {
            DBConnect dbConn = new DBConnect();
            dbConn.openConnect();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_GoQuyen";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TenTaiKhoan", taiKhoan);

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ThemQuyenMember()
        {
            DBConnect dbConn = new DBConnect();
            dbConn.openConnect();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_AddRoleTaiKhoanMoi";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TenTaiKhoan", taiKhoan);

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool CapNhatTaiKhoan(DBConnect dbConn, string pTaiKhoan, string pMatKhau)
        {
            dbConn.openConnect();
            DBConnect dbTong = new DBConnect();
            if (dbConn.checkExist("TaiKhoan", "TenTaiKhoan", taiKhoan))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = dbConn.conn;
                        cmd.CommandText = "sp_DoiMatKhau";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TenTaiKhoan", pTaiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", pMatKhau);

                        cmd.ExecuteNonQuery();
                        //cmd.Connection.Close();
                    }
                    doiMatKhauLogin(dbTong, pTaiKhoan, pMatKhau);
                    dbTong.disposeConnect();
                    return true;
                }
                catch (SqlException ex)
                {
                    throw;
                }
            }
            return false;
        }
    }
}
