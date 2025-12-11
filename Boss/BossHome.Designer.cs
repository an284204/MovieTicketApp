using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class BossHome
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelSummary;
        private Guna.UI2.WinForms.Guna2Panel panelCharts;
        private Guna.UI2.WinForms.Guna2Panel panelTopItems;

        private Guna.UI2.WinForms.Guna2Panel cardTotalTickets;
        private Guna.UI2.WinForms.Guna2Panel cardMovieRevenue;
        private Guna.UI2.WinForms.Guna2Panel cardFoodRevenue;
        private Guna.UI2.WinForms.Guna2Panel cardNewUsers;

        private Label lblTotalTickets;
        private Label lblMovieRevenue;
        private Label lblFoodRevenue;
        private Label lblNewUsers;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private ListView listTopMovies;
        private ListView listTopFoods;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.cardNewUsers = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNewUsers = new System.Windows.Forms.Label();
            this.cardFoodRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFoodRevenue = new System.Windows.Forms.Label();
            this.cardMovieRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMovieRevenue = new System.Windows.Forms.Label();
            this.cardTotalTickets = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.panelCharts = new Guna.UI2.WinForms.Guna2Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTopItems = new Guna.UI2.WinForms.Guna2Panel();
            this.listTopFoods = new System.Windows.Forms.ListView();
            this.listTopMovies = new System.Windows.Forms.ListView();
            this.panelSummary.SuspendLayout();
            this.cardNewUsers.SuspendLayout();
            this.cardFoodRevenue.SuspendLayout();
            this.cardMovieRevenue.SuspendLayout();
            this.cardTotalTickets.SuspendLayout();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.panelTopItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSummary.Controls.Add(this.cardNewUsers);
            this.panelSummary.Controls.Add(this.cardFoodRevenue);
            this.panelSummary.Controls.Add(this.cardMovieRevenue);
            this.panelSummary.Controls.Add(this.cardTotalTickets);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.FillColor = System.Drawing.Color.LightGreen;
            this.panelSummary.Location = new System.Drawing.Point(0, 0);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Padding = new System.Windows.Forms.Padding(10);
            this.panelSummary.Size = new System.Drawing.Size(1180, 130);
            this.panelSummary.TabIndex = 2;
            this.panelSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSummary_Paint);
            // 
            // cardNewUsers
            // 
            this.cardNewUsers.BackColor = System.Drawing.Color.Silver;
            this.cardNewUsers.Controls.Add(this.lblNewUsers);
            this.cardNewUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardNewUsers.Location = new System.Drawing.Point(580, 10);
            this.cardNewUsers.Name = "cardNewUsers";
            this.cardNewUsers.Size = new System.Drawing.Size(190, 110);
            this.cardNewUsers.TabIndex = 0;
            // 
            // lblNewUsers
            // 
            this.lblNewUsers.Location = new System.Drawing.Point(0, 0);
            this.lblNewUsers.Name = "lblNewUsers";
            this.lblNewUsers.Size = new System.Drawing.Size(100, 23);
            this.lblNewUsers.TabIndex = 0;
            // 
            // cardFoodRevenue
            // 
            this.cardFoodRevenue.BackColor = System.Drawing.Color.Silver;
            this.cardFoodRevenue.Controls.Add(this.lblFoodRevenue);
            this.cardFoodRevenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardFoodRevenue.Location = new System.Drawing.Point(390, 10);
            this.cardFoodRevenue.Name = "cardFoodRevenue";
            this.cardFoodRevenue.Size = new System.Drawing.Size(190, 110);
            this.cardFoodRevenue.TabIndex = 1;
            // 
            // lblFoodRevenue
            // 
            this.lblFoodRevenue.Location = new System.Drawing.Point(0, 0);
            this.lblFoodRevenue.Name = "lblFoodRevenue";
            this.lblFoodRevenue.Size = new System.Drawing.Size(100, 23);
            this.lblFoodRevenue.TabIndex = 0;
            // 
            // cardMovieRevenue
            // 
            this.cardMovieRevenue.BackColor = System.Drawing.Color.Silver;
            this.cardMovieRevenue.Controls.Add(this.lblMovieRevenue);
            this.cardMovieRevenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardMovieRevenue.Location = new System.Drawing.Point(200, 10);
            this.cardMovieRevenue.Name = "cardMovieRevenue";
            this.cardMovieRevenue.Size = new System.Drawing.Size(190, 110);
            this.cardMovieRevenue.TabIndex = 2;
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
            this.cardTotalTickets.BackColor = System.Drawing.Color.Silver;
            this.cardTotalTickets.Controls.Add(this.lblTotalTickets);
            this.cardTotalTickets.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardTotalTickets.Location = new System.Drawing.Point(10, 10);
            this.cardTotalTickets.Name = "cardTotalTickets";
            this.cardTotalTickets.Size = new System.Drawing.Size(190, 110);
            this.cardTotalTickets.TabIndex = 3;
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.Location = new System.Drawing.Point(0, 0);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(100, 23);
            this.lblTotalTickets.TabIndex = 0;
            // 
            // panelCharts
            // 
            this.panelCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCharts.Controls.Add(this.chartRevenue);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCharts.FillColor = System.Drawing.Color.White;
            this.panelCharts.Location = new System.Drawing.Point(0, 130);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Padding = new System.Windows.Forms.Padding(10);
            this.panelCharts.Size = new System.Drawing.Size(1180, 300);
            this.panelCharts.TabIndex = 1;
            // 
            // chartRevenue
            // 
            chartArea3.Name = "MainArea";
            this.chartRevenue.ChartAreas.Add(chartArea3);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartRevenue.Location = new System.Drawing.Point(10, 10);
            this.chartRevenue.Name = "chartRevenue";
            series3.ChartArea = "MainArea";
            series3.Name = "DoanhThu";
            this.chartRevenue.Series.Add(series3);
            this.chartRevenue.Size = new System.Drawing.Size(1160, 280);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Click += new System.EventHandler(this.chartRevenue_Click);
            // 
            // panelTopItems
            // 
            this.panelTopItems.Controls.Add(this.listTopFoods);
            this.panelTopItems.Controls.Add(this.listTopMovies);
            this.panelTopItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopItems.FillColor = System.Drawing.Color.GhostWhite;
            this.panelTopItems.Location = new System.Drawing.Point(0, 430);
            this.panelTopItems.Name = "panelTopItems";
            this.panelTopItems.Padding = new System.Windows.Forms.Padding(10);
            this.panelTopItems.Size = new System.Drawing.Size(1180, 470);
            this.panelTopItems.TabIndex = 0;
            // 
            // listTopFoods
            // 
            this.listTopFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listTopFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTopFoods.ForeColor = System.Drawing.Color.Black;
            this.listTopFoods.HideSelection = false;
            this.listTopFoods.Location = new System.Drawing.Point(590, 10);
            this.listTopFoods.Name = "listTopFoods";
            this.listTopFoods.Size = new System.Drawing.Size(580, 450);
            this.listTopFoods.TabIndex = 0;
            this.listTopFoods.UseCompatibleStateImageBehavior = false;
            this.listTopFoods.View = System.Windows.Forms.View.List;
            // 
            // listTopMovies
            // 
            this.listTopMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listTopMovies.Dock = System.Windows.Forms.DockStyle.Left;
            this.listTopMovies.ForeColor = System.Drawing.Color.Black;
            this.listTopMovies.HideSelection = false;
            this.listTopMovies.Location = new System.Drawing.Point(10, 10);
            this.listTopMovies.Name = "listTopMovies";
            this.listTopMovies.Size = new System.Drawing.Size(580, 450);
            this.listTopMovies.TabIndex = 1;
            this.listTopMovies.UseCompatibleStateImageBehavior = false;
            this.listTopMovies.View = System.Windows.Forms.View.List;
            // 
            // BossHome
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panelTopItems);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelSummary);
            this.Name = "BossHome";
            this.Size = new System.Drawing.Size(1180, 900);
            this.panelSummary.ResumeLayout(false);
            this.cardNewUsers.ResumeLayout(false);
            this.cardFoodRevenue.ResumeLayout(false);
            this.cardMovieRevenue.ResumeLayout(false);
            this.cardTotalTickets.ResumeLayout(false);
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.panelTopItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}