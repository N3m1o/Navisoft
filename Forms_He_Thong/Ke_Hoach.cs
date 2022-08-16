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
    public partial class Ke_Hoach : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-IQ04FMD\SQLEXPRESS;Initial Catalog=NamViet;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table_search_MaKH = new DataTable();
        DataTable table_search_MaDDG = new DataTable();
        DataTable table_search_MaNV = new DataTable();
        DataTable table_search_MaTC = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaKH AS N'Mã kế hoạch', MaBTC AS N'Mã bộ tiêu chí', MaDDG AS N'Mã đợt đánh giá', MaNV AS N'Mã nhân viên', KeHoachDatRa AS N'Kế hoạch đặt ra' FROM KeHoach";
            dataAdapter.SelectCommand = command;
            table.Clear();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
        }

        void loadCommoBox()
        {
            //combo box MaDDG:
            var cmd1 = new SqlCommand("SELECT * FROM dbo.Dotdanhgia", connection);
            var dr = cmd1.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBox_MaDDG.DisplayMember = "MaDDG";
            comboBox_MaDDG.DataSource = dt;
            //combobox MaNV:
            var cmd2 = new SqlCommand("SELECT * FROM dbo.Nhanvien", connection);
            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            comboBox_MaNV.DisplayMember = "MaNV";
            comboBox_MaNV.DataSource = dt2;
            //combo box MaTC:
            var cmd3 = new SqlCommand("SELECT * FROM dbo.BoTieuChi", connection);
            var dr3 = cmd3.ExecuteReader();
            var dt3 = new DataTable();
            dt3.Load(dr3);
            dr3.Dispose();
            comboBox_MaBTC.DisplayMember = "MaBTC";
            comboBox_MaBTC.DataSource = dt3;
        }

        void loadCommoBoxForSearch()
        {
            //combo box MaDDG:
            var cmd4 = new SqlCommand("SELECT * FROM dbo.Dotdanhgia", connection);
            var dr4 = cmd4.ExecuteReader();
            var dt4 = new DataTable();
            dt4.Load(dr4);
            dr4.Dispose();
            comboBox_MaDotDanhGia.DisplayMember = "MaDDG";
            comboBox_MaDotDanhGia.DataSource = dt4;
            //combobox MaNV:
            var cmd5 = new SqlCommand("SELECT * FROM dbo.Nhanvien", connection);
            var dr5 = cmd5.ExecuteReader();
            var dt5 = new DataTable();
            dt5.Load(dr5);
            dr5.Dispose();
            comboBox_MaNhanVien.DisplayMember = "MaNV";
            comboBox_MaNhanVien.DataSource = dt5;
            //combo box MaTC:
            var cmd6 = new SqlCommand("SELECT * FROM dbo.TieuChi", connection);
            var dr6 = cmd6.ExecuteReader();
            var dt6 = new DataTable();
            dt6.Load(dr6);
            dr6.Dispose();
            comboBox_MaTieuChi.DisplayMember = "MaBTC";
            comboBox_MaTieuChi.DataSource = dt6;
        }

        public Ke_Hoach()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txt_MaKH.ReadOnly = true;
            i = dgv.CurrentRow.Index;
            txt_MaKH.Text = dgv.Rows[i].Cells[0].Value.ToString();
            comboBox_MaDDG.Text = dgv.Rows[i].Cells[1].Value.ToString();
            comboBox_MaNV.Text = dgv.Rows[i].Cells[2].Value.ToString();
            comboBox_MaBTC.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txt_KeHoachDatRa.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void Ke_Hoach_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            loadCommoBox();
            loadCommoBoxForSearch();

            comboBox_MaTieuChi.Text = "";
            comboBox_MaNhanVien.Text = "";
            comboBox_MaDotDanhGia.Text = "";
        }

        private void comboBox_MaDDG_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.KeHoach VALUES(N'" + txt_MaKH.Text + "', N'" + comboBox_MaBTC.Text + "', N'" + comboBox_MaDDG.Text + "', N'" + comboBox_MaNV.Text + "', N'"+txt_KeHoachDatRa.Text+"')";
            command.ExecuteNonQuery();
            loadData();
            loadCommoBox();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE KeHoach SET MaBTC='" + comboBox_MaBTC.Text + "', MaDDG='" + comboBox_MaDDG.Text + "', MaNV='" + comboBox_MaNV.Text + "', KeHoachDatRa=N'" + txt_KeHoachDatRa.Text+ "' WHERE MaKH= N'" + txt_MaKH.Text + "'";
            command.ExecuteNonQuery();
            loadData();
            loadCommoBox();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this line?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM KeHoach WHERE MaKH='" + txt_MaKH.Text + "'";
                command.ExecuteNonQuery();
                loadData();
                loadCommoBox();
            }
        }

        private void btn_KhoiTao_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = "";
            comboBox_MaDDG.Text = "";
            comboBox_MaNV.Text = "";
            comboBox_MaBTC.Text = "";
            txt_KeHoachDatRa.Text = "";
            txt_MaKH.ReadOnly = false;
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
                txt_Search.Text = "";
                loadData();
                loadCommoBoxForSearch();
                comboBox_MaTieuChi.Text = "";
                comboBox_MaNhanVien.Text = "";
                comboBox_MaDotDanhGia.Text = "";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //loadCommoBoxForSearch();
            if (raBtn_MaKH.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaKH AS N'Mã kế hoạch', MaDDG AS N'Mã đợt đánh giá', MaNV AS N'Mã nhân viên', MaBTC AS N'Mã tiêu chí', KeHoachDatRa AS N'Kế hoạch đặt ra' FROM dbo.KeHoach WHERE MaKH LIKE '%" + txt_Search.Text+"%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_MaKH.Clear();
                dataAdapter.Fill(table_search_MaKH);
                dgv.DataSource = table_search_MaKH;
            }
            else if (comboBox_MaDotDanhGia.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaKH AS N'Mã kế hoạch', MaDDG AS N'Mã đợt đánh giá', MaNV AS N'Mã nhân viên', MaBTC AS N'Mã tiêu chí', KeHoachDatRa AS N'Kế hoạch đặt ra' FROM dbo.KeHoach WHERE MaDDG = '" + comboBox_MaDotDanhGia.Text + "'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_MaDDG.Clear();
                dataAdapter.Fill(table_search_MaDDG);
                dgv.DataSource = table_search_MaDDG;
            }
            else if (comboBox_MaNhanVien.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaKH AS N'Mã kế hoạch', MaDDG AS N'Mã đợt đánh giá', MaNV AS N'Mã nhân viên', MaBTC AS N'Mã tiêu chí', KeHoachDatRa AS N'Kế hoạch đặt ra' FROM dbo.KeHoach WHERE MaNV = '" + comboBox_MaNhanVien.Text + "'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_MaNV.Clear();
                dataAdapter.Fill(table_search_MaNV);
                dgv.DataSource = table_search_MaNV;
            }
            else if (comboBox_MaTieuChi.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaKH AS N'Mã kế hoạch', MaDDG AS N'Mã đợt đánh giá', MaNV AS N'Mã nhân viên', MaBTC AS N'Mã tiêu chí', KeHoachDatRa AS N'Kế hoạch đặt ra' FROM dbo.KeHoach WHERE MaBTC = '" + comboBox_MaTieuChi.Text + "'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_search_MaTC.Clear();
                dataAdapter.Fill(table_search_MaTC);
                dgv.DataSource = table_search_MaTC;
            }
        }
    }
}
