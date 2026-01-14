using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class FormMainAdmin : Form
    {
        // Cho phép kéo form không viền
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private Guna.UI2.WinForms.Guna2Button currentActiveButton;
        private UserInfo _currentUser;

        public FormMainAdmin(UserInfo userInfo)
        {
            InitializeComponent();
            _currentUser = userInfo;
            SetupSidebarButtons();
        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {
            // Mặc định hiển thị trang chủ khi mở form
            UC_TrangChuAdmin uc = new UC_TrangChuAdmin();
            AddUserControl(uc);
            SetActiveButton(btnTrangChu);
        }

        private void SetupSidebarButtons()
        {
            // Thiết lập hover effect cho các button
            var buttons = new[] { btnTrangChu, btnQLPhim, btnQLDoAn, btnXuatChieu, btnQLTaiKhoan };
            foreach (var btn in buttons)
            {
                btn.MouseEnter += (s, e) =>
                {
                    if (btn != currentActiveButton)
                    {
                        btn.FillColor = System.Drawing.Color.FromArgb(45, 55, 75);
                    }
                };
                btn.MouseLeave += (s, e) =>
                {
                    if (btn != currentActiveButton)
                    {
                        btn.FillColor = System.Drawing.Color.FromArgb(35, 40, 52);
                    }
                };
            }
        }

        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeBtn)
        {
            // Reset tất cả button về trạng thái mặc định
            var buttons = new[] { btnTrangChu, btnQLPhim, btnQLDoAn, btnXuatChieu, btnQLTaiKhoan };
            foreach (var btn in buttons)
            {
                btn.FillColor = System.Drawing.Color.FromArgb(35, 40, 52);
                btn.ForeColor = System.Drawing.Color.FromArgb(180, 180, 195);
            }

            // Highlight button đang active
            activeBtn.FillColor = System.Drawing.Color.FromArgb(55, 90, 140);
            activeBtn.ForeColor = System.Drawing.Color.White;
            currentActiveButton = activeBtn;
        }

        private void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            UC_TrangChuAdmin uc = new UC_TrangChuAdmin();
            AddUserControl(uc);
            SetActiveButton(btnTrangChu);
        }

        private void btnQLPhim_Click(object sender, EventArgs e)
        {
            UC_QLPhim uc = new UC_QLPhim();
            AddUserControl(uc);
            SetActiveButton(btnQLPhim);
        }

        private void btnQLDoAn_Click(object sender, EventArgs e)
        {
            UC_QLDoAn uc = new UC_QLDoAn();
            AddUserControl(uc);
            SetActiveButton(btnQLDoAn);
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            UC_XuatChieu uc = new UC_XuatChieu();
            AddUserControl(uc);
            SetActiveButton(btnXuatChieu);
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            UC_QLTaiKhoan uc = new UC_QLTaiKhoan(_currentUser);
            AddUserControl(uc);
            SetActiveButton(btnQLTaiKhoan);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        // Window control buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Cho phép kéo header để di chuyển form
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
