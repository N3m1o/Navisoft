using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1.Forms_Quan_Ly
{
    public partial class Form_Quan_Ly : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form_Quan_Ly()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color selectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
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
                if (currentButton != (Button)btnSender)
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
            foreach (Control previousBtn in panelMenu.Controls)
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
            if (activeForm != null)
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
            label2.Text = childForm.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms_Quan_Ly.Nhan_Vien(), sender);
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms_Quan_Ly.Danh_Gia(), sender);
        }

        private void btnBoTieuChi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms_Quan_Ly.Bo_Tieu_Chi(), sender);
        }

        private void btnTieuChi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms_Quan_Ly.Tieu_Chi(), sender);
        }

        private void btnChiTietDanhGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms_Quan_Ly.Chi_Tiet_Danh_Gia(), sender);
        }

        private void Form_Quan_Ly_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            new fLogin().Show();
        }
    }
}
