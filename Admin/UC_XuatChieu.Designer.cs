namespace MovieTicketApp
{
    partial class UC_XuatChieu
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2ComboBox cbPhim;
        private Guna.UI2.WinForms.Guna2ComboBox cbDiaDiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtNgayChieu;
        private Guna.UI2.WinForms.Guna2ComboBox cbGioChieu;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaVe;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLichChieu;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblNgayChieu;
        private System.Windows.Forms.Label lblGioChieu;
        private System.Windows.Forms.Label lblGiaVe;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbPhim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDiaDiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNgayChieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbGioChieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtGiaVe = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.dgvLichChieu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblPhim = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblNgayChieu = new System.Windows.Forms.Label();
            this.lblGioChieu = new System.Windows.Forms.Label();
            this.lblGiaVe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPhim
            // 
            this.cbPhim.BackColor = System.Drawing.Color.Transparent;
            this.cbPhim.BorderRadius = 8;
            this.cbPhim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhim.FocusedColor = System.Drawing.Color.Empty;
            this.cbPhim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPhim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPhim.ItemHeight = 30;
            this.cbPhim.Location = new System.Drawing.Point(180, 20);
            this.cbPhim.Name = "cbPhim";
            this.cbPhim.Size = new System.Drawing.Size(400, 36);
            this.cbPhim.TabIndex = 1;
            // 
            // cbDiaDiem
            // 
            this.cbDiaDiem.BackColor = System.Drawing.Color.Transparent;
            this.cbDiaDiem.BorderRadius = 8;
            this.cbDiaDiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDiaDiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiaDiem.FocusedColor = System.Drawing.Color.Empty;
            this.cbDiaDiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDiaDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDiaDiem.ItemHeight = 30;
            this.cbDiaDiem.Location = new System.Drawing.Point(180, 60);
            this.cbDiaDiem.Name = "cbDiaDiem";
            this.cbDiaDiem.Size = new System.Drawing.Size(200, 36);
            this.cbDiaDiem.TabIndex = 3;
            this.cbDiaDiem.SelectedIndexChanged += new System.EventHandler(this.cbDiaDiem_SelectedIndexChanged);
            // 
            // cbPhong
            // 
            this.cbPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbPhong.BorderRadius = 8;
            this.cbPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhong.FocusedColor = System.Drawing.Color.Empty;
            this.cbPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPhong.ItemHeight = 30;
            this.cbPhong.Location = new System.Drawing.Point(180, 100);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(200, 36);
            this.cbPhong.TabIndex = 5;
            // 
            // txtNgayChieu
            // 
            this.txtNgayChieu.BorderRadius = 8;
            this.txtNgayChieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayChieu.DefaultText = "";
            this.txtNgayChieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayChieu.Location = new System.Drawing.Point(180, 140);
            this.txtNgayChieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgayChieu.Name = "txtNgayChieu";
            this.txtNgayChieu.PlaceholderText = "dd/MM/yyyy";
            this.txtNgayChieu.SelectedText = "";
            this.txtNgayChieu.Size = new System.Drawing.Size(200, 36);
            this.txtNgayChieu.TabIndex = 7;
            // 
            // cbGioChieu
            // 
            this.cbGioChieu.BackColor = System.Drawing.Color.Transparent;
            this.cbGioChieu.BorderRadius = 8;
            this.cbGioChieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioChieu.FocusedColor = System.Drawing.Color.Empty;
            this.cbGioChieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGioChieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGioChieu.ItemHeight = 30;
            this.cbGioChieu.Items.AddRange(new object[] {
            "07:00",
            "09:00",
            "11:00",
            "12:00",
            "13:00",
            "15:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbGioChieu.Location = new System.Drawing.Point(180, 180);
            this.cbGioChieu.Name = "cbGioChieu";
            this.cbGioChieu.Size = new System.Drawing.Size(200, 36);
            this.cbGioChieu.TabIndex = 9;
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.BorderRadius = 8;
            this.txtGiaVe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaVe.DefaultText = "";
            this.txtGiaVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaVe.Location = new System.Drawing.Point(180, 220);
            this.txtGiaVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.PlaceholderText = "Nhập giá vé";
            this.txtGiaVe.SelectedText = "";
            this.txtGiaVe.Size = new System.Drawing.Size(200, 36);
            this.txtGiaVe.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(600, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 40);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(600, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 40);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(600, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvLichChieu
            // 
            Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLichChieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichChieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichChieu.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichChieu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichChieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichChieu.Location = new System.Drawing.Point(20, 270);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.RowHeadersVisible = false;
            this.dgvLichChieu.RowHeadersWidth = 62;
            this.dgvLichChieu.Size = new System.Drawing.Size(960, 415);
            this.dgvLichChieu.TabIndex = 15;
            this.dgvLichChieu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichChieu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLichChieu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLichChieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLichChieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLichChieu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichChieu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichChieu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLichChieu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLichChieu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvLichChieu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLichChieu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLichChieu.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvLichChieu.ThemeStyle.ReadOnly = false;
            this.dgvLichChieu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichChieu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichChieu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvLichChieu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLichChieu.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLichChieu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dgvLichChieu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLichChieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichChieu_CellContentClick);
            // 
            // lblPhim
            // 
            this.lblPhim.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblPhim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.lblPhim.Location = new System.Drawing.Point(15, 26);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(100, 30);
            this.lblPhim.TabIndex = 0;
            this.lblPhim.Text = "Phim:";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblDiaDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.lblDiaDiem.Location = new System.Drawing.Point(15, 60);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(150, 30);
            this.lblDiaDiem.TabIndex = 2;
            this.lblDiaDiem.Text = "Địa điểm:";
            // 
            // lblPhong
            // 
            this.lblPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.lblPhong.Location = new System.Drawing.Point(20, 100);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(100, 30);
            this.lblPhong.TabIndex = 4;
            this.lblPhong.Text = "Phòng:";
            // 
            // lblNgayChieu
            // 
            this.lblNgayChieu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblNgayChieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.lblNgayChieu.Location = new System.Drawing.Point(20, 140);
            this.lblNgayChieu.Name = "lblNgayChieu";
            this.lblNgayChieu.Size = new System.Drawing.Size(150, 30);
            this.lblNgayChieu.TabIndex = 6;
            this.lblNgayChieu.Text = "Ngày chiếu:";
            // 
            // lblGioChieu
            // 
            this.lblGioChieu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblGioChieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.lblGioChieu.Location = new System.Drawing.Point(20, 180);
            this.lblGioChieu.Name = "lblGioChieu";
            this.lblGioChieu.Size = new System.Drawing.Size(150, 30);
            this.lblGioChieu.TabIndex = 8;
            this.lblGioChieu.Text = "Giờ chiếu:";
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblGiaVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.lblGiaVe.Location = new System.Drawing.Point(20, 220);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(150, 30);
            this.lblGiaVe.TabIndex = 10;
            this.lblGiaVe.Text = "Giá vé:";
            // 
            // UC_XuatChieu
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.lblPhim);
            this.Controls.Add(this.cbPhim);
            this.Controls.Add(this.lblDiaDiem);
            this.Controls.Add(this.cbDiaDiem);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.cbPhong);
            this.Controls.Add(this.lblNgayChieu);
            this.Controls.Add(this.txtNgayChieu);
            this.Controls.Add(this.lblGioChieu);
            this.Controls.Add(this.cbGioChieu);
            this.Controls.Add(this.lblGiaVe);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvLichChieu);
            this.Name = "UC_XuatChieu";
            this.Size = new System.Drawing.Size(1000, 900);
            this.Load += new System.EventHandler(this.UC_XuatChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}