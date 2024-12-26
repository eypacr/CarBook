using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class PricingConfiguration : IEntityTypeConfiguration<Pricing>
{
    public void Configure(EntityTypeBuilder<Pricing> builder)
    {
        builder.HasData(
            new Pricing { PricingId = 1, Name = "Saatlik" },
            new Pricing { PricingId = 2, Name = "Günlük" },
            new Pricing { PricingId = 3, Name = "Haftalık" },
            new Pricing { PricingId = 4, Name = "Aylık" }
            );
    }
}