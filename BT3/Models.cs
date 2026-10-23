using System;

namespace BT3
{
    // Hồ sơ sinh viên
    public class StudentModel
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string ClassName { get; set; }
    }

    // Môn học / lớp học phần
    public class CourseModel
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public string Lecturer { get; set; }
    }

    // Giảng viên
    public class LecturerModel
    {
        public string LecturerId { get; set; }
        public string FullName { get; set; }
        public string Faculty { get; set; }
        public string Degree { get; set; }
    }
}
