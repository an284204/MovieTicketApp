namespace MovieTicketApp
{
    partial class FormMainAdmin
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
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panelMenuItems = new Guna.UI2.WinForms.Guna2Panel();
            this.btnQLTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatChieu = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLDoAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLPhim = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            
            this.panelSidebar.SuspendLayout();
            this.panelMenuItems.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            
            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(24, 29, 39);
            this.panelSidebar.Controls.Add(this.btnThoat);
            this.panelSidebar.Controls.Add(this.panelMenuItems);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.FillColor = System.Drawing.Color.FromArgb(24, 29, 39);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 800);
            this.panelSidebar.TabIndex = 0;
            
            // panelLogo
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.lblSubtitle);
            this.panelLogo.Controls.Add(this.lblTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.FillColor = System.Drawing.Color.Transparent;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 32);
            this.lblTitle.Text = "CineMax";
            
            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(140, 140, 160);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 60);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Admin Dashboard";
            
            // panelMenuItems
            this.panelMenuItems.BackColor = System.Drawing.Color.Transparent;
            this.panelMenuItems.Controls.Add(this.btnQLTaiKhoan);
            this.panelMenuItems.Controls.Add(this.btnXuatChieu);
            this.panelMenuItems.Controls.Add(this.btnQLDoAn);
            this.panelMenuItems.Controls.Add(this.btnQLPhim);
            this.panelMenuItems.Controls.Add(this.btnTrangChu);
            this.panelMenuItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuItems.FillColor = System.Drawing.Color.Transparent;
            this.panelMenuItems.Location = new System.Drawing.Point(0, 100);
            this.panelMenuItems.Name = "panelMenuItems";
            this.panelMenuItems.Size = new System.Drawing.Size(250, 320);
            
            // btnTrangChu
            this.btnTrangChu.Animated = true;
            this.btnTrangChu.BorderRadius = 10;
            this.btnTrangChu.FillColor = System.Drawing.Color.FromArgb(55, 90, 140);
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.HoverState.FillColor = System.Drawing.Color.FromArgb(65, 100, 150);
            this.btnTrangChu.Location = new System.Drawing.Point(15, 15);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(220, 50);
            this.btnTrangChu.Text = "    Trang chủ";
            this.btnTrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            
            // btnQLPhim
            this.btnQLPhim.Animated = true;
            this.btnQLPhim.BorderRadius = 10;
            this.btnQLPhim.FillColor = System.Drawing.Color.FromArgb(35, 40, 52);
            this.btnQLPhim.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnQLPhim.ForeColor = System.Drawing.Color.FromArgb(180, 180, 195);
            this.btnQLPhim.HoverState.FillColor = System.Drawing.Color.FromArgb(55, 90, 140);
            this.btnQLPhim.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnQLPhim.Location = new System.Drawing.Point(15, 75);
            this.btnQLPhim.Name = "btnQLPhim";
            this.btnQLPhim.Size = new System.Drawing.Size(220, 50);
            this.btnQLPhim.Text = "    Quản lý phim";
            this.btnQLPhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLPhim.Click += new System.EventHandler(this.btnQLPhim_Click);
            
            // btnQLDoAn
            this.btnQLDoAn.Animated = true;
            this.btnQLDoAn.BorderRadius = 10;
            this.btnQLDoAn.FillColor = System.Drawing.Color.FromArgb(35, 40, 52);
            this.btnQLDoAn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnQLDoAn.ForeColor = System.Drawing.Color.FromArgb(180, 180, 195);
            this.btnQLDoAn.HoverState.FillColor = System.Drawing.Color.FromArgb(55, 90, 140);
            this.btnQLDoAn.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnQLDoAn.Location = new System.Drawing.Point(15, 135);
            this.btnQLDoAn.Name = "btnQLDoAn";
            this.btnQLDoAn.Size = new System.Drawing.Size(220, 50);
            this.btnQLDoAn.Text = "    Quản lý đồ ăn";
            this.btnQLDoAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLDoAn.Click += new System.EventHandler(this.btnQLDoAn_Click);
            
            // btnXuatChieu
            this.btnXuatChieu.Animated = true;
            this.btnXuatChieu.BorderRadius = 10;
            this.btnXuatChieu.FillColor = System.Drawing.Color.FromArgb(35, 40, 52);
            this.btnXuatChieu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnXuatChieu.ForeColor = System.Drawing.Color.FromArgb(180, 180, 195);
            this.btnXuatChieu.HoverState.FillColor = System.Drawing.Color.FromArgb(55, 90, 140);
            this.btnXuatChieu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnXuatChieu.Location = new System.Drawing.Point(15, 195);
            this.btnXuatChieu.Name = "btnXuatChieu";
            this.btnXuatChieu.Size = new System.Drawing.Size(220, 50);
            this.btnXuatChieu.Text = "    Quản lý xuất chiếu";
            this.btnXuatChieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXuatChieu.Click += new System.EventHandler(this.btnQLPhong_Click);
            
            // btnQLTaiKhoan
            this.btnQLTaiKhoan.Animated = true;
            this.btnQLTaiKhoan.BorderRadius = 10;
            this.btnQLTaiKhoan.FillColor = System.Drawing.Color.FromArgb(35, 40, 52);
            this.btnQLTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnQLTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(180, 180, 195);
            this.btnQLTaiKhoan.HoverState.FillColor = System.Drawing.Color.FromArgb(55, 90, 140);
            this.btnQLTaiKhoan.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(15, 255);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(220, 50);
            this.btnQLTaiKhoan.Text = "    Quản lý tài khoản";
            this.btnQLTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            
            // btnThoat
            this.btnThoat.Animated = true;
            this.btnThoat.BorderColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnThoat.BorderRadius = 10;
            this.btnThoat.BorderThickness = 2;
            this.btnThoat.FillColor = System.Drawing.Color.Transparent;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnThoat.HoverState.BorderColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnThoat.HoverState.FillColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnThoat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(15, 735);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(220, 50);
            this.btnThoat.Text = "Đăng xuất";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            
            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 35, 48);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.btnMaximize);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(30, 35, 48);
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1050, 55);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            
            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(25, 16);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Text = "Xin chào, Quản lý!";
            
            // btnMinimize
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(255, 214, 90);
            this.btnMinimize.Location = new System.Drawing.Point(920, 15);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            
            // btnMaximize
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FillColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnMaximize.HoverState.FillColor = System.Drawing.Color.FromArgb(72, 199, 101);
            this.btnMaximize.Location = new System.Drawing.Point(955, 15);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            
            // btnClose
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(245, 90, 105);
            this.btnClose.Location = new System.Drawing.Point(990, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            
            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.panelMain.Location = new System.Drawing.Point(250, 55);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1050, 745);
            
            // FormMainAdmin
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel - CineMax";
            this.Load += new System.EventHandler(this.FormMainAdmin_Load);
            
            this.panelSidebar.ResumeLayout(false);
            this.panelMenuItems.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2Panel panelLogo;
        private Guna.UI2.WinForms.Guna2Panel panelMenuItems;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnQLPhim;
        private Guna.UI2.WinForms.Guna2Button btnQLDoAn;
        private Guna.UI2.WinForms.Guna2Button btnXuatChieu;
        private Guna.UI2.WinForms.Guna2Button btnQLTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnMaximize;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
    }
}
