
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyGiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyGiamGia));
            this.lblCode = new System.Windows.Forms.Label();
            this.lblMucGiamGia = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachGiamGia = new System.Windows.Forms.DataGridView();
            this.cboCode = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboMucGiamGia = new System.Windows.Forms.ComboBox();
            this.lblMaGiamGia = new System.Windows.Forms.Label();
            this.lblMaGiamGiaIP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachGiamGia)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCode.Location = new System.Drawing.Point(18, 102);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(102, 37);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code:";
            // 
            // lblMucGiamGia
            // 
            this.lblMucGiamGia.AutoSize = true;
            this.lblMucGiamGia.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMucGiamGia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMucGiamGia.Location = new System.Drawing.Point(598, 98);
            this.lblMucGiamGia.Name = "lblMucGiamGia";
            this.lblMucGiamGia.Size = new System.Drawing.Size(222, 37);
            this.lblMucGiamGia.TabIndex = 2;
            this.lblMucGiamGia.Text = "Mức giảm giá:";
            // 
            // dataGridViewDanhSachGiamGia
            // 
            this.dataGridViewDanhSachGiamGia.AllowUserToAddRows = false;
            this.dataGridViewDanhSachGiamGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachGiamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachGiamGia.Location = new System.Drawing.Point(12, 297);
            this.dataGridViewDanhSachGiamGia.Name = "dataGridViewDanhSachGiamGia";
            this.dataGridViewDanhSachGiamGia.RowHeadersWidth = 51;
            this.dataGridViewDanhSachGiamGia.RowTemplate.Height = 24;
            this.dataGridViewDanhSachGiamGia.Size = new System.Drawing.Size(1182, 207);
            this.dataGridViewDanhSachGiamGia.TabIndex = 5;
            this.dataGridViewDanhSachGiamGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachGiamGia_CellClick);
            // 
            // cboCode
            // 
            this.cboCode.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCode.FormattingEnabled = true;
            this.cboCode.Location = new System.Drawing.Point(213, 95);
            this.cboCode.Name = "cboCode";
            this.cboCode.Size = new System.Drawing.Size(332, 45);
            this.cboCode.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(983, -2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(187, 86);
            this.btnThoat.TabIndex = 29;
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
            this.btnSua.Location = new System.Drawing.Point(479, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(202, 77);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.Location = new System.Drawing.Point(725, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(202, 77);
            this.btnLammoi.TabIndex = 27;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(14, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(202, 77);
            this.btnThem.TabIndex = 26;
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
            this.btnXoa.Location = new System.Drawing.Point(256, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(202, 77);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboMucGiamGia
            // 
            this.cboMucGiamGia.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMucGiamGia.FormattingEnabled = true;
            this.cboMucGiamGia.Location = new System.Drawing.Point(851, 95);
            this.cboMucGiamGia.Name = "cboMucGiamGia";
            this.cboMucGiamGia.Size = new System.Drawing.Size(307, 45);
            this.cboMucGiamGia.TabIndex = 7;
            // 
            // lblMaGiamGia
            // 
            this.lblMaGiamGia.AutoSize = true;
            this.lblMaGiamGia.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiamGia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMaGiamGia.Location = new System.Drawing.Point(18, 6);
            this.lblMaGiamGia.Name = "lblMaGiamGia";
            this.lblMaGiamGia.Size = new System.Drawing.Size(203, 37);
            this.lblMaGiamGia.TabIndex = 30;
            this.lblMaGiamGia.Text = "Mã giảm giá:";
            // 
            // lblMaGiamGiaIP
            // 
            this.lblMaGiamGiaIP.AutoSize = true;
            this.lblMaGiamGiaIP.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiamGiaIP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaGiamGiaIP.Location = new System.Drawing.Point(269, 6);
            this.lblMaGiamGiaIP.Name = "lblMaGiamGiaIP";
            this.lblMaGiamGiaIP.Size = new System.Drawing.Size(214, 37);
            this.lblMaGiamGiaIP.TabIndex = 31;
            this.lblMaGiamGiaIP.Text = "[MaGiamGia]";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboMucGiamGia);
            this.panel1.Controls.Add(this.lblMaGiamGiaIP);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.lblMaGiamGia);
            this.panel1.Controls.Add(this.lblMucGiamGia);
            this.panel1.Controls.Add(this.cboCode);
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 189);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLammoi);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(12, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 93);
            this.panel2.TabIndex = 33;
            // 
            // frmQuanLyGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1206, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDanhSachGiamGia);
            this.Name = "frmQuanLyGiamGia";
            this.Text = "frmQuanLyGiamGia";
            this.Load += new System.EventHandler(this.frmQuanLyGiamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachGiamGia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblMucGiamGia;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachGiamGia;
        private System.Windows.Forms.ComboBox cboCode;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboMucGiamGia;
        private System.Windows.Forms.Label lblMaGiamGia;
        private System.Windows.Forms.Label lblMaGiamGiaIP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}