using System;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class FormMainAdmin : Form
    {
        public FormMainAdmin(UserInfo userInfo)
        {
            InitializeComponent();

        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {
            // Mặc định hiển thị trang chủ khi mở form
            UC_TrangChuAdmin uc = new UC_TrangChuAdmin();
            AddUserControl(uc);
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
        }

        private void btnQLPhim_Click(object sender, EventArgs e)
        {
            UC_QLPhim uc = new UC_QLPhim();
            AddUserControl(uc);
        }

        private void btnQLDoAn_Click(object sender, EventArgs e)
        {
            UC_QLDoAn uc = new UC_QLDoAn();
            AddUserControl(uc);
        }


        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            UC_XuatChieu uc = new UC_XuatChieu();
            AddUserControl(uc);
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            UC_QLTaiKhoan uc = new UC_QLTaiKhoan();
            AddUserControl(uc);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
