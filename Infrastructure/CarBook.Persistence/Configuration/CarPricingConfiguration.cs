using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class CarPricingConfiguration : IEntityTypeConfiguration<CarPricing>
{
    public void Configure(EntityTypeBuilder<CarPricing> builder)
    {
        builder.HasData(
            new CarPricing { CarPricingId = 1, CarId = 1, PricingId = 2, Amount = 900 },
            new CarPricing { CarPricingId = 2, CarId = 2, PricingId = 2, Amount = 950 },
            new CarPricing { CarPricingId = 3, CarId = 3, PricingId = 2, Amount = 1000 },
            new CarPricing { CarPricingId = 4, CarId = 4, PricingId = 2, Amount = 1050 },
            new CarPricing { CarPricingId = 5, CarId = 5, PricingId = 2, Amount = 1100 },
            new CarPricing { CarPricingId = 6, CarId = 6, PricingId = 2, Amount = 1150 },
            new CarPricing { CarPricingId = 7, CarId = 7, PricingId = 2, Amount = 1200 },
            new CarPricing { CarPricingId = 8, CarId = 8, PricingId = 2, Amount = 1250 },
            new CarPricing { CarPricingId = 9, CarId = 9, PricingId = 2, Amount = 1300 },
            new CarPricing { CarPricingId = 10, CarId = 10, PricingId = 2, Amount = 1350 },
            new CarPricing { CarPricingId = 11, CarId = 11, PricingId = 2, Amount = 1400 },
            new CarPricing { CarPricingId = 12, CarId = 12, PricingId = 2, Amount = 1450 }
            );
    }
}
