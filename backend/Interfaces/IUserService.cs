using backend.Models;

namespace backend.Interfaces
{
    public interface IUserService
    {
        bool ValidateUser(User user);
    }
}