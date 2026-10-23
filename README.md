# BÁO CÁO BÀI TẬP THỰC HÀNH LẬP TRÌNH C# WINFORMS

## I. THÔNG TIN SINH VIÊN
* **Họ và tên:** Lê Minh Dũng
* **Mã số sinh viên:** 24810320213
* **Lớp học phần:** Lập trình .NET - Mã Lớp: D19QTANM1
* **Link Repository:** https://github.com/leminhdung050-w2k/LT.NET_TEST02_24810320213_LeMinhDung.git

---

## II. DANH SÁCH BÀI TẬP HOÀN THÀNH & TỰ ĐÁNH GIÁ

| Bài tập | Tiêu đề bài tập | Thư mục | Trạng thái | Mức độ hoàn thành (%) |
| :---: | :--- | :---: | :---: | :---: |
| **Bài 1** | Quản lý Đặt phòng Khách sạn (Data Binding 2 chiều & Validation) | `BT1` | Hoàn thành | 100% |
| **Bài 2** | Quản lý Hồ sơ Nhân sự & Thông tin Lương (System Dialogs & File I/O) | `BT2` | Hoàn thành | 100% |
| **Bài 3** | Hệ thống MDI Quản lý Trường học & Đào tạo (Kiến trúc MDI) | `BT3` | Hoàn thành | 100% |
| **Bài 4** | Bảng điều khiển Tổng hợp Báo cáo Kho hàng (Async/Await & không khóa UI) | `BT4` | Hoàn thành | 100% |
| **Bài 5** | Mô phỏng Giám sát Hệ thống Cảnh báo IoT Real-time (Cross-Thread Safety) | `BT5` | Hoàn thành | 100% |


---

## III. MINH HỌA GIAO DIỆN & KỸ THUẬT NỔI BẬT

> Các ảnh minh họa được chụp khi chạy chương trình bằng **Visual Studio (Debug – F5)**.

### 1. Bài 1: Quản lý Đặt phòng Khách sạn (`frmBookingManager`)
* **Kỹ thuật áp dụng:** Khai báo cột DataGridView hoàn toàn bằng code (`AutoGenerateColumns = false`, `DataPropertyName` khớp `BookingModel`), Data Binding 2 chiều với `BindingList<BookingModel>` + `BindingSource` (`DataBindings.Add`), Validation với `ErrorProvider`, mã đặt phòng tự sinh `BK001, BK002...`.
* **Hình ảnh minh họa Giao diện:**

![Giao diện chính Bài 1](docs/bai1_main.png)
*Mô tả: Chọn một dòng trên `dgvBookings`, thông tin lập tức hiển thị lên các ô nhập liệu; bấm Cập nhật thì dữ liệu được ghi xuống `BindingList<T>` và cập nhật ngay lên Grid.*

![Bắt lỗi Validation Bài 1](docs/bai1_error.png)
*Mô tả: Kiểm tra hợp lệ bằng `ErrorProvider` khi nhấn Thêm đặt phòng: tên khách không được trống, CCCD phải đủ 9 hoặc 12 chữ số, giá phòng phải lớn hơn 0.*

---

### 2. Bài 2: Quản lý Hồ sơ Nhân sự & Lương (`frmEmployeeManager`)
* **Kỹ thuật áp dụng:** `OpenFileDialog` (chọn ảnh chân dung *.jpg, *.png), `SaveFileDialog` / `OpenFileDialog` (Lưu / Mở file CSV phân cách dấu phẩy, UTF-8), parse CSV thành `EmployeeModel` nạp vào `BindingList<T>`, `MenuStrip` + `ToolStrip` (nút thao tác nhanh Mở file, Lưu file, Thêm mới, Tìm kiếm) + `StatusStrip` (tổng số nhân viên, tổng quỹ lương, đồng hồ thời gian thực).
* **Hình ảnh minh họa Giao diện:**

![Giao diện Bài 2 và Load Ảnh](docs/bai2_main.png)
*Mô tả: Chọn ảnh chân dung từ ổ cứng hiển thị lên `picAvatar`, Grid chỉ lưu đường dẫn ảnh.*

![Nạp dữ liệu từ CSV Bài 2](docs/bai2_csv.png)
*Mô tả: Mở file CSV bằng `OpenFileDialog`, nạp lại 5 nhân viên vào danh sách; StatusStrip tự tính lại tổng số nhân viên và tổng quỹ lương sau mỗi lần Thêm / Sửa / Xóa / Import.*

---

### 3. Bài 3: Hệ thống MDI Quản lý Trường học (`frmSchoolMain`)
* **Kỹ thuật áp dụng:** MDI Container (`IsMdiContainer = true`), kiểm tra `MdiChildren` để chống mở trùng Form con (đã mở thì `Activate()`, chưa mở thì tạo mới, gán `MdiParent = this` và `Show()`), sắp xếp `Cascade / TileHorizontal / TileVertical`, Đóng tất cả, `StatusStrip` hiển thị Cán bộ quản lý và `ToolStripProgressBar`.
* **Hình ảnh minh họa Giao diện:**

![Giao diện Khung MDI](docs/bai3_mdi.png)
*Mô tả: Khung Form cha MDI mở các Form con (Sinh viên, Giảng viên, Lớp học) xếp tầng; mở lại một Form đã mở chỉ đưa Form đó lên trước.*

![Sắp xếp Tile Vertical](docs/bai3_tile.png)
*Mô tả: Lệnh Cửa sổ → Dọc (Tile Vertical) sắp xếp chính xác các Form con đang mở.*

---

### 4. Bài 4: Bảng điều khiển Báo cáo Kho hàng (`frmWarehouseAnalytics`)
* **Kỹ thuật áp dụng:** `async/await` + `await Task.Run(...)` xử lý tổng hợp dữ liệu kho (~4,5 giây) dưới Background Thread, `IProgress<int>` cập nhật `pgbStatus` và `lblPercent`, hủy tác vụ bằng `CancellationTokenSource` (reset ProgressBar và báo đã hủy).
* **Hình ảnh minh họa Giao diện:**

![Minh họa Async không treo UI](docs/bai4_async.png)
*Mô tả: Tiến trình ngầm đang chạy (55%), giao diện vẫn kéo rê, phóng to/thu nhỏ, chuyển Tab bình thường; nút Thống Kê bị khóa, nút Hủy Tác Vụ được bật.*

![Kết quả thống kê kho](docs/bai4_main.png)
*Mô tả: Tác vụ hoàn tất (100%), kết quả tồn kho và tổng giá trị hiển thị trên `dgvReportData` kèm thông báo hoàn tất.*

---

### 5. Bài 5: Giám sát Cảnh báo IoT Real-time (`frmIoTMonitor`)
* **Kỹ thuật áp dụng:** `Task.Run` lặp vô hạn 2 giây/lần sinh nhiệt độ ngẫu nhiên 30°C – 42°C, Thread Safety với `this.InvokeRequired` + `this.Invoke(new Action(...))`, dừng bằng `CancellationTokenSource`, `lblTemperature` đổi màu đỏ khi > 37°C và xanh khi bình thường, `StatusStrip` hiển thị trạng thái kết nối và số lần nhận tín hiệu.
* **Hình ảnh minh họa Giao diện:**

![Giám sát IoT real-time](docs/bai5_main.png)
*Mô tả: Nhật ký nhiệt độ cập nhật real-time trên `dgvLogs`, các mốc vượt 37°C được tô đỏ; chạy F5 không phát sinh lỗi `InvalidOperationException: Cross-thread operation not valid`.*
