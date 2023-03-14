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
    public partial class Form3 : Form
    {
        int previd = -1;
        Form1 seriookienko;
        double cena = 0;
        double[] ceny = { 10, 20, 30, 40 };
        public Form3(Form1 okienko1)
        {
            InitializeComponent();
            seriookienko = okienko1;
            // seriookienko.SetPrice(); <- wywoływanie 
        }

        public Form3()
        {
            InitializeComponent();
            
                
        }
        public void SetPrice(double price)
        {
            label1.Text = price.ToString();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                cena = 0;
                for(int i = 0; i < listView1.SelectedIndices.Count; i++)
                {
                    cena += ceny[listView1.SelectedIndices[i]];
                }
                
                label1.Text = cena.ToString();
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seriookienko.GetPrice3(cena);
            seriookienko.SetPrice();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
