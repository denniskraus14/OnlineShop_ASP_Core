using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities.Employee;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repositories.EmployeeRepo {
    public class EmployeeRepository : IEmployeeRepository {
        private ApplicationContext Context { get; set; }

        public EmployeeRepository(ApplicationContext context) { Context = context; }

        public List<Employee> Get() {
            return Context.Employees.ToList();
        }

        public IEnumerable<Employee> GetEmployees() {
            throw new System.NotImplementedException();
        }

        public List<Employee> GetAllEmployees() {
            throw new System.NotImplementedException();
        }

        public async Task<List<Employee>> GetAsync() => await Context.Employees.ToListAsync();
    }
}
