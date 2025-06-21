
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyPhieuDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyPhieuDat));
            this.dataGridViewDanhSachPhieuDat = new System.Windows.Forms.DataGridView();
            this.lblMaphieudat = new System.Windows.Forms.Label();
            this.btnXoaPhieuDat = new System.Windows.Forms.Button();
            this.btnTaoPhieuDat = new System.Windows.Forms.Button();
            this.btnSuaPhieuDat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuaChiTiet = new System.Windows.Forms.Button();
            this.dateTimePickerNgayDat = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.cboTenKhachHang = new System.Windows.Forms.ComboBox();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachChiTietPhieuDat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhieuDat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChiTietPhieuDat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachPhieuDat
            // 
            this.dataGridViewDanhSachPhieuDat.AllowUserToAddRows = false;
            this.dataGridViewDanhSachPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachPhieuDat.Location = new System.Drawing.Point(12, 338);
            this.dataGridViewDanhSachPhieuDat.Name = "dataGridViewDanhSachPhieuDat";
            this.dataGridViewDanhSachPhieuDat.RowHeadersWidth = 51;
            this.dataGridViewDanhSachPhieuDat.RowTemplate.Height = 24;
            this.dataGridViewDanhSachPhieuDat.Size = new System.Drawing.Size(785, 153);
            this.dataGridViewDanhSachPhieuDat.TabIndex = 6;
            this.dataGridViewDanhSachPhieuDat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachPhieuDat_CellDoubleClick);
            // 
            // lblMaphieudat
            // 
            this.lblMaphieudat.AutoSize = true;
            this.lblMaphieudat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaphieudat.ForeColor = System.Drawing.Color.Navy;
            this.lblMaphieudat.Location = new System.Drawing.Point(3, 0);
            this.lblMaphieudat.Name = "lblMaphieudat";
            this.lblMaphieudat.Size = new System.Drawing.Size(175, 35);
            this.lblMaphieudat.TabIndex = 7;
            this.lblMaphieudat.Text = "MaPhieuDat";
            // 
            // btnXoaPhieuDat
            // 
            this.btnXoaPhieuDat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnXoaPhieuDat.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuDat.ForeColor = System.Drawing.Color.Navy;
            this.btnXoaPhieuDat.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuDat.Image")));
            this.btnXoaPhieuDat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhieuDat.Location = new System.Drawing.Point(362, 61);
            this.btnXoaPhieuDat.Name = "btnXoaPhieuDat";
            this.btnXoaPhieuDat.Size = new System.Drawing.Size(186, 60);
            this.btnXoaPhieuDat.TabIndex = 15;
            this.btnXoaPhieuDat.Text = "Xóa ";
            this.btnXoaPhieuDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieuDat.UseVisualStyleBackColor = false;
            this.btnXoaPhieuDat.Click += new System.EventHandler(this.btnXoaPhieuDat_Click);
            // 
            // btnTaoPhieuDat
            // 
            this.btnTaoPhieuDat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTaoPhieuDat.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuDat.ForeColor = System.Drawing.Color.Navy;
            this.btnTaoPhieuDat.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieuDat.Image")));
            this.btnTaoPhieuDat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoPhieuDat.Location = new System.Drawing.Point(9, 61);
            this.btnTaoPhieuDat.Name = "btnTaoPhieuDat";
            this.btnTaoPhieuDat.Size = new System.Drawing.Size(134, 60);
            this.btnTaoPhieuDat.TabIndex = 16;
            this.btnTaoPhieuDat.Text = "Tạo ";
            this.btnTaoPhieuDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPhieuDat.UseVisualStyleBackColor = false;
            this.btnTaoPhieuDat.Click += new System.EventHandler(this.btnTaoPhieuDat_Click);
            // 
            // btnSuaPhieuDat
            // 
            this.btnSuaPhieuDat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSuaPhieuDat.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhieuDat.ForeColor = System.Drawing.Color.Navy;
            this.btnSuaPhieuDat.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPhieuDat.Image")));
            this.btnSuaPhieuDat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaPhieuDat.Location = new System.Drawing.Point(158, 61);
            this.btnSuaPhieuDat.Name = "btnSuaPhieuDat";
            this.btnSuaPhieuDat.Size = new System.Drawing.Size(175, 60);
            this.btnSuaPhieuDat.TabIndex = 18;
            this.btnSuaPhieuDat.Text = "Sửa ";
            this.btnSuaPhieuDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPhieuDat.UseVisualStyleBackColor = false;
            this.btnSuaPhieuDat.Click += new System.EventHandler(this.btnSuaPhieuDat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Navy;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(598, 235);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(187, 42);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSuaChiTiet);
            this.panel1.Controls.Add(this.dateTimePickerNgayDat);
            this.panel1.Controls.Add(this.lblNgayDat);
            this.panel1.Controls.Add(this.lblMaphieudat);
            this.panel1.Controls.Add(this.cboTenKhachHang);
            this.panel1.Controls.Add(this.lblTenkhachhang);
            this.panel1.Controls.Add(this.btnXoaPhieuDat);
            this.panel1.Controls.Add(this.btnTaoPhieuDat);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnSuaPhieuDat);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 320);
            this.panel1.TabIndex = 27;
            // 
            // btnSuaChiTiet
            // 
            this.btnSuaChiTiet.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSuaChiTiet.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiTiet.ForeColor = System.Drawing.Color.Navy;
            this.btnSuaChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaChiTiet.Image")));
            this.btnSuaChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaChiTiet.Location = new System.Drawing.Point(575, 61);
            this.btnSuaChiTiet.Name = "btnSuaChiTiet";
            this.btnSuaChiTiet.Size = new System.Drawing.Size(210, 60);
            this.btnSuaChiTiet.TabIndex = 45;
            this.btnSuaChiTiet.Text = "Sửa Chi Tiết ";
            this.btnSuaChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaChiTiet.UseVisualStyleBackColor = false;
            this.btnSuaChiTiet.Click += new System.EventHandler(this.btnSuaChiTiet_Click);
            // 
            // dateTimePickerNgayDat
            // 
            this.dateTimePickerNgayDat.CustomFormat = "";
            this.dateTimePickerNgayDat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayDat.Location = new System.Drawing.Point(171, 235);
            this.dateTimePickerNgayDat.Name = "dateTimePickerNgayDat";
            this.dateTimePickerNgayDat.Size = new System.Drawing.Size(395, 42);
            this.dateTimePickerNgayDat.TabIndex = 44;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDat.ForeColor = System.Drawing.Color.Navy;
            this.lblNgayDat.Location = new System.Drawing.Point(3, 235);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(130, 35);
            this.lblNgayDat.TabIndex = 43;
            this.lblNgayDat.Text = "Ngày đặt";
            // 
            // cboTenKhachHang
            // 
            this.cboTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenKhachHang.FormattingEnabled = true;
            this.cboTenKhachHang.Location = new System.Drawing.Point(250, 143);
            this.cboTenKhachHang.Name = "cboTenKhachHang";
            this.cboTenKhachHang.Size = new System.Drawing.Size(316, 43);
            this.cboTenKhachHang.TabIndex = 42;
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkhachhang.ForeColor = System.Drawing.Color.Navy;
            this.lblTenkhachhang.Location = new System.Drawing.Point(3, 146);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(217, 35);
            this.lblTenkhachhang.TabIndex = 41;
            this.lblTenkhachhang.Text = "Tên khách hàng";
            // 
            // dataGridViewDanhSachChiTietPhieuDat
            // 
            this.dataGridViewDanhSachChiTietPhieuDat.AllowUserToAddRows = false;
            this.dataGridViewDanhSachChiTietPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachChiTietPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachChiTietPhieuDat.Location = new System.Drawing.Point(814, 9);
            this.dataGridViewDanhSachChiTietPhieuDat.Name = "dataGridViewDanhSachChiTietPhieuDat";
            this.dataGridViewDanhSachChiTietPhieuDat.RowHeadersWidth = 51;
            this.dataGridViewDanhSachChiTietPhieuDat.RowTemplate.Height = 24;
            this.dataGridViewDanhSachChiTietPhieuDat.Size = new System.Drawing.Size(556, 482);
            this.dataGridViewDanhSachChiTietPhieuDat.TabIndex = 30;
            // 
            // frmQuanLyPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1382, 503);
            this.Controls.Add(this.dataGridViewDanhSachChiTietPhieuDat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDanhSachPhieuDat);
            this.Name = "frmQuanLyPhieuDat";
            this.Text = "frmQuanLyPhieuDat";
            this.Load += new System.EventHandler(this.frmQuanLyPhieuDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhieuDat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChiTietPhieuDat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachPhieuDat;
        private System.Windows.Forms.Label lblMaphieudat;
        private System.Windows.Forms.Button btnXoaPhieuDat;
        private System.Windows.Forms.Button btnTaoPhieuDat;
        private System.Windows.Forms.Button btnSuaPhieuDat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachChiTietPhieuDat;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDat;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.ComboBox cboTenKhachHang;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.Button btnSuaChiTiet;
    }
}