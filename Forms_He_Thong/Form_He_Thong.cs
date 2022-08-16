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
    public partial class Form_He_Thong : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form_He_Thong()
        {
            InitializeComponent();
            random = new Random();
        }

        //Method
        private Color selectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = selectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Phong_Ban(), sender);
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Chuc_Vu(), sender);
        }

        private void btnKeHoach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Ke_Hoach(), sender);
        }

        private void btnDotDanhGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dot_Danh_gia(), sender);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the program?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                //ActiveButton(sender);
                //new fLogin().Show();
                //FormMain().Hide();
                this.Hide();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            new fLogin().Show();
            this.Hide();
        }
    }
}
