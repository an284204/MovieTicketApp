using System;

namespace MovieTicketApp.Models
{
    public class ChatMessage
    {
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Message { get; set; }
        public DateTime SentTime { get; set; }
    }
}