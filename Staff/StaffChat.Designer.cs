namespace MovieTicketApp
{
    partial class StaffChat
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel panelMessages;
        private Guna.UI2.WinForms.Guna2Panel panelInput;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private System.Windows.Forms.Label lblHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInput = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panelMain.BorderRadius = 0;
            this.panelMain.BorderThickness = 0;
            this.panelMain.Controls.Add(this.panelMessages);
            this.panelMain.Controls.Add(this.panelInput);
            this.panelMain.Controls.Add(this.lblHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(0);
            this.panelMain.Size = new System.Drawing.Size(600, 600);
            this.panelMain.TabIndex = 0;
            // 
            // panelMessages
            // 
            this.panelMessages.AutoScroll = true;
            this.panelMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMessages.Location = new System.Drawing.Point(0, 70);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.panelMessages.Size = new System.Drawing.Size(600, 480);
            this.panelMessages.TabIndex = 0;
            this.panelMessages.WrapContents = false;

            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.FillColor = System.Drawing.Color.White;
            this.panelInput.Location = new System.Drawing.Point(0, 530);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.panelInput.ShadowDecoration.Enabled = true;
            this.panelInput.ShadowDecoration.Depth = 6;
            this.panelInput.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelInput.Size = new System.Drawing.Size(600, 70);
            this.panelInput.TabIndex = 4;
            this.panelInput.Controls.Add(this.txtMessage);
            this.panelInput.Controls.Add(this.btnSend);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtMessage.BorderRadius = 10;
            this.txtMessage.BorderThickness = 2;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtMessage.Location = new System.Drawing.Point(16, 16);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtMessage.PlaceholderText = "Nhập tin nhắn...";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(450, 38);
            this.txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Animated = true;
            this.btnSend.BorderRadius = 10;
            this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnSend.Location = new System.Drawing.Point(476, 16);
            this.btnSend.Name = "btnSend";
            this.btnSend.ShadowDecoration.Enabled = true;
            this.btnSend.ShadowDecoration.Depth = 5;
            this.btnSend.Size = new System.Drawing.Size(108, 38);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Gửi";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(600, 70);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Khách hàng";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaffChat
            // 
            this.Controls.Add(this.panelMain);
            this.Name = "StaffChat";
            this.Size = new System.Drawing.Size(600, 600);
            this.panelMain.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}