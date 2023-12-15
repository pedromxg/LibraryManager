namespace GerenciadorBiblioteca.API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Loan> Loans { get; set; }

        public User(string name, string email, List<Loan> loans)
        {
            Name = name;
            Email = email;
            Loans = loans;
        }

        public void Update(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
