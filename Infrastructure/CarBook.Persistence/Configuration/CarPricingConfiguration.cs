using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class CarPricingConfiguration : IEntityTypeConfiguration<CarPricing>
{
    public void Configure(EntityTypeBuilder<CarPricing> builder)
    {
        builder.HasData(
            new CarPricing { CarPricingId = 1, CarId = 1, PricingId = 1, Amount = 100 }, 
            new CarPricing { CarPricingId = 2, CarId = 1, PricingId = 2, Amount = 900 }, 
            new CarPricing { CarPricingId = 3, CarId = 1, PricingId = 3, Amount = 6000 }, 
            new CarPricing { CarPricingId = 4, CarId = 1, PricingId = 4, Amount = 20000 }, 

            new CarPricing { CarPricingId = 5, CarId = 2, PricingId = 1, Amount = 110 }, 
            new CarPricing { CarPricingId = 6, CarId = 2, PricingId = 2, Amount = 950 }, 
            new CarPricing { CarPricingId = 7, CarId = 2, PricingId = 3, Amount = 6300 }, 
            new CarPricing { CarPricingId = 8, CarId = 2, PricingId = 4, Amount = 21000 }, 

            new CarPricing { CarPricingId = 9, CarId = 3, PricingId = 1, Amount = 120 }, 
            new CarPricing { CarPricingId = 10, CarId = 3, PricingId = 2, Amount = 1000 },
            new CarPricing { CarPricingId = 11, CarId = 3, PricingId = 3, Amount = 7000 }, 
            new CarPricing { CarPricingId = 12, CarId = 3, PricingId = 4, Amount = 23000 }, 

            new CarPricing { CarPricingId = 13, CarId = 4, PricingId = 1, Amount = 130 }, 
            new CarPricing { CarPricingId = 14, CarId = 4, PricingId = 2, Amount = 1050 }, 
            new CarPricing { CarPricingId = 15, CarId = 4, PricingId = 3, Amount = 7350 }, 
            new CarPricing { CarPricingId = 16, CarId = 4, PricingId = 4, Amount = 24500 }, 

            new CarPricing { CarPricingId = 17, CarId = 5, PricingId = 1, Amount = 140 }, 
            new CarPricing { CarPricingId = 18, CarId = 5, PricingId = 2, Amount = 1100 }, 
            new CarPricing { CarPricingId = 19, CarId = 5, PricingId = 3, Amount = 7700 }, 
            new CarPricing { CarPricingId = 20, CarId = 5, PricingId = 4, Amount = 26000 }, 

            new CarPricing { CarPricingId = 21, CarId = 6, PricingId = 1, Amount = 150 }, 
            new CarPricing { CarPricingId = 22, CarId = 6, PricingId = 2, Amount = 1150 }, 
            new CarPricing { CarPricingId = 23, CarId = 6, PricingId = 3, Amount = 8050 }, 
            new CarPricing { CarPricingId = 24, CarId = 6, PricingId = 4, Amount = 27500 }, 

            new CarPricing { CarPricingId = 25, CarId = 7, PricingId = 1, Amount = 160 }, 
            new CarPricing { CarPricingId = 26, CarId = 7, PricingId = 2, Amount = 1200 }, 
            new CarPricing { CarPricingId = 27, CarId = 7, PricingId = 3, Amount = 8400 }, 
            new CarPricing { CarPricingId = 28, CarId = 7, PricingId = 4, Amount = 29000 }, 

            new CarPricing { CarPricingId = 29, CarId = 8, PricingId = 1, Amount = 170 },
            new CarPricing { CarPricingId = 30, CarId = 8, PricingId = 2, Amount = 1250 },
            new CarPricing { CarPricingId = 31, CarId = 8, PricingId = 3, Amount = 8750 }, 
            new CarPricing { CarPricingId = 32, CarId = 8, PricingId = 4, Amount = 30500 }, 

            new CarPricing { CarPricingId = 33, CarId = 9, PricingId = 1, Amount = 180 }, 
            new CarPricing { CarPricingId = 34, CarId = 9, PricingId = 2, Amount = 1300 }, 
            new CarPricing { CarPricingId = 35, CarId = 9, PricingId = 3, Amount = 9100 }, 
            new CarPricing { CarPricingId = 36, CarId = 9, PricingId = 4, Amount = 32000 }, 

            new CarPricing { CarPricingId = 37, CarId = 10, PricingId = 1, Amount = 190 }, 
            new CarPricing { CarPricingId = 38, CarId = 10, PricingId = 2, Amount = 1350 }, 
            new CarPricing { CarPricingId = 39, CarId = 10, PricingId = 3, Amount = 9450 }, 
            new CarPricing { CarPricingId = 40, CarId = 10, PricingId = 4, Amount = 33500 }, 

            new CarPricing { CarPricingId = 41, CarId = 11, PricingId = 1, Amount = 200 }, 
            new CarPricing { CarPricingId = 42, CarId = 11, PricingId = 2, Amount = 1400 }, 
            new CarPricing { CarPricingId = 43, CarId = 11, PricingId = 3, Amount = 9800 }, 
            new CarPricing { CarPricingId = 44, CarId = 11, PricingId = 4, Amount = 35000 }, 

            new CarPricing { CarPricingId = 45, CarId = 12, PricingId = 1, Amount = 210 }, 
            new CarPricing { CarPricingId = 46, CarId = 12, PricingId = 2, Amount = 1450 }, 
            new CarPricing { CarPricingId = 47, CarId = 12, PricingId = 3, Amount = 10150 }, 
            new CarPricing { CarPricingId = 48, CarId = 12, PricingId = 4, Amount = 36500 }  
        );
    }
}
