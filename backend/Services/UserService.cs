using backend.Models;
using backend.Interfaces;

namespace backend.Services
{
    public class UserService : IUserService
    {
        public bool ValidateUser(User user)
        {
            return user.Username == "admin" && user.Password == "password";
        }
    }
}