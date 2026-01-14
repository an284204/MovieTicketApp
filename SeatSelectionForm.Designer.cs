using Guna.UI2.WinForms;
using System.Drawing;

namespace MovieTicketApp
{
    partial class SeatSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2Panel panelMain;
        private Guna2Panel panelScreen;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Panel panelSeats;
        private Guna2Panel panelLegend;
        private Guna2Panel panelBottom;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSelectedSeats;
        private Guna2Button btnConfirm;
        private Guna2Button btnMinimize;
        private Guna2Button btnClose;
        private Guna2CircleButton circleBtnAvailable;
        private Guna2CircleButton circleBtnSelected;
        private Guna2CircleButton circleBtnBooked;
        private Guna2CircleButton circleBtnLocked;
        private Guna2CircleButton circleBtnVIP;
        private System.Windows.Forms.Label lblLegendAvailable;
        private System.Windows.Forms.Label lblLegendSelected;
        private System.Windows.Forms.Label lblLegendBooked;
        private System.Windows.Forms.Label lblLegendLocked;
        private System.Windows.Forms.Label lblLegendVIP;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelScreen = new Guna.UI2.WinForms.Guna2Panel();
            this.lblScreen = new System.Windows.Forms.Label();
            this.panelSeats = new System.Windows.Forms.Panel();
            this.panelLegend = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSelectedSeats = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.circleBtnAvailable = new Guna.UI2.WinForms.Guna2CircleButton();
            this.circleBtnSelected = new Guna.UI2.WinForms.Guna2CircleButton();
            this.circleBtnBooked = new Guna.UI2.WinForms.Guna2CircleButton();
            this.circleBtnLocked = new Guna.UI2.WinForms.Guna2CircleButton();
            this.circleBtnVIP = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblLegendAvailable = new System.Windows.Forms.Label();
            this.lblLegendSelected = new System.Windows.Forms.Label();
            this.lblLegendBooked = new System.Windows.Forms.Label();
            this.lblLegendLocked = new System.Windows.Forms.Label();
            this.lblLegendVIP = new System.Windows.Forms.Label();
            
