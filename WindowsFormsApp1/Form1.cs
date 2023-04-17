using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private Bitmap bmp;       

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
                string path = ofd.FileName;
                bmp = new Bitmap(path);
                pictureBox1.Image = bmp;
            }
        }

        private void onlygreen_button_Click(object sender, EventArgs e)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            int r, g, b, a;
            Color col;

            for(int x = 0; x < width; x++) { 
                for(int y = 0; y < height; y++) {
                    col = bmp.GetPixel(x, y);
                    r = col.R;
                    g = col.G;
                    b = col.B;
                    a = col.A;
                    if(r <= 0.70*g && b <= 0.70*g)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                    }
                }
            }
            pictureBox1.Image = bmp;

        }

        private void negatyw_button_Click(object sender, EventArgs e)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            int r, g, b, a;
            Color col;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    col = bmp.GetPixel(x, y);
                    r = col.R;
                    g = col.G;
                    b = col.B;
                    a = col.A;
                    bmp.SetPixel(x, y, Color.FromArgb(255 - a, 255 - r, 255 - g, 255 - b));
                }
            }
            pictureBox1.Image = bmp;
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
