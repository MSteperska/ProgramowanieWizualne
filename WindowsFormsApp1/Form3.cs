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
        string text = "";
        Form1 form;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            form = form1;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
        }
        
        private void Search3_button_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < form.Book_list.Count; i++)
            {
                
                    if (form.Book_list[i].title.Contains(text) || form.Book_list[i].author.Contains(text)
                        || form.Book_list[i].genres.Contains(text) || form.Book_list[i].stars.Contains(text)
                         || form.Book_list[i].price.Contains(text))
                    {
                        dataGridView2.Rows.Add(form.Book_list[i]);
                    }             
                
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
