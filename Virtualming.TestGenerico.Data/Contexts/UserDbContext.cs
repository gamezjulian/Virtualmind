using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualmind.TestGenerico.Core.Entities;

namespace Virtualming.TestGenerico.Data.Contexts
{
    public class UserDbContext : DbContext
    {
        public UserDbContext() : base("Virtualmind")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
