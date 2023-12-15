using GerenciadorBiblioteca.API.Entities;

namespace GerenciadorBiblioteca.API.Models.InputModels
{
    public class LoanInputModel
    {
        public int UserId { get; set; }
        public DateTime FinishDate { get; set; }

        public User User { get; set; }
        public List<Book> Books { get; set; }
    }
}
