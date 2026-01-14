namespace MovieTicketApp
{
    partial class TestTicket
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelInput = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaVe = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.cardInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPhimTitle = new System.Windows.Forms.Label();
            this.lblPhimValue = new System.Windows.Forms.Label();
            this.lblNgayTitle = new System.Windows.Forms.Label();
            this.lblNgayValue = new System.Windows.Forms.Label();
            this.lblGioTitle = new System.Windows.Forms.Label();
            this.lblGioValue = new System.Windows.Forms.Label();
            this.lblPhongTitle = new System.Windows.Forms.Label();
            this.lblPhongValue = new System.Windows.Forms.Label();
            this.lblRapTitle = new System.Windows.Forms.Label();
            this.lblRapValue = new System.Windows.Forms.Label();
            this.lblGheTitle = new System.Windows.Forms.Label();
            this.lblGheValue = new System.Windows.Forms.Label();
            this.panelTrangThai = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrangThaiTitle = new System.Windows.Forms.Label();
            this.lblTrangThaiValue = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.cardInfo.SuspendLayout();
            this.panelTrangThai.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.headerPanel.Controls.Add(this.lblHeader);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(900, 60);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "KIỂM TRA VÉ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInput
            // 
            this.panelInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInput.BackColor = System.Drawing.Color.Transparent;
            this.panelInput.Controls.Add(this.txtMaVe);
            this.panelInput.Controls.Add(this.btnCheck);
            this.panelInput.Controls.Add(this.btnXacNhan);
            this.panelInput.FillColor = System.Drawing.Color.Transparent;
            this.panelInput.Location = new System.Drawing.Point(30, 85);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(840, 70);
            this.panelInput.TabIndex = 1;
            // 
            // txtMaVe
            // 
            this.txtMaVe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaVe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtMaVe.BorderRadius = 12;
            this.txtMaVe.BorderThickness = 2;
            this.txtMaVe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaVe.DefaultText = "";
            this.txtMaVe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaVe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaVe.FillColor = System.Drawing.Color.White;
            this.txtMaVe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtMaVe.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtMaVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtMaVe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtMaVe.Location = new System.Drawing.Point(0, 10);
            this.txtMaVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.PasswordChar = '\0';
            this.txtMaVe.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaVe.PlaceholderText = "Nhập mã vé...";
            this.txtMaVe.SelectedText = "";
            this.txtMaVe.Size = new System.Drawing.Size(460, 50);
            this.txtMaVe.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Animated = true;
            this.btnCheck.BorderRadius = 12;
            this.btnCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCheck.Location = new System.Drawing.Point(480, 10);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(160, 50);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.Animated = true;
            this.btnXacNhan.BorderRadius = 12;
            this.btnXacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnXacNhan.Location = new System.Drawing.Point(660, 10);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(160, 50);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận vé";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cardInfo
            // 
            this.cardInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardInfo.BackColor = System.Drawing.Color.White;
            this.cardInfo.BorderRadius = 16;
            this.cardInfo.Controls.Add(this.lblPhimTitle);
            this.cardInfo.Controls.Add(this.lblPhimValue);
            this.cardInfo.Controls.Add(this.lblNgayTitle);
            this.cardInfo.Controls.Add(this.lblNgayValue);
            this.cardInfo.Controls.Add(this.lblGioTitle);
            this.cardInfo.Controls.Add(this.lblGioValue);
            this.cardInfo.Controls.Add(this.lblPhongTitle);
            this.cardInfo.Controls.Add(this.lblPhongValue);
            this.cardInfo.Controls.Add(this.lblRapTitle);
            this.cardInfo.Controls.Add(this.lblRapValue);
            this.cardInfo.Controls.Add(this.lblGheTitle);
            this.cardInfo.Controls.Add(this.lblGheValue);
            this.cardInfo.Controls.Add(this.panelTrangThai);
            this.cardInfo.FillColor = System.Drawing.Color.White;
            this.cardInfo.Location = new System.Drawing.Point(30, 175);
            this.cardInfo.Name = "cardInfo";
            this.cardInfo.ShadowDecoration.Enabled = true;
            this.cardInfo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardInfo.ShadowDecoration.Depth = 15;
            this.cardInfo.Size = new System.Drawing.Size(840, 395);
            this.cardInfo.TabIndex = 2;
            // 
            // lblPhimTitle
            // 
            this.lblPhimTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lblPhimTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPhimTitle.Location = new System.Drawing.Point(40, 35);
            this.lblPhimTitle.Name = "lblPhimTitle";
            this.lblPhimTitle.Size = new System.Drawing.Size(130, 30);
            this.lblPhimTitle.TabIndex = 0;
            this.lblPhimTitle.Text = "Phim:";
            // 
            // lblPhimValue
            // 
            this.lblPhimValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhimValue.AutoEllipsis = true;
            this.lblPhimValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPhimValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblPhimValue.Location = new System.Drawing.Point(180, 35);
            this.lblPhimValue.Name = "lblPhimValue";
            this.lblPhimValue.Size = new System.Drawing.Size(600, 30);
            this.lblPhimValue.TabIndex = 1;
            this.lblPhimValue.Text = "---";
            // 
            // lblNgayTitle
            // 
            this.lblNgayTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lblNgayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblNgayTitle.Location = new System.Drawing.Point(40, 80);
            this.lblNgayTitle.Name = "lblNgayTitle";
            this.lblNgayTitle.Size = new System.Drawing.Size(130, 30);
            this.lblNgayTitle.TabIndex = 2;
            this.lblNgayTitle.Text = "Ngày chiếu:";
            // 
            // lblNgayValue
            // 
            this.lblNgayValue.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblNgayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblNgayValue.Location = new System.Drawing.Point(180, 80);
            this.lblNgayValue.Name = "lblNgayValue";
            this.lblNgayValue.Size = new System.Drawing.Size(250, 30);
            this.lblNgayValue.TabIndex = 3;
            this.lblNgayValue.Text = "---";
            // 
            // lblGioTitle
            // 
            this.lblGioTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lblGioTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblGioTitle.Location = new System.Drawing.Point(40, 125);
            this.lblGioTitle.Name = "lblGioTitle";
            this.lblGioTitle.Size = new System.Drawing.Size(130, 30);
            this.lblGioTitle.TabIndex = 4;
            this.lblGioTitle.Text = "Giờ chiếu:";
            // 
            // lblGioValue
            // 
            this.lblGioValue.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblGioValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblGioValue.Location = new System.Drawing.Point(180, 125);
            this.lblGioValue.Name = "lblGioValue";
            this.lblGioValue.Size = new System.Drawing.Size(250, 30);
            this.lblGioValue.TabIndex = 5;
            this.lblGioValue.Text = "---";
            // 
            // lblPhongTitle
            // 
            this.lblPhongTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lblPhongTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPhongTitle.Location = new System.Drawing.Point(430, 80);
            this.lblPhongTitle.Name = "lblPhongTitle";
            this.lblPhongTitle.Size = new System.Drawing.Size(130, 30);
            this.lblPhongTitle.TabIndex = 6;
            this.lblPhongTitle.Text = "Phòng:";
            // 
            // lblPhongValue
            // 
            this.lblPhongValue.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPhongValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblPhongValue.Location = new System.Drawing.Point(560, 80);
            this.lblPhongValue.Name = "lblPhongValue";
            this.lblPhongValue.Size = new System.Drawing.Size(200, 30);
            this.lblPhongValue.TabIndex = 7;
            this.lblPhongValue.Text = "---";
            // 
            // lblRapTitle
            // 
            this.lblRapTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lblRapTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblRapTitle.Location = new System.Drawing.Point(430, 125);
            this.lblRapTitle.Name = "lblRapTitle";
            this.lblRapTitle.Size = new System.Drawing.Size(130, 30);
            this.lblRapTitle.TabIndex = 8;
            this.lblRapTitle.Text = "Rạp:";
            // 
            // lblRapValue
            // 
            this.lblRapValue.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblRapValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblRapValue.Location = new System.Drawing.Point(560, 125);
            this.lblRapValue.Name = "lblRapValue";
            this.lblRapValue.Size = new System.Drawing.Size(200, 30);
            this.lblRapValue.TabIndex = 9;
            this.lblRapValue.Text = "---";
            // 
            // lblGheTitle
            // 
            this.lblGheTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lblGheTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblGheTitle.Location = new System.Drawing.Point(40, 170);
            this.lblGheTitle.Name = "lblGheTitle";
            this.lblGheTitle.Size = new System.Drawing.Size(130, 30);
            this.lblGheTitle.TabIndex = 10;
            this.lblGheTitle.Text = "Ghế:";
            // 
            // lblGheValue
            // 
            this.lblGheValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblGheValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblGheValue.Location = new System.Drawing.Point(180, 170);
            this.lblGheValue.Name = "lblGheValue";
            this.lblGheValue.Size = new System.Drawing.Size(580, 30);
            this.lblGheValue.TabIndex = 11;
            this.lblGheValue.Text = "---";
            // 
            // panelTrangThai
            // 
            this.panelTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelTrangThai.BorderRadius = 12;
            this.panelTrangThai.Controls.Add(this.lblTrangThaiTitle);
            this.panelTrangThai.Controls.Add(this.lblTrangThaiValue);
            this.panelTrangThai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelTrangThai.Location = new System.Drawing.Point(40, 250);
            this.panelTrangThai.Name = "panelTrangThai";
            this.panelTrangThai.Size = new System.Drawing.Size(760, 100);
            this.panelTrangThai.TabIndex = 12;
            // 
            // lblTrangThaiTitle
            // 
            this.lblTrangThaiTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.lblTrangThaiTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTrangThaiTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTrangThaiTitle.Name = "lblTrangThaiTitle";
            this.lblTrangThaiTitle.Size = new System.Drawing.Size(150, 30);
            this.lblTrangThaiTitle.TabIndex = 0;
            this.lblTrangThaiTitle.Text = "Trạng thái:";
            // 
            // lblTrangThaiValue
            // 
            this.lblTrangThaiValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrangThaiValue.AutoEllipsis = true;
            this.lblTrangThaiValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTrangThaiValue.ForeColor = System.Drawing.Color.Gray;
            this.lblTrangThaiValue.Location = new System.Drawing.Point(30, 50);
            this.lblTrangThaiValue.Name = "lblTrangThaiValue";
            this.lblTrangThaiValue.Size = new System.Drawing.Size(700, 45);
            this.lblTrangThaiValue.TabIndex = 1;
            this.lblTrangThaiValue.Text = "Chưa kiểm tra";
            this.lblTrangThaiValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.cardInfo);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.headerPanel);
            this.Name = "TestTicket";
            this.Size = new System.Drawing.Size(900, 600);
            this.headerPanel.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.cardInfo.ResumeLayout(false);
            this.panelTrangThai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Panel panelInput;
        private Guna.UI2.WinForms.Guna2TextBox txtMaVe;
        private Guna.UI2.WinForms.Guna2Button btnCheck;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2Panel cardInfo;
        private System.Windows.Forms.Label lblPhimTitle;
        private System.Windows.Forms.Label lblPhimValue;
        private System.Windows.Forms.Label lblNgayTitle;
        private System.Windows.Forms.Label lblNgayValue;
        private System.Windows.Forms.Label lblGioTitle;
        private System.Windows.Forms.Label lblGioValue;
        private System.Windows.Forms.Label lblPhongTitle;
        private System.Windows.Forms.Label lblPhongValue;
        private System.Windows.Forms.Label lblRapTitle;
        private System.Windows.Forms.Label lblRapValue;
        private System.Windows.Forms.Label lblGheTitle;
        private System.Windows.Forms.Label lblGheValue;
        private Guna.UI2.WinForms.Guna2Panel panelTrangThai;
        private System.Windows.Forms.Label lblTrangThaiTitle;
        private System.Windows.Forms.Label lblTrangThaiValue;
    }
}
