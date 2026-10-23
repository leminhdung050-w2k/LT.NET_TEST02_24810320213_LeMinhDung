using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BT3
{
    // Form con 1: quản lý hồ sơ sinh viên (nhúng vào MDI)
    public partial class frmStudentList : Form
    {
        private BindingList<StudentModel> dsSinhVien = new BindingList<StudentModel>();

        public frmStudentList()
        {
            InitializeComponent();
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            dsSinhVien.Add(new StudentModel { StudentId = "SV001", FullName = "Lê Minh Dũng", BirthDate = new DateTime(2005, 5, 20), Gender = "Nam", ClassName = "D19QTANM1" });
            dsSinhVien.Add(new StudentModel { StudentId = "SV002", FullName = "Trần Thị Bình", BirthDate = new DateTime(2005, 9, 2), Gender = "Nữ", ClassName = "D19CNPM1" });
            dsSinhVien.Add(new StudentModel { StudentId = "SV003", FullName = "Nguyễn Văn An", BirthDate = new DateTime(2004, 12, 15), Gender = "Nam", ClassName = "D19QTANM1" });

            dgvSinhVien.AutoGenerateColumns = false;
            bsSinhVien.DataSource = dsSinhVien;
            dgvSinhVien.DataSource = bsSinhVien;
        }

        // Gửi thông báo lên StatusStrip của Form cha MDI
        private void GuiThongBao(string thongBao)
        {
            frmSchoolMain main = this.MdiParent as frmSchoolMain;
            if (main != null) main.CapNhatTrangThai("[Sinh viên] " + thongBao);
        }

        private void bsSinhVien_CurrentChanged(object sender, EventArgs e)
        {
            StudentModel sv = bsSinhVien.Current as StudentModel;
            errorProvider1.Clear();
            if (sv == null) return;
            txtMaSV.Text = sv.StudentId;
            txtHoTen.Text = sv.FullName;
            dtpNgaySinh.Value = sv.BirthDate;
            cboGioiTinh.SelectedItem = sv.Gender;
            cboLop.SelectedItem = sv.ClassName;
        }

        private bool KiemTraHopLe(StudentModel dangSua)
        {
            errorProvider1.Clear();
            bool hopLe = true;
            string ma = txtMaSV.Text.Trim();

            if (ma == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không được để trống.");
                hopLe = false;
            }
            else if (dsSinhVien.Any(sv => sv != dangSua && sv.StudentId.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên đã tồn tại.");
                hopLe = false;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống.");
                hopLe = false;
            }
            if (cboGioiTinh.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboGioiTinh, "Vui lòng chọn giới tính.");
                hopLe = false;
            }
            if (cboLop.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboLop, "Vui lòng chọn lớp.");
                hopLe = false;
            }
            return hopLe;
        }

        private void GhiVaoSinhVien(StudentModel sv)
        {
            sv.StudentId = txtMaSV.Text.Trim();
            sv.FullName = txtHoTen.Text.Trim();
            sv.BirthDate = dtpNgaySinh.Value.Date;
            sv.Gender = cboGioiTinh.SelectedItem.ToString();
            sv.ClassName = cboLop.SelectedItem.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe(null)) return;
            StudentModel sv = new StudentModel();
            GhiVaoSinhVien(sv);
            dsSinhVien.Add(sv);
            bsSinhVien.Position = dsSinhVien.IndexOf(sv);
            GuiThongBao("Đã thêm sinh viên " + sv.StudentId + " - " + sv.FullName + ".");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            StudentModel sv = bsSinhVien.Current as StudentModel;
            if (sv == null) return;
            if (!KiemTraHopLe(sv)) return;
            GhiVaoSinhVien(sv);
            bsSinhVien.ResetCurrentItem();
            GuiThongBao("Đã cập nhật sinh viên " + sv.StudentId + ".");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            StudentModel sv = bsSinhVien.Current as StudentModel;
            if (sv == null) return;
            if (MessageBox.Show("Xóa sinh viên " + sv.FullName + "?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bsSinhVien.RemoveCurrent();
                GuiThongBao("Đã xóa sinh viên " + sv.StudentId + ".");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = new DateTime(2005, 1, 1);
            cboGioiTinh.SelectedIndex = -1;
            cboLop.SelectedIndex = -1;
            txtMaSV.Focus();
        }
    }
}
