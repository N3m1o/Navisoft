
namespace Test_1.Forms_Quan_Ly
{
    partial class Nhan_Vien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox_ChiTietNV = new System.Windows.Forms.GroupBox();
            this.txtDinhChi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateSinhNhat = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayBD = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.comboBoxCongViec = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonTenNV = new System.Windows.Forms.RadioButton();
            this.radioButtonMaNV = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.btn_KetXuat = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox_ChiTietNV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1177, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Nhân viên";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 23);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(1171, 264);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox_ChiTietNV
            // 
            this.groupBox_ChiTietNV.Controls.Add(this.txtDinhChi);
            this.groupBox_ChiTietNV.Controls.Add(this.label10);
            this.groupBox_ChiTietNV.Controls.Add(this.dateSinhNhat);
            this.groupBox_ChiTietNV.Controls.Add(this.label9);
            this.groupBox_ChiTietNV.Controls.Add(this.txtSoDienThoai);
            this.groupBox_ChiTietNV.Controls.Add(this.label8);
            this.groupBox_ChiTietNV.Controls.Add(this.dateTimePickerNgayKT);
            this.groupBox_ChiTietNV.Controls.Add(this.dateTimePickerNgayBD);
            this.groupBox_ChiTietNV.Controls.Add(this.comboBoxPhongBan);
            this.groupBox_ChiTietNV.Controls.Add(this.comboBoxCongViec);
            this.groupBox_ChiTietNV.Controls.Add(this.txtDiaChi);
            this.groupBox_ChiTietNV.Controls.Add(this.txtTenNV);
            this.groupBox_ChiTietNV.Controls.Add(this.txtMaNV);
            this.groupBox_ChiTietNV.Controls.Add(this.label7);
            this.groupBox_ChiTietNV.Controls.Add(this.label6);
            this.groupBox_ChiTietNV.Controls.Add(this.label5);
            this.groupBox_ChiTietNV.Controls.Add(this.label4);
            this.groupBox_ChiTietNV.Controls.Add(this.label3);
            this.groupBox_ChiTietNV.Controls.Add(this.label2);
            this.groupBox_ChiTietNV.Controls.Add(this.label1);
            this.groupBox_ChiTietNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_ChiTietNV.Location = new System.Drawing.Point(0, 290);
            this.groupBox_ChiTietNV.Name = "groupBox_ChiTietNV";
            this.groupBox_ChiTietNV.Size = new System.Drawing.Size(644, 387);
            this.groupBox_ChiTietNV.TabIndex = 1;
            this.groupBox_ChiTietNV.TabStop = false;
            this.groupBox_ChiTietNV.Text = "Chi tiết Nhân viên";
            // 
            // txtDinhChi
            // 
            this.txtDinhChi.Location = new System.Drawing.Point(514, 29);
            this.txtDinhChi.Name = "txtDinhChi";
            this.txtDinhChi.Size = new System.Drawing.Size(90, 27);
            this.txtDinhChi.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Đình chỉ";
            // 
            // dateSinhNhat
            // 
            this.dateSinhNhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSinhNhat.Location = new System.Drawing.Point(141, 268);
            this.dateSinhNhat.Name = "dateSinhNhat";
            this.dateSinhNhat.Size = new System.Drawing.Size(271, 27);
            this.dateSinhNhat.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ngày sinh";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(141, 349);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(271, 27);
            this.txtSoDienThoai.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Số điện thoại";
            // 
            // dateTimePickerNgayKT
            // 
            this.dateTimePickerNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayKT.Location = new System.Drawing.Point(141, 221);
            this.dateTimePickerNgayKT.Name = "dateTimePickerNgayKT";
            this.dateTimePickerNgayKT.Size = new System.Drawing.Size(271, 27);
            this.dateTimePickerNgayKT.TabIndex = 17;
            // 
            // dateTimePickerNgayBD
            // 
            this.dateTimePickerNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayBD.Location = new System.Drawing.Point(141, 181);
            this.dateTimePickerNgayBD.Name = "dateTimePickerNgayBD";
            this.dateTimePickerNgayBD.Size = new System.Drawing.Size(271, 27);
            this.dateTimePickerNgayBD.TabIndex = 16;
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Location = new System.Drawing.Point(141, 144);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(271, 28);
            this.comboBoxPhongBan.TabIndex = 15;
            // 
            // comboBoxCongViec
            // 
            this.comboBoxCongViec.FormattingEnabled = true;
            this.comboBoxCongViec.Location = new System.Drawing.Point(141, 106);
            this.comboBoxCongViec.Name = "comboBoxCongViec";
            this.comboBoxCongViec.Size = new System.Drawing.Size(271, 28);
            this.comboBoxCongViec.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(141, 304);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(271, 27);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(141, 69);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(271, 27);
            this.txtTenNV.TabIndex = 8;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(141, 29);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(271, 27);
            this.txtMaNV.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phòng ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnTaiLai);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.radioButtonTenNV);
            this.groupBox2.Controls.Add(this.radioButtonMaNV);
            this.groupBox2.Location = new System.Drawing.Point(655, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 381);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm Nhân viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(26, 203);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(128, 44);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaiLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaiLai.Location = new System.Drawing.Point(166, 203);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(128, 44);
            this.btnTaiLai.TabIndex = 8;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(6, 132);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 38);
            this.textBox1.TabIndex = 2;
            // 
            // radioButtonTenNV
            // 
            this.radioButtonTenNV.AutoSize = true;
            this.radioButtonTenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonTenNV.Location = new System.Drawing.Point(6, 82);
            this.radioButtonTenNV.Name = "radioButtonTenNV";
            this.radioButtonTenNV.Size = new System.Drawing.Size(171, 27);
            this.radioButtonTenNV.TabIndex = 1;
            this.radioButtonTenNV.TabStop = true;
            this.radioButtonTenNV.Text = "Tìm Tên nhân viên";
            this.radioButtonTenNV.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaNV
            // 
            this.radioButtonMaNV.AutoSize = true;
            this.radioButtonMaNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMaNV.Location = new System.Drawing.Point(6, 49);
            this.radioButtonMaNV.Name = "radioButtonMaNV";
            this.radioButtonMaNV.Size = new System.Drawing.Size(170, 27);
            this.radioButtonMaNV.TabIndex = 0;
            this.radioButtonMaNV.TabStop = true;
            this.radioButtonMaNV.Text = "Tìm Mã nhân viên";
            this.radioButtonMaNV.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(1016, 346);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 44);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(1016, 396);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 44);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(1016, 446);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 44);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.BackColor = System.Drawing.Color.DarkCyan;
            this.btnKhoiTao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKhoiTao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhoiTao.Location = new System.Drawing.Point(1016, 496);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(128, 44);
            this.btnKhoiTao.TabIndex = 6;
            this.btnKhoiTao.Text = "Khởi tạo";
            this.btnKhoiTao.UseVisualStyleBackColor = false;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // btn_KetXuat
            // 
            this.btn_KetXuat.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_KetXuat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KetXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_KetXuat.Location = new System.Drawing.Point(1016, 546);
            this.btn_KetXuat.Name = "btn_KetXuat";
            this.btn_KetXuat.Size = new System.Drawing.Size(128, 44);
            this.btn_KetXuat.TabIndex = 7;
            this.btn_KetXuat.Text = "Kết xuất";
            this.btn_KetXuat.UseVisualStyleBackColor = false;
            this.btn_KetXuat.Click += new System.EventHandler(this.btn_KetXuat_Click);
            // 
            // Nhan_Vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 677);
            this.Controls.Add(this.btn_KetXuat);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_ChiTietNV);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nhan_Vien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.Nhan_Vien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox_ChiTietNV.ResumeLayout(false);
            this.groupBox_ChiTietNV.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox_ChiTietNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKhoiTao;
        private System.Windows.Forms.RadioButton radioButtonTenNV;
        private System.Windows.Forms.RadioButton radioButtonMaNV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox comboBoxCongViec;
        private System.Windows.Forms.ComboBox comboBoxPhongBan;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKT;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBD;
        private System.Windows.Forms.Button btn_KetXuat;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateSinhNhat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDinhChi;
        private System.Windows.Forms.Label label10;
    }
}