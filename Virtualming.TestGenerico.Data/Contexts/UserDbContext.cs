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
            Database.SetInitializer<UserDbContext>(new UserInitializer());
        }

        public DbSet<User> Users { get; set; }
    }

    public class UserInitializer : System.Data.Entity.CreateDatabaseIfNotExists<UserDbContext>
    {
        protected override void Seed(UserDbContext context)
        {
            base.Seed(context);

            var users = new List<User>()
            {
                new User(){FirstName="Julián", LastName="Gamez", Email="julian.gamez@gmail.com",Password="123456"},
                new User(){FirstName="Ramiro", LastName="Garzon", Email="ramiro.garzon@gmail.com",Password="123456"},
                new User(){FirstName="Mauro", LastName="Briones", Email="mauro.briones@gmail.com",Password="123456"},
                new User(){FirstName="Antonio", LastName="Garcia", Email="antonio.garcia@gmail.com",Password="123456"},
                new User(){FirstName="Juan", LastName="Gallardo", Email="juan.gallardo@gmail.com",Password="123456"},
                new User(){FirstName="Amadeo", LastName="Amavet", Email="amadeo.amavet@gmail.com",Password="123456"},
                new User(){FirstName="Nicolas", LastName="Rodriguez", Email="nicolas.rodriguez@gmail.com",Password="123456"},
                new User(){FirstName="Nicole", LastName="Rubio", Email="nicole.rubio@gmail.com",Password="123456"},
                new User(){FirstName="Eliana", LastName="Pietrandrea", Email="eliana.pietrandrea@gmail.com",Password="123456"},
                new User(){FirstName="Belen", LastName="Finez", Email="belen.finez@gmail.com",Password="123456"},
                new User(){FirstName="Omar", LastName="Dicarlo", Email="omar.dicarlo@gmail.com",Password="123456"},
                new User(){FirstName="Ruben", LastName="Ferri", Email="ruben.ferri@gmail.com",Password="123456"},
                new User(){FirstName="Maricel", LastName="Rodino", Email="maricel.rodino@gmail.com",Password="123456"},
                new User(){FirstName="Aurora", LastName="Quinteros", Email="aurora.quinteros@gmail.com",Password="123456"},
                new User(){FirstName="Lucas", LastName="Heiman", Email="lucas.heiman@gmail.com",Password="123456"},
                new User(){FirstName="Cecilia", LastName="Ramirez", Email="cecilia.ramirez@gmail.com",Password="123456"},
                new User(){FirstName="Sol", LastName="Costa", Email="sol.costa@gmail.com",Password="123456"},
                new User(){FirstName="Barbara", LastName="Veloso", Email="barbara.veloso@gmail.com",Password="123456"},
                new User(){FirstName="Ezequiel", LastName="Ball", Email="ezequiel.ball@gmail.com",Password="123456"},
                new User(){FirstName="Agustin", LastName="Schmidt", Email="agustin.schmidt@gmail.com",Password="123456"},
            };

            users.ForEach(x => context.Users.Add(x));

            context.SaveChanges();
        }
    }
}
