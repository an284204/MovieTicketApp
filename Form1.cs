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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string input = txtUsername.Text.Trim(); // Email hoặc SĐT
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            var result = db.CheckLogin(input, password);

            if (result.userId == -1)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                return;
            }

            // Tạo đối tượng chứa thông tin người dùng
            var userInfo = new UserInfo
            {
                UserId = result.userId,
                RoleId = result.roleId,
                HoTen = result.hoTen,
                Email = result.email,
                SoDienThoai = result.soDienThoai
            };

            this.Hide();
            switch (userInfo.RoleId)
            {
                case 1:
                    using (var f = new FormMainUser(userInfo)) f.ShowDialog();
                    break;
                case 2:
                    using (var f = new FormMainAdmin(userInfo)) f.ShowDialog();
                    break;
                case 3:
                    using (var f = new Staff(userInfo)) f.ShowDialog();
                    break;
                case 4:
                    using (var f = new Boss(userInfo)) f.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Vai trò không hợp lệ!");
                    break;
            }

            this.Show();
        }
    }
}
