using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualmind.TestGenerico.Core.Entities;

namespace Virtualmind.TestGenerico.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();

        User AddUser(User entity);

        User Update(User entity);

        bool Delete(User entity);

        User Find(int id);
    }
}
