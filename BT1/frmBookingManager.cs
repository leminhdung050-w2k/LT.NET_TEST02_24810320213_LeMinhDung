using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BT1
{
    public partial class frmBookingManager : Form
    {
        //DỮ LIỆU: BindingList<T> nối với DataGridView qua bsBookings (BindingSource kéo từ Toolbox)
        private BindingList<BookingModel> dsDatPhong = new BindingList<BookingModel>();

        public frmBookingManager()
        {
            InitializeComponent();
        }

        private void frmBookingManager_Load(object sender, EventArgs e)
        {
            TaoDuLieuMau();
            KhoiTaoGrid();

            bsBookings.DataSource = dsDatPhong;
            dgvBookings.DataSource = bsBookings;

            GanDataBinding();
        }

        private void TaoDuLieuMau()
        {
            DateTime hom = DateTime.Today;
            dsDatPhong.Add(new BookingModel { BookingId = "BK001", CustomerName = "Nguyễn Văn An", IdentityCard = "001203004567", RoomType = "Deluxe", CheckIn = hom, Days = 2, PricePerNight = 1200000 });
            dsDatPhong.Add(new BookingModel { BookingId = "BK002", CustomerName = "Trần Thị Bình", IdentityCard = "123456789", RoomType = "Standard", CheckIn = hom.AddDays(1), Days = 3, PricePerNight = 700000 });
            dsDatPhong.Add(new BookingModel { BookingId = "BK003", CustomerName = "Lê Minh Dũng", IdentityCard = "079204001234", RoomType = "VIP", CheckIn = hom.AddDays(3), Days = 1, PricePerNight = 2500000 });
        }

        //1. Khởi tạo Grid: khai báo cột hoàn toàn bằng code
        private void KhoiTaoGrid()
        {
            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.Columns.Clear();
            ThemCot("BookingId", "Mã Đặt", 70, null);
            ThemCot("CustomerName", "Tên Khách", 140, null);
            ThemCot("IdentityCard", "CCCD", 110, null);
            ThemCot("RoomType", "Loại Phòng", 80, null);
            ThemCot("CheckIn", "Ngày Nhận", 85, "dd/MM/yyyy");
            ThemCot("Days", "Số Đêm", 60, null);
            DataGridViewTextBoxColumn colGia = ThemCot("PricePerNight", "Giá/Đêm", 90, "N0");
            colGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private DataGridViewTextBoxColumn ThemCot(string thuocTinh, string tieuDe, float doRong, string dinhDang)
        {
            DataGridViewTextBoxColumn cot = new DataGridViewTextBoxColumn();
            cot.Name = "col" + thuocTinh;
            cot.DataPropertyName = thuocTinh;   // khớp tên thuộc tính của BookingModel
            cot.HeaderText = tieuDe;
            cot.FillWeight = doRong;
            if (dinhDang != null) cot.DefaultCellStyle.Format = dinhDang;
            dgvBookings.Columns.Add(cot);
            return cot;
        }

        //2. Data Binding 2 chiều
        // - Chọn dòng trên Grid -> BindingSource tự đẩy dữ liệu lên các ô nhập
        // - DataSourceUpdateMode.Never: gõ vào ô nhập chưa làm đổi dữ liệu, chỉ ghi xuống BindingList khi bấm Cập nhật
        private void GanDataBinding()
        {
            txtBookingId.DataBindings.Add("Text", bsBookings, "BookingId", true, DataSourceUpdateMode.Never);
            txtCustomerName.DataBindings.Add("Text", bsBookings, "CustomerName", true, DataSourceUpdateMode.Never);
            txtIdentityCard.DataBindings.Add("Text", bsBookings, "IdentityCard", true, DataSourceUpdateMode.Never);
            cboRoomType.DataBindings.Add("SelectedItem", bsBookings, "RoomType", true, DataSourceUpdateMode.Never);
            dtpCheckIn.DataBindings.Add("Value", bsBookings, "CheckIn", true, DataSourceUpdateMode.Never);
            numDays.DataBindings.Add("Value", bsBookings, "Days", true, DataSourceUpdateMode.Never);
            txtPricePerNight.DataBindings.Add("Text", bsBookings, "PricePerNight", true, DataSourceUpdateMode.Never);
        }

        // Tự động tạo mã BK001, BK002, ...
        private string TaoMaMoi()
        {
            int max = 0;
            foreach (BookingModel b in dsDatPhong)
            {
                int so;
                if (b.BookingId.StartsWith("BK") && int.TryParse(b.BookingId.Substring(2), out so) && so > max)
                    max = so;
            }
            return "BK" + (max + 1).ToString("D3");
        }

        // Đọc giá: bỏ dấu phân cách hàng nghìn
        private bool DocGia(out decimal gia)
        {
            string s = txtPricePerNight.Text.Trim().Replace(",", "").Replace(".", "").Replace(" ", "");
            return decimal.TryParse(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out gia);
        }

        //3. Kiểm tra hợp lệ (ErrorProvider)
        private bool KiemTraHopLe()
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (txtCustomerName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCustomerName, "Tên khách hàng không được để trống.");
                hopLe = false;
            }

            if (!Regex.IsMatch(txtIdentityCard.Text.Trim(), @"^(\d{9}|\d{12})$"))
            {
                errorProvider1.SetError(txtIdentityCard, "CCCD/CMND phải đủ 9 hoặc 12 chữ số.");
                hopLe = false;
            }

            if (cboRoomType.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboRoomType, "Vui lòng chọn loại phòng.");
                hopLe = false;
            }

            decimal gia;
            if (!DocGia(out gia) || gia <= 0)
            {
                errorProvider1.SetError(txtPricePerNight, "Giá phòng phải là số lớn hơn 0.");
                hopLe = false;
            }
            else
            {
                txtPricePerNight.Text = gia.ToString("0"); // chuẩn hóa để binding đọc được
            }

            return hopLe;
        }

        //4. Thêm, cập nhật, xóa, làm mới
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;

            BookingModel b = new BookingModel
            {
                BookingId = TaoMaMoi(),
                CustomerName = txtCustomerName.Text.Trim(),
                IdentityCard = txtIdentityCard.Text.Trim(),
                RoomType = cboRoomType.SelectedItem.ToString(),
                CheckIn = dtpCheckIn.Value.Date,
                Days = (int)numDays.Value,
                PricePerNight = decimal.Parse(txtPricePerNight.Text)
            };

            dsDatPhong.Add(b);
            bsBookings.Position = dsDatPhong.IndexOf(b); // chọn dòng vừa thêm
            MessageBox.Show("Đã thêm đặt phòng " + b.BookingId + ".", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookingModel b = bsBookings.Current as BookingModel;
            if (b == null || txtBookingId.Text != b.BookingId)
            {
                MessageBox.Show("Vui lòng chọn đặt phòng cần cập nhật trên bảng.", "Thông báo");
                return;
            }
            if (!KiemTraHopLe()) return;

            // Ghi giá trị từ các ô nhập xuống đối tượng trong BindingList
            string ten = txtCustomerName.Text.Trim();
            string cccd = txtIdentityCard.Text.Trim();
            string loai = cboRoomType.SelectedItem.ToString();
            DateTime ngay = dtpCheckIn.Value.Date;
            int soDem = (int)numDays.Value;
            decimal gia = decimal.Parse(txtPricePerNight.Text);

            b.CustomerName = ten;
            b.IdentityCard = cccd;
            b.RoomType = loai;
            b.CheckIn = ngay;
            b.Days = soDem;
            b.PricePerNight = gia;
            bsBookings.ResetCurrentItem(); // đồng bộ ngay lên Grid và các ô nhập
            MessageBox.Show("Đã cập nhật đặt phòng " + b.BookingId + ".", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BookingModel b = bsBookings.Current as BookingModel;
            if (b == null)
            {
                MessageBox.Show("Không có đặt phòng nào để xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa đặt phòng " + b.BookingId + " của khách " + b.CustomerName + "?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bsBookings.RemoveCurrent();
                errorProvider1.Clear();
            }
        }

        // Làm mới: xóa trắng ô nhập để chuẩn bị thêm đặt phòng mới
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtBookingId.Text = TaoMaMoi();
            txtCustomerName.Clear();
            txtIdentityCard.Clear();
            cboRoomType.SelectedIndex = 0;
            dtpCheckIn.Value = DateTime.Today;
            numDays.Value = 1;
            txtPricePerNight.Clear();
            txtCustomerName.Focus();
        }
    }
}
