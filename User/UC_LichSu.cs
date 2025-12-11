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

        public UC_LichSu(UserInfo user)
        {
            InitializeComponent();
            currentUser = user; // gán giá trị
        }


        private void UC_LichSu_Load(object sender, EventArgs e)
        {
            LoadLichSuVe();
            LoadLichSuDoAn();
        }
        public void ReloadData()
        {
            LoadLichSuVe();
            LoadLichSuDoAn();
        }



        private void LoadLichSuVe()
        {
            flowLichSuVe.Controls.Clear();
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetHoaDonVe(currentUser.UserId); // ✅ truyền userId

            foreach (DataRow row in dt.Rows)
            {
                var panel = new Guna2Panel()
                {
                    Size = new Size(600, 180),
                    BorderRadius = 12,
                    FillColor = Color.Thistle,
                    Margin = new Padding(10),
                    ShadowDecoration = { Enabled = true }
                };

                int gia = row["Gia"] != DBNull.Value ? Convert.ToInt32(row["Gia"]) : 0;

                var lblInfo = new Label()
                {
                    Text = $"Hóa đơn #{row["HoaDonID"]}\n" +
                           $"Phim: {row["MovieTitle"]}\n" +
                           $"Ghế: {row["SeatCode"]} - Mã vé: {row["MaVe"]}\n" +
                           $"Ngày chiếu: {Convert.ToDateTime(row["ShowDate"]).ToString("dd/MM/yyyy")} {row["ShowTime"]}\n" +
                           $"Giá vé: {gia:N0}đ",
                    AutoSize = true,
                    MaximumSize = new Size(280, 0),
                    Font = new Font("Segoe UI", 10F),
                    Location = new Point(20, 20),
                    TextAlign = ContentAlignment.TopLeft
                };

                var lblStatus = new Label()
                {
                    Text = row["TenTrangThai"].ToString(),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    Location = new Point(panel.Width - 150, 20),
                    TextAlign = ContentAlignment.TopRight
                };

                if (row["ColorCode"] != DBNull.Value)
                {
                    lblStatus.ForeColor = ColorTranslator.FromHtml(row["ColorCode"].ToString());
                }

                panel.Controls.Add(lblInfo);
                panel.Controls.Add(lblStatus);
                flowLichSuVe.Controls.Add(panel);
            }
        }

        private void LoadLichSuDoAn()
        {
            flowLichSuDoAn.Controls.Clear();
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetHoaDonDoAn(currentUser.UserId); // ✅ truyền userId

            // Gom nhóm theo HoaDonID
            var grouped = dt.AsEnumerable()
                            .GroupBy(r => r["HoaDonID"]);

            foreach (var group in grouped)
            {
                var panel = new Guna2Panel()
                {
                    Size = new Size(500, 150),
                    BorderRadius = 12,
                    FillColor = Color.LightYellow,
                    Margin = new Padding(10),
                    ShadowDecoration = { Enabled = true }
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
                    Font = new Font("Segoe UI", 10F),
                    Location = new Point(20, 20)
                };

                var lblStatus = new Label()
                {
                    Text = status,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    Location = new Point(panel.Width - 150, 20),
                    TextAlign = ContentAlignment.TopRight
                };

                if (!string.IsNullOrEmpty(colorCode))
                    lblStatus.ForeColor = ColorTranslator.FromHtml(colorCode);

                panel.Controls.Add(lblInfo);
                panel.Controls.Add(lblStatus);
                flowLichSuDoAn.Controls.Add(panel);
            }
        }
    }
}