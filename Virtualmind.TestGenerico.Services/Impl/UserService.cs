using System.Collections.Generic;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Services.Interfaces;
using Virtualming.TestGenerico.Data.Contexts;
using Virtualming.TestGenerico.Data.Interfaces;

namespace Virtualmind.TestGenerico.Services.Impl
{
    public class UserService : IUserService
    {
        private IRepository<User, UserDbContext> userRepository;

        public UserService(IRepository<User, UserDbContext> repository)
        {
            this.userRepository = repository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return this.userRepository.GetAll();
        }
    }
}
