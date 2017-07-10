using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserDomain.Entity;

namespace UserDomain.ServiceInterfaces
{
    public interface IUserService
    {
        IList<Users> GetUsers();
        Users GetUser(string id);

        Task<IList<Users>> GetUsersAsync();
        Task<Users> GetUserAsync(string id);
    }
}