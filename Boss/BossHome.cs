using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieTicketApp
{
    public partial class BossHome : UserControl
    {
        public BossHome()
        {
            InitializeComponent();
            ApplyStyles();
            LoadDashboardData();
        }

        private void ApplyStyles()
        {
            // Style cards + labels
            StyleCard(cardTotalTickets, lblTotalTickets, "Tổng vé bán: 0");
            StyleCard(cardMovieRevenue, lblMovieRevenue, "Doanh thu phim: 0đ");
            StyleCard(cardFoodRevenue, lblFoodRevenue, "Doanh thu đồ ăn: 0đ");
            StyleCard(cardNewUsers, lblNewUsers, "Người dùng mới: 0");

            // Chart aesthetic
            var area = chartRevenue.ChartAreas["MainArea"];
            area.BackColor = Color.FromArgb(10, 10, 10);
            area.AxisX.LabelStyle.ForeColor = Color.Black;
            area.AxisY.LabelStyle.ForeColor = Color.Black;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(70, 70, 90);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(70, 70, 90);

            var series = chartRevenue.Series["DoanhThu"];
            series.Color = Color.FromArgb(90, 160, 255);
        }

        private void StyleCard(Guna.UI2.WinForms.Guna2Panel card, Label lbl, string text)
        {
            card.FillColor = Color.FromArgb(45, 45, 70);
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

        private void LoadDashboardData()
        {
            lblTotalTickets.Text = "Tổng vé bán: 1,245";
            lblMovieRevenue.Text = "Doanh thu phim: 85,000,000đ";
            lblFoodRevenue.Text = "Doanh thu đồ ăn: 22,500,000đ";
            lblNewUsers.Text = "Người dùng mới: 37";

            var s = chartRevenue.Series["DoanhThu"];
            s.Points.Clear();
            s.Points.AddXY("Thứ 2", 12_000_000);
            s.Points.AddXY("Thứ 3", 15_000_000);
            s.Points.AddXY("Thứ 4", 18_000_000);
            s.Points.AddXY("Thứ 5", 20_000_000);
            s.Points.AddXY("Thứ 6", 25_000_000);
            s.Points.AddXY("Thứ 7", 30_000_000);
            s.Points.AddXY("CN", 22_000_000);

            listTopMovies.Items.Clear();
            listTopMovies.Items.Add("Avengers: Endgame");
            listTopMovies.Items.Add("The Batman");
            listTopMovies.Items.Add("Oppenheimer");

            listTopFoods.Items.Clear();
            listTopFoods.Items.Add("Bắp rang bơ");
            listTopFoods.Items.Add("Coca-Cola");
            listTopFoods.Items.Add("Hotdog");
        }

        private void panelSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartRevenue_Click(object sender, EventArgs e)
        {

        }
    }
}