using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuyenBay_Demo.Helpers;
using System.Data.SqlClient;

namespace QuanLyChuyenBay_Demo.Models
{
    public class GiamGia
    {
        public string Code { get; set; }
        public float MucGiamGia { get; set; }
        public GiamGia(string pCode, float pMucGiamGia)
        {
            Code = pCode;
            MucGiamGia = pMucGiamGia;
        }
        public bool ThemMaGiamGia(DBConnect dbConn)
        {
            if (dbConn.checkExist("GiamGia", "Code", Code))
                throw new Exception("Đã tồn tại mã giảm giá '" + Code + "'");
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_ThemMaGiamGia";  
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;  

                    cmd.Parameters.AddWithValue("@Code", Code);  
                    cmd.Parameters.AddWithValue("@MucGiamGia", MucGiamGia);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        dbConn.closeConnect();
                        return true;
                    }
                    catch (SqlException)
                    {
                        throw;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool XoaMaGiamGia(DBConnect dBConnect, string pMaGiamGia)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dBConnect.conn;
                    dBConnect.openConnect();
                    cmd.CommandText = "sp_XoaMaGiamGia";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaGiamGia", pMaGiamGia);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        dBConnect.closeConnect();
                        return true;
                    }
                    catch (SqlException)
                    {
                        throw;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool SuaMaGiamGia(DBConnect dbConn, string maGiamGia)
        {
            try
            {
                dbConn.openConnect();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaMaGiamGia";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền các tham số
                    cmd.Parameters.AddWithValue("@MaGiamGia", maGiamGia);
                    cmd.Parameters.AddWithValue("@Code", Code);
                    cmd.Parameters.AddWithValue("@MucGiamGia", Convert.ToDecimal(MucGiamGia));

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();

                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}