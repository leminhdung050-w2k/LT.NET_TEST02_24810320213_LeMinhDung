namespace BT2
{
    partial class frmEmployeeManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTacVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();
            this.lblAvatarPath = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvatarPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTongNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQuyLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKhoangTrang = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.sfdCsv = new System.Windows.Forms.SaveFileDialog();
            this.ofdCsv = new System.Windows.Forms.OpenFileDialog();
            this.ofdAvatar = new System.Windows.Forms.OpenFileDialog();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTacVu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // mnuFile
            //
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenCsv,
            this.mnuSaveCsv,
            this.mnuSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "&File";
            //
            // mnuOpenCsv
            //
            this.mnuOpenCsv.Name = "mnuOpenCsv";
            this.mnuOpenCsv.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenCsv.Size = new System.Drawing.Size(240, 26);
            this.mnuOpenCsv.Text = "Mở file CSV";
            this.mnuOpenCsv.Click += new System.EventHandler(this.OpenCsv_Click);
            //
            // mnuSaveCsv
            //
            this.mnuSaveCsv.Name = "mnuSaveCsv";
            this.mnuSaveCsv.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSaveCsv.Size = new System.Drawing.Size(240, 26);
            this.mnuSaveCsv.Text = "Lưu file CSV";
            this.mnuSaveCsv.Click += new System.EventHandler(this.SaveCsv_Click);
            //
            // mnuSeparator1
            //
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(237, 6);
            //
            // mnuExit
            //
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(240, 26);
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            //
            // mnuTacVu
            //
            this.mnuTacVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuUpdate,
            this.mnuDelete,
            this.mnuSeparator2,
            this.mnuSearch});
            this.mnuTacVu.Name = "mnuTacVu";
            this.mnuTacVu.Size = new System.Drawing.Size(66, 24);
            this.mnuTacVu.Text = "&Tác vụ";
            //
            // mnuAdd
            //
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuAdd.Size = new System.Drawing.Size(220, 26);
            this.mnuAdd.Text = "Thêm";
            this.mnuAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // mnuUpdate
            //
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(220, 26);
            this.mnuUpdate.Text = "Sửa";
            this.mnuUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // mnuDelete
            //
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuDelete.Size = new System.Drawing.Size(220, 26);
            this.mnuDelete.Text = "Xóa";
            this.mnuDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // mnuSeparator2
            //
            this.mnuSeparator2.Name = "mnuSeparator2";
            this.mnuSeparator2.Size = new System.Drawing.Size(217, 6);
            //
            // mnuSearch
            //
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuSearch.Size = new System.Drawing.Size(220, 26);
            this.mnuSearch.Text = "Tìm kiếm";
            this.mnuSearch.Click += new System.EventHandler(this.mnuSearch_Click);
            //
            // toolStrip1
            //
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.tsbAdd,
            this.tsSeparator1,
            this.tslSearch,
            this.tstSearch,
            this.tsbSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            //
            // tsbOpen
            //
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(87, 28);
            this.tsbOpen.Text = "Mở file";
            this.tsbOpen.ToolTipText = "Mở file CSV (Ctrl+O)";
            this.tsbOpen.Click += new System.EventHandler(this.OpenCsv_Click);
            //
            // tsbSave
            //
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(90, 28);
            this.tsbSave.Text = "Lưu file";
            this.tsbSave.ToolTipText = "Lưu file CSV (Ctrl+S)";
            this.tsbSave.Click += new System.EventHandler(this.SaveCsv_Click);
            //
            // tsbAdd
            //
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(100, 28);
            this.tsbAdd.Text = "Thêm mới";
            this.tsbAdd.ToolTipText = "Làm trống ô nhập để thêm nhân viên mới";
            this.tsbAdd.Click += new System.EventHandler(this.btnClear_Click);
            //
            // tsSeparator1
            //
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 31);
            //
            // tslSearch
            //
            this.tslSearch.Name = "tslSearch";
            this.tslSearch.Size = new System.Drawing.Size(130, 28);
            this.tslSearch.Text = "Tìm (Mã / Họ tên):";
            //
            // tstSearch
            //
            this.tstSearch.Name = "tstSearch";
            this.tstSearch.Size = new System.Drawing.Size(200, 31);
            this.tstSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstSearch_KeyDown);
            //
            // tsbSearch
            //
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(61, 28);
            this.tsbSearch.Text = "Tìm";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            //
            // grpChiTiet
            //
            this.grpChiTiet.Controls.Add(this.lblEmployeeId);
            this.grpChiTiet.Controls.Add(this.txtEmployeeId);
            this.grpChiTiet.Controls.Add(this.lblFullName);
            this.grpChiTiet.Controls.Add(this.txtFullName);
            this.grpChiTiet.Controls.Add(this.lblDepartment);
            this.grpChiTiet.Controls.Add(this.cboDepartment);
            this.grpChiTiet.Controls.Add(this.lblPosition);
            this.grpChiTiet.Controls.Add(this.txtPosition);
            this.grpChiTiet.Controls.Add(this.lblSalary);
            this.grpChiTiet.Controls.Add(this.txtSalary);
            this.grpChiTiet.Controls.Add(this.lblDonVi);
            this.grpChiTiet.Controls.Add(this.lblAnh);
            this.grpChiTiet.Controls.Add(this.lblAvatarPath);
            this.grpChiTiet.Controls.Add(this.picAvatar);
            this.grpChiTiet.Controls.Add(this.btnChonAnh);
            this.grpChiTiet.Controls.Add(this.btnAdd);
            this.grpChiTiet.Controls.Add(this.btnUpdate);
            this.grpChiTiet.Controls.Add(this.btnDelete);
            this.grpChiTiet.Controls.Add(this.btnClear);
            this.grpChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpChiTiet.Location = new System.Drawing.Point(0, 59);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(1032, 220);
            this.grpChiTiet.TabIndex = 2;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Thông tin nhân viên";
            //
            // lblEmployeeId
            //
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(15, 33);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(48, 16);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "Mã NV";
            //
            // txtEmployeeId
            //
            this.txtEmployeeId.Location = new System.Drawing.Point(125, 30);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(220, 22);
            this.txtEmployeeId.TabIndex = 1;
            //
            // lblFullName
            //
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(15, 68);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 16);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Họ và tên";
            //
            // txtFullName
            //
            this.txtFullName.Location = new System.Drawing.Point(125, 65);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(220, 22);
            this.txtFullName.TabIndex = 3;
            //
            // lblDepartment
            //
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(15, 103);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(73, 16);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Phòng ban";
            //
            // cboDepartment
            //
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Items.AddRange(new object[] {
            "Kỹ thuật",
            "Kinh doanh",
            "Nhân sự",
            "Kế toán",
            "Hành chính"});
            this.cboDepartment.Location = new System.Drawing.Point(125, 99);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(220, 24);
            this.cboDepartment.TabIndex = 5;
            //
            // lblPosition
            //
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(15, 138);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 16);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Chức vụ";
            //
            // txtPosition
            //
            this.txtPosition.Location = new System.Drawing.Point(125, 135);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(220, 22);
            this.txtPosition.TabIndex = 7;
            //
            // lblSalary
            //
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(385, 33);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(39, 16);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "Lương";
            //
            // txtSalary
            //
            this.txtSalary.Location = new System.Drawing.Point(470, 30);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 22);
            this.txtSalary.TabIndex = 9;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblDonVi
            //
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(676, 33);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(36, 16);
            this.lblDonVi.TabIndex = 10;
            this.lblDonVi.Text = "VNĐ";
            //
            // lblAnh
            //
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(385, 68);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(31, 16);
            this.lblAnh.TabIndex = 11;
            this.lblAnh.Text = "Ảnh";
            //
            // lblAvatarPath
            //
            this.lblAvatarPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvatarPath.AutoEllipsis = true;
            this.lblAvatarPath.ForeColor = System.Drawing.Color.Gray;
            this.lblAvatarPath.Location = new System.Drawing.Point(467, 68);
            this.lblAvatarPath.Name = "lblAvatarPath";
            this.lblAvatarPath.Size = new System.Drawing.Size(390, 40);
            this.lblAvatarPath.TabIndex = 12;
            this.lblAvatarPath.Text = "(chưa có ảnh)";
            //
            // picAvatar
            //
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(880, 20);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(135, 150);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 13;
            this.picAvatar.TabStop = false;
            //
            // btnChonAnh
            //
            this.btnChonAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonAnh.Location = new System.Drawing.Point(880, 176);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(135, 32);
            this.btnChonAnh.TabIndex = 14;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(15, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 36);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.Location = new System.Drawing.Point(130, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 36);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(245, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 36);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(360, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 36);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // dgvEmployees
            //
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeId,
            this.colFullName,
            this.colDepartment,
            this.colPosition,
            this.colSalary,
            this.colAvatarPath});
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 279);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 30;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1032, 288);
            this.dgvEmployees.TabIndex = 3;
            //
            // colEmployeeId
            //
            this.colEmployeeId.DataPropertyName = "EmployeeId";
            this.colEmployeeId.FillWeight = 60F;
            this.colEmployeeId.HeaderText = "Mã NV";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.ReadOnly = true;
            //
            // colFullName
            //
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.FillWeight = 120F;
            this.colFullName.HeaderText = "Họ và tên";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            //
            // colDepartment
            //
            this.colDepartment.DataPropertyName = "Department";
            this.colDepartment.FillWeight = 80F;
            this.colDepartment.HeaderText = "Phòng ban";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            //
            // colPosition
            //
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.FillWeight = 80F;
            this.colPosition.HeaderText = "Chức vụ";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            //
            // colSalary
            //
            this.colSalary.DataPropertyName = "Salary";
            this.colSalary.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSalary.DefaultCellStyle.Format = "N0";
            this.colSalary.FillWeight = 80F;
            this.colSalary.HeaderText = "Lương";
            this.colSalary.Name = "colSalary";
            this.colSalary.ReadOnly = true;
            //
            // colAvatarPath
            //
            this.colAvatarPath.DataPropertyName = "AvatarPath";
            this.colAvatarPath.FillWeight = 160F;
            this.colAvatarPath.HeaderText = "Ảnh (đường dẫn)";
            this.colAvatarPath.Name = "colAvatarPath";
            this.colAvatarPath.ReadOnly = true;
            //
            // statusStrip1
            //
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTongNV,
            this.lblQuyLuong,
            this.lblKhoangTrang,
            this.lblThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1032, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            //
            // lblTongNV
            //
            this.lblTongNV.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTongNV.Name = "lblTongNV";
            this.lblTongNV.Size = new System.Drawing.Size(130, 20);
            this.lblTongNV.Text = "Tổng số nhân viên: 0";
            //
            // lblQuyLuong
            //
            this.lblQuyLuong.Name = "lblQuyLuong";
            this.lblQuyLuong.Size = new System.Drawing.Size(150, 20);
            this.lblQuyLuong.Text = "Tổng quỹ lương: 0 VNĐ";
            //
            // lblKhoangTrang
            //
            this.lblKhoangTrang.Name = "lblKhoangTrang";
            this.lblKhoangTrang.Size = new System.Drawing.Size(560, 20);
            this.lblKhoangTrang.Spring = true;
            //
            // lblThoiGian
            //
            this.lblThoiGian.AutoSize = false;
            this.lblThoiGian.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(170, 20);
            this.lblThoiGian.Text = "00/00/0000 00:00:00";
            //
            // errorProvider1
            //
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            //
            // bsEmployees
            //
            this.bsEmployees.CurrentChanged += new System.EventHandler(this.bsEmployees_CurrentChanged);
            this.bsEmployees.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsEmployees_ListChanged);
            //
            // sfdCsv
            //
            this.sfdCsv.DefaultExt = "csv";
            this.sfdCsv.FileName = "DanhSachNhanVien.csv";
            this.sfdCsv.Filter = "CSV File (*.csv)|*.csv";
            this.sfdCsv.Title = "Lưu danh sách nhân viên ra CSV";
            //
            // ofdCsv
            //
            this.ofdCsv.Filter = "CSV File (*.csv)|*.csv";
            this.ofdCsv.Title = "Mở file CSV danh sách nhân viên";
            //
            // ofdAvatar
            //
            this.ofdAvatar.Filter = "Ảnh (*.jpg;*.png)|*.jpg;*.png";
            this.ofdAvatar.Title = "Chọn ảnh chân dung nhân viên";
            //
            // tmrClock
            //
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            //
            // frmEmployeeManager
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 593);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.grpChiTiet);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "frmEmployeeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hồ sơ nhân sự & thông tin lương";
            this.Load += new System.EventHandler(this.frmEmployeeManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenCsv;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveCsv;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTacVu;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Label lblAvatarPath;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvatarPath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTongNV;
        private System.Windows.Forms.ToolStripStatusLabel lblQuyLuong;
        private System.Windows.Forms.ToolStripStatusLabel lblKhoangTrang;
        private System.Windows.Forms.ToolStripStatusLabel lblThoiGian;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bsEmployees;
        private System.Windows.Forms.SaveFileDialog sfdCsv;
        private System.Windows.Forms.OpenFileDialog ofdCsv;
        private System.Windows.Forms.OpenFileDialog ofdAvatar;
        private System.Windows.Forms.Timer tmrClock;
    }
}
