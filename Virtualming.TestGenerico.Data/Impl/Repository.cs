using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualming.TestGenerico.Data.Interfaces;

namespace Virtualming.TestGenerico.Data.Impl
{
    public class Repository<T, U> : IRepository<T, U>
        where T : BaseEntity
        where U : DbContext, new()
    {
        public U DbContext { get; set; }

        public Repository()
        {
            this.DbContext = new U();
        }

        public T Add(T entity)
        {
            var newEntity = this.DbContext.Set<T>().Add(entity);
            this.SaveChanges();

            return newEntity;
        }

        public void Delete(T entity)
        {
            this.DbContext.Set<T>().Attach(entity);
            var removedEntity = this.DbContext.Set<T>().Remove(entity);
            this.SaveChanges();
        }

        public T Get(int id)
        {
            return this.DbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return this.DbContext.Set<T>();
        }

        public T Update(T entity)
        {
            this.DbContext.Entry<T>(entity).State = EntityState.Modified;
            this.SaveChanges();

            return this.Get(entity.Id);

        }

        private void SaveChanges()
        {
            this.DbContext.SaveChanges();
        }
    }
}
