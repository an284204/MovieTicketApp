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
                txtHoTen.Text = currentUser.HoTen;
                txtEmail.Text = currentUser.Email;
                txtPhone.Text = currentUser.SoDienThoai;
                txtNgaySinh.Text = currentUser.NgaySinh?.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                DateTime NgaySinh;
                DateTime.TryParse(txtNgaySinh.Text, out NgaySinh);

                db.UpdateAccount(
                    currentUser.UserId,
                    txtHoTen.Text,
                    NgaySinh,
                    txtEmail.Text,
                    txtPhone.Text,
                    null, // không đổi mật khẩu ở đây
                    currentUser.RoleId
                );

                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            panelDoiMK.Visible = true;
        }

        private void btnXacNhanMK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMKCu.Text) || string.IsNullOrEmpty(txtMKMoi.Text) || string.IsNullOrEmpty(txtNhapLaiMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mật khẩu!");
                return;
            }

            if (txtMKMoi.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();
                DateTime NgaySinh;
                DateTime.TryParse(txtNgaySinh.Text, out NgaySinh);

                db.UpdateAccount(
                    currentUser.UserId,
                    txtHoTen.Text,
                    NgaySinh,
                    txtEmail.Text,
                    txtPhone.Text,
                    txtMKMoi.Text, // cập nhật mật khẩu mới
                    currentUser.RoleId
                );

                MessageBox.Show("Đổi mật khẩu thành công!");
                panelDoiMK.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message);
            }
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    picAvatar.Image = System.Drawing.Image.FromFile(ofd.FileName);
            //    // Nếu muốn lưu avatar vào DB thì thêm cột Avatar trong bảng Users
            //}
        }
    }
}