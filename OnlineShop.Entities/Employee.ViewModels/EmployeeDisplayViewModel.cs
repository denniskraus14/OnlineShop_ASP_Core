using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Entities.Employee.ViewModels {
    public class EmployeeDisplayViewModel {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Position { get; set; }
    }
}
