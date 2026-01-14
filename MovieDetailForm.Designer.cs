namespace MovieTicketApp
{
    partial class MovieDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2PictureBox picPoster;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenPhim;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThoiLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTheLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2ComboBox cboNgayChieu;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhungGio;
        private Guna.UI2.WinForms.Guna2Button btnDatVe;

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
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatVe = new Guna.UI2.WinForms.Guna2Button();
            this.picPoster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTenPhim = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblThoiLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTheLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboNgayChieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboKhungGio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLocal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            //
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderRadius = 20;
            this.panelMain.BorderThickness = 0;
            this.panelMain.Controls.Add(this.lblLocal);
            this.panelMain.Controls.Add(this.btnDatVe);
            this.panelMain.Controls.Add(this.guna2Button1);
            this.panelMain.Controls.Add(this.picPoster);
            this.panelMain.Controls.Add(this.lblTenPhim);
            this.panelMain.Controls.Add(this.lblThoiLuong);
            this.panelMain.Controls.Add(this.lblTheLoai);
            this.panelMain.Controls.Add(this.txtMoTa);
            this.panelMain.Controls.Add(this.cboNgayChieu);
            this.panelMain.Controls.Add(this.cboKhungGio);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(24);
            this.panelMain.ShadowDecoration.Color = System.Drawing.Color.Black;
            this.panelMain.ShadowDecoration.Depth = 12;
            this.panelMain.ShadowDecoration.Enabled = true;
            this.panelMain.Size = new System.Drawing.Size(900, 500);
            this.panelMain.TabIndex = 0;
            // 
            // guna2Button1 (Đóng)
            //
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.guna2Button1.Location = new System.Drawing.Point(24, 442);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(120, 44);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Đóng";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BorderRadius = 12;
            this.btnDatVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnDatVe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDatVe.ForeColor = System.Drawing.Color.White;
            this.btnDatVe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnDatVe.Location = new System.Drawing.Point(756, 442);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(120, 44);
            this.btnDatVe.TabIndex = 9;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // picPoster
            //
            this.picPoster.BorderRadius = 14;
            this.picPoster.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.picPoster.ImageRotate = 0F;
            this.picPoster.Location = new System.Drawing.Point(24, 24);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(220, 320);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // lblTenPhim
            //
            this.lblTenPhim.BackColor = System.Drawing.Color.Transparent;
            this.lblTenPhim.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTenPhim.ForeColor = System.Drawing.Color.White;
            this.lblTenPhim.Location = new System.Drawing.Point(264, 24);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(500, 50);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "Tên phim";
            this.lblTenPhim.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblThoiLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblThoiLuong.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblThoiLuong.Location = new System.Drawing.Point(264, 80);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(200, 24);
            this.lblThoiLuong.TabIndex = 2;
            this.lblThoiLuong.Text = "⏱ 120 phút";
            // 
            // lblTheLoai
            //
            this.lblTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblTheLoai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTheLoai.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTheLoai.Location = new System.Drawing.Point(264, 108);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(300, 24);
            this.lblTheLoai.TabIndex = 3;
            this.lblTheLoai.Text = "🎫 Thể loại: Hành động";
            // 
            // txtMoTa
            //
            this.txtMoTa.BorderRadius = 10;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMoTa.ForeColor = System.Drawing.Color.White;
            this.txtMoTa.Location = new System.Drawing.Point(264, 140);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMoTa.PlaceholderText = "Mô tả phim...";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(612, 80);
            this.txtMoTa.TabIndex = 4;
            // 
            // cboNgayChieu
            //
            this.cboNgayChieu.BackColor = System.Drawing.Color.Transparent;
            this.cboNgayChieu.BorderRadius = 10;
            this.cboNgayChieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNgayChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgayChieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.cboNgayChieu.FocusedColor = System.Drawing.Color.Empty;
            this.cboNgayChieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cboNgayChieu.ForeColor = System.Drawing.Color.White;
            this.cboNgayChieu.ItemHeight = 30;
            this.cboNgayChieu.Location = new System.Drawing.Point(264, 230);
            this.cboNgayChieu.Name = "cboNgayChieu";
            this.cboNgayChieu.Size = new System.Drawing.Size(280, 36);
            this.cboNgayChieu.TabIndex = 5;
            this.cboNgayChieu.SelectedIndexChanged += new System.EventHandler(this.cboNgayChieu_SelectedIndexChanged);
            // 
            // cboKhungGio
            //
            this.cboKhungGio.BackColor = System.Drawing.Color.Transparent;
            this.cboKhungGio.BorderRadius = 10;
            this.cboKhungGio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhungGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhungGio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.cboKhungGio.FocusedColor = System.Drawing.Color.Empty;
            this.cboKhungGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cboKhungGio.ForeColor = System.Drawing.Color.White;
            this.cboKhungGio.ItemHeight = 30;
            this.cboKhungGio.Items.AddRange(new object[] {
            "09:00",
            "13:30",
            "16:00",
            "19:00",
            "21:30"});
            this.cboKhungGio.Location = new System.Drawing.Point(576, 230);
            this.cboKhungGio.Name = "cboKhungGio";
            this.cboKhungGio.Size = new System.Drawing.Size(300, 40);
            this.cboKhungGio.TabIndex = 6;
            this.cboKhungGio.SelectedIndexChanged += new System.EventHandler(this.cboKhungGio_SelectedIndexChanged);
            // 
            // lblLocal
            //
            this.lblLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblLocal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLocal.Location = new System.Drawing.Point(264, 280);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(200, 24);
            this.lblLocal.TabIndex = 8;
            this.lblLocal.Text = "📄 Địa điểm: Hà Nội";
            this.lblLocal.Click += new System.EventHandler(this.lblLocal_Click);
            // 
            // MovieDetailForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết phim";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLocal;
    }
}