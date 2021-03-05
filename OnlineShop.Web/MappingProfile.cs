using AutoMapper;
using OnlineShop.Entities.Account;
using OnlineShop.Entities.Employee;
using OnlineShop.ViewModel.AccountViews;
using OnlineShop.ViewModel.EmployeeViews;

namespace OnlineShop_ASP_Core {
    public class MappingProfile : Profile {
        /// <summary>
        /// Creates a mapping between source (Domain) and destination (ViewModel)
        /// </summary>
        public MappingProfile() {
            // Map email to the username 
            CreateMap<RegistrationViewModel, User>().ForMember(
                user => user.UserName, 
                option => option.MapFrom(x => x.Email)
            );

            // Try #1
            /*CreateMap<EmployeeDisplayViewModel, Employee>().ForMember(
                employee => employee.Id,
                option => option.MapFrom(x => x.Id)
            );*/

            // Try #2
            //CreateMap<Employee, EmployeeDisplayViewModel>().ReverseMap();
            // MapperConfiguration

            // Try #3
            CreateMap<Employee, EmployeeDisplayViewModel>();
        }
    }
}
