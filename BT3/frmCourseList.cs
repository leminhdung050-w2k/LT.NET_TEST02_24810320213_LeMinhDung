using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BT3
{
    // Form con 2: quản lý danh mục môn học (nhúng vào MDI)
    public partial class frmCourseList : Form
    {
        private BindingList<CourseModel> dsMonHoc = new BindingList<CourseModel>();

        public frmCourseList()
        {
            InitializeComponent();
        }

        private void frmCourseList_Load(object sender, EventArgs e)
        {
            dsMonHoc.Add(new CourseModel { CourseId = "LTNET", CourseName = "Lập trình .NET", Credits = 3, Lecturer = "ThS. Nguyễn Văn Hùng" });
            dsMonHoc.Add(new CourseModel { CourseId = "CSDL", CourseName = "Cơ sở dữ liệu", Credits = 3, Lecturer = "TS. Trần Thu Hà" });
            dsMonHoc.Add(new CourseModel { CourseId = "ATTT", CourseName = "An toàn thông tin", Credits = 2, Lecturer = "ThS. Lê Quang Minh" });

            dgvMonHoc.AutoGenerateColumns = false;
            bsMonHoc.DataSource = dsMonHoc;
            dgvMonHoc.DataSource = bsMonHoc;
        }

        private void GuiThongBao(string thongBao)
        {
            frmSchoolMain main = this.MdiParent as frmSchoolMain;
            if (main != null) main.CapNhatTrangThai("[Môn học] " + thongBao);
        }

        private void bsMonHoc_CurrentChanged(object sender, EventArgs e)
        {
            CourseModel mh = bsMonHoc.Current as CourseModel;
            errorProvider1.Clear();
            if (mh == null) return;
            txtMaMon.Text = mh.CourseId;
            txtTenMon.Text = mh.CourseName;
            numSoTinChi.Value = mh.Credits;
            txtGiangVien.Text = mh.Lecturer;
        }

        private bool KiemTraHopLe(CourseModel dangSua)
        {
            errorProvider1.Clear();
            bool hopLe = true;
            string ma = txtMaMon.Text.Trim();

            if (ma == "")
            {
                errorProvider1.SetError(txtMaMon, "Mã môn không được để trống.");
                hopLe = false;
            }
            else if (dsMonHoc.Any(m => m != dangSua && m.CourseId.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaMon, "Mã môn đã tồn tại.");
                hopLe = false;
            }
            if (txtTenMon.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenMon, "Tên môn không được để trống.");
                hopLe = false;
            }
            return hopLe;
        }

        private void GhiVaoMonHoc(CourseModel mh)
        {
            mh.CourseId = txtMaMon.Text.Trim();
            mh.CourseName = txtTenMon.Text.Trim();
            mh.Credits = (int)numSoTinChi.Value;
            mh.Lecturer = txtGiangVien.Text.Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe(null)) return;
            CourseModel mh = new CourseModel();
            GhiVaoMonHoc(mh);
            dsMonHoc.Add(mh);
            bsMonHoc.Position = dsMonHoc.IndexOf(mh);
            GuiThongBao("Đã thêm môn " + mh.CourseName + ".");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CourseModel mh = bsMonHoc.Current as CourseModel;
            if (mh == null) return;
            if (!KiemTraHopLe(mh)) return;
            GhiVaoMonHoc(mh);
            bsMonHoc.ResetCurrentItem();
            GuiThongBao("Đã cập nhật môn " + mh.CourseName + ".");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CourseModel mh = bsMonHoc.Current as CourseModel;
            if (mh == null) return;
            if (MessageBox.Show("Xóa môn " + mh.CourseName + "?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bsMonHoc.RemoveCurrent();
                GuiThongBao("Đã xóa môn " + mh.CourseName + ".");
            }
        }
    }
}
