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
    public partial class Phong_Ban : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-IQ04FMD\SQLEXPRESS;Initial Catalog=NamViet;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table_MaPB = new DataTable();
        DataTable table_TenPB = new DataTable();

        //load du lieu ra gridView
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT MaPB AS N'Mã phòng ban', TenPB AS N'Tên phòng ban' FROM dbo.PhongBan";
            dataAdapter.SelectCommand = command;
            table.Clear();
            dataAdapter.Fill(table);
            dgv.DataSource = table;
        }

        public Phong_Ban()
        {
            InitializeComponent();
        }

        private void Phong_Ban_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txt_MaPB.ReadOnly = true;
            i = dgv.CurrentRow.Index;
            txt_MaPB.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txt_TenPB.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO PhongBan VALUES(N'"+txt_MaPB.Text+"', N'"+txt_TenPB.Text+"')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this line?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM PhongBan WHERE MaPB='" + txt_MaPB.Text + "'";
                command.ExecuteNonQuery();
                loadData();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE PhongBan SET TenPB=N'"+txt_TenPB.Text+"' WHERE MaPB='"+txt_MaPB.Text+"'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btn_khoiTao_Click(object sender, EventArgs e)
        {
            txt_MaPB.Text = "";
            txt_TenPB.Text = "";
            txt_MaPB.ReadOnly = false;
        }

        //private void btn_Search_Click(object sender, EventArgs e)
        //{
          //  new Search_ChucVu().Show();
        //}

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            if (raBtn_MaPB.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaPB AS N'Mã phòng ban', TenPB AS N'Tên phòng ban' FROM dbo.PhongBan WHERE MaPB = N'" + txt_search.Text+"'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_MaPB.Clear();
                dataAdapter.Fill(table_MaPB);
                dgv.DataSource = table_MaPB;
            }
            else if (raBtn_TenPB.Checked == true)
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaPB AS N'Mã phòng ban', TenPB AS N'Tên phòng ban' FROM dbo.PhongBan WHERE TenPB LIKE N'%" + txt_search.Text+"%'";
                //command.ExecuteNonQuery();
                //loadData();
                dataAdapter.SelectCommand = command;
                table_TenPB.Clear();
                dataAdapter.Fill(table_TenPB);
                dgv.DataSource = table_TenPB;
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
                txt_search.Text = "";
                loadData();
        }
    }
}
