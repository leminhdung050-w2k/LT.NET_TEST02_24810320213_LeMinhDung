using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BT3
{
    // Form con: danh sách giảng viên (chỉ xem)
    public partial class frmLecturerList : Form
    {
        private BindingList<LecturerModel> dsGiangVien = new BindingList<LecturerModel>();

        public frmLecturerList()
        {
            InitializeComponent();
        }

        private void frmLecturerList_Load(object sender, EventArgs e)
        {
            dsGiangVien.Add(new LecturerModel { LecturerId = "GV01", FullName = "Nguyễn Văn Hùng", Faculty = "Công nghệ thông tin", Degree = "Thạc sĩ" });
            dsGiangVien.Add(new LecturerModel { LecturerId = "GV02", FullName = "Trần Thu Hà", Faculty = "Công nghệ thông tin", Degree = "Tiến sĩ" });
            dsGiangVien.Add(new LecturerModel { LecturerId = "GV03", FullName = "Lê Quang Minh", Faculty = "An toàn thông tin", Degree = "Thạc sĩ" });
            dsGiangVien.Add(new LecturerModel { LecturerId = "GV04", FullName = "Phạm Thị Lan", Faculty = "Khoa học cơ bản", Degree = "Phó Giáo sư" });

            dgvGiangVien.AutoGenerateColumns = false;
            bsGiangVien.DataSource = dsGiangVien;
            dgvGiangVien.DataSource = bsGiangVien;
            lblTongSo.Text = "Tổng số giảng viên: " + dsGiangVien.Count;
        }
    }
}
