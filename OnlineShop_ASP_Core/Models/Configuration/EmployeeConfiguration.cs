using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop_ASP_Core.Models.Configuration {
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>{

        public void Configure(EntityTypeBuilder<Employee> builder) {
            builder.HasData(
                new Employee {
                    Id = new Guid(),
                    Name = "Ant Mac",
                    Age = 31,
                    Position = "Software Developer",
                },
                new Employee {
                    Id = new Guid(),
                    Name = "Mac Ant",
                    Age = 31,
                    Position = "Software Engineer",
                }
            );
        }
    }
}
