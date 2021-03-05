using OnlineShop.Entities.Employee;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repositories.EmployeeRepo {
    /// <summary>
    /// Only needs a single method called Get() so that we can retreive all of
    /// the Employees from the Employee Table inside the database.
    /// </summary>
    public interface IEmployeeRepository {
        List<Employee> Get();
        Task<List<Employee>> GetAsync();
        List<Employee> GetAllEmployees();
        IEnumerable<Employee> GetEmployees();
    }
}
