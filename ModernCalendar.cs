using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class ModernCalendar : UserControl
    {
        public event Action<DateTime> OnDateSelected;

        private DateTime currentMonth;
        private DateTime selectedDate;

        private Rectangle btnPrev;
        private Rectangle btnNext;

        public ModernCalendar()
        {
            InitializeComponent();         // MUST HAVE
            InitializeCustomCalendar(DateTime.Now);
        }

        public ModernCalendar(DateTime selected)
        {
            InitializeComponent();         // MUST HAVE
            InitializeCustomCalendar(selected);
        }

        private void InitializeCustomCalendar(DateTime selected)
        {
            selectedDate = selected;
            currentMonth = new DateTime(selected.Year, selected.Month, 1);

            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.Size = new Size(240, 260);

            btnPrev = new Rectangle(5, 5, 25, 25);
            btnNext = new Rectangle(this.Width - 30, 5, 25, 25);

            this.Paint += ModernCalendar_Paint;
            this.MouseClick += ModernCalendar_MouseClick;
        }
        private void ModernCalendar_Load(object sender, EventArgs e)
        {
            // Optional: thêm code khi load, hoặc để trống
        }

        private void ModernCalendar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(Brushes.White, this.ClientRectangle);

            using (Font fTitle = new Font("Segoe UI", 10, FontStyle.Bold))
            {
                string title = currentMonth.ToString("MMMM yyyy");
                SizeF titleSize = g.MeasureString(title, fTitle);
                g.DrawString(title, fTitle, Brushes.Black, (Width - titleSize.Width) / 2, 5);

                // Nút chuyển tháng
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    Rectangle rectPrev = new Rectangle(btnPrev.X, btnPrev.Y, btnPrev.Width, btnPrev.Height);
                    Rectangle rectNext = new Rectangle(btnNext.X, btnNext.Y, btnNext.Width, btnNext.Height);

                    g.DrawString("<", fTitle, Brushes.Black, rectPrev, sf);
                    g.DrawString(">", fTitle, Brushes.Black, rectNext, sf);
                }
            }

            DrawWeekDays(g);
            DrawDays(g);
        }


        private void DrawWeekDays(Graphics g)
        {
            string[] weekDays = { "T2", "T3", "T4", "T5", "T6", "T7", "CN" };

            int startX = 10;
            int startY = 30;
            int w = 35;
            int h = 22;
            int spacing = 4;

            using (Font f = new Font("Segoe UI", 9, FontStyle.Bold))
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                Brush textBrush = Brushes.Black; // Dùng trực tiếp, không dispose

                for (int i = 0; i < 7; i++)
                {
                    Rectangle rect = new Rectangle(
                        startX + i * (w + spacing),
                        startY,
                        w,
                        h
                    );

                    // kiểm tra rectangle hợp lệ
                    if (rect.Width > 0 && rect.Height > 0)
                    {
                        g.DrawString(weekDays[i], f, textBrush, rect, sf);
                    }
                }
            }
        }


        private void DrawDays(Graphics g)
        {
            int startX = 10, startY = 50;
            int w = 30, h = 25;

            DateTime firstDay = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int startIndex = ((int)firstDay.DayOfWeek + 6) % 7; // Thứ 2 = 0

            using (Font f = new Font("Segoe UI", 8))
            using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (Brush selectedBrush = new SolidBrush(Color.FromArgb(90, 150, 255))) // dùng brush riêng cho highlight
            {
                Brush textBrush = Brushes.Black; // Dùng trực tiếp, không dispose

                for (int d = 1; d <= DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month); d++)
                {
                    int col = (startIndex + d - 1) % 7;
                    int row = (startIndex + d - 1) / 7;

                    Rectangle rect = new Rectangle(
                        startX + col * (w + 2),
                        startY + row * (h + 2),
                        w, h
                    );

                    // Highlight ngày được chọn
                    if (selectedDate.Day == d &&
                        selectedDate.Month == currentMonth.Month &&
                        selectedDate.Year == currentMonth.Year)
                    {
                        int padding = 3;
                        Rectangle ellipseRect = new Rectangle(
                            rect.X + padding,
                            rect.Y + padding,
                            rect.Width - padding * 2,
                            rect.Height - padding * 2
                        );

                        g.FillEllipse(selectedBrush, ellipseRect);
                    }

                    g.DrawString(d.ToString(), f, textBrush, rect, format);
                }
            }
        }



        private void ModernCalendar_MouseClick(object sender, MouseEventArgs e)
        {
            // Chuyển tháng
            if (btnPrev.Contains(e.Location))
            {
                currentMonth = currentMonth.AddMonths(-1);
                Invalidate();
                return;
            }
            if (btnNext.Contains(e.Location))
            {
                currentMonth = currentMonth.AddMonths(1);
                Invalidate();
                return;
            }

            // Chọn ngày
            int startX = 10, startY = 50, w = 30, h = 25;
            DateTime firstDay = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int startIndex = ((int)firstDay.DayOfWeek + 6) % 7;

            for (int d = 1; d <= DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month); d++)
            {
                int col = (startIndex + d - 1) % 7;
                int row = (startIndex + d - 1) / 7;
                int x = startX + col * (w + 2);
                int y = startY + row * (h + 2);
                Rectangle rect = new Rectangle(x, y, w, h);

                if (rect.Contains(e.Location))
                {
                    selectedDate = new DateTime(currentMonth.Year, currentMonth.Month, d);
                    OnDateSelected?.Invoke(selectedDate);
                    Invalidate();
                    break;
                }
            }
        }
    }
}
