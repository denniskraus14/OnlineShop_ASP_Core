using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repositories.EmployeeRepo {
    public class EmployeeRepository {
        private ApplicationContext Context { get; set; }

        public EmployeeRepository(ApplicationContext context) {
            Context = context;
        }

        public async Task<List<Employee>> GetAsync() {
            return await Context.Employees.ToListAsync();
        }
    }
}
