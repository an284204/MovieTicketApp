using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace MovieTicketApp
{
    public partial class FormMainUser : Form
    {
        private Guna2CircleButton btnChatBot;
        private Guna2Button[] menuButtons;
        private UC_TrangChu homeUC; 
        private UC_Phim phimUC;
        private UC_DoAn doAnUC;
        private UC_LichSu lichSuUC;
        private UC_TaiKhoan taiKhoanUC;
        private UC_Hotro hoTroUC;
        private Chatbot chatForm;

        private readonly UserInfo currentUser;

        private readonly Color menuActiveColor = Color.FromArgb(229, 9, 20);
        private readonly Color menuInactiveColor = Color.FromArgb(30, 30, 45);

        public FormMainUser(UserInfo userInfo)
        {
            InitializeComponent();
            currentUser = userInfo; 
            ConfigureMenuButtons();
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
            homeUC = new UC_TrangChu(currentUser);
            phimUC = new UC_Phim(currentUser);
            doAnUC = new UC_DoAn(currentUser);
            lichSuUC = new UC_LichSu(currentUser);   
            taiKhoanUC = new UC_TaiKhoan(currentUser);
            hoTroUC = new UC_Hotro(currentUser);


            AddUserControl(homeUC);
            SetActiveButton(btnTrangChu);

            AddChatBotButton();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            AddUserControl(homeUC);
            btnChatBot.Visible = true;
            SetActiveButton(btnTrangChu);
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            AddUserControl(phimUC);
            btnChatBot.Visible = true;
            SetActiveButton(btnPhim);
        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            AddUserControl(doAnUC);
            btnChatBot.Visible = false;
            SetActiveButton(btnDoAn);
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            lichSuUC.ReloadData();
            AddUserControl(lichSuUC);
            btnChatBot.Visible = false;
            SetActiveButton(btnLichSu);
        }

        private void btnQuanLyTK_Click(object sender, EventArgs e)
        {
            AddUserControl(taiKhoanUC);
            btnChatBot.Visible = false;
            SetActiveButton(btnQuanLyTK);
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
                FillColor = Color.FromArgb(229, 9, 20),
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.White,
                Text = "💬",
                ImageSize = new Size(28, 28),
                BorderThickness = 0,
                Cursor = Cursors.Hand,
                ShadowDecoration = { Enabled = true, Depth = 15, Color = Color.FromArgb(100, 0, 0, 0) },
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
            SetActiveButton(btnTrangChu);
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
            SetActiveButton(btnHotro);
        }

        private void ConfigureMenuButtons()
        {
            menuButtons = new[]
            {
                btnTrangChu,
                btnPhim,
                btnDoAn,
                btnLichSu,
                btnQuanLyTK,
                btnHotro
            };

            foreach (var btn in menuButtons)
            {
                if (btn == null)
                {
                    continue;
                }

                btn.ButtonMode = ButtonMode.RadioButton;
                btn.FillColor = menuInactiveColor;
                btn.HoverState.FillColor = Color.FromArgb(200, 20, 35);
                btn.CheckedState.FillColor = menuActiveColor;
                btn.CheckedState.ForeColor = Color.White;
                btn.CheckedState.CustomBorderColor = menuActiveColor;
                btn.TextAlign = HorizontalAlignment.Left;
                btn.Padding = new Padding(4, 0, 0, 0);
            }

            if (btnTrangChu != null)
            {
                btnTrangChu.Checked = true;
            }
        }

        private void SetActiveButton(Guna2Button targetButton)
        {
            if (targetButton == null)
            {
                return;
            }

            targetButton.Checked = true;
        }
    }
}
