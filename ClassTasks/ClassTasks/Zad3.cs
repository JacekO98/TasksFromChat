
namespace Zad3
{
    public class Author
    {
        public string Name { get; }
        public string Lastname { get; }

        internal Author(string Name, string Lastname)
        {
            this.Name = Name;
            this.Lastname = Lastname;
        }
    }

    public class Book
    {
        public string Title { get; }
        public int ReleaseDate { get; }
        public Author Author { get; }

        internal Book(string Title, int ReleaseDate, Author Author)
        {
            this.Title = Title;
            this.ReleaseDate = ReleaseDate;
            this.Author = Author;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Tytuł:{this.Title}, Imie Autora:{this.Author.Name}, Nazwisko Autora:{this.Author.Lastname}, Data wydania:{this.ReleaseDate}");
        }
    }

    
}
