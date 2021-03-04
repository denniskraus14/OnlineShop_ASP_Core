using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entities.Account;

namespace OnlineShop.Data.Configuration {
    class RoleConfiguration : IEntityTypeConfiguration<Role> {
        public void Configure(EntityTypeBuilder<Role> builder) {
            /*
             * builder.ToTable("Role");
             */

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
