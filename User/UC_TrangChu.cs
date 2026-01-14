using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Data;
using Guna.UI2.WinForms;
using System.Drawing.Drawing2D;

namespace MovieTicketApp
{
    public partial class UC_TrangChu : UserControl
    {
        private List<Image> bannerImages = new List<Image>();
        private List<DataRow> bannerMovies = new List<DataRow>();
        private int currentBannerIndex = 0;
        private UserInfo currentUser;
        private DataRow currentFeaturedMovie; // Phim đang hiển thị (phim hot đầu tiên)
        private int carouselStartIndex = 0; // Vị trí bắt đầu của carousel 5 banner
        
        // Khắc phục: Xóa bỏ dòng khai báo miniPictures nếu không dùng
        // private Guna.UI2.WinForms.Guna2PictureBox[] miniPictures; // Tùy chọn: Xóa trong Designer.cs nếu không cần

        public UC_TrangChu()
        {
            InitializeComponent();
            this.Load += UC_TrangChu_Load;
            
            // Đảm bảo panelMiniCarousel được phủ màu nền tối
            panelMiniCarousel.BackColor = Color.FromArgb(20, 20, 30);
            
            // Initialize mini carousel
            InitializeMiniCarousel();
        }

        public UC_TrangChu(UserInfo user) : this()
        {
            currentUser = user;
        }

        public void SetUser(UserInfo user)
        {
            currentUser = user;
        }

        private void UC_TrangChu_Load(object sender, EventArgs e)
        {
            LoadBanners();
            // LoadFeaturedMovie(); // Không cần thiết, đã được gọi trong LoadBanners/ShowBanner
            LoadHotMovies();
            LoadRecommendedMovies();
            
            // Hiển thị overlay thông tin phim
            panelOverlay.Visible = true;
            panelOverlay.BackColor = Color.Transparent;
            panelOverlay.BringToFront();
            
            if (bannerImages.Count > 0)
            {
                currentBannerIndex = 0;
                // ShowBanner(0); // Không cần gọi ShowBanner riêng nữa
                UpdateMiniCarousel(); // Cập nhật banner và thông tin phim
                timerBanner.Start();
            }
        }

        private void InitializeMiniCarousel()
        {
            // Khắc phục: Đảm bảo pictureBanner bị ẩn và panelMiniCarousel hiển thị đúng
            pictureBanner.Visible = false;
            
            // Đưa overlay và buttons lên trên
            panelOverlay.BringToFront();
            btnCarouselPrev.BringToFront();
            btnCarouselNext.BringToFront();
            
            // Khắc phục: Thay vì sử dụng miniPictures = new Guna2PictureBox[0], 
            // bạn nên xóa khai báo miniPictures khỏi Designer.cs nếu không dùng.
            // Nếu vẫn muốn giữ khai báo:
            if (miniPictures == null) 
            {
                miniPictures = new Guna2PictureBox[0]; 
            }
        }

        private void UpdateMiniCarousel()
        {
            if (bannerImages.Count == 0) return;
            
            // Hiển thị banner chính ngay trên panel nền
            panelMiniCarousel.BackgroundImage = bannerImages[currentBannerIndex];
            panelMiniCarousel.BackgroundImageLayout = ImageLayout.Stretch;
            
            // Khắc phục: Đảm bảo panelOverlay luôn được đặt trên cùng
            panelOverlay.BringToFront();
            
            // Cập nhật thông tin phim
            if (bannerMovies.Count > currentBannerIndex)
            {
                currentFeaturedMovie = bannerMovies[currentBannerIndex];
                UpdateFeaturedMovieInfo();
            }
        }

        private void MiniPicture_Click(int relativeIndex)
        {
            if (bannerImages.Count == 0) return;
            
            currentBannerIndex = relativeIndex % bannerImages.Count;
            
            // Update banner và featured movie info
            UpdateMiniCarousel();
            
            if (bannerMovies.Count > currentBannerIndex)
            {
                currentFeaturedMovie = bannerMovies[currentBannerIndex];
                UpdateFeaturedMovieInfo();
            }
            
            timerBanner.Stop();
            timerBanner.Start();
        }

