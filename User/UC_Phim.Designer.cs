namespace MovieTicketApp
{
    partial class UC_Phim
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
            this.flowPhim = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.cboLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbGioChieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchPhim = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPhim
            // 
            this.flowPhim.AutoScroll = true;
            this.flowPhim.BackColor = System.Drawing.Color.DimGray;
            this.flowPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPhim.Location = new System.Drawing.Point(0, 60);
            this.flowPhim.Name = "flowPhim";
            this.flowPhim.Padding = new System.Windows.Forms.Padding(8);
            this.flowPhim.Size = new System.Drawing.Size(1580, 940);
            this.flowPhim.TabIndex = 0;
            this.flowPhim.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPhim_Paint_1);
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelTop.BorderRadius = 12;
            this.guna2PanelTop.Controls.Add(this.cboLocation);
            this.guna2PanelTop.Controls.Add(this.cbGioChieu);
            this.guna2PanelTop.Controls.Add(this.cboTheLoai);
            this.guna2PanelTop.Controls.Add(this.txtSearchPhim);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.FillColor = System.Drawing.Color.Khaki;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.guna2PanelTop.Size = new System.Drawing.Size(1580, 60);
            this.guna2PanelTop.TabIndex = 1;
            // 
            // cboLocation
            // 
            this.cboLocation.AutoRoundedCorners = true;
            this.cboLocation.BackColor = System.Drawing.Color.Transparent;
            this.cboLocation.BorderRadius = 16;
            this.cboLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cboLocation.FocusedColor = System.Drawing.Color.Empty;
            this.cboLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocation.ForeColor = System.Drawing.Color.White;
            this.cboLocation.ItemHeight = 28;
            this.cboLocation.Location = new System.Drawing.Point(3, 8);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(220, 34);
            this.cboLocation.TabIndex = 6;
            this.cboLocation.SelectedIndexChanged += new System.EventHandler(this.cboLocation_SelectedIndexChanged);
            // 
            // cbGioChieu
            // 
            this.cbGioChieu.AutoRoundedCorners = true;
            this.cbGioChieu.BackColor = System.Drawing.Color.Transparent;
            this.cbGioChieu.BorderRadius = 16;
            this.cbGioChieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioChieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cbGioChieu.FocusedColor = System.Drawing.Color.Empty;
            this.cbGioChieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbGioChieu.ForeColor = System.Drawing.Color.White;
            this.cbGioChieu.ItemHeight = 28;
            this.cbGioChieu.Location = new System.Drawing.Point(1100, 6);
            this.cbGioChieu.Name = "cbGioChieu";
            this.cbGioChieu.Size = new System.Drawing.Size(150, 34);
            this.cbGioChieu.TabIndex = 4;
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.AutoRoundedCorners = true;
            this.cboTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboTheLoai.BorderRadius = 16;
            this.cboTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cboTheLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cboTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cboTheLoai.ForeColor = System.Drawing.Color.White;
            this.cboTheLoai.ItemHeight = 28;
            this.cboTheLoai.Location = new System.Drawing.Point(680, 6);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(300, 34);
            this.cboTheLoai.TabIndex = 2;
            this.cboTheLoai.SelectedIndexChanged += new System.EventHandler(this.cboTheLoai_SelectedIndexChanged);
            // 
            // txtSearchPhim
            // 
            this.txtSearchPhim.BorderRadius = 8;
            this.txtSearchPhim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchPhim.DefaultText = "";
            this.txtSearchPhim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtSearchPhim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchPhim.ForeColor = System.Drawing.Color.Black;
            this.txtSearchPhim.Location = new System.Drawing.Point(250, 6);
            this.txtSearchPhim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchPhim.Name = "txtSearchPhim";
            this.txtSearchPhim.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchPhim.PlaceholderText = "Nhập tên phim...";
            this.txtSearchPhim.SelectedText = "";
            this.txtSearchPhim.Size = new System.Drawing.Size(250, 50);
            this.txtSearchPhim.TabIndex = 1;
            this.txtSearchPhim.TextChanged += new System.EventHandler(this.txtSearchPhim_TextChanged);
            // 
            // UC_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.flowPhim);
            this.Controls.Add(this.guna2PanelTop);
            this.Name = "UC_Phim";
            this.Size = new System.Drawing.Size(1580, 1000);
            this.Load += new System.EventHandler(this.UC_Phim_Load);
            this.guna2PanelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPhim;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchPhim;
        private Guna.UI2.WinForms.Guna2ComboBox cboTheLoai;
        private Guna.UI2.WinForms.Guna2ComboBox cbGioChieu;
        private Guna.UI2.WinForms.Guna2ComboBox cboLocation;
    }
}
