using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MovieTicketApp
{
    public partial class UC_LichSu : UserControl
    {
        private readonly UserInfo currentUser;
        private DataTable dtVeCache;
        private DataTable dtDoAnCache;

        public UC_LichSu(UserInfo user)
        {
            InitializeComponent();
            currentUser = user;
        }


        private void UC_LichSu_Load(object sender, EventArgs e)
        {
            // Set default values
            cboTrangThai.SelectedIndex = 0;
            cboSapXep.SelectedIndex = 0;
            
            // Load data into cache
            LoadDataToCache();
            
            // Display filtered data
            LoadLichSuVe();
            LoadLichSuDoAn();
        }

        public void ReloadData()
        {
            LoadDataToCache();
            LoadLichSuVe();
            LoadLichSuDoAn();
        }

        private void LoadDataToCache()
        {
            DatabaseHelper db = new DatabaseHelper();
            dtVeCache = db.GetHoaDonVe(currentUser.UserId);
            dtDoAnCache = db.GetHoaDonDoAn(currentUser.UserId);
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            LoadLichSuVe();
            LoadLichSuDoAn();
        }

        private DataRow[] ApplyFiltersVe(DataTable dt)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string trangThai = cboTrangThai.SelectedItem?.ToString() ?? "Tất cả";
            bool sortNewest = cboSapXep.SelectedIndex == 0;

            var query = dt.AsEnumerable().Where(row =>
            {
                // Filter by keyword
                if (!string.IsNullOrEmpty(keyword))
                {
                    string movieTitle = row["MovieTitle"]?.ToString().ToLower() ?? "";
                    string seatCode = row["SeatCode"]?.ToString().ToLower() ?? "";
                    string maVe = row["MaVe"]?.ToString().ToLower() ?? "";
                    if (!movieTitle.Contains(keyword) && !seatCode.Contains(keyword) && !maVe.Contains(keyword))
                        return false;
                }

                // Filter by status
                if (trangThai != "Tất cả")
                {
                    string status = row["TenTrangThai"]?.ToString() ?? "";
                    if (status != trangThai)
                        return false;
                }

                return true;
            });

            // Sort
            if (sortNewest)
                query = query.OrderByDescending(r => r["HoaDonID"]);
            else
                query = query.OrderBy(r => r["HoaDonID"]);

            return query.ToArray();
        }

        private DataRow[] ApplyFiltersDoAn(DataTable dt)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string trangThai = cboTrangThai.SelectedItem?.ToString() ?? "Tất cả";
            bool sortNewest = cboSapXep.SelectedIndex == 0;

            var query = dt.AsEnumerable().Where(row =>
            {
                // Filter by keyword
                if (!string.IsNullOrEmpty(keyword))
                {
                    string foodName = row["FoodName"]?.ToString().ToLower() ?? "";
                    if (!foodName.Contains(keyword))
                        return false;
                }

                // Filter by status
                if (trangThai != "Tất cả")
                {
                    string status = row["TenTrangThai"]?.ToString() ?? "";
                    if (status != trangThai)
                        return false;
                }

                return true;
            });

            return query.ToArray();
        }



        private void LoadLichSuVe()
        {
            flowLichSuVe.Controls.Clear();
            
            if (dtVeCache == null) return;
            
            var filteredRows = ApplyFiltersVe(dtVeCache);

            foreach (DataRow row in filteredRows)
            {
                var panel = new Guna2Panel()
                {
                    Size = new Size(670, 180),
                    BorderRadius = 14,
                    FillColor = Color.FromArgb(35, 35, 50),
                    Margin = new Padding(8),
                    ShadowDecoration = { Enabled = true, Depth = 10 }
                };

                int gia = row["Gia"] != DBNull.Value ? Convert.ToInt32(row["Gia"]) : 0;
                string colorCode = row["ColorCode"].ToString();

                var lblInfo = new Label()
                {
                    Text = $"Hóa đơn #{row["HoaDonID"]}\n" +
                           $"Phim: {row["MovieTitle"]}\n" +
                           $"Ghế: {row["SeatCode"]} - Mã vé: {row["MaVe"]}\n" +
                           $"Ngày chiếu: {Convert.ToDateTime(row["ShowDate"]).ToString("dd/MM/yyyy")} {row["ShowTime"]}\n" +
                           $"Giá vé: {gia:N0}đ",
                    AutoSize = true,
                    MaximumSize = new Size(520, 0),
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    Location = new Point(24, 24),
                    TextAlign = ContentAlignment.TopLeft,
                    ForeColor = Color.White
                };

                var lblStatus = new Label()
                {
                    Text = row["TenTrangThai"].ToString(),
                    AutoSize = false,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Location = new Point(480, 18),
                    Size = new Size(160, 28),
                    TextAlign = ContentAlignment.MiddleRight,
                    ForeColor = Color.White
                };

                if (row["ColorCode"] != DBNull.Value)
                {
                    lblStatus.ForeColor = colorCode.StartsWith("#")
                        ? ColorTranslator.FromHtml(colorCode)
                        : Color.FromName(colorCode);
                }

                panel.Controls.Add(lblInfo);
                panel.Controls.Add(lblStatus);
                flowLichSuVe.Controls.Add(panel);
            }
        }

        private void LoadLichSuDoAn()
        {
            flowLichSuDoAn.Controls.Clear();
            
            if (dtDoAnCache == null) return;
            
            var filteredRows = ApplyFiltersDoAn(dtDoAnCache);

            // Gom nhóm theo HoaDonID
            var grouped = filteredRows.GroupBy(r => r["HoaDonID"]);
            
            // Sort groups
            bool sortNewest = cboSapXep.SelectedIndex == 0;
            if (sortNewest)
                grouped = grouped.OrderByDescending(g => g.Key);
            else
                grouped = grouped.OrderBy(g => g.Key);

            foreach (var group in grouped)
            {
                var panel = new Guna2Panel()
                {
                    Size = new Size(670, 180),
                    BorderRadius = 14,
                    FillColor = Color.FromArgb(35, 35, 50),
                    Margin = new Padding(8),
                    ShadowDecoration = { Enabled = true, Depth = 10 }
                };

                // Lấy thông tin chung từ dòng đầu tiên
                var firstRow = group.First();
                string status = firstRow["TenTrangThai"].ToString();
                string colorCode = firstRow["ColorCode"].ToString();

                // Gom các món ăn lại thành chuỗi
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Hóa đơn #{firstRow["HoaDonID"]}");
                foreach (var row in group)
                {
                    sb.AppendLine($"- {row["FoodName"]} x{row["SoLuong"]} - Giá {Convert.ToInt32(row["Gia"]):N0}đ");
                }

                var lblInfo = new Label()
                {
                    Text = sb.ToString(),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    Location = new Point(24, 24),
                    ForeColor = Color.White,
                    MaximumSize = new Size(520, 0)
                };

                var lblStatus = new Label()
                {
                    Text = status,
                    AutoSize = false,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Location = new Point(480, 18),
                    Size = new Size(160, 28),
                    TextAlign = ContentAlignment.MiddleRight,
                    ForeColor = Color.White
                };

                if (!string.IsNullOrEmpty(colorCode))
                    lblStatus.ForeColor = colorCode.StartsWith("#")
                        ? ColorTranslator.FromHtml(colorCode)
                        : Color.FromName(colorCode);

                panel.Controls.Add(lblInfo);
                panel.Controls.Add(lblStatus);
                flowLichSuDoAn.Controls.Add(panel);
            }
        }
    }
}