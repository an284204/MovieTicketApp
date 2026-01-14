using System.Drawing;

namespace MovieTicketApp
{
    partial class FormMainUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHotro = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyTK = new Guna.UI2.WinForms.Guna2Button();
            this.btnLichSu = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoAn = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhim = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.btnHotro);
            this.panelMenu.Controls.Add(this.btnThoat);
            this.panelMenu.Controls.Add(this.btnQuanLyTK);
            this.panelMenu.Controls.Add(this.btnLichSu);
            this.panelMenu.Controls.Add(this.btnDoAn);
            this.panelMenu.Controls.Add(this.btnPhim);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(18, 24, 18, 24);
            this.panelMenu.Size = new System.Drawing.Size(240, 1200);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnHotro
            // 
            this.btnHotro.BackColor = System.Drawing.Color.Transparent;
            this.btnHotro.BorderRadius = 8;
            this.btnHotro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHotro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHotro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHotro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHotro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHotro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnHotro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotro.ForeColor = System.Drawing.Color.White;
            this.btnHotro.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnHotro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHotro.ImageSize = new System.Drawing.Size(24, 24);
            this.btnHotro.Location = new System.Drawing.Point(18, 407);
            this.btnHotro.Name = "btnHotro";
            this.btnHotro.ShadowDecoration.Enabled = true;
            this.btnHotro.Size = new System.Drawing.Size(204, 45);
            this.btnHotro.TabIndex = 8;
            this.btnHotro.Text = "💬 Hỗ trợ";
            this.btnHotro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHotro.Click += new System.EventHandler(this.btnHotro_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BorderRadius = 8;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThoat.ImageSize = new System.Drawing.Size(24, 24);
            this.btnThoat.Location = new System.Drawing.Point(18, 1131);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ShadowDecoration.Enabled = true;
            this.btnThoat.Size = new System.Drawing.Size(204, 45);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnQuanLyTK
            // 
            this.btnQuanLyTK.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyTK.BorderRadius = 8;
            this.btnQuanLyTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnQuanLyTK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTK.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyTK.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnQuanLyTK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyTK.ImageSize = new System.Drawing.Size(24, 24);
            this.btnQuanLyTK.Location = new System.Drawing.Point(18, 362);
            this.btnQuanLyTK.Name = "btnQuanLyTK";
            this.btnQuanLyTK.ShadowDecoration.Enabled = true;
            this.btnQuanLyTK.Size = new System.Drawing.Size(204, 45);
            this.btnQuanLyTK.TabIndex = 6;
            this.btnQuanLyTK.Text = "👤 Tài khoản";
            this.btnQuanLyTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyTK.Click += new System.EventHandler(this.btnQuanLyTK_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.BackColor = System.Drawing.Color.Transparent;
            this.btnLichSu.BorderRadius = 8;
            this.btnLichSu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLichSu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLichSu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichSu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichSu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnLichSu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSu.ForeColor = System.Drawing.Color.White;
            this.btnLichSu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnLichSu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLichSu.ImageSize = new System.Drawing.Size(24, 24);
            this.btnLichSu.Location = new System.Drawing.Point(18, 317);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.ShadowDecoration.Enabled = true;
            this.btnLichSu.Size = new System.Drawing.Size(204, 45);
            this.btnLichSu.TabIndex = 5;
            this.btnLichSu.Text = "📋 Lịch sử";
            this.btnLichSu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnDoAn
            // 
            this.btnDoAn.BackColor = System.Drawing.Color.Transparent;
            this.btnDoAn.BorderRadius = 8;
            this.btnDoAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoAn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDoAn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoAn.ForeColor = System.Drawing.Color.White;
            this.btnDoAn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnDoAn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoAn.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDoAn.Location = new System.Drawing.Point(18, 272);
            this.btnDoAn.Name = "btnDoAn";
            this.btnDoAn.ShadowDecoration.Enabled = true;
            this.btnDoAn.Size = new System.Drawing.Size(204, 45);
            this.btnDoAn.TabIndex = 4;
            this.btnDoAn.Text = "🍿 Đồ ăn";
            this.btnDoAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoAn.Click += new System.EventHandler(this.btnDoAn_Click);
            // 
            // btnPhim
            // 
            this.btnPhim.BackColor = System.Drawing.Color.Transparent;
            this.btnPhim.BorderRadius = 8;
            this.btnPhim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnPhim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPhim.ForeColor = System.Drawing.Color.White;
            this.btnPhim.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnPhim.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhim.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPhim.Location = new System.Drawing.Point(18, 227);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.ShadowDecoration.Enabled = true;
            this.btnPhim.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnPhim.Size = new System.Drawing.Size(204, 45);
            this.btnPhim.TabIndex = 3;
            this.btnPhim.Text = "🎬 Danh sách phim";
            this.btnPhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.BorderRadius = 8;
            this.btnTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnTrangChu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrangChu.ImageSize = new System.Drawing.Size(24, 24);
            this.btnTrangChu.Location = new System.Drawing.Point(18, 182);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.ShadowDecoration.Enabled = true;
            this.btnTrangChu.Size = new System.Drawing.Size(204, 45);
            this.btnTrangChu.TabIndex = 2;
            this.btnTrangChu.Text = "🏠 Trang chủ";
            this.btnTrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 144);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Cinema App";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(18, 24);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(204, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(240, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1560, 1200);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // FormMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1800, 1200);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CinemaApp";
            this.Load += new System.EventHandler(this.FormMainUser_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyTK;
        private Guna.UI2.WinForms.Guna2Button btnLichSu;
        private Guna.UI2.WinForms.Guna2Button btnDoAn;
        private Guna.UI2.WinForms.Guna2Button btnPhim;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnHotro;
    }
}