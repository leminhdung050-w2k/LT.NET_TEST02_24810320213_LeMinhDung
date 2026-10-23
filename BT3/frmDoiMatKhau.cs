using System;
using System.Windows.Forms;

namespace BT3
{
    // Hộp thoại đổi mật khẩu (mở bằng ShowDialog từ Form cha)
    public partial class frmDoiMatKhau : Form
    {
        private string matKhauHienTai;

        // Form cha đọc mật khẩu mới sau khi bấm Đồng ý
        public string MatKhauMoi { get; private set; }

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public frmDoiMatKhau(string matKhauHienTai) : this()
        {
            this.matKhauHienTai = matKhauHienTai;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (txtMatKhauCu.Text != matKhauHienTai)
            {
                errorProvider1.SetError(txtMatKhauCu, "Mật khẩu cũ không đúng.");
                hopLe = false;
            }
            if (txtMatKhauMoi.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhauMoi, "Mật khẩu mới phải có ít nhất 6 ký tự.");
                hopLe = false;
            }
            else if (txtMatKhauMoi.Text == matKhauHienTai)
            {
                errorProvider1.SetError(txtMatKhauMoi, "Mật khẩu mới phải khác mật khẩu cũ.");
                hopLe = false;
            }
            if (txtXacNhan.Text != txtMatKhauMoi.Text)
            {
                errorProvider1.SetError(txtXacNhan, "Nhập lại mật khẩu không khớp.");
                hopLe = false;
            }
            if (!hopLe) return;

            MatKhauMoi = txtMatKhauMoi.Text;
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
