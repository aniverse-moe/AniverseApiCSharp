using AniverseApiCSharp.Entities;
using AniverseApiCSharp.Models;
using AniverseApiCSharp.Models.User;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AniverseApiCSharp.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserResponse>();
            CreateMap<RegisterRequest, User>();
            CreateMap<UpdateRequest, User>();
        }
    }
}

