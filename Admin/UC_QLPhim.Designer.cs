using System.Drawing;

namespace MovieTicketApp
{
    partial class UC_QLPhim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPhim = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtTenPhim = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTheLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtThoiLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.picPoster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnChonAnh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý phim";
            // 
            // dgvPhim
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dgvPhim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvPhim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvPhim.ColumnHeadersHeight = 36;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhim.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvPhim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.dgvPhim.Location = new System.Drawing.Point(25, 360);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.RowHeadersVisible = false;
            this.dgvPhim.RowHeadersWidth = 62;
            this.dgvPhim.RowTemplate.Height = 28;
            this.dgvPhim.Size = new System.Drawing.Size(825, 220);
            this.dgvPhim.TabIndex = 12;
            this.dgvPhim.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhim.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhim.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhim.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhim.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhim.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvPhim.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.dgvPhim.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhim.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhim.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvPhim.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhim.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhim.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvPhim.ThemeStyle.ReadOnly = false;
            this.dgvPhim.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhim.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhim.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvPhim.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhim.ThemeStyle.RowsStyle.Height = 28;
            this.dgvPhim.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhim.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BorderRadius = 8;
            this.txtTenPhim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenPhim.DefaultText = "";
            this.txtTenPhim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenPhim.Location = new System.Drawing.Point(160, 80);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.PlaceholderText = "Tên phim";
            this.txtTenPhim.SelectedText = "";
            this.txtTenPhim.Size = new System.Drawing.Size(260, 35);
            this.txtTenPhim.TabIndex = 4;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.BorderRadius = 8;
            this.txtTheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTheLoai.DefaultText = "";
            this.txtTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTheLoai.Location = new System.Drawing.Point(160, 125);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.PlaceholderText = "Thể loại";
            this.txtTheLoai.SelectedText = "";
            this.txtTheLoai.Size = new System.Drawing.Size(260, 35);
            this.txtTheLoai.TabIndex = 5;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.BorderRadius = 8;
            this.txtThoiLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiLuong.DefaultText = "";
            this.txtThoiLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThoiLuong.Location = new System.Drawing.Point(160, 170);
            this.txtThoiLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.PlaceholderText = "Thời lượng (phút)";
            this.txtThoiLuong.SelectedText = "";
            this.txtThoiLuong.Size = new System.Drawing.Size(260, 35);
            this.txtThoiLuong.TabIndex = 6;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderRadius = 8;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.Location = new System.Drawing.Point(160, 260);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderText = "Mô tả phim";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(380, 80);
            this.txtMoTa.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.FillColor = System.Drawing.Color.GreenYellow;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(450, 100);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 35);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.FillColor = System.Drawing.Color.Gold;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(450, 150);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 35);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.Tomato;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(450, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 35);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // picPoster
            // 
            this.picPoster.BorderRadius = 10;
            this.picPoster.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.picPoster.ImageRotate = 0F;
            this.picPoster.Location = new System.Drawing.Point(25, 70);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(120, 170);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 2;
            this.picPoster.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BorderRadius = 8;
            this.btnChonAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(25, 250);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(120, 35);
            this.btnChonAnh.TabIndex = 3;
            this.btnChonAnh.Text = "Chọn ảnh";
            // 
            // UC_QLPhim
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picPoster);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.txtTheLoai);
            this.Controls.Add(this.txtThoiLuong);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvPhim);
            this.Name = "UC_QLPhim";
            this.Size = new System.Drawing.Size(870, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhim;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPhim;
        private Guna.UI2.WinForms.Guna2TextBox txtTheLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtThoiLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2PictureBox picPoster;
        private Guna.UI2.WinForms.Guna2Button btnChonAnh;
    }
}
