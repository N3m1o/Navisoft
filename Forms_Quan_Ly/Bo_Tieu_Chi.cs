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
    public partial class Bo_Tieu_Chi : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-IQ04FMD\SQLEXPRESS;Initial Catalog=NamViet;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table_search_MaBTC = new DataTable();
        DataTable table_search_TenBTC = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaBTC AS N'Mã bộ tiêu chí', TenBTC AS N'Tên bộ tiêu chí', Mota AS N'Mô tả' FROM BoTieuChi";
            dataAdapter.SelectCommand = command;
            table.Clear();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
        }

        public Bo_Tieu_Chi()
        {
            InitializeComponent();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txtMaBTC.ReadOnly = true;
            i = dgv.CurrentRow.Index;
            txtMaBTC.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtTenBTC.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtMota.Text = dgv.Rows[i].Cells[2].Value.ToString();
        }

        private void Bo_Tieu_Chi_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.BoTieuChi(MaBTC, TenBTC, MoTa) VALUES ( N'" + txtMaBTC.Text + "', N'" + txtTenBTC.Text + "', N'" + txtMota.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE BoTieuChi SET TenBTC = N'" + txtTenBTC.Text + "', MoTa='" + txtMota.Text + "' WHERE MaBTC= '" + txtMaBTC.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa dòng này không?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM dbo.BoTieuChi WHERE MaBTC ='" + txtMaBTC.Text + "'";
                command.ExecuteNonQuery();
                loadData();
            }
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaBTC.Text = "";
            txtTenBTC.Text = "";
            txtMota.Text = "";
            txtMaBTC.ReadOnly = false;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
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
                worksheet.Name = "Bộ tiêu chí";

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
            if (radioButtonMaBTC.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaBTC AS N'Mã bộ tiêu chí', TenBTC AS N'Tên bộ tiêu chí', Mota AS N'Mô tả' FROM BoTieuChi WHERE MaBTC LIKE '%" + textBox1.Text + "%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_MaBTC.Clear();
                dataAdapter.Fill(table_search_MaBTC);
                dgv.DataSource = table_search_MaBTC;
            }
            else if (radioButtonTenBTC.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaBTC AS N'Mã bộ tiêu chí', TenBTC AS N'Tên bộ tiêu chí', Mota AS N'Mô tả' FROM BoTieuChi WHERE TenBTC LIKE N'%" + textBox1.Text + "%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_TenBTC.Clear();
                dataAdapter.Fill(table_search_TenBTC);
                dgv.DataSource = table_search_TenBTC;
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            loadData();
        }
    }
}
