using System;

namespace BT5
{
    // Một mốc nhiệt độ ghi nhận được từ cảm biến
    public class LogItem
    {
        public int Lan { get; set; }
        public DateTime ThoiGian { get; set; }
        public double NhietDo { get; set; }

        public string TrangThai
        {
            get { return NhietDo > 37 ? "CẢNH BÁO - Quá nhiệt" : "Bình thường"; }
        }
    }
}
