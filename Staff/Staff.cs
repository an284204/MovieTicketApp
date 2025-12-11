using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Staff : Form
    {
        private UserInfo currentUser;

        public Staff(UserInfo userInfo)
        {
            InitializeComponent();
            currentUser = userInfo;
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // Có thể hiển thị thông tin nhân viên tại đây nếu cần
        }

        private void LoadUC(Control uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnKiemTraVe_Click(object sender, EventArgs e)
        {

        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {

        }

        private void btnTinNhan_Click(object sender, EventArgs e)
        {
            LoadUC(new StaffChat(currentUser.UserId));
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}