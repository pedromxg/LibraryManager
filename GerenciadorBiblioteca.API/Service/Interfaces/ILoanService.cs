using GerenciadorBiblioteca.API.Models.InputModels;
using GerenciadorBiblioteca.API.Models.ViewModels;

namespace GerenciadorBiblioteca.API.Service.Interfaces
{
    public interface ILoanService
    {
        public List<LoanViewModel> GetAll();
        public LoanViewModel GetById(int id);
        public LoanViewModel Create(LoanInputModel loanInputModel);
        public void Update(int id, LoanInputModel loanInputModel);
        public void Delete(int id);
    }
}
