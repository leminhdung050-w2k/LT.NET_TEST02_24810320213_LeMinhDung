namespace BT3
{
    partial class frmLecturerList
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
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.bsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGiangVien)).BeginInit();
            this.SuspendLayout();
            //
            // dgvGiangVien
            //
            this.dgvGiangVien.AllowUserToAddRows = false;
            this.dgvGiangVien.AllowUserToDeleteRows = false;
            this.dgvGiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGV,
            this.colHoTen,
            this.colKhoa,
            this.colHocVi});
            this.dgvGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiangVien.Location = new System.Drawing.Point(0, 0);
            this.dgvGiangVien.MultiSelect = false;
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.ReadOnly = true;
            this.dgvGiangVien.RowHeadersWidth = 30;
            this.dgvGiangVien.RowTemplate.Height = 24;
            this.dgvGiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiangVien.Size = new System.Drawing.Size(642, 307);
            this.dgvGiangVien.TabIndex = 0;
            //
            // colMaGV
            //
            this.colMaGV.DataPropertyName = "LecturerId";
            this.colMaGV.FillWeight = 60F;
            this.colMaGV.HeaderText = "Mã GV";
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.ReadOnly = true;
            //
            // colHoTen
            //
            this.colHoTen.DataPropertyName = "FullName";
            this.colHoTen.FillWeight = 140F;
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            //
            // colKhoa
            //
            this.colKhoa.DataPropertyName = "Faculty";
            this.colKhoa.FillWeight = 110F;
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.ReadOnly = true;
            //
            // colHocVi
            //
            this.colHocVi.DataPropertyName = "Degree";
            this.colHocVi.FillWeight = 70F;
            this.colHocVi.HeaderText = "Học vị";
            this.colHocVi.Name = "colHocVi";
            this.colHocVi.ReadOnly = true;
            //
            // lblTongSo
            //
            this.lblTongSo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongSo.Location = new System.Drawing.Point(0, 307);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblTongSo.Size = new System.Drawing.Size(642, 26);
            this.lblTongSo.TabIndex = 1;
            this.lblTongSo.Text = "Tổng số giảng viên: 0";
            this.lblTongSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // frmLecturerList
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 333);
            this.Controls.Add(this.dgvGiangVien);
            this.Controls.Add(this.lblTongSo);
            this.Name = "frmLecturerList";
            this.Text = "Danh sách Giảng viên";
            this.Load += new System.EventHandler(this.frmLecturerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGiangVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocVi;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.BindingSource bsGiangVien;
    }
}
