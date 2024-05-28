using BookProject.Models;
using BookProject.Service.IService;

namespace BookProject.Service
{
    public class UserService : IUserService
    {
        private readonly List<UserNew> _users = new()
        {
            new UserNew { Username = "admin", Password = "password", Role = "Admin" },
            new UserNew { Username = "user", Password = "password", Role = "User" }
        };

        public UserNew Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(x => x.Username == username && x.Password == password);
        }

        public IEnumerable<UserNew> GetAll()
        {
            return _users;
        }
    }
}
