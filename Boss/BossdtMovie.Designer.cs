using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class BossdtMovie
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelSummary;
        private Guna.UI2.WinForms.Guna2Panel panelDetail;
        private Guna.UI2.WinForms.Guna2Panel panelCharts;
        private Guna.UI2.WinForms.Guna2Panel panelTopMovies;
        private Guna.UI2.WinForms.Guna2Panel panelTopItems;

        private Guna.UI2.WinForms.Guna2Panel cardTotalTickets;
        private Guna.UI2.WinForms.Guna2Panel cardMovieRevenue;

        private Label lblTotalTickets;
        private Label lblMovieRevenue;

        private DataGridView dgvMovieDetail;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMovieRevenue;

        private DataGridView dgvTopMovies;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopMovies;

        private Label lblTopBest;
        private Label lblTopWorst;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.cardMovieRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMovieRevenue = new System.Windows.Forms.Label();
            this.cardTotalTickets = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.panelDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvMovieDetail = new System.Windows.Forms.DataGridView();
            this.panelCharts = new Guna.UI2.WinForms.Guna2Panel();
            this.chartMovieRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTopMovies = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvTopMovies = new System.Windows.Forms.DataGridView();
            this.chartTopMovies = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTopItems = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTopWorst = new System.Windows.Forms.Label();
            this.lblTopBest = new System.Windows.Forms.Label();
            this.panelSummary.SuspendLayout();
            this.cardMovieRevenue.SuspendLayout();
            this.cardTotalTickets.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDetail)).BeginInit();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovieRevenue)).BeginInit();
            this.panelTopMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopMovies)).BeginInit();
            this.panelTopItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelSummary.Controls.Add(this.cardMovieRevenue);
            this.panelSummary.Controls.Add(this.cardTotalTickets);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelSummary.Location = new System.Drawing.Point(0, 0);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Padding = new System.Windows.Forms.Padding(24, 24, 24, 14);
            this.panelSummary.Size = new System.Drawing.Size(1174, 150);
            this.panelSummary.TabIndex = 3;
            // 
            // cardMovieRevenue
            // 
            this.cardMovieRevenue.BackColor = System.Drawing.Color.White;
            this.cardMovieRevenue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardMovieRevenue.BorderRadius = 18;
            this.cardMovieRevenue.BorderThickness = 1;
            this.cardMovieRevenue.Controls.Add(this.lblMovieRevenue);
            this.cardMovieRevenue.FillColor = System.Drawing.Color.White;
            this.cardMovieRevenue.Location = new System.Drawing.Point(360, 24);
            this.cardMovieRevenue.Name = "cardMovieRevenue";
            this.cardMovieRevenue.ShadowDecoration.BorderRadius = 18;
            this.cardMovieRevenue.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.cardMovieRevenue.ShadowDecoration.Depth = 10;
            this.cardMovieRevenue.ShadowDecoration.Enabled = true;
            this.cardMovieRevenue.Size = new System.Drawing.Size(320, 112);
            this.cardMovieRevenue.TabIndex = 0;
            // 
            // lblMovieRevenue
            // 
            this.lblMovieRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMovieRevenue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblMovieRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMovieRevenue.Location = new System.Drawing.Point(0, 0);
            this.lblMovieRevenue.Name = "lblMovieRevenue";
            this.lblMovieRevenue.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.lblMovieRevenue.Size = new System.Drawing.Size(320, 112);
            this.lblMovieRevenue.TabIndex = 0;
            this.lblMovieRevenue.Text = "Doanh thu phim";
            this.lblMovieRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardTotalTickets
            // 
            this.cardTotalTickets.BackColor = System.Drawing.Color.White;
            this.cardTotalTickets.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardTotalTickets.BorderRadius = 18;
            this.cardTotalTickets.BorderThickness = 1;
            this.cardTotalTickets.Controls.Add(this.lblTotalTickets);
            this.cardTotalTickets.FillColor = System.Drawing.Color.White;
            this.cardTotalTickets.Location = new System.Drawing.Point(24, 24);
            this.cardTotalTickets.Name = "cardTotalTickets";
            this.cardTotalTickets.ShadowDecoration.BorderRadius = 18;
            this.cardTotalTickets.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.cardTotalTickets.ShadowDecoration.Depth = 10;
            this.cardTotalTickets.ShadowDecoration.Enabled = true;
            this.cardTotalTickets.Size = new System.Drawing.Size(320, 112);
            this.cardTotalTickets.TabIndex = 1;
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalTickets.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTotalTickets.Location = new System.Drawing.Point(0, 0);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.lblTotalTickets.Size = new System.Drawing.Size(320, 112);
            this.lblTotalTickets.TabIndex = 0;
            this.lblTotalTickets.Text = "Tổng vé bán";
            this.lblTotalTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelDetail.Controls.Add(this.dgvMovieDetail);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelDetail.Location = new System.Drawing.Point(0, 150);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Padding = new System.Windows.Forms.Padding(24, 12, 24, 16);
            this.panelDetail.Size = new System.Drawing.Size(1174, 340);
            this.panelDetail.TabIndex = 2;
            // 
            // dgvMovieDetail
            // 
            this.dgvMovieDetail.AllowUserToAddRows = false;
            this.dgvMovieDetail.AllowUserToDeleteRows = false;
            this.dgvMovieDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovieDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovieDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovieDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMovieDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMovieDetail.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvMovieDetail.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.dgvMovieDetail.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMovieDetail.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8);
            this.dgvMovieDetail.ColumnHeadersHeight = 44;
            this.dgvMovieDetail.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMovieDetail.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvMovieDetail.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvMovieDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovieDetail.EnableHeadersVisualStyles = false;
            this.dgvMovieDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvMovieDetail.Location = new System.Drawing.Point(24, 12);
            this.dgvMovieDetail.Name = "dgvMovieDetail";
            this.dgvMovieDetail.ReadOnly = true;
            this.dgvMovieDetail.RowHeadersVisible = false;
            this.dgvMovieDetail.RowHeadersWidth = 62;
            this.dgvMovieDetail.RowTemplate.Height = 38;
            this.dgvMovieDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovieDetail.Size = new System.Drawing.Size(1126, 312);
            this.dgvMovieDetail.TabIndex = 0;
            // 
            // panelCharts
            // 
            this.panelCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelCharts.Controls.Add(this.chartMovieRevenue);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCharts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelCharts.Location = new System.Drawing.Point(0, 490);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Padding = new System.Windows.Forms.Padding(24, 12, 24, 16);
            this.panelCharts.Size = new System.Drawing.Size(1174, 400);
            this.panelCharts.TabIndex = 1;
            // 
            // chartMovieRevenue
            // 
            this.chartMovieRevenue.BackColor = System.Drawing.Color.White;
            this.chartMovieRevenue.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "MainArea";
            this.chartMovieRevenue.ChartAreas.Add(chartArea2);
            this.chartMovieRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMovieRevenue.Location = new System.Drawing.Point(24, 12);
            this.chartMovieRevenue.Name = "chartMovieRevenue";
            series2.ChartArea = "MainArea";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            series2.Name = "DoanhThuPhim";
            this.chartMovieRevenue.Series.Add(series2);
            this.chartMovieRevenue.Size = new System.Drawing.Size(1126, 372);
            this.chartMovieRevenue.TabIndex = 0;
            // 
            // panelTopMovies
            // 
            this.panelTopMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelTopMovies.Controls.Add(this.chartTopMovies);
            this.panelTopMovies.Controls.Add(this.dgvTopMovies);
            this.panelTopMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMovies.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelTopMovies.Location = new System.Drawing.Point(0, 890);
            this.panelTopMovies.Name = "panelTopMovies";
            this.panelTopMovies.Padding = new System.Windows.Forms.Padding(24, 12, 24, 16);
            this.panelTopMovies.Size = new System.Drawing.Size(1174, 540);
            this.panelTopMovies.TabIndex = 2;
            // 
            // dgvTopMovies
            // 
            this.dgvTopMovies.AllowUserToAddRows = false;
            this.dgvTopMovies.AllowUserToDeleteRows = false;
            this.dgvTopMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopMovies.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTopMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTopMovies.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvTopMovies.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.dgvTopMovies.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTopMovies.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8);
            this.dgvTopMovies.ColumnHeadersHeight = 44;
            this.dgvTopMovies.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTopMovies.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvTopMovies.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvTopMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTopMovies.EnableHeadersVisualStyles = false;
            this.dgvTopMovies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvTopMovies.Location = new System.Drawing.Point(24, 12);
            this.dgvTopMovies.Name = "dgvTopMovies";
            this.dgvTopMovies.ReadOnly = true;
            this.dgvTopMovies.RowHeadersVisible = false;
            this.dgvTopMovies.RowHeadersWidth = 62;
            this.dgvTopMovies.RowTemplate.Height = 38;
            this.dgvTopMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopMovies.Size = new System.Drawing.Size(1126, 130);
            this.dgvTopMovies.TabIndex = 0;
            // 
            // chartTopMovies
            // 
            this.chartTopMovies.BackColor = System.Drawing.Color.White;
            this.chartTopMovies.BorderlineColor = System.Drawing.Color.Transparent;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "TopMoviesArea";
            this.chartTopMovies.ChartAreas.Add(chartArea3);
            this.chartTopMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTopMovies.Location = new System.Drawing.Point(24, 142);
            this.chartTopMovies.Name = "chartTopMovies";
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            series3.ChartArea = "TopMoviesArea";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            series3.Name = "DoanhThuPhim";
            this.chartTopMovies.Series.Add(series3);
            this.chartTopMovies.Size = new System.Drawing.Size(1126, 362);
            this.chartTopMovies.TabIndex = 1;
            // 
            // panelTopItems
            // 
            this.panelTopItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelTopItems.Controls.Add(this.lblTopWorst);
            this.panelTopItems.Controls.Add(this.lblTopBest);
            this.panelTopItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelTopItems.Location = new System.Drawing.Point(0, 1410);
            this.panelTopItems.Name = "panelTopItems";
            this.panelTopItems.Padding = new System.Windows.Forms.Padding(24, 12, 24, 22);
            this.panelTopItems.Size = new System.Drawing.Size(1174, 160);
            this.panelTopItems.TabIndex = 0;
            this.panelTopItems.Visible = false;
            // 
            // lblTopWorst
            // 
            this.lblTopWorst.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopWorst.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.lblTopWorst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTopWorst.Location = new System.Drawing.Point(24, 78);
            this.lblTopWorst.Name = "lblTopWorst";
            this.lblTopWorst.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblTopWorst.Size = new System.Drawing.Size(1126, 65);
            this.lblTopWorst.TabIndex = 0;
            this.lblTopWorst.Text = "Phim ít bán nhất:";
            // 
            // lblTopBest
            // 
            this.lblTopBest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopBest.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.lblTopBest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTopBest.Location = new System.Drawing.Point(24, 12);
            this.lblTopBest.Name = "lblTopBest";
            this.lblTopBest.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblTopBest.Size = new System.Drawing.Size(1126, 66);
            this.lblTopBest.TabIndex = 1;
            this.lblTopBest.Text = "Phim bán chạy nhất:";
            // 
            // BossdtMovie
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.panelTopItems);
            this.Controls.Add(this.panelTopMovies);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelSummary);
            this.Name = "BossdtMovie";
            this.Size = new System.Drawing.Size(1174, 1050);
            this.panelSummary.ResumeLayout(false);
            this.cardMovieRevenue.ResumeLayout(false);
            this.cardTotalTickets.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDetail)).EndInit();
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMovieRevenue)).EndInit();
            this.panelTopMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopMovies)).EndInit();
            this.panelTopItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}