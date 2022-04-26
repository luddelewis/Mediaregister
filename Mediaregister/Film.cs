namespace Mediaregister
{
    class Film : Media
    {
        private string director;
        private int length;
        //Konstruktor som ärver titel från basklassen media
        public Film(string titel, string director, int length) : base(titel)
        {
            this.director = director;
            this.length = length;
        }
        //Override av ToString() för classen Film
        public override string ToString()
        {
            return $"{titel} ({director}, {length} minuter)";
        }
    }
}
