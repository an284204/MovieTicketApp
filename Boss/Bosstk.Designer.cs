using System;
using System.Drawing;

namespace MovieTicketApp
{
    partial class Bosstk
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilterLabel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAccounts;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterRole;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtNgaySinh;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2ComboBox cbEditRole;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSuaThongTin;
        private Guna.UI2.WinForms.Guna2Button btnTogglePassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFilterLabel = new System.Windows.Forms.Label();
            this.dgvAccounts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbFilterRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbEditRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.btnTogglePassword = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 37);
            this.lblTitle.TabIndex = 100;
            this.lblTitle.Text = "Quản lý tài khoản";
            // 
            // lblFilterLabel
            // 
            this.lblFilterLabel.AutoSize = true;
            this.lblFilterLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblFilterLabel.Location = new System.Drawing.Point(665, 37);
            this.lblFilterLabel.Name = "lblFilterLabel";
            this.lblFilterLabel.Size = new System.Drawing.Size(79, 20);
            this.lblFilterLabel.TabIndex = 101;
            this.lblFilterLabel.Text = "Lọc Role:";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounts.ColumnHeadersHeight = 44;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvAccounts.Location = new System.Drawing.Point(30, 80);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowHeadersWidth = 62;
            this.dgvAccounts.RowTemplate.Height = 40;
            this.dgvAccounts.Size = new System.Drawing.Size(940, 300);
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAccounts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAccounts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.dgvAccounts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAccounts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvAccounts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccounts.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvAccounts.ThemeStyle.ReadOnly = true;
            this.dgvAccounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccounts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvAccounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvAccounts.ThemeStyle.RowsStyle.Height = 40;
            this.dgvAccounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvAccounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellContentClick);
            // 
            // cbFilterRole
            // 
            this.cbFilterRole.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cbFilterRole.BorderRadius = 10;
            this.cbFilterRole.BorderThickness = 2;
            this.cbFilterRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterRole.FillColor = System.Drawing.Color.White;
            this.cbFilterRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.cbFilterRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbFilterRole.ItemHeight = 30;
            this.cbFilterRole.Items.AddRange(new object[] {
            "Tất cả",
            "User",
            "Staff",
            "Admin",
            "Boss"});
            this.cbFilterRole.Location = new System.Drawing.Point(750, 30);
            this.cbFilterRole.Name = "cbFilterRole";
            this.cbFilterRole.Size = new System.Drawing.Size(220, 36);
            this.cbFilterRole.TabIndex = 1;
            this.cbFilterRole.SelectedIndexChanged += new System.EventHandler(this.cbFilterRole_SelectedIndexChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtHoTen.BorderRadius = 10;
            this.txtHoTen.BorderThickness = 2;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.FillColor = System.Drawing.Color.White;
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtHoTen.Location = new System.Drawing.Point(30, 410);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtHoTen.PlaceholderText = "Họ tên";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(220, 45);
            this.txtHoTen.TabIndex = 2;
    //        this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtNgaySinh.BorderRadius = 10;
            this.txtNgaySinh.BorderThickness = 2;
            this.txtNgaySinh.Checked = true;
            this.txtNgaySinh.FillColor = System.Drawing.Color.White;
            this.txtNgaySinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySinh.Location = new System.Drawing.Point(270, 410);
            this.txtNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(220, 45);
            this.txtNgaySinh.TabIndex = 3;
            this.txtNgaySinh.Value = new System.DateTime(2025, 11, 30, 1, 1, 56, 715);
  //          this.txtNgaySinh.ValueChanged += new System.EventHandler(this.txtNgaySinh_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.White;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtEmail.Location = new System.Drawing.Point(510, 410);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(220, 45);
            this.txtEmail.TabIndex = 4;
        //    this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtSoDienThoai.BorderRadius = 10;
            this.txtSoDienThoai.BorderThickness = 2;
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.DefaultText = "";
            this.txtSoDienThoai.FillColor = System.Drawing.Color.White;
            this.txtSoDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtSoDienThoai.Location = new System.Drawing.Point(750, 410);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtSoDienThoai.PlaceholderText = "Số điện thoại";
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.Size = new System.Drawing.Size(220, 45);
            this.txtSoDienThoai.TabIndex = 5;
      //      this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPassword.Location = new System.Drawing.Point(30, 475);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(170, 45);
            this.txtPassword.TabIndex = 6;
       //     this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cbEditRole
            // 
            this.cbEditRole.BackColor = System.Drawing.Color.Transparent;
            this.cbEditRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cbEditRole.BorderRadius = 10;
            this.cbEditRole.BorderThickness = 2;
            this.cbEditRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEditRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditRole.FillColor = System.Drawing.Color.White;
            this.cbEditRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.cbEditRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEditRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbEditRole.ItemHeight = 30;
            this.cbEditRole.Items.AddRange(new object[] {
            "User",
            "Staff",
            "Admin",
            "Boss"});
            this.cbEditRole.Location = new System.Drawing.Point(270, 475);
            this.cbEditRole.Name = "cbEditRole";
            this.cbEditRole.Size = new System.Drawing.Size(220, 36);
            this.cbEditRole.TabIndex = 8;
   //         this.cbEditRole.SelectedIndexChanged += new System.EventHandler(this.cbEditRole_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.BorderRadius = 12;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnThem.Location = new System.Drawing.Point(510, 475);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Enabled = true;
            this.btnThem.ShadowDecoration.Depth = 8;
            this.btnThem.Size = new System.Drawing.Size(150, 45);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.BorderRadius = 12;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoa.Location = new System.Drawing.Point(820, 475);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Enabled = true;
            this.btnXoa.ShadowDecoration.Depth = 8;
            this.btnXoa.Size = new System.Drawing.Size(150, 45);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Animated = true;
            this.btnSuaThongTin.BorderRadius = 12;
            this.btnSuaThongTin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSuaThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnSuaThongTin.ForeColor = System.Drawing.Color.White;
            this.btnSuaThongTin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnSuaThongTin.Location = new System.Drawing.Point(665, 475);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.ShadowDecoration.Enabled = true;
            this.btnSuaThongTin.ShadowDecoration.Depth = 8;
            this.btnSuaThongTin.Size = new System.Drawing.Size(150, 45);
            this.btnSuaThongTin.TabIndex = 11;
            this.btnSuaThongTin.Text = "✏️ Sửa thông tin";
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Animated = true;
            this.btnTogglePassword.BorderRadius = 10;
            this.btnTogglePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnTogglePassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTogglePassword.ForeColor = System.Drawing.Color.White;
            this.btnTogglePassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnTogglePassword.Location = new System.Drawing.Point(210, 475);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(45, 45);
            this.btnTogglePassword.TabIndex = 7;
            this.btnTogglePassword.Text = "👁";
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // Bosstk
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFilterLabel);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.cbFilterRole);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnTogglePassword);
            this.Controls.Add(this.cbEditRole);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSuaThongTin);
            this.Name = "Bosstk";
            this.Size = new System.Drawing.Size(1000, 550);
            this.Load += new System.EventHandler(this.Bosstk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}