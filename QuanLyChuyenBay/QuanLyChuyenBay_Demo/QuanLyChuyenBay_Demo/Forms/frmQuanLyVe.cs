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
using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmQuanLyVe : Form
    {
        private DBConnect dbConn;
        public frmQuanLyVe(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }

        private void frmQuanLyVe_Load(object sender, EventArgs e)
        {
            loadAllData();
            
        }

        private void loadAllData()
        {
            LoadCBO();
            FIllData.fillDataGridView(dataGridViewDanhSachVe, dbConn, "SELECT v.MaVe, ISNULL(h.HoTen, 'Chưa có hành khách') AS HoTen, t.TenTTV FROM Ve v LEFT JOIN HanhKhach h ON v.MaHanhKhach = h.MaHanhKhach LEFT JOIN TrangThaiVe t ON v.MaTTV = t.MaTTV;\r\n", "Ve");
            FIllData.fillDataGridView(dataGridViewChiTietVe, dbConn, " SELECT v.MaVe, ctv.MaChuyenBay, ctv.MaHangGhe, hg.TenHangGhe, cb.NgayGioDi, cb.NgayGioDen, hhk.TenHangHangKhong FROM Ve v JOIN ChiTietVe ctv ON v.MaVe = ctv.MaVe JOIN ChuyenBay cb ON ctv.MaChuyenBay = cb.MaChuyenBay JOIN HangHangKhong hhk ON cb.MaHangHangKhong = hhk.MaHangHangKhong JOIN HangGhe hg ON ctv.MaHangGhe = hg.MaHangGhe", "ChiTietVe");



        }
        
        private void LoadCBO()
        {
             FIllData.fillDataCbo(cboMaChuyenBay, dbConn, "SELECT * FROM ChuyenBay", "MaChuyenBay", "MaChuyenBay");

             FIllData.fillDataCbo(cboMaHangGhe, dbConn, "SELECT * FROM HangGhe", "TenHangGhe", "MaHangGhe");

             FIllData.fillDataCbo(cboTenHanhKhach, dbConn, "SELECT * FROM HanhKhach", "HoTen", "MaHanhKhach");
             if (!cboTenHanhKhach.Items.Contains("Chưa có hành khách"))
            {
                cboTenHanhKhach.Items.Insert(0, "Chưa có hành khách");
            }
             FIllData.fillDataCbo(cboTrangthaive, dbConn, "SELECT * FROM TrangThaiVe", "TenTTV", "MaTTV");

        }

       

        private void dataGridViewDanhSachVe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  
            {
                ClearControls();  

                 int maVe = Convert.ToInt32(dataGridViewDanhSachVe.Rows[e.RowIndex].Cells["MaVe"].Value);

                 dbConn.openConnect();

                 string cauTruyVan = @"SELECT v.MaVe, 
                              ISNULL(h.HoTen, 'Chưa có hành khách') AS HoTen, 
                              t.TenTTV
                       FROM Ve v 
                       LEFT JOIN HanhKhach h ON v.MaHanhKhach = h.MaHanhKhach 
                       LEFT JOIN TrangThaiVe t ON v.MaTTV = t.MaTTV
                       WHERE v.MaVe = @MaVe";  

                SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
                cmd.Parameters.AddWithValue("@MaVe", maVe);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())  
                {
                     lblMaVeoutput.Text = reader["MaVe"].ToString();

                     string hoTen = reader["HoTen"].ToString();

                     if (hoTen == "Chưa có hành khách")
                    {
                         if (!cboTenHanhKhach.Items.Contains("Chưa có hành khách"))
                        {
                            cboTenHanhKhach.Items.Insert(0, "Chưa có hành khách");
                        }
                        cboTenHanhKhach.SelectedIndex = cboTenHanhKhach.Items.IndexOf("Chưa có hành khách");
                    }
                    else
                    {
                         int indexTenHK = cboTenHanhKhach.FindStringExact(hoTen);
                        if (indexTenHK >= 0)
                        {
                            cboTenHanhKhach.SelectedIndex = indexTenHK;  
                        }
                    }

                     string tenTTV = reader["TenTTV"].ToString();
                    int indexTTV = cboTrangthaive.FindStringExact(tenTTV);
                    if (indexTTV >= 0)
                    {
                        cboTrangthaive.SelectedIndex = indexTTV;   
                    }
                }
                reader.Close();

                 string chiTietCauTruyVan = @"SELECT ctv.MaVe, ctv.MaChuyenBay, ctv.MaHangGhe, hg.TenHangGhe, cb.NgayGioDi, cb.NgayGioDen, hhk.TenHangHangKhong
                              FROM ChiTietVe ctv
                              JOIN ChuyenBay cb ON ctv.MaChuyenBay = cb.MaChuyenBay
                              JOIN HangHangKhong hhk ON cb.MaHangHangKhong = hhk.MaHangHangKhong
                              JOIN HangGhe hg ON ctv.MaHangGhe = hg.MaHangGhe
                              WHERE ctv.MaVe = @MaVe";

                SqlDataAdapter adapter = new SqlDataAdapter(chiTietCauTruyVan, dbConn.conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaVe", maVe);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewChiTietVe.DataSource = dt;

                dbConn.closeConnect();
            }
        }






        private void dataGridViewChiTietVe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  
            {
                 DataGridViewRow selectedRow = dataGridViewChiTietVe.Rows[e.RowIndex];
                string maChuyenBay = selectedRow.Cells["MaChuyenBay"].Value.ToString();
                string tenHangGhe = selectedRow.Cells["TenHangGhe"].Value.ToString();

                 int indexMaCB = cboMaChuyenBay.FindStringExact(maChuyenBay);
                if (indexMaCB >= 0) cboMaChuyenBay.SelectedIndex = indexMaCB;

                int indexHangGhe = cboMaHangGhe.FindStringExact(tenHangGhe);
                if (indexHangGhe >= 0) cboMaHangGhe.SelectedIndex = indexHangGhe;
            }
        }
        private void ClearControls()
        {
            // Xóa dữ liệu trên các điều khiển
            lblMaVeoutput.Text = string.Empty;
            cboTenHanhKhach.SelectedIndex = -1;  
            cboTrangthaive.SelectedIndex = -1;  
            cboMaChuyenBay.SelectedIndex = -1;  
            cboMaHangGhe.SelectedIndex = -1; 
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                 if (cboMaChuyenBay.SelectedIndex == -1 || cboMaHangGhe.SelectedIndex == -1)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng điền đầy đủ thông tin bắt buộc (Chuyến bay và Hạng ghế).");
                    return;
                }

                 int? maHK = null;   
                if (cboTenHanhKhach.SelectedIndex != -1)
                {
                    maHK = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboTenHanhKhach));
                }

                 int maChuyenBay = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaChuyenBay));
                int maHangGhe = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaHangGhe));

                 Ve veMoi = new Ve(maHK, maChuyenBay, maHangGhe);

                 if (veMoi.TaoVe(dbConn))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm vé thành công.");
                    ClearControls();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Thêm vé thất bại.");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
             
                int mave = 0;
                if (lblMaVeoutput.Text != "[Mã vé]")
                {
                    mave = int.Parse(CacHamKiemTra.KiemTraChuoiRong(lblMaVeoutput.Text));
                }
                
                

                Ve veMoi = new Ve();

                if (veMoi.XoaVe(dbConn, mave))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa vé");
                    ClearControls();
                    loadAllData();
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
       

       
        private void fillData(DataGridViewRow rows)
        {
            lblMaVeoutput.Text = FIllData.GetValueDGVRows(rows, "MaVe");



            cboTenHanhKhach.Text = FIllData.GetValueDGVRows(rows, "HoTen");

            cboTrangthaive.Text = FIllData.GetValueDGVRows(rows, "TenTTV");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {  

                int maHK = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboTenHanhKhach));
                int maChuyenBay = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaChuyenBay));
                int maHangGhe = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaHangGhe));
                int maTrangThaiVe = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboTrangthaive));

                // Tạo đối tượng Ve
                Ve veMoi = new Ve(maHK, maChuyenBay, maHangGhe,maTrangThaiVe);
                int mave = int.Parse(lblMaVeoutput.Text);
                if (veMoi.SuaTTVe(dbConn, mave))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Sua ve");
                    ClearControls();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Sua ve thất bại");
                }
            }
            
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
    }
    
}

