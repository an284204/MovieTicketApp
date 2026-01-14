namespace MovieTicketApp
{
    partial class ForgotPasswordForm
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
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSendCode = new Guna.UI2.WinForms.Guna2Button();
            this.panelVerifyCode = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCodeInfo = new System.Windows.Forms.Label();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerifyCode = new Guna.UI2.WinForms.Guna2Button();
            this.panelNewPassword = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPasswordInfo = new System.Windows.Forms.Label();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain.SuspendLayout();
            this.panelVerifyCode.SuspendLayout();
            this.panelNewPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderRadius = 20;
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.panelNewPassword);
            this.panelMain.Controls.Add(this.panelVerifyCode);
            this.panelMain.Controls.Add(this.btnSendCode);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.lblSubtitle);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(60, 80, 130);
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(560, 820);
            this.panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(35, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(323, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quên mật khẩu";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitle.Location = new System.Drawing.Point(40, 100);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(382, 28);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Nhập email để nhận mã xác thực";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderRadius = 12;
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(45, 45, 70);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(45, 145);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(470, 48);
            this.txtEmail.TabIndex = 2;
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.Transparent;
            this.btnSendCode.BorderRadius = 12;
            this.btnSendCode.FillColor = System.Drawing.Color.FromArgb(0, 150, 255);
            this.btnSendCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(45, 210);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(470, 50);
            this.btnSendCode.TabIndex = 3;
            this.btnSendCode.Text = "Gửi mã xác thực";
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // panelVerifyCode
            // 
            this.panelVerifyCode.BackColor = System.Drawing.Color.Transparent;
            this.panelVerifyCode.BorderRadius = 15;
            this.panelVerifyCode.Controls.Add(this.btnVerifyCode);
            this.panelVerifyCode.Controls.Add(this.txtCode);
            this.panelVerifyCode.Controls.Add(this.lblCodeInfo);
            this.panelVerifyCode.FillColor = System.Drawing.Color.FromArgb(40, 40, 65);
            this.panelVerifyCode.Location = new System.Drawing.Point(45, 290);
            this.panelVerifyCode.Name = "panelVerifyCode";
            this.panelVerifyCode.Padding = new System.Windows.Forms.Padding(20);
            this.panelVerifyCode.Size = new System.Drawing.Size(470, 160);
            this.panelVerifyCode.TabIndex = 4;
            // 
            // lblCodeInfo
            // 
            this.lblCodeInfo.AutoSize = true;
            this.lblCodeInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodeInfo.ForeColor = System.Drawing.Color.White;
            this.lblCodeInfo.Location = new System.Drawing.Point(20, 18);
            this.lblCodeInfo.Name = "lblCodeInfo";
            this.lblCodeInfo.Size = new System.Drawing.Size(223, 25);
            this.lblCodeInfo.TabIndex = 0;
            this.lblCodeInfo.Text = "Nhập mã xác thực 6 số";
            // 
            // txtCode
            // 
            this.txtCode.BorderRadius = 10;
            this.txtCode.FillColor = System.Drawing.Color.FromArgb(50, 50, 75);
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.PlaceholderText = "Mã xác thực";
            this.txtCode.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCode.Location = new System.Drawing.Point(20, 50);
            this.txtCode.MaxLength = 6;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(410, 42);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.BorderRadius = 10;
            this.btnVerifyCode.FillColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnVerifyCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerifyCode.ForeColor = System.Drawing.Color.White;
            this.btnVerifyCode.Location = new System.Drawing.Point(20, 102);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(410, 45);
            this.btnVerifyCode.TabIndex = 2;
            this.btnVerifyCode.Text = "Xác nhận";
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // panelNewPassword
            // 
            this.panelNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.panelNewPassword.BorderRadius = 15;
            this.panelNewPassword.Controls.Add(this.btnResetPassword);
            this.panelNewPassword.Controls.Add(this.txtConfirmPassword);
            this.panelNewPassword.Controls.Add(this.txtNewPassword);
            this.panelNewPassword.Controls.Add(this.lblPasswordInfo);
            this.panelNewPassword.FillColor = System.Drawing.Color.FromArgb(40, 40, 65);
            this.panelNewPassword.Location = new System.Drawing.Point(45, 470);
            this.panelNewPassword.Name = "panelNewPassword";
            this.panelNewPassword.Padding = new System.Windows.Forms.Padding(20);
            this.panelNewPassword.Size = new System.Drawing.Size(470, 280);
            this.panelNewPassword.TabIndex = 5;
            // 
            // lblPasswordInfo
            // 
            this.lblPasswordInfo.AutoSize = true;
            this.lblPasswordInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPasswordInfo.ForeColor = System.Drawing.Color.White;
            this.lblPasswordInfo.Location = new System.Drawing.Point(20, 18);
            this.lblPasswordInfo.Name = "lblPasswordInfo";
            this.lblPasswordInfo.Size = new System.Drawing.Size(182, 25);
            this.lblPasswordInfo.TabIndex = 0;
            this.lblPasswordInfo.Text = "Nhập mật khẩu mới";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderRadius = 10;
            this.txtNewPassword.FillColor = System.Drawing.Color.FromArgb(50, 50, 75);
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.White;
            this.txtNewPassword.PlaceholderText = "Mật khẩu mới";
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Location = new System.Drawing.Point(20, 50);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(410, 42);
            this.txtNewPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 10;
            this.txtConfirmPassword.FillColor = System.Drawing.Color.FromArgb(50, 50, 75);
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.PlaceholderText = "Xác nhận mật khẩu";
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Location = new System.Drawing.Point(20, 105);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(410, 42);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BorderRadius = 10;
            this.btnResetPassword.FillColor = System.Drawing.Color.FromArgb(255, 87, 34);
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(20, 160);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(410, 45);
            this.btnResetPassword.TabIndex = 3;
            this.btnResetPassword.Text = "Đổi mật khẩu";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 10;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(90, 90, 110);
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(470, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "✕";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 820);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelVerifyCode.ResumeLayout(false);
            this.panelVerifyCode.PerformLayout();
            this.panelNewPassword.ResumeLayout(false);
            this.panelNewPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Button btnSendCode;
        private Guna.UI2.WinForms.Guna2Panel panelVerifyCode;
        private System.Windows.Forms.Label lblCodeInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2Button btnVerifyCode;
        private Guna.UI2.WinForms.Guna2Panel panelNewPassword;
        private System.Windows.Forms.Label lblPasswordInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button btnResetPassword;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
