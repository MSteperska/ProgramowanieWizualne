using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int index;
        int row_counter = 0;
        public Book book1 = new Book();
        public List<Book> Book_list;

        //save and load 
        private SaveFileDialog sfd;
        private OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
        }
               
        public void Set_data()
        {
            Book_list.Add(book1);
            dataGridView1.Rows.Add(book1);
            //dataGridView1.Rows.Add(title, author, genres, stars, price);
            row_counter++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            if(row_counter != 0)
            {
                dataGridView1.Rows.RemoveAt(index);
                row_counter--;
            }
            
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            sfd = new SaveFileDialog();
            sfd.Filter = ".csv | .csv"; // czy to będzie działać, co jest przed |?
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName; //tu zapisuje się ścieżka do pliku
                this.dataGridView1.SelectAll();
                string full_text = "";
                
                if (!File.Exists(path))
                {
                    for(int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        for(int i = 0; i < 5; i++)
                        {
                            full_text += dataGridView1.Rows[j].Cells[i].Value.ToString(); 
                            if(i == 4) {
                                continue;
                            }
                            else {
                                full_text += ",";
                            }
                            
                        }
                        if(j == dataGridView1.RowCount - 1) {
                            continue;
                        }
                        else { 
                            full_text += Environment.NewLine;
                        }
                        
                        
                    }
                    File.WriteAllText(path, full_text);
                }


            }
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            string title = "";
            string author = "";
            string genres = "";
            string stars = "";
            string price = "";
            ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName; //ścieżka do pliku 
                foreach(string line in System.IO.File.ReadLines(path))
                {
                    string[] data = line.Split(',');
                    title = data[0];
                    author = data[1];
                    genres = data[2];
                    stars = data[3];
                    price = data[4];
                    dataGridView1.Rows.Add(title, author, genres, stars, price);
                    row_counter++;
                }
               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this);
            form.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
