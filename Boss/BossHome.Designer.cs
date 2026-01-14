using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class BossHome
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelSummary;
        private System.Windows.Forms.FlowLayoutPanel flowSummary;
        private Guna.UI2.WinForms.Guna2Panel panelCharts;

        private Guna.UI2.WinForms.Guna2Panel cardTotalTickets;
        private Guna.UI2.WinForms.Guna2Panel cardMovieRevenue;
        private Guna.UI2.WinForms.Guna2Panel cardFoodRevenue;
        private Guna.UI2.WinForms.Guna2Panel cardTong;

        private Label lblTotalTickets;
        private Label lblMovieRevenue;
        private Label lblFoodRevenue;
        private Label lblTong;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.flowSummary = new System.Windows.Forms.FlowLayoutPanel();
            this.cardTong = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTong = new System.Windows.Forms.Label();
            this.cardFoodRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFoodRevenue = new System.Windows.Forms.Label();
            this.cardMovieRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMovieRevenue = new System.Windows.Forms.Label();
            this.cardTotalTickets = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.panelCharts = new Guna.UI2.WinForms.Guna2Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelSummary.SuspendLayout();
            this.flowSummary.SuspendLayout();
            this.cardTong.SuspendLayout();
            this.cardFoodRevenue.SuspendLayout();
            this.cardMovieRevenue.SuspendLayout();
            this.cardTotalTickets.SuspendLayout();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelSummary.Controls.Add(this.flowSummary);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelSummary.Location = new System.Drawing.Point(0, 0);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Padding = new System.Windows.Forms.Padding(16, 18, 16, 12);
            this.panelSummary.Size = new System.Drawing.Size(1180, 140);
            this.panelSummary.TabIndex = 2;
            this.panelSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSummary_Paint);

            // 
            // flowSummary
            // 
            this.flowSummary.BackColor = System.Drawing.Color.Transparent;
            this.flowSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSummary.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowSummary.Location = new System.Drawing.Point(16, 18);
            this.flowSummary.Name = "flowSummary";
            this.flowSummary.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.flowSummary.Size = new System.Drawing.Size(1148, 110);
            this.flowSummary.TabIndex = 4;
            this.flowSummary.WrapContents = false;
            // 
            // cardTong
            // 
            this.flowSummary.Controls.Add(this.cardTotalTickets);
            this.flowSummary.Controls.Add(this.cardMovieRevenue);
            this.flowSummary.Controls.Add(this.cardFoodRevenue);
            this.flowSummary.Controls.Add(this.cardTong);

            this.cardTong.BackColor = System.Drawing.Color.Silver;
            this.cardTong.Controls.Add(this.lblTong);
            this.cardTong.Location = new System.Drawing.Point(696, 0);
            this.cardTong.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardTong.Name = "cardTong";
            this.cardTong.Size = new System.Drawing.Size(220, 110);
            this.cardTong.TabIndex = 0;
            // 
            // lblTong
            // 
            this.lblTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTong.Location = new System.Drawing.Point(0, 0);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(270, 110);
            this.lblTong.TabIndex = 0;
            // 
            // cardFoodRevenue
            // 
            this.cardFoodRevenue.BackColor = System.Drawing.Color.Silver;
            this.cardFoodRevenue.Controls.Add(this.lblFoodRevenue);
            this.cardFoodRevenue.Location = new System.Drawing.Point(464, 0);
            this.cardFoodRevenue.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardFoodRevenue.Name = "cardFoodRevenue";
            this.cardFoodRevenue.Size = new System.Drawing.Size(220, 110);
            this.cardFoodRevenue.TabIndex = 1;
            // 
            // lblFoodRevenue
            // 
            this.lblFoodRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodRevenue.Location = new System.Drawing.Point(0, 0);
            this.lblFoodRevenue.Name = "lblFoodRevenue";
            this.lblFoodRevenue.Size = new System.Drawing.Size(270, 110);
            this.lblFoodRevenue.TabIndex = 0;
            // 
            // cardMovieRevenue
            // 
            this.cardMovieRevenue.BackColor = System.Drawing.Color.Silver;
            this.cardMovieRevenue.Controls.Add(this.lblMovieRevenue);
            this.cardMovieRevenue.Location = new System.Drawing.Point(232, 0);
            this.cardMovieRevenue.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardMovieRevenue.Name = "cardMovieRevenue";
            this.cardMovieRevenue.Size = new System.Drawing.Size(220, 110);
            this.cardMovieRevenue.TabIndex = 2;
            // 
            // lblMovieRevenue
            // 
            this.lblMovieRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMovieRevenue.Location = new System.Drawing.Point(0, 0);
            this.lblMovieRevenue.Name = "lblMovieRevenue";
            this.lblMovieRevenue.Size = new System.Drawing.Size(270, 110);
            this.lblMovieRevenue.TabIndex = 0;
            // 
            // cardTotalTickets
            // 
            this.cardTotalTickets.BackColor = System.Drawing.Color.Silver;
            this.cardTotalTickets.Controls.Add(this.lblTotalTickets);
            this.cardTotalTickets.Location = new System.Drawing.Point(0, 0);
            this.cardTotalTickets.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardTotalTickets.Name = "cardTotalTickets";
            this.cardTotalTickets.Size = new System.Drawing.Size(220, 110);
            this.cardTotalTickets.TabIndex = 3;
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalTickets.Location = new System.Drawing.Point(0, 0);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(270, 110);
            this.lblTotalTickets.TabIndex = 0;
            // 
            // panelCharts
            // 
            this.panelCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelCharts.Controls.Add(this.chartRevenue);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCharts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelCharts.Location = new System.Drawing.Point(0, 140);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
            this.panelCharts.Size = new System.Drawing.Size(1180, 760);
            this.panelCharts.TabIndex = 1;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "MainArea";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRevenue.Location = new System.Drawing.Point(10, 10);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "MainArea";
            series1.Name = "DoanhThu";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(1160, 787);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Click += new System.EventHandler(this.chartRevenue_Click);
            // 
            // BossHome
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelSummary);
            this.Name = "BossHome";
            this.Size = new System.Drawing.Size(1180, 900);
            this.panelSummary.ResumeLayout(false);
            this.flowSummary.ResumeLayout(false);
            this.cardTong.ResumeLayout(false);
            this.cardFoodRevenue.ResumeLayout(false);
            this.cardMovieRevenue.ResumeLayout(false);
            this.cardTotalTickets.ResumeLayout(false);
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);

        }
    }
}