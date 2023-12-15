namespace GerenciadorBiblioteca.API.Models.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(int id, string name, string author, string iSBN, int publicationYear)
        {
            Id = id;
            Name = name;
            Author = author;
            ISBN = iSBN;
            PublicationYear = publicationYear;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public int PublicationYear { get; private set; }
    }
}
