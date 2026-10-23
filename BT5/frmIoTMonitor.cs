using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT5
{
    public partial class frmIoTMonitor : Form
    {
        //DỮ LIỆU: nhật ký nhiệt độ, hiển thị qua bsLogs (BindingSource kéo từ Toolbox)
        private BindingList<LogItem> dsNhatKy = new BindingList<LogItem>();

        private CancellationTokenSource cts;
        private int soLanNhan = 0;

        public frmIoTMonitor()
        {
            InitializeComponent();
        }

        private void frmIoTMonitor_Load(object sender, EventArgs e)
        {
            dgvLogs.AutoGenerateColumns = false;
            bsLogs.DataSource = dsNhatKy;
            dgvLogs.DataSource = bsLogs;
        }

        //1. Tiến trình chạy ngầm: Task.Run lặp vô hạn, 2 giây/lần sinh nhiệt độ 30°C - 42°C
        private void btnStart_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblKetNoi.Text = "Trạng thái: Đang kết nối cảm biến...";
            lblKetNoi.ForeColor = Color.DarkGreen;

            Task.Run(async () =>
            {
                Random rnd = new Random();
                try
                {
                    while (!token.IsCancellationRequested)
                    {
                        // Đang ở Background Thread: KHÔNG được gán trực tiếp lên Control
                        double nhietDo = Math.Round(30 + rnd.NextDouble() * 12, 1);
                        CapNhatGiaoDien(nhietDo, token);
                        await Task.Delay(2000, token);
                    }
                }
                catch (OperationCanceledException)
                {
                    // Bấm Dừng -> Task.Delay bị hủy, thoát vòng lặp
                }
            }, token);
        }

        //2. Thread Safety: kiểm tra InvokeRequired, dùng this.Invoke để chuyển về UI Thread
        private void CapNhatGiaoDien(double nhietDo, CancellationToken token)
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            if (this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new Action(() => CapNhatGiaoDien(nhietDo, token)));
                }
                catch (ObjectDisposedException) { }      // Form đã đóng
                catch (InvalidOperationException) { }    // Handle đã bị hủy khi đóng Form
                return;
            }

            // Từ đây trở xuống chắc chắn đang chạy trên UI Thread
            if (token.IsCancellationRequested) return; // đã bấm Dừng

            soLanNhan++;
            lblTemperature.Text = nhietDo.ToString("0.0") + " °C";

            if (nhietDo > 37)
            {
                lblTemperature.ForeColor = Color.Red;
                lblCanhBao.ForeColor = Color.Red;
                lblCanhBao.Text = "⚠ CẢNH BÁO: Nhiệt độ vượt 37°C!";
            }
            else
            {
                lblTemperature.ForeColor = Color.Green;
                lblCanhBao.ForeColor = Color.Green;
                lblCanhBao.Text = "Bình thường";
            }

            dsNhatKy.Insert(0, new LogItem { Lan = soLanNhan, ThoiGian = DateTime.Now, NhietDo = nhietDo });
            lblKetNoi.Text = "Trạng thái: Đã kết nối";
            lblSoLan.Text = "Số lần nhận tín hiệu: " + soLanNhan;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DungGiamSat();
            lblKetNoi.Text = "Trạng thái: Đã ngắt kết nối";
            lblKetNoi.ForeColor = Color.Gray;
        }

        private void DungGiamSat()
        {
            if (cts != null) cts.Cancel();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        // Tô đỏ các mốc nhiệt độ vượt ngưỡng trong nhật ký
        private void dgvLogs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            LogItem log = dgvLogs.Rows[e.RowIndex].DataBoundItem as LogItem;
            if (log != null && log.NhietDo > 37) e.CellStyle.ForeColor = Color.Red;
        }

        private void frmIoTMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DungGiamSat();
        }
    }
}
