using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_QLTaiKhoan : UserControl
    {
        private UserInfo currentUser;
        private string customTitle;
        private string customSubtitle;

        public UC_QLTaiKhoan()
        {
            InitializeComponent();
            LoadAdminInfo();
            CreateAvatarIcon();
            this.Load += (s, e) => UC_QLTaiKhoan_Resize(s, e);
        }

        // Constructor với UserInfo
        public UC_QLTaiKhoan(UserInfo user) : this()
        {
            this.currentUser = user;
            LoadAdminInfo();
        }

        // Constructor với UserInfo và title tùy chỉnh
        public UC_QLTaiKhoan(UserInfo user, string title, string subtitle) : this()
        {
            this.currentUser = user;
            this.customTitle = title;
            this.customSubtitle = subtitle;
            if (!string.IsNullOrEmpty(title))
            {
                lblTitle.Text = title;
            }
            if (!string.IsNullOrEmpty(subtitle))
            {
                lblSubtitle.Text = subtitle;
            }
            LoadAdminInfo();
        }

        private void UC_QLTaiKhoan_Resize(object sender, EventArgs e)
        {
            // Căn giữa panelCard trong panelMain
            if (panelCard != null && panelMain != null)
            {
                int x = (panelMain.Width - panelCard.Width) / 2;
                int y = (panelMain.Height - panelCard.Height) / 2;
                if (y < 20) y = 20;
                panelCard.Location = new Point(x, y);
            }
        }

        private void CreateAvatarIcon()
        {
            // Tạo avatar icon đơn giản
            try
            {
                Bitmap bmp = new Bitmap(70, 70);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.FromArgb(55, 90, 140));
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    
                    // Vẽ icon người dùng đơn giản
                    using (SolidBrush whiteBrush = new SolidBrush(Color.White))
                    {
                        // Đầu
                        g.FillEllipse(whiteBrush, 24, 12, 22, 22);
                        // Thân
                        g.FillEllipse(whiteBrush, 17, 38, 36, 25);
                    }
                }
                picAvatar.Image = bmp;
            }
            catch { }
        }

        private void LoadAdminInfo()
        {
            try
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

                    // Cập nhật tên hiển thị
                    lblAdminName.Text = string.IsNullOrEmpty(currentUser.HoTen) ? "Admin" : currentUser.HoTen;
                    
                    // Căn giữa tên
                    CenterLabel(lblAdminName);
                    CenterLabel(lblAdminRole);
                }
                else
                {
                    // Nếu không có user, thử load từ static hoặc để trống
                    lblAdminName.Text = "Quản trị viên";
                    CenterLabel(lblAdminName);
                    CenterLabel(lblAdminRole);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CenterLabel(Label lbl)
        {
            if (lbl.Parent != null)
            {
                int x = (lbl.Parent.Width - lbl.Width) / 2;
                lbl.Location = new Point(x, lbl.Location.Y);
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

                if (currentUser != null)
                {
                    db.UpdateAccount(
                        currentUser.UserId,
                        txtHoTen.Text.Trim(),
                        ngaySinh,
                        txtEmail.Text,
                        txtPhone.Text.Trim(),
                        null,
                        currentUser.RoleId
                    );

                    // Cập nhật lại thông tin currentUser
                    currentUser.HoTen = txtHoTen.Text.Trim();
                    currentUser.SoDienThoai = txtPhone.Text.Trim();
                    currentUser.NgaySinh = ngaySinh;

                    // Cập nhật label
                    lblAdminName.Text = txtHoTen.Text.Trim();
                    CenterLabel(lblAdminName);
                }

                MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentUser != null)
                {
                    using (var changePasswordForm = new ChangePasswordForm(currentUser))
                    {
                        changePasswordForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Tìm form cha và đóng
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

        // Phương thức để set user từ bên ngoài
        public void SetCurrentUser(UserInfo user)
        {
            this.currentUser = user;
            LoadAdminInfo();
        }
    }
}
