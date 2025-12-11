using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_QLDoAn : UserControl
    {
        private string selectedImagePath = "";
        private DatabaseHelper db = new DatabaseHelper();

        public UC_QLDoAn()
        {
            InitializeComponent();
            this.Load += UC_QLDoAn_Load;
        }

        private void UC_QLDoAn_Load(object sender, EventArgs e)
        {
            LoadFoodData();
        }

        // Load dữ liệu từ DB vào DataGridView
        private void LoadFoodData()
        {
            DataTable dt = db.GetFood();
            dgvDoAn.DataSource = dt;

            // Đổi tên header các cột
            if (dgvDoAn.Columns.Contains("FoodID"))
                dgvDoAn.Columns["FoodID"].HeaderText = "Mã món";
            if (dgvDoAn.Columns.Contains("Name"))
                dgvDoAn.Columns["Name"].HeaderText = "Tên món ăn";
            if (dgvDoAn.Columns.Contains("Price"))
                dgvDoAn.Columns["Price"].HeaderText = "Giá (VNĐ)";
            if (dgvDoAn.Columns.Contains("Stock"))
                dgvDoAn.Columns["Stock"].HeaderText = "Số lượng tồn";
            if (dgvDoAn.Columns.Contains("ImageURL"))
                dgvDoAn.Columns["ImageURL"].HeaderText = "Ảnh";
            if (dgvDoAn.Columns.Contains("TitleFood"))
                dgvDoAn.Columns["TitleFood"].HeaderText = "Loại";

            // Style bảng cho đẹp
            dgvDoAn.EnableHeadersVisualStyles = false;
            dgvDoAn.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvDoAn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDoAn.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            dgvDoAn.DefaultCellStyle.BackColor = Color.White;
            dgvDoAn.DefaultCellStyle.ForeColor = Color.Black;
            dgvDoAn.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvDoAn.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDoAn.DefaultCellStyle.Font = new Font("Segoe UI", 10F);

            dgvDoAn.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvDoAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Chọn ảnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                picAnh.Image = Image.FromFile(selectedImagePath);
            }
        }

        // Thêm đồ ăn
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenDoAn.Text.Trim();
            string giaText = txtGia.Text.Trim();
            string loai = cboLoai.SelectedItem?.ToString();
            string moTa = txtStock.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(giaText) || string.IsNullOrEmpty(loai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(giaText, out int gia))
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            string imageFileName = System.IO.Path.GetFileName(selectedImagePath);

            bool success = db.InsertFood(ten, gia, imageFileName, loai, moTa);

            if (success)
            {
                MessageBox.Show("Thêm đồ ăn thành công!");
                ClearForm();
                LoadFoodData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        // Làm mới form
        private void ClearForm()
        {
            txtTenDoAn.Text = "";
            txtGia.Text = "";
            cboLoai.SelectedIndex = -1;
            txtStock.Text = "";
            picAnh.Image = null;
            selectedImagePath = "";
        }

        // Các nút khác (sửa, xóa) bạn sẽ viết sau
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sửa sẽ viết sau.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xóa sẽ viết sau.");
        }
    }
}