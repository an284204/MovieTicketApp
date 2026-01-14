using System;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Staffticket : UserControl
    {
        public Staffticket()
        {
            InitializeComponent();
            this.Load += Staffticket_Load;
        }

        private void Staffticket_Load(object sender, EventArgs e)
        {
            var staffUser = new UserInfo
            {
                UserId = 18,
                RoleId = 1,
                HoTen = "Nhân viên đặt vé",
                Email = "stafftest@gmail.com",
                SoDienThoai = "1111111111"
            };

            var ucPhim = new UC_Phim(staffUser) { Dock = DockStyle.Fill };
            this.Controls.Clear();
            this.Controls.Add(ucPhim);
        }
    }
}