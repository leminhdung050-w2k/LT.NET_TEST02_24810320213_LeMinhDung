namespace BT3
{
    partial class frmCourseList
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.numSoTinChi = new System.Windows.Forms.NumericUpDown();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.txtGiangVien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc)).BeginInit();
            this.SuspendLayout();
            //
            // grpThongTin
            //
            this.grpThongTin.Controls.Add(this.lblMaMon);
            this.grpThongTin.Controls.Add(this.txtMaMon);
            this.grpThongTin.Controls.Add(this.lblTenMon);
            this.grpThongTin.Controls.Add(this.txtTenMon);
            this.grpThongTin.Controls.Add(this.lblSoTinChi);
            this.grpThongTin.Controls.Add(this.numSoTinChi);
            this.grpThongTin.Controls.Add(this.lblGiangVien);
            this.grpThongTin.Controls.Add(this.txtGiangVien);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Location = new System.Drawing.Point(0, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(742, 140);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin môn học";
            //
            // lblMaMon
            //
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Location = new System.Drawing.Point(15, 33);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(55, 16);
            this.lblMaMon.TabIndex = 0;
            this.lblMaMon.Text = "Mã môn";
            //
            // txtMaMon
            //
            this.txtMaMon.Location = new System.Drawing.Point(110, 30);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(200, 22);
            this.txtMaMon.TabIndex = 1;
            //
            // lblTenMon
            //
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(15, 68);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(58, 16);
            this.lblTenMon.TabIndex = 2;
            this.lblTenMon.Text = "Tên môn";
            //
            // txtTenMon
            //
            this.txtTenMon.Location = new System.Drawing.Point(110, 65);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(200, 22);
            this.txtTenMon.TabIndex = 3;
            //
            // lblSoTinChi
            //
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Location = new System.Drawing.Point(350, 33);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(65, 16);
            this.lblSoTinChi.TabIndex = 4;
            this.lblSoTinChi.Text = "Số tín chỉ";
            //
            // numSoTinChi
            //
            this.numSoTinChi.Location = new System.Drawing.Point(450, 30);
            this.numSoTinChi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSoTinChi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoTinChi.Name = "numSoTinChi";
            this.numSoTinChi.Size = new System.Drawing.Size(200, 22);
            this.numSoTinChi.TabIndex = 5;
            this.numSoTinChi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            //
            // lblGiangVien
            //
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Location = new System.Drawing.Point(350, 68);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(70, 16);
            this.lblGiangVien.TabIndex = 6;
            this.lblGiangVien.Text = "Giảng viên";
            //
            // txtGiangVien
            //
            this.txtGiangVien.Location = new System.Drawing.Point(450, 65);
            this.txtGiangVien.Name = "txtGiangVien";
            this.txtGiangVien.Size = new System.Drawing.Size(200, 22);
            this.txtGiangVien.TabIndex = 7;
            //
            // btnThem
            //
            this.btnThem.Location = new System.Drawing.Point(110, 98);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            //
            // btnSua
            //
            this.btnSua.Location = new System.Drawing.Point(220, 98);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            //
            // btnXoa
            //
            this.btnXoa.Location = new System.Drawing.Point(330, 98);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            //
            // dgvMonHoc
            //
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colTenMon,
            this.colSoTinChi,
            this.colGiangVien});
            this.dgvMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonHoc.Location = new System.Drawing.Point(0, 140);
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowHeadersWidth = 30;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(742, 253);
            this.dgvMonHoc.TabIndex = 1;
            //
            // colMaMon
            //
            this.colMaMon.DataPropertyName = "CourseId";
            this.colMaMon.FillWeight = 60F;
            this.colMaMon.HeaderText = "Mã môn";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.ReadOnly = true;
            //
            // colTenMon
            //
            this.colTenMon.DataPropertyName = "CourseName";
            this.colTenMon.FillWeight = 150F;
            this.colTenMon.HeaderText = "Tên môn học";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            //
            // colSoTinChi
            //
            this.colSoTinChi.DataPropertyName = "Credits";
            this.colSoTinChi.FillWeight = 50F;
            this.colSoTinChi.HeaderText = "Số TC";
            this.colSoTinChi.Name = "colSoTinChi";
            this.colSoTinChi.ReadOnly = true;
            //
            // colGiangVien
            //
            this.colGiangVien.DataPropertyName = "Lecturer";
            this.colGiangVien.FillWeight = 110F;
            this.colGiangVien.HeaderText = "Giảng viên phụ trách";
            this.colGiangVien.Name = "colGiangVien";
            this.colGiangVien.ReadOnly = true;
            //
            // errorProvider1
            //
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            //
            // bsMonHoc
            //
            this.bsMonHoc.CurrentChanged += new System.EventHandler(this.bsMonHoc_CurrentChanged);
            //
            // frmCourseList
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 393);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.grpThongTin);
            this.Name = "frmCourseList";
            this.Text = "Danh mục Lớp học (Môn học)";
            this.Load += new System.EventHandler(this.frmCourseList_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.NumericUpDown numSoTinChi;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.TextBox txtGiangVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiangVien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bsMonHoc;
    }
}
