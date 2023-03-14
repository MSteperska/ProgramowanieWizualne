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
        double cena2 = 0;
        double cena3 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void GetPrice2(double price)
        {
            cena2 = price;
        }

        public void GetPrice3(double price)
        {
            cena3 = price;
        }
        public void SetPrice()
        {
            double price = cena2 + cena3;
            label1.Text = price.ToString();
        }
        
                      
        private void button1_Click_1(object sender, EventArgs e) //komputer
        {
            Form2 form= new Form2(this);
            form.ShowDialog();
        }

       
        private void button3_Click(object sender, EventArgs e) //monitor
        {
            Form3 form = new Form3(this);
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e) 
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