        private void btnCarouselPrev_Click(object sender, EventArgs e)
        {
            if (bannerImages.Count == 0) return;
            
            currentBannerIndex = (currentBannerIndex - 1 + bannerImages.Count) % bannerImages.Count;
            UpdateMiniCarousel();
            
            if (bannerMovies.Count > currentBannerIndex)
            {
                currentFeaturedMovie = bannerMovies[currentBannerIndex];
                UpdateFeaturedMovieInfo();
            }
            
            timerBanner.Stop();
            timerBanner.Start();
        }

        private void btnCarouselNext_Click(object sender, EventArgs e)
        {
            if (bannerImages.Count == 0) return;
            
            currentBannerIndex = (currentBannerIndex + 1) % bannerImages.Count;
            UpdateMiniCarousel();
            
            if (bannerMovies.Count > currentBannerIndex)
            {
                currentFeaturedMovie = bannerMovies[currentBannerIndex];
                UpdateFeaturedMovieInfo();
            }
            
            timerBanner.Stop();
            timerBanner.Start();
        }

        private void UpdateFeaturedMovieInfo()
        {
            if (currentFeaturedMovie == null) return;
            
            lblBannerTitle.Text = currentFeaturedMovie["Title"].ToString();
            lblBannerGenre.Text = currentFeaturedMovie["Genre"].ToString() + " | " + 
                                 currentFeaturedMovie["Duration"].ToString();
            lblBannerDescription.Text = currentFeaturedMovie["Description"].ToString();
        }

