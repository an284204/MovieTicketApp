namespace MovieTicketApp
{
    partial class UC_TrangChu
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelBannerContainer;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBanner;
        private System.Windows.Forms.Panel panelOverlay;
        private System.Windows.Forms.Label lblBannerTitle;
        private System.Windows.Forms.Label lblBannerGenre;
        private System.Windows.Forms.Label lblBannerDescription;
        private Guna.UI2.WinForms.Guna2Button btnPlayNow;
        private Guna.UI2.WinForms.Guna2Button btnMoreInfo;
        private System.Windows.Forms.Timer timerBanner;
        private Guna.UI2.WinForms.Guna2Panel panelMiniCarousel;
        private Guna.UI2.WinForms.Guna2PictureBox[] miniPictures;
        private Guna.UI2.WinForms.Guna2Button btnCarouselPrev;
        private Guna.UI2.WinForms.Guna2Button btnCarouselNext;
        private System.Windows.Forms.FlowLayoutPanel flowPhimHot;
        private System.Windows.Forms.FlowLayoutPanel flowRecommend;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblRecommend;

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
            this.components = new System.ComponentModel.Container();
            this.panelBannerContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBanner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMiniCarousel = new Guna.UI2.WinForms.Guna2Panel();
            this.panelOverlay = new System.Windows.Forms.Panel();
            this.btnMoreInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlayNow = new Guna.UI2.WinForms.Guna2Button();
            this.lblBannerDescription = new System.Windows.Forms.Label();
            this.lblBannerGenre = new System.Windows.Forms.Label();
            this.lblBannerTitle = new System.Windows.Forms.Label();
            this.btnCarouselNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnCarouselPrev = new Guna.UI2.WinForms.Guna2Button();
            this.timerBanner = new System.Windows.Forms.Timer(this.components);
            this.flowPhimHot = new System.Windows.Forms.FlowLayoutPanel();
            this.flowRecommend = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblRecommend = new System.Windows.Forms.Label();
            this.panelBannerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanner)).BeginInit();
            this.panelMiniCarousel.SuspendLayout();
            this.panelOverlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBannerContainer
            // 
            this.panelBannerContainer.Controls.Add(this.pictureBanner);
            this.panelBannerContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBannerContainer.Location = new System.Drawing.Point(0, 0);
            this.panelBannerContainer.Name = "panelBannerContainer";
            this.panelBannerContainer.Size = new System.Drawing.Size(1580, 0);
            this.panelBannerContainer.TabIndex = 0;
            this.panelBannerContainer.Visible = false;
            // 
            // pictureBanner
            // 
            this.pictureBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBanner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.pictureBanner.ImageRotate = 0F;
            this.pictureBanner.Location = new System.Drawing.Point(0, 0);
            this.pictureBanner.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBanner.Name = "pictureBanner";
            this.pictureBanner.Size = new System.Drawing.Size(1580, 0);
            this.pictureBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBanner.TabIndex = 0;
            this.pictureBanner.TabStop = false;
            // 
            // panelMiniCarousel
            // 
            this.panelMiniCarousel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panelMiniCarousel.Controls.Add(this.panelOverlay);
            this.panelMiniCarousel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMiniCarousel.Location = new System.Drawing.Point(0, 0);
            this.panelMiniCarousel.Name = "panelMiniCarousel";
            this.panelMiniCarousel.Size = new System.Drawing.Size(1580, 500);
            this.panelMiniCarousel.TabIndex = 2;
            // 
            // panelOverlay
            // 
            this.panelOverlay.BackColor = System.Drawing.Color.Transparent;
            this.panelOverlay.Controls.Add(this.btnMoreInfo);
            this.panelOverlay.Controls.Add(this.btnPlayNow);
            this.panelOverlay.Controls.Add(this.lblBannerDescription);
            this.panelOverlay.Controls.Add(this.lblBannerGenre);
            this.panelOverlay.Controls.Add(this.lblBannerTitle);
            this.panelOverlay.Dock = System.Windows.Forms.DockStyle.None;
            this.panelOverlay.Location = new System.Drawing.Point(50, 60);
            this.panelOverlay.Name = "panelOverlay";
            this.panelOverlay.Size = new System.Drawing.Size(900, 420);
            this.panelOverlay.TabIndex = 10;
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.BorderRadius = 8;
            this.btnMoreInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoreInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoreInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoreInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoreInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMoreInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMoreInfo.ForeColor = System.Drawing.Color.White;
            this.btnMoreInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnMoreInfo.Location = new System.Drawing.Point(250, 360);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(180, 50);
            this.btnMoreInfo.TabIndex = 4;
            this.btnMoreInfo.Text = "ℹ Thông tin";
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // btnPlayNow
            // 
            this.btnPlayNow.BorderRadius = 8;
            this.btnPlayNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlayNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlayNow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnPlayNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlayNow.ForeColor = System.Drawing.Color.White;
            this.btnPlayNow.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnPlayNow.Location = new System.Drawing.Point(50, 360);
            this.btnPlayNow.Name = "btnPlayNow";
            this.btnPlayNow.Size = new System.Drawing.Size(180, 50);
            this.btnPlayNow.TabIndex = 3;
            this.btnPlayNow.Text = "Đặt vé ngay";
            this.btnPlayNow.Click += new System.EventHandler(this.btnPlayNow_Click);
            // 
            // lblBannerDescription
            // 
            this.lblBannerDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblBannerDescription.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblBannerDescription.ForeColor = System.Drawing.Color.White;
            this.lblBannerDescription.Location = new System.Drawing.Point(50, 300);
            this.lblBannerDescription.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblBannerDescription.Name = "lblBannerDescription";
            this.lblBannerDescription.Size = new System.Drawing.Size(700, 100);
            this.lblBannerDescription.TabIndex = 2;
            this.lblBannerDescription.Text = "Một câu chuyện cảm động về tình cha con...";
            // 
            // lblBannerGenre
            // 
            this.lblBannerGenre.AutoSize = true;
            this.lblBannerGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblBannerGenre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBannerGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.lblBannerGenre.Location = new System.Drawing.Point(50, 260);
            this.lblBannerGenre.Name = "lblBannerGenre";
            this.lblBannerGenre.Size = new System.Drawing.Size(200, 28);
            this.lblBannerGenre.TabIndex = 1;
            this.lblBannerGenre.Text = "Hành động | Viễn tưởng | 181 phút";
            // 
            // lblBannerTitle
            // 
            this.lblBannerTitle.AutoSize = true;
            this.lblBannerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBannerTitle.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Bold);
            this.lblBannerTitle.ForeColor = System.Drawing.Color.White;
            this.lblBannerTitle.Location = new System.Drawing.Point(30, 120);
            this.lblBannerTitle.Name = "lblBannerTitle";
            this.lblBannerTitle.Size = new System.Drawing.Size(628, 112);
            this.lblBannerTitle.TabIndex = 0;
            this.lblBannerTitle.Text = "Avengers: Endgame";
            // 
            // timerBanner
            // 
            this.timerBanner.Interval = 5000;
            this.timerBanner.Tick += new System.EventHandler(this.timerBanner_Tick);
            // 
            // flowPhimHot
            // 
            this.flowPhimHot.AutoScroll = true;
            this.flowPhimHot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.flowPhimHot.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPhimHot.Location = new System.Drawing.Point(0, 550);
            this.flowPhimHot.Name = "flowPhimHot";
            this.flowPhimHot.Padding = new System.Windows.Forms.Padding(20);
            this.flowPhimHot.Size = new System.Drawing.Size(1580, 340);
            this.flowPhimHot.TabIndex = 4;
            // 
            // flowRecommend
            // 
            this.flowRecommend.AutoScroll = true;
            this.flowRecommend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.flowRecommend.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowRecommend.Location = new System.Drawing.Point(0, 940);
            this.flowRecommend.Name = "flowRecommend";
            this.flowRecommend.Padding = new System.Windows.Forms.Padding(20);
            this.flowRecommend.Size = new System.Drawing.Size(1580, 340);
            this.flowRecommend.TabIndex = 6;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 500);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblTieuDe.Size = new System.Drawing.Size(1580, 50);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "🔥 PHIM HOT TRONG TUẦN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecommend
            // 
            this.lblRecommend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lblRecommend.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecommend.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRecommend.ForeColor = System.Drawing.Color.White;
            this.lblRecommend.Location = new System.Drawing.Point(0, 890);
            this.lblRecommend.Name = "lblRecommend";
            this.lblRecommend.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblRecommend.Size = new System.Drawing.Size(1580, 50);
            this.lblRecommend.TabIndex = 8;
            this.lblRecommend.Text = "🎯 GỢI Ý PHIM CHO BẠN";
            this.lblRecommend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_TrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.flowRecommend);
            this.Controls.Add(this.lblRecommend);
            this.Controls.Add(this.flowPhimHot);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.panelMiniCarousel);
            this.Controls.Add(this.panelBannerContainer);
            this.Name = "UC_TrangChu";
            this.Size = new System.Drawing.Size(1580, 1400);
            this.panelBannerContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanner)).EndInit();
            this.panelMiniCarousel.ResumeLayout(false);
            this.panelOverlay.ResumeLayout(false);
            this.panelOverlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
