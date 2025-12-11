using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class UC_TaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle, lblHoTen, lblEmail, lblPhone, lblNgaySinh, lblGioiTinh, lblStatus;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2Button btnChangeAvatar, btnLuu, btnDoiMatKhau, btnXacNhanMK;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen, txtEmail, txtPhone, txtMKCu, txtMKMoi, txtNhapLaiMK;
        private Guna.UI2.WinForms.Guna2Panel panelDoiMK;
        private Guna2TextBox txtNgaySinh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnChangeAvatar = new Guna.UI2.WinForms.Guna2Button();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelDoiMK = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMKCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMKMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNhapLaiMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXacNhanMK = new Guna.UI2.WinForms.Guna2Button();
            this.lblNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNgaySinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGioiTinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelDoiMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderRadius = 20;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.picAvatar);
            this.panelMain.Controls.Add(this.btnChangeAvatar);
            this.panelMain.Controls.Add(this.txtHoTen);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.txtPhone);
            this.panelMain.Controls.Add(this.btnLuu);
            this.panelMain.Controls.Add(this.btnDoiMatKhau);
            this.panelMain.Controls.Add(this.lblStatus);
            this.panelMain.Controls.Add(this.panelDoiMK);
            this.panelMain.Controls.Add(this.lblNgaySinh);
            this.panelMain.Controls.Add(this.txtNgaySinh);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.ShadowDecoration.Enabled = true;
            this.panelMain.Size = new System.Drawing.Size(650, 550);
            this.panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin tài khoản";
            // 
            // picAvatar
            // 
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(40, 80);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(150, 150);
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.BorderRadius = 10;
            this.btnChangeAvatar.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChangeAvatar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangeAvatar.ForeColor = System.Drawing.Color.White;
            this.btnChangeAvatar.Location = new System.Drawing.Point(60, 240);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(180, 45);
            this.btnChangeAvatar.TabIndex = 2;
            this.btnChangeAvatar.Text = "Đổi ảnh";
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 10;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.Location = new System.Drawing.Point(320, 80);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(250, 30);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(320, 120);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(250, 30);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(320, 160);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(250, 30);
            this.txtPhone.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 15;
            this.btnLuu.FillColor = System.Drawing.Color.LimeGreen;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(220, 290);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 40);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu thông tin";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BorderRadius = 15;
            this.btnDoiMatKhau.FillColor = System.Drawing.Color.Orange;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(420, 290);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(150, 40);
            this.btnDoiMatKhau.TabIndex = 9;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(220, 340);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(3, 2);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = null;
            // 
            // panelDoiMK
            // 
            this.panelDoiMK.BackColor = System.Drawing.Color.Transparent;
            this.panelDoiMK.BorderRadius = 15;
            this.panelDoiMK.Controls.Add(this.txtMKCu);
            this.panelDoiMK.Controls.Add(this.txtMKMoi);
            this.panelDoiMK.Controls.Add(this.txtNhapLaiMK);
            this.panelDoiMK.Controls.Add(this.btnXacNhanMK);
            this.panelDoiMK.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelDoiMK.Location = new System.Drawing.Point(220, 370);
            this.panelDoiMK.Name = "panelDoiMK";
            this.panelDoiMK.ShadowDecoration.Enabled = true;
            this.panelDoiMK.Size = new System.Drawing.Size(350, 180);
            this.panelDoiMK.TabIndex = 11;
            this.panelDoiMK.Visible = false;
            // 
            // txtMKCu
            // 
            this.txtMKCu.BorderRadius = 10;
            this.txtMKCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKCu.DefaultText = "";
            this.txtMKCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMKCu.Location = new System.Drawing.Point(20, 20);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PlaceholderText = "Mật khẩu cũ";
            this.txtMKCu.SelectedText = "";
            this.txtMKCu.Size = new System.Drawing.Size(300, 30);
            this.txtMKCu.TabIndex = 0;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.BorderRadius = 10;
            this.txtMKMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKMoi.DefaultText = "";
            this.txtMKMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMKMoi.Location = new System.Drawing.Point(20, 60);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PlaceholderText = "Mật khẩu mới";
            this.txtMKMoi.SelectedText = "";
            this.txtMKMoi.Size = new System.Drawing.Size(300, 30);
            this.txtMKMoi.TabIndex = 1;
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.BorderRadius = 10;
            this.txtNhapLaiMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLaiMK.DefaultText = "";
            this.txtNhapLaiMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhapLaiMK.Location = new System.Drawing.Point(20, 100);
            this.txtNhapLaiMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.PlaceholderText = "Nhập lại mật khẩu";
            this.txtNhapLaiMK.SelectedText = "";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(300, 30);
            this.txtNhapLaiMK.TabIndex = 2;
            // 
            // btnXacNhanMK
            // 
            this.btnXacNhanMK.BorderRadius = 15;
            this.btnXacNhanMK.FillColor = System.Drawing.Color.MediumPurple;
            this.btnXacNhanMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXacNhanMK.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanMK.Location = new System.Drawing.Point(20, 140);
            this.btnXacNhanMK.Name = "btnXacNhanMK";
            this.btnXacNhanMK.Size = new System.Drawing.Size(300, 30);
            this.btnXacNhanMK.TabIndex = 3;
            this.btnXacNhanMK.Text = "Xác nhận";
            this.btnXacNhanMK.Click += new System.EventHandler(this.btnXacNhanMK_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Location = new System.Drawing.Point(220, 200);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(76, 22);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.BorderRadius = 10;
            this.txtNgaySinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgaySinh.DefaultText = "";
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgaySinh.Location = new System.Drawing.Point(320, 200);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.PlaceholderText = "dd/MM/yyyy";
            this.txtNgaySinh.SelectedText = "";
            this.txtNgaySinh.Size = new System.Drawing.Size(250, 30);
            this.txtNgaySinh.TabIndex = 12;
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Location = new System.Drawing.Point(220, 80);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(55, 22);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(220, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(220, 160);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(39, 22);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "SĐT:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Location = new System.Drawing.Point(220, 240);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(65, 22);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // UC_TaiKhoan
            // 
            this.Controls.Add(this.panelMain);
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(650, 550);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelDoiMK.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
