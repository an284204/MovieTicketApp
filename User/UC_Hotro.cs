using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_Hotro : UserControl
    {
        private readonly UserInfo currentUser;   // thông tin khách đăng nhập
        private readonly DatabaseHelper dataHelper = new DatabaseHelper();

        private Timer refreshTimer;

        public UC_Hotro(UserInfo user)
        {
            InitializeComponent();
            currentUser = user;
            ReloadData();

            // Khởi tạo timer
            refreshTimer = new Timer();
            refreshTimer.Interval = 3000; // 3 giây
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            ReloadData(); // load lại hội thoại của khách
        }

        internal void ReloadData()
        {
            panelMessages.Controls.Clear();

            // Lấy lịch sử tin nhắn từ DB (chat riêng + chat chung)
            var messages = dataHelper.GetMessagesWithCustomer(currentUser.UserId);

            foreach (var msg in messages)
            {
                // Nếu người gửi là staff thì isStaff = true
                bool isStaff = msg.SenderId != currentUser.UserId;
                AddMessage(isStaff ? "Staff" : currentUser.HoTen, msg.Message, isStaff);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                string message = txtMessage.Text;

                // Khách gửi vào chat chung (ReceiverId = 14)
                dataHelper.SaveMessage(currentUser.UserId, 14, message);

                // Hiển thị ngay trên giao diện
                AddMessage(currentUser.HoTen, message, false);
                txtMessage.Clear();
            }
        }

        private void AddMessage(string sender, string message, bool isStaff)
        {
            Panel bubble = new Panel();
            bubble.AutoSize = true;
            bubble.MaximumSize = new Size(400, 0);
            bubble.Padding = new Padding(10);
            bubble.Margin = new Padding(8);
            bubble.BackColor = isStaff ? Color.LightBlue : Color.LightGreen;

            Label lbl = new Label();
            lbl.Text = message;
            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(380, 0);
            lbl.Font = new Font("Segoe UI", 10);
            lbl.ForeColor = Color.Black;

            bubble.Controls.Add(lbl);
            bubble.Anchor = isStaff ? AnchorStyles.Left : AnchorStyles.Right;

            panelMessages.Controls.Add(bubble);
            panelMessages.ScrollControlIntoView(bubble);
        }
    }
}