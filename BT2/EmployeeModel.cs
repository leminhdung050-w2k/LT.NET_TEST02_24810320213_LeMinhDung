namespace BT2
{
    // Hồ sơ nhân viên (ảnh chỉ lưu đường dẫn file)
    public class EmployeeModel
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string AvatarPath { get; set; }
    }
}