        private void LoadBanners()
        {
            bannerImages.Clear();
            bannerMovies.Clear();

            // Load banners từ thư mục Images/Banner trước
            string bannerFolder = Path.Combine(Application.StartupPath, "Images", "Banner");
            if (Directory.Exists(bannerFolder))
            {
                string[] bannerFiles = new string[] { "banner1.jpg", "banner2.jpg", "banner3.jpg", "banner4.jpg", "banner5.jpg" };
                foreach (string bannerFile in bannerFiles)
                {
                    string file = Path.Combine(bannerFolder, bannerFile);
                    if (File.Exists(file))
                    {
                        // Khắc phục lỗi file bị khóa: Clone ảnh trước khi thêm
                        try
                        {
                            using (Image original = Image.FromFile(file))
                            {
                                bannerImages.Add(new Bitmap(original));
                            }
                            bannerMovies.Add(null);
                        }
                        catch (Exception ex)
                        {
                            // Bỏ qua nếu không load được ảnh
                            Console.WriteLine($"Error loading banner image {file}: {ex.Message}");
                        }
                    }
                }
            }

            // Nếu không có banner, fallback sang load từ phim hot
            if (bannerImages.Count == 0)
            {
                DatabaseHelper db = new DatabaseHelper();
                DataTable featuredMovies = db.GetTopHotMovies(5);

                string folder = Path.Combine(Application.StartupPath, "Images", "Movies");

                foreach (DataRow row in featuredMovies.Rows)
                {
                    string posterPath = Path.Combine(folder, row["Poster"].ToString());
                    if (File.Exists(posterPath))
                    {
                        // Khắc phục lỗi file bị khóa: Clone ảnh trước khi thêm
                        try
                        {
                            using (Image original = Image.FromFile(posterPath))
                            {
                                bannerImages.Add(new Bitmap(original));
                            }
                            bannerMovies.Add(row);
                        }
                        catch (Exception ex)
                        {
                            // Bỏ qua nếu không load được ảnh
                            Console.WriteLine($"Error loading movie poster: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void ShowBanner(int index)
        {
            if (index < 0 || index >= bannerImages.Count) return;

            // Khắc phục: Không dùng pictureBanner nữa, chỉ cần gọi UpdateMiniCarousel
            // pictureBanner.Image = bannerImages[index];
            // pictureBanner.SendToBack();
            panelOverlay.BringToFront();
        }

        private void LoadFeaturedMovie()
        {
            // Không cần load riêng, sẽ dùng bannerMovies trong UpdateMiniCarousel
        }

        private void LoadHotMovies()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable hotMovies = db.GetTopHotMovies(8);

            flowPhimHot.Controls.Clear();

            foreach (DataRow row in hotMovies.Rows)
            {
                var card = CreateMovieCard(row);
                flowPhimHot.Controls.Add(card);
            }
        }

        private void LoadRecommendedMovies()
        {
            DatabaseHelper db = new DatabaseHelper();
            // Giả sử có một hàm lấy phim đề xuất khác
            // Hiện tại dùng tạm GetTopHotMovies(8)
            DataTable movies = db.GetTopHotMovies(8); 

            flowRecommend.Controls.Clear();

            foreach (DataRow row in movies.Rows)
            {
                var card = CreateMovieCard(row);
                flowRecommend.Controls.Add(card);
            }
        }

        private Guna2Panel CreateMovieCard(DataRow movieData)
        {
            // Main card panel
            Guna2Panel card = new Guna2Panel();
            card.Size = new Size(200, 300);
            card.Margin = new Padding(10);
            card.BorderRadius = 12;
            card.FillColor = Color.FromArgb(30, 30, 45);
            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.Depth = 20;
            card.ShadowDecoration.Color = Color.Black;
            card.Cursor = Cursors.Hand;
            card.Tag = movieData; // Store movie data

            // Poster image
            Guna2PictureBox pic = new Guna2PictureBox();
            pic.Location = new Point(0, 0);
            pic.Size = new Size(200, 240);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.BorderRadius = 12;
            
            string folder = Path.Combine(Application.StartupPath, "Images", "Movies");
            string posterPath = Path.Combine(folder, movieData["Poster"].ToString());
            if (File.Exists(posterPath))
            {
                // Khắc phục lỗi file bị khóa: Clone ảnh
                try
                {
                    using (Image original = Image.FromFile(posterPath))
                    {
                        pic.Image = new Bitmap(original);
                    }
                }
                catch (Exception)
                {
                    pic.FillColor = Color.FromArgb(50, 50, 70);
                }
            }
            else
                pic.FillColor = Color.FromArgb(50, 50, 70);

            // Movie title
            Label lblTitle = new Label();
            lblTitle.Text = movieData["Title"].ToString();
            lblTitle.Location = new Point(5, 245);
            lblTitle.Size = new Size(190, 25);
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Tickets sold / popularity indicator
            Label lblTickets = new Label();
            lblTickets.Text = $"🎫 {movieData["TotalTickets"]} vé";
            lblTickets.Location = new Point(5, 270);
            lblTickets.Size = new Size(190, 20);
            lblTickets.ForeColor = Color.FromArgb(200, 200, 200);
            lblTickets.Font = new Font("Segoe UI", 9);
            lblTickets.TextAlign = ContentAlignment.MiddleCenter;

            card.Controls.Add(lblTickets);
            card.Controls.Add(lblTitle);
            card.Controls.Add(pic);

            EventHandler cardClick = (s, e) => OpenMovieDetail(movieData);
            card.Click += cardClick;
            pic.Click += cardClick;
            lblTitle.Click += cardClick;
            lblTickets.Click += cardClick;

            card.MouseEnter += (s, e) =>
            {
                card.ShadowDecoration.Depth = 30;
                card.FillColor = Color.FromArgb(40, 40, 55);
            };

            card.MouseLeave += (s, e) =>
            {
                card.ShadowDecoration.Depth = 20;
                card.FillColor = Color.FromArgb(30, 30, 45);
            };

            return card;
        }

        private void OpenMovieDetail(DataRow movieData)
        {
            if (movieData == null) return;

            string tenPhim = movieData["Title"].ToString();
            string thoiLuong = movieData["Duration"]?.ToString() ?? string.Empty;
            string moTa = movieData["Description"]?.ToString() ?? string.Empty;
            string theLoai = movieData["Genre"]?.ToString() ?? string.Empty;
            string poster = movieData["Poster"]?.ToString() ?? string.Empty;

            MovieDetailForm detailForm = new MovieDetailForm(tenPhim, thoiLuong, moTa, theLoai, poster, currentUser);
            detailForm.ShowDialog();
        }

        private void timerBanner_Tick(object sender, EventArgs e)
        {
            if (bannerImages.Count == 0) return;

            currentBannerIndex = (currentBannerIndex + 1) % bannerImages.Count;
            UpdateMiniCarousel();

            if (bannerMovies.Count > currentBannerIndex)
            {
                currentFeaturedMovie = bannerMovies[currentBannerIndex];
                UpdateFeaturedMovieInfo();
            }
        }

        private void btnPlayNow_Click(object sender, EventArgs e)
        {
            if (currentFeaturedMovie != null)
            {
                OpenMovieDetail(currentFeaturedMovie);
                return;
            }

            MessageBox.Show("Không có thông tin phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            btnPlayNow_Click(sender, e);
        }
    }
}