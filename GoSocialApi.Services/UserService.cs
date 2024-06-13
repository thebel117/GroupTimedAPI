using System.Collections.Generic; 
using GoSocialApi.Models; 
using GoSocialApi.Services; 
using GoSocialApi.WebApi.Services; 

namespace GoSocialApi.Data
{
    public class UserService : IUserService
    {
        private readonly IUserService _userService;

        public UserService(IUserService userService)
        {
            _userService = userService;
        }

        public IEnumerable<User> GetAllUsers() => _userService.GetAllUsers();

        public User GetUserById(int id) => _userService.GetUserById(id);

        public void CreateUser(User user) => _userService.CreateUser(user);

        public void UpdateUser(User user) => _userService.UpdateUser(user);

        public void DeleteUser(int id) => _userService.DeleteUser(id);
    }
}
