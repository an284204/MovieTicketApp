namespace MovieTicketApp
{
    partial class UC_Hotro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel panelMessages;
        private Guna.UI2.WinForms.Guna2Panel panelInput;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private Guna.UI2.WinForms.Guna2Button btnSend;

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
            this.panelMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInput = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMessages
            // 
            this.panelMessages.AutoScroll = true;
            this.panelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMessages.Location = new System.Drawing.Point(0, 0);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(900, 650);
            this.panelMessages.TabIndex = 0;
            this.panelMessages.WrapContents = false;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.txtMessage);
            this.panelInput.Controls.Add(this.btnSend);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 650);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(900, 50);
            this.panelInput.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderRadius = 8;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PlaceholderText = "Nhập tin nhắn...";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(820, 50);
            this.txtMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 8;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(820, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 50);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // UC_Hotro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.panelInput);
            this.Name = "UC_Hotro";
            this.Size = new System.Drawing.Size(900, 700);
            this.panelInput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}