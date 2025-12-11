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
                    seat.BorderRadius = 8;
                    seat.Cursor = Cursors.Hand;
                    seat.Click += Seat_Click;
                    panelSeats.Controls.Add(seat);
                }

                // Nếu ghế đang được chọn bởi user hiện tại thì giữ nguyên màu cam
                if (selectedSeats.Contains(seat))
                    continue;

                // Cập nhật trạng thái từ DB
                seat.Tag = status;
                if (status == "available")
                    seat.FillColor = isLoveSeat ? Color.MediumVioletRed : Color.LimeGreen;
                else if (status == "booked")
                {
                    seat.FillColor = Color.Gray;
                    seat.Enabled = false;
                }
                else if (status == "locked")
                {
                    seat.FillColor = Color.Red; // đỏ cho ghế bị lock bởi user khác
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
                // Nếu ghế này nằm trong danh sách selectedSeats của user hiện tại
                if (selectedSeats.Contains(seat))
                {
                    // Bỏ chọn ghế → trả về available
                    DatabaseHelper db = new DatabaseHelper();
                    db.UpdateSeatStatus(showTimeId, seat.Text, "available");

                    seat.FillColor = seat.Width > 50 ? Color.MediumVioletRed : Color.LimeGreen;
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
            lblTotal.Text = "Tổng: " + (selectedSeats.Count * seatPrice).ToString("N0") + "đ";
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
                int hoaDonTrangThaiId = db.GetTrangThaiId("Chua Dung");
                int hoaDonId = db.InsertHoaDon(currentUserId, selectedSeats.Count * seatPrice, "Ve", hoaDonTrangThaiId);

                string locationName = db.GetLocationName(showTimeId);
                DateTime showDate = db.GetShowDate(showTimeId);

                foreach (Guna2Button seat in selectedSeats)
                {
                    int ticketTrangThaiId = db.GetTrangThaiId("Chua Dung");

                    string initials = string.Join("", locationName
                        .Split(' ')
                        .Where(word => !string.IsNullOrEmpty(word))
                        .Select(word => word[0]))
                        .ToUpper();

                    string datePart = showDate.ToString("yyMMdd");
                    string maVe = $"{initials}_{datePart}_{showTimeId}_{seat.Text}";

                    int ticketId = db.InsertTicket(hoaDonId, showTimeId, seat.Text, maVe, ticketTrangThaiId);

                    if (ticketId <= 0)
                    {
                        MessageBox.Show("Không tạo được vé cho ghế " + seat.Text);
                        continue;
                    }

                    db.InsertChiTietHoaDonVe(hoaDonId, ticketId, seatPrice);

                    // Cập nhật trạng thái ghế thành booked
                    db.UpdateSeatStatus(showTimeId, seat.Text, "booked");

                    seat.FillColor = Color.Gray;
                    seat.Tag = "booked";
                    tempLockedSeats.Remove(seat.Text);
                }

                MessageBox.Show("Bạn đã đặt " + selectedSeats.Count + " vé.\nTổng tiền: " +
                                (selectedSeats.Count * seatPrice).ToString("N0") + "đ");

                selectedSeats.Clear();
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message);
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
    }
}