namespace MovieTicketApp
{
    partial class ChangePasswordForm
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
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtXacNhanMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnToggleOld = new Guna.UI2.WinForms.Guna2Button();
            this.btnToggleNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnToggleConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderRadius = 18;
            this.panelMain.Controls.Add(this.btnToggleConfirm);
            this.panelMain.Controls.Add(this.btnToggleNew);
            this.panelMain.Controls.Add(this.btnToggleOld);
            this.panelMain.Controls.Add(this.lblSubtitle);
            this.panelMain.Controls.Add(this.btnHuy);
            this.panelMain.Controls.Add(this.btnXacNhan);
            this.panelMain.Controls.Add(this.txtXacNhanMatKhau);
            this.panelMain.Controls.Add(this.txtMatKhauMoi);
            this.panelMain.Controls.Add(this.txtMatKhauCu);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(55, 90, 140);
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.ShadowDecoration.Enabled = true;
            this.panelMain.Size = new System.Drawing.Size(520, 500);
            this.panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(130, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Đổi mật khẩu";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitle.Location = new System.Drawing.Point(90, 90);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(340, 30);
            this.lblSubtitle.TabIndex = 8;
            this.lblSubtitle.Text = "Vui lòng nhập mật khẩu cũ để xác nhận";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BorderRadius = 12;
            this.txtMatKhauCu.FillColor = System.Drawing.Color.FromArgb(45, 45, 70);
            this.txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauCu.ForeColor = System.Drawing.Color.White;
            this.txtMatKhauCu.PlaceholderText = "Mật khẩu cũ";
            this.txtMatKhauCu.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatKhauCu.PasswordChar = '●';
            this.txtMatKhauCu.Location = new System.Drawing.Point(40, 150);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(390, 45);
            this.txtMatKhauCu.TabIndex = 0;
            // 
            // btnToggleOld
            // 
            this.btnToggleOld.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleOld.BorderRadius = 8;
            this.btnToggleOld.FillColor = System.Drawing.Color.FromArgb(60, 60, 85);
            this.btnToggleOld.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnToggleOld.ForeColor = System.Drawing.Color.White;
            this.btnToggleOld.Location = new System.Drawing.Point(440, 150);
            this.btnToggleOld.Name = "btnToggleOld";
            this.btnToggleOld.Size = new System.Drawing.Size(40, 45);
            this.btnToggleOld.TabIndex = 7;
            this.btnToggleOld.Text = "👁";
            this.btnToggleOld.Click += new System.EventHandler(this.btnToggleOld_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BorderRadius = 12;
            this.txtMatKhauMoi.FillColor = System.Drawing.Color.FromArgb(45, 45, 70);
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.White;
            this.txtMatKhauMoi.PlaceholderText = "Mật khẩu mới";
            this.txtMatKhauMoi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatKhauMoi.PasswordChar = '●';
            this.txtMatKhauMoi.Location = new System.Drawing.Point(40, 210);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(390, 45);
            this.txtMatKhauMoi.TabIndex = 1;
            // 
            // btnToggleNew
            // 
            this.btnToggleNew.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleNew.BorderRadius = 8;
            this.btnToggleNew.FillColor = System.Drawing.Color.FromArgb(60, 60, 85);
            this.btnToggleNew.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnToggleNew.ForeColor = System.Drawing.Color.White;
            this.btnToggleNew.Location = new System.Drawing.Point(440, 210);
            this.btnToggleNew.Name = "btnToggleNew";
            this.btnToggleNew.Size = new System.Drawing.Size(40, 45);
            this.btnToggleNew.TabIndex = 8;
            this.btnToggleNew.Text = "👁";
            this.btnToggleNew.Click += new System.EventHandler(this.btnToggleNew_Click);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.BorderRadius = 12;
            this.txtXacNhanMatKhau.FillColor = System.Drawing.Color.FromArgb(45, 45, 70);
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtXacNhanMatKhau.ForeColor = System.Drawing.Color.White;
            this.txtXacNhanMatKhau.PlaceholderText = "Xác nhận mật khẩu mới";
            this.txtXacNhanMatKhau.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtXacNhanMatKhau.PasswordChar = '●';
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(40, 270);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(390, 45);
            this.txtXacNhanMatKhau.TabIndex = 2;
            // 
            // btnToggleConfirm
            // 
            this.btnToggleConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleConfirm.BorderRadius = 8;
            this.btnToggleConfirm.FillColor = System.Drawing.Color.FromArgb(60, 60, 85);
            this.btnToggleConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnToggleConfirm.ForeColor = System.Drawing.Color.White;
            this.btnToggleConfirm.Location = new System.Drawing.Point(440, 270);
            this.btnToggleConfirm.Name = "btnToggleConfirm";
            this.btnToggleConfirm.Size = new System.Drawing.Size(40, 45);
            this.btnToggleConfirm.TabIndex = 9;
            this.btnToggleConfirm.Text = "👁";
            this.btnToggleConfirm.Click += new System.EventHandler(this.btnToggleConfirm_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderRadius = 12;
            this.btnXacNhan.FillColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(40, 350);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(200, 50);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 12;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(90, 90, 110);
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(280, 350);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(200, 50);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 500);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauCu;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtXacNhanMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnToggleOld;
        private Guna.UI2.WinForms.Guna2Button btnToggleNew;
        private Guna.UI2.WinForms.Guna2Button btnToggleConfirm;
    }
}
