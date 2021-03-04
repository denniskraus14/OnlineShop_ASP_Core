using AutoMapper;
using OnlineShop.Entities.Account;
using OnlineShop.ViewModel.Account;

namespace OnlineShop_ASP_Core {
    public class MappingProfile : Profile {
        /// <summary>
        /// Map email to the username since we are not going to use username in the registration form
        /// </summary>
        public MappingProfile() {
            CreateMap<RegistrationViewModel, User>().ForMember(
                user => user.UserName, 
                option => option.MapFrom(x => x.Email)
            );
        }
    }
}
