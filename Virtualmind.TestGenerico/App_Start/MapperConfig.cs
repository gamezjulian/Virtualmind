using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Virtualmind.TestGenerico.Core.Entities;
using Virtualmind.TestGenerico.Models;

namespace Virtualmind.TestGenerico.App_Start
{
    public static class MapperConfig
    {
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.CreateMap<User, UserViewModel>().ReverseMap();
                x.CreateMap<Quote, QuoteViewModel>().ReverseMap();
            });
        }
    }
}