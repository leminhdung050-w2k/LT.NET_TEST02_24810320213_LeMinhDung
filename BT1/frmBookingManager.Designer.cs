namespace BT1
{
    partial class frmBookingManager
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
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblDays = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.lblPricePerNight = new System.Windows.Forms.Label();
            this.txtPricePerNight = new System.Windows.Forms.TextBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bsBookings = new System.Windows.Forms.BindingSource(this.components);
            this.grpNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBookings)).BeginInit();
            this.SuspendLayout();
            //
            // grpNhapLieu
            //
            this.grpNhapLieu.Controls.Add(this.lblBookingId);
            this.grpNhapLieu.Controls.Add(this.txtBookingId);
            this.grpNhapLieu.Controls.Add(this.lblCustomerName);
            this.grpNhapLieu.Controls.Add(this.txtCustomerName);
            this.grpNhapLieu.Controls.Add(this.lblIdentityCard);
            this.grpNhapLieu.Controls.Add(this.txtIdentityCard);
            this.grpNhapLieu.Controls.Add(this.lblRoomType);
            this.grpNhapLieu.Controls.Add(this.cboRoomType);
            this.grpNhapLieu.Controls.Add(this.lblCheckIn);
            this.grpNhapLieu.Controls.Add(this.dtpCheckIn);
            this.grpNhapLieu.Controls.Add(this.lblDays);
            this.grpNhapLieu.Controls.Add(this.numDays);
            this.grpNhapLieu.Controls.Add(this.lblPricePerNight);
            this.grpNhapLieu.Controls.Add(this.txtPricePerNight);
            this.grpNhapLieu.Controls.Add(this.lblDonVi);
            this.grpNhapLieu.Controls.Add(this.btnAdd);
            this.grpNhapLieu.Controls.Add(this.btnUpdate);
            this.grpNhapLieu.Controls.Add(this.btnDelete);
            this.grpNhapLieu.Controls.Add(this.btnRefresh);
            this.grpNhapLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpNhapLieu.Location = new System.Drawing.Point(0, 0);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new System.Drawing.Size(1032, 210);
            this.grpNhapLieu.TabIndex = 0;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Thông tin đặt phòng";
            //
            // lblBookingId
            //
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Location = new System.Drawing.Point(15, 33);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(95, 16);
            this.lblBookingId.TabIndex = 0;
            this.lblBookingId.Text = "Mã đặt phòng";
            //
            // txtBookingId
            //
            this.txtBookingId.BackColor = System.Drawing.SystemColors.Info;
            this.txtBookingId.Location = new System.Drawing.Point(140, 30);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.Size = new System.Drawing.Size(220, 22);
            this.txtBookingId.TabIndex = 1;
            this.txtBookingId.TabStop = false;
            //
            // lblCustomerName
            //
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(15, 68);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(101, 16);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Tên khách hàng";
            //
            // txtCustomerName
            //
            this.txtCustomerName.Location = new System.Drawing.Point(140, 65);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(220, 22);
            this.txtCustomerName.TabIndex = 3;
            //
            // lblIdentityCard
            //
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Location = new System.Drawing.Point(15, 103);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(107, 16);
            this.lblIdentityCard.TabIndex = 4;
            this.lblIdentityCard.Text = "Số CCCD/CMND";
            //
            // txtIdentityCard
            //
            this.txtIdentityCard.Location = new System.Drawing.Point(140, 100);
            this.txtIdentityCard.MaxLength = 12;
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(220, 22);
            this.txtIdentityCard.TabIndex = 5;
            //
            // lblRoomType
            //
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(15, 138);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(72, 16);
            this.lblRoomType.TabIndex = 6;
            this.lblRoomType.Text = "Loại phòng";
            //
            // cboRoomType
            //
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "VIP"});
            this.cboRoomType.Location = new System.Drawing.Point(140, 134);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(220, 24);
            this.cboRoomType.TabIndex = 7;
            //
            // lblCheckIn
            //
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(400, 33);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(113, 16);
            this.lblCheckIn.TabIndex = 8;
            this.lblCheckIn.Text = "Ngày nhận phòng";
            //
            // dtpCheckIn
            //
            this.dtpCheckIn.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(530, 30);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(220, 22);
            this.dtpCheckIn.TabIndex = 9;
            //
            // lblDays
            //
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(400, 68);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(63, 16);
            this.lblDays.TabIndex = 10;
            this.lblDays.Text = "Số ngày ở";
            //
            // numDays
            //
            this.numDays.Location = new System.Drawing.Point(530, 65);
            this.numDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(220, 22);
            this.numDays.TabIndex = 11;
            this.numDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // lblPricePerNight
            //
            this.lblPricePerNight.AutoSize = true;
            this.lblPricePerNight.Location = new System.Drawing.Point(400, 103);
            this.lblPricePerNight.Name = "lblPricePerNight";
            this.lblPricePerNight.Size = new System.Drawing.Size(103, 16);
            this.lblPricePerNight.TabIndex = 12;
            this.lblPricePerNight.Text = "Giá phòng/đêm";
            //
            // txtPricePerNight
            //
            this.txtPricePerNight.Location = new System.Drawing.Point(530, 100);
            this.txtPricePerNight.Name = "txtPricePerNight";
            this.txtPricePerNight.Size = new System.Drawing.Size(220, 22);
            this.txtPricePerNight.TabIndex = 13;
            this.txtPricePerNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblDonVi
            //
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(770, 103);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(36, 16);
            this.lblDonVi.TabIndex = 14;
            this.lblDonVi.Text = "VNĐ";
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(15, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 38);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm đặt phòng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.Location = new System.Drawing.Point(175, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 38);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(295, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 38);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(415, 158);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 38);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // dgvBookings
            //
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookings.Location = new System.Drawing.Point(0, 210);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 30;
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(1032, 383);
            this.dgvBookings.TabIndex = 1;
            //
            // errorProvider1
            //
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            //
            // frmBookingManager
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 593);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.grpNhapLieu);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "frmBookingManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đặt phòng khách sạn";
            this.Load += new System.EventHandler(this.frmBookingManager_Load);
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblIdentityCard;
        private System.Windows.Forms.TextBox txtIdentityCard;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.Label lblPricePerNight;
        private System.Windows.Forms.TextBox txtPricePerNight;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bsBookings;
    }
}
