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
    public partial class Dot_Danh_gia : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-IQ04FMD\SQLEXPRESS;Initial Catalog=NamViet;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table_MaDDG = new DataTable();
        DataTable table_TenDDG = new DataTable();

        void loadDataDotDanhGia()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaDDG AS N'Mã đợt đánh giá', TenDDG AS N'Tên đợt đánh giá', Thang AS N'Tháng', Nam AS N'Năm' FROM DotDanhGia";
            dataAdapter.SelectCommand = command;
            table.Clear();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
        }

        public Dot_Danh_gia()
        {
            InitializeComponent();
        }

        private void Dot_Danh_gia_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadDataDotDanhGia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Dotdanhgia VALUES(N'" + txt_MaDDG.Text + "', N'" + txt_TenDDG.Text + "', N'" + txt_Thang.Text + "', N'" + txt_Nam.Text + "')";
            command.ExecuteNonQuery();
            loadDataDotDanhGia();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txt_MaDDG.ReadOnly = true;
            i = dgv.CurrentRow.Index;
            txt_MaDDG.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txt_TenDDG.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txt_Thang.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txt_Nam.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE Dotdanhgia SET TenDDG='" + txt_TenDDG.Text + "', Thang='" + txt_Thang.Text + "', Nam='" + txt_Nam.Text + "' WHERE MaDDG='" + txt_MaDDG.Text + "'";
            command.ExecuteNonQuery();
            loadDataDotDanhGia();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this line?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Dotdanhgia WHERE MaDDG='" + txt_MaDDG.Text + "'";
                command.ExecuteNonQuery();
                loadDataDotDanhGia();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_MaDDG.Text = "";
            txt_MaDDG.ReadOnly = false;
            txt_TenDDG.Text = "";
            txt_Thang.Text = "";
            txt_Nam.Text = "";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (raBtn_MaDDG.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaDDG AS N'Mã đợt đánh giá', TenDDG AS N'Tên đợt đánh giá', Thang AS N'Tháng', Nam AS N'Năm' FROM dbo.Dotdanhgia WHERE MaDDG LIKE '%"+txt_Search.Text+"%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_MaDDG.Clear();
                dataAdapter.Fill(table_MaDDG);
                dgv.DataSource = table_MaDDG;
            }
            else if (raBtn_TenDDG.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaDDG AS N'Mã đợt đánh giá', TenDDG AS N'Tên đợt đánh giá', Thang AS N'Tháng', Nam AS N'Năm' FROM dbo.Dotdanhgia WHERE TenDDG LIKE N'%"+txt_Search.Text+"%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_TenDDG.Clear();
                dataAdapter.Fill(table_TenDDG);
                dgv.DataSource = table_TenDDG;
            }
        }
    }
}
