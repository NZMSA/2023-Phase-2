using Back_End.Models;

namespace Back_End.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
}