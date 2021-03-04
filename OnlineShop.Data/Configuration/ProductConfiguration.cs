using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entities.Product;
using System;

namespace OnlineShop.Data.Configuration {
    class ProductConfiguration : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {

            // Seed Data
            builder.HasData(
                new Product {
                    Id = Guid.NewGuid(),
                    Name = "Product One",
                    Description = "Product One Description",
                    Price = 10.00,
                    Quantity = 1000,
                    Category = "CategoryOne"
                },
                new Product {
                    Id = Guid.NewGuid(),
                    Name = "Product Two",
                    Description = "Product Two Description",
                    Price = 20.00,
                    Quantity = 1000,
                    Category = "CategoryOne"
                },
                new Product {
                    Id = Guid.NewGuid(),
                    Name = "Product Three",
                    Description = "Product Three Description",
                    Price = 30.00,
                    Quantity = 1000,
                    Category = "CategoryTwo"
                },
                new Product {
                    Id = Guid.NewGuid(),
                    Name = "Product Four",
                    Description = "Product Four Description",
                    Price = 40.00,
                    Quantity = 1000,
                    Category = "CategoryTwo"
                }
            );
        }
    }
}
