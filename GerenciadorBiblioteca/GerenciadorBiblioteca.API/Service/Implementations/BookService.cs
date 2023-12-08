using GerenciadorBiblioteca.API.Entities;
using GerenciadorBiblioteca.API.Models.InputModels;
using GerenciadorBiblioteca.API.Models.ViewModels;
using GerenciadorBiblioteca.API.Persistense;
using GerenciadorBiblioteca.API.Services.Interfaces;

namespace GerenciadorBiblioteca.API.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly LibraryDbContext _context;

        public List<BookViewModel> GetAll()
        {
            var books = _context.Books;

            var booksViewModel = books
                .Select(b => new BookViewModel(b.Id, b.Name, b.Author, b.ISBN, b.PublicationYear))
                .ToList();

            return booksViewModel;
        }

        public BookViewModel GetById(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            return new BookViewModel(book.Id, book.Name, book.Author, book.ISBN, book.PublicationYear);
        }

        public BookViewModel Create(BookInputModel bookInputModel)
        {
            var newBook = new Book(bookInputModel.Name, bookInputModel.Author, bookInputModel.ISBN, bookInputModel.PublicationYear);

            _context.Books.Add(newBook);

            return new BookViewModel(newBook.Id, newBook.Name, newBook.Author, newBook.ISBN, newBook.PublicationYear);
        }

        public BookViewModel Update(int id, BookInputModel bookInputModel)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            book.Update(bookInputModel.Name, bookInputModel.Author, bookInputModel.ISBN, bookInputModel.PublicationYear);

            return new BookViewModel(book.Id, book.Name, book.Author, book.ISBN, book.PublicationYear);
        }

        public void Delete(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            _context.Books.Remove(book);
        }        
    }
}
