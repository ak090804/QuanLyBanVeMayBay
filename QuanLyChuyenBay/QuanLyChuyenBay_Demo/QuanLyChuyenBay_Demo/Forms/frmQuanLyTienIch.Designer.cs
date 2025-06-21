
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyTienIch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTienIch));
            this.dataGridViewDanhSachTienIch = new System.Windows.Forms.DataGridView();
            this.txtTentienich = new System.Windows.Forms.TextBox();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.lblTrangthaive = new System.Windows.Forms.Label();
            this.lblMatienich = new System.Windows.Forms.Label();
            this.txtGiatienich = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMatienichIP = new System.Windows.Forms.Label();
            this.lblLoaiTienIch = new System.Windows.Forms.Label();
            this.cboLoaiTienIch = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachTienIch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachTienIch
            // 
            this.dataGridViewDanhSachTienIch.AllowUserToAddRows = false;
            this.dataGridViewDanhSachTienIch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachTienIch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachTienIch.Location = new System.Drawing.Point(595, 2);
            this.dataGridViewDanhSachTienIch.Name = "dataGridViewDanhSachTienIch";
            this.dataGridViewDanhSachTienIch.RowHeadersWidth = 51;
            this.dataGridViewDanhSachTienIch.RowTemplate.Height = 24;
            this.dataGridViewDanhSachTienIch.Size = new System.Drawing.Size(625, 426);
            this.dataGridViewDanhSachTienIch.TabIndex = 0;
            this.dataGridViewDanhSachTienIch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachTienIch_CellClick);
            // 
            // txtTentienich
            // 
            this.txtTentienich.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentienich.Location = new System.Drawing.Point(226, 71);
            this.txtTentienich.Name = "txtTentienich";
            this.txtTentienich.Size = new System.Drawing.Size(326, 42);
            this.txtTentienich.TabIndex = 12;
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.BackColor = System.Drawing.Color.GhostWhite;
            this.lblTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkhachhang.ForeColor = System.Drawing.Color.Navy;
            this.lblTenkhachhang.Location = new System.Drawing.Point(15, 78);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(164, 35);
            this.lblTenkhachhang.TabIndex = 9;
            this.lblTenkhachhang.Text = "Tên tiện ích";
            // 
            // lblTrangthaive
            // 
            this.lblTrangthaive.AutoSize = true;
            this.lblTrangthaive.BackColor = System.Drawing.Color.GhostWhite;
            this.lblTrangthaive.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthaive.ForeColor = System.Drawing.Color.Navy;
            this.lblTrangthaive.Location = new System.Drawing.Point(15, 138);
            this.lblTrangthaive.Name = "lblTrangthaive";
            this.lblTrangthaive.Size = new System.Drawing.Size(161, 35);
            this.lblTrangthaive.TabIndex = 8;
            this.lblTrangthaive.Text = "Giá tiện ích";
            // 
            // lblMatienich
            // 
            this.lblMatienich.AutoSize = true;
            this.lblMatienich.BackColor = System.Drawing.Color.GhostWhite;
            this.lblMatienich.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatienich.ForeColor = System.Drawing.Color.Navy;
            this.lblMatienich.Location = new System.Drawing.Point(15, 23);
            this.lblMatienich.Name = "lblMatienich";
            this.lblMatienich.Size = new System.Drawing.Size(158, 35);
            this.lblMatienich.TabIndex = 7;
            this.lblMatienich.Text = "Mã tiện ích";
            this.lblMatienich.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGiatienich
            // 
            this.txtGiatienich.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatienich.Location = new System.Drawing.Point(226, 138);
            this.txtGiatienich.Name = "txtGiatienich";
            this.txtGiatienich.Size = new System.Drawing.Size(326, 42);
            this.txtGiatienich.TabIndex = 13;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Navy;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1019, 452);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(201, 72);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Navy;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(350, 252);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(202, 72);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.Navy;
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.Location = new System.Drawing.Point(350, 345);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(202, 72);
            this.btnLammoi.TabIndex = 22;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Navy;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(21, 252);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(202, 72);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Navy;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(21, 345);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(202, 72);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMatienichIP
            // 
            this.lblMatienichIP.AutoSize = true;
            this.lblMatienichIP.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatienichIP.Location = new System.Drawing.Point(220, 23);
            this.lblMatienichIP.Name = "lblMatienichIP";
            this.lblMatienichIP.Size = new System.Drawing.Size(174, 35);
            this.lblMatienichIP.TabIndex = 25;
            this.lblMatienichIP.Text = "[MaTienIch]";
            // 
            // lblLoaiTienIch
            // 
            this.lblLoaiTienIch.AutoSize = true;
            this.lblLoaiTienIch.BackColor = System.Drawing.Color.GhostWhite;
            this.lblLoaiTienIch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiTienIch.ForeColor = System.Drawing.Color.Navy;
            this.lblLoaiTienIch.Location = new System.Drawing.Point(15, 197);
            this.lblLoaiTienIch.Name = "lblLoaiTienIch";
            this.lblLoaiTienIch.Size = new System.Drawing.Size(172, 35);
            this.lblLoaiTienIch.TabIndex = 28;
            this.lblLoaiTienIch.Text = "Loại tiện ích";
            // 
            // cboLoaiTienIch
            // 
            this.cboLoaiTienIch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiTienIch.FormattingEnabled = true;
            this.cboLoaiTienIch.Location = new System.Drawing.Point(226, 192);
            this.cboLoaiTienIch.Name = "cboLoaiTienIch";
            this.cboLoaiTienIch.Size = new System.Drawing.Size(326, 43);
            this.cboLoaiTienIch.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGiatienich);
            this.panel1.Controls.Add(this.cboLoaiTienIch);
            this.panel1.Controls.Add(this.btnLammoi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.lblMatienich);
            this.panel1.Controls.Add(this.lblLoaiTienIch);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lblTrangthaive);
            this.panel1.Controls.Add(this.lblMatienichIP);
            this.panel1.Controls.Add(this.lblTenkhachhang);
            this.panel1.Controls.Add(this.txtTentienich);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 426);
            this.panel1.TabIndex = 30;
            // 
            // frmQuanLyTienIch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1232, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridViewDanhSachTienIch);
            this.Name = "frmQuanLyTienIch";
            this.Text = "frmQuanLyTienIch";
            this.Load += new System.EventHandler(this.frmQuanLyTienIch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachTienIch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachTienIch;
        private System.Windows.Forms.TextBox txtTentienich;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.Label lblTrangthaive;
        private System.Windows.Forms.Label lblMatienich;
        private System.Windows.Forms.TextBox txtGiatienich;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMatienichIP;
        private System.Windows.Forms.Label lblLoaiTienIch;
        private System.Windows.Forms.ComboBox cboLoaiTienIch;
        private System.Windows.Forms.Panel panel1;
    }
}