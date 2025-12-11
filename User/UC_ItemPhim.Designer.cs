namespace MovieTicketApp
{
    partial class UC_ItemPhim
    {
        private System.ComponentModel.IContainer components = null;

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
            this.panelItem = new Guna.UI2.WinForms.Guna2Panel();
            this.lblThoiLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenPhim = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDatVe = new Guna.UI2.WinForms.Guna2Button();
            this.picPoster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItem
            // 
            this.panelItem.BackColor = System.Drawing.Color.Transparent;
            this.panelItem.BorderColor = System.Drawing.Color.Black;
            this.panelItem.BorderRadius = 12;
            this.panelItem.BorderThickness = 2;
            this.panelItem.Controls.Add(this.lblThoiLuong);
            this.panelItem.Controls.Add(this.lblTenPhim);
            this.panelItem.Controls.Add(this.btnDatVe);
            this.panelItem.Controls.Add(this.picPoster);
            this.panelItem.FillColor = System.Drawing.Color.White;
            this.panelItem.Location = new System.Drawing.Point(0, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.ShadowDecoration.Depth = 10;
            this.panelItem.Size = new System.Drawing.Size(200, 300);
            this.panelItem.TabIndex = 0;
            this.panelItem.Paint += new System.Windows.Forms.PaintEventHandler(this.panelItem_Paint);
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblThoiLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblThoiLuong.ForeColor = System.Drawing.Color.Black;
            this.lblThoiLuong.Location = new System.Drawing.Point(50, 220);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(114, 30);
            this.lblThoiLuong.TabIndex = 2;
            this.lblThoiLuong.Text = "⏱ 120 phút";
            this.lblThoiLuong.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = false;
            this.lblTenPhim.BackColor = System.Drawing.Color.Transparent;
            this.lblTenPhim.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenPhim.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTenPhim.Location = new System.Drawing.Point(15, 170);
            this.lblTenPhim.MaximumSize = new System.Drawing.Size(170, 35);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(170, 35);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "Tên phim";
            this.lblTenPhim.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTenPhim.Click += new System.EventHandler(this.lblTenPhim_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BorderRadius = 10;
            this.btnDatVe.FillColor = System.Drawing.Color.DarkOrange;
            this.btnDatVe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDatVe.ForeColor = System.Drawing.Color.Black;
            this.btnDatVe.Location = new System.Drawing.Point(40, 250);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(120, 30);
            this.btnDatVe.TabIndex = 3;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // picPoster
            // 
            this.picPoster.BorderRadius = 12;
            this.picPoster.FillColor = System.Drawing.Color.LightGray;
            this.picPoster.ImageRotate = 0F;
            this.picPoster.Location = new System.Drawing.Point(15, 15);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(170, 150);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            this.picPoster.Click += new System.EventHandler(this.picPoster_Click);
            // 
            // UC_ItemPhim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelItem);
            this.MaximumSize = new System.Drawing.Size(200, 300);
            this.MinimumSize = new System.Drawing.Size(200, 300);
            this.Name = "UC_ItemPhim";
            this.Size = new System.Drawing.Size(200, 300);
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelItem;
        private Guna.UI2.WinForms.Guna2PictureBox picPoster;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenPhim;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThoiLuong;
        private Guna.UI2.WinForms.Guna2Button btnDatVe;
    }
}