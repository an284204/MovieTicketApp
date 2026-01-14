using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class MovieDetailForm : Form
    {
        private DataTable showTimes;
        private UserInfo currentUser;

        public MovieDetailForm(string tenPhim, string thoiLuong, string description, string genre, string posterFile, UserInfo user = null)
        {
            InitializeComponent();

            currentUser = user;

            // Hiển thị thông tin phim
            lblTenPhim.Text = tenPhim;
            lblThoiLuong.Text = "⏱ " + thoiLuong;
            lblTheLoai.Text = "Thể loại: " + genre;
            txtMoTa.Text = description;

            // Load poster
            string imagePath = Path.Combine(Application.StartupPath, "Images", "Movies", posterFile);
            if (File.Exists(imagePath))
            {
                picPoster.Image = Image.FromFile(imagePath);
                picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            // Load dữ liệu suất chiếu
            DatabaseHelper db = new DatabaseHelper();
            showTimes = db.GetShowTimesByMovie(tenPhim);

            // Load danh sách ngày chiếu có xuất chiếu
            LoadAvailableDates();

            // Đổ khung giờ theo ngày đã chọn
            if (cboNgayChieu.Items.Count > 0)
            {
                cboNgayChieu.SelectedIndex = 0;
            }

            // Hiển thị nơi chiếu mặc định
            UpdateLocation();
        }

        private void LoadAvailableDates()
        {
            cboNgayChieu.Items.Clear();

            if (showTimes == null) return;

            // Lấy danh sách ngày chiếu duy nhất và sắp xếp
            var dates = showTimes.AsEnumerable()
                                 .Select(r => Convert.ToDateTime(r["ShowDate"]).Date)
                                 .Distinct()
                                 .OrderBy(d => d)
                                 .ToList();

            // Đổ vào ComboBox với định dạng đẹp
            foreach (var date in dates)
            {
                string dayOfWeek = date.ToString("dddd", new System.Globalization.CultureInfo("vi-VN"));
                string formattedDate = $"{date:dd/MM/yyyy} ({dayOfWeek})";
                cboNgayChieu.Items.Add(formattedDate);
            }
        }

        private DateTime GetSelectedDate()
        {
            if (cboNgayChieu.SelectedItem == null)
                return DateTime.Now.Date;

            // Lấy ngày từ chuỗi "dd/MM/yyyy (thứ X)"
            string selectedText = cboNgayChieu.SelectedItem.ToString();
            string dateText = selectedText.Split('(')[0].Trim();
            return DateTime.ParseExact(dateText, "dd/MM/yyyy", null);
        }

        private void LoadKhungGio(DateTime selectedDate)
        {
            cboKhungGio.Items.Clear();

            if (showTimes == null) return;

            var times = showTimes.AsEnumerable()
                                 .Where(r => Convert.ToDateTime(r["ShowDate"]).Date == selectedDate)
                                 .Select(r => r["ShowTime"].ToString())
                                 .OrderBy(t => t)
                                 .ToList();

            foreach (var t in times)
            {
                cboKhungGio.Items.Add(t);
            }

            if (cboKhungGio.Items.Count > 0)
                cboKhungGio.SelectedIndex = 0;
        }

        private void UpdateLocation()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable showTimes = db.GetShowTimesByMovie(lblTenPhim.Text);

            var selectedDate = GetSelectedDate();
            var selectedTime = cboKhungGio.SelectedItem?.ToString();

            var row = showTimes.AsEnumerable()
                               .FirstOrDefault(r => Convert.ToDateTime(r["ShowDate"]).Date == selectedDate
                                                 && r["ShowTime"].ToString() == selectedTime);

            if (row != null)
            {
                int showTimeId = Convert.ToInt32(row["ShowTimeID"]);
                lblLocal.Text = "Địa điểm: " + db.GetLocationName(showTimeId);
            }
            else
            {
                lblLocal.Text = "Địa điểm: (không xác định)";
            }
        }

        private void cboNgayChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reload khung giờ from cached showTimes
            DateTime selectedDate = GetSelectedDate();
            LoadKhungGio(selectedDate);
            UpdateLocation();
        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLocation();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (showTimes == null)
            {
                MessageBox.Show("Không có suất chiếu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDate = GetSelectedDate();
            var selectedTime = cboKhungGio.SelectedItem?.ToString();

            var row = showTimes.AsEnumerable()
                               .FirstOrDefault(r => Convert.ToDateTime(r["ShowDate"]).Date == selectedDate
                                                 && r["ShowTime"].ToString() == selectedTime);

            if (row == null)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int showTimeId = Convert.ToInt32(row["ShowTimeID"]);

            if (currentUser == null)
            {
                MessageBox.Show("Bạn cần đăng nhập để đặt vé.", "Yêu cầu đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var seatForm = new SeatSelectionForm(showTimeId, currentUser.UserId))
            {
                seatForm.ShowDialog();
            }
        }

        private void lblLocal_Click(object sender, EventArgs e)
        {
            // Không cần xử lý click
        }
    }
}
