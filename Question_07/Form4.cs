using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_07
{
    public partial class Form4 : Form
    {
        preprocessing p = new preprocessing();
        OpenFileDialog ofd = new OpenFileDialog();

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.LoadOriginalImage3(ofd.FileName);
            pictureBox1.ImageLocation = "7a.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.LoadMaskImage3();
            pictureBox2.ImageLocation = "MaskOutputImage.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.OROperator3();
            pictureBox3.ImageLocation = "LOGO.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
