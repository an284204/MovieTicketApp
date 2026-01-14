using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly Random _rng = new Random();
        private string _verificationCode;
        private string _userEmail;
        private bool _isVerified = false;

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra email có tồn tại trong DB không
            DatabaseHelper db = new DatabaseHelper();
            if (!db.CheckEmailExists(email))
            {
                MessageBox.Show("Email không tồn tại trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _userEmail = email;
            _verificationCode = _rng.Next(100000, 999999).ToString();

            // Gửi mã xác thực qua email
            try
            {
                SendVerificationEmail(email, _verificationCode);
                MessageBox.Show($"Mã xác thực đã được gửi tới email {email}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Hiện panel nhập mã
                panelVerifyCode.Visible = true;
                txtEmail.Enabled = false;
                btnSendCode.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể gửi email: {ex.Message}\n\nMã xác thực (dự phòng): {_verificationCode}", "Lỗi gửi email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panelVerifyCode.Visible = true;
                txtEmail.Enabled = false;
                btnSendCode.Enabled = false;
            }
        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();

            if (code != _verificationCode)
            {
                MessageBox.Show("Mã xác thực không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isVerified = true;
            MessageBox.Show("Xác thực thành công! Vui lòng nhập mật khẩu mới.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Hiện panel đổi mật khẩu
            panelNewPassword.Visible = true;
            panelVerifyCode.Enabled = false;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (!_isVerified)
            {
                MessageBox.Show("Vui lòng xác thực mã trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();
                var userInfo = db.GetUserByEmail(_userEmail);
                
                if (userInfo == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật mật khẩu mới
                db.UpdateAccount(
                    userInfo.UserId,
                    userInfo.HoTen,
                    userInfo.NgaySinh ?? DateTime.Now,
                    userInfo.Email,
                    userInfo.SoDienThoai,
                    newPassword,
                    userInfo.RoleId
                );

                MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendVerificationEmail(string toEmail, string code)
        {
            string fromEmail = "buianhx0004@gmail.com"; // Thay bằng email Gmail của bạn
            string appPassword = "cuse lgjl zrij xizk"; // Thay bằng App Password của Gmail

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(fromEmail, "Movie Ticket App");
                mail.To.Add(toEmail);
                mail.Subject = "Mã xác thực khôi phục mật khẩu";
                mail.Body = $@"
Xin chào,

Bạn đã yêu cầu khôi phục mật khẩu tài khoản Movie Ticket App.

Mã xác thực của bạn là: {code}

Mã này có hiệu lực trong 10 phút.

Nếu bạn không thực hiện yêu cầu này, vui lòng bỏ qua email này.

Trân trọng,
Movie Ticket App";
                mail.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(fromEmail, appPassword);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            panelVerifyCode.Visible = false;
            panelNewPassword.Visible = false;
        }
    }
}
