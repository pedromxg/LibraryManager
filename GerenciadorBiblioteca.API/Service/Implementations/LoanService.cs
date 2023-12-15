using GerenciadorBiblioteca.API.Entities;
using GerenciadorBiblioteca.API.Models.InputModels;
using GerenciadorBiblioteca.API.Models.ViewModels;
using GerenciadorBiblioteca.API.Persistense;
using GerenciadorBiblioteca.API.Service.Interfaces;

namespace GerenciadorBiblioteca.API.Service.Implementations
{
    public class LoanService : ILoanService
    {
        private readonly LibraryDbContext _context;

        public List<LoanViewModel> GetAll()
        {
            var loans = _context.Loans;

            var loansViewModel = loans
                .Select(l => new LoanViewModel(l.Id, l.UserId, l.LoanDate, l.FinishDate, l.User, l.Books))
                .ToList();

            return loansViewModel;
        }

        public LoanViewModel GetById(int id)
        {
            var loan = _context.Loans.SingleOrDefault(l => l.Id == id);

            return new LoanViewModel(loan.Id, loan.UserId, loan.LoanDate, loan.FinishDate, loan.User, loan.Books);
        }

        public LoanViewModel Create(LoanInputModel loanInputModel)
        {
            var newLoan = new Loan(loanInputModel.UserId, loanInputModel.FinishDate, loanInputModel.User, loanInputModel.Books);

            _context.Loans.Add(newLoan);

            return new LoanViewModel(newLoan.Id, newLoan.UserId, newLoan.LoanDate, newLoan.FinishDate, newLoan.User, newLoan.Books);
        }

        public void Update(int id, LoanInputModel loanInputModel)
        {
            var loan = _context.Loans.SingleOrDefault(l => l.Id == id);

            loan.Update(loanInputModel.FinishDate);
        }

        public void Delete(int id)
        {
            var loan = _context.Loans.SingleOrDefault(l => l.Id == id);

            _context.Loans.Remove(loan);
        }        
    }
}
