using GoSocialApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace GoSocialApi.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly GoSocialContext _context;

        public UserRepository(GoSocialContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers() => _context.Users.ToList();

        public User GetUserById(int id) => _context.Users.Find(id);

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
