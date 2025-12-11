namespace MovieTicketApp
{
    partial class StaffChat
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel panelMessages;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeader;

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
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.lblHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderColor = System.Drawing.Color.Gray;
            this.panelMain.BorderRadius = 10;
            this.panelMain.BorderThickness = 1;
            this.panelMain.Controls.Add(this.panelMessages);
            this.panelMain.Controls.Add(this.txtMessage);
            this.panelMain.Controls.Add(this.btnSend);
            this.panelMain.Controls.Add(this.lblHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(600, 600);
            this.panelMain.TabIndex = 0;
            // 
            // panelMessages
            // 
            this.panelMessages.AutoScroll = true;
            this.panelMessages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMessages.Location = new System.Drawing.Point(10, 40);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(560, 460);
            this.panelMessages.TabIndex = 0;
            this.panelMessages.WrapContents = false;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderRadius = 8;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessage.Location = new System.Drawing.Point(11, 540);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PlaceholderText = "Nhập tin nhắn...";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(400, 50);
            this.txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 8;
            this.btnSend.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(440, 540);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 50);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Gửi";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(10, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(136, 34);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Khách hàng";
            // 
            // StaffChat
            // 
            this.Controls.Add(this.panelMain);
            this.Name = "StaffChat";
            this.Size = new System.Drawing.Size(600, 600);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
    }
}