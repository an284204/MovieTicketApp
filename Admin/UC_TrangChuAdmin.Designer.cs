using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class UC_TrangChuAdmin
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnSaveAll;

        private Guna.UI2.WinForms.Guna2Panel bannerPanel1, bannerPanel2, bannerPanel3, bannerPanel4, bannerPanel5;
        private PictureBox pb1, pb2, pb3, pb4, pb5;
        private Guna.UI2.WinForms.Guna2Button btnSelect1, btnSelect2, btnSelect3, btnSelect4, btnSelect5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWelcome = new Label();
            this.lblSubtitle = new Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Label();
            this.btnSaveAll = new Guna.UI2.WinForms.Guna2Button();

            this.bannerPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bannerPanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.bannerPanel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.bannerPanel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.bannerPanel5 = new Guna.UI2.WinForms.Guna2Panel();

            this.pb1 = new PictureBox();
            this.pb2 = new PictureBox();
            this.pb3 = new PictureBox();
            this.pb4 = new PictureBox();
            this.pb5 = new PictureBox();

            this.btnSelect1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelect2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelect3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelect4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelect5 = new Guna.UI2.WinForms.Guna2Button();

            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            // panelTop - Header with gradient effect
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Height = 100;
            this.panelTop.FillColor = System.Drawing.Color.White;
            this.panelTop.BorderRadius = 0;
            this.panelTop.ShadowDecoration.Enabled = true;
            this.panelTop.ShadowDecoration.Depth = 20;
            this.panelTop.ShadowDecoration.Color = System.Drawing.Color.FromArgb(30, 0, 0, 0);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Controls.Add(this.lblWelcome);

            // lblWelcome - Main title
            this.lblWelcome.Text = "Quản Lý Banner Trang Chủ";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(30, 35, 48);
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(30, 22);

            // lblSubtitle - Subtitle
            this.lblSubtitle.Text = "Thiết lập hình ảnh quảng cáo hiển thị trên màn hình chính của ứng dụng";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 140);
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(32, 62);

            // panelMain
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Padding = new Padding(25);
            this.panelMain.AutoScroll = true;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.btnSaveAll);

            // lblTitle - hidden, not needed anymore
            this.lblTitle.Text = "";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 120);
            this.lblTitle.Location = new System.Drawing.Point(25, 5);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Visible = false;

            // btnSaveAll
            this.btnSaveAll.Text = "Luu tat ca";
            this.btnSaveAll.FillColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.Size = new System.Drawing.Size(200, 50);
            this.btnSaveAll.BorderRadius = 12;
            this.btnSaveAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnSaveAll.Location = new System.Drawing.Point(25, 870);
            this.btnSaveAll.ShadowDecoration.Enabled = true;
            this.btnSaveAll.ShadowDecoration.Depth = 10;
            this.btnSaveAll.ShadowDecoration.Color = System.Drawing.Color.FromArgb(50, 40, 167, 69);
            this.btnSaveAll.HoverState.FillColor = System.Drawing.Color.FromArgb(50, 190, 85);
            this.btnSaveAll.Animated = true;

            // Form/UserControl
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Size = new System.Drawing.Size(1050, 745);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
