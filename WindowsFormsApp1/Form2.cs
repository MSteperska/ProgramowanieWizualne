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
        DateTime start;
        TimeSpan ts;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start = new DateTime(DateTime.Now.Ticks);
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
    
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            ts = DateTime.Now - start;
            label2.Text = ts.ToString();
        }
    }
    
}
