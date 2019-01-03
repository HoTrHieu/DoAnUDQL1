namespace Project.GUI
{
    partial class frmThongKeMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeMatHang));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaXuatKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ CÁC MẶT HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.dgvMatHang);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình Trạng Mặt Hàng";
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatHang.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.DaXuatKho,
            this.TonKho});
            this.dgvMatHang.Location = new System.Drawing.Point(6, 19);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.Size = new System.Drawing.Size(587, 266);
            this.dgvMatHang.TabIndex = 0;
            // 
            // MaMH
            // 
            this.MaMH.HeaderText = "Mã Mặt Hàng";
            this.MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            this.TenMH.FillWeight = 200F;
            this.TenMH.HeaderText = "Tên Mặt Hàng";
            this.TenMH.Name = "TenMH";
            // 
            // DaXuatKho
            // 
            this.DaXuatKho.HeaderText = "Số Lượng Đã Xuất Kho";
            this.DaXuatKho.Name = "DaXuatKho";
            // 
            // TonKho
            // 
            this.TonKho.HeaderText = "Số Lượng Tồn Kho";
            this.TonKho.Name = "TonKho";
            // 
            // btnInThongKe
            // 
            this.btnInThongKe.BackColor = System.Drawing.Color.Azure;
            this.btnInThongKe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInThongKe.Location = new System.Drawing.Point(354, 352);
            this.btnInThongKe.Name = "btnInThongKe";
            this.btnInThongKe.Size = new System.Drawing.Size(124, 31);
            this.btnInThongKe.TabIndex = 23;
            this.btnInThongKe.Text = "In thống kê";
            this.btnInThongKe.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Azure;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(489, 352);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 31);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThongKeMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(623, 400);
            this.Controls.Add(this.btnInThongKe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongKeMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Mặt Hàng";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaXuatKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonKho;
        private System.Windows.Forms.Button btnInThongKe;
        private System.Windows.Forms.Button btnThoat;
    }
}