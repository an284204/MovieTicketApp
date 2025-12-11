using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class MovieDetailForm : Form
    {
        public MovieDetailForm(string tenPhim, string thoiLuong, string description, string genre, string posterFile)
        {
            InitializeComponent();

            // Hiển thị dữ liệu lên các control
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
            DatabaseHelper db = new DatabaseHelper();
            DataTable showTimes = db.GetShowTimesByMovie(tenPhim);

            // Lấy danh sách ngày chiếu duy nhất
            var dates = showTimes.AsEnumerable()
                                 .Select(r => Convert.ToDateTime(r["ShowDate"]).Date)
                                 .Distinct()
                                 .ToList();

            // Nếu có ngày chiếu thì set vào DateTimePicker
            if (dates.Any())
            {
                dtpNgayChieu.Value = dates.First(); // mặc định ngày đầu tiên
            }

            // Đổ khung giờ theo ngày đã chọn
            LoadKhungGio(showTimes, dtpNgayChieu.Value.Date);
        }
        private void LoadKhungGio(DataTable showTimes, DateTime selectedDate)
        {
            cboKhungGio.Items.Clear();

            var times = showTimes.AsEnumerable()
                                 .Where(r => Convert.ToDateTime(r["ShowDate"]).Date == selectedDate)
                                 .Select(r => r["ShowTime"].ToString())
                                 .ToList();

            foreach (var t in times)
            {
                cboKhungGio.Items.Add(t);
            }

            if (cboKhungGio.Items.Count > 0)
                cboKhungGio.SelectedIndex = 0;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable showTimes = db.GetShowTimesByMovie(lblTenPhim.Text);

            LoadKhungGio(showTimes, dtpNgayChieu.Value.Date);

        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
