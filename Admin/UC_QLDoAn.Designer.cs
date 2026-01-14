using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class UC_QLDoAn
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDoAn = new System.Windows.Forms.DataGridView();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnChonAnh = new Guna.UI2.WinForms.Guna2Button();
            this.picAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtTenDoAn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAn)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(608, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Đồ Ăn / Nước Uống";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderRadius = 15;
            this.panelMain.Controls.Add(this.dgvDoAn);
            this.panelMain.FillColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(10, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.ShadowDecoration.Depth = 10;
            this.panelMain.ShadowDecoration.Enabled = true;
            this.panelMain.Size = new System.Drawing.Size(950, 520);
            this.panelMain.TabIndex = 1;
            // 
            // dgvDoAn
            // 
            this.dgvDoAn.AllowUserToAddRows = false;
            this.dgvDoAn.AllowUserToDeleteRows = false;
            this.dgvDoAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoAn.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoAn.Location = new System.Drawing.Point(10, 20);
            this.dgvDoAn.Name = "dgvDoAn";
            this.dgvDoAn.ReadOnly = true;
            this.dgvDoAn.RowHeadersVisible = false;
            this.dgvDoAn.RowHeadersWidth = 62;
            this.dgvDoAn.RowTemplate.Height = 38;
            this.dgvDoAn.Size = new System.Drawing.Size(930, 700);
            this.dgvDoAn.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.BorderRadius = 15;
            this.panelRight.Controls.Add(this.btnXoa);
            this.panelRight.Controls.Add(this.btnSua);
            this.panelRight.Controls.Add(this.btnThem);
            this.panelRight.Controls.Add(this.btnChonAnh);
            this.panelRight.Controls.Add(this.picAnh);
            this.panelRight.Controls.Add(this.txtTenDoAn);
            this.panelRight.Controls.Add(this.txtGia);
            this.panelRight.Controls.Add(this.cboLoai);
            this.panelRight.Controls.Add(this.txtStock);
            this.panelRight.FillColor = System.Drawing.Color.White;
            this.panelRight.Location = new System.Drawing.Point(970, 80);
            this.panelRight.Name = "panelRight";
            this.panelRight.ShadowDecoration.Depth = 10;
            this.panelRight.ShadowDecoration.Enabled = true;
            this.panelRight.Size = new System.Drawing.Size(250, 520);
            this.panelRight.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(80, 450);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.UseTransparentBackground = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(130, 400);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseTransparentBackground = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 400);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseTransparentBackground = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BorderRadius = 10;
            this.btnChonAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(50, 150);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(150, 38);
            this.btnChonAnh.TabIndex = 1;
            this.btnChonAnh.Text = "📁 Chọn ảnh";
            this.btnChonAnh.UseTransparentBackground = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picAnh
            // 
            this.picAnh.BorderRadius = 10;
            this.picAnh.FillColor = System.Drawing.Color.LightGray;
            this.picAnh.ImageRotate = 0F;
            this.picAnh.Location = new System.Drawing.Point(25, 20);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(200, 120);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            // 
            // txtTenDoAn
            // 
            this.txtTenDoAn.BorderRadius = 10;
            this.txtTenDoAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDoAn.DefaultText = "";
            this.txtTenDoAn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenDoAn.Location = new System.Drawing.Point(25, 200);
            this.txtTenDoAn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenDoAn.Name = "txtTenDoAn";
            this.txtTenDoAn.PlaceholderText = "Tên đồ ăn";
            this.txtTenDoAn.SelectedText = "";
            this.txtTenDoAn.Size = new System.Drawing.Size(200, 35);
            this.txtTenDoAn.TabIndex = 3;
            // 
            // txtGia
            // 
            this.txtGia.BorderRadius = 10;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.DefaultText = "";
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGia.Location = new System.Drawing.Point(25, 245);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGia.Name = "txtGia";
            this.txtGia.PlaceholderText = "Giá (VNĐ)";
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(200, 35);
            this.txtGia.TabIndex = 4;
            // 
            // cboLoai
            // 
            this.cboLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboLoai.BorderRadius = 10;
            this.cboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cboLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoai.ItemHeight = 30;
            this.cboLoai.Location = new System.Drawing.Point(25, 290);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(200, 36);
            this.cboLoai.TabIndex = 5;
            // 
            // txtStock
            // 
            this.txtStock.BorderRadius = 10;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.DefaultText = "";
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStock.Location = new System.Drawing.Point(25, 340);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "Số lượng";
            this.txtStock.SelectedText = "";
            this.txtStock.Size = new System.Drawing.Size(200, 40);
            this.txtStock.TabIndex = 6;
            // 
            // UC_QLDoAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelRight);
            this.Name = "UC_QLDoAn";
            this.Size = new System.Drawing.Size(1240, 630);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAn)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.DataGridView dgvDoAn;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        private Guna.UI2.WinForms.Guna2PictureBox picAnh;
        private Guna.UI2.WinForms.Guna2Button btnChonAnh;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDoAn;
        private Guna.UI2.WinForms.Guna2TextBox txtGia;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtStock;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}
