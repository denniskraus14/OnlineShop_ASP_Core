using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop_ASP_Core.Models.Configuration;

namespace OnlineShop_ASP_Core.Models {

    public class ApplicationContext : IdentityDbContext<User> {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Employee> Employees { get; set; }

        //public DbSet<Role> Roles { get; set; }

        //public DbSet<UserRegistrationModel> UserRegistrations { get; set; }
    }
}
