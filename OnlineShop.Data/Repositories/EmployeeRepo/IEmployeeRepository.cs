using OnlineShop.Entities.Employee;
using System.Collections.Generic;

namespace OnlineShop.Data.Repositories.EmployeeRepo {
    /// <summary>
    /// Only needs a single method called Get() so that we can retreive all of
    /// the Employees from the Employee Table inside the database.
    /// </summary>
    public interface IEmployeeRepository {
        List<Employee> Get();
    }
}
