using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualmind.TestGenerico.Core.Entities;

namespace Virtualming.TestGenerico.Data.Interfaces
{
    public interface IRepository<T, U>
        where T : BaseEntity
        where U : DbContext
    {
        T Add(T entity);
        void Delete(T entity);
        T Update(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
