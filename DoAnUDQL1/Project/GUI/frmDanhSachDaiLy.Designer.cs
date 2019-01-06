namespace Project
{
    partial class frmDanhSachDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachDaiLy));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDSDL = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDL = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "DANH SÁCH ĐẠI LÝ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.dgvDSDL);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 356);
            this.panel1.TabIndex = 19;
            // 
            // dgvDSDL
            // 
            this.dgvDSDL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDL.Location = new System.Drawing.Point(0, 0);
            this.dgvDSDL.Name = "dgvDSDL";
            this.dgvDSDL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDL.Size = new System.Drawing.Size(777, 356);
            this.dgvDSDL.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Azure;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(670, 460);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 31);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Azure;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(531, 460);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 31);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xoá đại lý";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nhập Mã Đại Lý:";
            // 
            // txtMaDL
            // 
            this.txtMaDL.Location = new System.Drawing.Point(602, 55);
            this.txtMaDL.Name = "txtMaDL";
            this.txtMaDL.Size = new System.Drawing.Size(138, 20);
            this.txtMaDL.TabIndex = 22;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(747, 56);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(47, 23);
            this.btnTim.TabIndex = 23;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.Azure;
            this.btnHienThi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.Location = new System.Drawing.Point(383, 460);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(124, 31);
            this.btnHienThi.TabIndex = 24;
            this.btnHienThi.Text = "Hiển Thị Tất Cả";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // frmDanhSachDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(806, 505);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtMaDL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDanhSachDaiLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đại Lý";
            this.Load += new System.EventHandler(this.frmDanhSachDaiLy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDSDL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDL;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnHienThi;
    }
}