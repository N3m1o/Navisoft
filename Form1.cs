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

namespace Test_1
{
    public partial class fLogin : Form
    {
        SqlCommand command;
        SqlConnection connection;
        string str = "";
        SqlDataAdapter adapter = new SqlDataAdapter();
        FormClosingEventArgs a;

        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Phuong" && txtPassword.Text == "123456")
            {
                new FormMain().Show();
                this.Hide();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "") {
                MessageBox.Show("Please enter your username and password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect, try again", "Oooppp!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the program?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
