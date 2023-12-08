using GerenciadorBiblioteca.API.Entities;
using GerenciadorBiblioteca.API.Models.InputModels;
using GerenciadorBiblioteca.API.Models.ViewModels;

namespace GerenciadorBiblioteca.API.Services.Interfaces
{
    public interface IBookService
    {
        public List<BookViewModel> GetAll();
        public BookViewModel GetById(int id);
        public BookViewModel Create(BookInputModel bookInputModel);
        public BookViewModel Update(int id, BookInputModel bookInputModel);
        public void Delete(int id);
    }
}
