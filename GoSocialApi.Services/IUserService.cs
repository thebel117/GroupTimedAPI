using GoSocialApi.Models;
using GoSocialApi.Data;

namespace GoSocialApi.Data
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
