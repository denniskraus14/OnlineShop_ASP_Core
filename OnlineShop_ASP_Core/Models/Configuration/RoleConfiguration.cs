using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop_ASP_Core.Models.Configuration {
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole> {

        /// <summary>
        /// Used to seed data to the database
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<IdentityRole> builder) {
            builder.ToTable("Role");

            builder.HasData(
                new IdentityRole {
                    Name = "Guest",
                    NormalizedName = "GUEST"
                },
                new IdentityRole {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );
        }
    }
}
