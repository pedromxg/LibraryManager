namespace GerenciadorBiblioteca.API.Models.InputModels
{
    public class BookInputModel
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public int PublicationYear { get; private set; }

        public BookInputModel(string name, string author, string isbn, int publicationYear)
        {
            Name = name;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
        }
    }
}
