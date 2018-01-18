using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
    }
}