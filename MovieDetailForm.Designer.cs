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
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayChieu;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhungGio;

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
            this.picPoster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTenPhim = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblThoiLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTheLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgayChieu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboKhungGio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderColor = System.Drawing.Color.Black;
            this.panelMain.BorderRadius = 12;
            this.panelMain.BorderThickness = 2;
            this.panelMain.Controls.Add(this.guna2Button1);
            this.panelMain.Controls.Add(this.picPoster);
            this.panelMain.Controls.Add(this.lblTenPhim);
            this.panelMain.Controls.Add(this.lblThoiLuong);
            this.panelMain.Controls.Add(this.lblTheLoai);
            this.panelMain.Controls.Add(this.txtMoTa);
            this.panelMain.Controls.Add(this.dtpNgayChieu);
            this.panelMain.Controls.Add(this.cboKhungGio);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.panelMain.Size = new System.Drawing.Size(600, 400);
            this.panelMain.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Location = new System.Drawing.Point(20, 334);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(100, 40);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Đóng";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // picPoster
            // 
            this.picPoster.BorderRadius = 12;
            this.picPoster.FillColor = System.Drawing.Color.LightGray;
            this.picPoster.ImageRotate = 0F;
            this.picPoster.Location = new System.Drawing.Point(20, 20);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(200, 280);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.BackColor = System.Drawing.Color.Transparent;
            this.lblTenPhim.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTenPhim.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTenPhim.Location = new System.Drawing.Point(240, 20);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(127, 40);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "Tên phim";
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblThoiLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblThoiLuong.Location = new System.Drawing.Point(240, 60);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(114, 30);
            this.lblThoiLuong.TabIndex = 2;
            this.lblThoiLuong.Text = "⏱ 120 phút";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTheLoai.Location = new System.Drawing.Point(240, 90);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(178, 30);
            this.lblTheLoai.TabIndex = 3;
            this.lblTheLoai.Text = "Thể loại: Hành động";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "Mô tả phim...";
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.Location = new System.Drawing.Point(240, 130);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(300, 100);
            this.txtMoTa.TabIndex = 4;
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.Checked = true;
            this.dtpNgayChieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayChieu.Location = new System.Drawing.Point(240, 250);
            this.dtpNgayChieu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayChieu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(200, 36);
            this.dtpNgayChieu.TabIndex = 5;
            this.dtpNgayChieu.Value = new System.DateTime(2025, 11, 25, 22, 22, 40, 415);
            this.dtpNgayChieu.ValueChanged += new System.EventHandler(this.dtpNgayChieu_ValueChanged);
            // 
            // cboKhungGio
            // 
            this.cboKhungGio.BackColor = System.Drawing.Color.Transparent;
            this.cboKhungGio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhungGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhungGio.FocusedColor = System.Drawing.Color.Empty;
            this.cboKhungGio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhungGio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhungGio.ItemHeight = 30;
            this.cboKhungGio.Items.AddRange(new object[] {
            "09:00",
            "13:30",
            "16:00",
            "19:00",
            "21:30"});
            this.cboKhungGio.Location = new System.Drawing.Point(240, 300);
            this.cboKhungGio.Name = "cboKhungGio";
            this.cboKhungGio.Size = new System.Drawing.Size(200, 36);
            this.cboKhungGio.TabIndex = 6;
            this.cboKhungGio.SelectedIndexChanged += new System.EventHandler(this.cboKhungGio_SelectedIndexChanged);
            // 
            // MovieDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
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
    }
}