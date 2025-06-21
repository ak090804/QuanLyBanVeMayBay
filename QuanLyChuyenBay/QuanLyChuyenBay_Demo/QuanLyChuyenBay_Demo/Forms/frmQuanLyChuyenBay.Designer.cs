
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyChuyenBay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyChuyenBay));
            this.dataGridViewDanhSachChuyenBay = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dTPNgayGioDen = new System.Windows.Forms.DateTimePicker();
            this.dTPNgayGioDi = new System.Windows.Forms.DateTimePicker();
            this.lblgayGioDen = new System.Windows.Forms.Label();
            this.lblNgayGioDi = new System.Windows.Forms.Label();
            this.lblMaChuyenBayIP = new System.Windows.Forms.Label();
            this.txtGiabay = new System.Windows.Forms.TextBox();
            this.lblGiabay = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblMachuyenbay = new System.Windows.Forms.Label();
            this.cboTenmaybay = new System.Windows.Forms.ComboBox();
            this.cboTenLoTrinh = new System.Windows.Forms.ComboBox();
            this.cboHangHangKhong = new System.Windows.Forms.ComboBox();
            this.lblLotrinh = new System.Windows.Forms.Label();
            this.lblTenmaybay = new System.Windows.Forms.Label();
            this.lblTrangThaiChuyenBay = new System.Windows.Forms.Label();
            this.lblHangHangKhong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChuyenBay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachChuyenBay
            // 
            this.dataGridViewDanhSachChuyenBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachChuyenBay.Location = new System.Drawing.Point(12, 343);
            this.dataGridViewDanhSachChuyenBay.Name = "dataGridViewDanhSachChuyenBay";
            this.dataGridViewDanhSachChuyenBay.RowHeadersWidth = 51;
            this.dataGridViewDanhSachChuyenBay.RowTemplate.Height = 24;
            this.dataGridViewDanhSachChuyenBay.Size = new System.Drawing.Size(1252, 187);
            this.dataGridViewDanhSachChuyenBay.TabIndex = 4;
            this.dataGridViewDanhSachChuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachChuyenBay_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1066, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 69);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(520, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(176, 69);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.Location = new System.Drawing.Point(774, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(198, 69);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(13, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(187, 69);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.GhostWhite;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(264, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(176, 69);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dTPNgayGioDen
            // 
            this.dTPNgayGioDen.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayGioDen.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dTPNgayGioDen.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayGioDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNgayGioDen.Location = new System.Drawing.Point(878, 184);
            this.dTPNgayGioDen.Name = "dTPNgayGioDen";
            this.dTPNgayGioDen.Size = new System.Drawing.Size(331, 42);
            this.dTPNgayGioDen.TabIndex = 51;
            // 
            // dTPNgayGioDi
            // 
            this.dTPNgayGioDi.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayGioDi.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dTPNgayGioDi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayGioDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNgayGioDi.Location = new System.Drawing.Point(244, 184);
            this.dTPNgayGioDi.Name = "dTPNgayGioDi";
            this.dTPNgayGioDi.Size = new System.Drawing.Size(341, 42);
            this.dTPNgayGioDi.TabIndex = 50;
            // 
            // lblgayGioDen
            // 
            this.lblgayGioDen.AutoSize = true;
            this.lblgayGioDen.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgayGioDen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblgayGioDen.Location = new System.Drawing.Point(609, 183);
            this.lblgayGioDen.Name = "lblgayGioDen";
            this.lblgayGioDen.Size = new System.Drawing.Size(183, 35);
            this.lblgayGioDen.TabIndex = 49;
            this.lblgayGioDen.Text = "Ngày giờ đến";
            // 
            // lblNgayGioDi
            // 
            this.lblNgayGioDi.AutoSize = true;
            this.lblNgayGioDi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayGioDi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNgayGioDi.Location = new System.Drawing.Point(24, 183);
            this.lblNgayGioDi.Name = "lblNgayGioDi";
            this.lblNgayGioDi.Size = new System.Drawing.Size(162, 35);
            this.lblNgayGioDi.TabIndex = 48;
            this.lblNgayGioDi.Text = "Ngày giờ đi";
            // 
            // lblMaChuyenBayIP
            // 
            this.lblMaChuyenBayIP.AutoSize = true;
            this.lblMaChuyenBayIP.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChuyenBayIP.Location = new System.Drawing.Point(285, 15);
            this.lblMaChuyenBayIP.Name = "lblMaChuyenBayIP";
            this.lblMaChuyenBayIP.Size = new System.Drawing.Size(223, 35);
            this.lblMaChuyenBayIP.TabIndex = 47;
            this.lblMaChuyenBayIP.Text = "[MaChuyenBay]";
            // 
            // txtGiabay
            // 
            this.txtGiabay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiabay.Location = new System.Drawing.Point(878, 126);
            this.txtGiabay.Name = "txtGiabay";
            this.txtGiabay.Size = new System.Drawing.Size(331, 42);
            this.txtGiabay.TabIndex = 46;
            // 
            // lblGiabay
            // 
            this.lblGiabay.AutoSize = true;
            this.lblGiabay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiabay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGiabay.Location = new System.Drawing.Point(609, 124);
            this.lblGiabay.Name = "lblGiabay";
            this.lblGiabay.Size = new System.Drawing.Size(114, 35);
            this.lblGiabay.TabIndex = 45;
            this.lblGiabay.Text = "Giá bay";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(878, 72);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(331, 43);
            this.cboTrangThai.TabIndex = 44;
            // 
            // lblMachuyenbay
            // 
            this.lblMachuyenbay.AutoSize = true;
            this.lblMachuyenbay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachuyenbay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMachuyenbay.Location = new System.Drawing.Point(22, 18);
            this.lblMachuyenbay.Name = "lblMachuyenbay";
            this.lblMachuyenbay.Size = new System.Drawing.Size(207, 35);
            this.lblMachuyenbay.TabIndex = 43;
            this.lblMachuyenbay.Text = "Mã chuyến bay";
            // 
            // cboTenmaybay
            // 
            this.cboTenmaybay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenmaybay.FormattingEnabled = true;
            this.cboTenmaybay.Location = new System.Drawing.Point(244, 125);
            this.cboTenmaybay.Name = "cboTenmaybay";
            this.cboTenmaybay.Size = new System.Drawing.Size(341, 43);
            this.cboTenmaybay.TabIndex = 42;
            // 
            // cboTenLoTrinh
            // 
            this.cboTenLoTrinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenLoTrinh.FormattingEnabled = true;
            this.cboTenLoTrinh.Location = new System.Drawing.Point(244, 67);
            this.cboTenLoTrinh.Name = "cboTenLoTrinh";
            this.cboTenLoTrinh.Size = new System.Drawing.Size(341, 43);
            this.cboTenLoTrinh.TabIndex = 41;
            // 
            // cboHangHangKhong
            // 
            this.cboHangHangKhong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHangHangKhong.FormattingEnabled = true;
            this.cboHangHangKhong.Location = new System.Drawing.Point(878, 15);
            this.cboHangHangKhong.Name = "cboHangHangKhong";
            this.cboHangHangKhong.Size = new System.Drawing.Size(331, 43);
            this.cboHangHangKhong.TabIndex = 40;
            // 
            // lblLotrinh
            // 
            this.lblLotrinh.AutoSize = true;
            this.lblLotrinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotrinh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLotrinh.Location = new System.Drawing.Point(24, 70);
            this.lblLotrinh.Name = "lblLotrinh";
            this.lblLotrinh.Size = new System.Drawing.Size(120, 35);
            this.lblLotrinh.TabIndex = 39;
            this.lblLotrinh.Text = "Lộ trình";
            // 
            // lblTenmaybay
            // 
            this.lblTenmaybay.AutoSize = true;
            this.lblTenmaybay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenmaybay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTenmaybay.Location = new System.Drawing.Point(22, 128);
            this.lblTenmaybay.Name = "lblTenmaybay";
            this.lblTenmaybay.Size = new System.Drawing.Size(178, 35);
            this.lblTenmaybay.TabIndex = 38;
            this.lblTenmaybay.Text = "Tên máy bay";
            // 
            // lblTrangThaiChuyenBay
            // 
            this.lblTrangThaiChuyenBay.AutoSize = true;
            this.lblTrangThaiChuyenBay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiChuyenBay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTrangThaiChuyenBay.Location = new System.Drawing.Point(605, 70);
            this.lblTrangThaiChuyenBay.Name = "lblTrangThaiChuyenBay";
            this.lblTrangThaiChuyenBay.Size = new System.Drawing.Size(156, 35);
            this.lblTrangThaiChuyenBay.TabIndex = 37;
            this.lblTrangThaiChuyenBay.Text = "Trạng Thái";
            // 
            // lblHangHangKhong
            // 
            this.lblHangHangKhong.AutoSize = true;
            this.lblHangHangKhong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangHangKhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHangHangKhong.Location = new System.Drawing.Point(605, 18);
            this.lblHangHangKhong.Name = "lblHangHangKhong";
            this.lblHangHangKhong.Size = new System.Drawing.Size(255, 35);
            this.lblHangHangKhong.TabIndex = 36;
            this.lblHangHangKhong.Text = "Hãng Hàng Không";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dTPNgayGioDi);
            this.panel1.Controls.Add(this.dTPNgayGioDen);
            this.panel1.Controls.Add(this.lblgayGioDen);
            this.panel1.Controls.Add(this.lblTenmaybay);
            this.panel1.Controls.Add(this.txtGiabay);
            this.panel1.Controls.Add(this.lblLotrinh);
            this.panel1.Controls.Add(this.lblGiabay);
            this.panel1.Controls.Add(this.cboTenLoTrinh);
            this.panel1.Controls.Add(this.cboTrangThai);
            this.panel1.Controls.Add(this.lblNgayGioDi);
            this.panel1.Controls.Add(this.cboHangHangKhong);
            this.panel1.Controls.Add(this.cboTenmaybay);
            this.panel1.Controls.Add(this.lblTrangThaiChuyenBay);
            this.panel1.Controls.Add(this.lblMaChuyenBayIP);
            this.panel1.Controls.Add(this.lblHangHangKhong);
            this.panel1.Controls.Add(this.lblMachuyenbay);
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 244);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Location = new System.Drawing.Point(12, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 85);
            this.panel2.TabIndex = 53;
            // 
            // frmQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1270, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDanhSachChuyenBay);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmQuanLyChuyenBay";
            this.Text = "frmQuanLyChuyenBay";
            this.Load += new System.EventHandler(this.frmQuanLyChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChuyenBay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachChuyenBay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dTPNgayGioDen;
        private System.Windows.Forms.DateTimePicker dTPNgayGioDi;
        private System.Windows.Forms.Label lblgayGioDen;
        private System.Windows.Forms.Label lblNgayGioDi;
        private System.Windows.Forms.Label lblMaChuyenBayIP;
        private System.Windows.Forms.TextBox txtGiabay;
        private System.Windows.Forms.Label lblGiabay;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblMachuyenbay;
        private System.Windows.Forms.ComboBox cboTenmaybay;
        private System.Windows.Forms.ComboBox cboTenLoTrinh;
        private System.Windows.Forms.ComboBox cboHangHangKhong;
        private System.Windows.Forms.Label lblLotrinh;
        private System.Windows.Forms.Label lblTenmaybay;
        private System.Windows.Forms.Label lblTrangThaiChuyenBay;
        private System.Windows.Forms.Label lblHangHangKhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}