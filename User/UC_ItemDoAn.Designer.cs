namespace MovieTicketApp
{
    partial class UC_ItemDoAn
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelItem;
        public Guna.UI2.WinForms.Guna2PictureBox picMon;
        public System.Windows.Forms.Label lblTenMon;
        public System.Windows.Forms.Label lblGia;
        private Guna.UI2.WinForms.Guna2Button btnThem;

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
            this.panelItem = new Guna.UI2.WinForms.Guna2Panel();
            this.picMon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItem
            // 
            this.panelItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelItem.BackColor = System.Drawing.Color.Transparent;
            this.panelItem.BorderRadius = 12;
            this.panelItem.Controls.Add(this.picMon);
            this.panelItem.Controls.Add(this.lblTenMon);
            this.panelItem.Controls.Add(this.lblGia);
            this.panelItem.Controls.Add(this.btnThem);
            this.panelItem.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelItem.Location = new System.Drawing.Point(0, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.ShadowDecoration.Depth = 10;
            this.panelItem.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4);
            this.panelItem.Size = new System.Drawing.Size(180, 230);
            this.panelItem.TabIndex = 0;
            // 
            // picMon
            // 
            this.picMon.BorderRadius = 10;
            this.picMon.FillColor = System.Drawing.Color.LightGray;
            this.picMon.ImageRotate = 0F;
            this.picMon.Location = new System.Drawing.Point(15, 10);
            this.picMon.Name = "picMon";
            this.picMon.Size = new System.Drawing.Size(150, 100);
            this.picMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMon.TabIndex = 0;
            this.picMon.TabStop = false;
            // 
            // lblTenMon
            // 
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenMon.ForeColor = System.Drawing.Color.Black;
            this.lblTenMon.Location = new System.Drawing.Point(5, 120);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(170, 25);
            this.lblTenMon.TabIndex = 1;
            this.lblTenMon.Text = "Bắp rang bơ";
            this.lblTenMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGia.ForeColor = System.Drawing.Color.Black;
            this.lblGia.Location = new System.Drawing.Point(5, 145);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(170, 20);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "45.000 VNĐ";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.FillColor = System.Drawing.Color.Orange;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(40, 180);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // UC_ItemDoAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelItem);
            this.Name = "UC_ItemDoAn";
            this.Size = new System.Drawing.Size(180, 230);
            this.panelItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMon)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
