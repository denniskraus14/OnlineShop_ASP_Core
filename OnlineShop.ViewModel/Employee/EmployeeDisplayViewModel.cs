using OnlineShop.Data.Repositories.EmployeeRepo;
using System;

namespace OnlineShop.ViewModel.Employee {
    public class EmployeeDisplayViewModel {

        /// <summary>
        /// NOTE: You need a parameterless constructor for post-backs in MVC
        /// </summary>
        public EmployeeDisplayViewModel() { }

        public EmployeeDisplayViewModel(IEmployeeRepository repository) { }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Position { get; set; }
    }
}
