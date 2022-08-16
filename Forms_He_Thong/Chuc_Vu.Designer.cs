
namespace Test_1.Forms
{
    partial class Chuc_Vu
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
            this.groupBox_ThongTinChucVu = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox_ChiTietChucVu = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Diengiai = new System.Windows.Forms.TextBox();
            this.txt_TenCV = new System.Windows.Forms.TextBox();
            this.txt_MaCV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_KhoiTao = new System.Windows.Forms.Button();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.radioButton_TenCV = new System.Windows.Forms.RadioButton();
            this.radioButton_MaCV = new System.Windows.Forms.RadioButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.comboBox_MaBTC = new System.Windows.Forms.ComboBox();
            this.groupBox_ThongTinChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox_ChiTietChucVu.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ThongTinChucVu
            // 
            this.groupBox_ThongTinChucVu.Controls.Add(this.dgv);
            this.groupBox_ThongTinChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ThongTinChucVu.Location = new System.Drawing.Point(0, 0);
            this.groupBox_ThongTinChucVu.Name = "groupBox_ThongTinChucVu";
            this.groupBox_ThongTinChucVu.Size = new System.Drawing.Size(1177, 290);
            this.groupBox_ThongTinChucVu.TabIndex = 0;
            this.groupBox_ThongTinChucVu.TabStop = false;
            this.groupBox_ThongTinChucVu.Text = "Thông tin Chức vụ";
            this.groupBox_ThongTinChucVu.Enter += new System.EventHandler(this.groupBox_ThongTinChucVu_Enter);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox_ChiTietChucVu
            // 
            this.groupBox_ChiTietChucVu.Controls.Add(this.comboBox_MaBTC);
            this.groupBox_ChiTietChucVu.Controls.Add(this.label4);
            this.groupBox_ChiTietChucVu.Controls.Add(this.txt_Diengiai);
            this.groupBox_ChiTietChucVu.Controls.Add(this.txt_TenCV);
            this.groupBox_ChiTietChucVu.Controls.Add(this.txt_MaCV);
            this.groupBox_ChiTietChucVu.Controls.Add(this.label3);
            this.groupBox_ChiTietChucVu.Controls.Add(this.label2);
            this.groupBox_ChiTietChucVu.Controls.Add(this.label1);
            this.groupBox_ChiTietChucVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_ChiTietChucVu.Location = new System.Drawing.Point(0, 290);
            this.groupBox_ChiTietChucVu.Name = "groupBox_ChiTietChucVu";
            this.groupBox_ChiTietChucVu.Size = new System.Drawing.Size(644, 387);
            this.groupBox_ChiTietChucVu.TabIndex = 1;
            this.groupBox_ChiTietChucVu.TabStop = false;
            this.groupBox_ChiTietChucVu.Text = "Chi tiết Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã Bộ tiêu chí";
            // 
            // txt_Diengiai
            // 
            this.txt_Diengiai.Location = new System.Drawing.Point(385, 78);
            this.txt_Diengiai.Multiline = true;
            this.txt_Diengiai.Name = "txt_Diengiai";
            this.txt_Diengiai.Size = new System.Drawing.Size(218, 130);
            this.txt_Diengiai.TabIndex = 6;
            // 
            // txt_TenCV
            // 
            this.txt_TenCV.Location = new System.Drawing.Point(143, 181);
            this.txt_TenCV.Name = "txt_TenCV";
            this.txt_TenCV.Size = new System.Drawing.Size(145, 27);
            this.txt_TenCV.TabIndex = 5;
            // 
            // txt_MaCV
            // 
            this.txt_MaCV.Location = new System.Drawing.Point(143, 79);
            this.txt_MaCV.Name = "txt_MaCV";
            this.txt_MaCV.Size = new System.Drawing.Size(145, 27);
            this.txt_MaCV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(322, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chức vụ";
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
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.btn_Refresh);
            this.groupBox_Search.Controls.Add(this.btn_Search);
            this.groupBox_Search.Controls.Add(this.radioButton_TenCV);
            this.groupBox_Search.Controls.Add(this.radioButton_MaCV);
            this.groupBox_Search.Controls.Add(this.txt_Search);
            this.groupBox_Search.Location = new System.Drawing.Point(655, 296);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(320, 381);
            this.groupBox_Search.TabIndex = 6;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Tìm kiếm trong Chức vụ";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(162, 191);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(128, 44);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Tải lại";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(22, 191);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 44);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // radioButton_TenCV
            // 
            this.radioButton_TenCV.AutoSize = true;
            this.radioButton_TenCV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_TenCV.Location = new System.Drawing.Point(167, 72);
            this.radioButton_TenCV.Name = "radioButton_TenCV";
            this.radioButton_TenCV.Size = new System.Drawing.Size(123, 27);
            this.radioButton_TenCV.TabIndex = 2;
            this.radioButton_TenCV.TabStop = true;
            this.radioButton_TenCV.Text = "Tên chức vụ";
            this.radioButton_TenCV.UseVisualStyleBackColor = true;
            // 
            // radioButton_MaCV
            // 
            this.radioButton_MaCV.AutoSize = true;
            this.radioButton_MaCV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_MaCV.Location = new System.Drawing.Point(22, 72);
            this.radioButton_MaCV.Name = "radioButton_MaCV";
            this.radioButton_MaCV.Size = new System.Drawing.Size(122, 27);
            this.radioButton_MaCV.TabIndex = 1;
            this.radioButton_MaCV.TabStop = true;
            this.radioButton_MaCV.Text = "Mã chức vụ";
            this.radioButton_MaCV.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Search.Location = new System.Drawing.Point(6, 109);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(308, 38);
            this.txt_Search.TabIndex = 0;
            // 
            // comboBox_MaBTC
            // 
            this.comboBox_MaBTC.FormattingEnabled = true;
            this.comboBox_MaBTC.Location = new System.Drawing.Point(143, 270);
            this.comboBox_MaBTC.Name = "comboBox_MaBTC";
            this.comboBox_MaBTC.Size = new System.Drawing.Size(145, 28);
            this.comboBox_MaBTC.TabIndex = 8;
            // 
            // Chuc_Vu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 677);
            this.Controls.Add(this.groupBox_Search);
            this.Controls.Add(this.btn_KhoiTao);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox_ChiTietChucVu);
            this.Controls.Add(this.groupBox_ThongTinChucVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chuc_Vu";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.Chuc_Vu_Load);
            this.groupBox_ThongTinChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox_ChiTietChucVu.ResumeLayout(false);
            this.groupBox_ChiTietChucVu.PerformLayout();
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ThongTinChucVu;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox_ChiTietChucVu;
        private System.Windows.Forms.TextBox txt_Diengiai;
        private System.Windows.Forms.TextBox txt_TenCV;
        private System.Windows.Forms.TextBox txt_MaCV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_KhoiTao;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.RadioButton radioButton_TenCV;
        private System.Windows.Forms.RadioButton radioButton_MaCV;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_MaBTC;
    }
}