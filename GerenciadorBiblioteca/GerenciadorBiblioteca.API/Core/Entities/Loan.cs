namespace GerenciadorBiblioteca.API.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime FinishDate { get; set; }

        public User User { get; set; }
        public List<Book> Books { get; set; }

        public Loan(int userId, DateTime finishDate, User user, List<Book> books)
        {
            UserId = userId;
            LoanDate = DateTime.Now;
            FinishDate = finishDate;
            User = user;
            Books = books;
        }

        public void Update(DateTime finishDate)
        {
            FinishDate = finishDate;
        }
    }
}
