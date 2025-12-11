using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MovieTicketApp
{
    partial class UC_DoAn
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2Panel panelTop;
        private Guna2TextBox txtTimDoAn;
        private Guna2ComboBox cbLoai;
        private Guna2Button btnGioHang;
        private FlowLayoutPanel flowDoAn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTimDoAn = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnGioHang = new Guna.UI2.WinForms.Guna2Button();
            this.flowDoAn = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Khaki;
            this.panelTop.Controls.Add(this.txtTimDoAn);
            this.panelTop.Controls.Add(this.cbLoai);
            this.panelTop.Controls.Add(this.btnGioHang);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(15);
            this.panelTop.ShadowDecoration.Depth = 10;
            this.panelTop.ShadowDecoration.Enabled = true;
            this.panelTop.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelTop.Size = new System.Drawing.Size(1580, 80);
            this.panelTop.TabIndex = 1;
            // 
            // txtTimDoAn
            // 
            this.txtTimDoAn.BorderRadius = 12;
            this.txtTimDoAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimDoAn.DefaultText = "";
            this.txtTimDoAn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimDoAn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTimDoAn.ForeColor = System.Drawing.Color.Black;
            this.txtTimDoAn.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtTimDoAn.Location = new System.Drawing.Point(20, 20);
            this.txtTimDoAn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTimDoAn.Name = "txtTimDoAn";
            this.txtTimDoAn.PlaceholderText = "Nhập tên món...";
            this.txtTimDoAn.SelectedText = "";
            this.txtTimDoAn.Size = new System.Drawing.Size(250, 40);
            this.txtTimDoAn.TabIndex = 0;
            this.txtTimDoAn.TextChanged += new System.EventHandler(this.txtTimDoAn_TextChanged);
            // 
            // cbLoai
            // 
            this.cbLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbLoai.BorderRadius = 12;
            this.cbLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cbLoai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoai.ItemHeight = 30;
            this.cbLoai.Items.AddRange(new object[] {
            "Tất cả",
            "Bắp rang",
            "Nước uống",
            "Combo"});
            this.cbLoai.Location = new System.Drawing.Point(290, 20);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(160, 36);
            this.cbLoai.TabIndex = 1;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // btnGioHang
            // 
            this.btnGioHang.BorderRadius = 12;
            this.btnGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGioHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGioHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGioHang.ForeColor = System.Drawing.Color.White;
            this.btnGioHang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGioHang.Location = new System.Drawing.Point(600, 20);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(130, 40);
            this.btnGioHang.TabIndex = 3;
            this.btnGioHang.Text = "🛒 Giỏ hàng";
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // flowDoAn
            // 
            this.flowDoAn.AutoScroll = true;
            this.flowDoAn.BackColor = System.Drawing.Color.White;
            this.flowDoAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDoAn.Location = new System.Drawing.Point(0, 80);
            this.flowDoAn.Name = "flowDoAn";
            this.flowDoAn.Padding = new System.Windows.Forms.Padding(20);
            this.flowDoAn.Size = new System.Drawing.Size(1580, 686);
            this.flowDoAn.TabIndex = 0;
            // 
            // UC_DoAn
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowDoAn);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_DoAn";
            this.Size = new System.Drawing.Size(1580, 766);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
