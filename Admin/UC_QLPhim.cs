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

        private void UC_QLPhim_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            try
            {
                dgvPhim.DataSource = db.GetMovies();
                dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhim.RowTemplate.Height = 30;
                dgvPhim.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgvPhim.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                if (dgvPhim.Columns["Poster"] != null)
                    dgvPhim.Columns["Poster"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phim: " + ex.Message);
            }
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                open.Title = "Chọn ảnh poster phim";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        posterPath = open.FileName;
                        picPoster.Image?.Dispose(); 
                        picPoster.Image = Image.FromFile(open.FileName);
                        picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string title = txtTenPhim.Text.Trim();
            string genre = txtTheLoai.Text.Trim();
            string description = txtMoTa.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(txtThoiLuong.Text.Trim(), out int duration))
            {
                MessageBox.Show("Thời lượng phải là số nguyên!");
                return;
            }

            try
            {
                db.InsertMovie(title, duration, posterPath, description, genre);
                MessageBox.Show("Thêm phim thành công!");
                LoadMovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phim: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMovieId == -1)
            {
                MessageBox.Show("Vui lòng chọn phim cần sửa!");
                return;
            }

            string title = txtTenPhim.Text.Trim();
            string genre = txtTheLoai.Text.Trim();
            string description = txtMoTa.Text.Trim();

            if (!int.TryParse(txtThoiLuong.Text.Trim(), out int duration))
            {
                MessageBox.Show("Thời lượng phải là số nguyên!");
                return;
            }

            try
            {
                db.UpdateMovie(selectedMovieId, title, duration, posterPath, description, genre);
                MessageBox.Show("Cập nhật phim thành công!");
                LoadMovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phim: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMovieId == -1)
            {
                MessageBox.Show("Vui lòng chọn phim cần xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa phim này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    db.DeleteMovieSafe(selectedMovieId); 
                    MessageBox.Show("Xóa phim thành công!");
                    LoadMovies();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phim: " + ex.Message);
                }
            }
        }

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

                string poster = row.Cells["Poster"].Value?.ToString();
                if (!string.IsNullOrEmpty(poster) && File.Exists(poster))
                {
                    try
                    {
                        picPoster.Image?.Dispose();
                        picPoster.Image = Image.FromFile(poster);
                        picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                        posterPath = poster;
                    }
                    catch
                    {
                        picPoster.Image = null;
                        posterPath = "";
                    }
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