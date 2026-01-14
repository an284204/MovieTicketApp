using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class ModernDatePicker : UserControl
    {
        public DateTime SelectedDate { get; set; } = DateTime.Now;

        private TextBox txtDate;
        private Button btnOpen;

        public ModernDatePicker()
        {
            InitializeCustomComponents();
        }
        private void ModernDatePicker_Load(object sender, EventArgs e)
        {
            // code init nếu cần
        }

        private void InitializeCustomComponents()
        {
            this.Height = 36;
            this.Width = 150;

            txtDate = new TextBox
            {
                ReadOnly = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10),
                Text = SelectedDate.ToString("dd/MM/yyyy"),
                Location = new Point(0, 0),
                Width = this.Width - 36,
                Height = 36
            };

            btnOpen = new Button
            {
                Text = "📅",
                Font = new Font("Segoe UI", 10),
                Location = new Point(this.Width - 36, 0),
                Size = new Size(36, 36),
                FlatStyle = FlatStyle.Flat
            };
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.Click += BtnOpen_Click;

            this.Controls.Add(txtDate);
            this.Controls.Add(btnOpen);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            Form popup = new Form()
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual,
                ShowInTaskbar = false,
                BackColor = Color.White
            };

            ModernCalendar calendar = new ModernCalendar(SelectedDate)
            {
                Size = new Size(240, 260),
                Location = new Point(0, 0)
            };


            calendar.OnDateSelected += (d) =>
            {
                SelectedDate = d;
                txtDate.Text = d.ToString("dd/MM/yyyy");
                popup.Close();
            };

            popup.ClientSize = calendar.Size;
            popup.Controls.Add(calendar);
            popup.Location = this.PointToScreen(new Point(0, this.Height));

            // Chỉ show một lần
            popup.Show(this.FindForm());
        }
    }
}
