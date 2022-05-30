using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Music_Cognitive
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loadCaptchaImage();
            tb_Privacy_Policy.Text = "This is a Privacy Policy This is a Privacy Policy This is a Privacy Policy ";
        }
        int captcha_num = 0;

        private void loadCaptchaImage()
        {
            Random ran = new Random();
            captcha_num = ran.Next(1000, 10000);
            var image = new Bitmap(this.pb_Captcha.Width, this.pb_Captcha.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(captcha_num.ToString(), font, Brushes.Green, new Point(0, 0));
            pb_Captcha.Image = image;
        }

        private void btn_Refresh_Captcha_Click(object sender, EventArgs e)
        {
            loadCaptchaImage();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if(tb_Captcha.Text == captcha_num.ToString())
            {
                MessageBox.Show("Valid Captcha");
            }
            else
            {
                MessageBox.Show("Try Again !!!");
            }
            if(!cb_Privacy_Policy.Checked)
            {
                MessageBox.Show("Read Privacy Policy");
            }
            loadCaptchaImage();
        }
    }
}
