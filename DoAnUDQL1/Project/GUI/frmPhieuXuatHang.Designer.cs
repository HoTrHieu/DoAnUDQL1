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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPK = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDaiLy = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenDL = new System.Windows.Forms.Label();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU XUẤT HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 179);
            this.dataGridView1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày lập phiếu";
            // 
            // dtPK
            // 
            this.dtPK.Location = new System.Drawing.Point(349, 14);
            this.dtPK.Name = "dtPK";
            this.dtPK.Size = new System.Drawing.Size(202, 20);
            this.dtPK.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Đại Lý :";
            // 
            // cmbDaiLy
            // 
            this.cmbDaiLy.FormattingEnabled = true;
            this.cmbDaiLy.Location = new System.Drawing.Point(75, 18);
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
            this.btnThoat.Location = new System.Drawing.Point(475, 317);
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
            this.panel1.Controls.Add(this.lblTenDL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbDaiLy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtPK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 257);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Đại Lý :";
            // 
            // lblTenDL
            // 
            this.lblTenDL.AutoSize = true;
            this.lblTenDL.Location = new System.Drawing.Point(75, 45);
            this.lblTenDL.Name = "lblTenDL";
            this.lblTenDL.Size = new System.Drawing.Size(65, 13);
            this.lblTenDL.TabIndex = 14;
            this.lblTenDL.Text = "Tên Đại Lý :";
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.BackColor = System.Drawing.Color.Azure;
            this.btnInPhieu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieu.Location = new System.Drawing.Point(347, 317);
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
            this.btnLuuPhieu.Location = new System.Drawing.Point(222, 317);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(94, 31);
            this.btnLuuPhieu.TabIndex = 17;
            this.btnLuuPhieu.Text = "Lưu Phiếu";
            this.btnLuuPhieu.UseVisualStyleBackColor = false;
            // 
            // frmPhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(583, 365);
            this.Controls.Add(this.btnLuuPhieu);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhieuXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Xuất Hàng";
            this.Load += new System.EventHandler(this.frmPhieuXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}