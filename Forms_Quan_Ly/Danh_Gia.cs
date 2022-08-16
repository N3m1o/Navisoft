using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_1.Forms_Quan_Ly
{
    public partial class Danh_Gia : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-IQ04FMD\SQLEXPRESS;Initial Catalog=NamViet;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table_search_MaDG = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaDG AS N'Mã đánh giá', MaDDG AS N'Mã đợt đánh giá', MaNV AS N'Mã nhân viên', NgayDG AS N'Ngày đánh giá', DiemNVTDG AS N'Điểm nhân viên tự đánh giá', DiemQLDG AS N'Điểm quản lý đánh giá', XetDuyet AS N'Xét duyệt', YKienPheDuyet AS N'Ý kiến phê duyệt', TrangThai AS N'Trạng thái' FROM DanhGia";
            dataAdapter.SelectCommand = command;
            table.Clear();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
        }

        void loadCommoBox()
        {
            //combo box MaNV:
            var cmd1 = new SqlCommand("SELECT * FROM dbo.NhanVien", connection);
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            comboBoxMaNV.DisplayMember = "MaNV";
            comboBoxMaNV.DataSource = dt1;

            //combo box MaDDG:
            var cmd2 = new SqlCommand("SELECT * FROM dbo.DotDanhGia", connection);
            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            comboBox_MaDDG.DisplayMember = "MaDDG";
            comboBox_MaDDG.DataSource = dt2;
        }

        public Danh_Gia()
        {
            InitializeComponent();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txtMaDG.ReadOnly = true;
            i = dgv.CurrentRow.Index;
            txtMaDG.Text = dgv.Rows[i].Cells[0].Value.ToString();
            comboBox_MaDDG.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtNVTDG.Text = dgv.Rows[i].Cells[4].Value.ToString();
            txtQLDG.Text = dgv.Rows[i].Cells[5].Value.ToString();
            dateTimePicker1.Text = dgv.Rows[i].Cells[3].Value.ToString();
            comboBoxMaNV.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtTrangThai.Text = dgv.Rows[i].Cells[8].Value.ToString();
            txtXetDuyet.Text = dgv.Rows[i].Cells[6].Value.ToString();
            txtYKienPheDuyet.Text = dgv.Rows[i].Cells[7].Value.ToString();
        }

        private void Danh_Gia_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            loadCommoBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.DanhGia(MaDG, MaDDG, MaNV, NgayDG, DiemNVTDG, DiemQLDG, XetDuyet, YKienPheDuyet, TrangThai) VALUES( N'" + txtMaDG.Text + "', N'" + comboBox_MaDDG.Text + "', N'" + comboBoxMaNV.Text + "', '" + dateTimePicker1.Text + "', '" + txtNVTDG.Text + "', N'" + txtQLDG.Text + "', N'" + txtXetDuyet.Text + "', N'" + txtYKienPheDuyet.Text + "', N'" + txtTrangThai.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE DanhGia SET MaDDG = N'" + comboBox_MaDDG.Text + "', MaNV='" + comboBoxMaNV.Text + "', NgayDG='" + dateTimePicker1.Text + "', DiemNVTDG= '" + txtNVTDG.Text + "', DiemQLDG = N'" + txtQLDG.Text + "', XetDuyet = N'" + txtXetDuyet.Text + "', YKienPheDuyet = N'" + txtYKienPheDuyet.Text + "', TrangThai = N'" + txtTrangThai.Text + "' WHERE MaDG='" + txtMaDG.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa dòng này không?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM dbo.Nhanvien WHERE MaDG ='" + txtMaDG.Text + "'";
                command.ExecuteNonQuery();
                loadData();
            }
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaDG.Text = "";
            comboBox_MaDDG.Text = "";
            comboBoxMaNV.Text = "";
            dateTimePicker1.Text = "";
            txtNVTDG.Text = "";
            txtQLDG.Text = "";
            txtTrangThai.Text = "";
            txtXetDuyet.Text = "";
            txtYKienPheDuyet.Text = "";
            txtMaDG.ReadOnly = false;
        }

        private void btnKetXuat_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                xuatRaExcel(dgv, saveFileDialog1.FileName);
            }
        }

        private void xuatRaExcel(DataGridView dataGridView, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý nhân viên";

                // export header trong DataGridView
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTimMDG.Text = "";
            loadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaDG AS N'Mã đánh giá', MaDDG AS N'Mã đợt đánh giá', MaNV AS N'Mã nhân viên', NgayDG AS N'Ngày đánh giá', DiemNVTDG AS N'Điểm nhân viên tự đánh giá', DiemQLDG AS N'Điểm quản lý đánh giá', XetDuyet AS N'Xét duyệt', YKienPheDuyet AS N'Ý kiến phê duyệt', TrangThai AS N'Trạng thái' FROM DanhGia WHERE MaDG LIKE N'%" + txtTimMDG.Text + "%'";
            //command.ExecuteNonQuery();
            //loadData();
            dataAdapter.SelectCommand = command;
            table_search_MaDG.Clear();
            dataAdapter.Fill(table_search_MaDG);
            dgv.DataSource = table_search_MaDG;
        }
    }
}
