using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Models;
using Virtualmind.TestGenerico.Services.Interfaces;

namespace Virtualmind.TestGenerico.Controllers.Api
{
    public class UserController : ApiController
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [Route("api/users/all")]
        public IEnumerable<UserViewModel> GetAll()
        {
            var result = new List<UserViewModel>();
            var users = this.userService.GetAllUsers();
            result = Mapper.Map<IEnumerable<UserViewModel>>(users).ToList();

            return result;
        }

        [HttpPost]
        [Route("api/users/add")]
        public UserViewModel Add(UserViewModel viewModel)
        {
            var result = new UserViewModel();
            var userEntity = Mapper.Map<UserViewModel, User>(viewModel);
            var user = this.userService.AddUser(userEntity);
            result = Mapper.Map<UserViewModel>(user);

            return result;
        }

        [HttpPut]
        [Route("api/users/update")]
        public UserViewModel Update(UserViewModel viewModel)
        {
            var result = new UserViewModel();
            var userEntity = Mapper.Map<UserViewModel, User>(viewModel);
            var user = this.userService.Update(userEntity);
            result = Mapper.Map<UserViewModel>(user);

            return result;
        }

        [HttpDelete]
        [Route("api/users/delete")]
        public void Delete(UserViewModel viewModel)
        {
            var result = new UserViewModel();
            var userEntity = Mapper.Map<UserViewModel, User>(viewModel);
            this.userService.Delete(userEntity);
        }

        [HttpGet]
        [Route("api/users/{id}")]
        public UserViewModel Get(int id)
        {
            var user = this.userService.Find(id);
            var viewModel = Mapper.Map<UserViewModel>(user);

            return viewModel;
        }
    }
}