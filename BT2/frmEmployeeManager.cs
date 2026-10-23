using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BT2
{
    public partial class frmEmployeeManager : Form
    {
        //DỮ LIỆU: BindingList<T> nối với DataGridView qua bsEmployees (BindingSource kéo từ Toolbox)
        private BindingList<EmployeeModel> dsNhanVien = new BindingList<EmployeeModel>();

        // Đường dẫn ảnh đang hiển thị trên form
        private string anhDangChon = "";

        public frmEmployeeManager()
        {
            InitializeComponent();
        }

        private void frmEmployeeManager_Load(object sender, EventArgs e)
        {
            dsNhanVien.Add(new EmployeeModel { EmployeeId = "NV001", FullName = "Nguyễn Văn An", Department = "Kỹ thuật", Position = "Trưởng phòng", Salary = 25000000, AvatarPath = "" });
            dsNhanVien.Add(new EmployeeModel { EmployeeId = "NV002", FullName = "Trần Thị Bình", Department = "Kế toán", Position = "Kế toán viên", Salary = 12000000, AvatarPath = "" });
            dsNhanVien.Add(new EmployeeModel { EmployeeId = "NV003", FullName = "Lê Minh Dũng", Department = "Kỹ thuật", Position = "Lập trình viên", Salary = 18000000, AvatarPath = "" });
            dsNhanVien.Add(new EmployeeModel { EmployeeId = "NV004", FullName = "Phạm Thu Hà", Department = "Nhân sự", Position = "Chuyên viên", Salary = 11000000, AvatarPath = "" });

            dgvEmployees.AutoGenerateColumns = false;
            bsEmployees.DataSource = dsNhanVien;
            dgvEmployees.DataSource = bsEmployees;

            CapNhatStatus();
            lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        //Cập nhật StatusStrip: tự chạy mỗi khi danh sách thay đổi (Thêm / Sửa / Xóa / Import)
        private void bsEmployees_ListChanged(object sender, ListChangedEventArgs e)
        {
            CapNhatStatus();
        }

        private void CapNhatStatus()
        {
            lblTongNV.Text = "Tổng số nhân viên: " + dsNhanVien.Count;
            lblQuyLuong.Text = "Tổng quỹ lương: " + dsNhanVien.Sum(nv => nv.Salary).ToString("N0") + " VNĐ";
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        //Chọn dòng -> hiển thị lên khu vực chi tiết
        private void bsEmployees_CurrentChanged(object sender, EventArgs e)
        {
            HienThiNhanVien(bsEmployees.Current as EmployeeModel);
        }

        private void HienThiNhanVien(EmployeeModel nv)
        {
            errorProvider1.Clear();
            if (nv == null)
            {
                XoaTrangForm();
                return;
            }
            txtEmployeeId.Text = nv.EmployeeId;
            txtFullName.Text = nv.FullName;
            cboDepartment.SelectedItem = nv.Department;
            txtPosition.Text = nv.Position;
            txtSalary.Text = nv.Salary.ToString("N0");
            HienThiAnh(nv.AvatarPath);
        }

        private void XoaTrangForm()
        {
            errorProvider1.Clear();
            txtEmployeeId.Text = TaoMaMoi();
            txtFullName.Clear();
            cboDepartment.SelectedIndex = -1;
            txtPosition.Clear();
            txtSalary.Clear();
            HienThiAnh("");
        }

        private string TaoMaMoi()
        {
            int so = 1;
            while (dsNhanVien.Any(nv => nv.EmployeeId.Equals("NV" + so.ToString("D3"), StringComparison.OrdinalIgnoreCase)))
                so++;
            return "NV" + so.ToString("D3");
        }

        //1. Xử lý ảnh (OpenFileDialog)
        private void HienThiAnh(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                anhDangChon = path;
                picAvatar.ImageLocation = path;
                lblAvatarPath.Text = path;
            }
            else
            {
                anhDangChon = "";
                picAvatar.ImageLocation = null;
                picAvatar.Image = null;
                lblAvatarPath.Text = string.IsNullOrEmpty(path) ? "(chưa có ảnh)" : "(không tìm thấy file: " + path + ")";
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (ofdAvatar.ShowDialog() != DialogResult.OK) return;

            HienThiAnh(ofdAvatar.FileName);

            // Nếu đang xem một nhân viên có sẵn thì lưu luôn đường dẫn ảnh vào đối tượng đó
            EmployeeModel nv = bsEmployees.Current as EmployeeModel;
            if (nv != null && nv.EmployeeId == txtEmployeeId.Text.Trim())
            {
                nv.AvatarPath = anhDangChon;
                bsEmployees.ResetCurrentItem();
            }
        }

        //Kiểm tra dữ liệu nhập
        private bool DocLuong(out decimal luong)
        {
            string s = txtSalary.Text.Trim().Replace(",", "").Replace(".", "").Replace(" ", "");
            return decimal.TryParse(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out luong);
        }

        private bool KiemTraHopLe(EmployeeModel dangSua)
        {
            errorProvider1.Clear();
            bool hopLe = true;
            string ma = txtEmployeeId.Text.Trim();

            if (ma == "")
            {
                errorProvider1.SetError(txtEmployeeId, "Mã nhân viên không được để trống.");
                hopLe = false;
            }
            else if (dsNhanVien.Any(nv => nv != dangSua && nv.EmployeeId.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtEmployeeId, "Mã nhân viên đã tồn tại.");
                hopLe = false;
            }

            if (txtFullName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtFullName, "Họ tên không được để trống.");
                hopLe = false;
            }

            if (cboDepartment.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboDepartment, "Vui lòng chọn phòng ban.");
                hopLe = false;
            }

            decimal luong;
            if (!DocLuong(out luong) || luong < 0)
            {
                errorProvider1.SetError(txtSalary, "Lương phải là số không âm.");
                hopLe = false;
            }
            return hopLe;
        }

        private void GhiVaoNhanVien(EmployeeModel nv)
        {
            decimal luong;
            DocLuong(out luong);
            nv.EmployeeId = txtEmployeeId.Text.Trim();
            nv.FullName = txtFullName.Text.Trim();
            nv.Department = cboDepartment.SelectedItem.ToString();
            nv.Position = txtPosition.Text.Trim();
            nv.Salary = luong;
            nv.AvatarPath = anhDangChon;
        }

        //Thêm, sửa, xóa
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe(null)) return;

            EmployeeModel nv = new EmployeeModel();
            GhiVaoNhanVien(nv);
            dsNhanVien.Add(nv);
            bsEmployees.Position = dsNhanVien.IndexOf(nv);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeModel nv = bsEmployees.Current as EmployeeModel;
            if (nv == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo");
                return;
            }
            if (!KiemTraHopLe(nv)) return;

            GhiVaoNhanVien(nv);
            bsEmployees.ResetCurrentItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeModel nv = bsEmployees.Current as EmployeeModel;
            if (nv == null)
            {
                MessageBox.Show("Không có nhân viên nào để xóa.", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên " + nv.FullName + "?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bsEmployees.RemoveCurrent();
            }
        }

        // Thêm mới (ToolStrip) / Làm mới: xóa trắng để nhập nhân viên mới
        private void btnClear_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
            txtFullName.Focus();
        }

        //Tìm kiếm theo mã hoặc họ tên: chọn dòng khớp tiếp theo
        private void mnuSearch_Click(object sender, EventArgs e)
        {
            if (tstSearch.Text.Trim() == "")
            {
                tstSearch.Focus();
                return;
            }
            TimKiem();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void tstSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiem();
                e.SuppressKeyPress = true;
            }
        }

        private void TimKiem()
        {
            string tuKhoa = tstSearch.Text.Trim().ToLower();
            if (tuKhoa == "" || dsNhanVien.Count == 0) return;

            // Tìm từ dòng sau dòng đang chọn, hết danh sách thì quay lại đầu
            int batDau = bsEmployees.Position;
            for (int i = 1; i <= dsNhanVien.Count; i++)
            {
                int viTri = (batDau + i) % dsNhanVien.Count;
                EmployeeModel nv = dsNhanVien[viTri];
                if (nv.EmployeeId.ToLower().Contains(tuKhoa) || nv.FullName.ToLower().Contains(tuKhoa))
                {
                    bsEmployees.Position = viTri;
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy nhân viên nào khớp với \"" + tstSearch.Text.Trim() + "\".", "Tìm kiếm");
        }

        //2. Đọc / ghi file CSV
        private static string CsvField(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }

        // Tách 1 dòng CSV thành các trường (hỗ trợ trường có dấu phẩy nằm trong ngoặc kép)
        private static List<string> TachDongCsv(string dong)
        {
            List<string> ketQua = new List<string>();
            StringBuilder sb = new StringBuilder();
            bool trongNgoac = false;
            for (int i = 0; i < dong.Length; i++)
            {
                char c = dong[i];
                if (trongNgoac)
                {
                    if (c == '"' && i + 1 < dong.Length && dong[i + 1] == '"') { sb.Append('"'); i++; }
                    else if (c == '"') trongNgoac = false;
                    else sb.Append(c);
                }
                else if (c == '"') trongNgoac = true;
                else if (c == ',') { ketQua.Add(sb.ToString()); sb.Clear(); }
                else sb.Append(c);
            }
            ketQua.Add(sb.ToString());
            return ketQua;
        }

        private void GhiCsv(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(true)))
            {
                sw.WriteLine("EmployeeId,FullName,Department,Position,Salary,AvatarPath");
                foreach (EmployeeModel nv in dsNhanVien)
                {
                    sw.WriteLine(string.Join(",",
                        CsvField(nv.EmployeeId),
                        CsvField(nv.FullName),
                        CsvField(nv.Department),
                        CsvField(nv.Position),
                        nv.Salary.ToString("0", CultureInfo.InvariantCulture),
                        CsvField(nv.AvatarPath)));
                }
            }
        }

        // Trả về số dòng bị bỏ qua do sai định dạng
        private int DocCsv(string path)
        {
            List<EmployeeModel> ds = new List<EmployeeModel>();
            int dongLoi = 0;
            string[] cacDong = File.ReadAllLines(path, Encoding.UTF8);

            for (int i = 0; i < cacDong.Length; i++)
            {
                string dong = cacDong[i].Trim();
                if (dong == "" || (i == 0 && dong.StartsWith("EmployeeId"))) continue; // bỏ dòng trống và dòng tiêu đề

                List<string> f = TachDongCsv(dong);
                decimal luong;
                if (f.Count < 6 || f[0].Trim() == "" || !decimal.TryParse(f[4], NumberStyles.Number, CultureInfo.InvariantCulture, out luong))
                {
                    dongLoi++;
                    continue;
                }
                ds.Add(new EmployeeModel { EmployeeId = f[0].Trim(), FullName = f[1].Trim(), Department = f[2].Trim(), Position = f[3].Trim(), Salary = luong, AvatarPath = f[5].Trim() });
            }

            // Nạp vào BindingList<T>
            dsNhanVien.RaiseListChangedEvents = false;
            dsNhanVien.Clear();
            foreach (EmployeeModel nv in ds) dsNhanVien.Add(nv);
            dsNhanVien.RaiseListChangedEvents = true;
            bsEmployees.ResetBindings(false);
            HienThiNhanVien(bsEmployees.Current as EmployeeModel);
            return dongLoi;
        }

        private void SaveCsv_Click(object sender, EventArgs e)
        {
            if (sfdCsv.ShowDialog() != DialogResult.OK) return;
            try
            {
                GhiCsv(sfdCsv.FileName);
                MessageBox.Show("Đã lưu " + dsNhanVien.Count + " nhân viên ra file:\n" + sfdCsv.FileName, "Lưu file CSV",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenCsv_Click(object sender, EventArgs e)
        {
            if (ofdCsv.ShowDialog() != DialogResult.OK) return;
            try
            {
                int dongLoi = DocCsv(ofdCsv.FileName);
                string thongBao = "Đã nạp " + dsNhanVien.Count + " nhân viên từ file CSV.";
                if (dongLoi > 0) thongBao += "\nBỏ qua " + dongLoi + " dòng sai định dạng.";
                MessageBox.Show(thongBao, "Mở file CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
