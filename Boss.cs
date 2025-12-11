using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Boss : Form
    {
        public Boss(UserInfo userInfo)
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void Boss_Load(object sender, EventArgs e)
        {
            // Mặc định hiển thị trang chủ khi mở form
            panelMain.AutoScroll = true;
            BossHome uc = new BossHome();
            AddUserControl(uc);
        }
        private void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
            uc.BringToFront();
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
        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            Bosstk uc = new Bosstk();
            AddUserControl(uc);
        }
        private void btnDoanhThuDoAn_Click(object sender, EventArgs e)
        {
            Bossdtfood uc = new Bossdtfood();
            AddUserControl(uc);
        }


        private void btnDoanhThuPhim_Click(object sender, EventArgs e)
        {
            BossdtMovie uc = new BossdtMovie();
            AddUserControl(uc);
        }


        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            BossHome uc = new BossHome();
            AddUserControl(uc);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
