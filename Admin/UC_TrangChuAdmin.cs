using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_TrangChuAdmin : UserControl
    {
        // Lưu 5 ảnh đã chọn
        private readonly Image[] selectedImages = new Image[5];

        // Mảng ánh xạ controls
        private PictureBox[] bannerImages;
        private Guna.UI2.WinForms.Guna2Button[] bannerButtons;

        public UC_TrangChuAdmin()
        {
            InitializeComponent();

            // Tạo UI cho 5 banner sau InitializeComponent
            CreateBannerUI(bannerPanel1, pb1, btnSelect1, 1, 60);
            CreateBannerUI(bannerPanel2, pb2, btnSelect2, 2, 230);
            CreateBannerUI(bannerPanel3, pb3, btnSelect3, 3, 400);
            CreateBannerUI(bannerPanel4, pb4, btnSelect4, 4, 570);
            CreateBannerUI(bannerPanel5, pb5, btnSelect5, 5, 740);

            // Ánh xạ control vào mảng
            bannerImages = new[] { pb1, pb2, pb3, pb4, pb5 };
            bannerButtons = new[] { btnSelect1, btnSelect2, btnSelect3, btnSelect4, btnSelect5 };

            // Gắn event cho SaveAll ở đây để đúng PascalCase
            this.btnSaveAll.Click += BtnSaveAll_Click;

            LoadBannerImages();
        }

        private void CreateBannerUI(Guna.UI2.WinForms.Guna2Panel panel, PictureBox pb, Guna.UI2.WinForms.Guna2Button btn, int index, int top)
        {
            panel.Size = new Size(650, 150);
            panel.BorderRadius = 10;
            panel.BorderThickness = 1;
            panel.BorderColor = Color.Gray;
            panel.FillColor = Color.White;
            panel.Location = new Point(20, top);

            pb.Size = new Size(300, 120);
            pb.Location = new Point(15, 15);
            pb.BackColor = Color.LightGray;
            pb.SizeMode = PictureBoxSizeMode.Zoom;

            btn.Text = $"Chọn ảnh {index}";
            btn.Size = new Size(200, 45);
            btn.Location = new Point(330, 45);
            btn.Tag = index - 1;
            btn.BorderRadius = 8;
            btn.FillColor = Color.FromArgb(30, 136, 229);
            btn.ForeColor = Color.White;

            // Gắn event chọn ảnh với tên chuẩn PascalCase
            btn.Click += SelectBanner_Click;

            // Thêm vào panel và main
            panel.Controls.Add(pb);
            panel.Controls.Add(btn);
            this.panelMain.Controls.Add(panel);
        }

        // Chọn ảnh
        private void SelectBanner_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna.UI2.WinForms.Guna2Button;
            if (btn == null || btn.Tag == null) return;

            int index = (int)btn.Tag;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var tempImg = Image.FromFile(ofd.FileName))
                    {
                        selectedImages[index] = new Bitmap(tempImg);
                    }

                    bannerImages[index].Image = selectedImages[index];
                    bannerImages[index].SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        // Lưu ảnh
        private void BtnSaveAll_Click(object sender, EventArgs e)
        {
            string folder = Path.Combine(Application.StartupPath, "Images", "Banner");
            Directory.CreateDirectory(folder);

            for (int i = 0; i < 5; i++)
            {
                if (selectedImages[i] != null)
                {
                    string filePath = Path.Combine(folder, $"banner{i + 1}.jpg");
                    selectedImages[i].Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }

            MessageBox.Show(" Banner đã được lưu!", "Thông báo");
        }

        // Load ảnh đã lưu
        private void LoadBannerImages()
        {
            string folder = Path.Combine(Application.StartupPath, "Images", "Banner");
            if (!Directory.Exists(folder)) return;

            for (int i = 0; i < 5; i++)
            {
                string filePath = Path.Combine(folder, $"banner{i + 1}.jpg");
                if (File.Exists(filePath))
                {
                    using (var tempImg = Image.FromFile(filePath))
                    {
                        selectedImages[i] = new Bitmap(tempImg);
                    }

                    bannerImages[i].Image = selectedImages[i];
                    bannerImages[i].SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}