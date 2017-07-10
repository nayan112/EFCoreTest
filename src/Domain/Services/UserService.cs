using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserDomain.Entity;
using UserDomain.RepositoryInterfaces;
using UserDomain.ServiceInterfaces;

namespace UserDomain.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Users GetUser(string id)
        {
            return _userRepository.Get(id);
        }

        public IList<Users> GetUsers()
        {
            return _userRepository.Get();
        }

        public async Task<Users> GetUserAsync(string id)
        {
            return await _userRepository.GetAsync(id);
        }
        public async Task<IList<Users>> GetUsersAsync()
        {
            return await _userRepository.GetAsync();
        }
    }
}