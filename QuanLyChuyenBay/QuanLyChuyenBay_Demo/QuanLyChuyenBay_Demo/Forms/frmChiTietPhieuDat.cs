using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;
using System.Data.SqlClient;


namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmChiTietPhieuDat : Form
    {
        private DBConnect dbConn;

        public frmChiTietPhieuDat(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;


        }


        private void frmChiTietPhieuDat_Load(object sender, EventArgs e)
        {
            loadCboTenLoTrinh();
            loadTenHanhKhach();
        }

        private void loadTenHanhKhach()
        {
            dbConn.openConnect();
            string cauTruyVan = "select MaHanhKhach ,HoTen from HanhKhach";
            FIllData.fillDataCbo(cboHanhKhach, dbConn, cauTruyVan, "HoTen", "MaHanhKhach");
            dbConn.closeConnect();

        }
        private void loadCboTenLoTrinh()
        {
            dbConn.openConnect();
            string cauTruyVan = "SELECT tenlotrinh FROM lotrinh";
            FIllData.fillDataCbo(cboTenLoTrinh, dbConn, cauTruyVan, "tenlotrinh", "tenlotrinh");
            dbConn.closeConnect();
        }


        private void loadCboMaChuyenBay(string tenLoTrinh)
        {
            dbConn.openConnect();

            string cauTruyVan = @"SELECT cb.MaChuyenBay
FROM ChuyenBay cb
JOIN LoTrinh lt ON cb.MaLoTrinh = lt.MaLoTrinh
WHERE lt.TenLoTrinh = @tenLoTrinh
  AND EXISTS (
      SELECT 1
      FROM ChiTietVe ctv
      JOIN ve v ON ctv.MaVe = v.MaVe
      WHERE ctv.MaChuyenBay = cb.MaChuyenBay
        AND v.MaHanhKhach IS NULL
  );
";

            SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
            cmd.Parameters.AddWithValue("@tenLoTrinh", tenLoTrinh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboChuyenBay.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cboChuyenBay.Items.Add(row["machuyenbay"].ToString());
            }
            if (cboChuyenBay.Items.Count <= 0)
            {
                cboChuyenBay.Text = "Không có chuyến bay Có sẵn";
                cboVe.Items.Clear();
                cboVe.Text = "";
                btnThemVe.Enabled = false;
            }
            else
            {
                btnThemVe.Enabled = true;
                cboChuyenBay.SelectedIndex = 0;
            }
            dbConn.closeConnect();
        }

        private void cboTenLoTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenLoTrinh = cboTenLoTrinh.SelectedItem.ToString();
            loadCboMaChuyenBay(tenLoTrinh);
        }
        private void loadVeByChuyenBay(string maChuyenBay)
        {
            dbConn.openConnect();
            if (int.TryParse(maChuyenBay,out _) == false)
            {
                cboVe.SelectedIndex = -1;
                return;
            }

            string cauTruyVan = "SELECT ctv.mave FROM chitietve ctv JOIN ve v ON ctv.mave = v.mave  WHERE ctv.machuyenbay = @maChuyenBay  AND v.mattv = 1"; // Sửa cột "machuyenbay" thành "MaChuyenBay"
            SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
            cmd.Parameters.AddWithValue("@maChuyenBay", maChuyenBay);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboVe.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cboVe.Items.Add(row["mave"].ToString());
            }
            cboVe.SelectedIndex = 0;
            dbConn.closeConnect();
        }

        private void cboChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maChuyenBay = cboChuyenBay.SelectedItem.ToString();
            loadVeByChuyenBay(maChuyenBay);
        }
        private void loadCboVe(string maChuyenBay)
        {
            dbConn.openConnect();
            string cauTruyVan = "SELECT ctv.mave FROM chitietve ctv JOIN ve v ON ctv.mave = v.mave  WHERE ctv.machuyenbay = @maChuyenBay  AND v.mattv = 1";
            SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
            cmd.Parameters.AddWithValue("@maChuyenBay", maChuyenBay);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboVe.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cboVe.Items.Add(row["mave"].ToString());
            }
            dbConn.closeConnect();
        }
        public void SetMaPhieuDat(int maPhieuDat)
        {
            lblMaphieudat.Text = maPhieuDat.ToString();
            LoadChiTietPhieuDat(maPhieuDat);
        }

        private void btnThemVe_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboVe.SelectedItem == null)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn vé.");
                    return;
                }

                if (string.IsNullOrEmpty(lblMaphieudat.Text))
                {
                    Notification_Helpers.ThongBaoLoi(this, "Mã phiếu đặt không hợp lệ.");
                    return;
                }

                int maPhieuDat = int.Parse(lblMaphieudat.Text);
                int maVe = int.Parse(cboVe.SelectedItem.ToString());

                if (dataGridViewChiTietPhieuDat.Columns.Count == 0)
                {
                    dataGridViewChiTietPhieuDat.Columns.Add("MaPhieuDat", "Mã Phiếu Đặt");
                    dataGridViewChiTietPhieuDat.Columns.Add("MaVe", "Mã Vé");
                }

                dataGridViewChiTietPhieuDat.Rows.Add(maPhieuDat, maVe);

                PhieuDat phieuDatMoi = new PhieuDat();
                phieuDatMoi.MaPhieuDat = maPhieuDat;
                phieuDatMoi.mave = maVe;
                string maHK = FIllData.GetRealDataOfComboBox(cboHanhKhach);



                if (phieuDatMoi.TaoChiTietPhieuDat(dbConn, maHK))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm vé vào chi tiết phiếu đặt thành công.");
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Thêm chi tiết phiếu đặt thất bại.");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, "Lỗi: " + ex.Message);
            }
        }
        private void LoadChiTietPhieuDat(int maPhieuDat)
        {
            try
            {
                if (dataGridViewChiTietPhieuDat.Columns.Count == 0)
                {
                    dataGridViewChiTietPhieuDat.Columns.Add("MaPhieuDat", "Mã Phiếu Đặt");
                    dataGridViewChiTietPhieuDat.Columns.Add("MaVe", "Mã Vé");
                }

                string query = @"SELECT cp.MaVe 
                         FROM ChiTietPhieuDat cp
                         WHERE cp.MaPhieuDat = @MaPhieuDat";

                SqlCommand cmd = new SqlCommand(query, dbConn.conn);
                cmd.Parameters.AddWithValue("@MaPhieuDat", maPhieuDat);

                dbConn.openConnect();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbConn.closeConnect();

                dataGridViewChiTietPhieuDat.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dataGridViewChiTietPhieuDat.Rows.Add(maPhieuDat, row["MaVe"]);
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, "Lỗi khi tải chi tiết phiếu đặt: " + ex.Message);
            }

        }
        private void ClearComboBoxes()
        {
            cboTenLoTrinh.Text = "";

            cboChuyenBay.Text = "";

            cboVe.Text = "";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();

            frmQuanLyPhieuDat frmQLPhieuDat = new frmQuanLyPhieuDat(dbConn);

            frmQLPhieuDat.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearComboBoxes();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewChiTietPhieuDat.SelectedRows.Count == 0)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn dòng để xóa.");
                    return;
                }

                int maPhieuDat = 0;
                int mave = 0;

                maPhieuDat = int.Parse(dataGridViewChiTietPhieuDat.SelectedRows[0].Cells["MaPhieuDat"].Value.ToString());
                mave = int.Parse(dataGridViewChiTietPhieuDat.SelectedRows[0].Cells["MaVe"].Value.ToString());

                if (maPhieuDat == 0 || mave == 0)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Mã phiếu đặt hoặc mã vé không hợp lệ.");
                    return;
                }

                PhieuDat phieuDatMoi = new PhieuDat();
                phieuDatMoi.MaPhieuDat = maPhieuDat;

                // Xóa vé khỏi chi tiết phiếu đặt
                if (phieuDatMoi.XoaVeTrongChiTietPhieuDat(dbConn, maPhieuDat, mave)) // Gọi phương thức với mã vé
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa vé thành công.");

                    LoadChiTietPhieuDat(maPhieuDat);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Lỗi khi xóa vé.");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, "Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieuDat;
                if (!int.TryParse(lblMaphieudat.Text, out maPhieuDat))
                {
                    Notification_Helpers.ThongBaoLoi(this, "Mã phiếu đặt không hợp lệ.");
                    return;
                }

                if (cboVe.SelectedItem == null)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn mã vé.");
                    return;
                }

                int maVe = int.Parse(cboVe.Text);

                PhieuDat phieuDat = new PhieuDat();

                bool isSuccess = phieuDat.SuaVeTrongPhieuDat(dbConn, maPhieuDat, maVe);

                if (isSuccess)
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Sửa vé thành công.");
                    LoadChiTietPhieuDat(maPhieuDat);

                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Sửa vé thất bại.");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
    }
}
