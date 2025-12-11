namespace MovieTicketApp
{
    partial class Boss
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoanhThuDoAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoanhThuPhim = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.panelMenu.Controls.Add(this.btnThoat);
            this.panelMenu.Controls.Add(this.btnQLTaiKhoan);
            this.panelMenu.Controls.Add(this.btnDoanhThuDoAn);
            this.panelMenu.Controls.Add(this.btnDoanhThuPhim);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 900);
            this.panelMenu.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BorderRadius = 8;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(0, 855);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ShadowDecoration.Enabled = true;
            this.btnThoat.Size = new System.Drawing.Size(220, 45);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.BorderRadius = 8;
            this.btnQLTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTaiKhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btnQLTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnQLTaiKhoan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(0, 293);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(220, 45);
            this.btnQLTaiKhoan.TabIndex = 6;
            this.btnQLTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // btnDoanhThuDoAn
            // 
            this.btnDoanhThuDoAn.BorderRadius = 8;
            this.btnDoanhThuDoAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhThuDoAn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btnDoanhThuDoAn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoanhThuDoAn.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThuDoAn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnDoanhThuDoAn.Location = new System.Drawing.Point(0, 248);
            this.btnDoanhThuDoAn.Name = "btnDoanhThuDoAn";
            this.btnDoanhThuDoAn.Size = new System.Drawing.Size(220, 45);
            this.btnDoanhThuDoAn.TabIndex = 5;
            this.btnDoanhThuDoAn.Text = "Doanh thu đồ ăn";
            this.btnDoanhThuDoAn.Click += new System.EventHandler(this.btnDoanhThuDoAn_Click);
            // 
            // btnDoanhThuPhim
            // 
            this.btnDoanhThuPhim.BorderRadius = 8;
            this.btnDoanhThuPhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhThuPhim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btnDoanhThuPhim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoanhThuPhim.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThuPhim.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnDoanhThuPhim.Location = new System.Drawing.Point(0, 203);
            this.btnDoanhThuPhim.Name = "btnDoanhThuPhim";
            this.btnDoanhThuPhim.Size = new System.Drawing.Size(220, 45);
            this.btnDoanhThuPhim.TabIndex = 4;
            this.btnDoanhThuPhim.Text = "Doanh thu phim";
            this.btnDoanhThuPhim.Click += new System.EventHandler(this.btnDoanhThuPhim_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BorderRadius = 8;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnTrangChu.Location = new System.Drawing.Point(0, 158);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(220, 45);
            this.btnTrangChu.TabIndex = 3;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 120);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BOSS CONTROL";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(220, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1180, 900);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // Boss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Boss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boss Dashboard";
            this.Load += new System.EventHandler(this.Boss_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnDoanhThuPhim;
        private Guna.UI2.WinForms.Guna2Button btnDoanhThuDoAn;
        private Guna.UI2.WinForms.Guna2Button btnQLTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
    }
}
