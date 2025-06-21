namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmSaoLuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaoLuu));
            this.btnSaoLuuCSDL = new System.Windows.Forms.Button();
            this.btnKhoiPhucCSDL = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaoLuuCSDL
            // 
            this.btnSaoLuuCSDL.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSaoLuuCSDL.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoLuuCSDL.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnSaoLuuCSDL.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoLuuCSDL.Image")));
            this.btnSaoLuuCSDL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaoLuuCSDL.Location = new System.Drawing.Point(20, 25);
            this.btnSaoLuuCSDL.Name = "btnSaoLuuCSDL";
            this.btnSaoLuuCSDL.Size = new System.Drawing.Size(367, 166);
            this.btnSaoLuuCSDL.TabIndex = 0;
            this.btnSaoLuuCSDL.Text = "BACKUP";
            this.btnSaoLuuCSDL.UseVisualStyleBackColor = false;
            this.btnSaoLuuCSDL.Click += new System.EventHandler(this.btnSaoLuuCSDL_Click);
            // 
            // btnKhoiPhucCSDL
            // 
            this.btnKhoiPhucCSDL.BackColor = System.Drawing.Color.GhostWhite;
            this.btnKhoiPhucCSDL.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhucCSDL.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnKhoiPhucCSDL.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoiPhucCSDL.Image")));
            this.btnKhoiPhucCSDL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhoiPhucCSDL.Location = new System.Drawing.Point(20, 197);
            this.btnKhoiPhucCSDL.Name = "btnKhoiPhucCSDL";
            this.btnKhoiPhucCSDL.Size = new System.Drawing.Size(367, 166);
            this.btnKhoiPhucCSDL.TabIndex = 1;
            this.btnKhoiPhucCSDL.Text = "RESTORE";
            this.btnKhoiPhucCSDL.UseVisualStyleBackColor = false;
            this.btnKhoiPhucCSDL.Click += new System.EventHandler(this.btnKhoiPhucCSDL_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoiPhucCSDL);
            this.panel1.Controls.Add(this.btnSaoLuuCSDL);
            this.panel1.Location = new System.Drawing.Point(45, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 378);
            this.panel1.TabIndex = 2;
            // 
            // frmSaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmSaoLuu";
            this.Text = "Sao Lưu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaoLuuCSDL;
        private System.Windows.Forms.Button btnKhoiPhucCSDL;
        private System.Windows.Forms.Panel panel1;
    }
}