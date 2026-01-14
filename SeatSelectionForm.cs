using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MovieTicketApp
{
    public partial class SeatSelectionForm : Form
    {
        private List<Guna2Button> selectedSeats = new List<Guna2Button>();
        private int seatPrice;
        private int maxSelection = 3;
        private Dictionary<string, DateTime> tempLockedSeats = new Dictionary<string, DateTime>();
        private Timer unlockTimer = new Timer();
        private Timer refreshTimer = new Timer();
        private int currentUserId;
        private int showTimeId;

        public SeatSelectionForm(int showTimeId, int userId)
        {
            InitializeComponent();
            this.showTimeId = showTimeId;
            this.currentUserId = userId;

            DatabaseHelper db = new DatabaseHelper();
            this.seatPrice = db.GetTicketPrice(showTimeId);

            // Timer unlock ghế sau 5 phút
            unlockTimer.Interval = 1000;
            unlockTimer.Tick += UnlockTimer_Tick;
            unlockTimer.Start();

            // Timer refresh trạng thái ghế từ DB
            refreshTimer.Interval = 3000; // 3 giây
            refreshTimer.Tick += (s, e) => LoadSeatsFromDb(showTimeId);
            refreshTimer.Start();
        }

        private void SeatSelectionForm_Load(object sender, EventArgs e)
        {
            LoadSeatsFromDb(showTimeId);
        }

        private void LoadSeatsFromDb(int showTimeId)
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetSeatsByShowTime(showTimeId);

            foreach (DataRow row in dt.Rows)
            {
                string seatCode = row["SeatCode"].ToString().Trim().ToUpper();
                bool isLoveSeat = Convert.ToBoolean(row["IsDouble"]);
                string status = row["Status"].ToString().Trim().ToLower();

                Guna2Button seat = panelSeats.Controls.OfType<Guna2Button>()
                    .FirstOrDefault(s => s.Text == seatCode);

                if (seat == null)
                {
                    // Tạo mới ghế nếu chưa có
                    int size = 50;
                    int spacing = 10;
                    int r = seatCode[0] - 'A';
                    string numberPart = new string(seatCode.Skip(1).TakeWhile(char.IsDigit).ToArray());
                    int colNum = int.Parse(numberPart);

                    seat = new Guna2Button();
                    seat.Height = size;

                    if (isLoveSeat)
                    {
                        int adjustedCol = colNum + (colNum - 9);
                        seat.Width = size * 2 + spacing;
                        seat.Left = (adjustedCol - 1) * (size + spacing) + 60;
                    }
                    else
                    {
                        seat.Width = size;
                        seat.Left = (colNum - 1) * (size + spacing) + 60;
                    }

                    seat.Top = r * (size + spacing) + 20;
                    seat.Text = seatCode;
                    seat.BorderRadius = 12;  // Rounded square
                    seat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    seat.Cursor = Cursors.Hand;
                    seat.ForeColor = Color.White;
                    
                    // Thêm hover effect
                    seat.MouseEnter += (s, e) =>
                    {
                        if (seat.Tag.ToString() == "available")
                            seat.FillColor = Color.FromArgb(144, 238, 144); // lighter green on hover
                    };
                    seat.MouseLeave += (s, e) =>
                    {
                        if (seat.Tag.ToString() == "available" && !selectedSeats.Contains(seat))
                            seat.FillColor = Color.LimeGreen;
                    };
                    
                    seat.Click += Seat_Click;
                    panelSeats.Controls.Add(seat);
                }

                // Nếu ghế đang được chọn bởi user hiện tại thì giữ nguyên màu cam
                if (selectedSeats.Contains(seat))
                    continue;

                // Cập nhật trạng thái từ DB
                seat.Tag = status;
                if (status == "available")
                {
                    // Ghế còn trống: xanh lá hoặc tím cho VIP
                    seat.FillColor = isLoveSeat ? Color.FromArgb(200, 80, 180) : Color.LimeGreen;
                    seat.Enabled = true;
                }
                else if (status == "booked")
                {
                    // Ghế đã đặt: xám
                    seat.FillColor = Color.Gray;
                    seat.Enabled = false;
                }
                else if (status == "locked")
                {
                    // Ghế tạm khóa bởi user khác: đỏ
                    seat.FillColor = Color.Red;
                    seat.Enabled = true;
                }
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Guna2Button seat = sender as Guna2Button;
            string state = seat.Tag.ToString();

            if (state == "booked")
            {
                MessageBox.Show("Ghế đã được đặt!");
                return;
            }

            if (state == "locked")
            {
                if (selectedSeats.Contains(seat))
                {
                    DatabaseHelper db = new DatabaseHelper();
                    db.UpdateSeatStatus(showTimeId, seat.Text, "available");

                    // Restore color: VIP (purple) or standard (green)
                    seat.FillColor = seat.Width > 50 ? Color.FromArgb(200, 80, 180) : Color.LimeGreen;
                    seat.Tag = "available";
                    selectedSeats.Remove(seat);
                    tempLockedSeats.Remove(seat.Text);
                }
                else
                {
                    // Ghế đang bị user khác giữ → không cho đổi
                    MessageBox.Show("Ghế này đang được giữ tạm thời bởi người khác!");
                    return;
                }
            }
            else if (state == "available")
            {
                if (selectedSeats.Count >= maxSelection)
                {
                    MessageBox.Show("Bạn chỉ được chọn tối đa " + maxSelection + " ghế.");
                    return;
                }

                // Lock ghế trong DB
                DatabaseHelper db = new DatabaseHelper();
                db.UpdateSeatStatus(showTimeId, seat.Text, "locked");

                seat.FillColor = Color.Orange; // cam cho user hiện tại
                seat.Tag = "locked";
                selectedSeats.Add(seat);
                tempLockedSeats[seat.Text] = DateTime.Now.AddMinutes(5);
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            int total = 0;

            foreach (var seat in selectedSeats)
            {
                bool isLoveSeat = false;

               if (seat.Tag != null && seat.Tag.ToString().Contains("double"))
                {
                    isLoveSeat = true;
                }

                if (seat.Width > 50)
                {
                    isLoveSeat = true;
                }
                if (isLoveSeat)
                    total += seatPrice * 2;   
                else
                    total += seatPrice;       
            }

            lblTotal.Text = "Tổng: " + total.ToString("N0") + "đ";

            if (selectedSeats.Count == 0)
            {
                lblSelectedSeats.Text = "Ghế đã chọn: Không có";
            }
            else
            {
                var seatCodes = string.Join(", ", selectedSeats.Select(s => s.Text).OrderBy(c => c));
                lblSelectedSeats.Text = "Ghế đã chọn: " + seatCodes;
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế!");
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                // Get movie name from ShowTime
                string movieName = db.GetMovieNameByShowTime(showTimeId);

                // Lấy trạng thái hóa đơn (ví dụ: "Chưa thanh toán")
                int hoaDonTrangThaiId = db.GetTrangThaiId("Chưa Thanh Toán");

                // Create HoaDon with pending status
                decimal totalAmount = selectedSeats.Count * seatPrice;
                int hoaDonId = db.InsertHoaDon(currentUserId, (int)totalAmount, "Ve", hoaDonTrangThaiId);

                // Lấy LocationName và ngày chiếu từ DB
                string locationName = db.GetLocationName(showTimeId);
                DateTime showDate = db.GetShowDate(showTimeId);

                // Get seat list for payment form
                List<string> seatCodes = new List<string>();

                foreach (Guna2Button seat in selectedSeats)
                {
                    // Trạng thái vé
                    int ticketTrangThaiId = db.GetTrangThaiId("Chưa Thanh Toán");

                    // Tạo mã vé: initials_locationName + YYMMDD + ShowTimeID + SeatCode
                    string initials = string.Join("", locationName
                        .Split(' ')
                        .Where(word => !string.IsNullOrEmpty(word))
                        .Select(word => word[0]))
                        .ToUpper();

                    string datePart = showDate.ToString("yyMMdd");
                    string maVe = $"{initials}_{datePart}_{showTimeId}_{seat.Text}";

                    int ticketId = db.InsertTicket(
                        hoaDonId,
                        showTimeId,
                        seat.Text,
                        maVe,
                        ticketTrangThaiId
                    );

                    if (ticketId <= 0)
                    {
                        MessageBox.Show("Không tạo được vé cho ghế " + seat.Text);
                        continue;
                    }

                    // Thêm chi tiết hóa đơn vé
                    db.InsertChiTietHoaDonVe(hoaDonId, ticketId, seatPrice);

                    // Store seat code for payment
                    seatCodes.Add(seat.Text);

                    // Temporarily lock the seat
                    seat.FillColor = Color.Yellow;
                    seat.Tag = "locked";
                    tempLockedSeats[seat.Text] = DateTime.Now;
                }

                // Open PaymentForm
                PaymentForm paymentForm = new PaymentForm(
                    hoaDonId,
                    currentUserId,
                    movieName,
                    totalAmount,
                    seatCodes,
                    showTimeId
                );

                DialogResult paymentResult = paymentForm.ShowDialog();

                if (paymentResult == DialogResult.OK)
                {
                    // Payment successful - seats are already updated in PaymentForm.VerifyPayment()
                    // Update UI to reflect booked status
                    foreach (Guna2Button seat in selectedSeats)
                    {
                        seat.FillColor = Color.Gray;
                        seat.Tag = "booked";
                        tempLockedSeats.Remove(seat.Text);
                    }

                    MessageBox.Show("Thanh toán thành công! Vé của bạn đã được xác nhận.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int supportUserId = 14;
                    int staffUserId = 18;

                    // giả sử currentUser là người đang đặt vé
                    if (currentUserId == staffUserId)
                    {
                        foreach (string seatCode in seatCodes)
                        {
                            string initials = string.Join("", locationName
                                .Split(' ')
                                .Where(word => !string.IsNullOrEmpty(word))
                                .Select(word => word[0]))
                                .ToUpper();

                            string datePart = showDate.ToString("yyMMdd");
                            string maVe = $"{initials}_{datePart}_{showTimeId}_{seatCode}";

                            db.SaveMessage(supportUserId, staffUserId, $"Mã vé mới: {maVe}");
                        }
                    }
                }
                else
                {
                    // Payment cancelled or failed - revert seats to available
                    foreach (Guna2Button seat in selectedSeats)
                    {
                        seat.FillColor = Color.White;
                        seat.Tag = "available";
                        tempLockedSeats.Remove(seat.Text);

                        // Optionally delete the ticket from database
                        string deleteQuery = $"DELETE FROM Ticket WHERE HoaDonID = {hoaDonId}";
                        db.ExecuteNonQuery(deleteQuery);

                        string deleteInvoiceQuery = $"DELETE FROM HoaDon WHERE HoaDonID = {hoaDonId}";
                        db.ExecuteNonQuery(deleteInvoiceQuery);
                    }

                    MessageBox.Show("Thanh toán đã bị hủy. Ghế được giải phóng.", "Hủy bỏ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                selectedSeats.Clear();
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void SeatSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            foreach (var seatCode in tempLockedSeats.Keys.ToList())
            {
                db.UpdateSeatStatus(showTimeId, seatCode, "available");
            }
        }

        private void UnlockTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            List<string> keys = tempLockedSeats.Keys.ToList();
            DatabaseHelper db = new DatabaseHelper();

            foreach (string key in keys)
            {
                if (tempLockedSeats[key] <= now)
                {
                    foreach (Control ctrl in panelSeats.Controls)
                    {
                        Guna2Button seat = ctrl as Guna2Button;
                        if (seat != null && seat.Text == key && seat.Tag.ToString() == "locked")
                        {
                            db.UpdateSeatStatus(showTimeId, key, "available");
                            seat.FillColor = seat.Width > 50 ? Color.MediumVioletRed : Color.LimeGreen;
                            seat.Tag = "available";
                        }
                    }

                    tempLockedSeats.Remove(key);
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
