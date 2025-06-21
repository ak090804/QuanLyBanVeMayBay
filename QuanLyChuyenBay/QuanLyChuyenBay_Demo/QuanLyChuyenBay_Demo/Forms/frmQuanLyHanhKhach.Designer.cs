
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyHanhKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHanhKhach));
            this.dataGridViewDanhSachHangKhach = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMahanhkhach = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblQuoctich = new System.Windows.Forms.Label();
            this.lblSodienthoai = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblCccd = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtQuoctich = new System.Windows.Forms.TextBox();
            this.txtCCCD_Passport = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.cboTenkhachhang = new System.Windows.Forms.ComboBox();
            this.lblMaHanhKhachOutPut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachHangKhach)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachHangKhach
            // 
            this.dataGridViewDanhSachHangKhach.AllowUserToAddRows = false;
            this.dataGridViewDanhSachHangKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachHangKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachHangKhach.Location = new System.Drawing.Point(21, 333);
            this.dataGridViewDanhSachHangKhach.Name = "dataGridViewDanhSachHangKhach";
            this.dataGridViewDanhSachHangKhach.RowHeadersWidth = 51;
            this.dataGridViewDanhSachHangKhach.RowTemplate.Height = 24;
            this.dataGridViewDanhSachHangKhach.Size = new System.Drawing.Size(1259, 213);
            this.dataGridViewDanhSachHangKhach.TabIndex = 0;
            this.dataGridViewDanhSachHangKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachHangKhach_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1063, 15);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(149, 63);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(535, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 63);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.Location = new System.Drawing.Point(810, 15);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(149, 63);
            this.btnLammoi.TabIndex = 22;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(45, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 63);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.GhostWhite;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(268, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 63);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMahanhkhach
            // 
            this.lblMahanhkhach.AutoSize = true;
            this.lblMahanhkhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMahanhkhach.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMahanhkhach.Location = new System.Drawing.Point(3, 25);
            this.lblMahanhkhach.Name = "lblMahanhkhach";
            this.lblMahanhkhach.Size = new System.Drawing.Size(172, 26);
            this.lblMahanhkhach.TabIndex = 25;
            this.lblMahanhkhach.Text = "Mã hành khách";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGioitinh.Location = new System.Drawing.Point(386, 194);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(104, 26);
            this.lblGioitinh.TabIndex = 26;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDiachi.Location = new System.Drawing.Point(3, 147);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(85, 26);
            this.lblDiachi.TabIndex = 27;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblQuoctich
            // 
            this.lblQuoctich.AutoSize = true;
            this.lblQuoctich.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoctich.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblQuoctich.Location = new System.Drawing.Point(3, 204);
            this.lblQuoctich.Name = "lblQuoctich";
            this.lblQuoctich.Size = new System.Drawing.Size(112, 26);
            this.lblQuoctich.TabIndex = 28;
            this.lblQuoctich.Text = "Quốc tịch";
            // 
            // lblSodienthoai
            // 
            this.lblSodienthoai.AutoSize = true;
            this.lblSodienthoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSodienthoai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSodienthoai.Location = new System.Drawing.Point(932, 81);
            this.lblSodienthoai.Name = "lblSodienthoai";
            this.lblSodienthoai.Size = new System.Drawing.Size(145, 26);
            this.lblSodienthoai.TabIndex = 29;
            this.lblSodienthoai.Text = "Số điện thoại";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysinh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNgaysinh.Location = new System.Drawing.Point(386, 81);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(113, 26);
            this.lblNgaysinh.TabIndex = 30;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblCccd
            // 
            this.lblCccd.AutoSize = true;
            this.lblCccd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCccd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCccd.Location = new System.Drawing.Point(932, 194);
            this.lblCccd.Name = "lblCccd";
            this.lblCccd.Size = new System.Drawing.Size(80, 26);
            this.lblCccd.TabIndex = 31;
            this.lblCccd.Text = "CCCD";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmail.Location = new System.Drawing.Point(932, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 26);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHoten.Location = new System.Drawing.Point(3, 88);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(81, 26);
            this.lblHoten.TabIndex = 33;
            this.lblHoten.Text = "Họ tên";
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkhachhang.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTenkhachhang.Location = new System.Drawing.Point(386, 135);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(187, 26);
            this.lblTenkhachhang.TabIndex = 34;
            this.lblTenkhachhang.Text = "Tên Khách Hàng";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(158, 81);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(222, 34);
            this.txtHoten.TabIndex = 35;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(158, 140);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(222, 34);
            this.txtDiachi.TabIndex = 36;
            // 
            // txtQuoctich
            // 
            this.txtQuoctich.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuoctich.Location = new System.Drawing.Point(158, 194);
            this.txtQuoctich.Name = "txtQuoctich";
            this.txtQuoctich.Size = new System.Drawing.Size(222, 34);
            this.txtQuoctich.TabIndex = 37;
            // 
            // txtCCCD_Passport
            // 
            this.txtCCCD_Passport.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD_Passport.Location = new System.Drawing.Point(1079, 185);
            this.txtCCCD_Passport.Name = "txtCCCD_Passport";
            this.txtCCCD_Passport.Size = new System.Drawing.Size(180, 34);
            this.txtCCCD_Passport.TabIndex = 38;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(1079, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 34);
            this.txtEmail.TabIndex = 39;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodienthoai.Location = new System.Drawing.Point(1079, 78);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(180, 34);
            this.txtSodienthoai.TabIndex = 40;
            // 
            // dateTimePickerNgaysinh
            // 
            this.dateTimePickerNgaysinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaysinh.Location = new System.Drawing.Point(627, 74);
            this.dateTimePickerNgaysinh.Name = "dateTimePickerNgaysinh";
            this.dateTimePickerNgaysinh.Size = new System.Drawing.Size(264, 34);
            this.dateTimePickerNgaysinh.TabIndex = 41;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(627, 192);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(81, 30);
            this.radNam.TabIndex = 42;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(774, 194);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(64, 30);
            this.radNu.TabIndex = 43;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // cboTenkhachhang
            // 
            this.cboTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenkhachhang.FormattingEnabled = true;
            this.cboTenkhachhang.Location = new System.Drawing.Point(627, 132);
            this.cboTenkhachhang.Name = "cboTenkhachhang";
            this.cboTenkhachhang.Size = new System.Drawing.Size(264, 33);
            this.cboTenkhachhang.TabIndex = 45;
            // 
            // lblMaHanhKhachOutPut
            // 
            this.lblMaHanhKhachOutPut.AutoSize = true;
            this.lblMaHanhKhachOutPut.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHanhKhachOutPut.Location = new System.Drawing.Point(286, 23);
            this.lblMaHanhKhachOutPut.Name = "lblMaHanhKhachOutPut";
            this.lblMaHanhKhachOutPut.Size = new System.Drawing.Size(188, 26);
            this.lblMaHanhKhachOutPut.TabIndex = 46;
            this.lblMaHanhKhachOutPut.Text = "[MaHanhKhach]";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMahanhkhach);
            this.panel1.Controls.Add(this.cboTenkhachhang);
            this.panel1.Controls.Add(this.lblMaHanhKhachOutPut);
            this.panel1.Controls.Add(this.dateTimePickerNgaysinh);
            this.panel1.Controls.Add(this.radNu);
            this.panel1.Controls.Add(this.txtCCCD_Passport);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblTenkhachhang);
            this.panel1.Controls.Add(this.txtSodienthoai);
            this.panel1.Controls.Add(this.lblNgaysinh);
            this.panel1.Controls.Add(this.lblCccd);
            this.panel1.Controls.Add(this.lblHoten);
            this.panel1.Controls.Add(this.radNam);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtHoten);
            this.panel1.Controls.Add(this.txtQuoctich);
            this.panel1.Controls.Add(this.lblDiachi);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.lblGioitinh);
            this.panel1.Controls.Add(this.lblSodienthoai);
            this.panel1.Controls.Add(this.lblQuoctich);
            this.panel1.Location = new System.Drawing.Point(21, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 239);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnLammoi);
            this.panel2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(21, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1259, 100);
            this.panel2.TabIndex = 48;
            // 
            // frmQuanLyHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1281, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDanhSachHangKhach);
            this.Name = "frmQuanLyHanhKhach";
            this.Text = "frmQuanLyHanhKhach";
            this.Load += new System.EventHandler(this.frmQuanLyHanhKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachHangKhach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachHangKhach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMahanhkhach;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblQuoctich;
        private System.Windows.Forms.Label lblSodienthoai;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblCccd;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtQuoctich;
        private System.Windows.Forms.TextBox txtCCCD_Passport;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaysinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.ComboBox cboTenkhachhang;
        private System.Windows.Forms.Label lblMaHanhKhachOutPut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}