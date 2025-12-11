using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_XuatChieu : UserControl
    {
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
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetMovies();
            cbPhim.DataSource = dt;
            cbPhim.DisplayMember = "Title";
            cbPhim.ValueMember = "MovieID";
        }

        private void LoadLocations()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetLocation();
            cbDiaDiem.DataSource = dt;
            cbDiaDiem.DisplayMember = "LocationName";
            cbDiaDiem.ValueMember = "LocationID";
        }

        private void LoadRooms()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetRooms(); 
            cbPhong.DataSource = dt;
            cbPhong.DisplayMember = "RoomName";
            cbPhong.ValueMember = "RoomID";
        }
        private void LoadShowTimes()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetShowTimes(); 
            dgvLichChieu.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int movieId = Convert.ToInt32(cbPhim.SelectedValue);
                int roomId = Convert.ToInt32(cbPhong.SelectedValue);
                int locationId = Convert.ToInt32(cbDiaDiem.SelectedValue);

                DateTime showDate;
                if (!DateTime.TryParse(txtNgayChieu.Text, out showDate))
                {
                    MessageBox.Show("Ngày chiếu không hợp lệ!");
                    return;
                }

                string showTime = cbGioChieu.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(showTime))
                {
                    MessageBox.Show("Vui lòng chọn giờ chiếu!");
                    return;
                }

                decimal price;
                if (!decimal.TryParse(txtGiaVe.Text, out price))
                {
                    MessageBox.Show("Giá vé không hợp lệ!");
                    return;
                }

                DatabaseHelper db = new DatabaseHelper();
                db.InsertShowTime(movieId, roomId, locationId, showDate, showTime, price);

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

            int showTimeId = Convert.ToInt32(dgvLichChieu.CurrentRow.Cells["ShowTimeID"].Value);
            int movieId = Convert.ToInt32(cbPhim.SelectedValue);
            int roomId = Convert.ToInt32(cbPhong.SelectedValue);
            int locationId = Convert.ToInt32(cbDiaDiem.SelectedValue);

            if (!DateTime.TryParse(txtNgayChieu.Text, out DateTime showDate))
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

            DatabaseHelper db = new DatabaseHelper();
            db.UpdateShowTime(showTimeId, movieId, roomId, locationId, showDate, showTime, price);

            MessageBox.Show("Cập nhật suất chiếu thành công!");
            LoadShowTimes();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLichChieu.CurrentRow == null) return;

            int showTimeId = Convert.ToInt32(dgvLichChieu.CurrentRow.Cells["ShowTimeID"].Value);

            if (MessageBox.Show("Bạn có chắc muốn xóa suất chiếu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseHelper db = new DatabaseHelper();
                db.DeleteShowTime(showTimeId);

                MessageBox.Show("Xóa suất chiếu thành công!");
                LoadShowTimes();
            }
        }

        private void cbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDiaDiem.SelectedItem is DataRowView selectedRow)
            {
                int locationId = Convert.ToInt32(selectedRow["LocationID"]);
                DatabaseHelper db = new DatabaseHelper();
                DataTable dt = db.GetRoomsByLocation(locationId);

                cbPhong.DataSource = dt;
                cbPhong.DisplayMember = "RoomName";
                cbPhong.ValueMember = "RoomID";
            }
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayChieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGioChieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaVe_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLichChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
