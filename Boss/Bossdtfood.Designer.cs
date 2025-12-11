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
            this.panelSummary.Controls.Add(this.cardFoodRevenue);
            this.panelSummary.Controls.Add(this.cardTotalOrders);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.FillColor = System.Drawing.Color.Yellow;
            this.panelSummary.Location = new System.Drawing.Point(0, 0);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Padding = new System.Windows.Forms.Padding(10);
            this.panelSummary.Size = new System.Drawing.Size(848, 120);
            this.panelSummary.TabIndex = 3;
            // 
            // cardFoodRevenue
            // 
            this.cardFoodRevenue.BackColor = System.Drawing.Color.Silver;
            this.cardFoodRevenue.Controls.Add(this.lblFoodRevenue);
            this.cardFoodRevenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardFoodRevenue.Location = new System.Drawing.Point(260, 10);
            this.cardFoodRevenue.Name = "cardFoodRevenue";
            this.cardFoodRevenue.Size = new System.Drawing.Size(250, 100);
            this.cardFoodRevenue.TabIndex = 0;
            // 
            // lblFoodRevenue
            // 
            this.lblFoodRevenue.Location = new System.Drawing.Point(0, 0);
            this.lblFoodRevenue.Name = "lblFoodRevenue";
            this.lblFoodRevenue.Size = new System.Drawing.Size(100, 23);
            this.lblFoodRevenue.TabIndex = 0;
            // 
            // cardTotalOrders
            // 
            this.cardTotalOrders.BackColor = System.Drawing.Color.Silver;
            this.cardTotalOrders.Controls.Add(this.lblTotalOrders);
            this.cardTotalOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardTotalOrders.Location = new System.Drawing.Point(10, 10);
            this.cardTotalOrders.Name = "cardTotalOrders";
            this.cardTotalOrders.Size = new System.Drawing.Size(250, 100);
            this.cardTotalOrders.TabIndex = 1;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.Location = new System.Drawing.Point(0, 0);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(100, 23);
            this.lblTotalOrders.TabIndex = 0;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.dgvFoodDetail);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDetail.Location = new System.Drawing.Point(0, 120);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Padding = new System.Windows.Forms.Padding(10);
            this.panelDetail.Size = new System.Drawing.Size(848, 300);
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
            this.dgvFoodDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFoodDetail.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoodDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFoodDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoodDetail.EnableHeadersVisualStyles = false;
            this.dgvFoodDetail.Location = new System.Drawing.Point(10, 10);
            this.dgvFoodDetail.MultiSelect = false;
            this.dgvFoodDetail.Name = "dgvFoodDetail";
            this.dgvFoodDetail.ReadOnly = true;
            this.dgvFoodDetail.RowHeadersWidth = 62;
            this.dgvFoodDetail.RowTemplate.Height = 30;
            this.dgvFoodDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodDetail.Size = new System.Drawing.Size(828, 280);
            this.dgvFoodDetail.TabIndex = 0;
            // 
            // panelCharts
            // 
            this.panelCharts.Controls.Add(this.chartFoodPie);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCharts.FillColor = System.Drawing.Color.White;
            this.panelCharts.Location = new System.Drawing.Point(0, 420);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Padding = new System.Windows.Forms.Padding(10);
            this.panelCharts.Size = new System.Drawing.Size(848, 300);
            this.panelCharts.TabIndex = 1;
            // 
            // chartFoodPie
            // 
            this.chartFoodPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "PieArea";
            this.chartFoodPie.ChartAreas.Add(chartArea1);
            this.chartFoodPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFoodPie.Location = new System.Drawing.Point(10, 10);
            this.chartFoodPie.Name = "chartFoodPie";
            series1.ChartArea = "PieArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "DoanhThu";
            this.chartFoodPie.Series.Add(series1);
            this.chartFoodPie.Size = new System.Drawing.Size(828, 280);
            this.chartFoodPie.TabIndex = 0;
            this.chartFoodPie.Click += new System.EventHandler(this.chartFoodPie_Click);
            // 
            // panelTopItems
            // 
            this.panelTopItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTopItems.Controls.Add(this.lblTopWorst);
            this.panelTopItems.Controls.Add(this.lblTopBest);
            this.panelTopItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTopItems.Location = new System.Drawing.Point(0, 720);
            this.panelTopItems.Name = "panelTopItems";
            this.panelTopItems.Padding = new System.Windows.Forms.Padding(10);
            this.panelTopItems.Size = new System.Drawing.Size(848, 430);
            this.panelTopItems.TabIndex = 0;
            // 
            // lblTopWorst
            // 
            this.lblTopWorst.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopWorst.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTopWorst.ForeColor = System.Drawing.Color.Black;
            this.lblTopWorst.Location = new System.Drawing.Point(10, 100);
            this.lblTopWorst.Name = "lblTopWorst";
            this.lblTopWorst.Size = new System.Drawing.Size(828, 90);
            this.lblTopWorst.TabIndex = 0;
            this.lblTopWorst.Text = "Sản phẩm bán ít nhất:";
            // 
            // lblTopBest
            // 
            this.lblTopBest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopBest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTopBest.ForeColor = System.Drawing.Color.Black;
            this.lblTopBest.Location = new System.Drawing.Point(10, 10);
            this.lblTopBest.Name = "lblTopBest";
            this.lblTopBest.Size = new System.Drawing.Size(828, 90);
            this.lblTopBest.TabIndex = 1;
            this.lblTopBest.Text = "Sản phẩm bán chạy nhất:";
            // 
            // Bossdtfood
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panelTopItems);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelSummary);
            this.Name = "Bossdtfood";
            this.Size = new System.Drawing.Size(848, 974);
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