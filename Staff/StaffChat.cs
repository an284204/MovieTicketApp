using Guna.UI2.WinForms;
using MovieTicketApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class StaffChat : UserControl
    {
        private SplitContainer splitMain;
        private FlowLayoutPanel panelCustomers;

        private Dictionary<string, FlowLayoutPanel> chatPanels = new Dictionary<string, FlowLayoutPanel>();
        private string currentCustomer;

        private readonly DatabaseHelper dataHelper = new DatabaseHelper(); // dùng DataHelper
        private readonly int staffId; // lưu UserID của nhân viên đăng nhập

        private Timer refreshTimer;

        public StaffChat(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
            SetupLayout();
            BuildCustomerList();

            // Khởi tạo timer
            refreshTimer = new Timer();
            refreshTimer.Interval = 3000; // 3 giây
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        public StaffChat()
        {
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentCustomer))
            {
                LoadCustomer(currentCustomer); // load lại hội thoại của khách hiện tại
            }
        }

        private void SetupLayout()
        {
            splitMain = new SplitContainer();
            splitMain.Dock = DockStyle.Fill;
            splitMain.Orientation = Orientation.Vertical;
            splitMain.SplitterDistance = (int)(this.Width * 0.05);
            splitMain.IsSplitterFixed = false;

            this.Controls.Clear();
            this.Controls.Add(splitMain);

            panelCustomers = new FlowLayoutPanel();
            panelCustomers.Dock = DockStyle.Fill;
            panelCustomers.FlowDirection = FlowDirection.TopDown;
            panelCustomers.AutoScroll = true;
            splitMain.Panel1.Controls.Add(panelCustomers);

            panelMain.Dock = DockStyle.Fill;
            splitMain.Panel2.Controls.Add(panelMain);
        }

        private void BuildCustomerList()
        {
            var customers = dataHelper.GetCustomers(); // SELECT UserID, HoTen WHERE RoleID=1

            foreach (var c in customers)
            {
                string userId = c.UserId.ToString();
                string hoTen = c.HoTen;

                FlowLayoutPanel customerMessages = new FlowLayoutPanel();
                customerMessages.Dock = DockStyle.Fill;
                customerMessages.FlowDirection = FlowDirection.TopDown;
                customerMessages.WrapContents = false;
                customerMessages.AutoScroll = true;

                chatPanels[userId] = customerMessages;

                Guna2Button btnCustomer = new Guna2Button();
                btnCustomer.Text = hoTen;
                btnCustomer.Width = 160;
                btnCustomer.Height = 40;
                btnCustomer.Margin = new Padding(5);

                btnCustomer.FillColor = Color.MediumSlateBlue;
                btnCustomer.ForeColor = Color.White;
                btnCustomer.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnCustomer.BorderRadius = 10;
                btnCustomer.UseTransparentBackground = true;
                btnCustomer.ShadowDecoration.Enabled = false;

                btnCustomer.Click += (s, e) =>
                {
                    LoadCustomer(userId);
                };

                panelCustomers.Controls.Add(btnCustomer);
            }

            if (chatPanels.Count > 0)
            {
                string firstUserId = new List<string>(chatPanels.Keys)[0];
                LoadCustomer(firstUserId);
            }
        }
        private void LoadCustomer(string customerId)
        {
            currentCustomer = customerId;
            lblHeader.Text = "Khách hàng: " + customerId;

            panelMessages.Controls.Clear();

            List<ChatMessage> messages;

            if (customerId == "14") // Chat chung
            {
                messages = dataHelper.GetMessagesByReceiver(14);
            }
            else // Chat riêng
            {
                messages = dataHelper.GetMessagesWithCustomer(int.Parse(customerId));
            }

            foreach (var msg in messages)
            {
                bool isStaff = msg.SenderId == staffId;
                AddMessage(isStaff ? "Staff" : "User", msg.Message, isStaff, customerId);
            }
        }

        public void AddMessage(string sender, string message, bool isStaff, string customerId)
        {
            Panel bubble = new Panel();
            bubble.AutoSize = true;
            bubble.MaximumSize = new Size(300, 0);
            bubble.Padding = new Padding(10);
            bubble.Margin = new Padding(8);

            bubble.BackColor = isStaff ? Color.DodgerBlue : Color.LightGray;

            Label lbl = new Label();
            lbl.Text = message;
            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(280, 0);
            lbl.Font = new Font("Segoe UI", 10);
            lbl.ForeColor = isStaff ? Color.White : Color.Black;

            bubble.Controls.Add(lbl);
            bubble.Anchor = isStaff ? AnchorStyles.Right : AnchorStyles.Left;

            // Thêm trực tiếp vào panelMessages
            panelMessages.Controls.Add(bubble);
            panelMessages.ScrollControlIntoView(bubble);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text) && !string.IsNullOrEmpty(currentCustomer))
            {
                string message = txtMessage.Text;

                // Lưu xuống DB qua DataHelper với staffId động
                dataHelper.SaveMessage(staffId, int.Parse(currentCustomer), message);

                // Hiển thị ngay
                AddMessage("Staff", message, true, currentCustomer);

                txtMessage.Clear();
            }
        }
    }
}