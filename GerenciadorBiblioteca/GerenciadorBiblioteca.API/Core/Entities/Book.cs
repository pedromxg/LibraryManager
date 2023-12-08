using GerenciadorBiblioteca.API.Models.InputModels;

namespace GerenciadorBiblioteca.API.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }

        public Book(string name, string author, string isbn, int publicationYear)
        {
            Name = name;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
        }

        public void Update(string name, string author, string isbn, int publicationYear)
        {
            Name = name;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
        }
    }
}
