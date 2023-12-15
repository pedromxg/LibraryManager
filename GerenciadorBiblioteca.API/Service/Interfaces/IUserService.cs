using GerenciadorBiblioteca.API.Models.InputModels;
using GerenciadorBiblioteca.API.Models.ViewModels;

namespace GerenciadorBiblioteca.API.Service.Interfaces
{
    public interface IUserService
    {
        public List<UserViewModel> GetAll();
        public UserViewModel GetById(int id);
        public UserViewModel Create(UserInputModel userInputModel);
        public void Update(int id, UserInputModel userInputModel);
        public void Delete(int id);
    }
}
