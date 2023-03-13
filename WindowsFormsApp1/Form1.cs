using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetPrice(double price)
        {
            label1.Text = price.ToString();
        }
                      
        private void button1_Click_1(object sender, EventArgs e) //komputer
        {
            Form2 form= new Form2(this);
            form.ShowDialog();
        }

       
        private void button3_Click(object sender, EventArgs e) //monitor
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e) 
        {
           
        }
    }
}
