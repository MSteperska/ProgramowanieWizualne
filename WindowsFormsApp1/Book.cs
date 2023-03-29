using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    [XmlType("Book")]
    [Serializable]
    public class Book
    {
        [XmlElement("title")]
        public string title { get; set; }
        [XmlElement("author")]
        public string author { get; set; }
        [XmlElement("genres")]
        public string genres { get; set; }
        [XmlElement("stars")]
        public string stars { get; set; }
        [XmlElement("price")]
        public string price { get; set; }



        public Book() { }

        public Book(string tytul,string autor,string gatunek,string ocena,string cena)
        {
            title = tytul;
            author = autor; 
            genres = gatunek;   
            stars = ocena;
            price = cena;
        }
    }
}
