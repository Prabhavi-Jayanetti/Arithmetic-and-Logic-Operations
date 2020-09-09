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
    public partial class Form3 : Form
    {
        preprocessing p = new preprocessing();

        OpenFileDialog ofd = new OpenFileDialog();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.LoadOriginalImage1(ofd.FileName);
            pictureBox1.ImageLocation = "BinaryImage.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.LoadMaskImage1();
            pictureBox2.ImageLocation = "MaskOutputImage2.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.Addition();
            pictureBox3.ImageLocation = "ADD.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.AddWeight();
            pictureBox4.ImageLocation = "ADDweight.png";
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
