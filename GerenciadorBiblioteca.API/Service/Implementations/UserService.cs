using GerenciadorBiblioteca.API.Entities;
using GerenciadorBiblioteca.API.Models.InputModels;
using GerenciadorBiblioteca.API.Models.ViewModels;
using GerenciadorBiblioteca.API.Persistense;
using GerenciadorBiblioteca.API.Service.Interfaces;

namespace GerenciadorBiblioteca.API.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly LibraryDbContext _context;

        public List<UserViewModel> GetAll()
        {
            var users = _context.Users;

            var usersViewModel = users
                .Select(u => new UserViewModel(u.Id, u.Name, u.Email, u.Loans))
                .ToList();

            return usersViewModel;
        }

        public UserViewModel GetById(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);

            return new UserViewModel(user.Id, user.Name, user.Email, user.Loans);
        }

        public UserViewModel Create(UserInputModel userInputModel)
        {
            var newUser = new User(userInputModel.Name, userInputModel.Email, userInputModel.Loans);

            _context.Users.Add(newUser);

            return new UserViewModel(newUser.Id, newUser.Name, newUser.Email, newUser.Loans);
        }

        public void Update(int id, UserInputModel userInputModel)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);

            user.Update(userInputModel.Name, userInputModel.Email);
        }

        public void Delete(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);

            _context.Users.Remove(user);
        }
    }
}
