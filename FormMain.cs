using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            FormMainLoad f = new FormMainLoad();
            addForm(f);
        }

        private void addForm(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void heThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_He_Thong f = new Form_He_Thong();
            addForm(f);
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms_Quan_Ly.Form_Quan_Ly f = new Forms_Quan_Ly.Form_Quan_Ly();
            addForm(f);
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the program?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                new fLogin().Show();
                this.Hide();
            }
        }

        private void baoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Bao_cao.Form_Bao_cao f = new Form_Bao_cao.Form_Bao_cao();
            addForm(f);
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Navisoft.Form_Doi_MK f = new Navisoft.Form_Doi_MK();
            addForm(f);
        }
    }
}
