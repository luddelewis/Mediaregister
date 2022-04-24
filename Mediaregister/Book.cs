using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaregister
{
    class Book : Media
    {
        private string author;
        private int length;
        //Konstruktor som ärver titel från basklassen media
        public Book(string titel, string author, int length) : base(titel)
        {
            this.author = author;
            this.length = length;
        }
        //Override av ToString() för classen Book
        public override string ToString()
        {
            return String.Format("{0}({1},{2} minuter)",titel,author,length);
        }
    }
}
