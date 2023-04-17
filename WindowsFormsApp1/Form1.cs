using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName; //ścieżka do pliku
                bmp = new Bitmap(path);
                pictureBox1.Image = bmp;
            }
        }

        private void rotate_button_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = bmp;
            }
                      
        }

        private void mirror1_button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Image = bmp;
            }
        }

        private void mirror2_button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Image = bmp;
            }
        }
    }
}
