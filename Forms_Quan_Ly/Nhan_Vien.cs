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
    public partial class Nhan_Vien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-IQ04FMD\SQLEXPRESS;Initial Catalog=NamViet;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table_search_MaNV = new DataTable();
        DataTable table_search_TenNV = new DataTable();

        void loadDataNhanVien()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaNV AS N'Mã nhân viên', MaCV AS N'Mã chức vụ', MaPB AS N'Mã phòng ban', TenNV AS N'Tên nhân viên', Ngaysinh AS N'Ngày sinh', DiaChi AS N'Địa chỉ', Sdt AS N'Số điện thoại', Dinhchi AS N'Đình chỉ', NgayBD AS N'Ngày bắt đầu', NgayKT AS N'Ngày kết thúc' FROM NhanVien";
            dataAdapter.SelectCommand = command;
            table.Clear();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
        }
        public Nhan_Vien()
        {
            InitializeComponent();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txtMaNV.ReadOnly = true;
            i = dgv.CurrentRow.Index;
            txtMaNV.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgv.Rows[i].Cells[3].Value.ToString();
            comboBoxCongViec.Text = dgv.Rows[i].Cells[1].Value.ToString();
            comboBoxPhongBan.Text = dgv.Rows[i].Cells[2].Value.ToString();
            dateTimePickerNgayBD.Text = dgv.Rows[i].Cells[8].Value.ToString();
            dateTimePickerNgayKT.Text = dgv.Rows[i].Cells[9].Value.ToString();
            dateSinhNhat.Text = dgv.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dgv.Rows[i].Cells[5].Value.ToString();
            txtSoDienThoai.Text = dgv.Rows[i].Cells[6].Value.ToString();
            txtDinhChi.Text = dgv.Rows[i].Cells[7].Value.ToString();
        }

        private void Nhan_Vien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadDataNhanVien();
            loadCommoBox();
        }

        void loadCommoBox()
        {
            //combo box MaCV:
            var cmd1 = new SqlCommand("SELECT * FROM dbo.ChucVu", connection);
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            comboBoxCongViec.DisplayMember = "MaCV";
            comboBoxCongViec.DataSource = dt1;
            //combobox MaPB:
            var cmd2 = new SqlCommand("SELECT * FROM dbo.PhongBan", connection);
            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            comboBoxPhongBan.DisplayMember = "MaPB";
            comboBoxPhongBan.DataSource = dt2;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.Nhanvien(TenNV, MaCV, NgayBD, NgayKT, MaPB, Ngaysinh, DiaChi, Sdt, Dinhchi) VALUES(N'"+txtTenNV.Text+"', N'"+comboBoxCongViec.Text+"', '"+dateTimePickerNgayBD.Text+"', '"+dateTimePickerNgayKT.Text+"', N'"+comboBoxPhongBan.Text+"', N'"+dateSinhNhat.Text+"', N'"+txtDiaChi.Text+"', N'"+txtSoDienThoai.Text+"', N'"+txtDinhChi.Text+"')";
            command.ExecuteNonQuery();
            loadDataNhanVien();
            loadCommoBox();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            comboBoxCongViec.Text = "";
            comboBoxPhongBan.Text = "";
            dateTimePickerNgayBD.Text = "";
            dateTimePickerNgayKT.Text = "";
            dateSinhNhat.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtDinhChi.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "UPDATE Nhanvien SET TenNV = N'" + txtTenNV.Text + "', MaCV='" + comboBoxCongViec.Text + "', NgayBD='" + dateTimePickerNgayBD.Text + "', NgayKT= '" + dateTimePickerNgayKT.Text + "', DiaChi = N'"+txtDiaChi.Text+ "', MaPB = N'"+comboBoxPhongBan.Text+ "', Ngaysinh = N'"+dateSinhNhat.Text+"', Sdt = N'"+txtSoDienThoai.Text+"', Dinhchi = N'"+txtDinhChi.Text+"' WHERE MaNV='" + txtMaNV.Text + "'";
            command.ExecuteNonQuery();
            loadDataNhanVien();
            loadCommoBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa dòng này không?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM dbo.Nhanvien WHERE MaNV ='" + txtMaNV.Text + "'";
                command.ExecuteNonQuery();
                loadDataNhanVien();
                loadCommoBox();
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            loadDataNhanVien();
            loadCommoBox();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radioButtonMaNV.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaNV AS N'Mã nhân viên', MaCV AS N'Mã chức vụ', MaPB AS N'Mã phòng ban', TenNV AS N'Tên nhân viên', Ngaysinh AS N'Ngày sinh', DiaChi AS N'Địa chỉ', Sdt AS N'Số điện thoại', Dinhchi AS N'Đình chỉ', NgayBD AS N'Ngày bắt đầu', NgayKT AS N'Ngày kết thúc' FROM NhanVien INNER JOIN dbo.ChucVu ON ChucVu.MaCV = Nhanvien.MaCV INNER JOIN dbo.PhongBan ON PhongBan.MaPB = Nhanvien.MaPB WHERE MaNV LIKE '%" + textBox1.Text+"%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_MaNV.Clear();
                dataAdapter.Fill(table_search_MaNV);
                dgv.DataSource = table_search_MaNV;
            }
            else if (radioButtonTenNV.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaNV AS N'Mã nhân viên', MaCV AS N'Mã chức vụ', MaPB AS N'Mã phòng ban', TenNV AS N'Tên nhân viên', Ngaysinh AS N'Ngày sinh', DiaChi AS N'Địa chỉ', Sdt AS N'Số điện thoại', Dinhchi AS N'Đình chỉ', NgayBD AS N'Ngày bắt đầu', NgayKT AS N'Ngày kết thúc' FROM NhanVien INNER JOIN dbo.ChucVu ON ChucVu.MaCV = Nhanvien.MaCV INNER JOIN dbo.PhongBan ON PhongBan.MaPB = Nhanvien.MaPB WHERE TenNV LIKE N'%" + textBox1.Text+"%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_TenNV.Clear();
                dataAdapter.Fill(table_search_TenNV);
                dgv.DataSource = table_search_TenNV;
            }
        }

        private void btn_KetXuat_Click(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
    }
}
