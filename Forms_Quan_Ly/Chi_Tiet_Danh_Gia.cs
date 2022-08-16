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
    public partial class Chi_Tiet_Danh_Gia : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-IQ04FMD\SQLEXPRESS;Initial Catalog=NamViet;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table_search_MaBTC = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaTC AS N'Mã tiêu chí', MaBTC AS N'Mã bộ tiêu chí', TrongSo AS N'Trọng số' FROM CT_BTC_TC";
            dataAdapter.SelectCommand = command;
            table.Clear();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
        }

        void loadCommoBox()
        {
            //combo box MaCV:
            var cmd1 = new SqlCommand("SELECT * FROM dbo.TieuChi", connection);
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            comboBox_MaTC.DisplayMember = "MaTC";
            comboBox_MaTC.DataSource = dt1;
            //combobox MaPB:
            var cmd2 = new SqlCommand("SELECT * FROM dbo.BoTieuChi", connection);
            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            comboBoxMaBTC.DisplayMember = "MaBTC";
            comboBoxMaBTC.DataSource = dt2;
        }

        public Chi_Tiet_Danh_Gia()
        {
            InitializeComponent();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            comboBox_MaTC.Text = dgv.Rows[i].Cells[0].Value.ToString();
            comboBoxMaBTC.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtTrongSo.Text = dgv.Rows[i].Cells[2].Value.ToString();
        }

        private void Chi_Tiet_Danh_Gia_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            loadCommoBox();
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
                worksheet.Name = "Chi tiết đánh giá";

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.CT_BTC_TC(MaTC, MaBTC, TrongSo) VALUES( N'" + comboBox_MaTC.Text + "', N'" + comboBoxMaBTC.Text + "', N'" + txtTrongSo.Text + "')";
            command.ExecuteNonQuery();
            loadData();
            loadCommoBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE CT_BTC_TC SET MaTC = N'" + comboBox_MaTC.Text + "', MaBTC='" + comboBoxMaBTC.Text + "', TrongSo='" + txtTrongSo.Text + "' WHERE MaTC='" + comboBox_MaTC.Text + "' AND MaBTC = '"+comboBoxMaBTC.Text+"'";
            command.ExecuteNonQuery();
            loadData();
            loadCommoBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa dòng này không?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM dbo.Nhanvien WHERE MaTC ='" + comboBox_MaTC.Text + "' AND MaBTC = '"+comboBoxMaBTC.Text+"'";
                command.ExecuteNonQuery();
                loadData();
                loadCommoBox();
            }
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            comboBox_MaTC.Text = "";
            comboBoxMaBTC.Text = "";
            txtTrongSo.Text = "";
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTimMaCTDG.Text = "";
            loadData();
            loadCommoBox();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaTC AS N'Mã tiêu chí', MaBTC AS N'Mã bộ tiêu chí', TrongSo AS N'Trọng số' FROM CT_BTC_TC WHERE MaTC LIKE '%" + txtTimMaCTDG.Text + "%'";
            //command.ExecuteNonQuery();
            //loadData();
            dataAdapter.SelectCommand = command;
            table_search_MaBTC.Clear();
            dataAdapter.Fill(table_search_MaBTC);
            dgv.DataSource = table_search_MaBTC;
        }
    }
}
