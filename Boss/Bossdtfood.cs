using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieTicketApp
{
    public partial class Bossdtfood : UserControl
    {
        public Bossdtfood()
        {
            InitializeComponent();
            ApplyStyles();
            LoadFoodData();
        }

        private void ApplyStyles()
        {
            StyleCard(cardTotalOrders, lblTotalOrders, "Tổng đơn đồ ăn: 0");
            StyleCard(cardFoodRevenue, lblFoodRevenue, "Doanh thu đồ ăn: 0đ");

            // Đổi màu panel sang sáng
            panelSummary.FillColor = Color.LightBlue;
            panelDetail.FillColor = Color.LightYellow;
            panelCharts.FillColor = Color.LightGreen;
            panelTopItems.FillColor = Color.LightCoral;

            // DataGridView header sáng
            dgvFoodDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvFoodDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvFoodDetail.BackgroundColor = Color.White;
            dgvFoodDetail.ForeColor = Color.Black;
            dgvFoodDetail.EnableHeadersVisualStyles = false;
        }

        private void StyleCard(Guna.UI2.WinForms.Guna2Panel card, Label lbl, string text)
        {
            card.FillColor = Color.AliceBlue; // màu sáng
            card.BorderRadius = 10;
            card.Margin = new Padding(10);

            lbl.Text = text;
            lbl.ForeColor = Color.Black; // chữ đen cho sáng
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            if (!card.Controls.Contains(lbl))
                card.Controls.Add(lbl);
        }

        private void LoadFoodData()
        {
            // Demo dữ liệu giả
            lblTotalOrders.Text = "Tổng đơn đồ ăn: 356";
            lblFoodRevenue.Text = "Doanh thu đồ ăn: 22,500,000đ";

            // Bảng chi tiết
            dgvFoodDetail.Columns.Clear();
            dgvFoodDetail.Columns.Add("TenMon", "Tên món ăn");
            dgvFoodDetail.Columns.Add("SoLuong", "Số lượng bán ra");
            dgvFoodDetail.Columns.Add("DoanhThu", "Doanh thu");

            dgvFoodDetail.Rows.Clear();
            dgvFoodDetail.Rows.Add("Bắp rang bơ", 120, "12,000,000đ");
            dgvFoodDetail.Rows.Add("Coca-Cola", 90, "6,300,000đ");
            dgvFoodDetail.Rows.Add("Hotdog", 60, "4,500,000đ");
            dgvFoodDetail.Rows.Add("Khoai tây chiên", 40, "2,700,000đ");

            // Biểu đồ tròn
            var s = chartFoodPie.Series["DoanhThu"];
            s.Points.Clear();
            s.Points.AddXY("Bắp rang bơ", 12000000);
            s.Points.AddXY("Coca-Cola", 6300000);
            s.Points.AddXY("Hotdog", 4500000);
            s.Points.AddXY("Khoai tây chiên", 2700000);
            s.Points.AddXY("Khác", 1500000);
            // Đổi màu từng slice
            s.Points[0].Color = Color.LightSkyBlue;
            s.Points[1].Color = Color.LightPink;
            s.Points[2].Color = Color.LightGreen;
            s.Points[3].Color = Color.Orange;
            s.Points[4].Color = Color.LightGray;


            // Top sản phẩm
            lblTopBest.Text = "Món ăn bán chạy nhất: Bắp rang bơ";
            lblTopWorst.Text = "Món ăn ít bán nhất: Khoai tây chiên";
        }

        private void chartFoodPie_Click(object sender, EventArgs e)
        {

        }
    }
}