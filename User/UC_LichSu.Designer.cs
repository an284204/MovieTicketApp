using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class UC_LichSu
    {
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgay;
        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private TabPage tabVe;
        private TabPage tabDoAn;
        private FlowLayoutPanel flowLichSuVe;
        private FlowLayoutPanel flowLichSuDoAn;

        private void InitializeComponent()
        {
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabVe = new System.Windows.Forms.TabPage();
            this.flowLichSuVe = new System.Windows.Forms.FlowLayoutPanel();
            this.tabDoAn = new System.Windows.Forms.TabPage();
            this.flowLichSuDoAn = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabVe.SuspendLayout();
            this.tabDoAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.BorderRadius = 12;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.cboTrangThai);
            this.panelTop.Controls.Add(this.dtNgay);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.Khaki;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.ShadowDecoration.Depth = 10;
            this.panelTop.ShadowDecoration.Enabled = true;
            this.panelTop.Size = new System.Drawing.Size(950, 65);
            this.panelTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lịch sử giao dịch";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(220, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(180, 36);
            this.txtSearch.TabIndex = 1;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.BorderRadius = 10;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đã dùng",
            "Chưa dùng",
            "Đã hủy"});
            this.cboTrangThai.Location = new System.Drawing.Point(420, 14);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(130, 36);
            this.cboTrangThai.TabIndex = 2;
            // 
            // dtNgay
            // 
            this.dtNgay.BorderRadius = 10;
            this.dtNgay.Checked = true;
            this.dtNgay.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dtNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(560, 14);
            this.dtNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(140, 36);
            this.dtNgay.TabIndex = 3;
            this.dtNgay.Value = new System.DateTime(2025, 11, 26, 17, 9, 6, 40);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabVe);
            this.tabControl.Controls.Add(this.tabDoAn);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl.Location = new System.Drawing.Point(0, 65);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(950, 555);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.DeepSkyBlue;
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.LightBlue;
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.LightBlue;
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.RoyalBlue;
            this.tabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // tabVe
            // 
            this.tabVe.Controls.Add(this.flowLichSuVe);
            this.tabVe.Location = new System.Drawing.Point(184, 4);
            this.tabVe.Name = "tabVe";
            this.tabVe.Size = new System.Drawing.Size(762, 547);
            this.tabVe.TabIndex = 0;
            this.tabVe.Text = "Vé";
            // 
            // flowLichSuVe
            // 
            this.flowLichSuVe.AutoScroll = true;
            this.flowLichSuVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLichSuVe.Location = new System.Drawing.Point(0, 0);
            this.flowLichSuVe.Name = "flowLichSuVe";
            this.flowLichSuVe.Padding = new System.Windows.Forms.Padding(20);
            this.flowLichSuVe.Size = new System.Drawing.Size(762, 547);
            this.flowLichSuVe.TabIndex = 0;
            // 
            // tabDoAn
            // 
            this.tabDoAn.Controls.Add(this.flowLichSuDoAn);
            this.tabDoAn.Location = new System.Drawing.Point(184, 4);
            this.tabDoAn.Name = "tabDoAn";
            this.tabDoAn.Size = new System.Drawing.Size(762, 547);
            this.tabDoAn.TabIndex = 1;
            this.tabDoAn.Text = "Đồ ăn";
            // 
            // flowLichSuDoAn
            // 
            this.flowLichSuDoAn.AutoScroll = true;
            this.flowLichSuDoAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLichSuDoAn.Location = new System.Drawing.Point(0, 0);
            this.flowLichSuDoAn.Name = "flowLichSuDoAn";
            this.flowLichSuDoAn.Padding = new System.Windows.Forms.Padding(20);
            this.flowLichSuDoAn.Size = new System.Drawing.Size(762, 547);
            this.flowLichSuDoAn.TabIndex = 0;
            // 
            // UC_LichSu
            // 
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_LichSu";
            this.Size = new System.Drawing.Size(950, 620);
            this.Load += new System.EventHandler(this.UC_LichSu_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabVe.ResumeLayout(false);
            this.tabDoAn.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}