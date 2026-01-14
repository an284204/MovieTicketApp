using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_Hotro : UserControl
    {
        private readonly UserInfo currentUser;   
        private readonly DatabaseHelper dataHelper = new DatabaseHelper();

        private Timer refreshTimer;

        public UC_Hotro(UserInfo user)
        {
            InitializeComponent();
            currentUser = user;
            ReloadData();

            refreshTimer = new Timer();
            refreshTimer.Interval = 9000; 
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            ReloadData(); 
        }

        internal void ReloadData()
        {
            panelMessages.Controls.Clear();

            var messages = dataHelper.GetMessagesWithCustomer(currentUser.UserId);

            foreach (var msg in messages)
            {
                bool isStaff = msg.SenderId != currentUser.UserId;
                AddMessage(isStaff ? "Staff" : currentUser.HoTen, msg.Message, isStaff);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                string message = txtMessage.Text;

                dataHelper.SaveMessage(currentUser.UserId, 14, message);

                AddMessage(currentUser.HoTen, message, false);
                txtMessage.Clear();
            }
        }

        private void AddMessage(string sender, string message, bool isStaff)
        {
            var container = new Panel
            {
                AutoSize = true,
                Width = panelMessages.ClientSize.Width - 32,
                Margin = new Padding(0, 0, 0, 14)
            };

            var row = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = isStaff ? FlowDirection.LeftToRight : FlowDirection.RightToLeft,
                WrapContents = false,
                BackColor = Color.Transparent,
                Width = container.Width
            };

            var avatarStack = BuildAvatarStack(isStaff);
            avatarStack.Margin = new Padding(0, 0, 12, 0);

            var lblText = new Label
            {
                AutoSize = true,
                MaximumSize = new Size(container.Width - 170, 0),
                Text = message,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.Transparent
            };

            var bubble = new Guna.UI2.WinForms.Guna2Panel
            {
                AutoSize = true,
                MaximumSize = new Size(container.Width - 170, 0),
                BorderRadius = 14,
                FillColor = isStaff ? Color.FromArgb(45, 45, 65) : Color.FromArgb(229, 9, 20),
                Padding = new Padding(12, 10, 12, 10),
                Margin = new Padding(0, 0, 12, 0)
            };
            bubble.Controls.Add(lblText);

            row.Controls.Add(avatarStack);
            row.Controls.Add(bubble);

            container.Controls.Add(row);
            panelMessages.Controls.Add(container);
            panelMessages.ScrollControlIntoView(container);
        }

        private Control BuildAvatarStack(bool isStaff)
        {
            var stack = new Panel
            {
                Width = 90,
                Height = 80
            };

            var nameLabel = new Label
            {
                Text = isStaff ? "Nhân viên" : "Bạn",
                AutoSize = false,
                Width = 90,
                Height = 18,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = Color.Gainsboro,
                BackColor = Color.Transparent
            };

            var avatar = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new Size(52, 52),
                BorderRadius = 26,
                FillColor = isStaff ? Color.FromArgb(90, 160, 255) : Color.FromArgb(229, 9, 20),
                Location = new Point((90 - 52) / 2, 22)
            };

            var avatarText = new Label
            {
                Dock = DockStyle.Fill,
                Text = isStaff ? "CS" : "U",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent
            };

            avatar.Controls.Add(avatarText);
            stack.Controls.Add(nameLabel);
            stack.Controls.Add(avatar);
            return stack;
        }
    }
}