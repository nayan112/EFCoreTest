using Core;
using UserDomain.Context;
using UserDomain.Entity;
using UserDomain.RepositoryInterfaces;

namespace UserDomain.Repositories
{
    public class UserRepository:GenericRepository<Users>, IUserRepository
    {
        public UserRepository(UserContext context):base(context)
        {

        }
    }
}