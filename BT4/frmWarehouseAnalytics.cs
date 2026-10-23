using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT4
{
    public partial class frmWarehouseAnalytics : Form
    {
        //DỮ LIỆU: kết quả thống kê, hiển thị qua bsReport (BindingSource kéo từ Toolbox)
        private BindingList<ReportItem> dsBaoCao = new BindingList<ReportItem>();

        // Dùng để hủy tác vụ đang chạy
        private CancellationTokenSource cts;

        public frmWarehouseAnalytics()
        {
            InitializeComponent();
        }

        private void frmWarehouseAnalytics_Load(object sender, EventArgs e)
        {
            cboKho.SelectedIndex = 0;
            dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDenNgay.Value = DateTime.Today;

            dgvReportData.AutoGenerateColumns = false;
            bsReport.DataSource = dsBaoCao;
            dgvReportData.DataSource = bsReport;
        }

        private void GhiNhatKy(string noiDung)
        {
            lstNhatKy.Items.Insert(0, DateTime.Now.ToString("HH:mm:ss") + "  " + noiDung);
        }

        //1. Tác vụ nặng chạy dưới Background Thread bằng Task.Run
        //   Giả lập quét và tổng hợp dữ liệu kho mất khoảng 4,5 giây
        private Task<List<ReportItem>> TongHopDuLieuKhoAsync(string kho, DateTime tuNgay, DateTime denNgay,
            IProgress<int> progress, CancellationToken token)
        {
            return Task.Run(() =>
            {
                string[] cacKho = { "Kho Hà Nội", "Kho Đà Nẵng", "Kho TP.HCM" };
                string[,] hangHoa =
                {
                    { "MH01", "Laptop Dell Inspiron 15", "15500000" },
                    { "MH02", "Màn hình LG 24 inch", "3200000" },
                    { "MH03", "Bàn phím cơ Akko", "1250000" },
                    { "MH04", "Chuột Logitech G102", "450000" },
                    { "MH05", "Ổ cứng SSD 512GB", "1350000" },
                    { "MH06", "RAM DDR4 16GB", "1100000" },
                    { "MH07", "Tai nghe Sony WH-1000XM4", "6200000" },
                    { "MH08", "Router Wifi TP-Link", "890000" }
                };

                // Cùng tiêu chí -> cùng kết quả
                Random rnd = new Random(tuNgay.DayOfYear * 1000 + denNgay.DayOfYear);
                List<ReportItem> ketQua = new List<ReportItem>();
                const int soBuoc = 50;

                for (int buoc = 1; buoc <= soBuoc; buoc++)
                {
                    token.ThrowIfCancellationRequested(); // bấm Hủy -> dừng ngay
                    Thread.Sleep(90);                     // giả lập truy xuất dữ liệu chậm
                    progress.Report(buoc * 100 / soBuoc);
                }

                foreach (string k in cacKho)
                {
                    if (kho != "Tất cả kho" && kho != k) continue;
                    for (int i = 0; i < hangHoa.GetLength(0); i++)
                    {
                        ketQua.Add(new ReportItem
                        {
                            MaHang = hangHoa[i, 0],
                            TenHang = hangHoa[i, 1],
                            Kho = k,
                            SoLuongTon = rnd.Next(5, 300),
                            DonGia = decimal.Parse(hangHoa[i, 2])
                        });
                    }
                }
                return ketQua;
            }, token);
        }

        private async void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtpDenNgay.Value.Date < dtpTuNgay.Value.Date)
            {
                MessageBox.Show("\"Đến ngày\" không được trước \"Từ ngày\".", "Lỗi tiêu chí",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Progress<int> tạo trên UI Thread -> cập nhật ProgressBar an toàn
            Progress<int> progress = new Progress<int>(phanTram =>
            {
                pgbStatus.Value = phanTram;
                lblPercent.Text = phanTram + "%";
            });

            string kho = cboKho.Text;
            btnThongKe.Enabled = false;
            btnHuy.Enabled = true;
            pgbStatus.Value = 0;
            lblPercent.Text = "0%";
            cts = new CancellationTokenSource();
            GhiNhatKy("Bắt đầu thống kê " + kho + " (" + dtpTuNgay.Value.ToString("dd/MM/yyyy") + " - " + dtpDenNgay.Value.ToString("dd/MM/yyyy") + ")");

            try
            {
                // await: UI Thread được giải phóng trong lúc chờ -> Form không bị "Not Responding"
                List<ReportItem> ketQua = await TongHopDuLieuKhoAsync(kho, dtpTuNgay.Value.Date, dtpDenNgay.Value.Date, progress, cts.Token);

                dsBaoCao.RaiseListChangedEvents = false;
                dsBaoCao.Clear();
                foreach (ReportItem r in ketQua) dsBaoCao.Add(r);
                dsBaoCao.RaiseListChangedEvents = true;
                bsReport.ResetBindings(false);

                decimal tong = ketQua.Sum(r => r.GiaTriTon);
                lblTongGiaTri.Text = "Số mặt hàng: " + ketQua.Count + "    |    Tổng giá trị tồn kho: " + tong.ToString("N0") + " VNĐ";
                GhiNhatKy("Hoàn tất: " + ketQua.Count + " dòng, tổng giá trị " + tong.ToString("N0") + " VNĐ");
                MessageBox.Show("Thống kê hoàn tất!\nTổng giá trị tồn kho: " + tong.ToString("N0") + " VNĐ", "Hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                //2. Hủy tác vụ: reset ProgressBar và báo đã hủy
                pgbStatus.Value = 0;
                lblPercent.Text = "0%";
                GhiNhatKy("Đã hủy tác vụ thống kê.");
                if (!this.IsDisposed)
                {
                    MessageBox.Show("Đã hủy tác vụ thống kê kho.", "Đã hủy",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                GhiNhatKy("Lỗi: " + ex.Message);
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnThongKe.Enabled = true;
                btnHuy.Enabled = false;
                cts.Dispose();
                cts = null;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel(); // gửi tín hiệu hủy tới tiến trình ngầm
                btnHuy.Enabled = false;
            }
        }

        // Đóng Form khi đang chạy -> hủy tiến trình ngầm
        private void frmWarehouseAnalytics_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cts != null) cts.Cancel();
        }
    }
}
