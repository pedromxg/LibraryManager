using GerenciadorBiblioteca.API.Entities;

namespace GerenciadorBiblioteca.API.Models.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(int id, string name, string email, List<Loan> loans)
        {
            Id = id;
            Name = name;
            Email = email;
            Loans = loans;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Loan> Loans { get; set; }
    }
}
