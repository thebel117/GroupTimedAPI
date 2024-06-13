using System.Collections.Generic; 
using GoSocialApi.Models; 
using GoSocialApi.Services; 
using GoSocialApi.WebApi.Services; 

namespace GoSocialApi.Data
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers() => _userRepository.GetAllUsers();

        public User GetUserById(int id) => _userRepository.GetUserById(id);

        public void CreateUser(User user) => _userRepository.CreateUser(user);

        public void UpdateUser(User user) => _userRepository.UpdateUser(user);

        public void DeleteUser(int id) => _userRepository.DeleteUser(id);
    }
}
