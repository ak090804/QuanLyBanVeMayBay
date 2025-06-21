using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmSaoLuu : Form
    {
        private DBConnect dbConn;

        public frmSaoLuu(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;

        }

        private void btnSaoLuuCSDL_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối tới cơ sở dữ liệu
                dbConn.openConnect();

                // Tên database cần sao lưu
                string databaseName = "QuanLyBanVeMayBay"; // Thay bằng tên database của bạn

                // Tạo câu lệnh SQL để gọi hàm dbo.BackupDatabase và thực thi câu lệnh SQL trả về
                string sqlQuery = "DECLARE @BackupSQL NVARCHAR(MAX); " +
                                  "SET @BackupSQL = dbo.BackupDatabase(@DatabaseName); " +  // Gọi hàm BackupDatabase
                                  "EXEC sp_executesql @BackupSQL;"; // Thực thi câu lệnh SQL động

                using (SqlCommand cmd = new SqlCommand(sqlQuery, dbConn.conn))
                {
                    cmd.CommandType = CommandType.Text;

                    // Thêm tham số cho hàm BackupDatabase
                    cmd.Parameters.AddWithValue("@DatabaseName", databaseName);

                    // Thực thi câu lệnh SQL
                    cmd.ExecuteNonQuery();

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Backup cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                // Hiển thị thông báo lỗi SQL
                MessageBox.Show($"Lỗi SQL khi backup: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi tổng quát
                MessageBox.Show($"Lỗi khi backup: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối
                dbConn.closeConnect();
            }
        }

        private void btnKhoiPhucCSDL_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối tới cơ sở dữ liệu
                dbConn.openConnect();

                // Tên database cần khôi phục và đường dẫn backup
                string databaseName = "QuanLyBanVeMayBay"; // Thay bằng tên database của bạn
                string backupPath = @"D:\Backup\QuanLyBanVeMayBay.bak"; // Thay bằng đường dẫn sao lưu của bạn

                // Chuyển database về chế độ SINGLE_USER để tránh lỗi trong quá trình restore
                using (SqlCommand singleUserCmd = new SqlCommand($"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", dbConn.conn))
                {
                    singleUserCmd.ExecuteNonQuery();
                }

                // Đảm bảo đang sử dụng database master
                using (SqlCommand setMasterCmd = new SqlCommand("USE master;", dbConn.conn))
                {
                    setMasterCmd.ExecuteNonQuery();
                }

                // Khôi phục database từ file backup
                using (SqlCommand restoreCmd = new SqlCommand($"RESTORE DATABASE [{databaseName}] FROM DISK = '{backupPath}' WITH REPLACE;", dbConn.conn))
                {
                    restoreCmd.ExecuteNonQuery();
                }

                // Chuyển database trở lại chế độ MULTI_USER
                using (SqlCommand multiUserCmd = new SqlCommand($"ALTER DATABASE [{databaseName}] SET MULTI_USER;", dbConn.conn))
                {
                    multiUserCmd.ExecuteNonQuery();
                }

                // Thông báo thành công
                MessageBox.Show($"Khôi phục database {databaseName} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                // Hiển thị thông báo lỗi SQL
                MessageBox.Show($"Lỗi SQL khi khôi phục: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi tổng quát
                MessageBox.Show($"Lỗi khi khôi phục: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối
                dbConn.closeConnect();
            }
        }
    }
}
