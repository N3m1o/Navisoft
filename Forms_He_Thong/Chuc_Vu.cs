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

namespace Test_1.Forms
{
    public partial class Chuc_Vu : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-IQ04FMD\SQLEXPRESS;Initial Catalog=NamViet;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table_search_MaCV = new DataTable();
        DataTable table_search_TenCV = new DataTable();

        void loadDataChucVu()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaCV AS N'Mã chức vụ', TenCV AS N'Tên chức vụ', MoTa AS N'Mô tả', MaBTC as N'Mã bộ tiêu chí' FROM NamViet.dbo.ChucVu";
            dataAdapter.SelectCommand = command;
            table.Clear();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
        }

        void loadCommoBox()
        {
            //combo box MaCV:
            var cmd1 = new SqlCommand("SELECT * FROM dbo.BoTieuChi", connection);
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            comboBox_MaBTC.DisplayMember = "MaBTC";
            comboBox_MaBTC.DataSource = dt1;
        }
        public Chuc_Vu()
        {
            InitializeComponent();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txt_MaCV.ReadOnly = true;
            i = dgv.CurrentRow.Index;
            txt_MaCV.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txt_TenCV.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txt_Diengiai.Text = dgv.Rows[i].Cells[2].Value.ToString();
            comboBox_MaBTC.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void groupBox_ThongTinChucVu_Enter(object sender, EventArgs e)
        {

        }

        private void Chuc_Vu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadDataChucVu();
            loadCommoBox();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO ChucVu VALUES(N'" + txt_MaCV.Text + "', N'" + txt_TenCV.Text + "', N'" + txt_Diengiai.Text + "', N'"+comboBox_MaBTC.Text+"')";
            command.ExecuteNonQuery();
            loadDataChucVu();
            loadCommoBox();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE ChucVu SET TenCV=N'" + txt_TenCV.Text + "', MoTa=N'" + txt_Diengiai.Text + "', MaBTC = N'"+comboBox_MaBTC.Text+"' WHERE MaCV='" + txt_MaCV.Text + "'";
            command.ExecuteNonQuery();
            loadDataChucVu();
            loadCommoBox();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this line?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM ChucVu WHERE MaCV='" + txt_MaCV.Text + "'";
                command.ExecuteNonQuery();
                loadDataChucVu();
            }
        }

        private void btn_KhoiTao_Click(object sender, EventArgs e)
        {
            txt_MaCV.Text = "";
            txt_TenCV.Text = "";
            txt_Diengiai.Text = "";
            comboBox_MaBTC.Text = "";
            txt_MaCV.ReadOnly = false;
            loadCommoBox();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            loadDataChucVu();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (radioButton_MaCV.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT TenCV AS N'Tên chức vụ', MoTa AS N'Mô tả', MaBTC as N'Mã bộ tiêu chí' FROM dbo.ChucVu WHERE MaCV = N'" + txt_Search.Text + "'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_MaCV.Clear();
                dataAdapter.Fill(table_search_MaCV);
                dgv.DataSource = table_search_MaCV;
            }
            else if (radioButton_TenCV.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT TenCV AS N'Tên chức vụ', MoTa AS N'Mô tả', MaBTC as N'Mã bộ tiêu chí' FROM dbo.ChucVu WHERE TenCV LIKE N'%" + txt_Search.Text + "%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_TenCV.Clear();
                dataAdapter.Fill(table_search_TenCV);
                dgv.DataSource = table_search_TenCV;
            }
        }
    }
}
