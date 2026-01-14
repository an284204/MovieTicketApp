using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MovieTicketApp
{
    public partial class UC_TrangChuAdmin : UserControl
    {
        private readonly Image[] selectedImages = new Image[5];
        private PictureBox[] bannerImages;
        private Guna2Button[] bannerButtons;
        private Guna2Panel[] statusDots;
        private Label[] statusLabels;

        public UC_TrangChuAdmin()
        {
            InitializeComponent();
            CreateModernBannerUI();
            LoadBannerImages();
        }

        private void CreateModernBannerUI()
        {
            // Clear existing controls
            panelMain.Controls.Clear();

            // Initialize arrays
            bannerImages = new PictureBox[5];
            bannerButtons = new Guna2Button[5];
            statusDots = new Guna2Panel[5];
            statusLabels = new Label[5];

            // Stats cards row
            FlowLayoutPanel statsPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                Location = new Point(25, 20),
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                BackColor = Color.Transparent
            };

            statsPanel.Controls.Add(CreateStatCard("📷", "Tổng Banner", "5", Color.FromArgb(55, 90, 140)));
            statsPanel.Controls.Add(CreateStatCard("✓", "Đang hiển thị", "5", Color.FromArgb(40, 167, 69)));
            statsPanel.Controls.Add(CreateStatCard("📅", "Cập nhật lần cuối", DateTime.Now.ToString("dd/MM/yyyy"), Color.FromArgb(255, 152, 0)));

            panelMain.Controls.Add(statsPanel);

            // Section title
            Label sectionTitle = new Label
            {
                Text = "📋 Danh sách Banner",
                Font = new Font("Segoe UI Semibold", 14F),
                ForeColor = Color.FromArgb(30, 35, 48),
                Location = new Point(25, 115),
                AutoSize = true
            };
            panelMain.Controls.Add(sectionTitle);

            Label sectionSubtitle = new Label
            {
                Text = "Nhấn \"Chọn ảnh\" để tải lên banner mới",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(120, 120, 130),
                Location = new Point(25, 142),
                AutoSize = true
            };
            panelMain.Controls.Add(sectionSubtitle);

            int startY = 175;

            for (int i = 0; i < 5; i++)
            {
                // Modern card panel
                Guna2Panel bannerCard = new Guna2Panel
                {
                    Size = new Size(950, 125),
                    Location = new Point(25, startY + i * 135),
                    FillColor = Color.White,
                    BorderRadius = 12
                };
                bannerCard.ShadowDecoration.Enabled = true;
                bannerCard.ShadowDecoration.Depth = 10;
                bannerCard.ShadowDecoration.Color = Color.FromArgb(25, 0, 0, 0);

                // Badge
                Guna2Panel badge = new Guna2Panel
                {
                    Size = new Size(36, 36),
                    Location = new Point(15, 44),
                    FillColor = Color.FromArgb(55, 90, 140),
                    BorderRadius = 18
                };

                Label badgeText = new Label
                {
                    Text = (i + 1).ToString(),
                    Font = new Font("Segoe UI Semibold", 12F),
                    ForeColor = Color.White,
                    Size = new Size(36, 36),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                badge.Controls.Add(badgeText);
                bannerCard.Controls.Add(badge);

                // Banner label
                Label bannerLabel = new Label
                {
                    Text = string.Format("Banner {0}", i + 1),
                    Font = new Font("Segoe UI Semibold", 12F),
                    ForeColor = Color.FromArgb(30, 35, 48),
                    Location = new Point(65, 18),
                    AutoSize = true
                };
                bannerCard.Controls.Add(bannerLabel);

                Label bannerDesc = new Label
                {
                    Text = "Kích thước khuyến nghị: 1200 x 400 pixels",
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.FromArgb(150, 150, 160),
                    Location = new Point(65, 42),
                    AutoSize = true
                };
                bannerCard.Controls.Add(bannerDesc);

                // Status indicator
                statusDots[i] = new Guna2Panel
                {
                    Size = new Size(10, 10),
                    Location = new Point(65, 70),
                    FillColor = Color.FromArgb(200, 200, 200),
                    BorderRadius = 5
                };
                bannerCard.Controls.Add(statusDots[i]);

                statusLabels[i] = new Label
                {
                    Text = "Chưa có ảnh",
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.FromArgb(150, 150, 150),
                    Location = new Point(80, 67),
                    AutoSize = true
                };
                bannerCard.Controls.Add(statusLabels[i]);

                // PictureBox container
                Guna2Panel pbContainer = new Guna2Panel
                {
                    Size = new Size(310, 85),
                    Location = new Point(300, 20),
                    FillColor = Color.FromArgb(245, 247, 250),
                    BorderRadius = 8,
                    BorderColor = Color.FromArgb(220, 225, 230),
                    BorderThickness = 1
                };

                bannerImages[i] = new PictureBox
                {
                    Size = new Size(300, 75),
                    Location = new Point(5, 5),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.Transparent
                };
                pbContainer.Controls.Add(bannerImages[i]);
                bannerCard.Controls.Add(pbContainer);

                // Select button
                bannerButtons[i] = new Guna2Button
                {
                    Text = "Chọn ảnh",
                    Size = new Size(130, 40),
                    Location = new Point(640, 42),
                    FillColor = Color.FromArgb(55, 90, 140),
                    ForeColor = Color.White,
                    BorderRadius = 10,
                    Font = new Font("Segoe UI Semibold", 10F),
                    Tag = i,
                    Animated = true
                };
                bannerButtons[i].ShadowDecoration.Enabled = true;
                bannerButtons[i].ShadowDecoration.Depth = 5;
                bannerButtons[i].ShadowDecoration.Color = Color.FromArgb(30, 55, 90, 140);
                bannerButtons[i].HoverState.FillColor = Color.FromArgb(70, 110, 165);
                bannerButtons[i].Click += SelectBanner_Click;
                bannerCard.Controls.Add(bannerButtons[i]);

                // Remove button
                int idx = i;
                Guna2Button btnRemove = new Guna2Button
                {
                    Text = "X",
                    Size = new Size(40, 40),
                    Location = new Point(785, 42),
                    FillColor = Color.FromArgb(220, 53, 69),
                    ForeColor = Color.White,
                    BorderRadius = 10,
                    Font = new Font("Segoe UI Bold", 11F),
                    Animated = true
                };
                btnRemove.HoverState.FillColor = Color.FromArgb(200, 35, 50);
                btnRemove.Click += (s, e) =>
                {
                    if (bannerImages[idx].Image != null)
                    {
                        bannerImages[idx].Image = null;
                        selectedImages[idx]?.Dispose();
                        selectedImages[idx] = null;
                        UpdateBannerStatus(idx, false);
                    }
                };
                bannerCard.Controls.Add(btnRemove);

                panelMain.Controls.Add(bannerCard);
            }

            // Save All button
            btnSaveAll.Location = new Point(25, startY + 5 * 135 + 15);
            btnSaveAll.Click -= BtnSaveAll_Click;
            btnSaveAll.Click += BtnSaveAll_Click;
            panelMain.Controls.Add(btnSaveAll);
        }

        private Guna2Panel CreateStatCard(string icon, string title, string value, Color accentColor)
        {
            Guna2Panel card = new Guna2Panel
            {
                Size = new Size(220, 85),
                Margin = new Padding(0, 0, 20, 0),
                FillColor = Color.White,
                BorderRadius = 12
            };
            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.Depth = 10;
            card.ShadowDecoration.Color = Color.FromArgb(25, 0, 0, 0);

            // Icon label
            Label iconLabel = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 18F),
                ForeColor = accentColor,
                Location = new Point(15, 22),
                AutoSize = true
            };
            card.Controls.Add(iconLabel);

            Label titleLabel = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(120, 120, 130),
                Location = new Point(55, 15),
                AutoSize = true
            };
            card.Controls.Add(titleLabel);

            Label valueLabel = new Label
            {
                Text = value,
                Font = new Font("Segoe UI Semibold", 16F),
                ForeColor = accentColor,
                Location = new Point(55, 38),
                AutoSize = true
            };
            card.Controls.Add(valueLabel);

            return card;
        }

        private void UpdateBannerStatus(int index, bool hasImage)
        {
            if (hasImage)
            {
                statusDots[index].FillColor = Color.FromArgb(40, 167, 69);
                statusLabels[index].Text = "Đang hiển thị";
                statusLabels[index].ForeColor = Color.FromArgb(40, 167, 69);
            }
            else
            {
                statusDots[index].FillColor = Color.FromArgb(200, 200, 200);
                statusLabels[index].Text = "Chưa có ảnh";
                statusLabels[index].ForeColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void SelectBanner_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna2Button;
            if (btn == null || btn.Tag == null) return;

            int index = (int)btn.Tag;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var tempImg = Image.FromFile(ofd.FileName))
                        {
                            selectedImages[index]?.Dispose();
                            selectedImages[index] = new Bitmap(tempImg);
                        }

                        bannerImages[index].Image = selectedImages[index];
                        bannerImages[index].SizeMode = PictureBoxSizeMode.Zoom;
                        bannerImages[index].Tag = Path.GetExtension(ofd.FileName);
                        UpdateBannerStatus(index, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void BtnSaveAll_Click(object sender, EventArgs e)
        {
            string folder = Path.Combine(Application.StartupPath, "Images", "Banner");
            Directory.CreateDirectory(folder);

            int savedCount = 0;
            for (int i = 0; i < 5; i++)
            {
                if (selectedImages[i] != null)
                {
                    string ext = bannerImages[i].Tag?.ToString() ?? ".jpg";
                    string filePath = Path.Combine(folder, string.Format("banner{0}{1}", i + 1, ext));

                    try
                    {
                        if (ext.ToLower() == ".png")
                            selectedImages[i].Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                        else
                            selectedImages[i].Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                        savedCount++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("Lỗi khi lưu banner {0}: {1}", i + 1, ex.Message));
                    }
                }
            }

            MessageBox.Show(string.Format("Đã lưu {0}/5 banner!", savedCount), "Thông báo");
        }

        private void LoadBannerImages()
        {
            string folder = Path.Combine(Application.StartupPath, "Images", "Banner");
            if (!Directory.Exists(folder)) return;

            for (int i = 0; i < 5; i++)
            {
                string jpgPath = Path.Combine(folder, string.Format("banner{0}.jpg", i + 1));
                string pngPath = Path.Combine(folder, string.Format("banner{0}.png", i + 1));

                string filePath = File.Exists(pngPath) ? pngPath : jpgPath;

                if (File.Exists(filePath))
                {
                    try
                    {
                        using (var tempImg = Image.FromFile(filePath))
                        {
                            selectedImages[i]?.Dispose();
                            selectedImages[i] = new Bitmap(tempImg);
                        }

                        bannerImages[i].Image = selectedImages[i];
                        bannerImages[i].SizeMode = PictureBoxSizeMode.Zoom;
                        bannerImages[i].Tag = Path.GetExtension(filePath);
                        UpdateBannerStatus(i, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("Lỗi khi tải banner {0}: {1}", i + 1, ex.Message));
                    }
                }
            }
        }
    }
}
