using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class RegisterForm : Form
    {
        private readonly Random _rng = new Random();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string dobText = txtDob.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(dobText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải từ 6 ký tự.");
                return;
            }

            if (!string.Equals(password, confirmPassword))
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                return;
            }

            if (!Regex.IsMatch(phone, @"^[0-9]{9,11}$"))
            {
                MessageBox.Show("Số điện thoại chỉ gồm 9-11 chữ số.");
                return;
            }

            if (!DateTime.TryParse(dobText, out DateTime dob))
            {
                MessageBox.Show("Ngày sinh không hợp lệ (định dạng: dd/MM/yyyy).");
                return;
            }

            string verificationCode = _rng.Next(100000, 999999).ToString();

            var pending = new PendingRegistration
            {
                Email = email,
                Password = password,
                HoTen = fullName,
                Phone = phone,
                Dob = dob
            };

            // Gửi email xác thực
            try
            {
                SendVerificationEmail(email, verificationCode);
                MessageBox.Show($"Mã xác thực đã được gửi tới email {email}.", "Xác thực email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể gửi email: {ex.Message}\n\nMã xác thực (dự phòng): {verificationCode}", "Lỗi gửi email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            using (var verifyForm = new VerifyCodeForm(pending, verificationCode))
            {
                if (verifyForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
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
                mail.Subject = "Mã xác thực đăng ký tài khoản";
                mail.Body = $@"
Xin chào,

Mã xác thực của bạn là: {code}

Mã này có hiệu lực trong 10 phút.

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

        public class PendingRegistration
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string HoTen { get; set; }
            public string Phone { get; set; }
            public DateTime Dob { get; set; }
        }
    }
}
