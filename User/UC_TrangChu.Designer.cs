namespace MovieTicketApp
{
    partial class UC_TrangChu
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBanner;
        private System.Windows.Forms.Timer timerBanner;
        private System.Windows.Forms.FlowLayoutPanel flowPhimHot;
        private System.Windows.Forms.FlowLayoutPanel flowRecommend;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblRecommend;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;

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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TrangChu));
            this.pictureBanner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timerBanner = new System.Windows.Forms.Timer(this.components);
            this.flowPhimHot = new System.Windows.Forms.FlowLayoutPanel();
            this.flowRecommend = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblRecommend = new System.Windows.Forms.Label();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBanner
            // 
            this.guna2Transition1.SetDecoration(this.pictureBanner, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBanner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBanner.ImageRotate = 0F;
            this.pictureBanner.Location = new System.Drawing.Point(0, 0);
            this.pictureBanner.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBanner.Name = "pictureBanner";
            this.pictureBanner.Size = new System.Drawing.Size(792, 300);
            this.pictureBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBanner.TabIndex = 0;
            this.pictureBanner.TabStop = false;
            this.pictureBanner.Click += new System.EventHandler(this.pictureBanner_Click);
            // 
            // timerBanner
            // 
            this.timerBanner.Interval = 3500;
            this.timerBanner.Tick += new System.EventHandler(this.timerBanner_Tick);
            // 
            // flowPhimHot
            // 
            this.flowPhimHot.AutoScroll = true;
            this.flowPhimHot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Transition1.SetDecoration(this.flowPhimHot, Guna.UI2.AnimatorNS.DecorationType.None);
            this.flowPhimHot.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPhimHot.Location = new System.Drawing.Point(0, 340);
            this.flowPhimHot.Name = "flowPhimHot";
            this.flowPhimHot.Padding = new System.Windows.Forms.Padding(10);
            this.flowPhimHot.Size = new System.Drawing.Size(792, 270);
            this.flowPhimHot.TabIndex = 4;
            this.flowPhimHot.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPhimHot_Paint);
            // 
            // flowRecommend
            // 
            this.flowRecommend.AutoScroll = true;
            this.flowRecommend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Transition1.SetDecoration(this.flowRecommend, Guna.UI2.AnimatorNS.DecorationType.None);
            this.flowRecommend.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowRecommend.Location = new System.Drawing.Point(0, 650);
            this.flowRecommend.Name = "flowRecommend";
            this.flowRecommend.Padding = new System.Windows.Forms.Padding(10);
            this.flowRecommend.Size = new System.Drawing.Size(792, 180);
            this.flowRecommend.TabIndex = 6;
            // 
            // lblTieuDe
            // 
            this.guna2Transition1.SetDecoration(this.lblTieuDe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 300);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(792, 40);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "🎬 PHIM HOT TRONG TUẦN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecommend
            // 
            this.guna2Transition1.SetDecoration(this.lblRecommend, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRecommend.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecommend.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblRecommend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblRecommend.Location = new System.Drawing.Point(0, 610);
            this.lblRecommend.Name = "lblRecommend";
            this.lblRecommend.Size = new System.Drawing.Size(792, 40);
            this.lblRecommend.TabIndex = 8;
            this.lblRecommend.Text = "🎯 GỢI Ý PHIM CHO BẠN";
            this.lblRecommend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // UC_TrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowRecommend);
            this.Controls.Add(this.lblRecommend);
            this.Controls.Add(this.flowPhimHot);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.pictureBanner);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "UC_TrangChu";
            this.Size = new System.Drawing.Size(792, 774);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
