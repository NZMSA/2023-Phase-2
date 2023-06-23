using Back_End.Models;

namespace Back_End.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User> 
        { 
            new User { Id = Guid.NewGuid().ToString(), Username = "test", Password = "test" } 
        };

        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => _users.SingleOrDefault(user => user.Username == username && user.Password == password));

            // Return null if user not found
            if (user == null)
                return null;

            return user;
        }
    }
}