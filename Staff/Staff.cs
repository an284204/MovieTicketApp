using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MovieTicketApp
{
    public partial class Staff : Form
    {
        private UserInfo currentUser;
        private Guna2Button activeButton;
        private readonly Color activeColor = Color.FromArgb(255, 152, 67);
        private readonly Color normalColor = Color.FromArgb(45, 55, 72);

        public Staff(UserInfo userInfo)
        {
            InitializeComponent();
            currentUser = userInfo;
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            SetActiveButton(btnKiemTraVe);
            LoadUC(new TestTicket());
        }

        private void SetActiveButton(Guna2Button button)
        {
            // Reset previous active button
            if (activeButton != null && activeButton != btnThoat)
            {
                activeButton.FillColor = normalColor;
                activeButton.HoverState.FillColor = Color.FromArgb(60, 70, 90);
            }

            // Set new active button
            activeButton = button;
            if (button != btnThoat)
            {
                button.FillColor = activeColor;
                button.HoverState.FillColor = Color.FromArgb(255, 180, 100);
            }
        }

        private void LoadUC(Control uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnKiemTraVe_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnKiemTraVe);
            LoadUC(new TestTicket());
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDatVe);
            LoadUC(new Staffticket());
        }

        private void btnKiemTraDoAn_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnKiemTraDoAn);
            LoadUC(new TestFoodVoucher());
        }

        private void btnTinNhan_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnTinNhan);
            LoadUC(new StaffChat(currentUser.UserId));
        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDoAn);
            LoadUC(new UC_DoAn(currentUser));
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnTaiKhoan);
            LoadUC(new UC_QLTaiKhoan(currentUser, "Thông Tin Nhân Viên", "Quản lý thông tin tài khoản nhân viên"));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát?", 
                "Xác nhận", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
