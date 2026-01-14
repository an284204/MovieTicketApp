using System;
using System.Data;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_XuatChieu : UserControl
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        public UC_XuatChieu()
        {
            InitializeComponent();
            cbPhim.IntegralHeight = false;
            cbPhim.DropDownHeight = cbPhim.ItemHeight * 6;
            cbGioChieu.IntegralHeight = false;
            cbGioChieu.DropDownHeight = cbGioChieu.ItemHeight * 6;
        }

        private void UC_XuatChieu_Load(object sender, EventArgs e)
        {
            LoadMovies();
            LoadLocations();
            LoadRooms();
            LoadShowTimes();
        }

        private void LoadMovies()
        {
            DataTable dt = db.GetMovies();
            cbPhim.DataSource = dt;
            cbPhim.DisplayMember = "Title";
            cbPhim.ValueMember = "MovieID";
        }

        private void LoadLocations()
        {
            DataTable dt = db.GetLocation();
            cbDiaDiem.DataSource = dt;
            cbDiaDiem.DisplayMember = "LocationName";
            cbDiaDiem.ValueMember = "LocationID";
        }

        private void LoadRooms()
        {
            DataTable dt = db.GetRooms();
            cbPhong.DataSource = dt;
            cbPhong.DisplayMember = "RoomName";
            cbPhong.ValueMember = "RoomID";
        }

        private void LoadShowTimes()
        {
            DataTable dt = db.GetShowTimes();

            // Thêm cột string mới để hiển thị ngày đã format
            dt.Columns.Add("NgayChieuFormatted", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                if (row["Ngày chiếu"] != DBNull.Value)
                {
                    DateTime d = Convert.ToDateTime(row["Ngày chiếu"]);
                    row["NgayChieuFormatted"] = d.ToString("dd/MM/yyyy");
                }
            }

            dgvLichChieu.DataSource = dt;

            // Ẩn cột ngày gốc, hiện cột đã format
            dgvLichChieu.Columns["Ngày chiếu"].Visible = false;
            dgvLichChieu.Columns["NgayChieuFormatted"].HeaderText = "Ngày chiếu";
            dgvLichChieu.Columns["NgayChieuFormatted"].DisplayIndex = 4; // đặt vị trí hiển thị

            // Đặt lại header text cho các cột
            dgvLichChieu.Columns["Id"].HeaderText = "ID";
            dgvLichChieu.Columns["Tên phim"].HeaderText = "Tên phim";
            dgvLichChieu.Columns["Phòng"].HeaderText = "Phòng";
            dgvLichChieu.Columns["Địa điểm"].HeaderText = "Địa điểm";
            dgvLichChieu.Columns["Giờ chiếu"].HeaderText = "Giờ chiếu";
            dgvLichChieu.Columns["Giá vé"].HeaderText = "Giá vé";
            dgvLichChieu.Columns["MovieID"].Visible = false;
            dgvLichChieu.Columns["LocationID"].Visible = false;
            dgvLichChieu.Columns["RoomID"].Visible = false;

            // Chỉ cho xem, không cho sửa
            dgvLichChieu.ReadOnly = true;
            dgvLichChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichChieu.MultiSelect = false;
            dgvLichChieu.AllowUserToAddRows = false;
            dgvLichChieu.AllowUserToDeleteRows = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int movieId = Convert.ToInt32(cbPhim.SelectedValue);
                int roomId = Convert.ToInt32(cbPhong.SelectedValue);
                int locationId = Convert.ToInt32(cbDiaDiem.SelectedValue);

                string showDateStr = txtNgayChieu.Text.Trim();
                if (!DateTime.TryParseExact(showDateStr, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                {
                    MessageBox.Show("Ngày chiếu không hợp lệ! Vui lòng nhập đúng định dạng: dd/MM/yyyy");
                    return;
                }

                string showTime = cbGioChieu.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(showTime))
                {
                    MessageBox.Show("Vui lòng chọn giờ chiếu!");
                    return;
                }

                if (!decimal.TryParse(txtGiaVe.Text, out decimal price))
                {
                    MessageBox.Show("Giá vé không hợp lệ!");
                    return;
                }
                if (db.IsDuplicateShowTime(locationId, roomId, parsedDate, showTime))
                {
                    MessageBox.Show("Đã có suất chiếu khác tại địa điểm, phòng và thời gian này!");
                    return;
                }

                db.InsertShowTime(movieId, roomId, locationId, parsedDate, showTime, price);

                MessageBox.Show("Thêm suất chiếu thành công!");
                LoadShowTimes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLichChieu.CurrentRow == null) return;

            int showTimeId = Convert.ToInt32(dgvLichChieu.CurrentRow.Cells["Id"].Value);
            int movieId = Convert.ToInt32(cbPhim.SelectedValue);
            int roomId = Convert.ToInt32(cbPhong.SelectedValue);
            int locationId = Convert.ToInt32(cbDiaDiem.SelectedValue);

            string showDateStr = txtNgayChieu.Text.Trim();
            if (!DateTime.TryParseExact(showDateStr, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                MessageBox.Show("Ngày chiếu không hợp lệ! Vui lòng nhập đúng định dạng: dd/MM/yyyy");
                return;
            }

            if (cbGioChieu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giờ chiếu!");
                return;
            }

            string showTime = cbGioChieu.SelectedItem.ToString();

            if (!decimal.TryParse(txtGiaVe.Text, out decimal price))
            {
                MessageBox.Show("Giá vé không hợp lệ!");
                return;
            }
            if (db.IsDuplicateShowTimeExcept(showTimeId, locationId, roomId, parsedDate, showTime))
{
    MessageBox.Show("Đã có suất chiếu khác tại địa điểm, phòng và thời gian này!");
    return;
}

            db.UpdateShowTime(showTimeId, movieId, roomId, locationId, parsedDate, showTime, price);

            MessageBox.Show("Cập nhật suất chiếu thành công!");
            LoadShowTimes();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLichChieu.CurrentRow == null) return;

            int showTimeId = Convert.ToInt32(dgvLichChieu.CurrentRow.Cells["Id"].Value);

            if (MessageBox.Show("Bạn có chắc muốn xóa suất chiếu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.DeleteShowTime(showTimeId);
                MessageBox.Show("Xóa suất chiếu thành công!");
                LoadShowTimes();
            }
        }

        private void cbDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDiaDiem.SelectedItem is DataRowView selectedRow)
            {
                int locationId = Convert.ToInt32(selectedRow["LocationID"]);
                DataTable dt = db.GetRoomsByLocation(locationId);

                cbPhong.DataSource = dt;
                cbPhong.DisplayMember = "RoomName";
                cbPhong.ValueMember = "RoomID";
            }
        }

        private void dgvLichChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLichChieu.Rows[e.RowIndex];

                txtNgayChieu.Text = Convert.ToDateTime(row.Cells["Ngày chiếu"].Value).ToString("dd/MM/yyyy");
                cbGioChieu.SelectedItem = row.Cells["Giờ chiếu"].Value.ToString();
                txtGiaVe.Text = row.Cells["Giá vé"].Value.ToString();
                cbPhim.SelectedValue = row.Cells["MovieID"].Value;
                cbDiaDiem.SelectedValue = row.Cells["LocationID"].Value;
                cbPhong.SelectedValue = row.Cells["RoomID"].Value;
            }

        }
    }
}