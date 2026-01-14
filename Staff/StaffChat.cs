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

        private readonly DatabaseHelper dataHelper = new DatabaseHelper(); 
        private readonly int staffId; 

        private Timer refreshTimer;

        public StaffChat(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
            SetupLayout();
            BuildCustomerList();

            refreshTimer = new Timer();
            refreshTimer.Interval = 9000; 
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
                LoadCustomer(currentCustomer); 
            }
        }

        private void SetupLayout()
        {
            splitMain = new SplitContainer();
            splitMain.Dock = DockStyle.Fill;
            splitMain.Orientation = Orientation.Vertical;
            splitMain.IsSplitterFixed = false;
            splitMain.SplitterWidth = 2;

            this.Controls.Clear();
            this.Controls.Add(splitMain);
            
            this.Load += (s, e) =>
            {
                splitMain.Panel1MinSize = 200;
                splitMain.Panel2MinSize = 300;
                
                if (this.Width > 600)
                    splitMain.SplitterDistance = 240;
                else
                    splitMain.SplitterDistance = 200;
            };

            Panel sidebarContainer = new Panel();
            sidebarContainer.Dock = DockStyle.Fill;
            sidebarContainer.BackColor = Color.FromArgb(248, 250, 252);

            Guna2Panel sidebarHeader = new Guna2Panel();
            sidebarHeader.Dock = DockStyle.Top;
            sidebarHeader.Height = 70;
            sidebarHeader.FillColor = Color.FromArgb(30, 58, 138); 
            sidebarHeader.ShadowDecoration.Enabled = true;
            sidebarHeader.ShadowDecoration.Depth = 8;
            sidebarHeader.ShadowDecoration.Color = Color.FromArgb(50, 0, 0, 0);
            
            Label lblSidebarTitle = new Label();
            lblSidebarTitle.Text = "Khách hàng";
            lblSidebarTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.White;
            lblSidebarTitle.AutoSize = true;
            lblSidebarTitle.Location = new Point(20, 22);
            sidebarHeader.Controls.Add(lblSidebarTitle);
            
            sidebarContainer.Controls.Add(sidebarHeader);
            
            // Customer list panel với background sáng
            panelCustomers = new FlowLayoutPanel();
            panelCustomers.Dock = DockStyle.Fill;
            panelCustomers.FlowDirection = FlowDirection.TopDown;
            panelCustomers.AutoScroll = true;
            panelCustomers.BackColor = Color.FromArgb(248, 250, 252);
            panelCustomers.Padding = new Padding(12, 15, 12, 15);
            panelCustomers.WrapContents = false;
            
            sidebarContainer.Controls.Add(panelCustomers);
            splitMain.Panel1.Controls.Add(sidebarContainer);

            panelMain.Dock = DockStyle.Fill;
            splitMain.Panel2.Controls.Add(panelMain);

            // Giữ cho vùng tin nhắn cập nhật chiều rộng khi form thay đổi
            panelMessages.SizeChanged += PanelMessages_SizeChanged;
        }

        private void BuildCustomerList()
        {
            var customers = dataHelper.GetCustomers(); 

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

                Guna2Panel customerItem = new Guna2Panel();
                customerItem.Width = 216;
                customerItem.Height = 68;
                customerItem.BorderRadius = 12;
                customerItem.FillColor = Color.White;
                customerItem.Margin = new Padding(0, 0, 0, 8);
                customerItem.Cursor = Cursors.Hand;
                customerItem.Tag = userId;
                customerItem.ShadowDecoration.Enabled = true;
                customerItem.ShadowDecoration.Depth = 3;
                customerItem.ShadowDecoration.Color = Color.FromArgb(20, 0, 0, 0);
                
                Guna2CirclePictureBox avatar = new Guna2CirclePictureBox();
                avatar.Size = new Size(42, 42);
                avatar.Location = new Point(12, 13);
                avatar.FillColor = Color.FromArgb(30, 58, 138);
                avatar.ShadowDecoration.Enabled = true;
                avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
                avatar.ShadowDecoration.Depth = 5;
                
                Label lblName = new Label();
                lblName.Text = hoTen;
                lblName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblName.ForeColor = Color.FromArgb(30, 41, 59); 
                lblName.AutoSize = true;
                lblName.MaximumSize = new Size(145, 0);
                lblName.Location = new Point(62, 14);
                lblName.Tag = userId;
                lblName.Cursor = Cursors.Hand;
                
                Label lblStatus = new Label();
                lblStatus.Text = "● Trực tuyến";
                lblStatus.Font = new Font("Segoe UI", 8.5F);
                lblStatus.ForeColor = Color.FromArgb(34, 197, 94); 
                lblStatus.AutoSize = true;
                lblStatus.Location = new Point(62, 36);
                
                customerItem.Controls.Add(avatar);
                customerItem.Controls.Add(lblName);
                customerItem.Controls.Add(lblStatus);
                
                customerItem.MouseEnter += (s, e) =>
                {
                    if (currentCustomer != userId)
                        customerItem.FillColor = Color.FromArgb(241, 245, 249); 
                };
                
                customerItem.MouseLeave += (s, e) =>
                {
                    if (currentCustomer != userId)
                        customerItem.FillColor = Color.White;
                };
                
                customerItem.Click += (s, e) =>
                {
                    LoadCustomer(userId);
                    foreach (Control ctrl in panelCustomers.Controls)
                    {
                        if (ctrl is Guna2Panel panel)
                        {
                            panel.FillColor = Color.White;
                        }
                    }
                    customerItem.FillColor = Color.FromArgb(219, 234, 254); 
                };
                
                lblName.Click += (s, e) =>
                {
                    LoadCustomer(userId);
                    foreach (Control ctrl in panelCustomers.Controls)
                    {
                        if (ctrl is Guna2Panel panel)
                        {
                            panel.FillColor = Color.White;
                        }
                    }
                    customerItem.FillColor = Color.FromArgb(219, 234, 254);
                };

                panelCustomers.Controls.Add(customerItem);
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
            var customers = dataHelper.GetCustomers();
            string customerName = customerId;
            foreach (var c in customers)
            {
                if (c.UserId.ToString() == customerId)
                {
                    customerName = c.HoTen;
                    break;
                }
            }
            
            lblHeader.Text = customerName;

            panelMessages.Controls.Clear();

            List<ChatMessage> messages;

            if (customerId == "14")
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
            FlowLayoutPanel messageWrapper = new FlowLayoutPanel();
            int availableWidth = panelMessages.ClientSize.Width - panelMessages.Padding.Horizontal;
            messageWrapper.Width = availableWidth > 0 ? availableWidth : 100;
            messageWrapper.FlowDirection = FlowDirection.LeftToRight;
            messageWrapper.WrapContents = false;
            messageWrapper.AutoSize = false;
            messageWrapper.Tag = isStaff; 
            messageWrapper.Margin = new Padding(0, 6, 0, 6);
            messageWrapper.Padding = new Padding(0);

            Guna2Panel bubble = new Guna2Panel();
            bubble.AutoSize = true;
            bubble.MaximumSize = new Size(520, 0);
            bubble.MinimumSize = new Size(80, 36);
            bubble.Padding = new Padding(14, 10, 14, 10);
            bubble.BorderRadius = 12;
            
            if (isStaff)
            {
                bubble.FillColor = Color.FromArgb(30, 58, 138);
            }
            else
            {
                bubble.FillColor = Color.White; 
                bubble.BorderColor = Color.FromArgb(226, 232, 240);
                bubble.BorderThickness = 1;
            }
            
            bubble.ShadowDecoration.Enabled = true;
            bubble.ShadowDecoration.Depth = 4;
            bubble.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);

            Label lbl = new Label();
            lbl.Text = message;
            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(490, 0);
            lbl.Font = new Font("Segoe UI", 10F);
            lbl.ForeColor = isStaff ? Color.White : Color.FromArgb(30, 41, 59);
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Copy", null, (s, e) => Clipboard.SetText(lbl.Text));
            lbl.ContextMenuStrip = contextMenu;

            bubble.Controls.Add(lbl);
            messageWrapper.Controls.Add(bubble);

            bubble.PerformLayout();
            int bubbleWidth = bubble.PreferredSize.Width;
            int leftPadding = isStaff ? Math.Max(0, messageWrapper.Width - bubbleWidth) : 0;
            bubble.Margin = new Padding(leftPadding, bubble.Margin.Top, bubble.Margin.Right, bubble.Margin.Bottom);

            messageWrapper.Height = bubble.PreferredSize.Height + messageWrapper.Margin.Vertical;
            
            panelMessages.Controls.Add(messageWrapper);
            panelMessages.ScrollControlIntoView(messageWrapper);
        }

        private void PanelMessages_SizeChanged(object sender, EventArgs e)
        {
            int availableWidth = panelMessages.ClientSize.Width - panelMessages.Padding.Horizontal;
            foreach (Control ctrl in panelMessages.Controls)
            {
                if (ctrl is FlowLayoutPanel flp)
                {
                    flp.Width = availableWidth > 0 ? availableWidth : flp.Width;

                    bool isStaff = flp.Tag is bool b && b;
                    foreach (Control child in flp.Controls)
                    {
                        if (child is Guna2Panel bubble)
                        {
                            bubble.PerformLayout();
                            int bubbleWidth = bubble.PreferredSize.Width;
                            int leftPadding = isStaff ? Math.Max(0, flp.Width - bubbleWidth) : 0;
                            bubble.Margin = new Padding(leftPadding, bubble.Margin.Top, bubble.Margin.Right, bubble.Margin.Bottom);
                        }
                    }
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text) && !string.IsNullOrEmpty(currentCustomer))
            {
                string message = txtMessage.Text;

                dataHelper.SaveMessage(staffId, int.Parse(currentCustomer), message);

                AddMessage("Staff", message, true, currentCustomer);

                txtMessage.Clear();
            }
        }
    }
}