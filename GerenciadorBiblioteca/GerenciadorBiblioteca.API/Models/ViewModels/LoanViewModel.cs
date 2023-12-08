using GerenciadorBiblioteca.API.Entities;

namespace GerenciadorBiblioteca.API.Models.ViewModels
{
    public class LoanViewModel
    {
        public LoanViewModel(int id, int userId, DateTime loanDate, DateTime finishDate, User user, List<Book> books)
        {
            Id = id;
            UserId = userId;
            LoanDate = loanDate;
            FinishDate = finishDate;
            User = user;
            Books = books;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime FinishDate { get; set; }

        public User User { get; set; }
        public List<Book> Books { get; set; }
    }
}
