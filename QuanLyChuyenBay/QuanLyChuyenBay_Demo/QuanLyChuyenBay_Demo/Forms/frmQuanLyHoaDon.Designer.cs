using System;
using System.Windows.Forms;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmQuanLyHoaDon : Form
    {
        private DataGridView dataGridViewDanhSachHoaDon;
        private Button btnThem;
        private Button btnSua;
        private TextBox txtMaPhieuDat;

        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHoaDon));
            this.dataGridViewDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaPhieuDat = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblMaPhieuDat = new System.Windows.Forms.Label();
            this.lblMaHoaDonIP = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienIP = new System.Windows.Forms.Label();
            this.btnTinhTongTien = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachHoaDon
            // 
            this.dataGridViewDanhSachHoaDon.AllowUserToAddRows = false;
            this.dataGridViewDanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDanhSachHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDanhSachHoaDon.ColumnHeadersHeight = 32;
            this.dataGridViewDanhSachHoaDon.Location = new System.Drawing.Point(283, 199);
            this.dataGridViewDanhSachHoaDon.Name = "dataGridViewDanhSachHoaDon";
            this.dataGridViewDanhSachHoaDon.RowHeadersWidth = 51;
            this.dataGridViewDanhSachHoaDon.Size = new System.Drawing.Size(761, 253);
            this.dataGridViewDanhSachHoaDon.TabIndex = 1;
            this.dataGridViewDanhSachHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachHoaDon_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(-1, -3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(247, 51);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm hóa đơn";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(-1, 54);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(247, 51);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa hóa đơn";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaPhieuDat
            // 
            this.txtMaPhieuDat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuDat.Location = new System.Drawing.Point(219, 85);
            this.txtMaPhieuDat.Name = "txtMaPhieuDat";
            this.txtMaPhieuDat.Size = new System.Drawing.Size(120, 39);
            this.txtMaPhieuDat.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(4, 344);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(239, 76);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.Location = new System.Drawing.Point(-1, 168);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(247, 51);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMaHoaDon.Location = new System.Drawing.Point(3, 16);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(181, 30);
            this.lblMaHoaDon.TabIndex = 11;
            this.lblMaHoaDon.Text = "Mã hóa đơn:";
            // 
            // lblMaPhieuDat
            // 
            this.lblMaPhieuDat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuDat.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMaPhieuDat.Location = new System.Drawing.Point(3, 91);
            this.lblMaPhieuDat.Name = "lblMaPhieuDat";
            this.lblMaPhieuDat.Size = new System.Drawing.Size(189, 33);
            this.lblMaPhieuDat.TabIndex = 12;
            this.lblMaPhieuDat.Text = "Mã phiếu đặt:";
            // 
            // lblMaHoaDonIP
            // 
            this.lblMaHoaDonIP.AutoSize = true;
            this.lblMaHoaDonIP.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDonIP.Location = new System.Drawing.Point(190, 11);
            this.lblMaHoaDonIP.Name = "lblMaHoaDonIP";
            this.lblMaHoaDonIP.Size = new System.Drawing.Size(173, 32);
            this.lblMaHoaDonIP.TabIndex = 13;
            this.lblMaHoaDonIP.Text = "[MaHoaDon]";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTongTien.Location = new System.Drawing.Point(406, 16);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(145, 32);
            this.lblTongTien.TabIndex = 14;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblTongTienIP
            // 
            this.lblTongTienIP.AutoSize = true;
            this.lblTongTienIP.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienIP.Location = new System.Drawing.Point(566, 16);
            this.lblTongTienIP.Name = "lblTongTienIP";
            this.lblTongTienIP.Size = new System.Drawing.Size(145, 32);
            this.lblTongTienIP.TabIndex = 15;
            this.lblTongTienIP.Text = "[TongTien]";
            // 
            // btnTinhTongTien
            // 
            this.btnTinhTongTien.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTinhTongTien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTongTien.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTinhTongTien.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhTongTien.Image")));
            this.btnTinhTongTien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinhTongTien.Location = new System.Drawing.Point(4, 282);
            this.btnTinhTongTien.Name = "btnTinhTongTien";
            this.btnTinhTongTien.Size = new System.Drawing.Size(243, 56);
            this.btnTinhTongTien.TabIndex = 16;
            this.btnTinhTongTien.Text = "Tạm tính";
            this.btnTinhTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhTongTien.UseVisualStyleBackColor = false;
            this.btnTinhTongTien.Click += new System.EventHandler(this.btnTinhTongTien_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 225);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(247, 51);
            this.btnThanhToan.TabIndex = 17;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnTinhTongTien);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 439);
            this.panel1.TabIndex = 18;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.GhostWhite;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.Location = new System.Drawing.Point(-4, 111);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(247, 51);
            this.btnIn.TabIndex = 20;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMaHoaDon);
            this.panel2.Controls.Add(this.lblMaHoaDonIP);
            this.panel2.Controls.Add(this.lblTongTienIP);
            this.panel2.Controls.Add(this.lblMaPhieuDat);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.txtMaPhieuDat);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(283, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 173);
            this.panel2.TabIndex = 19;
            // 
            // frmQuanLyHoaDon
            // 
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1197, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDanhSachHoaDon);
            this.Name = "frmQuanLyHoaDon";
            this.Text = "frmQuanLyHoaDon";
            this.Load += new System.EventHandler(this.frmQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void BtnAddInvoice_Click(object sender, EventArgs e)
        {
            // Logic for adding an invoice
            MessageBox.Show("Thêm hóa đơn mới!");
        }

        private void BtnEditInvoice_Click(object sender, EventArgs e)
        {
            // Logic for editing an invoice
            MessageBox.Show("Chỉnh sửa hóa đơn!");
        }

        private void BtnDeleteInvoice_Click(object sender, EventArgs e)
        {
            // Logic for deleting an invoice
            MessageBox.Show("Xóa hóa đơn!");
        }

        private void BtnSearchInvoice_Click(object sender, EventArgs e)
        {
            // Logic for searching an invoice
            MessageBox.Show($"Tìm kiếm hóa đơn với từ khóa: {txtMaPhieuDat.Text}");
        }
        private Button btnThoat;
        private Button btnLamMoi;
        private Label lblMaHoaDon;
        private Label lblMaPhieuDat;
        private Label lblMaHoaDonIP;
        private Label lblTongTien;
        private Label lblTongTienIP;
        private Button btnTinhTongTien;
        private Button btnThanhToan;
        private Panel panel1;
        private Panel panel2;
        private Button btnIn;
    }
}
