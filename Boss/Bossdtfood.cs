using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieTicketApp
{
    public partial class Bossdtfood : UserControl
    {
        private DatabaseHelper db;
        private ComboBox cmbYear, cmbMonth, cmbDay;
        private Label lblYear, lblMonth, lblDay;

        public Bossdtfood()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            CreateDateSelectors();
            ApplyStyles();
            LoadFoodData(0, 0, 0); // Mặc định xem tất cả
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
            cmbYear.Items.Add("(Tất cả)");
            for (int y = DateTime.Now.Year - 2; y <= DateTime.Now.Year + 1; y++)
                cmbYear.Items.Add(y);
            cmbYear.SelectedIndex = 0;
            cmbYear.SelectedIndexChanged += (s, e) => 
            {
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
            cmbMonth.Items.Add("(Tất cả)");
            for (int m = 1; m <= 12; m++)
                cmbMonth.Items.Add(m);
            cmbMonth.SelectedIndex = DateTime.Now.Month;
            cmbMonth.SelectedIndexChanged += (s, e) => 
            {
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

                LoadFoodData(year, month, day);
                chartFoodPie.Series["DoanhThu"].Points.Clear();
                LoadFoodData(year, month, day);
                chartFoodPie.Refresh();
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

            StyleCard(cardTotalOrders, lblTotalOrders, "Tổng đơn: 0", primary, surface, border);
            StyleCard(cardFoodRevenue, lblFoodRevenue, "Doanh thu đồ ăn: 0 đ", primary, surface, border);

            StyleGrid();
            StyleChart(primary, border);
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
            dgvFoodDetail.EnableHeadersVisualStyles = false;
            dgvFoodDetail.BackgroundColor = Color.White;
            dgvFoodDetail.DefaultCellStyle.BackColor = Color.White;
            dgvFoodDetail.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvFoodDetail.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvFoodDetail.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvFoodDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvFoodDetail.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvFoodDetail.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvFoodDetail.GridColor = Color.FromArgb(226, 232, 240);
        }

        private void StyleChart(Color primary, Color border)
        {
            chartFoodPie.Titles.Clear();
            
            // Tiêu đề chính
            chartFoodPie.Titles.Add(new Title
            {
                Text = "Doanh thu đồ ăn theo danh mục",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Alignment = System.Drawing.ContentAlignment.TopCenter
            });

            // Mô tả phụ
            chartFoodPie.Titles.Add(new Title
            {
                Text = "Biểu đồ thể hiện tỷ lệ phần trăm doanh thu từng loại đồ ăn (Nước uống, Bỏng ngô)",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.FromArgb(100, 116, 139),
                Alignment = System.Drawing.ContentAlignment.TopCenter
            });

            var area = chartFoodPie.ChartAreas["PieArea"];
            area.BackColor = Color.White;
            area.BorderColor = Color.Transparent;

            var series = chartFoodPie.Series["DoanhThu"];
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.FromArgb(55, 65, 81);
            series.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            series.Label = "#PERCENT{P1}\n(#VALY{N0} đ)";
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";
        }

        private void UpdateLegend()
        {
            panelLegend.Controls.Clear();
            panelLegend.BackColor = Color.White;

            var series = chartFoodPie.Series["DoanhThu"];
            Color[] colors = new Color[]
            {
                Color.FromArgb(59, 130, 246),   // Blue
                Color.FromArgb(251, 146, 60),   // Orange
                Color.FromArgb(239, 68, 68),    // Red
                Color.FromArgb(34, 197, 94),    // Green
                Color.FromArgb(168, 85, 247)    // Purple
            };

            for (int i = 0; i < series.Points.Count; i++)
            {
                var point = series.Points[i];
                Color itemColor = i < colors.Length ? colors[i] : Color.Gray;
                point.Color = itemColor;

                // Tạo panel chứa mỗi mục legend
                FlowLayoutPanel legendItem = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    AutoSize = true,
                    Margin = new Padding(0, 0, 24, 0),
                    WrapContents = false
                };

                // Ô màu
                Panel colorBox = new Panel
                {
                    Width = 20,
                    Height = 20,
                    BackColor = itemColor,
                    Margin = new Padding(0, 2, 8, 0)
                };

                // Nhãn văn bản
                Label lblLegend = new Label
                {
                    Text = point.AxisLabel,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 0)
                };

                legendItem.Controls.Add(colorBox);
                legendItem.Controls.Add(lblLegend);
                panelLegend.Controls.Add(legendItem);
            }
        }

        private void LoadFoodData(int year, int month, int day)
        {
            // Query trực tiếp từ HoaDon với date filtering
            DataTable dt = db.ExecuteQuery(
                @"SELECT 
                    f.Name AS TenMon,
                    f.TitleFood AS TitleFood,
                    SUM(ctda.SoLuong) AS SoLuong,
                    SUM(ctda.SoLuong * f.Price) AS DoanhThu,
                    CAST(h.NgayLap AS DATE) AS NgayTao
                FROM HoaDon h
                INNER JOIN ChiTietHoaDonDoAn ctda ON h.HoaDonID = ctda.HoaDonID
                INNER JOIN Food f ON ctda.FoodID = f.FoodID
                WHERE h.TrangThaiID IN (1,2,3) AND h.LoaiHoaDon = 'DoAn'
                GROUP BY f.Name, f.TitleFood, CAST(h.NgayLap AS DATE)
                ORDER BY f.TitleFood, f.Name");

            int totalOrders = 0;
            decimal totalRevenue = 0;

            dgvFoodDetail.Columns.Clear();
            dgvFoodDetail.Columns.Add("TenMon", "Tên món ăn");
            dgvFoodDetail.Columns.Add("Loai", "Loại đồ ăn");
            dgvFoodDetail.Columns.Add("SoLuong", "Số lượng bán ra");
            dgvFoodDetail.Columns.Add("DoanhThu", "Doanh thu");
            dgvFoodDetail.Rows.Clear();

            var series = chartFoodPie.Series["DoanhThu"];
            series.Points.Clear();
            series.ChartType = SeriesChartType.Pie;

            // Lọc dữ liệu theo tiêu chí năm/tháng/ngày
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
                })
                .ToList();

            // Gom dữ liệu theo loại để vẽ biểu đồ tròn
            var grouped = filtered
                .GroupBy(r => r["TitleFood"].ToString())
                .Select(g => new
                {
                    Loai = g.Key,
                    DoanhThu = g.Sum(x => x["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(x["DoanhThu"]) : 0)
                });

            // Gom dữ liệu theo món ăn cho DataGridView
            var detailGrouped = filtered
                .GroupBy(r => new { TenMon = r["TenMon"].ToString(), Loai = r["TitleFood"].ToString() })
                .Select(g => new
                {
                    TenMon = g.Key.TenMon,
                    Loai = g.Key.Loai,
                    SoLuong = g.Sum(x => x["SoLuong"] != DBNull.Value ? Convert.ToInt32(x["SoLuong"]) : 0),
                    DoanhThu = g.Sum(x => x["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(x["DoanhThu"]) : 0)
                });

            foreach (var item in detailGrouped)
            {
                dgvFoodDetail.Rows.Add(item.TenMon, item.Loai, item.SoLuong, $"{item.DoanhThu:N0} đ");
                totalOrders += item.SoLuong;
                totalRevenue += item.DoanhThu;
            }

            foreach (var item in grouped)
            {
                series.Points.AddXY(item.Loai, item.DoanhThu);
            }

            UpdateLegend();

            lblTotalOrders.Text = $"Tổng đơn: {totalOrders:N0}";
            lblFoodRevenue.Text = $"Doanh thu đồ ăn: {totalRevenue:N0} đ";
        }
    }
}