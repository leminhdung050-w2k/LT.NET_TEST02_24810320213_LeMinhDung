using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class frmSchoolMain : Form
    {
        private string canBoQuanLy = Environment.UserName; // cán bộ đang đăng nhập
        private string matKhau = "123456";                 // mật khẩu mặc định
        private bool daDangNhap = true;

        public frmSchoolMain()
        {
            InitializeComponent();
        }

        private void frmSchoolMain_Load(object sender, EventArgs e)
        {
            CapNhatGiaoDienDangNhap();
            CapNhatTrangThai("Xin chào " + canBoQuanLy + "!");
        }

        // Form con gọi hàm này để báo thông tin lên StatusStrip của Form cha
        public void CapNhatTrangThai(string thongBao)
        {
            lblThongBao.Text = DateTime.Now.ToString("HH:mm:ss") + "  |  " + thongBao;
        }

        // Thanh tiến trình ToolStripProgressBar: chạy khi đang nạp Form con
        private async Task ChayTienTrinh()
        {
            pgbTienTrinh.Value = 0;
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(30);
                pgbTienTrinh.Value = i * 10;
            }
            await Task.Delay(200);
            pgbTienTrinh.Value = 0;
        }

        //1. Quản lý Form con MDI: không mở lặp lại cùng một Form
        private async void MoFormCon<T>() where T : Form, new()
        {
            // Kiểm tra trong danh sách MdiChildren
            foreach (Form f in this.MdiChildren)
            {
                if (f is T)
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Activate(); // Form đã mở -> đưa lên trước
                    CapNhatTrangThai("Cửa sổ \"" + f.Text + "\" đang mở -> đưa lên trước.");
                    return;
                }
            }

            // Form chưa mở -> khởi tạo Instance mới, gán MdiParent và Show()
            T frm = new T();
            frm.MdiParent = this;
            frm.FormClosed += (s, e) => CapNhatTrangThai("Đã đóng cửa sổ \"" + frm.Text + "\".");
            frm.Show();
            CapNhatTrangThai("Đang tải \"" + frm.Text + "\"...");
            await ChayTienTrinh();
            CapNhatTrangThai("Đã mở cửa sổ \"" + frm.Text + "\".");
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            MoFormCon<frmStudentList>();
        }

        private void mnuGiangVien_Click(object sender, EventArgs e)
        {
            MoFormCon<frmLecturerList>();
        }

        private void mnuLopHoc_Click(object sender, EventArgs e)
        {
            MoFormCon<frmCourseList>();
        }

        //2. Sắp xếp cửa sổ
        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            CapNhatTrangThai("Đã sắp xếp xếp tầng (Cascade).");
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            CapNhatTrangThai("Đã sắp xếp ngang (Tile Horizontal).");
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            CapNhatTrangThai("Đã sắp xếp dọc (Tile Vertical).");
        }

        private void mnuDongTatCa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            CapNhatTrangThai("Đã đóng tất cả cửa sổ.");
        }

        //Hệ thống: Đăng xuất / Đổi mật khẩu / Thoát
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (daDangNhap)
            {
                if (MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                }
                daDangNhap = false;
                CapNhatGiaoDienDangNhap();
                CapNhatTrangThai("Đã đăng xuất. Chọn \"Đăng nhập\" để sử dụng lại.");
            }
            else
            {
                daDangNhap = true;
                CapNhatGiaoDienDangNhap();
                CapNhatTrangThai("Đăng nhập lại thành công. Xin chào " + canBoQuanLy + "!");
            }
        }

        // Bật / tắt chức năng theo trạng thái đăng nhập
        private void CapNhatGiaoDienDangNhap()
        {
            mnuQuanLy.Enabled = daDangNhap;
            mnuCuaSo.Enabled = daDangNhap;
            mnuDoiMatKhau.Enabled = daDangNhap;
            mnuDangXuat.Text = daDangNhap ? "Đăng xuất" : "Đăng nhập";
            lblCanBo.Text = "Cán bộ quản lý: " + (daDangNhap ? canBoQuanLy : "(chưa đăng nhập)");
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (frmDoiMatKhau frm = new frmDoiMatKhau(matKhau))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    matKhau = frm.MatKhauMoi;
                    CapNhatTrangThai("Đổi mật khẩu thành công.");
                }
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
