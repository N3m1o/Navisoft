
namespace Test_1.Forms
{
    partial class Phong_Ban
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
            this.groupBoxPhongBan = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TenPB = new System.Windows.Forms.TextBox();
            this.txt_MaPB = new System.Windows.Forms.TextBox();
            this.label_TenPB = new System.Windows.Forms.Label();
            this.label_MaPB = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_khoiTao = new System.Windows.Forms.Button();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.raBtn_TenPB = new System.Windows.Forms.RadioButton();
            this.raBtn_MaPB = new System.Windows.Forms.RadioButton();
            this.groupBoxPhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPhongBan
            // 
            this.groupBoxPhongBan.Controls.Add(this.dgv);
            this.groupBoxPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPhongBan.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPhongBan.Name = "groupBoxPhongBan";
            this.groupBoxPhongBan.Size = new System.Drawing.Size(1177, 290);
            this.groupBoxPhongBan.TabIndex = 0;
            this.groupBoxPhongBan.TabStop = false;
            this.groupBoxPhongBan.Text = "Thông Tin Phòng Ban";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TenPB);
            this.groupBox1.Controls.Add(this.txt_MaPB);
            this.groupBox1.Controls.Add(this.label_TenPB);
            this.groupBox1.Controls.Add(this.label_MaPB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 387);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết";
            // 
            // txt_TenPB
            // 
            this.txt_TenPB.Location = new System.Drawing.Point(210, 192);
            this.txt_TenPB.Name = "txt_TenPB";
            this.txt_TenPB.Size = new System.Drawing.Size(140, 27);
            this.txt_TenPB.TabIndex = 5;
            // 
            // txt_MaPB
            // 
            this.txt_MaPB.Location = new System.Drawing.Point(210, 78);
            this.txt_MaPB.Name = "txt_MaPB";
            this.txt_MaPB.Size = new System.Drawing.Size(140, 27);
            this.txt_MaPB.TabIndex = 4;
            // 
            // label_TenPB
            // 
            this.label_TenPB.AutoSize = true;
            this.label_TenPB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_TenPB.Location = new System.Drawing.Point(42, 192);
            this.label_TenPB.Name = "label_TenPB";
            this.label_TenPB.Size = new System.Drawing.Size(128, 23);
            this.label_TenPB.TabIndex = 1;
            this.label_TenPB.Text = "Tên Phòng ban";
            // 
            // label_MaPB
            // 
            this.label_MaPB.AutoSize = true;
            this.label_MaPB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_MaPB.Location = new System.Drawing.Point(42, 78);
            this.label_MaPB.Name = "label_MaPB";
            this.label_MaPB.Size = new System.Drawing.Size(126, 23);
            this.label_MaPB.TabIndex = 0;
            this.label_MaPB.Text = "Mã Phòng ban";
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
            // btn_khoiTao
            // 
            this.btn_khoiTao.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_khoiTao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_khoiTao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_khoiTao.Location = new System.Drawing.Point(1022, 539);
            this.btn_khoiTao.Name = "btn_khoiTao";
            this.btn_khoiTao.Size = new System.Drawing.Size(128, 44);
            this.btn_khoiTao.TabIndex = 5;
            this.btn_khoiTao.Text = "Khởi tạo";
            this.btn_khoiTao.UseVisualStyleBackColor = false;
            this.btn_khoiTao.Click += new System.EventHandler(this.btn_khoiTao_Click);
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.btn_Reload);
            this.groupBox_Search.Controls.Add(this.btn_Search);
            this.groupBox_Search.Controls.Add(this.txt_search);
            this.groupBox_Search.Controls.Add(this.raBtn_TenPB);
            this.groupBox_Search.Controls.Add(this.raBtn_MaPB);
            this.groupBox_Search.Location = new System.Drawing.Point(655, 296);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(320, 381);
            this.groupBox_Search.TabIndex = 6;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Tìm kiếm trong Phòng Ban";
            this.groupBox_Search.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Reload.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reload.Location = new System.Drawing.Point(162, 191);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(128, 44);
            this.btn_Reload.TabIndex = 4;
            this.btn_Reload.Text = "Tải lại";
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(22, 191);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 44);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(6, 109);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(308, 38);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // raBtn_TenPB
            // 
            this.raBtn_TenPB.AutoSize = true;
            this.raBtn_TenPB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raBtn_TenPB.Location = new System.Drawing.Point(167, 72);
            this.raBtn_TenPB.Name = "raBtn_TenPB";
            this.raBtn_TenPB.Size = new System.Drawing.Size(146, 27);
            this.raBtn_TenPB.TabIndex = 1;
            this.raBtn_TenPB.TabStop = true;
            this.raBtn_TenPB.Text = "Tên phòng ban";
            this.raBtn_TenPB.UseVisualStyleBackColor = true;
            // 
            // raBtn_MaPB
            // 
            this.raBtn_MaPB.AutoSize = true;
            this.raBtn_MaPB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raBtn_MaPB.Location = new System.Drawing.Point(16, 72);
            this.raBtn_MaPB.Name = "raBtn_MaPB";
            this.raBtn_MaPB.Size = new System.Drawing.Size(145, 27);
            this.raBtn_MaPB.TabIndex = 0;
            this.raBtn_MaPB.TabStop = true;
            this.raBtn_MaPB.Text = "Mã phòng ban";
            this.raBtn_MaPB.UseVisualStyleBackColor = true;
            // 
            // Phong_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 677);
            this.Controls.Add(this.groupBox_Search);
            this.Controls.Add(this.btn_khoiTao);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPhongBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phong_Ban";
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.Phong_Ban_Load);
            this.groupBoxPhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPhongBan;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenPB;
        private System.Windows.Forms.TextBox txt_MaPB;
        private System.Windows.Forms.Label label_TenPB;
        private System.Windows.Forms.Label label_MaPB;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_khoiTao;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.RadioButton raBtn_TenPB;
        private System.Windows.Forms.RadioButton raBtn_MaPB;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Reload;
    }
}