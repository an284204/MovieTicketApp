using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class BossdtMovie
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelSummary;
        private Guna.UI2.WinForms.Guna2Panel panelDetail;
        private Guna.UI2.WinForms.Guna2Panel panelCharts;
        private Guna.UI2.WinForms.Guna2Panel panelTopItems;

        private Guna.UI2.WinForms.Guna2Panel cardTotalTickets;
        private Guna.UI2.WinForms.Guna2Panel cardMovieRevenue;

        private Label lblTotalTickets;
        private Label lblMovieRevenue;

        private DataGridView dgvMovieDetail;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMovieRevenue;

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
            this.panelTopItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.cardMovieRevenue);
            this.panelSummary.Controls.Add(this.cardTotalTickets);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.FillColor = System.Drawing.Color.LightBlue;
            this.panelSummary.Location = new System.Drawing.Point(0, 0);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Padding = new System.Windows.Forms.Padding(10);
            this.panelSummary.Size = new System.Drawing.Size(1174, 150);
            this.panelSummary.TabIndex = 3;
            // 
            // cardMovieRevenue
            // 
            this.cardMovieRevenue.Controls.Add(this.lblMovieRevenue);
            this.cardMovieRevenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardMovieRevenue.FillColor = System.Drawing.Color.AliceBlue;
            this.cardMovieRevenue.Location = new System.Drawing.Point(310, 10);
            this.cardMovieRevenue.Name = "cardMovieRevenue";
            this.cardMovieRevenue.Size = new System.Drawing.Size(300, 130);
            this.cardMovieRevenue.TabIndex = 0;
            // 
            // lblMovieRevenue
            // 
            this.lblMovieRevenue.Location = new System.Drawing.Point(0, 0);
            this.lblMovieRevenue.Name = "lblMovieRevenue";
            this.lblMovieRevenue.Size = new System.Drawing.Size(100, 23);
            this.lblMovieRevenue.TabIndex = 0;
            // 
            // cardTotalTickets
            // 
            this.cardTotalTickets.Controls.Add(this.lblTotalTickets);
            this.cardTotalTickets.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardTotalTickets.FillColor = System.Drawing.Color.AliceBlue;
            this.cardTotalTickets.Location = new System.Drawing.Point(10, 10);
            this.cardTotalTickets.Name = "cardTotalTickets";
            this.cardTotalTickets.Size = new System.Drawing.Size(300, 130);
            this.cardTotalTickets.TabIndex = 1;
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.Location = new System.Drawing.Point(0, 0);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(100, 23);
            this.lblTotalTickets.TabIndex = 0;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.dgvMovieDetail);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetail.FillColor = System.Drawing.Color.LightYellow;
            this.panelDetail.Location = new System.Drawing.Point(0, 150);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Padding = new System.Windows.Forms.Padding(10);
            this.panelDetail.Size = new System.Drawing.Size(1174, 300);
            this.panelDetail.TabIndex = 2;
            // 
            // dgvMovieDetail
            // 
            this.dgvMovieDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovieDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovieDetail.ColumnHeadersHeight = 34;
            this.dgvMovieDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovieDetail.Location = new System.Drawing.Point(10, 10);
            this.dgvMovieDetail.Name = "dgvMovieDetail";
            this.dgvMovieDetail.RowHeadersWidth = 62;
            this.dgvMovieDetail.Size = new System.Drawing.Size(1154, 280);
            this.dgvMovieDetail.TabIndex = 0;
            // 
            // panelCharts
            // 
            this.panelCharts.Controls.Add(this.chartMovieRevenue);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCharts.FillColor = System.Drawing.Color.MintCream;
            this.panelCharts.Location = new System.Drawing.Point(0, 450);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Padding = new System.Windows.Forms.Padding(10);
            this.panelCharts.Size = new System.Drawing.Size(1174, 400);
            this.panelCharts.TabIndex = 1;
            // 
            // chartMovieRevenue
            // 
            this.chartMovieRevenue.BackColor = System.Drawing.Color.MintCream;
            chartArea2.Name = "MainArea";
            this.chartMovieRevenue.ChartAreas.Add(chartArea2);
            this.chartMovieRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMovieRevenue.Location = new System.Drawing.Point(10, 10);
            this.chartMovieRevenue.Name = "chartMovieRevenue";
            series2.ChartArea = "MainArea";
            series2.Name = "DoanhThuPhim";
            this.chartMovieRevenue.Series.Add(series2);
            this.chartMovieRevenue.Size = new System.Drawing.Size(1154, 380);
            this.chartMovieRevenue.TabIndex = 0;
            // 
            // panelTopItems
            // 
            this.panelTopItems.Controls.Add(this.lblTopWorst);
            this.panelTopItems.Controls.Add(this.lblTopBest);
            this.panelTopItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopItems.FillColor = System.Drawing.Color.Honeydew;
            this.panelTopItems.Location = new System.Drawing.Point(0, 850);
            this.panelTopItems.Name = "panelTopItems";
            this.panelTopItems.Padding = new System.Windows.Forms.Padding(10);
            this.panelTopItems.Size = new System.Drawing.Size(1174, 500);
            this.panelTopItems.TabIndex = 0;
            // 
            // lblTopWorst
            // 
            this.lblTopWorst.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopWorst.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTopWorst.ForeColor = System.Drawing.Color.Black;
            this.lblTopWorst.Location = new System.Drawing.Point(10, 50);
            this.lblTopWorst.Name = "lblTopWorst";
            this.lblTopWorst.Size = new System.Drawing.Size(1154, 40);
            this.lblTopWorst.TabIndex = 0;
            this.lblTopWorst.Text = "Phim ít bán nhất:";
            // 
            // lblTopBest
            // 
            this.lblTopBest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopBest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTopBest.ForeColor = System.Drawing.Color.Black;
            this.lblTopBest.Location = new System.Drawing.Point(10, 10);
            this.lblTopBest.Name = "lblTopBest";
            this.lblTopBest.Size = new System.Drawing.Size(1154, 40);
            this.lblTopBest.TabIndex = 1;
            this.lblTopBest.Text = "Phim bán chạy nhất:";
            // 
            // BossdtMovie
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelTopItems);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelSummary);
            this.Name = "BossdtMovie";
            this.Size = new System.Drawing.Size(1174, 1000);
            this.panelSummary.ResumeLayout(false);
            this.cardMovieRevenue.ResumeLayout(false);
            this.cardTotalTickets.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDetail)).EndInit();
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMovieRevenue)).EndInit();
            this.panelTopItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}