            this.panelMain.SuspendLayout();
            this.panelScreen.SuspendLayout();
            this.panelLegend.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            
            // panelMain - Main container (dark background)
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.panelSeats);
            this.panelMain.Controls.Add(this.panelLegend);
            this.panelMain.Controls.Add(this.panelScreen);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1100, 680);
            this.panelMain.TabIndex = 0;
            
            // panelScreen - Curved screen display at top - DOCK TOP
            this.panelScreen.BackColor = System.Drawing.Color.Transparent;
            this.panelScreen.BorderRadius = 30;
            this.panelScreen.Controls.Add(this.btnClose);
            this.panelScreen.Controls.Add(this.btnMinimize);
            this.panelScreen.Controls.Add(this.lblScreen);
            this.panelScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelScreen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.panelScreen.ShadowDecoration.Color = System.Drawing.Color.Black;
            this.panelScreen.ShadowDecoration.Depth = 8;
            this.panelScreen.ShadowDecoration.Enabled = true;
            this.panelScreen.Size = new System.Drawing.Size(1100, 70);
            this.panelScreen.TabIndex = 0;
            
            // lblScreen - Screen label with emoji
            this.lblScreen.BackColor = System.Drawing.Color.Transparent;
            this.lblScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblScreen.ForeColor = System.Drawing.Color.White;
            this.lblScreen.Location = new System.Drawing.Point(20, 10);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(960, 50);
            this.lblScreen.TabIndex = 0;
            this.lblScreen.Text = "📽️  SCREEN";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // panelSeats - Main seating area (left + center) - NO DOCK, FIXED SIZE
            this.panelSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panelSeats.Location = new System.Drawing.Point(0, 70);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Padding = new System.Windows.Forms.Padding(20);
            this.panelSeats.Size = new System.Drawing.Size(800, 480);
            this.panelSeats.TabIndex = 1;
            this.panelSeats.AutoScroll = true;
            
            // panelLegend - Legend panel (right side, compact) - NO DOCK, FIXED SIZE
            this.panelLegend.BackColor = System.Drawing.Color.Transparent;
            this.panelLegend.BorderRadius = 16;
            this.panelLegend.Controls.Add(this.lblLegendVIP);
            this.panelLegend.Controls.Add(this.circleBtnVIP);
            this.panelLegend.Controls.Add(this.lblLegendLocked);
            this.panelLegend.Controls.Add(this.circleBtnLocked);
            this.panelLegend.Controls.Add(this.lblLegendBooked);
            this.panelLegend.Controls.Add(this.circleBtnBooked);
            this.panelLegend.Controls.Add(this.lblLegendSelected);
            this.panelLegend.Controls.Add(this.circleBtnSelected);
            this.panelLegend.Controls.Add(this.lblLegendAvailable);
            this.panelLegend.Controls.Add(this.circleBtnAvailable);
            this.panelLegend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.panelLegend.Location = new System.Drawing.Point(800, 70);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Padding = new System.Windows.Forms.Padding(12);
            this.panelLegend.ShadowDecoration.Color = System.Drawing.Color.Black;
            this.panelLegend.ShadowDecoration.Depth = 8;
            this.panelLegend.ShadowDecoration.Enabled = true;
            this.panelLegend.Size = new System.Drawing.Size(300, 480);
            this.panelLegend.TabIndex = 2;
            
            // Legend: Available (Green)
            this.circleBtnAvailable.FillColor = System.Drawing.Color.LimeGreen;
            this.circleBtnAvailable.Location = new System.Drawing.Point(16, 20);
            this.circleBtnAvailable.Size = new System.Drawing.Size(18, 18);
            this.circleBtnAvailable.TabIndex = 0;
            this.lblLegendAvailable.AutoSize = true;
            this.lblLegendAvailable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLegendAvailable.ForeColor = System.Drawing.Color.White;
            this.lblLegendAvailable.Location = new System.Drawing.Point(42, 20);
            this.lblLegendAvailable.Text = "Ghế còn trống";
            
            // Legend: Selected (Orange)
            this.circleBtnSelected.FillColor = System.Drawing.Color.Orange;
            this.circleBtnSelected.Location = new System.Drawing.Point(16, 55);
            this.circleBtnSelected.Size = new System.Drawing.Size(18, 18);
            this.circleBtnSelected.TabIndex = 1;
            this.lblLegendSelected.AutoSize = true;
            this.lblLegendSelected.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLegendSelected.ForeColor = System.Drawing.Color.White;
            this.lblLegendSelected.Location = new System.Drawing.Point(42, 55);
            this.lblLegendSelected.Text = "Đang chọn";
            
            // Legend: Booked (Gray)
            this.circleBtnBooked.FillColor = System.Drawing.Color.Gray;
            this.circleBtnBooked.Location = new System.Drawing.Point(16, 90);
            this.circleBtnBooked.Size = new System.Drawing.Size(18, 18);
            this.circleBtnBooked.TabIndex = 2;
            this.lblLegendBooked.AutoSize = true;
            this.lblLegendBooked.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLegendBooked.ForeColor = System.Drawing.Color.White;
            this.lblLegendBooked.Location = new System.Drawing.Point(42, 90);
            this.lblLegendBooked.Text = "Đã đặt";
            
            // Legend: Locked (Red)
            this.circleBtnLocked.FillColor = System.Drawing.Color.Red;
            this.circleBtnLocked.Location = new System.Drawing.Point(16, 125);
            this.circleBtnLocked.Size = new System.Drawing.Size(18, 18);
            this.circleBtnLocked.TabIndex = 3;
            this.lblLegendLocked.AutoSize = true;
            this.lblLegendLocked.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLegendLocked.ForeColor = System.Drawing.Color.White;
            this.lblLegendLocked.Location = new System.Drawing.Point(42, 125);
            this.lblLegendLocked.Text = "Tạm khóa";
            
            // Legend: VIP (Purple)
            this.circleBtnVIP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.circleBtnVIP.Location = new System.Drawing.Point(16, 160);
            this.circleBtnVIP.Size = new System.Drawing.Size(18, 18);
            this.circleBtnVIP.TabIndex = 4;
            this.lblLegendVIP.AutoSize = true;
            this.lblLegendVIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLegendVIP.ForeColor = System.Drawing.Color.White;
            this.lblLegendVIP.Location = new System.Drawing.Point(42, 160);
            this.lblLegendVIP.Text = "Ghế VIP/Đôi";
            
            // panelBottom - Info and payment bar - DOCK BOTTOM
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.BorderRadius = 16;
            this.panelBottom.Controls.Add(this.btnConfirm);
            this.panelBottom.Controls.Add(this.lblTotal);
            this.panelBottom.Controls.Add(this.lblSelectedSeats);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(15);
            this.panelBottom.ShadowDecoration.Color = System.Drawing.Color.Black;
            this.panelBottom.ShadowDecoration.Depth = 8;
            this.panelBottom.ShadowDecoration.Enabled = true;
            this.panelBottom.Size = new System.Drawing.Size(1100, 130);
            this.panelBottom.TabIndex = 3;
            
            // btnMinimize - Minimize button (top left)
            this.btnMinimize.BorderRadius = 8;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnMinimize.Location = new System.Drawing.Point(20, 15);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "−";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            
            // btnClose - Close button (top left, next to minimize)
            this.btnClose.BorderRadius = 8;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.Location = new System.Drawing.Point(60, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            
            // lblSelectedSeats
            this.lblSelectedSeats.AutoSize = true;
            this.lblSelectedSeats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedSeats.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSelectedSeats.Location = new System.Drawing.Point(15, 15);
            this.lblSelectedSeats.Name = "lblSelectedSeats";
            this.lblSelectedSeats.Text = "Ghế đã chọn: Không có";
            
            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(15, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "Tổng: 0đ";
            
            // btnConfirm - Payment button (Red accent)
            this.btnConfirm.BorderRadius = 12;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnConfirm.Location = new System.Drawing.Point(720, 35);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(165, 40);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Thanh toán";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            
            // SeatSelectionForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeatSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn ghế";
            this.Load += new System.EventHandler(this.SeatSelectionForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SeatSelectionForm_FormClosing);
            
            this.panelMain.ResumeLayout(false);
            this.panelScreen.ResumeLayout(false);
            this.panelLegend.ResumeLayout(false);
            this.panelLegend.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
