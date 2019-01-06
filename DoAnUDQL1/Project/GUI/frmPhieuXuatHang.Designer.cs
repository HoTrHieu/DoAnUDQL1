namespace Project.GUI
{
    partial class frmPhieuXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuXuatHang));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuXuatHang = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPK = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDaiLy = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenDL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaMatHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTenMatHang = new System.Windows.Forms.Label();
            this.cmbDonViTinh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuatHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU XUẤT HÀNG";
            // 
            // dgvPhieuXuatHang
            // 
            this.dgvPhieuXuatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuXuatHang.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvPhieuXuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.tenMatHang,
            this.donViTinh,
            this.soLuong,
            this.donGia,
            this.thanhTien});
            this.dgvPhieuXuatHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhieuXuatHang.Location = new System.Drawing.Point(0, 163);
            this.dgvPhieuXuatHang.Name = "dgvPhieuXuatHang";
            this.dgvPhieuXuatHang.Size = new System.Drawing.Size(770, 193);
            this.dgvPhieuXuatHang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày lập phiếu";
            // 
            // dtPK
            // 
            this.dtPK.Location = new System.Drawing.Point(215, 416);
            this.dtPK.Name = "dtPK";
            this.dtPK.Size = new System.Drawing.Size(202, 20);
            this.dtPK.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Đại Lý :";
            // 
            // cmbDaiLy
            // 
            this.cmbDaiLy.FormattingEnabled = true;
            this.cmbDaiLy.Location = new System.Drawing.Point(179, 21);
            this.cmbDaiLy.Name = "cmbDaiLy";
            this.cmbDaiLy.Size = new System.Drawing.Size(164, 21);
            this.cmbDaiLy.TabIndex = 12;
            this.cmbDaiLy.SelectedIndexChanged += new System.EventHandler(this.cmbDaiLy_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Azure;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(688, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 31);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbDonViTinh);
            this.panel1.Controls.Add(this.cmbMaMatHang);
            this.panel1.Controls.Add(this.lblTenMatHang);
            this.panel1.Controls.Add(this.lblTenDL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbDaiLy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvPhieuXuatHang);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 356);
            this.panel1.TabIndex = 15;
            // 
            // lblTenDL
            // 
            this.lblTenDL.AutoSize = true;
            this.lblTenDL.Location = new System.Drawing.Point(512, 25);
            this.lblTenDL.Name = "lblTenDL";
            this.lblTenDL.Size = new System.Drawing.Size(65, 13);
            this.lblTenDL.TabIndex = 14;
            this.lblTenDL.Text = "Tên Đại Lý :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Đại Lý :";
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.BackColor = System.Drawing.Color.Azure;
            this.btnInPhieu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieu.Location = new System.Drawing.Point(560, 409);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(94, 31);
            this.btnInPhieu.TabIndex = 16;
            this.btnInPhieu.Text = "In Phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.BackColor = System.Drawing.Color.Azure;
            this.btnLuuPhieu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLuuPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieu.Location = new System.Drawing.Point(435, 409);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(94, 31);
            this.btnLuuPhieu.TabIndex = 17;
            this.btnLuuPhieu.Text = "Lưu Phiếu";
            this.btnLuuPhieu.UseVisualStyleBackColor = false;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // tenMatHang
            // 
            this.tenMatHang.HeaderText = "Tên Mặt Hàng";
            this.tenMatHang.Name = "tenMatHang";
            this.tenMatHang.ReadOnly = true;
            // 
            // donViTinh
            // 
            this.donViTinh.HeaderText = "Đơn Vị Tính";
            this.donViTinh.Name = "donViTinh";
            this.donViTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.donViTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.Name = "soLuong";
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn Giá";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành Tiền";
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mã Mặt Hàng :";
            // 
            // cmbMaMatHang
            // 
            this.cmbMaMatHang.FormattingEnabled = true;
            this.cmbMaMatHang.Location = new System.Drawing.Point(179, 48);
            this.cmbMaMatHang.Name = "cmbMaMatHang";
            this.cmbMaMatHang.Size = new System.Drawing.Size(164, 21);
            this.cmbMaMatHang.TabIndex = 15;
            this.cmbMaMatHang.SelectedIndexChanged += new System.EventHandler(this.cmbMaMatHang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên Mặt Hàng";
            // 
            // lblTenMatHang
            // 
            this.lblTenMatHang.AutoSize = true;
            this.lblTenMatHang.Location = new System.Drawing.Point(512, 52);
            this.lblTenMatHang.Name = "lblTenMatHang";
            this.lblTenMatHang.Size = new System.Drawing.Size(63, 13);
            this.lblTenMatHang.TabIndex = 14;
            this.lblTenMatHang.Text = "tenmathang";
            // 
            // cmbDonViTinh
            // 
            this.cmbDonViTinh.FormattingEnabled = true;
            this.cmbDonViTinh.Location = new System.Drawing.Point(179, 75);
            this.cmbDonViTinh.Name = "cmbDonViTinh";
            this.cmbDonViTinh.Size = new System.Drawing.Size(164, 21);
            this.cmbDonViTinh.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Đơn Vị Tính :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(179, 103);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(164, 20);
            this.txtSoLuong.TabIndex = 17;
            // 
            // frmPhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(794, 456);
            this.Controls.Add(this.btnLuuPhieu);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPK);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhieuXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Xuất Hàng";
            this.Load += new System.EventHandler(this.frmPhieuXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuatHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhieuXuatHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDaiLy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenDL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDonViTinh;
        private System.Windows.Forms.ComboBox cmbMaMatHang;
        private System.Windows.Forms.Label lblTenMatHang;
        private System.Windows.Forms.Label label6;
    }
}