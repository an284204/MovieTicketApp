using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_QLPhim : UserControl
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private int selectedMovieId = -1;
        private string posterPath = "";

        public UC_QLPhim()
        {
            InitializeComponent();
            this.Load += UC_QLPhim_Load;
            btnChonAnh.Click += BtnChonAnh_Click;
            dgvPhim.CellClick += dgvPhim_CellClick;
        }

        // ✅ Nạp danh sách phim từ DB
        private void UC_QLPhim_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            dgvPhim.DataSource = db.GetMovies();
            dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhim.RowTemplate.Height = 30;
            dgvPhim.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPhim.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Ẩn cột Poster để không hiển thị đường dẫn
            if (dgvPhim.Columns["Poster"] != null)
                dgvPhim.Columns["Poster"].Visible = false;
        }

        // ✅ Chọn ảnh poster
        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                open.Title = "Chọn ảnh poster phim";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    posterPath = open.FileName;
                    picPoster.Image = Image.FromFile(open.FileName);
                    picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        // ✅ Thêm phim
        private void btnThem_Click(object sender, EventArgs e)
        {
            string title = txtTenPhim.Text.Trim();
            string genre = txtTheLoai.Text.Trim();
            int duration = int.Parse(txtThoiLuong.Text.Trim());
            string description = txtMoTa.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            db.InsertMovie(title, duration, posterPath, description, genre);
            MessageBox.Show("Thêm phim thành công!");
            LoadMovies();
        }

        // ✅ Sửa phim
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMovieId == -1)
            {
                MessageBox.Show("Vui lòng chọn phim cần sửa!");
                return;
            }

            string title = txtTenPhim.Text.Trim();
            string genre = txtTheLoai.Text.Trim();
            int duration = int.Parse(txtThoiLuong.Text.Trim());
            string description = txtMoTa.Text.Trim();

            db.UpdateMovie(selectedMovieId, title, duration, posterPath, description, genre);
            MessageBox.Show("Cập nhật phim thành công!");
            LoadMovies();
        }

        // ✅ Xóa phim
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMovieId == -1)
            {
                MessageBox.Show("Vui lòng chọn phim cần xóa!");
                return;
            }

            db.DeleteMovie(selectedMovieId);
            MessageBox.Show("Xóa phim thành công!");
            LoadMovies();
        }

        // ✅ Khi click vào phim trong bảng
        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhim.Rows[e.RowIndex];
                selectedMovieId = Convert.ToInt32(row.Cells["MovieID"].Value);

                txtTenPhim.Text = row.Cells["Title"].Value.ToString();
                txtTheLoai.Text = row.Cells["Genre"].Value.ToString();
                txtThoiLuong.Text = row.Cells["Duration"].Value.ToString();
                txtMoTa.Text = row.Cells["Description"].Value.ToString();

                // Load poster nếu có
                string poster = row.Cells["Poster"].Value.ToString();
                if (!string.IsNullOrEmpty(poster) && File.Exists(poster))
                {
                    picPoster.Image = Image.FromFile(poster);
                    picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    posterPath = poster;
                }
                else
                {
                    picPoster.Image = null;
                    posterPath = "";
                }
            }
        }
    }
}