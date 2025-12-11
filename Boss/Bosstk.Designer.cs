using System;
using System.Drawing;

namespace MovieTicketApp
{
    partial class Bosstk
    {
        private System.ComponentModel.IContainer components = null;

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
        private Guna.UI2.WinForms.Guna2Button btnSuaRole;
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
            this.btnSuaRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnTogglePassword = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounts.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAccounts.Location = new System.Drawing.Point(20, 70);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowHeadersWidth = 62;
            this.dgvAccounts.Size = new System.Drawing.Size(780, 250);
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAccounts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAccounts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAccounts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAccounts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAccounts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvAccounts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccounts.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvAccounts.ThemeStyle.ReadOnly = true;
            this.dgvAccounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccounts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvAccounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAccounts.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAccounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dgvAccounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellContentClick);
            // 
            // cbFilterRole
            // 
            this.cbFilterRole.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterRole.BorderRadius = 8;
            this.cbFilterRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterRole.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterRole.ItemHeight = 30;
            this.cbFilterRole.Items.AddRange(new object[] {
            "Tất cả",
            "User",
            "Staff",
            "Admin",
            "Boss"});
            this.cbFilterRole.Location = new System.Drawing.Point(550, 20);
            this.cbFilterRole.Name = "cbFilterRole";
            this.cbFilterRole.Size = new System.Drawing.Size(200, 36);
            this.cbFilterRole.TabIndex = 1;
            this.cbFilterRole.SelectedIndexChanged += new System.EventHandler(this.cbFilterRole_SelectedIndexChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 8;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.Location = new System.Drawing.Point(20, 340);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "Họ tên";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(220, 40);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.BorderRadius = 8;
            this.txtNgaySinh.Checked = true;
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySinh.Location = new System.Drawing.Point(20, 390);
            this.txtNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(220, 40);
            this.txtNgaySinh.TabIndex = 3;
            this.txtNgaySinh.Value = new System.DateTime(2025, 11, 30, 1, 1, 56, 715);
            this.txtNgaySinh.ValueChanged += new System.EventHandler(this.txtNgaySinh_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(20, 440);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(220, 40);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BorderRadius = 8;
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.DefaultText = "";
            this.txtSoDienThoai.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(260, 340);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PlaceholderText = "Số điện thoại";
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.Size = new System.Drawing.Size(220, 40);
            this.txtSoDienThoai.TabIndex = 5;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(260, 390);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(180, 40);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cbEditRole
            // 
            this.cbEditRole.BackColor = System.Drawing.Color.Transparent;
            this.cbEditRole.BorderRadius = 8;
            this.cbEditRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEditRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditRole.FocusedColor = System.Drawing.Color.Empty;
            this.cbEditRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEditRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbEditRole.ItemHeight = 30;
            this.cbEditRole.Items.AddRange(new object[] {
            "User",
            "Staff",
            "Admin",
            "Boss"});
            this.cbEditRole.Location = new System.Drawing.Point(260, 440);
            this.cbEditRole.Name = "cbEditRole";
            this.cbEditRole.Size = new System.Drawing.Size(180, 36);
            this.cbEditRole.TabIndex = 8;
            this.cbEditRole.SelectedIndexChanged += new System.EventHandler(this.cbEditRole_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(500, 340);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 40);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.FillColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(500, 390);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 40);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaRole
            // 
            this.btnSuaRole.BorderRadius = 10;
            this.btnSuaRole.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSuaRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaRole.ForeColor = System.Drawing.Color.White;
            this.btnSuaRole.Location = new System.Drawing.Point(500, 440);
            this.btnSuaRole.Name = "btnSuaRole";
            this.btnSuaRole.Size = new System.Drawing.Size(140, 40);
            this.btnSuaRole.TabIndex = 11;
            this.btnSuaRole.Text = "✏️ Sửa Role";
            this.btnSuaRole.Click += new System.EventHandler(this.btnSuaRole_Click);
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.BorderRadius = 8;
            this.btnTogglePassword.FillColor = System.Drawing.Color.Gray;
            this.btnTogglePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTogglePassword.ForeColor = System.Drawing.Color.White;
            this.btnTogglePassword.Location = new System.Drawing.Point(450, 390);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(40, 40);
            this.btnTogglePassword.TabIndex = 7;
            this.btnTogglePassword.Text = "👁";
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // Bosstk
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.Controls.Add(this.btnSuaRole);
            this.Name = "Bosstk";
            this.Size = new System.Drawing.Size(820, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}