using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Services.Impl;
using Virtualmind.TestGenerico.Services.Interfaces;
using Virtualming.TestGenerico.Data.Contexts;
using Virtualming.TestGenerico.Data.Impl;
using Virtualming.TestGenerico.Data.Interfaces;

namespace Virtualmind.TestGenerico.Tests.Services
{
    [TestClass]
    public class UserServiceTest
    {
        private IUserService service;
        private IRepository<User, UserDbContext> repository;

        [TestInitialize]
        public void Initialize()
        {
            this.repository = A.Fake<IRepository<User, UserDbContext>>();
            this.service = new UserService(repository);
        }

        [TestMethod]
        public void GetUser()
        {
            A.CallTo(() => this.repository.Get(1))
                .Returns(new User()
                {
                    FirstName = "Julian"
                });

            var user = this.service.Find(1);

            Assert.AreEqual("Julian", user.FirstName);
        }

        [TestMethod]
        public void GetAllUsers()
        {
            A.CallTo(() => this.repository.GetAll())
                .Returns(new List<User>()
                {
                    new User()
                    {
                        Id = 1
                    },
                    new User()
                    {
                        Id = 2
                    }
                });

            var users = this.service.GetAllUsers();

            Assert.AreEqual(1, users.ElementAt(0).Id);
            Assert.AreEqual(2, users.ElementAt(1).Id);
        }

        [TestMethod]
        public void RemoveUser()
        {
            var user = new User
            {
                FirstName = "Julian",
                LastName = "Gamez",
                Id = 1,
                Email = "gamez.julian@gmail.com",
                Password = "1234"
            };

            A.CallTo(() => this.repository.Delete(user))
                .Returns(true);

            Assert.IsTrue(this.repository.Delete(user));
        }

        [TestMethod]
        public void UpdateUser()
        {
            var userUpdated = new User
            {
                FirstName = "Julian",
                LastName = "Gomez",
                Id = 1,
                Email = "gamez.julian@gmail.com",
                Password = "1234"
            };

            A.CallTo(() => this.repository.Update(userUpdated)).Returns(new User { LastName = "Gomez" });

            Assert.AreEqual(userUpdated.LastName, this.repository.Update(userUpdated).LastName);
        }
    }
}
