using GerenciadorBiblioteca.API.Entities;

namespace GerenciadorBiblioteca.API.Models.InputModels
{
    public class UserInputModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Loan> Loans { get; set; }
    }
}
