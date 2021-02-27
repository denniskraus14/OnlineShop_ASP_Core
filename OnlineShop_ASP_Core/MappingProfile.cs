using AutoMapper;
using OnlineShop_ASP_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop_ASP_Core {
    public class MappingProfile : Profile {
        /// <summary>
        /// Map email to the username since we are not going to use username in the registration form
        /// </summary>
        public MappingProfile() {
            CreateMap<UserRegistrationModel, User>().ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
