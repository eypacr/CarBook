using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.HasData(
            new Brand { BrandId = 1, Name = "Mercedes" },
            new Brand { BrandId = 2, Name = "Range Rover" },
            new Brand { BrandId = 3, Name = "BMW" },
            new Brand { BrandId = 4, Name = "Audi" },
            new Brand { BrandId = 5, Name = "Renault" },
            new Brand { BrandId = 6, Name = "Volkswogen" },
            new Brand { BrandId = 7, Name = "Toyota" },
            new Brand { BrandId = 8, Name = "Jeep" }
            );
    }
}