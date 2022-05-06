using CloudCustomersTDD.API.Models;

namespace CloudCustomersTDD.API.Services
{
    public interface IUsersService
    {
        public Task<List<User>> GetAllUsers();
    }
    public class UsersService : IUsersService
    {
        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
