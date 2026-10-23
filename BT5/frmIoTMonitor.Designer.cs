namespace BT5
{
    partial class frmIoTMonitor
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
            this.grpDieuKhien = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblChuKy = new System.Windows.Forms.Label();
            this.grpHienThi = new System.Windows.Forms.GroupBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblCanhBao = new System.Windows.Forms.Label();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.colLan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhietDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblKetNoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSoLan = new System.Windows.Forms.ToolStripStatusLabel();
            this.bsLogs = new System.Windows.Forms.BindingSource(this.components);
            this.grpDieuKhien.SuspendLayout();
            this.grpHienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogs)).BeginInit();
            this.SuspendLayout();
            //
            // grpDieuKhien
            //
            this.grpDieuKhien.Controls.Add(this.btnStart);
            this.grpDieuKhien.Controls.Add(this.btnStop);
            this.grpDieuKhien.Controls.Add(this.lblChuKy);
            this.grpDieuKhien.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDieuKhien.Location = new System.Drawing.Point(0, 0);
            this.grpDieuKhien.Name = "grpDieuKhien";
            this.grpDieuKhien.Size = new System.Drawing.Size(832, 75);
            this.grpDieuKhien.TabIndex = 0;
            this.grpDieuKhien.TabStop = false;
            this.grpDieuKhien.Text = "Điều khiển";
            //
            // btnStart
            //
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(15, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu Giám sát";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            //
            // btnStop
            //
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(195, 25);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(170, 38);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Dừng Giám sát";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            //
            // lblChuKy
            //
            this.lblChuKy.AutoSize = true;
            this.lblChuKy.ForeColor = System.Drawing.Color.Gray;
            this.lblChuKy.Location = new System.Drawing.Point(385, 36);
            this.lblChuKy.Name = "lblChuKy";
            this.lblChuKy.Size = new System.Drawing.Size(330, 16);
            this.lblChuKy.TabIndex = 2;
            this.lblChuKy.Text = "Chu kỳ: 2 giây/lần  •  Ngưỡng cảnh báo: > 37°C";
            //
            // grpHienThi
            //
            this.grpHienThi.Controls.Add(this.lblTemperature);
            this.grpHienThi.Controls.Add(this.lblCanhBao);
            this.grpHienThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHienThi.Location = new System.Drawing.Point(0, 75);
            this.grpHienThi.Name = "grpHienThi";
            this.grpHienThi.Size = new System.Drawing.Size(832, 130);
            this.grpHienThi.TabIndex = 1;
            this.grpHienThi.TabStop = false;
            this.grpHienThi.Text = "Nhiệt độ cảm biến (real-time)";
            //
            // lblTemperature
            //
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTemperature.ForeColor = System.Drawing.Color.Gray;
            this.lblTemperature.Location = new System.Drawing.Point(15, 25);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(300, 95);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "-- °C";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblCanhBao
            //
            this.lblCanhBao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCanhBao.ForeColor = System.Drawing.Color.Gray;
            this.lblCanhBao.Location = new System.Drawing.Point(330, 50);
            this.lblCanhBao.Name = "lblCanhBao";
            this.lblCanhBao.Size = new System.Drawing.Size(480, 45);
            this.lblCanhBao.TabIndex = 1;
            this.lblCanhBao.Text = "Chưa nhận tín hiệu";
            this.lblCanhBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // dgvLogs
            //
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLan,
            this.colThoiGian,
            this.colNhietDo,
            this.colTrangThai});
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(0, 205);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersWidth = 30;
            this.dgvLogs.RowTemplate.Height = 24;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(832, 302);
            this.dgvLogs.TabIndex = 2;
            this.dgvLogs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLogs_CellFormatting);
            //
            // colLan
            //
            this.colLan.DataPropertyName = "Lan";
            this.colLan.FillWeight = 40F;
            this.colLan.HeaderText = "Lần";
            this.colLan.Name = "colLan";
            this.colLan.ReadOnly = true;
            //
            // colThoiGian
            //
            this.colThoiGian.DataPropertyName = "ThoiGian";
            this.colThoiGian.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            this.colThoiGian.FillWeight = 110F;
            this.colThoiGian.HeaderText = "Thời gian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.ReadOnly = true;
            //
            // colNhietDo
            //
            this.colNhietDo.DataPropertyName = "NhietDo";
            this.colNhietDo.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colNhietDo.DefaultCellStyle.Format = "0.0 °C";
            this.colNhietDo.FillWeight = 70F;
            this.colNhietDo.HeaderText = "Nhiệt độ";
            this.colNhietDo.Name = "colNhietDo";
            this.colNhietDo.ReadOnly = true;
            //
            // colTrangThai
            //
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.FillWeight = 110F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            //
            // statusStrip1
            //
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblKetNoi,
            this.lblSoLan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(832, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            //
            // lblKetNoi
            //
            this.lblKetNoi.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblKetNoi.ForeColor = System.Drawing.Color.Gray;
            this.lblKetNoi.Name = "lblKetNoi";
            this.lblKetNoi.Size = new System.Drawing.Size(200, 20);
            this.lblKetNoi.Text = "Trạng thái: Chưa kết nối";
            //
            // lblSoLan
            //
            this.lblSoLan.Name = "lblSoLan";
            this.lblSoLan.Size = new System.Drawing.Size(180, 20);
            this.lblSoLan.Text = "Số lần nhận tín hiệu: 0";
            //
            // frmIoTMonitor
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 533);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.grpHienThi);
            this.Controls.Add(this.grpDieuKhien);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmIoTMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giám sát hệ thống cảnh báo IoT real-time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIoTMonitor_FormClosing);
            this.Load += new System.EventHandler(this.frmIoTMonitor_Load);
            this.grpDieuKhien.ResumeLayout(false);
            this.grpDieuKhien.PerformLayout();
            this.grpHienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDieuKhien;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblChuKy;
        private System.Windows.Forms.GroupBox grpHienThi;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblCanhBao;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhietDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblKetNoi;
        private System.Windows.Forms.ToolStripStatusLabel lblSoLan;
        private System.Windows.Forms.BindingSource bsLogs;
    }
}
