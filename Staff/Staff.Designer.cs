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
            this.btnDatVe = new Guna.UI2.WinForms.Guna2Button();
            this.btnKiemTraVe = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BorderRadius = 15;
            this.panelMenu.Controls.Add(this.btnTaiKhoan);
            this.panelMenu.Controls.Add(this.btnTinNhan);
            this.panelMenu.Controls.Add(this.btnDatVe);
            this.panelMenu.Controls.Add(this.btnKiemTraVe);
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Controls.Add(this.btnThoat);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.ShadowDecoration.Depth = 10;
            this.panelMenu.ShadowDecoration.Enabled = true;
            this.panelMenu.Size = new System.Drawing.Size(200, 600);
            this.panelMenu.TabIndex = 1;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BorderRadius = 8;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 275);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(200, 45);
            this.btnTaiKhoan.TabIndex = 6;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnTinNhan
            // 
            this.btnTinNhan.BorderRadius = 8;
            this.btnTinNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTinNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.btnTinNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTinNhan.ForeColor = System.Drawing.Color.White;
            this.btnTinNhan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnTinNhan.Location = new System.Drawing.Point(0, 230);
            this.btnTinNhan.Name = "btnTinNhan";
            this.btnTinNhan.Size = new System.Drawing.Size(200, 45);
            this.btnTinNhan.TabIndex = 1;
            this.btnTinNhan.Text = "Tin Nhắn";
            this.btnTinNhan.Click += new System.EventHandler(this.btnTinNhan_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BorderRadius = 8;
            this.btnDatVe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.btnDatVe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDatVe.ForeColor = System.Drawing.Color.White;
            this.btnDatVe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnDatVe.Location = new System.Drawing.Point(0, 185);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(200, 45);
            this.btnDatVe.TabIndex = 2;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnKiemTraVe
            // 
            this.btnKiemTraVe.BorderRadius = 8;
            this.btnKiemTraVe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKiemTraVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.btnKiemTraVe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKiemTraVe.ForeColor = System.Drawing.Color.White;
            this.btnKiemTraVe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnKiemTraVe.Location = new System.Drawing.Point(0, 140);
            this.btnKiemTraVe.Name = "btnKiemTraVe";
            this.btnKiemTraVe.Size = new System.Drawing.Size(200, 45);
            this.btnKiemTraVe.TabIndex = 3;
            this.btnKiemTraVe.Text = "Kiểm tra vé";
            this.btnKiemTraVe.Click += new System.EventHandler(this.btnKiemTraVe_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 40);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Staff Panel";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BorderRadius = 15;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Enabled = true;
            this.picLogo.Size = new System.Drawing.Size(200, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BorderRadius = 8;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(0, 555);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(200, 45);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderRadius = 15;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.panelMain.ShadowDecoration.Depth = 10;
            this.panelMain.ShadowDecoration.Enabled = true;
            this.panelMain.Size = new System.Drawing.Size(800, 600);
            this.panelMain.TabIndex = 0;
            // 
            // Staff
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
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
        private Guna.UI2.WinForms.Guna2Button btnKiemTraVe;
        private Guna.UI2.WinForms.Guna2Button btnTaiKhoan;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
    }
}