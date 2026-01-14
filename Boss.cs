using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Boss : Form
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

        public Boss(UserInfo userInfo)
        {
            InitializeComponent();
            _currentUser = userInfo;
            SetupSidebarButtons();
        }

        private void Boss_Load(object sender, EventArgs e)
        {
            // Mặc định hiển thị trang chủ khi mở form
            BossHome uc = new BossHome();
            AddUserControl(uc);
            SetActiveButton(btnTrangChu);
        }

        private void SetupSidebarButtons()
        {
            // Thiết lập hover effect cho các button
            var buttons = new[] { btnTrangChu, btnDoanhThuPhim, btnDoanhThuDoAn, btnQLTaiKhoan };
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
            var buttons = new[] { btnTrangChu, btnDoanhThuPhim, btnDoanhThuDoAn, btnQLTaiKhoan };
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

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "Bạn có chắc muốn đăng xuất không?",
                 "Xác nhận",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            Bosstk uc = new Bosstk();
            AddUserControl(uc);
            SetActiveButton(btnQLTaiKhoan);
        }
        
        private void btnDoanhThuDoAn_Click(object sender, EventArgs e)
        {
            Bossdtfood uc = new Bossdtfood();
            AddUserControl(uc);
            SetActiveButton(btnDoanhThuDoAn);
        }

        private void btnDoanhThuPhim_Click(object sender, EventArgs e)
        {
            BossdtMovie uc = new BossdtMovie();
            AddUserControl(uc);
            SetActiveButton(btnDoanhThuPhim);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            BossHome uc = new BossHome();
            AddUserControl(uc);
            SetActiveButton(btnTrangChu);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
