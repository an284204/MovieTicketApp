using System.Windows.Forms;

namespace MovieTicketApp
{
    partial class Bossdtfood
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panelSummary;
        private Guna.UI2.WinForms.Guna2Panel panelDetail;
        private Guna.UI2.WinForms.Guna2Panel panelCharts;
        private Guna.UI2.WinForms.Guna2Panel panelTopItems;

        private Guna.UI2.WinForms.Guna2Panel cardTotalOrders;
        private Guna.UI2.WinForms.Guna2Panel cardFoodRevenue;

        private Label lblTotalOrders;
        private Label lblFoodRevenue;

        private DataGridView dgvFoodDetail;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFoodPie;
        private FlowLayoutPanel panelLegend;

        private Label lblTopBest;
        private Label lblTopWorst;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.cardFoodRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFoodRevenue = new System.Windows.Forms.Label();
            this.cardTotalOrders = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.panelDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvFoodDetail = new System.Windows.Forms.DataGridView();
            this.panelCharts = new Guna.UI2.WinForms.Guna2Panel();
            this.chartFoodPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLegend = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTopItems = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTopWorst = new System.Windows.Forms.Label();
            this.lblTopBest = new System.Windows.Forms.Label();
            this.panelSummary.SuspendLayout();
            this.cardFoodRevenue.SuspendLayout();
            this.cardTotalOrders.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodDetail)).BeginInit();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFoodPie)).BeginInit();
            this.panelTopItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelSummary.Controls.Add(this.cardFoodRevenue);
            this.panelSummary.Controls.Add(this.cardTotalOrders);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelSummary.Location = new System.Drawing.Point(0, 0);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Padding = new System.Windows.Forms.Padding(20, 20, 20, 12);
            this.panelSummary.Size = new System.Drawing.Size(848, 140);
            this.panelSummary.TabIndex = 3;
            // 
            // cardFoodRevenue
            // 
            this.cardFoodRevenue.BackColor = System.Drawing.Color.White;
            this.cardFoodRevenue.BorderRadius = 16;
            this.cardFoodRevenue.Controls.Add(this.lblFoodRevenue);
            this.cardFoodRevenue.FillColor = System.Drawing.Color.White;
            this.cardFoodRevenue.Location = new System.Drawing.Point(320, 20);
            this.cardFoodRevenue.Name = "cardFoodRevenue";
            this.cardFoodRevenue.ShadowDecoration.BorderRadius = 16;
            this.cardFoodRevenue.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.cardFoodRevenue.ShadowDecoration.Depth = 12;
            this.cardFoodRevenue.ShadowDecoration.Enabled = true;
            this.cardFoodRevenue.Size = new System.Drawing.Size(280, 108);
            this.cardFoodRevenue.TabIndex = 0;
            // 
            // lblFoodRevenue
            // 
            this.lblFoodRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFoodRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblFoodRevenue.Location = new System.Drawing.Point(0, 0);
            this.lblFoodRevenue.Name = "lblFoodRevenue";
            this.lblFoodRevenue.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.lblFoodRevenue.Size = new System.Drawing.Size(280, 108);
            this.lblFoodRevenue.TabIndex = 0;
            this.lblFoodRevenue.Text = "Doanh thu đồ ăn";
            this.lblFoodRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardTotalOrders
            // 
            this.cardTotalOrders.BackColor = System.Drawing.Color.White;
            this.cardTotalOrders.BorderRadius = 16;
            this.cardTotalOrders.Controls.Add(this.lblTotalOrders);
            this.cardTotalOrders.FillColor = System.Drawing.Color.White;
            this.cardTotalOrders.Location = new System.Drawing.Point(20, 20);
            this.cardTotalOrders.Name = "cardTotalOrders";
            this.cardTotalOrders.ShadowDecoration.BorderRadius = 16;
            this.cardTotalOrders.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.cardTotalOrders.ShadowDecoration.Depth = 12;
            this.cardTotalOrders.ShadowDecoration.Enabled = true;
            this.cardTotalOrders.Size = new System.Drawing.Size(280, 108);
            this.cardTotalOrders.TabIndex = 1;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTotalOrders.Location = new System.Drawing.Point(0, 0);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.lblTotalOrders.Size = new System.Drawing.Size(280, 108);
            this.lblTotalOrders.TabIndex = 0;
            this.lblTotalOrders.Text = "Tổng đơn hàng";
            this.lblTotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelDetail.Controls.Add(this.dgvFoodDetail);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelDetail.Location = new System.Drawing.Point(0, 140);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Padding = new System.Windows.Forms.Padding(20, 8, 20, 12);
            this.panelDetail.Size = new System.Drawing.Size(848, 330);
            this.panelDetail.TabIndex = 2;
            // 
            // dgvFoodDetail
            // 
            this.dgvFoodDetail.AllowUserToAddRows = false;
            this.dgvFoodDetail.AllowUserToDeleteRows = false;
            this.dgvFoodDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvFoodDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFoodDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvFoodDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFoodDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFoodDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            this.dgvFoodDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFoodDetail.ColumnHeadersHeight = 44;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoodDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFoodDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoodDetail.EnableHeadersVisualStyles = false;
            this.dgvFoodDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvFoodDetail.Location = new System.Drawing.Point(20, 8);
            this.dgvFoodDetail.MultiSelect = false;
            this.dgvFoodDetail.Name = "dgvFoodDetail";
            this.dgvFoodDetail.ReadOnly = true;
            this.dgvFoodDetail.RowHeadersVisible = false;
            this.dgvFoodDetail.RowHeadersWidth = 62;
            this.dgvFoodDetail.RowTemplate.Height = 36;
            this.dgvFoodDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodDetail.Size = new System.Drawing.Size(808, 310);
            this.dgvFoodDetail.TabIndex = 0;
            // 
            // panelCharts
            // 
            this.panelCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelCharts.Controls.Add(this.panelLegend);
            this.panelCharts.Controls.Add(this.chartFoodPie);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCharts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelCharts.Location = new System.Drawing.Point(0, 470);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Padding = new System.Windows.Forms.Padding(20, 8, 20, 28);
            this.panelCharts.Size = new System.Drawing.Size(848, 650);
            this.panelCharts.TabIndex = 1;
            // 
            // chartFoodPie
            // 
            this.chartFoodPie.BackColor = System.Drawing.Color.White;
            this.chartFoodPie.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "PieArea";
            this.chartFoodPie.ChartAreas.Add(chartArea1);
            this.chartFoodPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFoodPie.Location = new System.Drawing.Point(20, 8);
            this.chartFoodPie.Name = "chartFoodPie";
            series1.ChartArea = "PieArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "DoanhThu";
            this.chartFoodPie.Series.Add(series1);
            this.chartFoodPie.Size = new System.Drawing.Size(808, 312);
            this.chartFoodPie.TabIndex = 0;
            // 
            // panelLegend
            // 
            this.panelLegend.BackColor = System.Drawing.Color.White;
            this.panelLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLegend.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelLegend.Location = new System.Drawing.Point(20, 392);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Padding = new System.Windows.Forms.Padding(16, 20, 16, 16);
            this.panelLegend.Size = new System.Drawing.Size(750, 40);
            this.panelLegend.TabIndex = 1;
            this.panelLegend.WrapContents = true;
            // 
            // panelTopItems
            // 
            this.panelTopItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelTopItems.Controls.Add(this.lblTopWorst);
            this.panelTopItems.Controls.Add(this.lblTopBest);
            this.panelTopItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelTopItems.Location = new System.Drawing.Point(0, 790);
            this.panelTopItems.Name = "panelTopItems";
            this.panelTopItems.Padding = new System.Windows.Forms.Padding(20, 8, 20, 20);
            this.panelTopItems.Size = new System.Drawing.Size(848, 160);
            this.panelTopItems.TabIndex = 0;
            this.panelTopItems.Visible = false;
            // 
            // lblTopWorst
            // 
            this.lblTopWorst.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopWorst.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTopWorst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTopWorst.Location = new System.Drawing.Point(20, 73);
            this.lblTopWorst.Name = "lblTopWorst";
            this.lblTopWorst.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblTopWorst.Size = new System.Drawing.Size(808, 65);
            this.lblTopWorst.TabIndex = 0;
            this.lblTopWorst.Text = "Sản phẩm bán ít nhất:";
            // 
            // lblTopBest
            // 
            this.lblTopBest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopBest.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTopBest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTopBest.Location = new System.Drawing.Point(20, 8);
            this.lblTopBest.Name = "lblTopBest";
            this.lblTopBest.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblTopBest.Size = new System.Drawing.Size(808, 65);
            this.lblTopBest.TabIndex = 1;
            this.lblTopBest.Text = "Sản phẩm bán chạy nhất:";
            // 
            // Bossdtfood
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.panelTopItems);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelSummary);
            this.Name = "Bossdtfood";
            this.Size = new System.Drawing.Size(848, 1000);
            this.panelSummary.ResumeLayout(false);
            this.cardFoodRevenue.ResumeLayout(false);
            this.cardTotalOrders.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodDetail)).EndInit();
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFoodPie)).EndInit();
            this.panelTopItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}