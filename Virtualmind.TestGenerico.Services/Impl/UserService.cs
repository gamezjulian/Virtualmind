﻿using System.Collections.Generic;
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

        public User AddUser(User entity)
        {
            return this.userRepository.Add(entity);
        }

        public bool Delete(User entity)
        {
            return this.userRepository.Delete(entity);
        }

        public User Find(int id)
        {
            return this.userRepository.Get(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return this.userRepository.GetAll();
        }

        public User Update(User entity)
        {
            return this.userRepository.Update(entity);
        }
    }
}
