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
    public partial class Form2 : Form
    {
        preprocessing p = new preprocessing();
        OpenFileDialog ofd = new OpenFileDialog();

        public Form2()
        {
            InitializeComponent();
        }

        // Load Image
        private void button1_Click(object sender, EventArgs e)
        {
            p.LoadOriginalImage(ofd.FileName);
            pictureBox1.ImageLocation = "BinaryImage.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Create  Mask Image for Orginal image
            p.LoadMaskImage();
            pictureBox2.ImageLocation = "MaskOutputImage.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            p.ANDOperator();
            pictureBox3.ImageLocation = "AND.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            p.OROperator();
            pictureBox3.ImageLocation = "OR.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            p.NOTOperator();
            pictureBox3.ImageLocation = "NOT.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            p.XOROperator();
            pictureBox3.ImageLocation = "XOR.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
