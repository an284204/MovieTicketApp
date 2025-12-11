using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class UC_TrangChuAdmin
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Label lblWelcome;
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
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Height = 80;
            this.panelTop.FillColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.panelTop.Controls.Add(this.lblWelcome);

            // lblWelcome
            this.lblWelcome.Text = "Xin chào, Quản lý 👋";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);

            // panelMain
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Padding = new Padding(20);
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.lblTitle);

            // lblTitle
            this.lblTitle.Text = "Quản lý Banner Trang Chủ (5 ảnh)";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.AutoSize = true;

            // btnSaveAll
            this.btnSaveAll.Text = " Lưu tất cả";
            this.btnSaveAll.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.Size = new System.Drawing.Size(200, 50);
            this.btnSaveAll.BorderRadius = 8;
            this.btnSaveAll.Location = new System.Drawing.Point(20, 910);
            // gắn event handler ở file .cs bằng BtnSaveAll_Click
            // this.btnSaveAll.Click += new System.EventHandler(this.BtnSaveAll_Click);

            // Khởi tạo các panel banner (vị trí sẽ set trong CreateBannerUI ở file .cs)
            this.panelMain.Controls.Add(this.btnSaveAll);

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Size = new System.Drawing.Size(900, 900);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}