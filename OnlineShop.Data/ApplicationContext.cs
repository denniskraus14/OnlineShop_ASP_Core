using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.Configuration;
using OnlineShop.Entities.Account;
using OnlineShop.Entities.Employee;
using OnlineShop.Entities.Product;

namespace OnlineShop.Data {
    public class ApplicationContext : IdentityDbContext<User> {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
