using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class UC_QLTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Guna2Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        // Main content
        private Guna2Panel panelMain;
        private Guna2Panel panelCard;

        // Avatar section
        private Guna2CirclePictureBox picAvatar;
        private Label lblAdminName;
        private Label lblAdminRole;

        // Form fields
        private Guna2TextBox txtEmail;
        private Guna2TextBox txtHoTen;
        private Guna2TextBox txtPhone;
        private Guna2TextBox txtNgaySinh;

        // Buttons
        private Guna2Button btnLuu;
        private Guna2Button btnDoiMatKhau;
        private Guna2Button btnDangXuat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new Guna2Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.panelMain = new Guna2Panel();
            this.panelCard = new Guna2Panel();
            this.picAvatar = new Guna2CirclePictureBox();
            this.lblAdminName = new Label();
            this.lblAdminRole = new Label();
            this.txtEmail = new Guna2TextBox();
            this.txtHoTen = new Guna2TextBox();
            this.txtPhone = new Guna2TextBox();
            this.txtNgaySinh = new Guna2TextBox();
            this.btnLuu = new Guna2Button();
            this.btnDoiMatKhau = new Guna2Button();
            this.btnDangXuat = new Guna2Button();

            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 100;
            this.panelHeader.FillColor = System.Drawing.Color.White;
            this.panelHeader.ShadowDecoration.Enabled = true;
            this.panelHeader.ShadowDecoration.Depth = 20;
            this.panelHeader.ShadowDecoration.Color = System.Drawing.Color.FromArgb(30, 0, 0, 0);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);

            // lblTitle
            this.lblTitle.Text = "Quản Lý Tài Khoản";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 35, 48);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 22);

            // lblSubtitle
            this.lblSubtitle.Text = "Quản lý thông tin tài khoản quản trị viên";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 140);
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(32, 62);

            // panelMain
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.panelMain.Padding = new Padding(30);
            this.panelMain.Controls.Add(this.panelCard);

            // panelCard - Main card container
            this.panelCard.Size = new System.Drawing.Size(450, 570);
            this.panelCard.Anchor = AnchorStyles.None;
            this.panelCard.FillColor = System.Drawing.Color.White;
            this.panelCard.BorderRadius = 16;
            this.panelCard.ShadowDecoration.Enabled = true;
            this.panelCard.ShadowDecoration.Depth = 25;
            this.panelCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(30, 0, 0, 0);

            // picAvatar
            this.picAvatar.Size = new System.Drawing.Size(70, 70);
            this.picAvatar.Location = new System.Drawing.Point(190, 15);
            this.picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            this.picAvatar.FillColor = System.Drawing.Color.FromArgb(55, 90, 140);
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.panelCard.Controls.Add(this.picAvatar);

            // lblAdminName
            this.lblAdminName.Text = "Admin";
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(30, 35, 48);
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(190, 90);
            this.panelCard.Controls.Add(this.lblAdminName);

            // lblAdminRole
            this.lblAdminRole.Text = "Quản trị viên";
            this.lblAdminRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAdminRole.ForeColor = System.Drawing.Color.FromArgb(120, 130, 140);
            this.lblAdminRole.AutoSize = true;
            this.lblAdminRole.Location = new System.Drawing.Point(180, 115);
            this.panelCard.Controls.Add(this.lblAdminRole);

            // txtEmail
            this.txtEmail.Size = new System.Drawing.Size(370, 38);
            this.txtEmail.Location = new System.Drawing.Point(40, 145);
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(220, 225, 230);
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            this.txtEmail.ReadOnly = true;
            this.panelCard.Controls.Add(this.txtEmail);

            // txtHoTen
            this.txtHoTen.Size = new System.Drawing.Size(370, 38);
            this.txtHoTen.Location = new System.Drawing.Point(40, 195);
            this.txtHoTen.BorderRadius = 10;
            this.txtHoTen.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtHoTen.BorderColor = System.Drawing.Color.FromArgb(220, 225, 230);
            this.txtHoTen.BorderThickness = 1;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(50, 50, 60);
            this.txtHoTen.PlaceholderText = "Họ và tên";
            this.txtHoTen.PlaceholderForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            this.panelCard.Controls.Add(this.txtHoTen);

            // txtPhone
            this.txtPhone.Size = new System.Drawing.Size(370, 38);
            this.txtPhone.Location = new System.Drawing.Point(40, 245);
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(220, 225, 230);
            this.txtPhone.BorderThickness = 1;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(50, 50, 60);
            this.txtPhone.PlaceholderText = "Số điện thoại";
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            this.panelCard.Controls.Add(this.txtPhone);

            // txtNgaySinh
            this.txtNgaySinh.Size = new System.Drawing.Size(370, 38);
            this.txtNgaySinh.Location = new System.Drawing.Point(40, 295);
            this.txtNgaySinh.BorderRadius = 10;
            this.txtNgaySinh.FillColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtNgaySinh.BorderColor = System.Drawing.Color.FromArgb(220, 225, 230);
            this.txtNgaySinh.BorderThickness = 1;
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNgaySinh.ForeColor = System.Drawing.Color.FromArgb(50, 50, 60);
            this.txtNgaySinh.PlaceholderText = "Ngày sinh (dd/MM/yyyy)";
            this.txtNgaySinh.PlaceholderForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            this.panelCard.Controls.Add(this.txtNgaySinh);

            // btnLuu
            this.btnLuu.Size = new System.Drawing.Size(175, 40);
            this.btnLuu.Location = new System.Drawing.Point(40, 400);
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Text = "Lưu thông tin";
            this.btnLuu.Animated = true;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(50, 190, 85);
            this.btnLuu.ShadowDecoration.Enabled = true;
            this.btnLuu.ShadowDecoration.Depth = 8;
            this.btnLuu.ShadowDecoration.Color = System.Drawing.Color.FromArgb(40, 40, 167, 69);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.panelCard.Controls.Add(this.btnLuu);

            // btnDoiMatKhau
            this.btnDoiMatKhau.Size = new System.Drawing.Size(175, 40);
            this.btnDoiMatKhau.Location = new System.Drawing.Point(235, 400);
            this.btnDoiMatKhau.BorderRadius = 10;
            this.btnDoiMatKhau.FillColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Animated = true;
            this.btnDoiMatKhau.HoverState.FillColor = System.Drawing.Color.FromArgb(255, 210, 60);
            this.btnDoiMatKhau.ShadowDecoration.Enabled = true;
            this.btnDoiMatKhau.ShadowDecoration.Depth = 8;
            this.btnDoiMatKhau.ShadowDecoration.Color = System.Drawing.Color.FromArgb(40, 255, 193, 7);
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            this.panelCard.Controls.Add(this.btnDoiMatKhau);

            // btnDangXuat
            this.btnDangXuat.Size = new System.Drawing.Size(370, 40);
            this.btnDangXuat.Location = new System.Drawing.Point(40, 460);
            this.btnDangXuat.BorderRadius = 10;
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BorderColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDangXuat.BorderThickness = 2;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Animated = true;
            this.btnDangXuat.HoverState.FillColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDangXuat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            this.panelCard.Controls.Add(this.btnDangXuat);

            // UC_QLTaiKhoan
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "UC_QLTaiKhoan";
            this.Size = new System.Drawing.Size(1000, 750);
            this.Resize += new System.EventHandler(this.UC_QLTaiKhoan_Resize);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
