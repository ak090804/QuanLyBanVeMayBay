namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.dataGridViewThongKeDuLieu = new System.Windows.Forms.DataGridView();
            this.cboThongKe = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeDuLieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewThongKeDuLieu
            // 
            this.dataGridViewThongKeDuLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThongKeDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKeDuLieu.Location = new System.Drawing.Point(12, 252);
            this.dataGridViewThongKeDuLieu.Name = "dataGridViewThongKeDuLieu";
            this.dataGridViewThongKeDuLieu.RowHeadersWidth = 51;
            this.dataGridViewThongKeDuLieu.RowTemplate.Height = 24;
            this.dataGridViewThongKeDuLieu.Size = new System.Drawing.Size(863, 248);
            this.dataGridViewThongKeDuLieu.TabIndex = 0;
            // 
            // cboThongKe
            // 
            this.cboThongKe.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThongKe.FormattingEnabled = true;
            this.cboThongKe.Items.AddRange(new object[] {
            "Chuyến bay được bay nhiều nhất",
            "Lộ trình được bay nhiều nhất",
            "Khách hàng mua vé nhiều nhất",
            "Hãng hàng không được bay nhiều nhất",
            "Máy bay được sử dụng để bay nhiều nhất"});
            this.cboThongKe.Location = new System.Drawing.Point(14, 82);
            this.cboThongKe.Name = "cboThongKe";
            this.cboThongKe.Size = new System.Drawing.Size(531, 45);
            this.cboThongKe.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.Location = new System.Drawing.Point(565, 60);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(315, 88);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê dữ liệu";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.cboThongKe);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 213);
            this.panel1.TabIndex = 3;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(907, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewThongKeDuLieu);
            this.Name = "frmThongKe";
            this.Text = "Thống Kê";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeDuLieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewThongKeDuLieu;
		private System.Windows.Forms.ComboBox cboThongKe;
		private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel1;
    }
}