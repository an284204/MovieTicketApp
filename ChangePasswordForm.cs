using System;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class ChangePasswordForm : Form
    {
        private UserInfo currentUser;

        public ChangePasswordForm(UserInfo user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauCu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtXacNhanMatKhau.Text))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhanMatKhau.Focus();
                return;
            }

            if (txtMatKhauMoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }

            if (txtMatKhauMoi.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhanMatKhau.Focus();
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();
                
                // Kiểm tra mật khẩu cũ
                var checkResult = db.CheckLogin(currentUser.Email, txtMatKhauCu.Text);
                
                if (checkResult.userId == -1)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauCu.Focus();
                    txtMatKhauCu.SelectAll();
                    return;
                }

                // Cập nhật mật khẩu mới
                db.UpdateAccount(
                    currentUser.UserId,
                    currentUser.HoTen,
                    currentUser.NgaySinh ?? DateTime.Now,
                    currentUser.Email,
                    currentUser.SoDienThoai,
                    txtMatKhauMoi.Text,
                    currentUser.RoleId
                );

                MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToggleOld_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.PasswordChar == '●')
            {
                txtMatKhauCu.PasswordChar = '\0';
                btnToggleOld.Text = "🙈";
            }
            else
            {
                txtMatKhauCu.PasswordChar = '●';
                btnToggleOld.Text = "👁";
            }
        }

        private void btnToggleNew_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.PasswordChar == '●')
            {
                txtMatKhauMoi.PasswordChar = '\0';
                btnToggleNew.Text = "🙈";
            }
            else
            {
                txtMatKhauMoi.PasswordChar = '●';
                btnToggleNew.Text = "👁";
            }
        }

        private void btnToggleConfirm_Click(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.PasswordChar == '●')
            {
                txtXacNhanMatKhau.PasswordChar = '\0';
                btnToggleConfirm.Text = "🙈";
            }
            else
            {
                txtXacNhanMatKhau.PasswordChar = '●';
                btnToggleConfirm.Text = "👁";
            }
        }
    }
}
