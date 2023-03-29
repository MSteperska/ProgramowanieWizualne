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
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    [Serializable]
    public partial class Form1 : Form
    {
        int index;
        int row_counter = 0;
        public Book book1 = new Book();
        public List<Book> Book_list = new List<Book> ();

        //save and load 
        private SaveFileDialog sfd;
        private OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
        }
               
        public void Set_data()
        {
            Book_list.Add(new Book(book1.title, book1.author, book1.genres, book1.stars, book1.price));
            dataGridView1.Rows.Add(Book_list.Last().title, Book_list.Last().author, Book_list.Last().genres, Book_list.Last().stars, Book_list.Last().price);
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
                Book_list.RemoveAt(index);
                dataGridView1.Rows.RemoveAt(index);
                row_counter--;
            }
            
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            sfd = new SaveFileDialog();
            sfd.Filter = ".csv | .csv"; 
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
            //string title = "";
            //string author = "";
            //string genres = "";
            //string stars = "";
            //string price = "";
            ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName; //ścieżka do pliku 
                foreach(string line in System.IO.File.ReadLines(path))
                {
                    string[] data = line.Split(',');
                    book1.title = data[0];
                    book1.author = data[1];
                    book1.genres = data[2];
                    book1.stars = data[3];
                    book1.price = data[4];
                    Book_list.Add(new Book(book1.title, book1.author, book1.genres, book1.stars, book1.price));
                    dataGridView1.Rows.Add(Book_list.Last().title, Book_list.Last().author, Book_list.Last().genres, Book_list.Last().stars, Book_list.Last().price);            
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

        private void SaveXML_button_Click(object sender, EventArgs e)
        {            
            
            sfd = new SaveFileDialog();
            sfd.Filter = ".xml | .xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                if(!File.Exists(path)) 
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Book>));
                    StreamWriter writer = new StreamWriter(path);
                    ser.Serialize(writer, Book_list);
                    writer.Close();
                }
                
            }
                

        }

        private void LoadXML_button_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName; //ścieżka do pliku 
                XmlSerializer ser = new XmlSerializer(typeof(List<Book>));
                StreamReader reader= new StreamReader(path);
                Book_list = (List<Book>)ser.Deserialize(reader);
                reader.Close();
                while(dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
                for(int i = 0; i < Book_list.Count; i++)
                {
                    //????
                    Book_list.Add(new Book(book1.title, book1.author, book1.genres, book1.stars, book1.price));
                    dataGridView1.Rows.Add(Book_list.Last().title, Book_list.Last().author, Book_list.Last().genres, Book_list.Last().stars, Book_list.Last().price);
                    row_counter++;
                }

            }

           
        }
    }
}
