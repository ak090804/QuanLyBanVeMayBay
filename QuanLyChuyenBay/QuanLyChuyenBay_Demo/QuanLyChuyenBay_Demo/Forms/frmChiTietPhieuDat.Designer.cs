namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmChiTietPhieuDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuDat));
            this.lblVe = new System.Windows.Forms.Label();
            this.cboVe = new System.Windows.Forms.ComboBox();
            this.cboChuyenBay = new System.Windows.Forms.ComboBox();
            this.lblChuyenBay = new System.Windows.Forms.Label();
            this.panelThongTinVe = new System.Windows.Forms.Panel();
            this.lblHanhKhach = new System.Windows.Forms.Label();
            this.cboHanhKhach = new System.Windows.Forms.ComboBox();
            this.lblLoTrinh = new System.Windows.Forms.Label();
            this.cboTenLoTrinh = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemVe = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblMaphieudat = new System.Windows.Forms.Label();
            this.dataGridViewChiTietPhieuDat = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelThongTinVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuDat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVe
            // 
            this.lblVe.AutoSize = true;
            this.lblVe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVe.Location = new System.Drawing.Point(8, 112);
            this.lblVe.Name = "lblVe";
            this.lblVe.Size = new System.Drawing.Size(40, 26);
            this.lblVe.TabIndex = 1;
            this.lblVe.Text = "Vé";
            // 
            // cboVe
            // 
            this.cboVe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVe.FormattingEnabled = true;
            this.cboVe.Location = new System.Drawing.Point(127, 109);
            this.cboVe.Name = "cboVe";
            this.cboVe.Size = new System.Drawing.Size(155, 33);
            this.cboVe.TabIndex = 2;
            // 
            // cboChuyenBay
            // 
            this.cboChuyenBay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuyenBay.FormattingEnabled = true;
            this.cboChuyenBay.Location = new System.Drawing.Point(777, 43);
            this.cboChuyenBay.Name = "cboChuyenBay";
            this.cboChuyenBay.Size = new System.Drawing.Size(433, 33);
            this.cboChuyenBay.TabIndex = 4;
            this.cboChuyenBay.SelectedIndexChanged += new System.EventHandler(this.cboChuyenBay_SelectedIndexChanged);
            // 
            // lblChuyenBay
            // 
            this.lblChuyenBay.AutoSize = true;
            this.lblChuyenBay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuyenBay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblChuyenBay.Location = new System.Drawing.Point(578, 43);
            this.lblChuyenBay.Name = "lblChuyenBay";
            this.lblChuyenBay.Size = new System.Drawing.Size(137, 26);
            this.lblChuyenBay.TabIndex = 3;
            this.lblChuyenBay.Text = "Chuyến Bay";
            // 
            // panelThongTinVe
            // 
            this.panelThongTinVe.Controls.Add(this.lblHanhKhach);
            this.panelThongTinVe.Controls.Add(this.cboHanhKhach);
            this.panelThongTinVe.Controls.Add(this.lblLoTrinh);
            this.panelThongTinVe.Controls.Add(this.cboChuyenBay);
            this.panelThongTinVe.Controls.Add(this.cboTenLoTrinh);
            this.panelThongTinVe.Controls.Add(this.lblVe);
            this.panelThongTinVe.Controls.Add(this.cboVe);
            this.panelThongTinVe.Controls.Add(this.lblChuyenBay);
            this.panelThongTinVe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panelThongTinVe.Location = new System.Drawing.Point(12, 14);
            this.panelThongTinVe.Name = "panelThongTinVe";
            this.panelThongTinVe.Size = new System.Drawing.Size(1220, 173);
            this.panelThongTinVe.TabIndex = 32;
            // 
            // lblHanhKhach
            // 
            this.lblHanhKhach.AutoSize = true;
            this.lblHanhKhach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblHanhKhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHanhKhach.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHanhKhach.Location = new System.Drawing.Point(578, 109);
            this.lblHanhKhach.Name = "lblHanhKhach";
            this.lblHanhKhach.Size = new System.Drawing.Size(137, 26);
            this.lblHanhKhach.TabIndex = 42;
            this.lblHanhKhach.Text = "Hành khách";
            // 
            // cboHanhKhach
            // 
            this.cboHanhKhach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cboHanhKhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHanhKhach.FormattingEnabled = true;
            this.cboHanhKhach.Location = new System.Drawing.Point(777, 105);
            this.cboHanhKhach.Name = "cboHanhKhach";
            this.cboHanhKhach.Size = new System.Drawing.Size(433, 33);
            this.cboHanhKhach.TabIndex = 43;
            // 
            // lblLoTrinh
            // 
            this.lblLoTrinh.AutoSize = true;
            this.lblLoTrinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoTrinh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLoTrinh.Location = new System.Drawing.Point(8, 46);
            this.lblLoTrinh.Name = "lblLoTrinh";
            this.lblLoTrinh.Size = new System.Drawing.Size(98, 26);
            this.lblLoTrinh.TabIndex = 39;
            this.lblLoTrinh.Text = "Lộ trình";
            // 
            // cboTenLoTrinh
            // 
            this.cboTenLoTrinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenLoTrinh.FormattingEnabled = true;
            this.cboTenLoTrinh.Location = new System.Drawing.Point(127, 43);
            this.cboTenLoTrinh.Name = "cboTenLoTrinh";
            this.cboTenLoTrinh.Size = new System.Drawing.Size(317, 33);
            this.cboTenLoTrinh.TabIndex = 40;
            this.cboTenLoTrinh.SelectedIndexChanged += new System.EventHandler(this.cboTenLoTrinh_SelectedIndexChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.Location = new System.Drawing.Point(762, 29);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(185, 46);
            this.btnLamMoi.TabIndex = 41;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.GhostWhite;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(242, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 46);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa Vé";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemVe
            // 
            this.btnThemVe.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThemVe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVe.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThemVe.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVe.Image")));
            this.btnThemVe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVe.Location = new System.Drawing.Point(-4, 29);
            this.btnThemVe.Name = "btnThemVe";
            this.btnThemVe.Size = new System.Drawing.Size(181, 46);
            this.btnThemVe.TabIndex = 35;
            this.btnThemVe.Text = "Thêm Vé";
            this.btnThemVe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVe.UseVisualStyleBackColor = false;
            this.btnThemVe.Click += new System.EventHandler(this.btnThemVe_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.GhostWhite;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLai.Image")));
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLai.Location = new System.Drawing.Point(1028, 27);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(182, 50);
            this.btnQuayLai.TabIndex = 37;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(512, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(179, 46);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa Vé";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblMaphieudat
            // 
            this.lblMaphieudat.AutoSize = true;
            this.lblMaphieudat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaphieudat.Location = new System.Drawing.Point(17, -2);
            this.lblMaphieudat.Name = "lblMaphieudat";
            this.lblMaphieudat.Size = new System.Drawing.Size(143, 26);
            this.lblMaphieudat.TabIndex = 35;
            this.lblMaphieudat.Text = "MaPhieuDat";
            // 
            // dataGridViewChiTietPhieuDat
            // 
            this.dataGridViewChiTietPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietPhieuDat.Location = new System.Drawing.Point(12, 298);
            this.dataGridViewChiTietPhieuDat.Name = "dataGridViewChiTietPhieuDat";
            this.dataGridViewChiTietPhieuDat.RowHeadersWidth = 51;
            this.dataGridViewChiTietPhieuDat.RowTemplate.Height = 24;
            this.dataGridViewChiTietPhieuDat.Size = new System.Drawing.Size(1220, 183);
            this.dataGridViewChiTietPhieuDat.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemVe);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Location = new System.Drawing.Point(12, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 100);
            this.panel1.TabIndex = 37;
            // 
            // frmChiTietPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1236, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewChiTietPhieuDat);
            this.Controls.Add(this.lblMaphieudat);
            this.Controls.Add(this.panelThongTinVe);
            this.Name = "frmChiTietPhieuDat";
            this.Text = "frmChiTietPhieuDat";
            this.Load += new System.EventHandler(this.frmChiTietPhieuDat_Load);
            this.panelThongTinVe.ResumeLayout(false);
            this.panelThongTinVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuDat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVe;
        private System.Windows.Forms.ComboBox cboVe;
        private System.Windows.Forms.ComboBox cboChuyenBay;
        private System.Windows.Forms.Label lblChuyenBay;
        private System.Windows.Forms.Panel panelThongTinVe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemVe;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblMaphieudat;
        private System.Windows.Forms.DataGridView dataGridViewChiTietPhieuDat;
        private System.Windows.Forms.Label lblLoTrinh;
        private System.Windows.Forms.ComboBox cboTenLoTrinh;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblHanhKhach;
        private System.Windows.Forms.ComboBox cboHanhKhach;
        private System.Windows.Forms.Panel panel1;
    }
}