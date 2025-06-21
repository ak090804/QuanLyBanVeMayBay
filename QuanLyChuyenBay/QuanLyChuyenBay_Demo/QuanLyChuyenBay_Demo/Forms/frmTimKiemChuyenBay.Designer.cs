
using System.Windows.Forms;
using System;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmTimKiemChuyenBay : Form
    {
        private Button btnTimkiem;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemChuyenBay));
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.lblTenHangHangKhong = new System.Windows.Forms.Label();
            this.cboHangHangKhong = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboLoTrinh = new System.Windows.Forms.ComboBox();
            this.lblLoTrinh = new System.Windows.Forms.Label();
            this.cboTenMayBay = new System.Windows.Forms.ComboBox();
            this.lblTenMayBay = new System.Windows.Forms.Label();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachChuyenBay = new System.Windows.Forms.DataGridView();
            this.dTPNgayDi = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChuyenBay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(959, 220);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(169, 68);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.UseMnemonic = false;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // lblTenHangHangKhong
            // 
            this.lblTenHangHangKhong.AutoSize = true;
            this.lblTenHangHangKhong.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHangHangKhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTenHangHangKhong.Location = new System.Drawing.Point(3, 37);
            this.lblTenHangHangKhong.Name = "lblTenHangHangKhong";
            this.lblTenHangHangKhong.Size = new System.Drawing.Size(332, 37);
            this.lblTenHangHangKhong.TabIndex = 5;
            this.lblTenHangHangKhong.Text = "Tên hãng hàng không:";
            // 
            // cboHangHangKhong
            // 
            this.cboHangHangKhong.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHangHangKhong.FormattingEnabled = true;
            this.cboHangHangKhong.Location = new System.Drawing.Point(341, 36);
            this.cboHangHangKhong.Name = "cboHangHangKhong";
            this.cboHangHangKhong.Size = new System.Drawing.Size(266, 45);
            this.cboHangHangKhong.TabIndex = 6;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(341, 208);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(266, 45);
            this.cboTrangThai.TabIndex = 8;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTrangThai.Location = new System.Drawing.Point(3, 211);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(176, 37);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboLoTrinh
            // 
            this.cboLoTrinh.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoTrinh.FormattingEnabled = true;
            this.cboLoTrinh.Location = new System.Drawing.Point(757, 115);
            this.cboLoTrinh.Name = "cboLoTrinh";
            this.cboLoTrinh.Size = new System.Drawing.Size(374, 45);
            this.cboLoTrinh.TabIndex = 10;
            // 
            // lblLoTrinh
            // 
            this.lblLoTrinh.AutoSize = true;
            this.lblLoTrinh.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoTrinh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLoTrinh.Location = new System.Drawing.Point(605, 119);
            this.lblLoTrinh.Name = "lblLoTrinh";
            this.lblLoTrinh.Size = new System.Drawing.Size(146, 37);
            this.lblLoTrinh.TabIndex = 9;
            this.lblLoTrinh.Text = "Lộ trình:";
            // 
            // cboTenMayBay
            // 
            this.cboTenMayBay.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenMayBay.FormattingEnabled = true;
            this.cboTenMayBay.Location = new System.Drawing.Point(341, 112);
            this.cboTenMayBay.Name = "cboTenMayBay";
            this.cboTenMayBay.Size = new System.Drawing.Size(266, 45);
            this.cboTenMayBay.TabIndex = 12;
            // 
            // lblTenMayBay
            // 
            this.lblTenMayBay.AutoSize = true;
            this.lblTenMayBay.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMayBay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTenMayBay.Location = new System.Drawing.Point(3, 115);
            this.lblTenMayBay.Name = "lblTenMayBay";
            this.lblTenMayBay.Size = new System.Drawing.Size(208, 37);
            this.lblTenMayBay.TabIndex = 11;
            this.lblTenMayBay.Text = "Tên máy bay:";
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNgayDi.Location = new System.Drawing.Point(605, 39);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(136, 37);
            this.lblNgayDi.TabIndex = 13;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // dataGridViewDanhSachChuyenBay
            // 
            this.dataGridViewDanhSachChuyenBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachChuyenBay.Location = new System.Drawing.Point(116, 351);
            this.dataGridViewDanhSachChuyenBay.Name = "dataGridViewDanhSachChuyenBay";
            this.dataGridViewDanhSachChuyenBay.RowHeadersWidth = 51;
            this.dataGridViewDanhSachChuyenBay.RowTemplate.Height = 24;
            this.dataGridViewDanhSachChuyenBay.Size = new System.Drawing.Size(976, 220);
            this.dataGridViewDanhSachChuyenBay.TabIndex = 18;
            // 
            // dTPNgayDi
            // 
            this.dTPNgayDi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dTPNgayDi.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayDi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayDi.Location = new System.Drawing.Point(757, 31);
            this.dTPNgayDi.Name = "dTPNgayDi";
            this.dTPNgayDi.Size = new System.Drawing.Size(371, 45);
            this.dTPNgayDi.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.lblTenHangHangKhong);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.dTPNgayDi);
            this.panel1.Controls.Add(this.cboHangHangKhong);
            this.panel1.Controls.Add(this.lblTrangThai);
            this.panel1.Controls.Add(this.lblNgayDi);
            this.panel1.Controls.Add(this.cboTrangThai);
            this.panel1.Controls.Add(this.cboTenMayBay);
            this.panel1.Controls.Add(this.lblLoTrinh);
            this.panel1.Controls.Add(this.lblTenMayBay);
            this.panel1.Controls.Add(this.cboLoTrinh);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 312);
            this.panel1.TabIndex = 20;
            // 
            // frmTimKiemChuyenBay
            // 
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1169, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDanhSachChuyenBay);
            this.Name = "frmTimKiemChuyenBay";
            this.Text = "Tìm Kiếm Chuyến Bay";
            this.Load += new System.EventHandler(this.frmTimKiemChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChuyenBay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        private Label lblTenHangHangKhong;
        private ComboBox cboHangHangKhong;
        private ComboBox cboTrangThai;
        private Label lblTrangThai;
        private ComboBox cboLoTrinh;
        private Label lblLoTrinh;
        private ComboBox cboTenMayBay;
        private Label lblTenMayBay;
        private Label lblNgayDi;
        private DataGridView dataGridViewDanhSachChuyenBay;
        private DateTimePicker dTPNgayDi;
        private Panel panel1;
    }
}