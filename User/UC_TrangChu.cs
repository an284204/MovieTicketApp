using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Data;

namespace MovieTicketApp
{
    public partial class UC_TrangChu : UserControl
    {
        private List<Image> bannerImages = new List<Image>();
        private int currentBannerIndex = 0;

        public UC_TrangChu()
        {
            InitializeComponent();
            this.Load += UC_TrangChu_Load;
        }

        private void UC_TrangChu_Load(object sender, EventArgs e)
        {
            LoadHotMovies();
            LoadBanners();
            if (bannerImages.Count > 0)
            {
                pictureBanner.Image = bannerImages[0];
                timerBanner.Start();
            }
        }

        private void pictureBanner_Click(object sender, EventArgs e) { }

        private void LoadBanners()
        {
            string folder = Path.Combine(Application.StartupPath, "Images", "Banner");
            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

            bannerImages.Clear();
            for (int i = 1; i <= 5; i++)
            {
                string file = Path.Combine(folder, $"banner{i}.jpg");
                if (File.Exists(file))
                    bannerImages.Add(Image.FromFile(file));
            }
        }

        private async Task FadeToNextBanner()
        {
            if (bannerImages.Count == 0) return;

            for (int i = 100; i >= 0; i -= 5)
            {
                pictureBanner.Image = SetImageOpacity(bannerImages[currentBannerIndex], i / 100f);
                await Task.Delay(8);
            }

            currentBannerIndex = (currentBannerIndex + 1) % bannerImages.Count;

            for (int i = 0; i <= 100; i += 5)
            {
                pictureBanner.Image = SetImageOpacity(bannerImages[currentBannerIndex], i / 100f);
                await Task.Delay(8);
            }
        }

        private Bitmap SetImageOpacity(Image img, float opacity)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix { Matrix33 = opacity };
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }
        private void LoadHotMovies()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable hotMovies = db.GetTopHotMovies(4);

            flowPhimHot.Controls.Clear();

            foreach (DataRow row in hotMovies.Rows)
            {
                Panel card = new Panel();
                card.Size = new Size(180, 260);
                card.Margin = new Padding(10);
                card.BorderStyle = BorderStyle.FixedSingle;

                // Poster
                PictureBox pic = new PictureBox();
                pic.Dock = DockStyle.Top;
                pic.Height = 200;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                string folder = Path.Combine(Application.StartupPath, "Images", "Movies");
                string posterPath = Path.Combine(folder, row["Poster"].ToString());
                if (File.Exists(posterPath))
                    pic.Image = Image.FromFile(posterPath);

                // Tên phim
                Label lblTitle = new Label();
                lblTitle.Text = row["Title"].ToString();
                lblTitle.Dock = DockStyle.Top;
                lblTitle.TextAlign = ContentAlignment.MiddleCenter;
                lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblTitle.Height = 30;

                // Số vé đã đặt
                Label lblTickets = new Label();
                lblTickets.Text = $"Vé đã đặt: {row["TotalTickets"]}";
                lblTickets.Dock = DockStyle.Top;
                lblTickets.TextAlign = ContentAlignment.MiddleCenter;
                lblTickets.Font = new Font("Segoe UI", 9);
                lblTickets.Height = 20;

                card.Controls.Add(lblTickets);
                card.Controls.Add(lblTitle);
                card.Controls.Add(pic);

                flowPhimHot.Controls.Add(card);
            }
        }

        private async void timerBanner_Tick(object sender, EventArgs e)
        {
            await FadeToNextBanner();
        }

        private void flowPhimHot_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}