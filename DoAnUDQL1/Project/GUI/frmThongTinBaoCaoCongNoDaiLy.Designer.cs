namespace Project.GUI
{
    partial class frmThongTinBaoCaoCongNoDaiLy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinBaoCaoCongNoDaiLy));
            this.dgvCongNo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInCongNo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaBaoCao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCongNo
            // 
            this.dgvCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongNo.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCongNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCongNo.Location = new System.Drawing.Point(6, 19);
            this.dgvCongNo.Name = "dgvCongNo";
            this.dgvCongNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongNo.Size = new System.Drawing.Size(565, 221);
            this.dgvCongNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "BÁO CÁO CÔNG NỢ";
            // 
            // btnInCongNo
            // 
            this.btnInCongNo.BackColor = System.Drawing.Color.Azure;
            this.btnInCongNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInCongNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInCongNo.Location = new System.Drawing.Point(330, 337);
            this.btnInCongNo.Name = "btnInCongNo";
            this.btnInCongNo.Size = new System.Drawing.Size(124, 31);
            this.btnInCongNo.TabIndex = 21;
            this.btnInCongNo.Text = "Xuất File Excel";
            this.btnInCongNo.UseVisualStyleBackColor = false;
            this.btnInCongNo.Click += new System.EventHandler(this.btnInCongNo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Azure;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(465, 337);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 31);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(278, 44);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(50, 21);
            this.cmbThang.TabIndex = 20;
            this.cmbThang.SelectedValueChanged += new System.EventHandler(this.cmbThang_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.dgvCongNo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 248);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Tài Chính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(355, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã Báo Cáo:";
            // 
            // cmbMaBaoCao
            // 
            this.cmbMaBaoCao.FormattingEnabled = true;
            this.cmbMaBaoCao.Location = new System.Drawing.Point(446, 44);
            this.cmbMaBaoCao.Name = "cmbMaBaoCao";
            this.cmbMaBaoCao.Size = new System.Drawing.Size(81, 21);
            this.cmbMaBaoCao.TabIndex = 26;
            // 
            // frmThongTinBaoCaoCongNoDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(601, 379);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMaBaoCao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInCongNo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongTinBaoCaoCongNoDaiLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Công Nợ Đại Lý";
            this.Load += new System.EventHandler(this.frmThongTinBaoCaoCongNoDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCongNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInCongNo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaBaoCao;
    }
}