using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_QLDoAn : UserControl
    {
        private string selectedImagePath = "";
        private int selectedFoodId = -1;
        private readonly DatabaseHelper db = new DatabaseHelper();

        public UC_QLDoAn()
        {
            InitializeComponent();
            this.Load += UC_QLDoAn_Load;
            dgvDoAn.CellClick += dgvDoAn_CellClick;
            txtStock.KeyPress += txtStock_KeyPress; 
        }

        private void UC_QLDoAn_Load(object sender, EventArgs e)
        {
            LoadFoodData();
            LoadFoodCategories();
        }

 
        private void LoadFoodData()
        {
            DataTable dt = db.GetFood();
            dgvDoAn.DataSource = dt;

            if (dgvDoAn.Columns.Contains("FoodID"))
                dgvDoAn.Columns["FoodID"].HeaderText = "ID";
            if (dgvDoAn.Columns.Contains("Name"))
                dgvDoAn.Columns["Name"].HeaderText = "Tên món ăn";
            if (dgvDoAn.Columns.Contains("Price"))
                dgvDoAn.Columns["Price"].HeaderText = "Giá (VNĐ)";
            if (dgvDoAn.Columns.Contains("Stock"))
                dgvDoAn.Columns["Stock"].HeaderText = "Số lượng";
            if (dgvDoAn.Columns.Contains("TitleFood"))
                dgvDoAn.Columns["TitleFood"].HeaderText = "Loại";

            if (dgvDoAn.Columns.Contains("ImageURL"))
                dgvDoAn.Columns["ImageURL"].Visible = false;

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

        private void LoadFoodCategories()
        {
            DataTable dt = db.GetFood();
            cboLoai.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string category = row["TitleFood"].ToString();
                if (!cboLoai.Items.Contains(category))
                {
                    cboLoai.Items.Add(category);
                }
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadImageToPictureBox(string path)
        {
            try
            {
                picAnh.Image?.Dispose();
                picAnh.Image = Image.FromFile(path);
                picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                selectedImagePath = path;
            }
            catch
            {
                picAnh.Image = null;
                selectedImagePath = "";
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                LoadImageToPictureBox(selectedImagePath);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenDoAn.Text.Trim();
            string giaText = txtGia.Text.Trim();
            string loai = cboLoai.SelectedItem?.ToString();
            string stockText = txtStock.Text.Trim();

            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(giaText) || string.IsNullOrWhiteSpace(loai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(giaText, out int gia))
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            if (!int.TryParse(stockText, out int stock))
            {
                MessageBox.Show("Số lượng tồn phải là số!");
                return;
            }

            string imageFileName = string.IsNullOrEmpty(selectedImagePath) ? "" : Path.GetFileName(selectedImagePath);

            bool success = db.InsertFood(ten, gia, imageFileName, loai, stock);

            if (success)
            {
                MessageBox.Show("Thêm đồ ăn thành công!");
                ClearForm();
                LoadFoodData();
                LoadFoodCategories();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedFoodId == -1)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần sửa!");
                return;
            }

            string ten = txtTenDoAn.Text.Trim();
            string giaText = txtGia.Text.Trim();
            string loai = cboLoai.SelectedItem?.ToString();
            string stockText = txtStock.Text.Trim();

            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(giaText) || string.IsNullOrWhiteSpace(loai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(giaText, out int gia))
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            if (!int.TryParse(stockText, out int stock))
            {
                MessageBox.Show("Số lượng tồn phải là số!");
                return;
            }

            string imageFileName = string.IsNullOrEmpty(selectedImagePath) ? "" : Path.GetFileName(selectedImagePath);

            bool success = db.UpdateFood(selectedFoodId, ten, gia, imageFileName, loai, stock);

            if (success)
            {
                MessageBox.Show("Cập nhật món ăn thành công!");
                ClearForm();
                LoadFoodData();
                LoadFoodCategories();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedFoodId == -1)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool success = db.DeleteFood(selectedFoodId);
                if (success)
                {
                    MessageBox.Show("Xóa món ăn thành công!");
                    ClearForm();
                    LoadFoodData();
                    LoadFoodCategories();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void dgvDoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDoAn.Rows[e.RowIndex];
                selectedFoodId = Convert.ToInt32(row.Cells["FoodID"].Value);

                txtTenDoAn.Text = row.Cells["Name"].Value.ToString();
                txtGia.Text = row.Cells["Price"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                cboLoai.SelectedItem = row.Cells["TitleFood"].Value.ToString();

                string imageFile = row.Cells["ImageURL"].Value?.ToString();
                if (!string.IsNullOrEmpty(imageFile))
                {
                    string fullPath = Path.Combine(Application.StartupPath, "Images", "Foods", imageFile);
                    if (File.Exists(fullPath))
                    {
                        LoadImageToPictureBox(fullPath);
                    }
                    else
                    {
                        picAnh.Image = null;
                        selectedImagePath = "";
                    }
                }
                else
                {
                    picAnh.Image = null;
                    selectedImagePath = "";
                }
            }
        }
            private void ClearForm()
        {
            txtTenDoAn.Text = "";
            txtGia.Text = "";
            cboLoai.SelectedIndex = -1;
            txtStock.Text = "";
            picAnh.Image = null;
            selectedImagePath = "";
            selectedFoodId = -1;
        }
    }
}