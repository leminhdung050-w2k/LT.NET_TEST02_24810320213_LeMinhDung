namespace BT4
{
    // Một dòng báo cáo tồn kho
    public class ReportItem
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Kho { get; set; }
        public int SoLuongTon { get; set; }
        public decimal DonGia { get; set; }

        // Giá trị tồn = số lượng tồn x đơn giá
        public decimal GiaTriTon
        {
            get { return SoLuongTon * DonGia; }
        }
    }
}
