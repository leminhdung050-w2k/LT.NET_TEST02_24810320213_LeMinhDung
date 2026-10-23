namespace BT4
{
    partial class frmWarehouseAnalytics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpTieuChi = new System.Windows.Forms.GroupBox();
            this.lblKho = new System.Windows.Forms.Label();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlTrangThai = new System.Windows.Forms.Panel();
            this.lblTienTrinh = new System.Windows.Forms.Label();
            this.pgbStatus = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKetQua = new System.Windows.Forms.TabPage();
            this.dgvReportData = new System.Windows.Forms.DataGridView();
            this.colMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTriTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongGiaTri = new System.Windows.Forms.Label();
            this.tabNhatKy = new System.Windows.Forms.TabPage();
            this.lstNhatKy = new System.Windows.Forms.ListBox();
            this.bsReport = new System.Windows.Forms.BindingSource(this.components);
            this.grpTieuChi.SuspendLayout();
            this.pnlTrangThai.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            this.tabNhatKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReport)).BeginInit();
            this.SuspendLayout();
            //
            // grpTieuChi
            //
            this.grpTieuChi.Controls.Add(this.lblKho);
            this.grpTieuChi.Controls.Add(this.cboKho);
            this.grpTieuChi.Controls.Add(this.lblTuNgay);
            this.grpTieuChi.Controls.Add(this.dtpTuNgay);
            this.grpTieuChi.Controls.Add(this.lblDenNgay);
            this.grpTieuChi.Controls.Add(this.dtpDenNgay);
            this.grpTieuChi.Controls.Add(this.btnThongKe);
            this.grpTieuChi.Controls.Add(this.btnHuy);
            this.grpTieuChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTieuChi.Location = new System.Drawing.Point(0, 0);
            this.grpTieuChi.Name = "grpTieuChi";
            this.grpTieuChi.Size = new System.Drawing.Size(1032, 110);
            this.grpTieuChi.TabIndex = 0;
            this.grpTieuChi.TabStop = false;
            this.grpTieuChi.Text = "Tiêu chí thống kê";
            //
            // lblKho
            //
            this.lblKho.AutoSize = true;
            this.lblKho.Location = new System.Drawing.Point(15, 33);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(65, 16);
            this.lblKho.TabIndex = 0;
            this.lblKho.Text = "Kho hàng";
            //
            // cboKho
            //
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Items.AddRange(new object[] {
            "Tất cả kho",
            "Kho Hà Nội",
            "Kho Đà Nẵng",
            "Kho TP.HCM"});
            this.cboKho.Location = new System.Drawing.Point(100, 29);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(200, 24);
            this.cboKho.TabIndex = 1;
            //
            // lblTuNgay
            //
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(330, 33);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(56, 16);
            this.lblTuNgay.TabIndex = 2;
            this.lblTuNgay.Text = "Từ ngày";
            //
            // dtpTuNgay
            //
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(400, 30);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(150, 22);
            this.dtpTuNgay.TabIndex = 3;
            //
            // lblDenNgay
            //
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(580, 33);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(64, 16);
            this.lblDenNgay.TabIndex = 4;
            this.lblDenNgay.Text = "Đến ngày";
            //
            // dtpDenNgay
            //
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(655, 30);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(150, 22);
            this.dtpDenNgay.TabIndex = 5;
            //
            // btnThongKe
            //
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.Location = new System.Drawing.Point(100, 64);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(160, 36);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê Kho";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            //
            // btnHuy
            //
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(270, 64);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(160, 36);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy Tác Vụ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            //
            // pnlTrangThai
            //
            this.pnlTrangThai.Controls.Add(this.lblTienTrinh);
            this.pnlTrangThai.Controls.Add(this.pgbStatus);
            this.pnlTrangThai.Controls.Add(this.lblPercent);
            this.pnlTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTrangThai.Location = new System.Drawing.Point(0, 110);
            this.pnlTrangThai.Name = "pnlTrangThai";
            this.pnlTrangThai.Size = new System.Drawing.Size(1032, 50);
            this.pnlTrangThai.TabIndex = 1;
            //
            // lblTienTrinh
            //
            this.lblTienTrinh.AutoSize = true;
            this.lblTienTrinh.Location = new System.Drawing.Point(12, 17);
            this.lblTienTrinh.Name = "lblTienTrinh";
            this.lblTienTrinh.Size = new System.Drawing.Size(68, 16);
            this.lblTienTrinh.TabIndex = 0;
            this.lblTienTrinh.Text = "Tiến trình:";
            //
            // pgbStatus
            //
            this.pgbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbStatus.Location = new System.Drawing.Point(100, 12);
            this.pgbStatus.Name = "pgbStatus";
            this.pgbStatus.Size = new System.Drawing.Size(840, 26);
            this.pgbStatus.TabIndex = 1;
            //
            // lblPercent
            //
            this.lblPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPercent.Location = new System.Drawing.Point(950, 14);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(70, 22);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "0%";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabKetQua);
            this.tabControl1.Controls.Add(this.tabNhatKy);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 433);
            this.tabControl1.TabIndex = 2;
            //
            // tabKetQua
            //
            this.tabKetQua.Controls.Add(this.dgvReportData);
            this.tabKetQua.Controls.Add(this.lblTongGiaTri);
            this.tabKetQua.Location = new System.Drawing.Point(4, 25);
            this.tabKetQua.Name = "tabKetQua";
            this.tabKetQua.Padding = new System.Windows.Forms.Padding(3);
            this.tabKetQua.Size = new System.Drawing.Size(1024, 404);
            this.tabKetQua.TabIndex = 0;
            this.tabKetQua.Text = "Kết quả tồn kho";
            this.tabKetQua.UseVisualStyleBackColor = true;
            //
            // dgvReportData
            //
            this.dgvReportData.AllowUserToAddRows = false;
            this.dgvReportData.AllowUserToDeleteRows = false;
            this.dgvReportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHang,
            this.colTenHang,
            this.colKho,
            this.colSoLuongTon,
            this.colDonGia,
            this.colGiaTriTon});
            this.dgvReportData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportData.Location = new System.Drawing.Point(3, 3);
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.ReadOnly = true;
            this.dgvReportData.RowHeadersWidth = 30;
            this.dgvReportData.RowTemplate.Height = 24;
            this.dgvReportData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportData.Size = new System.Drawing.Size(1018, 370);
            this.dgvReportData.TabIndex = 0;
            //
            // colMaHang
            //
            this.colMaHang.DataPropertyName = "MaHang";
            this.colMaHang.FillWeight = 60F;
            this.colMaHang.HeaderText = "Mã hàng";
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.ReadOnly = true;
            //
            // colTenHang
            //
            this.colTenHang.DataPropertyName = "TenHang";
            this.colTenHang.FillWeight = 150F;
            this.colTenHang.HeaderText = "Tên hàng";
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.ReadOnly = true;
            //
            // colKho
            //
            this.colKho.DataPropertyName = "Kho";
            this.colKho.FillWeight = 90F;
            this.colKho.HeaderText = "Kho";
            this.colKho.Name = "colKho";
            this.colKho.ReadOnly = true;
            //
            // colSoLuongTon
            //
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoLuongTon.DefaultCellStyle.Format = "N0";
            this.colSoLuongTon.FillWeight = 70F;
            this.colSoLuongTon.HeaderText = "Số lượng tồn";
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.ReadOnly = true;
            //
            // colDonGia
            //
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDonGia.DefaultCellStyle.Format = "N0";
            this.colDonGia.FillWeight = 80F;
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            //
            // colGiaTriTon
            //
            this.colGiaTriTon.DataPropertyName = "GiaTriTon";
            this.colGiaTriTon.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colGiaTriTon.DefaultCellStyle.Format = "N0";
            this.colGiaTriTon.FillWeight = 100F;
            this.colGiaTriTon.HeaderText = "Giá trị tồn";
            this.colGiaTriTon.Name = "colGiaTriTon";
            this.colGiaTriTon.ReadOnly = true;
            //
            // lblTongGiaTri
            //
            this.lblTongGiaTri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongGiaTri.Location = new System.Drawing.Point(3, 373);
            this.lblTongGiaTri.Name = "lblTongGiaTri";
            this.lblTongGiaTri.Size = new System.Drawing.Size(1018, 28);
            this.lblTongGiaTri.TabIndex = 1;
            this.lblTongGiaTri.Text = "Chưa có dữ liệu. Bấm [Thống Kê Kho] để bắt đầu.";
            this.lblTongGiaTri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // tabNhatKy
            //
            this.tabNhatKy.Controls.Add(this.lstNhatKy);
            this.tabNhatKy.Location = new System.Drawing.Point(4, 25);
            this.tabNhatKy.Name = "tabNhatKy";
            this.tabNhatKy.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhatKy.Size = new System.Drawing.Size(1024, 404);
            this.tabNhatKy.TabIndex = 1;
            this.tabNhatKy.Text = "Nhật ký tác vụ";
            this.tabNhatKy.UseVisualStyleBackColor = true;
            //
            // lstNhatKy
            //
            this.lstNhatKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNhatKy.FormattingEnabled = true;
            this.lstNhatKy.ItemHeight = 16;
            this.lstNhatKy.Location = new System.Drawing.Point(3, 3);
            this.lstNhatKy.Name = "lstNhatKy";
            this.lstNhatKy.Size = new System.Drawing.Size(1018, 398);
            this.lstNhatKy.TabIndex = 0;
            //
            // frmWarehouseAnalytics
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 593);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlTrangThai);
            this.Controls.Add(this.grpTieuChi);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "frmWarehouseAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điều khiển tổng hợp báo cáo kho hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWarehouseAnalytics_FormClosing);
            this.Load += new System.EventHandler(this.frmWarehouseAnalytics_Load);
            this.grpTieuChi.ResumeLayout(false);
            this.grpTieuChi.PerformLayout();
            this.pnlTrangThai.ResumeLayout(false);
            this.pnlTrangThai.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            this.tabNhatKy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTieuChi;
        private System.Windows.Forms.Label lblKho;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlTrangThai;
        private System.Windows.Forms.Label lblTienTrinh;
        private System.Windows.Forms.ProgressBar pgbStatus;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKetQua;
        private System.Windows.Forms.DataGridView dgvReportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTriTon;
        private System.Windows.Forms.Label lblTongGiaTri;
        private System.Windows.Forms.TabPage tabNhatKy;
        private System.Windows.Forms.ListBox lstNhatKy;
        private System.Windows.Forms.BindingSource bsReport;
    }
}
