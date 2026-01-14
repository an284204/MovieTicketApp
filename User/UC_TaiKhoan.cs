using System;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_TaiKhoan : UserControl
    {
        private UserInfo currentUser;

        public UC_TaiKhoan(UserInfo currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            if (currentUser != null)
            {
                txtEmail.Text = currentUser.Email;
                txtHoTen.Text = currentUser.HoTen;
                txtPhone.Text = currentUser.SoDienThoai;
                
                if (currentUser.NgaySinh.HasValue)
                {
                    txtNgaySinh.Text = currentUser.NgaySinh.Value.ToString("dd/MM/yyyy");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTen.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }

                DatabaseHelper db = new DatabaseHelper();
                DateTime ngaySinh = DateTime.Now;
                
                if (!string.IsNullOrWhiteSpace(txtNgaySinh.Text))
                {
                    if (!DateTime.TryParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaySinh))
                    {
                        MessageBox.Show("Ngày sinh không đúng định dạng (dd/MM/yyyy)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNgaySinh.Focus();
                        return;
                    }
                }

                db.UpdateAccount(
                    currentUser.UserId,
                    txtHoTen.Text.Trim(),
                    ngaySinh,
                    txtEmail.Text,
                    txtPhone.Text.Trim(),
                    null, // không đổi mật khẩu ở đây
                    currentUser.RoleId
                );

                // Cập nhật lại thông tin currentUser
                currentUser.HoTen = txtHoTen.Text.Trim();
                currentUser.SoDienThoai = txtPhone.Text.Trim();
                currentUser.NgaySinh = ngaySinh;

                MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (var changePasswordForm = new ChangePasswordForm(currentUser))
            {
                changePasswordForm.ShowDialog();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Tìm form cha là FormMainUser và đóng nó
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close();
                    
                    // Mở lại form đăng nhập
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
        }
    }
}