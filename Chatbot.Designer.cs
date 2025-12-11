namespace MovieTicketApp
{
    partial class Chatbot
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel chatPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtInput;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private System.Windows.Forms.Panel bottomPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.chatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatPanel
            // 
            this.chatPanel.AutoScroll = true;
            this.chatPanel.BackColor = System.Drawing.Color.White;
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatPanel.Location = new System.Drawing.Point(0, 0);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Padding = new System.Windows.Forms.Padding(5);
            this.chatPanel.Size = new System.Drawing.Size(400, 335);
            this.chatPanel.TabIndex = 0;
            this.chatPanel.WrapContents = false;
            // 
            // txtInput
            // 
            this.txtInput.BorderColor = System.Drawing.Color.Gray;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.DefaultText = "";
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInput.Location = new System.Drawing.Point(5, 5);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.PlaceholderText = "Nhập câu hỏi...";
            this.txtInput.SelectedText = "";
            this.txtInput.Size = new System.Drawing.Size(280, 35);
            this.txtInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 8;
            this.btnSend.FillColor = System.Drawing.Color.OrangeRed;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSend.Location = new System.Drawing.Point(290, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 35);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Gửi";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.txtInput);
            this.bottomPanel.Controls.Add(this.btnSend);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 335);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(400, 45);
            this.bottomPanel.TabIndex = 3;
            // 
            // Chatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "Chatbot";
            this.Text = "Bot";
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}