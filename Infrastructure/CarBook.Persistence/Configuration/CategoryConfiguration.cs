using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category { CategoryId = 1, Name = "Hibrit Araçlar" },
            new Category { CategoryId = 2, Name = "Araç Bakımları" },
            new Category { CategoryId = 3, Name = "Periyodik Muayeneler" },
            new Category { CategoryId = 4, Name = "Elektrikli Araçlar" },
            new Category { CategoryId = 5, Name = "Araç Temizliği" }
        );
    }
}
