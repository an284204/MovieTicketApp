using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_Phim : UserControl
    {
        private readonly UserInfo currentUser;

        public UC_Phim(UserInfo user)
        {
            InitializeComponent();
            currentUser = user;
            this.Load += UC_Phim_Load;
        }

        public string Description { get; set; }
        public string Genre { get; set; }
        public string PosterFile { get; set; }

        private void UC_Phim_Load(object sender, EventArgs e)
        {
            SetupFlowPanel();
            LoadGenres();
            LoadLocations();
            LoadMovies("", "Tất cả", "Tất cả");
        }

        private void SetupFlowPanel()
        {
            flowPhim.Controls.Clear();
            flowPhim.WrapContents = true;
            flowPhim.FlowDirection = FlowDirection.LeftToRight;
            flowPhim.AutoScroll = true;
            flowPhim.AutoSize = false;
            flowPhim.Padding = new Padding(5);
            flowPhim.Dock = DockStyle.Fill;
        }

        private void LoadGenres()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable movies = db.GetMoviesWithShowTime();

            cboTheLoai.Items.Clear();
            cboTheLoai.Items.Add("Tất cả");

            var distinctGenres = movies.AsEnumerable()
                                       .Select(r => r["Genre"].ToString())
                                       .Distinct()
                                       .ToList();

            cboTheLoai.Items.AddRange(distinctGenres.ToArray());
            cboTheLoai.SelectedIndex = 0;
        }

        private void LoadLocations()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable locations = db.GetLocation();

            cboLocation.Items.Clear();
            cboLocation.Items.Add("Tất cả");

            foreach (DataRow row in locations.Rows)
            {
                cboLocation.Items.Add(row["LocationName"].ToString());
            }

            cboLocation.SelectedIndex = 0;
        }

        private void LoadMovies(string keyword = "", string genreFilter = "", string locationFilter = "")
        {
            flowPhim.Controls.Clear();
            DatabaseHelper db = new DatabaseHelper();
            DataTable movies = db.GetMoviesWithShowTime(); // phải có LocationName trong query

            foreach (DataRow row in movies.Rows)
            {
                string tenPhim = row["Title"].ToString();
                string genre = row["Genre"].ToString();
                string location = row["LocationName"].ToString();
                string thoiLuong = "⏱ " + row["Duration"].ToString() + " phút";
                string posterFile = row["Poster"].ToString();
                int showTimeId = Convert.ToInt32(row["ShowTimeID"]);

                bool matchKeyword = string.IsNullOrEmpty(keyword) || tenPhim.ToLower().Contains(keyword.ToLower());
                bool matchGenre = string.IsNullOrEmpty(genreFilter) || genreFilter == "Tất cả" || genre == genreFilter;
                bool matchLocation = string.IsNullOrEmpty(locationFilter) || locationFilter == "Tất cả" || location == locationFilter;

                if (matchKeyword && matchGenre && matchLocation)
                {
                    UC_ItemPhim item = new UC_ItemPhim(currentUser);
                    item.Size = new Size(200, 300);
                    item.SetData(tenPhim, thoiLuong, posterFile, showTimeId);
                    item.Margin = new Padding(3);

                    item.Description = row["Description"].ToString();
                    item.Genre = genre;
                    item.PosterFile = posterFile;

                    flowPhim.Controls.Add(item);
                }
            }
        }

        private void OpenChatBot()
        {
            Chatbot chatForm = new Chatbot();
            chatForm.ShowDialog(); // hoặc Show() nếu muốn mở song song
        }
        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMovies(txtSearchPhim.Text, cboTheLoai.SelectedItem?.ToString(), cboLocation.SelectedItem?.ToString());
        }

        private void cboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMovies(txtSearchPhim.Text, cboTheLoai.SelectedItem?.ToString(), cboLocation.SelectedItem?.ToString());
        }

        private void txtSearchPhim_TextChanged(object sender, EventArgs e)
        {
            LoadMovies(txtSearchPhim.Text, cboTheLoai.SelectedItem?.ToString(), cboLocation.SelectedItem?.ToString());
        }
        private void flowPhim_Paint_1(object sender, PaintEventArgs e)
        {
        }
    }
}