using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace MovieTicketApp
{
    public partial class FormMainUser : Form
    {
        private Guna.UI2.WinForms.Guna2CircleButton btnChatBot;
        private UC_TrangChu homeUC; 
        private UC_Phim phimUC;
        private UC_DoAn doAnUC;
        private UC_LichSu lichSuUC;
        private UC_TaiKhoan taiKhoanUC;
        private UC_Hotro hoTroUC;
        private Chatbot chatForm;

        private readonly UserInfo currentUser;

        public FormMainUser(UserInfo userInfo)
        {
            InitializeComponent();
            currentUser = userInfo; 
        }

        private void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void FormMainUser_Load(object sender, EventArgs e)
        {
            homeUC = new UC_TrangChu();
            phimUC = new UC_Phim(currentUser);
            doAnUC = new UC_DoAn(currentUser);
            lichSuUC = new UC_LichSu(currentUser);   
            taiKhoanUC = new UC_TaiKhoan(currentUser);
            hoTroUC = new UC_Hotro(currentUser);


            AddUserControl(homeUC);

            AddChatBotButton();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            AddUserControl(homeUC);
            btnChatBot.Visible = true;
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            AddUserControl(phimUC);
            btnChatBot.Visible = true;
        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            AddUserControl(doAnUC);
            btnChatBot.Visible = false;
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            lichSuUC.ReloadData();
            AddUserControl(lichSuUC);
            btnChatBot.Visible = false;
        }

        private void btnQuanLyTK_Click(object sender, EventArgs e)
        {
            AddUserControl(taiKhoanUC);
            btnChatBot.Visible = false;
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
                this.Close();
        }

        private void AddChatBotButton()
        {
            btnChatBot = new Guna.UI2.WinForms.Guna2CircleButton()
            {
                Size = new Size(60, 60),
                FillColor = Color.OrangeRed,
                ImageSize = new Size(28, 28),
                BorderThickness = 0,
                Cursor = Cursors.Hand,
                ShadowDecoration = { Enabled = false },
                //ShadowDecoration = { Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle },
                //Image = Properties.Resources.chatbot // icon của bạn
            };

            btnChatBot.Click += BtnChatBot_Click;

            this.Controls.Add(btnChatBot);
            PositionChatBot();
            this.Resize += (s, e) => PositionChatBot();
        }

        private void PositionChatBot()
        {
            btnChatBot.Location = new Point(
                this.ClientSize.Width - btnChatBot.Width - 20,
                this.ClientSize.Height - btnChatBot.Height - 20
            );
            btnChatBot.BringToFront();
        }
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            AddUserControl(homeUC);
        }


        private void BtnChatBot_Click(object sender, EventArgs e)
        {
            if (chatForm == null || chatForm.IsDisposed)
            {
                chatForm = new Chatbot();

                Point btnScreenPos = this.PointToScreen(btnChatBot.Location);

                chatForm.StartPosition = FormStartPosition.Manual;
                chatForm.Location = new Point(
                    btnScreenPos.X - (chatForm.Width - btnChatBot.Width) / 1,
                    btnScreenPos.Y - chatForm.Height
                );

                chatForm.TopMost = true;
                chatForm.Show();
            }
            else
            {
                // Nếu form đã mở thì đưa nó lên trước
                chatForm.BringToFront();
                chatForm.Focus();
            }
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {
            hoTroUC.ReloadData();
            AddUserControl(hoTroUC);
            btnChatBot.Visible = false;
        }
    }
}
