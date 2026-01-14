using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieTicketApp
{
    public partial class BossdtMovie : UserControl
    {
        private DatabaseHelper db;
        private ComboBox cmbYear, cmbMonth, cmbDay;
        private Label lblYear, lblMonth, lblDay;

        public BossdtMovie()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            CreateDateSelectors();
            ApplyStyles();
            LoadMovieData(0, 0, 0); // Mặc định xem tất cả
            LoadTopMovies(0, 0, 0); // Mặc định xem tất cả
        }

        private void CreateDateSelectors()
        {
            // Tạo Panel chứa date selectors ở trên chart
            FlowLayoutPanel pnlDateSelectors = new FlowLayoutPanel
            {
                BackColor = Color.White,
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
            cmbYear.Items.Add("(Tất cả)"); // Trống - Tất cả năm
            for (int y = DateTime.Now.Year - 2; y <= DateTime.Now.Year + 1; y++)
                cmbYear.Items.Add(y);
            cmbYear.SelectedIndex = 0; // Mặc định là tất cả
            cmbYear.SelectedIndexChanged += (s, e) => 
            {
                // Khi năm thay đổi, reset tháng/ngày
                cmbMonth.SelectedIndex = 0;
                RefreshChart();
            };

            // Tháng
            lblMonth = new Label 
            { 
                Text = "Tháng:", 
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
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
            cmbMonth.Items.Add("(Tất cả)"); // Trống - Tất cả tháng
            for (int m = 1; m <= 12; m++)
                cmbMonth.Items.Add(m);
            cmbMonth.SelectedIndex = DateTime.Now.Month; // Mặc định tháng hiện tại
            cmbMonth.SelectedIndexChanged += (s, e) => 
            {
                // Khi tháng thay đổi, cập nhật ngày
                UpdateDayComboBox();
                RefreshChart();
            };

            // Ngày
            lblDay = new Label 
            { 
                Text = "Ngày:", 
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
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
            cmbDay.SelectedIndexChanged += (s, e) => RefreshChart();

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
            
            // Nếu tháng là "Tất cả", ngày chỉ hiển thị "Tất cả"
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
                
                cmbDay.SelectedIndex = cmbDay.Items.Contains(DateTime.Now.Day) ? DateTime.Now.Day : 1;
            }
        }

        private void RefreshChart()
        {
            try
            {
                int year = cmbYear.SelectedIndex == 0 ? 0 : int.Parse(cmbYear.SelectedItem.ToString());
                int month = cmbMonth.SelectedIndex == 0 ? 0 : int.Parse(cmbMonth.SelectedItem.ToString());
                int day = cmbDay.SelectedIndex == 0 ? 0 : int.Parse(cmbDay.SelectedItem.ToString());

                LoadMovieData(year, month, day);
                
                // Buộc vẽ lại biểu đồ
                chartMovieRevenue.Series["DoanhThuPhim"].Points.Clear();
                
                // Reload lại dữ liệu vào chart
                LoadMovieData(year, month, day);
                
                chartMovieRevenue.Refresh();

                // Cập nhật Top 5 phim theo ngày
                LoadTopMovies(year, month, day);
                chartTopMovies.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật biểu đồ: " + ex.Message);
            }
        }

        private void ApplyStyles()
        {
            var primary = Color.FromArgb(37, 99, 235);
            var surface = Color.White;
            var border = Color.FromArgb(226, 232, 240);

            StyleCard(cardTotalTickets, lblTotalTickets, "Tổng vé bán: 0", primary, surface, border);
            StyleCard(cardMovieRevenue, lblMovieRevenue, "Doanh thu phim: 0 đ", primary, surface, border);

            StyleGrid();
            StyleTopGrid();
            StyleChart(primary, border);
            StyleTopMoviesChart(primary, border);
        }

        private void StyleTopGrid()
        {
            dgvTopMovies.EnableHeadersVisualStyles = false;
            dgvTopMovies.BackgroundColor = Color.White;
            dgvTopMovies.DefaultCellStyle.BackColor = Color.White;
            dgvTopMovies.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvTopMovies.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvTopMovies.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvTopMovies.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvTopMovies.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvTopMovies.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvTopMovies.GridColor = Color.FromArgb(226, 232, 240);
        }

        private void StyleCard(Guna.UI2.WinForms.Guna2Panel card, Label lbl, string text, Color primary, Color surface, Color border)
        {
            card.FillColor = surface;
            card.BorderColor = border;
            card.BorderThickness = 1;
            card.Margin = new Padding(10);

            lbl.Text = text;
            lbl.ForeColor = Color.FromArgb(30, 41, 59);
            lbl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleLeft;

            if (!card.Controls.Contains(lbl))
                card.Controls.Add(lbl);
        }

        private void StyleGrid()
        {
            dgvMovieDetail.EnableHeadersVisualStyles = false;
            dgvMovieDetail.BackgroundColor = Color.White;
            dgvMovieDetail.DefaultCellStyle.BackColor = Color.White;
            dgvMovieDetail.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvMovieDetail.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvMovieDetail.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvMovieDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvMovieDetail.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvMovieDetail.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvMovieDetail.GridColor = Color.FromArgb(226, 232, 240);
        }

        private void StyleChart(Color primary, Color border)
        {
            chartMovieRevenue.Titles.Clear();
            chartMovieRevenue.Titles.Add(new Title
            {
                Text = "Doanh thu theo khu vực",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59)
            });

            var area = chartMovieRevenue.ChartAreas["MainArea"];
            area.BackColor = Color.White;
            area.BorderColor = Color.Transparent;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 10F);
            area.AxisX.LabelStyle.ForeColor = Color.FromArgb(71, 85, 105);
            area.AxisX.LabelStyle.Angle = -15;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.MajorTickMark.Enabled = false;
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 10F);
            area.AxisY.LabelStyle.ForeColor = Color.FromArgb(71, 85, 105);
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisY.MajorGrid.LineColor = border;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            area.AxisY.MajorTickMark.Enabled = false;
            area.AxisY.MinorGrid.Enabled = false;

            var series = chartMovieRevenue.Series["DoanhThuPhim"];
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(37, 99, 235);
            series.BorderWidth = 0;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.FromArgb(55, 65, 81);
            series.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            series.LabelFormat = "#,0 đ";
        }

        private void StyleTopMoviesChart(Color primary, Color border)
        {
            chartTopMovies.Titles.Clear();
            chartTopMovies.Titles.Add(new Title
            {
                Text = "Doanh thu top  phim bán chạy nhất",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59)
            });

            var area = chartTopMovies.ChartAreas["TopMoviesArea"];
            area.BackColor = Color.White;
            area.BorderColor = Color.Transparent;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 10F);
            area.AxisX.LabelStyle.ForeColor = Color.FromArgb(71, 85, 105);
            area.AxisX.LabelStyle.Angle = -15;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.MajorTickMark.Enabled = false;
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 10F);
            area.AxisY.LabelStyle.ForeColor = Color.FromArgb(71, 85, 105);
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisY.MajorGrid.LineColor = border;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            area.AxisY.MajorTickMark.Enabled = false;
            area.AxisY.MinorGrid.Enabled = false;

            var series = chartTopMovies.Series["DoanhThuPhim"];
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(37, 99, 235);
            series.BorderWidth = 0;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.FromArgb(55, 65, 81);
            series.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            series.LabelFormat = "#,0 đ";
        }

        private void LoadMovieData(int year, int month, int day)
        {

            DataTable dt = db.ExecuteQuery(
                @"SELECT 
                    m.Title AS TenPhim,
                    ISNULL(l.LocationName, N'Không xác định') AS LocationName,
                    SUM(h.TongTien) AS DoanhThu,
                    COUNT(t.TicketID) AS SoVe,
                    CAST(h.NgayLap AS DATE) AS NgayTao
                FROM HoaDon h
                LEFT JOIN Ticket t ON h.HoaDonID = t.HoaDonID
                LEFT JOIN ShowTime st ON t.ShowTimeID = st.ShowTimeID
                LEFT JOIN Movie m ON st.MovieID = m.MovieID
                LEFT JOIN Room r ON st.RoomID = r.RoomID
                LEFT JOIN Location l ON r.LocationID = l.LocationID
                WHERE h.TrangThaiID IN (1,2,3) AND h.LoaiHoaDon = 'Ve'
                GROUP BY m.Title, l.LocationName, CAST(h.NgayLap AS DATE)
                ORDER BY m.Title, l.LocationName");

            int totalTickets = 0;
            decimal totalRevenue = 0;

            dgvMovieDetail.Columns.Clear();
            dgvMovieDetail.Columns.Add("LocationName", "Khu vực");
            dgvMovieDetail.Columns.Add("SoVe", "Số vé bán ra");
            dgvMovieDetail.Columns.Add("DoanhThu", "Doanh thu");
            dgvMovieDetail.Rows.Clear();

            var series = chartMovieRevenue.Series["DoanhThuPhim"];
            series.Points.Clear();

            var filtered = dt.AsEnumerable()
                .Where(r => 
                {
                    if (r["NgayTao"] == DBNull.Value)
                        return false;

                    DateTime date = Convert.ToDateTime(r["NgayTao"]);

                    // Nếu chọn cả year, month, day
                    if (year > 0 && month > 0 && day > 0)
                    {
                        return date.Year == year && date.Month == month && date.Day == day;
                    }
                    // Nếu chọn year và month, nhưng day trống
                    else if (year > 0 && month > 0 && day == 0)
                    {
                        return date.Year == year && date.Month == month;
                    }
                    // Nếu chọn chỉ year, month trống
                    else if (year > 0 && month == 0 && day == 0)
                    {
                        return date.Year == year;
                    }
                    // Nếu tất cả trống - hiển thị toàn bộ
                    else if (year == 0 && month == 0 && day == 0)
                    {
                        return true;
                    }

                    return false;
                });

            // Gom dữ liệu theo khu vực
            var grouped = filtered
                .GroupBy(r => r["LocationName"].ToString())
                .Select(g => new
                {
                    Location = g.Key,
                    SoVe = g.Sum(x => x["SoVe"] != DBNull.Value ? Convert.ToInt32(x["SoVe"]) : 0),
                    DoanhThu = g.Sum(x => x["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(x["DoanhThu"]) : 0)
                })
                .OrderByDescending(x => x.DoanhThu);

            foreach (var item in grouped)
            {
                dgvMovieDetail.Rows.Add(item.Location, item.SoVe, $"{item.DoanhThu:N0} đ");
                totalTickets += item.SoVe;
                totalRevenue += item.DoanhThu;
                series.Points.AddXY(item.Location, item.DoanhThu);
            }

            lblTotalTickets.Text = $"Tổng vé bán: {totalTickets:N0}";
            lblMovieRevenue.Text = $"Doanh thu phim: {totalRevenue:N0} đ";
        }

        private void LoadTopMovies(int year, int month, int day)
        {
            // Lấy Top 5 phim doanh thu cao nhất
            DataTable dt = db.ExecuteQuery(
                @"SELECT TOP 5
                    m.Title AS TenPhim,
                    SUM(h.TongTien) AS DoanhThu,
                    COUNT(t.TicketID) AS SoVe,
                    CAST(h.NgayLap AS DATE) AS NgayTao
                FROM HoaDon h
                LEFT JOIN Ticket t ON h.HoaDonID = t.HoaDonID
                LEFT JOIN ShowTime st ON t.ShowTimeID = st.ShowTimeID
                LEFT JOIN Movie m ON st.MovieID = m.MovieID
                WHERE h.TrangThaiID IN (1,2,3) AND h.LoaiHoaDon = 'Ve'
                GROUP BY m.Title, CAST(h.NgayLap AS DATE)
                ORDER BY DoanhThu DESC");

            dgvTopMovies.Columns.Clear();
            dgvTopMovies.Columns.Add("TenPhim", "Tên phim");
            dgvTopMovies.Columns.Add("SoVe", "Số vé bán ra");
            dgvTopMovies.Columns.Add("DoanhThu", "Doanh thu");
            dgvTopMovies.Rows.Clear();

            var series = chartTopMovies.Series["DoanhThuPhim"];
            series.Points.Clear();

            // Lọc dữ liệu theo tiêu chí ngày tháng năm
            var filtered = dt.AsEnumerable()
                .Where(r =>
                {
                    if (r["NgayTao"] == DBNull.Value)
                        return false;

                    DateTime date = Convert.ToDateTime(r["NgayTao"]);

                    if (year > 0 && month > 0 && day > 0)
                    {
                        return date.Year == year && date.Month == month && date.Day == day;
                    }
                    else if (year > 0 && month > 0 && day == 0)
                    {
                        return date.Year == year && date.Month == month;
                    }
                    else if (year > 0 && month == 0 && day == 0)
                    {
                        return date.Year == year;
                    }
                    else if (year == 0 && month == 0 && day == 0)
                    {
                        return true;
                    }

                    return false;
                })
                .ToList();

            // Sắp xếp Top 5 theo doanh thu cao nhất
            var topMovies = filtered
                .GroupBy(r => r["TenPhim"].ToString())
                .Select(g => new
                {
                    TenPhim = g.Key,
                    SoVe = g.Sum(x => x["SoVe"] != DBNull.Value ? Convert.ToInt32(x["SoVe"]) : 0),
                    DoanhThu = g.Sum(x => x["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(x["DoanhThu"]) : 0)
                })
                .OrderByDescending(x => x.DoanhThu)
                .Take(5);

            foreach (var item in topMovies)
            {
                dgvTopMovies.Rows.Add(item.TenPhim, item.SoVe, $"{item.DoanhThu:N0} đ");
                series.Points.AddXY(item.TenPhim, item.DoanhThu);
            }
        }
    }
}