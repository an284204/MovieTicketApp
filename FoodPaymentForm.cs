using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QRCoder;

namespace MovieTicketApp
{
    public partial class FoodPaymentForm : Form
    {
        private int _hoaDonId;
        private int _userId;
        private decimal _totalAmount;
        private List<(string TenMon, int SoLuong, int Gia)> _selectedFoods;
        private DatabaseHelper _db;

        public FoodPaymentForm(int hoaDonId, int userId, decimal totalAmount, List<(string TenMon, int SoLuong, int Gia)> selectedFoods)
        {
            InitializeComponent();
            _hoaDonId = hoaDonId;
            _userId = userId;
            _totalAmount = totalAmount;
            _selectedFoods = selectedFoods;
            _db = new DatabaseHelper();
        }

        private void FoodPaymentForm_Load(object sender, EventArgs e)
        {
            // Display food information
            string foodList = string.Join(", ", _selectedFoods.Select(f => $"{f.TenMon}(x{f.SoLuong})"));
            lblFoodInfo.Text = $"Đồ ăn: {foodList}";
            lblTotalAmount.Text = $"Tổng tiền: {_totalAmount:C}";
            
            // Show bank transfer panel by default
            panelBankTransfer.Visible = true;
            panelQRCode.Visible = false;
            DisplayBankInfo();
        }

        private void btnBankTransfer_Click(object sender, EventArgs e)
        {
            panelBankTransfer.Visible = true;
            panelQRCode.Visible = false;
            btnBankTransfer.FillColor = Color.FromArgb(0, 150, 255);
            btnQRCode.FillColor = Color.FromArgb(100, 100, 130);
            DisplayBankInfo();
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            panelQRCode.Visible = true;
            panelBankTransfer.Visible = false;
            btnQRCode.FillColor = Color.FromArgb(100, 200, 255);
            btnBankTransfer.FillColor = Color.FromArgb(0, 100, 200);
            GenerateQRCode();
        }

        private void DisplayBankInfo()
        {
            string transactionCode = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            string transactionContent = $"DoAn-{transactionCode}";

            lblBankName.Text = "Ngân hàng: Vietcombank";
            lblAccountNumber.Text = "Số tài khoản: 1234567890";
            lblTransactionContent.Text = $"Nội dung: {transactionContent}";
            lblBankAmount.Text = $"Số tiền: {_totalAmount:C}";
        }

        private void GenerateQRCode()
        {
            try
            {
                string foodNames = string.Join("|", _selectedFoods.Select(f => f.TenMon));
                string qrData = $"FOOD_ORDER_{_hoaDonId}_{foodNames}_{_totalAmount}";
                
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrBitmap = qrCode.GetGraphic(10);

                picQRCode.Image = qrBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã QR: " + ex.Message);
            }
        }

        private void btnVerifyBankPayment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đã chuyển khoản?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VerifyPayment();
            }
        }

        private void btnVerifyQRPayment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận quét mã QR thành công?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VerifyPayment();
            }
        }

        private void VerifyPayment()
        {
            try
            {
                // Update HoaDon status to "Đã thanh toán"
                int paidStatusId = _db.GetTrangThaiId("Chưa Sử Dụng");
                _db.UpdateHoaDonStatus(_hoaDonId, paidStatusId);

                MessageBox.Show("Thanh toán thành công! Đơn hàng của bạn đã được xác nhận.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xác nhận thanh toán: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng? Thanh toán sẽ bị hủy.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
