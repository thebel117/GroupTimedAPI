using GoSocialApi.Models;
using System.Collections.Generic;

namespace GoSocialApi.Data
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
