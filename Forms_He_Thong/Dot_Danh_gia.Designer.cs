
namespace Test_1.Forms
{
    partial class Dot_Danh_gia
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
            this.groupBox_thongTinDDG = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox_chiTietDDG = new System.Windows.Forms.GroupBox();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.txt_Thang = new System.Windows.Forms.TextBox();
            this.txt_TenDDG = new System.Windows.Forms.TextBox();
            this.txt_MaDDG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.raBtn_TenDDG = new System.Windows.Forms.RadioButton();
            this.raBtn_MaDDG = new System.Windows.Forms.RadioButton();
            this.groupBox_thongTinDDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox_chiTietDDG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_thongTinDDG
            // 
            this.groupBox_thongTinDDG.Controls.Add(this.dgv);
            this.groupBox_thongTinDDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_thongTinDDG.Location = new System.Drawing.Point(0, 0);
            this.groupBox_thongTinDDG.Name = "groupBox_thongTinDDG";
            this.groupBox_thongTinDDG.Size = new System.Drawing.Size(1177, 290);
            this.groupBox_thongTinDDG.TabIndex = 0;
            this.groupBox_thongTinDDG.TabStop = false;
            this.groupBox_thongTinDDG.Text = "Thông tin Đợt đánh giá";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.Location = new System.Drawing.Point(3, 23);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(1171, 264);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox_chiTietDDG
            // 
            this.groupBox_chiTietDDG.Controls.Add(this.txt_Nam);
            this.groupBox_chiTietDDG.Controls.Add(this.txt_Thang);
            this.groupBox_chiTietDDG.Controls.Add(this.txt_TenDDG);
            this.groupBox_chiTietDDG.Controls.Add(this.txt_MaDDG);
            this.groupBox_chiTietDDG.Controls.Add(this.label4);
            this.groupBox_chiTietDDG.Controls.Add(this.label3);
            this.groupBox_chiTietDDG.Controls.Add(this.label2);
            this.groupBox_chiTietDDG.Controls.Add(this.label1);
            this.groupBox_chiTietDDG.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_chiTietDDG.Location = new System.Drawing.Point(0, 290);
            this.groupBox_chiTietDDG.Name = "groupBox_chiTietDDG";
            this.groupBox_chiTietDDG.Size = new System.Drawing.Size(644, 387);
            this.groupBox_chiTietDDG.TabIndex = 1;
            this.groupBox_chiTietDDG.TabStop = false;
            this.groupBox_chiTietDDG.Text = "Chi tiết Đợt đánh giá";
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(412, 199);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(125, 27);
            this.txt_Nam.TabIndex = 7;
            // 
            // txt_Thang
            // 
            this.txt_Thang.Location = new System.Drawing.Point(412, 57);
            this.txt_Thang.Name = "txt_Thang";
            this.txt_Thang.Size = new System.Drawing.Size(125, 27);
            this.txt_Thang.TabIndex = 6;
            // 
            // txt_TenDDG
            // 
            this.txt_TenDDG.Location = new System.Drawing.Point(167, 199);
            this.txt_TenDDG.Name = "txt_TenDDG";
            this.txt_TenDDG.Size = new System.Drawing.Size(125, 27);
            this.txt_TenDDG.TabIndex = 5;
            // 
            // txt_MaDDG
            // 
            this.txt_MaDDG.Location = new System.Drawing.Point(165, 57);
            this.txt_MaDDG.Name = "txt_MaDDG";
            this.txt_MaDDG.Size = new System.Drawing.Size(125, 27);
            this.txt_MaDDG.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(358, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(346, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đợt đánh giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Đợt đánh giá";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1022, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1022, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1022, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1022, 539);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "Khởi tạo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ma_DDG";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 148;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Reload);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Controls.Add(this.raBtn_TenDDG);
            this.groupBox1.Controls.Add(this.raBtn_MaDDG);
            this.groupBox1.Location = new System.Drawing.Point(655, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 381);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm Đợt đánh giá";
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
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Search.Location = new System.Drawing.Point(6, 109);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(308, 38);
            this.txt_Search.TabIndex = 2;
            // 
            // raBtn_TenDDG
            // 
            this.raBtn_TenDDG.AutoSize = true;
            this.raBtn_TenDDG.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raBtn_TenDDG.Location = new System.Drawing.Point(167, 72);
            this.raBtn_TenDDG.Name = "raBtn_TenDDG";
            this.raBtn_TenDDG.Size = new System.Drawing.Size(130, 27);
            this.raBtn_TenDDG.TabIndex = 1;
            this.raBtn_TenDDG.TabStop = true;
            this.raBtn_TenDDG.Text = "Tìm theo Tên";
            this.raBtn_TenDDG.UseVisualStyleBackColor = true;
            // 
            // raBtn_MaDDG
            // 
            this.raBtn_MaDDG.AutoSize = true;
            this.raBtn_MaDDG.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raBtn_MaDDG.Location = new System.Drawing.Point(22, 72);
            this.raBtn_MaDDG.Name = "raBtn_MaDDG";
            this.raBtn_MaDDG.Size = new System.Drawing.Size(129, 27);
            this.raBtn_MaDDG.TabIndex = 0;
            this.raBtn_MaDDG.TabStop = true;
            this.raBtn_MaDDG.Text = "Tìm theo Mã";
            this.raBtn_MaDDG.UseVisualStyleBackColor = true;
            // 
            // Dot_Danh_gia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 677);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_chiTietDDG);
            this.Controls.Add(this.groupBox_thongTinDDG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dot_Danh_gia";
            this.Text = "Đợt đánh giá";
            this.Load += new System.EventHandler(this.Dot_Danh_gia_Load);
            this.groupBox_thongTinDDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox_chiTietDDG.ResumeLayout(false);
            this.groupBox_chiTietDDG.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_thongTinDDG;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox_chiTietDDG;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.TextBox txt_Thang;
        private System.Windows.Forms.TextBox txt_TenDDG;
        private System.Windows.Forms.TextBox txt_MaDDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton raBtn_TenDDG;
        private System.Windows.Forms.RadioButton raBtn_MaDDG;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_Search;
    }
}