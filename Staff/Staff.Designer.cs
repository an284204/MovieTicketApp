namespace MovieTicketApp
{
    partial class Staff
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnTinNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatVe = new Guna.UI2.WinForms.Guna2Button();
            this.btnKiemTraDoAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnKiemTraVe = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.btnTaiKhoan);
            this.panelMenu.Controls.Add(this.btnTinNhan);
            this.panelMenu.Controls.Add(this.btnDoAn);
            this.panelMenu.Controls.Add(this.btnDatVe);
            this.panelMenu.Controls.Add(this.btnKiemTraDoAn);
            this.panelMenu.Controls.Add(this.btnKiemTraVe);
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Controls.Add(this.btnThoat);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 700);
            this.panelMenu.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(67)))));
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(50, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Enabled = true;
            this.picLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picLogo.Size = new System.Drawing.Size(80, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 115);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 35);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Staff Panel";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKiemTraVe
            // 
            this.btnKiemTraVe.Animated = true;
            this.btnKiemTraVe.BorderRadius = 10;
            this.btnKiemTraVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnKiemTraVe.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnKiemTraVe.ForeColor = System.Drawing.Color.White;
            this.btnKiemTraVe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnKiemTraVe.Location = new System.Drawing.Point(15, 170);
            this.btnKiemTraVe.Name = "btnKiemTraVe";
            this.btnKiemTraVe.Size = new System.Drawing.Size(150, 50);
            this.btnKiemTraVe.TabIndex = 3;
            this.btnKiemTraVe.Text = "Kiểm tra vé";
            this.btnKiemTraVe.Click += new System.EventHandler(this.btnKiemTraVe_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.Animated = true;
            this.btnDatVe.BorderRadius = 10;
            this.btnDatVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnDatVe.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnDatVe.ForeColor = System.Drawing.Color.White;
            this.btnDatVe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnDatVe.Location = new System.Drawing.Point(15, 300);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(150, 50);
            this.btnDatVe.TabIndex = 2;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnKiemTraDoAn
            // 
            this.btnKiemTraDoAn.Animated = true;
            this.btnKiemTraDoAn.BorderRadius = 10;
            this.btnKiemTraDoAn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnKiemTraDoAn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnKiemTraDoAn.ForeColor = System.Drawing.Color.White;
            this.btnKiemTraDoAn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnKiemTraDoAn.Location = new System.Drawing.Point(15, 235);
            this.btnKiemTraDoAn.Name = "btnKiemTraDoAn";
            this.btnKiemTraDoAn.Size = new System.Drawing.Size(150, 50);
            this.btnKiemTraDoAn.TabIndex = 8;
            this.btnKiemTraDoAn.Text = "Kiểm tra đồ ăn";
            this.btnKiemTraDoAn.Click += new System.EventHandler(this.btnKiemTraDoAn_Click);
            // 
            // btnDoAn
            // 
            this.btnDoAn.Animated = true;
            this.btnDoAn.BorderRadius = 10;
            this.btnDoAn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnDoAn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnDoAn.ForeColor = System.Drawing.Color.White;
            this.btnDoAn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnDoAn.Location = new System.Drawing.Point(15, 365);
            this.btnDoAn.Name = "btnDoAn";
            this.btnDoAn.Size = new System.Drawing.Size(150, 50);
            this.btnDoAn.TabIndex = 7;
            this.btnDoAn.Text = "Đồ ăn";
            this.btnDoAn.Click += new System.EventHandler(this.btnDoAn_Click);
            // 
            // btnTinNhan
            // 
            this.btnTinNhan.Animated = true;
            this.btnTinNhan.BorderRadius = 10;
            this.btnTinNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnTinNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnTinNhan.ForeColor = System.Drawing.Color.White;
            this.btnTinNhan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnTinNhan.Location = new System.Drawing.Point(15, 430);
            this.btnTinNhan.Name = "btnTinNhan";
            this.btnTinNhan.Size = new System.Drawing.Size(150, 50);
            this.btnTinNhan.TabIndex = 1;
            this.btnTinNhan.Text = "Tin Nhắn";
            this.btnTinNhan.Click += new System.EventHandler(this.btnTinNhan_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Animated = true;
            this.btnTaiKhoan.BorderRadius = 10;
            this.btnTaiKhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnTaiKhoan.Location = new System.Drawing.Point(15, 495);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(150, 50);
            this.btnTaiKhoan.TabIndex = 6;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Animated = true;
            this.btnThoat.BorderRadius = 10;
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnThoat.Location = new System.Drawing.Point(15, 630);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 50);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panelMain.Location = new System.Drawing.Point(180, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(920, 700);
            this.panelMain.TabIndex = 0;
            // 
            // Staff
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Panel";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnTinNhan;
        private Guna.UI2.WinForms.Guna2Button btnDatVe;
        private Guna.UI2.WinForms.Guna2Button btnDoAn;
        private Guna.UI2.WinForms.Guna2Button btnKiemTraDoAn;
        private Guna.UI2.WinForms.Guna2Button btnKiemTraVe;
        private Guna.UI2.WinForms.Guna2Button btnTaiKhoan;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picLogo;
    }
}
