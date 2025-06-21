
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyMayBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyMayBay));
            this.dataGridViewDanhSachMayBay = new System.Windows.Forms.DataGridView();
            this.lblMamaybay = new System.Windows.Forms.Label();
            this.lblTenmaybay = new System.Windows.Forms.Label();
            this.lblSucchua = new System.Windows.Forms.Label();
            this.txtTenmaybay = new System.Windows.Forms.TextBox();
            this.txtSucchua = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMamaybayIP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachMayBay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachMayBay
            // 
            this.dataGridViewDanhSachMayBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachMayBay.Location = new System.Drawing.Point(579, 12);
            this.dataGridViewDanhSachMayBay.Name = "dataGridViewDanhSachMayBay";
            this.dataGridViewDanhSachMayBay.RowHeadersWidth = 51;
            this.dataGridViewDanhSachMayBay.RowTemplate.Height = 24;
            this.dataGridViewDanhSachMayBay.Size = new System.Drawing.Size(459, 480);
            this.dataGridViewDanhSachMayBay.TabIndex = 0;
            this.dataGridViewDanhSachMayBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachMayBay_CellClick);
            // 
            // lblMamaybay
            // 
            this.lblMamaybay.AutoSize = true;
            this.lblMamaybay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMamaybay.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMamaybay.Location = new System.Drawing.Point(18, 46);
            this.lblMamaybay.Name = "lblMamaybay";
            this.lblMamaybay.Size = new System.Drawing.Size(172, 35);
            this.lblMamaybay.TabIndex = 1;
            this.lblMamaybay.Text = "Mã máy bay";
            // 
            // lblTenmaybay
            // 
            this.lblTenmaybay.AutoSize = true;
            this.lblTenmaybay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenmaybay.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTenmaybay.Location = new System.Drawing.Point(12, 105);
            this.lblTenmaybay.Name = "lblTenmaybay";
            this.lblTenmaybay.Size = new System.Drawing.Size(178, 35);
            this.lblTenmaybay.TabIndex = 2;
            this.lblTenmaybay.Text = "Tên máy bay";
            // 
            // lblSucchua
            // 
            this.lblSucchua.AutoSize = true;
            this.lblSucchua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucchua.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSucchua.Location = new System.Drawing.Point(12, 172);
            this.lblSucchua.Name = "lblSucchua";
            this.lblSucchua.Size = new System.Drawing.Size(132, 35);
            this.lblSucchua.TabIndex = 3;
            this.lblSucchua.Text = "Sức chứa";
            this.lblSucchua.Click += new System.EventHandler(this.lblSucchua_Click);
            // 
            // txtTenmaybay
            // 
            this.txtTenmaybay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenmaybay.Location = new System.Drawing.Point(227, 105);
            this.txtTenmaybay.Name = "txtTenmaybay";
            this.txtTenmaybay.Size = new System.Drawing.Size(299, 42);
            this.txtTenmaybay.TabIndex = 5;
            // 
            // txtSucchua
            // 
            this.txtSucchua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucchua.Location = new System.Drawing.Point(227, 172);
            this.txtSucchua.Name = "txtSucchua";
            this.txtSucchua.Size = new System.Drawing.Size(299, 42);
            this.txtSucchua.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Navy;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1044, 436);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(176, 55);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Navy;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(272, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(211, 55);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.Navy;
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.Location = new System.Drawing.Point(272, 92);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(211, 55);
            this.btnLammoi.TabIndex = 22;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Navy;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(12, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(211, 55);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.GhostWhite;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Navy;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(12, 92);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(211, 55);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMamaybayIP
            // 
            this.lblMamaybayIP.AutoSize = true;
            this.lblMamaybayIP.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMamaybayIP.Location = new System.Drawing.Point(282, 46);
            this.lblMamaybayIP.Name = "lblMamaybayIP";
            this.lblMamaybayIP.Size = new System.Drawing.Size(182, 35);
            this.lblMamaybayIP.TabIndex = 25;
            this.lblMamaybayIP.Text = "[MaMayBay]";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSucchua);
            this.panel1.Controls.Add(this.lblMamaybay);
            this.panel1.Controls.Add(this.lblTenmaybay);
            this.panel1.Controls.Add(this.lblSucchua);
            this.panel1.Controls.Add(this.txtTenmaybay);
            this.panel1.Controls.Add(this.lblMamaybayIP);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 255);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.btnLammoi);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(16, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 218);
            this.panel2.TabIndex = 27;
            // 
            // frmQuanLyMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1232, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridViewDanhSachMayBay);
            this.Name = "frmQuanLyMayBay";
            this.Text = "frmQuanLyMayBay";
            this.Load += new System.EventHandler(this.frmQuanLyMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachMayBay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachMayBay;
        private System.Windows.Forms.Label lblMamaybay;
        private System.Windows.Forms.Label lblTenmaybay;
        private System.Windows.Forms.Label lblSucchua;
        private System.Windows.Forms.TextBox txtTenmaybay;
        private System.Windows.Forms.TextBox txtSucchua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMamaybayIP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}