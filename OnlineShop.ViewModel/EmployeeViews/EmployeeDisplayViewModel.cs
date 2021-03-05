using OnlineShop.Data.Repositories.EmployeeRepo;
using OnlineShop.Entities.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewModel.EmployeeViews {
    public class EmployeeDisplayViewModel {
        /*/// <summary>
        /// Allows you to create a repo object in the POST method of our controller
        /// </summary>
        public IEmployeeRepository Repository { get; set; }
        /// <summary>
        /// This will get us a list of Employee objects that will be loaded with all the
        /// employees returned from the table. This will be the property where the
        /// HTML table is built from.
        /// </summary>
        public List<Employee> Employees { get; set; }
        public Task<List<Employee>> EmployeesTask { get; set; }

        /// <summary>
        /// NOTE: You need a parameterless constructor for post-backs in MVC
        /// </summary>
        public EmployeeDisplayViewModel() { }

        /// <summary>
        /// We pass an instance of a EmployeeRepository when the EmployeeDisplayViewModel is created
        /// by the DI system in OnlineShop.Web
        /// </summary>
        /// <param name="repository"></param>
        public EmployeeDisplayViewModel(IEmployeeRepository repository) {
            Repository = repository;
        }

        /// <summary>
        /// We call this from the controller to retrieve the list of employee data. We can add more logic
        /// in the future to perform other function such as searching, paging, adding, editing, and
        /// deleting employee data.
        /// 
        /// NOTE: This should be the only method that is called from the controller classes
        /// </summary>
        public void HandleRequest() {
            LoadEmployees();
        }

        /// <summary>
        /// Resposible for called the GET() method on the repo object and retrieving the list of employee objects.
        /// </summary>
        protected virtual void LoadEmployees() {
            if (Repository == null) {
                throw new ApplicationException("Must set the Repository property.");
            } else {
                // Needs testing
                *//*Employees = Repository.Get().OrderBy(p => p.Name).ToList();*//*
                EmployeesTask = Repository.GetAsync();
            }
        }*/

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Position { get; set; }
    }
}
