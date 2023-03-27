using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Form1;

namespace WindowsFormsApp1
{
    
    public partial class Form2 : Form
    {
        Form1 okno;
        string title, author, genres, stars, price;
        

        public Form2(Form1 serio_okno)
        {
            InitializeComponent();
            okno = serio_okno;
        }
                
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Author_text_TextChanged(object sender, EventArgs e)
        {
            //author = Author_text.Text;
            okno.book1.author = Author_text.Text; //cała ścieżka 
        }

        private void Genres_text_TextChanged(object sender, EventArgs e)
        {
            //genres = Genres_text.Text;
            okno.book1.genres = Genres_text.Text;
        }

        private void Stars_text_TextChanged(object sender, EventArgs e)
        {
            okno.book1.stars = Stars_text.Text;
        }

        private void Price_text_TextChanged(object sender, EventArgs e)
        {
            okno.book1.price = Price_text.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            okno.book1.title = Title_text.Text;
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {

            okno.Set_data();
            this.Close();
        }

        private void Return_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
