using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 seriookienko;
        double cena = 0;
        double cena_dysk = 0;
        double cena_dodatki = 0;
        double cena_karta = 0;
        double[] ceny_kart = { 25, 35, 45, 50 };
        public Form2(Form1 okienko1)
        {
            InitializeComponent();
            seriookienko = okienko1;
           // seriookienko.SetPrice(); <- wywoływanie 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
    
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            seriookienko.GetPrice2(cena);
            seriookienko.SetPrice();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          if (radioButton1.Checked) {
                cena += 100;
                cena_dysk = 100;
            }
            label4_Click(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cena += 150;
                cena_dysk = 150;
            }
            label4_Click(sender, e);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                cena += 200;
                cena_dysk = 200;
            }
            label4_Click(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cena += 84;
                cena_dodatki = cena_dodatki + 84;
            }
            else
            {
                cena_dodatki = cena_dodatki - 84;
            }
            label4_Click(sender, e);
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                cena += 125;
                cena_dodatki =cena_dodatki + 125;
            }
            else
            {
                cena_dodatki = cena_dodatki - 125;
            }
            label4_Click(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                cena += 199;
                cena_dodatki =cena_dodatki + 199;
            }
            else
            {
                cena_dodatki = cena_dodatki - 199;
            }
            label4_Click(sender, e);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked)
            {
                cena += 219;
                cena_dodatki = cena_dodatki + 219;
            }
            else
            {
                cena_dodatki = cena_dodatki - 219;
            }
            label4_Click(sender, e);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                cena += 99;
                cena_dodatki = cena_dodatki + 99;
                
            }
            else 
            { 
                cena_dodatki = cena_dodatki - 99;
            }
            label4_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            cena = (cena_dysk + cena_dodatki + cena_karta);
            label4.Text = cena.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cena_karta = ceny_kart[comboBox1.SelectedIndex];
            label4_Click(sender, e);  
        }
    }
    
}
