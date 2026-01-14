using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieTicketApp
{
    public partial class BossHome : UserControl
    {
        private DatabaseHelper db;
        private ComboBox cmbYear, cmbMonth, cmbDay;
        private Label lblYear, lblMonth, lblDay;

        public BossHome()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            CreateDateSelectors();
            ApplyStyles();
            LoadDashboardData(0, 0, 0);
            LoadRevenueChartFromDatabase(0, 0, 0);
        }

        private void CreateDateSelectors()
        {
            // Tạo Panel chứa date selectors ở trên chart
            FlowLayoutPanel pnlDateSelectors = new FlowLayoutPanel
            {
                BackColor = Color.FromArgb(15, 23, 42),
                Dock = DockStyle.Top,
                Height = 60,
                Padding = new Padding(24, 12, 24, 12),
                WrapContents = false
            };

            int controlWidth = 100;
            int controlHeight = 32;
            int marginRight = 12;

            // Năm
            lblYear = new Label 
            { 
                Text = "Năm:", 
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(0, 0),
                Margin = new Padding(0, 6, 8, 0)
            };
            cmbYear = new ComboBox 
            { 
                Font = new Font("Segoe UI", 10F),
                Size = new Size(controlWidth, controlHeight),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Margin = new Padding(0, 0, marginRight, 0)
            };
            cmbYear.Items.Add("(Tất cả)");
            for (int y = DateTime.Now.Year - 2; y <= DateTime.Now.Year + 1; y++)
                cmbYear.Items.Add(y);
            cmbYear.SelectedIndex = 0;
            cmbYear.SelectedIndexChanged += (s, e) => 
            {
                cmbMonth.SelectedIndex = 0;
                RefreshData();
            };

            // Tháng
            lblMonth = new Label 
            { 
                Text = "Tháng:", 
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(0, 0),
                Margin = new Padding(0, 6, 8, 0)
            };
            cmbMonth = new ComboBox 
            { 
                Font = new Font("Segoe UI", 10F),
                Size = new Size(controlWidth, controlHeight),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Margin = new Padding(0, 0, marginRight, 0)
            };
            cmbMonth.Items.Add("(Tất cả)");
            for (int m = 1; m <= 12; m++)
                cmbMonth.Items.Add(m);
            cmbMonth.SelectedIndex = 0;
            cmbMonth.SelectedIndexChanged += (s, e) => 
            {
                UpdateDayComboBox();
                RefreshData();
            };

            // Ngày
            lblDay = new Label 
            { 
                Text = "Ngày:", 
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(0, 0),
                Margin = new Padding(0, 6, 8, 0)
            };
            cmbDay = new ComboBox 
            { 
                Font = new Font("Segoe UI", 10F),
                Size = new Size(controlWidth, controlHeight),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Margin = new Padding(0, 0, 0, 0)
            };
            UpdateDayComboBox();
            cmbDay.SelectedIndexChanged += (s, e) => RefreshData();

            pnlDateSelectors.Controls.Add(lblYear);
            pnlDateSelectors.Controls.Add(cmbYear);
            pnlDateSelectors.Controls.Add(lblMonth);
            pnlDateSelectors.Controls.Add(cmbMonth);
            pnlDateSelectors.Controls.Add(lblDay);
            pnlDateSelectors.Controls.Add(cmbDay);

            panelCharts.Controls.Add(pnlDateSelectors);
        }

        private void UpdateDayComboBox()
        {
            cmbDay.Items.Clear();
            cmbDay.Items.Add("(Tất cả)");
            
            if (cmbMonth.SelectedIndex == 0)
            {
                cmbDay.SelectedIndex = 0;
            }
            else
            {
                int month = int.Parse(cmbMonth.SelectedItem.ToString());
                int year = cmbYear.SelectedIndex == 0 ? DateTime.Now.Year : int.Parse(cmbYear.SelectedItem.ToString());
                int daysInMonth = DateTime.DaysInMonth(year, month);
                
                for (int d = 1; d <= daysInMonth; d++)
                    cmbDay.Items.Add(d);
                
                cmbDay.SelectedIndex = 0;
            }
        }

        private void RefreshData()
        {
            try
            {
                int year = cmbYear.SelectedIndex == 0 ? 0 : int.Parse(cmbYear.SelectedItem.ToString());
                int month = cmbMonth.SelectedIndex == 0 ? 0 : int.Parse(cmbMonth.SelectedItem.ToString());
                int day = cmbDay.SelectedIndex == 0 ? 0 : int.Parse(cmbDay.SelectedItem.ToString());

                LoadDashboardData(year, month, day);
                LoadRevenueChartFromDatabase(year, month, day);
                chartRevenue.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void ApplyStyles()
        {
            StyleCard(cardTotalTickets, lblTotalTickets, "Tổng vé bán\n0 vé");
            StyleCard(cardMovieRevenue, lblMovieRevenue, "Doanh thu phim\n0đ");
            StyleCard(cardFoodRevenue, lblFoodRevenue, "Doanh thu đồ ăn\n0đ");
            StyleCard(cardTong, lblTong, "Tổng doanh thu\n0đ");

            // Chart aesthetic (dark, clean)
            chartRevenue.BackColor = Color.FromArgb(15, 23, 42);
            var area = chartRevenue.ChartAreas["MainArea"];
            area.BackColor = Color.FromArgb(15, 23, 42);
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.LineColor = Color.FromArgb(148, 163, 184);
            area.AxisY.LineColor = Color.FromArgb(148, 163, 184);

            var series = chartRevenue.Series["DoanhThu"];
            series.Color = Color.FromArgb(96, 165, 250);
            series.BorderWidth = 0;
            series["PointWidth"] = "0.6";
        }

        private void StyleCard(Guna.UI2.WinForms.Guna2Panel card, Label lbl, string text)
        {
            card.FillColor = Color.FromArgb(30, 41, 59);
            card.BorderRadius = 14;
            card.Margin = new Padding(0, 0, 12, 0);
            card.Padding = new Padding(14, 12, 14, 12);
            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.Color = Color.FromArgb(25, 0, 0, 0);
            card.ShadowDecoration.Depth = 10;

            lbl.Text = text;
            lbl.ForeColor = Color.White;
            lbl.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.AutoSize = false;
            lbl.Padding = new Padding(4, 2, 4, 2);

            if (!card.Controls.Contains(lbl))
                card.Controls.Add(lbl);
        }

        private void LoadDashboardData(int year, int month, int day)
        {
            // Query trực tiếp với date filtering
            DataTable dtPhim = db.ExecuteQuery(
                @"SELECT 
                    SUM(h.TongTien) AS DoanhThuPhim,
                    COUNT(t.TicketID) AS TongVe,
                    CAST(h.NgayLap AS DATE) AS NgayTao
                FROM HoaDon h
                LEFT JOIN Ticket t ON h.HoaDonID = t.HoaDonID
                WHERE h.TrangThaiID IN (1,2,3) AND h.LoaiHoaDon = 'Ve'
                GROUP BY CAST(h.NgayLap AS DATE)");

            DataTable dtDoAn = db.ExecuteQuery(
                @"SELECT 
                    SUM(h.TongTien) AS DoanhThuDoAn,
                    CAST(h.NgayLap AS DATE) AS NgayTao
                FROM HoaDon h
                WHERE h.TrangThaiID IN (1,2,3) AND h.LoaiHoaDon = 'DoAn'
                GROUP BY CAST(h.NgayLap AS DATE)");

            // Lọc theo ngày tháng năm
            var filteredPhim = FilterByDate(dtPhim, year, month, day);
            var filteredDoAn = FilterByDate(dtDoAn, year, month, day);

            decimal doanhThuPhim = filteredPhim.Sum(r => r["DoanhThuPhim"] != DBNull.Value ? Convert.ToDecimal(r["DoanhThuPhim"]) : 0);
            int tongVe = filteredPhim.Sum(r => r["TongVe"] != DBNull.Value ? Convert.ToInt32(r["TongVe"]) : 0);
            decimal doanhThuDoAn = filteredDoAn.Sum(r => r["DoanhThuDoAn"] != DBNull.Value ? Convert.ToDecimal(r["DoanhThuDoAn"]) : 0);
            decimal tongDoanhThu = doanhThuPhim + doanhThuDoAn;

            lblMovieRevenue.Text = $"Doanh thu phim\n{doanhThuPhim:N0}đ";
            lblFoodRevenue.Text = $"Doanh thu đồ ăn\n{doanhThuDoAn:N0}đ";
            lblTotalTickets.Text = $"Tổng vé bán\n{tongVe} vé";
            lblTong.Text = $"Tổng doanh thu\n{tongDoanhThu:N0}đ";
        }

        private System.Collections.Generic.List<DataRow> FilterByDate(DataTable dt, int year, int month, int day)
        {
            return dt.AsEnumerable()
                .Where(r => 
                {
                    if (r["NgayTao"] == DBNull.Value)
                        return false;

                    DateTime date = Convert.ToDateTime(r["NgayTao"]);

                    if (year > 0 && month > 0 && day > 0)
                        return date.Year == year && date.Month == month && date.Day == day;
                    else if (year > 0 && month > 0 && day == 0)
                        return date.Year == year && date.Month == month;
                    else if (year > 0 && month == 0 && day == 0)
                        return date.Year == year;
                    else if (year == 0 && month == 0 && day == 0)
                        return true;

                    return false;
                })
                .ToList();
        }
        private void LoadRevenueChartFromDatabase(int year, int month, int day)
        {
            // Query doanh thu theo ngày trong tuần
            DataTable dt = db.ExecuteQuery(
                @"SELECT 
                    DATENAME(WEEKDAY, CAST(h.NgayLap AS DATE)) AS NgayTrongTuan,
                    DATEPART(WEEKDAY, CAST(h.NgayLap AS DATE)) AS NgayThuTu,
                    SUM(h.TongTien) AS DoanhThu,
                    CAST(h.NgayLap AS DATE) AS NgayTao
                FROM HoaDon h
                WHERE h.TrangThaiID IN (1,2,3)
                GROUP BY CAST(h.NgayLap AS DATE), DATENAME(WEEKDAY, CAST(h.NgayLap AS DATE)), DATEPART(WEEKDAY, CAST(h.NgayLap AS DATE))
                ORDER BY NgayThuTu");

            var filtered = FilterByDate(dt, year, month, day);

            // Gom theo ngày trong tuần
            var grouped = filtered
                .GroupBy(r => new { Day = r["NgayTrongTuan"].ToString(), Order = Convert.ToInt32(r["NgayThuTu"]) })
                .Select(g => new
                {
                    DayName = g.Key.Day,
                    Order = g.Key.Order,
                    Revenue = g.Sum(x => x["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(x["DoanhThu"]) : 0)
                })
                .OrderBy(x => x.Order);

            var series = chartRevenue.Series["DoanhThu"];
            series.Points.Clear();
            series.ChartType = SeriesChartType.Column;

            foreach (var item in grouped)
            {
                series.Points.AddXY(item.DayName, item.Revenue);
            }
        }
        private void panelSummary_Paint(object sender, PaintEventArgs e)
        {
        }

        private void chartRevenue_Click(object sender, EventArgs e)
        {
        }
    }
}