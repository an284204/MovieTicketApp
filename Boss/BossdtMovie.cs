using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieTicketApp
{
    public partial class BossdtMovie : UserControl
    {
        public BossdtMovie()
        {
            InitializeComponent();
            ApplyStyles();
            LoadMovieData();
        }

        private void ApplyStyles()
        {
            StyleCard(cardTotalTickets, lblTotalTickets, "Tổng vé bán: 0");
            StyleCard(cardMovieRevenue, lblMovieRevenue, "Doanh thu phim: 0đ");

            dgvMovieDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvMovieDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvMovieDetail.EnableHeadersVisualStyles = false;
        }

        private void StyleCard(Guna.UI2.WinForms.Guna2Panel card, Label lbl, string text)
        {
            card.FillColor = Color.AliceBlue;
            card.BorderRadius = 10;
            card.Margin = new Padding(10);

            lbl.Text = text;
            lbl.ForeColor = Color.Black;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            if (!card.Controls.Contains(lbl))
                card.Controls.Add(lbl);
        }

        private void LoadMovieData()
        {
            // Demo dữ liệu giả
            lblTotalTickets.Text = "Tổng vé bán: 1,245";
            lblMovieRevenue.Text = "Doanh thu phim: 85,000,000đ";

            // Bảng chi tiết
            dgvMovieDetail.Columns.Clear();
            dgvMovieDetail.Columns.Add("TenPhim", "Tên phim");
            dgvMovieDetail.Columns.Add("SoVe", "Số vé bán ra");
            dgvMovieDetail.Columns.Add("DoanhThu", "Doanh thu");

            dgvMovieDetail.Rows.Clear();
            dgvMovieDetail.Rows.Add("Avengers: Endgame", 500, "50,000,000đ");
            dgvMovieDetail.Rows.Add("The Batman", 300, "25,000,000đ");
            dgvMovieDetail.Rows.Add("Oppenheimer", 200, "10,000,000đ");

            // Biểu đồ cột
            var s = chartMovieRevenue.Series["DoanhThuPhim"];
            s.Points.Clear();
            s.Points.AddXY("Avengers: Endgame", 50000000);
            s.Points.AddXY("The Batman", 25000000);
            s.Points.AddXY("Oppenheimer", 10000000);

            // Top sản phẩm
            lblTopBest.Text = "Phim bán chạy nhất: Avengers: Endgame";
            lblTopWorst.Text = "Phim ít bán nhất: Oppenheimer";
        }
    }
}