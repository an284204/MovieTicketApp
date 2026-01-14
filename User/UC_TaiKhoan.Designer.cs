using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class UC_TaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen, txtEmail, txtPhone, txtNgaySinh;
        private Guna.UI2.WinForms.Guna2Button btnLuu, btnDoiMatKhau, btnDangXuat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNgaySinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderRadius = 18;
            this.panelMain.Controls.Add(this.lblSubtitle);
            this.panelMain.Controls.Add(this.btnDangXuat);
            this.panelMain.Controls.Add(this.btnDoiMatKhau);
            this.panelMain.Controls.Add(this.btnLuu);
            this.panelMain.Controls.Add(this.txtNgaySinh);
            this.panelMain.Controls.Add(this.txtPhone);
            this.panelMain.Controls.Add(this.txtHoTen);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(55, 90, 140);
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.ShadowDecoration.Enabled = true;
            this.panelMain.Size = new System.Drawing.Size(1200, 700);
            this.panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(420, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Thông tin tài khoản";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitle.Location = new System.Drawing.Point(440, 110);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(320, 30);
            this.lblSubtitle.TabIndex = 8;
            this.lblSubtitle.Text = "Quản lý thông tin cá nhân của bạn";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 12;
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(45, 45, 70);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(380, 180);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(440, 45);
            this.txtEmail.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 12;
            this.txtHoTen.FillColor = System.Drawing.Color.FromArgb(45, 45, 70);
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.ForeColor = System.Drawing.Color.White;
            this.txtHoTen.PlaceholderText = "Họ và tên";
            this.txtHoTen.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtHoTen.Location = new System.Drawing.Point(380, 240);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(440, 45);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 12;
            this.txtPhone.FillColor = System.Drawing.Color.FromArgb(45, 45, 70);
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.PlaceholderText = "Số điện thoại";
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPhone.Location = new System.Drawing.Point(380, 300);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(440, 45);
            this.txtPhone.TabIndex = 2;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.BorderRadius = 12;
            this.txtNgaySinh.FillColor = System.Drawing.Color.FromArgb(45, 45, 70);
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNgaySinh.ForeColor = System.Drawing.Color.White;
            this.txtNgaySinh.PlaceholderText = "Ngày sinh (dd/MM/yyyy)";
            this.txtNgaySinh.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNgaySinh.Location = new System.Drawing.Point(380, 360);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(440, 45);
            this.txtNgaySinh.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 12;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(380, 430);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(440, 45);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu thông tin";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BorderRadius = 12;
            this.btnDoiMatKhau.FillColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(380, 485);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(440, 45);
            this.btnDoiMatKhau.TabIndex = 5;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BorderRadius = 12;
            this.btnDangXuat.FillColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(380, 540);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(440, 45);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // UC_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(1200, 700);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
