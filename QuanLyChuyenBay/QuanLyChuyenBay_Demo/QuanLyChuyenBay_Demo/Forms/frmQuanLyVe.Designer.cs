
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyVe));
            this.dataGridViewDanhSachVe = new System.Windows.Forms.DataGridView();
            this.lblMaChuyenBay = new System.Windows.Forms.Label();
            this.lblTrangthaive = new System.Windows.Forms.Label();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.cboMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.cboTrangthaive = new System.Windows.Forms.ComboBox();
            this.dataGridViewChiTietVe = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboTenHanhKhach = new System.Windows.Forms.ComboBox();
            this.lblMaHangGhe = new System.Windows.Forms.Label();
            this.cboMaHangGhe = new System.Windows.Forms.ComboBox();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.lblMaVeoutput = new System.Windows.Forms.Label();
            this.lblMaVett = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietVe)).BeginInit();
            this.panelThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachVe
            // 
            this.dataGridViewDanhSachVe.AllowUserToAddRows = false;
            this.dataGridViewDanhSachVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachVe.Location = new System.Drawing.Point(741, 12);
            this.dataGridViewDanhSachVe.Name = "dataGridViewDanhSachVe";
            this.dataGridViewDanhSachVe.RowHeadersWidth = 51;
            this.dataGridViewDanhSachVe.RowTemplate.Height = 24;
            this.dataGridViewDanhSachVe.Size = new System.Drawing.Size(445, 302);
            this.dataGridViewDanhSachVe.TabIndex = 0;
            this.dataGridViewDanhSachVe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachVe_CellDoubleClick);
            // 
            // lblMaChuyenBay
            // 
            this.lblMaChuyenBay.AutoSize = true;
            this.lblMaChuyenBay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChuyenBay.ForeColor = System.Drawing.Color.Navy;
            this.lblMaChuyenBay.Location = new System.Drawing.Point(16, 187);
            this.lblMaChuyenBay.Name = "lblMaChuyenBay";
            this.lblMaChuyenBay.Size = new System.Drawing.Size(207, 35);
            this.lblMaChuyenBay.TabIndex = 1;
            this.lblMaChuyenBay.Text = "Mã chuyến bay";
            this.lblMaChuyenBay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTrangthaive
            // 
            this.lblTrangthaive.AutoSize = true;
            this.lblTrangthaive.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthaive.ForeColor = System.Drawing.Color.Navy;
            this.lblTrangthaive.Location = new System.Drawing.Point(16, 132);
            this.lblTrangthaive.Name = "lblTrangthaive";
            this.lblTrangthaive.Size = new System.Drawing.Size(190, 35);
            this.lblTrangthaive.TabIndex = 2;
            this.lblTrangthaive.Text = "Trạng  thái vé";
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkhachhang.ForeColor = System.Drawing.Color.Navy;
            this.lblTenkhachhang.Location = new System.Drawing.Point(16, 70);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(218, 35);
            this.lblTenkhachhang.TabIndex = 3;
            this.lblTenkhachhang.Text = "Tên hành khách";
            // 
            // cboMaChuyenBay
            // 
            this.cboMaChuyenBay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaChuyenBay.FormattingEnabled = true;
            this.cboMaChuyenBay.Location = new System.Drawing.Point(283, 187);
            this.cboMaChuyenBay.Name = "cboMaChuyenBay";
            this.cboMaChuyenBay.Size = new System.Drawing.Size(241, 43);
            this.cboMaChuyenBay.TabIndex = 4;
            // 
            // cboTrangthaive
            // 
            this.cboTrangthaive.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangthaive.FormattingEnabled = true;
            this.cboTrangthaive.Location = new System.Drawing.Point(283, 132);
            this.cboTrangthaive.Name = "cboTrangthaive";
            this.cboTrangthaive.Size = new System.Drawing.Size(241, 43);
            this.cboTrangthaive.TabIndex = 5;
            // 
            // dataGridViewChiTietVe
            // 
            this.dataGridViewChiTietVe.AllowUserToAddRows = false;
            this.dataGridViewChiTietVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietVe.Location = new System.Drawing.Point(8, 320);
            this.dataGridViewChiTietVe.Name = "dataGridViewChiTietVe";
            this.dataGridViewChiTietVe.RowHeadersWidth = 51;
            this.dataGridViewChiTietVe.RowTemplate.Height = 24;
            this.dataGridViewChiTietVe.Size = new System.Drawing.Size(1178, 166);
            this.dataGridViewChiTietVe.TabIndex = 7;
            this.dataGridViewChiTietVe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTietVe_CellDoubleClick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Navy;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1035, 492);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(151, 63);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Navy;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(550, 72);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(177, 73);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa vé";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.Navy;
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.Location = new System.Drawing.Point(550, 219);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(177, 82);
            this.btnLammoi.TabIndex = 22;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Navy;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(550, -1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(177, 78);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Tạo vé";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.GhostWhite;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Navy;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(550, 143);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(177, 78);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa vé";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboTenHanhKhach
            // 
            this.cboTenHanhKhach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenHanhKhach.FormattingEnabled = true;
            this.cboTenHanhKhach.Location = new System.Drawing.Point(283, 67);
            this.cboTenHanhKhach.Name = "cboTenHanhKhach";
            this.cboTenHanhKhach.Size = new System.Drawing.Size(241, 43);
            this.cboTenHanhKhach.TabIndex = 25;
            // 
            // lblMaHangGhe
            // 
            this.lblMaHangGhe.AutoSize = true;
            this.lblMaHangGhe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHangGhe.ForeColor = System.Drawing.Color.Navy;
            this.lblMaHangGhe.Location = new System.Drawing.Point(16, 247);
            this.lblMaHangGhe.Name = "lblMaHangGhe";
            this.lblMaHangGhe.Size = new System.Drawing.Size(136, 35);
            this.lblMaHangGhe.TabIndex = 30;
            this.lblMaHangGhe.Text = "Hàng ghế";
            // 
            // cboMaHangGhe
            // 
            this.cboMaHangGhe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHangGhe.FormattingEnabled = true;
            this.cboMaHangGhe.Location = new System.Drawing.Point(283, 244);
            this.cboMaHangGhe.Name = "cboMaHangGhe";
            this.cboMaHangGhe.Size = new System.Drawing.Size(241, 43);
            this.cboMaHangGhe.TabIndex = 31;
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(this.btnLammoi);
            this.panelThongTin.Controls.Add(this.btnXoa);
            this.panelThongTin.Controls.Add(this.btnThem);
            this.panelThongTin.Controls.Add(this.btnSua);
            this.panelThongTin.Controls.Add(this.lblMaVeoutput);
            this.panelThongTin.Controls.Add(this.lblMaVett);
            this.panelThongTin.Controls.Add(this.cboMaChuyenBay);
            this.panelThongTin.Controls.Add(this.cboMaHangGhe);
            this.panelThongTin.Controls.Add(this.lblMaHangGhe);
            this.panelThongTin.Controls.Add(this.lblMaChuyenBay);
            this.panelThongTin.Controls.Add(this.lblTrangthaive);
            this.panelThongTin.Controls.Add(this.lblTenkhachhang);
            this.panelThongTin.Controls.Add(this.cboTrangthaive);
            this.panelThongTin.Controls.Add(this.cboTenHanhKhach);
            this.panelThongTin.Location = new System.Drawing.Point(8, 12);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(727, 302);
            this.panelThongTin.TabIndex = 32;
            // 
            // lblMaVeoutput
            // 
            this.lblMaVeoutput.AutoSize = true;
            this.lblMaVeoutput.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVeoutput.Location = new System.Drawing.Point(277, 16);
            this.lblMaVeoutput.Name = "lblMaVeoutput";
            this.lblMaVeoutput.Size = new System.Drawing.Size(113, 35);
            this.lblMaVeoutput.TabIndex = 36;
            this.lblMaVeoutput.Text = "[Mã vé]";
            // 
            // lblMaVett
            // 
            this.lblMaVett.AutoSize = true;
            this.lblMaVett.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVett.ForeColor = System.Drawing.Color.Navy;
            this.lblMaVett.Location = new System.Drawing.Point(16, 16);
            this.lblMaVett.Name = "lblMaVett";
            this.lblMaVett.Size = new System.Drawing.Size(93, 35);
            this.lblMaVett.TabIndex = 35;
            this.lblMaVett.Text = "Mã vé";
            // 
            // frmQuanLyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1268, 588);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridViewChiTietVe);
            this.Controls.Add(this.dataGridViewDanhSachVe);
            this.Name = "frmQuanLyVe";
            this.Text = "frmQuanLyVe";
            this.Load += new System.EventHandler(this.frmQuanLyVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietVe)).EndInit();
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachVe;
        private System.Windows.Forms.Label lblMaChuyenBay;
        private System.Windows.Forms.Label lblTrangthaive;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.ComboBox cboMaChuyenBay;
        private System.Windows.Forms.ComboBox cboTrangthaive;
        private System.Windows.Forms.DataGridView dataGridViewChiTietVe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboTenHanhKhach;
        private System.Windows.Forms.Label lblMaHangGhe;
        private System.Windows.Forms.ComboBox cboMaHangGhe;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Label lblMaVeoutput;
        private System.Windows.Forms.Label lblMaVett;
    }
}