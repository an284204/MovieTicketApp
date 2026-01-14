using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QRCoder;

namespace MovieTicketApp
{
    public partial class PaymentForm : Form
    {
        private int _hoaDonId;
        private int _userId;
        private string _movieName;
        private decimal _totalAmount;
        private List<string> _selectedSeats;
        private int _showTimeId;
        private DatabaseHelper _db;

        public PaymentForm(int hoaDonId, int userId, string movieName, decimal totalAmount, List<string> selectedSeats, int showTimeId)
        {
            InitializeComponent();
            _hoaDonId = hoaDonId;
            _userId = userId;
            _movieName = movieName;
            _totalAmount = totalAmount;
            _selectedSeats = selectedSeats;
            _showTimeId = showTimeId;
            _db = new DatabaseHelper();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            // Display movie information
            lblMovieInfo.Text = $"Phim: {_movieName} | Ghế: {string.Join(", ", _selectedSeats)}";
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
            string transactionContent = $"{_movieName}-{transactionCode}";

            lblBankName.Text = "Ngân hàng: Vietcombank";
            lblAccountNumber.Text = "Số tài khoản: 1234567890";
            lblTransactionContent.Text = $"Nội dung: {transactionContent}";
            lblBankAmount.Text = $"Số tiền: {_totalAmount:C}";
        }

        private void GenerateQRCode()
        {
            try
            {
                string qrData = $"MOVIE_TICKET_{_hoaDonId}_{_movieName}_{_totalAmount}";
                
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

                // Update all Tickets for this HoaDon
                string updateTicketQuery = $"UPDATE Ticket SET TrangThaiID = {paidStatusId} WHERE HoaDonID = {_hoaDonId}";
                _db.ExecuteNonQuery(updateTicketQuery);

                // Update ShowTimeSeat status by joining with Seat table
                string seatCodesStr = string.Join(",", _selectedSeats.Select(s => $"'{s}'"));
                string updateSeatQuery = $@"UPDATE ShowTimeSeat 
                                           SET Status = 'booked' 
                                           WHERE ShowTimeID = {_showTimeId} 
                                           AND SeatID IN (
                                               SELECT SeatID FROM Seat 
                                               WHERE SeatCode IN ({seatCodesStr})
                                           )";
                _db.ExecuteNonQuery(updateSeatQuery);

                MessageBox.Show("Thanh toán thành công! Vé của bạn đã được xác nhận.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
