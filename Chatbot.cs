using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MovieTicketApp
{
    public partial class Chatbot : Form
    {
        public Chatbot()
        {
            InitializeComponent();
        }

      //  Xử lý khi bấm nút Gửi
        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {
                // Hiển thị tin nhắn người dùng
                AddMessage(txtInput.Text, true);

                // Gọi sang Python Flask API
                string reply = await CallPythonBot(txtInput.Text);

                // Hiển thị câu trả lời từ chatbot
                AddMessage(reply, false);

                txtInput.Clear();
            }
        }

        // Hàm hiển thị tin nhắn dạng bubble
        private void AddMessage(string text, bool isUser)
        {
            Label bubble = new Label()
            {
                AutoSize = true,
                MaximumSize = new Size(250, 0),
                Text = text,
                Padding = new Padding(8),
                Margin = new Padding(5),
                BackColor = isUser ? Color.OrangeRed : Color.LightGray,
                ForeColor = isUser ? Color.White : Color.Black,
                Font = new Font("Segoe UI", 9)
            };

            // Panel chứa bubble để căn chỉnh trái/phải
            Panel container = new Panel()
            {
                AutoSize = true,
                Width = chatPanel.ClientSize.Width - 25,
                Margin = new Padding(0)
            };

            // Đặt vị trí bubble trong container
            if (isUser)
            {
                bubble.Location = new Point(container.Width - bubble.PreferredWidth - 10, 0);
            }
            else
            {
                bubble.Location = new Point(10, 0);
            }

            container.Controls.Add(bubble);
            chatPanel.Controls.Add(container);
            chatPanel.ScrollControlIntoView(container);
        }

        // Hàm gọi Flask API bên Python
        private async Task<string> CallPythonBot(string userMessage)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var payload = new { query = userMessage };
                    var json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("http://127.0.0.1:5000/ask", content);
                    var result = await response.Content.ReadAsStringAsync();

                    dynamic obj = JsonConvert.DeserializeObject(result);
                    return obj.answer;
                }
            }
            catch (Exception ex)
            {
                return "❌ Lỗi kết nối chatbot: " + ex.Message;
            }
        }

        //private void btnSend_Click(object sender, EventArgs e)
        //{

        //}
    }
}