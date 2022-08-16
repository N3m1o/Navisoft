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
    public partial class Tieu_Chi : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-IQ04FMD\SQLEXPRESS;Initial Catalog=NamViet;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table_search_MaTC = new DataTable();
        DataTable table_search_TenTC = new DataTable();
        DataTable table_MaBTC = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaTC AS N'Mã tiêu chí', TenTieuChi AS N'Tên tiêu chí', Mota AS N'Mô tả', DiemToiDa AS N'Điểm tối đa' FROM TieuChi";
            dataAdapter.SelectCommand = command;
            table.Clear();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
        }

        public Tieu_Chi()
        {
            InitializeComponent();
        }

        private void Tieu_Chi_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txtMaTC.ReadOnly = true;
            i = dgv.CurrentRow.Index;
            txtMaTC.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtTenTC.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtMota.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtDiemToiDa.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }


            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.TieuChi(MaTC, TenTieuChi, MoTa, DiemToiDa) VALUES ( N'" + txtMaTC.Text+"', N'"+ txtTenTC.Text +"', N'"+txtMota.Text+"', N'"+txtDiemToiDa.Text+"')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaTC.Text = "";
            txtTenTC.Text = "";
            txtMota.Text = "";
            txtDiemToiDa.Text = "";
            txtMaTC.ReadOnly = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE TieuChi SET TenTieuChi= N'" + txtTenTC.Text + "', MoTa = N'" + txtMota.Text + "', DiemToiDa = N'"+txtDiemToiDa.Text+"' WHERE MaTC='" + txtMaTC.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa dòng này không?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM dbo.TieuChi WHERE MaTC ='" + txtMaTC.Text + "'";
                command.ExecuteNonQuery();
                loadData();
            }
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
                worksheet.Name = "Tiêu chí";

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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radioButtonMaTC.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaTC AS N'Mã tiêu chí', MaBTC AS N'Mã bộ tiêu chí', TenTieuChi AS N'Tên tiêu chí', TrongSo AS N'Trọng số', DonViTinh AS N'Đơn vị tính', MoTa AS N'Mô tả' FROM dbo.TieuChi WHERE MaTC LIKE '%"+textBox1.Text+"%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_MaTC.Clear();
                dataAdapter.Fill(table_search_MaTC);
                dgv.DataSource = table_search_MaTC;
            }
            else if (radioButtonTenTC.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaTC AS N'Mã tiêu chí', MaBTC AS N'Mã bộ tiêu chí', TenTieuChi AS N'Tên tiêu chí', TrongSo AS N'Trọng số', DonViTinh AS N'Đơn vị tính', MoTa AS N'Mô tả' FROM dbo.TieuChi WHERE TenTC LIKE N'%" + textBox1.Text + "%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_TenTC.Clear();
                dataAdapter.Fill(table_search_TenTC);
                dgv.DataSource = table_search_TenTC;
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            loadData();
        }
    }
}
