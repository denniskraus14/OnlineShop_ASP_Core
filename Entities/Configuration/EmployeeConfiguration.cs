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
                    Id = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                    Name = "Ant Mac",
                    Age = 31,
                    Position = "Software Developer",
                },
                new Employee {
                    Id = new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"),
                    Name = "Mac Ant",
                    Age = 31,
                    Position = "Software Engineer",
                }
            );
        }
    }
}
