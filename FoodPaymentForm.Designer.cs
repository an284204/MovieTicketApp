namespace MovieTicketApp
{
    partial class FoodPaymentForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFoodInfo = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnBankTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.btnQRCode = new Guna.UI2.WinForms.Guna2Button();
            this.panelBankTransfer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVerifyBankPayment = new Guna.UI2.WinForms.Guna2Button();
            this.lblBankAmount = new System.Windows.Forms.Label();
            this.lblTransactionContent = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.panelQRCode = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVerifyQRPayment = new Guna.UI2.WinForms.Guna2Button();
            this.lblQRInfo = new System.Windows.Forms.Label();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain.SuspendLayout();
            this.panelBankTransfer.SuspendLayout();
            this.panelQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderRadius = 20;
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.panelQRCode);
            this.panelMain.Controls.Add(this.panelBankTransfer);
            this.panelMain.Controls.Add(this.btnQRCode);
            this.panelMain.Controls.Add(this.btnBankTransfer);
            this.panelMain.Controls.Add(this.lblTotalAmount);
            this.panelMain.Controls.Add(this.lblFoodInfo);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(25, 25, 45);
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(50, 70, 120);
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(30);
            this.panelMain.Size = new System.Drawing.Size(900, 700);
            this.panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thanh toán";
            // 
            // lblFoodInfo
            // 
            this.lblFoodInfo.AutoSize = true;
            this.lblFoodInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFoodInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFoodInfo.Location = new System.Drawing.Point(40, 100);
            this.lblFoodInfo.Name = "lblFoodInfo";
            this.lblFoodInfo.Size = new System.Drawing.Size(123, 28);
            this.lblFoodInfo.TabIndex = 1;
            this.lblFoodInfo.Text = "Đồ ăn: ...";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.lblTotalAmount.Location = new System.Drawing.Point(40, 135);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(146, 38);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "Tổng tiền: ...";
            // 
            // btnBankTransfer
            // 
            this.btnBankTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnBankTransfer.BorderRadius = 12;
            this.btnBankTransfer.FillColor = System.Drawing.Color.FromArgb(0, 150, 255);
            this.btnBankTransfer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBankTransfer.ForeColor = System.Drawing.Color.White;
            this.btnBankTransfer.Location = new System.Drawing.Point(40, 190);
            this.btnBankTransfer.Name = "btnBankTransfer";
            this.btnBankTransfer.Size = new System.Drawing.Size(200, 50);
            this.btnBankTransfer.TabIndex = 3;
            this.btnBankTransfer.Text = "💳 Chuyển khoản";
            this.btnBankTransfer.Click += new System.EventHandler(this.btnBankTransfer_Click);
            // 
            // btnQRCode
            // 
            this.btnQRCode.BackColor = System.Drawing.Color.Transparent;
            this.btnQRCode.BorderRadius = 12;
            this.btnQRCode.FillColor = System.Drawing.Color.FromArgb(100, 100, 130);
            this.btnQRCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnQRCode.ForeColor = System.Drawing.Color.White;
            this.btnQRCode.Location = new System.Drawing.Point(260, 190);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(200, 50);
            this.btnQRCode.TabIndex = 4;
            this.btnQRCode.Text = "📱 Quét QR";
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);
            // 
            // panelBankTransfer
            // 
            this.panelBankTransfer.BackColor = System.Drawing.Color.Transparent;
            this.panelBankTransfer.BorderRadius = 15;
            this.panelBankTransfer.Controls.Add(this.lblBankAmount);
            this.panelBankTransfer.Controls.Add(this.lblTransactionContent);
            this.panelBankTransfer.Controls.Add(this.lblAccountNumber);
            this.panelBankTransfer.Controls.Add(this.lblBankName);
            this.panelBankTransfer.Controls.Add(this.btnVerifyBankPayment);
            this.panelBankTransfer.FillColor = System.Drawing.Color.FromArgb(40, 40, 65);
            this.panelBankTransfer.Location = new System.Drawing.Point(40, 270);
            this.panelBankTransfer.Name = "panelBankTransfer";
            this.panelBankTransfer.Padding = new System.Windows.Forms.Padding(25);
            this.panelBankTransfer.Size = new System.Drawing.Size(420, 380);
            this.panelBankTransfer.TabIndex = 5;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.BackColor = System.Drawing.Color.Transparent;
            this.lblBankName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBankName.ForeColor = System.Drawing.Color.White;
            this.lblBankName.Location = new System.Drawing.Point(25, 25);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(163, 30);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "Ngân hàng: ...";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.White;
            this.lblAccountNumber.Location = new System.Drawing.Point(25, 75);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(204, 30);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Số tài khoản: ...";
            // 
            // lblTransactionContent
            // 
            this.lblTransactionContent.AutoSize = true;
            this.lblTransactionContent.BackColor = System.Drawing.Color.Transparent;
            this.lblTransactionContent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTransactionContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTransactionContent.Location = new System.Drawing.Point(25, 125);
            this.lblTransactionContent.Name = "lblTransactionContent";
            this.lblTransactionContent.Size = new System.Drawing.Size(142, 28);
            this.lblTransactionContent.TabIndex = 2;
            this.lblTransactionContent.Text = "Nội dung: ...";
            // 
            // lblBankAmount
            // 
            this.lblBankAmount.AutoSize = true;
            this.lblBankAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblBankAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBankAmount.ForeColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.lblBankAmount.Location = new System.Drawing.Point(25, 175);
            this.lblBankAmount.Name = "lblBankAmount";
            this.lblBankAmount.Size = new System.Drawing.Size(131, 32);
            this.lblBankAmount.TabIndex = 3;
            this.lblBankAmount.Text = "Số tiền: ...";
            // 
            // btnVerifyBankPayment
            // 
            this.btnVerifyBankPayment.BorderRadius = 12;
            this.btnVerifyBankPayment.FillColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnVerifyBankPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVerifyBankPayment.ForeColor = System.Drawing.Color.White;
            this.btnVerifyBankPayment.Location = new System.Drawing.Point(25, 310);
            this.btnVerifyBankPayment.Name = "btnVerifyBankPayment";
            this.btnVerifyBankPayment.Size = new System.Drawing.Size(370, 50);
            this.btnVerifyBankPayment.TabIndex = 4;
            this.btnVerifyBankPayment.Text = "✓ Kiểm tra thanh toán";
            this.btnVerifyBankPayment.Click += new System.EventHandler(this.btnVerifyBankPayment_Click);
            // 
            // panelQRCode
            // 
            this.panelQRCode.BackColor = System.Drawing.Color.Transparent;
            this.panelQRCode.BorderRadius = 15;
            this.panelQRCode.Controls.Add(this.picQRCode);
            this.panelQRCode.Controls.Add(this.lblQRInfo);
            this.panelQRCode.Controls.Add(this.btnVerifyQRPayment);
            this.panelQRCode.FillColor = System.Drawing.Color.FromArgb(40, 40, 65);
            this.panelQRCode.Location = new System.Drawing.Point(480, 270);
            this.panelQRCode.Name = "panelQRCode";
            this.panelQRCode.Padding = new System.Windows.Forms.Padding(25);
            this.panelQRCode.Size = new System.Drawing.Size(390, 380);
            this.panelQRCode.TabIndex = 6;
            // 
            // lblQRInfo
            // 
            this.lblQRInfo.AutoSize = true;
            this.lblQRInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblQRInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQRInfo.ForeColor = System.Drawing.Color.White;
            this.lblQRInfo.Location = new System.Drawing.Point(25, 25);
            this.lblQRInfo.Name = "lblQRInfo";
            this.lblQRInfo.Size = new System.Drawing.Size(210, 28);
            this.lblQRInfo.TabIndex = 0;
            this.lblQRInfo.Text = "Quét mã QR để thanh toán";
            // 
            // picQRCode
            // 
            this.picQRCode.BackColor = System.Drawing.Color.White;
            this.picQRCode.Location = new System.Drawing.Point(45, 70);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(300, 220);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCode.TabIndex = 1;
            this.picQRCode.TabStop = false;
            // 
            // btnVerifyQRPayment
            // 
            this.btnVerifyQRPayment.BorderRadius = 12;
            this.btnVerifyQRPayment.FillColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnVerifyQRPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVerifyQRPayment.ForeColor = System.Drawing.Color.White;
            this.btnVerifyQRPayment.Location = new System.Drawing.Point(25, 310);
            this.btnVerifyQRPayment.Name = "btnVerifyQRPayment";
            this.btnVerifyQRPayment.Size = new System.Drawing.Size(340, 50);
            this.btnVerifyQRPayment.TabIndex = 2;
            this.btnVerifyQRPayment.Text = "✓ Kiểm tra thanh toán";
            this.btnVerifyQRPayment.Click += new System.EventHandler(this.btnVerifyQRPayment_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 10;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(90, 90, 110);
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(820, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 45);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "✕";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FoodPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodPaymentForm";
            this.Load += new System.EventHandler(this.FoodPaymentForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBankTransfer.ResumeLayout(false);
            this.panelBankTransfer.PerformLayout();
            this.panelQRCode.ResumeLayout(false);
            this.panelQRCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFoodInfo;
        private System.Windows.Forms.Label lblTotalAmount;
        private Guna.UI2.WinForms.Guna2Button btnBankTransfer;
        private Guna.UI2.WinForms.Guna2Button btnQRCode;
        private Guna.UI2.WinForms.Guna2Panel panelBankTransfer;
        private System.Windows.Forms.Label lblBankAmount;
        private System.Windows.Forms.Label lblTransactionContent;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblBankName;
        private Guna.UI2.WinForms.Guna2Button btnVerifyBankPayment;
        private Guna.UI2.WinForms.Guna2Panel panelQRCode;
        private Guna.UI2.WinForms.Guna2Button btnVerifyQRPayment;
        private System.Windows.Forms.Label lblQRInfo;
        private System.Windows.Forms.PictureBox picQRCode;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
