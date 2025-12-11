using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_ItemPhim : UserControl
    {
        private UserInfo currentUser; // thêm field để giữ thông tin user

        public UC_ItemPhim(UserInfo user)
        {
            InitializeComponent();
            currentUser = user;
        }

        public string Description { get; set; }
        public string Genre { get; set; }
        public string PosterFile { get; set; }
        public int ShowTimeId { get; set; }   // hoặc MovieId nếu bạn muốn

        private void UC_ItemPhim_Load(object sender, EventArgs e)
        {

        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            // mở form với suất chiếu tương ứng và user hiện tại
            SeatSelectionForm seatSelectionForm = new SeatSelectionForm(this.ShowTimeId, currentUser.UserId);
            seatSelectionForm.ShowDialog();
        }

        public void SetData(string tenPhim, string thoiLuong, string posterFile, int showTimeId)
        {
            lblTenPhim.Text = tenPhim;
            lblThoiLuong.Text = thoiLuong;
            this.ShowTimeId = showTimeId;

            string imagePath = Path.Combine(Application.StartupPath, "Images", "Movies", posterFile);

            if (File.Exists(imagePath))
            {
                picPoster.Image = Image.FromFile(imagePath);
                picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                picPoster.Image = null;
                picPoster.BackColor = Color.LightGray;
            }
        }

        private void lblTenPhim_Click(object sender, EventArgs e)
        {

        }

        private void panelItem_Paint(object sender, PaintEventArgs e)
        {

        }


        private void picPoster_Click(object sender, EventArgs e)
        {
            MovieDetailForm detailForm = new MovieDetailForm(
            lblTenPhim.Text,
            lblThoiLuong.Text.Replace("⏱ ", ""), // bỏ icon nếu cần
             this.Description,
              this.Genre,
              this.PosterFile
   );
            detailForm.ShowDialog();

        }
    }
}
