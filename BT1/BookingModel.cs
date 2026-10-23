using System;

namespace BT1
{
    // Thông tin một lượt đặt phòng
    public class BookingModel
    {
        public string BookingId { get; set; }
        public string CustomerName { get; set; }
        public string IdentityCard { get; set; }
        public string RoomType { get; set; }
        public DateTime CheckIn { get; set; }
        public int Days { get; set; }
        public decimal PricePerNight { get; set; }
    }
}
