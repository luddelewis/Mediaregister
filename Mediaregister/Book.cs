namespace Mediaregister
{
    class Book : Media
    {
        private string author;
        private int nrOfPages;
        //Konstruktor som ärver titel från basklassen media
        public Book(string titel, string author, int pages) : base(titel)
        {
            this.author = author;
            nrOfPages = pages;
        }
        //Override av ToString() för classen Book
        public override string ToString()
        {
            return $"{titel} ({author}, {nrOfPages} sidor)";
        }
    }
}
