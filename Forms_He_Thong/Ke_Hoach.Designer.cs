
namespace Test_1.Forms
{
    partial class Ke_Hoach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_ThongTinKeHoach = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox_ChiTietKeHoach = new System.Windows.Forms.GroupBox();
            this.comboBox_MaBTC = new System.Windows.Forms.ComboBox();
            this.comboBox_MaNV = new System.Windows.Forms.ComboBox();
            this.comboBox_MaDDG = new System.Windows.Forms.ComboBox();
            this.txt_KeHoachDatRa = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_KhoiTao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_MaTieuChi = new System.Windows.Forms.ComboBox();
            this.raBtn_MaKH = new System.Windows.Forms.RadioButton();
            this.comboBox_MaNhanVien = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_MaDotDanhGia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_ThongTinKeHoach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox_ChiTietKeHoach.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ThongTinKeHoach
            // 
            this.groupBox_ThongTinKeHoach.Controls.Add(this.dgv);
            this.groupBox_ThongTinKeHoach.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ThongTinKeHoach.Location = new System.Drawing.Point(0, 0);
            this.groupBox_ThongTinKeHoach.Name = "groupBox_ThongTinKeHoach";
            this.groupBox_ThongTinKeHoach.Size = new System.Drawing.Size(1177, 290);
            this.groupBox_ThongTinKeHoach.TabIndex = 0;
            this.groupBox_ThongTinKeHoach.TabStop = false;
            this.groupBox_ThongTinKeHoach.Text = "Thông tin Kế hoạch";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 23);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(1171, 264);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox_ChiTietKeHoach
            // 
            this.groupBox_ChiTietKeHoach.Controls.Add(this.comboBox_MaBTC);
            this.groupBox_ChiTietKeHoach.Controls.Add(this.comboBox_MaNV);
            this.groupBox_ChiTietKeHoach.Controls.Add(this.comboBox_MaDDG);
            this.groupBox_ChiTietKeHoach.Controls.Add(this.txt_KeHoachDatRa);
            this.groupBox_ChiTietKeHoach.Controls.Add(this.txt_MaKH);
            this.groupBox_ChiTietKeHoach.Controls.Add(this.label5);
            this.groupBox_ChiTietKeHoach.Controls.Add(this.label4);
            this.groupBox_ChiTietKeHoach.Controls.Add(this.label3);
            this.groupBox_ChiTietKeHoach.Controls.Add(this.label2);
            this.groupBox_ChiTietKeHoach.Controls.Add(this.label1);
            this.groupBox_ChiTietKeHoach.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_ChiTietKeHoach.Location = new System.Drawing.Point(0, 290);
            this.groupBox_ChiTietKeHoach.Name = "groupBox_ChiTietKeHoach";
            this.groupBox_ChiTietKeHoach.Size = new System.Drawing.Size(644, 387);
            this.groupBox_ChiTietKeHoach.TabIndex = 1;
            this.groupBox_ChiTietKeHoach.TabStop = false;
            this.groupBox_ChiTietKeHoach.Text = "Chi tiết";
            // 
            // comboBox_MaBTC
            // 
            this.comboBox_MaBTC.FormattingEnabled = true;
            this.comboBox_MaBTC.Location = new System.Drawing.Point(166, 205);
            this.comboBox_MaBTC.Name = "comboBox_MaBTC";
            this.comboBox_MaBTC.Size = new System.Drawing.Size(125, 28);
            this.comboBox_MaBTC.TabIndex = 12;
            // 
            // comboBox_MaNV
            // 
            this.comboBox_MaNV.FormattingEnabled = true;
            this.comboBox_MaNV.Location = new System.Drawing.Point(166, 158);
            this.comboBox_MaNV.Name = "comboBox_MaNV";
            this.comboBox_MaNV.Size = new System.Drawing.Size(125, 28);
            this.comboBox_MaNV.TabIndex = 11;
            // 
            // comboBox_MaDDG
            // 
            this.comboBox_MaDDG.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_MaDDG.FormattingEnabled = true;
            this.comboBox_MaDDG.Location = new System.Drawing.Point(166, 103);
            this.comboBox_MaDDG.Name = "comboBox_MaDDG";
            this.comboBox_MaDDG.Size = new System.Drawing.Size(125, 28);
            this.comboBox_MaDDG.TabIndex = 10;
            this.comboBox_MaDDG.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaDDG_SelectedIndexChanged);
            // 
            // txt_KeHoachDatRa
            // 
            this.txt_KeHoachDatRa.Location = new System.Drawing.Point(438, 56);
            this.txt_KeHoachDatRa.Multiline = true;
            this.txt_KeHoachDatRa.Name = "txt_KeHoachDatRa";
            this.txt_KeHoachDatRa.Size = new System.Drawing.Size(188, 183);
            this.txt_KeHoachDatRa.TabIndex = 9;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(166, 53);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(125, 27);
            this.txt_MaKH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(297, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kế hoạch đặt ra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã bộ tiêu chí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đợt đánh giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã kế hoạch";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.Location = new System.Drawing.Point(1022, 368);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 44);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sua.Location = new System.Drawing.Point(1022, 422);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(128, 44);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Location = new System.Drawing.Point(1022, 483);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(128, 44);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_KhoiTao
            // 
            this.btn_KhoiTao.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_KhoiTao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KhoiTao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_KhoiTao.Location = new System.Drawing.Point(1022, 539);
            this.btn_KhoiTao.Name = "btn_KhoiTao";
            this.btn_KhoiTao.Size = new System.Drawing.Size(128, 44);
            this.btn_KhoiTao.TabIndex = 5;
            this.btn_KhoiTao.Text = "Khởi tạo";
            this.btn_KhoiTao.UseVisualStyleBackColor = false;
            this.btn_KhoiTao.Click += new System.EventHandler(this.btn_KhoiTao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Reload);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox_MaTieuChi);
            this.groupBox1.Controls.Add(this.raBtn_MaKH);
            this.groupBox1.Controls.Add(this.comboBox_MaNhanVien);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_MaDotDanhGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(655, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 381);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm kế hoạch";
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Reload.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reload.Location = new System.Drawing.Point(164, 269);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(128, 44);
            this.btn_Reload.TabIndex = 22;
            this.btn_Reload.Text = "Tải lại";
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(25, 269);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 44);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Search.Location = new System.Drawing.Point(6, 200);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(308, 38);
            this.txt_Search.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tìm theo:";
            // 
            // comboBox_MaTieuChi
            // 
            this.comboBox_MaTieuChi.FormattingEnabled = true;
            this.comboBox_MaTieuChi.Location = new System.Drawing.Point(178, 140);
            this.comboBox_MaTieuChi.Name = "comboBox_MaTieuChi";
            this.comboBox_MaTieuChi.Size = new System.Drawing.Size(125, 28);
            this.comboBox_MaTieuChi.TabIndex = 18;
            // 
            // raBtn_MaKH
            // 
            this.raBtn_MaKH.AutoSize = true;
            this.raBtn_MaKH.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.raBtn_MaKH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raBtn_MaKH.Location = new System.Drawing.Point(32, 167);
            this.raBtn_MaKH.Name = "raBtn_MaKH";
            this.raBtn_MaKH.Size = new System.Drawing.Size(131, 27);
            this.raBtn_MaKH.TabIndex = 0;
            this.raBtn_MaKH.TabStop = true;
            this.raBtn_MaKH.Text = "Mã kế hoạch";
            this.raBtn_MaKH.UseVisualStyleBackColor = true;
            // 
            // comboBox_MaNhanVien
            // 
            this.comboBox_MaNhanVien.FormattingEnabled = true;
            this.comboBox_MaNhanVien.Location = new System.Drawing.Point(178, 106);
            this.comboBox_MaNhanVien.Name = "comboBox_MaNhanVien";
            this.comboBox_MaNhanVien.Size = new System.Drawing.Size(125, 28);
            this.comboBox_MaNhanVien.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã Đợt đánh giá";
            // 
            // comboBox_MaDotDanhGia
            // 
            this.comboBox_MaDotDanhGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_MaDotDanhGia.FormattingEnabled = true;
            this.comboBox_MaDotDanhGia.Location = new System.Drawing.Point(178, 72);
            this.comboBox_MaDotDanhGia.Name = "comboBox_MaDotDanhGia";
            this.comboBox_MaDotDanhGia.Size = new System.Drawing.Size(125, 28);
            this.comboBox_MaDotDanhGia.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(32, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã bộ tiêu chí";
            // 
            // Ke_Hoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 677);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_KhoiTao);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox_ChiTietKeHoach);
            this.Controls.Add(this.groupBox_ThongTinKeHoach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ke_Hoach";
            this.Text = "Kế Hoạch";
            this.Load += new System.EventHandler(this.Ke_Hoach_Load);
            this.groupBox_ThongTinKeHoach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox_ChiTietKeHoach.ResumeLayout(false);
            this.groupBox_ChiTietKeHoach.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ThongTinKeHoach;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox_ChiTietKeHoach;
        private System.Windows.Forms.TextBox txt_KeHoachDatRa;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_KhoiTao;
        private System.Windows.Forms.ComboBox comboBox_MaBTC;
        private System.Windows.Forms.ComboBox comboBox_MaNV;
        private System.Windows.Forms.ComboBox comboBox_MaDDG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton raBtn_MaKH;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_MaTieuChi;
        private System.Windows.Forms.ComboBox comboBox_MaNhanVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_MaDotDanhGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_Search;
    }
}