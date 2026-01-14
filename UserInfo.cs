using System;

namespace MovieTicketApp
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime? NgaySinh { get; set; }
    }
}