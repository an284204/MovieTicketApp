using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_DoAn : UserControl
    {
        private readonly int currentUserId;
        private readonly UserInfo currentUser;
        private List<(string TenMon, string Gia, int SoLuong)> gioHang = new List<(string, string, int)>();

        public UC_DoAn(UserInfo user)
        {
            InitializeComponent();
            currentUser = user;
            currentUserId = user.UserId;

            this.Load += UC_DoAn_Load;

        }

        private void UC_DoAn_Load(object sender, EventArgs e)
        {
            SetupFlowPanel();
            LoadLoaiDoAn();
            LoadFoods();
        }

        private void SetupFlowPanel()
        {
            flowDoAn.Controls.Clear();
            flowDoAn.WrapContents = true;
            flowDoAn.FlowDirection = FlowDirection.LeftToRight;
            flowDoAn.AutoScroll = true;
            flowDoAn.AutoSize = false;
            flowDoAn.Padding = new Padding(5);
            flowDoAn.Dock = DockStyle.Fill;
        }

        private void LoadLoaiDoAn()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable foods = db.GetFood();

            cbLoai.Items.Clear();
            cbLoai.Items.Add("Tất cả");

            var distinctTitles = foods.AsEnumerable()
                                      .Select(r => r["TitleFood"].ToString())
                                      .Distinct()
                                      .ToList();
            cbLoai.Items.AddRange(distinctTitles.ToArray());
            cbLoai.SelectedIndex = 0;
        }

        private void LoadFoods(string keyword = "", string loaiFilter = "Tất cả")
        {
            flowDoAn.Controls.Clear();
            DatabaseHelper db = new DatabaseHelper();
            DataTable foods = db.GetFood();

            foreach (DataRow row in foods.Rows)
            {
                string tenMon = row["Name"].ToString();
                string gia = row["Price"].ToString() + " VND";
                string imageUrl = row["ImageURL"].ToString();
                string loai = row["TitleFood"].ToString();

                bool matchKeyword = string.IsNullOrEmpty(keyword) || tenMon.ToLower().Contains(keyword.ToLower());
                bool matchLoai = string.IsNullOrEmpty(loaiFilter) || loaiFilter == "Tất cả" || loai == loaiFilter;

                if (matchKeyword && matchLoai)
                {
                    Image hinh = null;
                    string imagePath = Path.Combine(Application.StartupPath, "Images", "Foods", imageUrl);
                    if (File.Exists(imagePath))
                    {
                        hinh = Image.FromFile(imagePath);
                    }

                    UC_ItemDoAn item = new UC_ItemDoAn();
                    item.Size = new Size(180, 270);
                    item.SetData(tenMon, gia, hinh);
                    item.Margin = new Padding(8);

                    item.OnThemMon += (s, mon) =>
                    {
                        var existing = gioHang.FirstOrDefault(x => x.TenMon == mon.TenMon);
                        if (!string.IsNullOrEmpty(existing.TenMon))
                        {
                            int index = gioHang.FindIndex(x => x.TenMon == mon.TenMon);
                            gioHang[index] = (mon.TenMon, mon.Gia, gioHang[index].SoLuong + 1);
                        }
                        else
                        {
                            gioHang.Add((mon.TenMon, mon.Gia, 1));
                        }
                        MessageBox.Show($"{mon.TenMon} đã thêm vào giỏ hàng!");
                    };

                    flowDoAn.Controls.Add(item);
                }
            }
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            FrmGioHang frm = new FrmGioHang(currentUserId, gioHang); // ✅ truyền đúng UserID
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var daThanhToan = frm.Tag as List<string>;
                if (daThanhToan != null)
                {
                    foreach (var tenMon in daThanhToan)
                    {
                        gioHang.RemoveAll(x => x.TenMon == tenMon);
                    }
                }
            }
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFoods(txtTimDoAn.Text, cbLoai.SelectedItem?.ToString());
        }

        private void txtTimDoAn_TextChanged(object sender, EventArgs e)
        {

            LoadFoods(txtTimDoAn.Text, cbLoai.SelectedItem?.ToString());
        }

    }
}