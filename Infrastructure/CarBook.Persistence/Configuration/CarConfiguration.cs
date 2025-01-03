using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasData(
            new Car { CarId = 1, BrandId = 1, Model = "E-200", CoverImageUrl = "/carbook-master/images/car-1.jpg", Km = 5000, Transmission = "Otomatik", Seat = 5, Luggage = 2, Fuel = "Benzin", BigImageUrl = "/carbook-master/images/car-1.jpg" },
            new Car { CarId = 2, BrandId = 2, Model = "Velar", CoverImageUrl = "/carbook-master/images/car-2.jpg", Km = 12000, Transmission = "Otomatik", Seat = 5, Luggage = 3, Fuel = "Dizel", BigImageUrl = "/carbook-master/images/car-2.jpg" },
            new Car { CarId = 3, BrandId = 3, Model = "BMW Serisi", CoverImageUrl = "/carbook-master/images/car-5.jpg", Km = 8000, Transmission = "Manuel", Seat = 5, Luggage = 2, Fuel = "Elektrik", BigImageUrl = "/carbook-master/images/car-5.jpg" },
            new Car { CarId = 4, BrandId = 4, Model = "A3", CoverImageUrl = "/carbook-master/images/car-12.jpg", Km = 15000, Transmission = "Manuel", Seat = 4, Luggage = 1, Fuel = "Benzin", BigImageUrl = "/carbook-master/images/car-12.jpg" },
            new Car { CarId = 5, BrandId = 5, Model = "Clio", CoverImageUrl = "/carbook-master/images/car-4.jpg", Km = 3000, Transmission = "Manuel", Seat = 5, Luggage = 1, Fuel = "Dizel", BigImageUrl = "/carbook-master/images/car-4.jpg" },
            new Car { CarId = 6, BrandId = 6, Model = "Passat", CoverImageUrl = "/carbook-master/images/car-3.jpg", Km = 10000, Transmission = "Otomatik", Seat = 5, Luggage = 3, Fuel = "Elektrik", BigImageUrl = "/carbook-master/images/car-3.jpg" },
            new Car { CarId = 7, BrandId = 7, Model = "Corolla", CoverImageUrl = "/carbook-master/images/car-6.jpg", Km = 20000, Transmission = "Manuel", Seat = 5, Luggage = 2, Fuel = "Dizel", BigImageUrl = "/carbook-master/images/car-6.jpg" },
            new Car { CarId = 8, BrandId = 8, Model = "Cherokee", CoverImageUrl = "/carbook-master/images/car-8.jpg", Km = 15000, Transmission = "Otomatik", Seat = 5, Luggage = 2, Fuel = "Benzin", BigImageUrl = "/carbook-master/images/car-8.jpg" },
            new Car { CarId = 9, BrandId = 1, Model = "S 350 BlueTEC 4Matic", CoverImageUrl = "/carbook-master/images/car-7.jpg", Km = 18000, Transmission = "Otomatik", Seat = 5, Luggage = 3, Fuel = "Dizel", BigImageUrl = "/carbook-master/images/car-7.jpg" },
            new Car { CarId = 10, BrandId = 1, Model = "S 320 CDI", CoverImageUrl = "/carbook-master/images/car-9.jpg", Km = 22000, Transmission = "Manuel", Seat = 5, Luggage = 2, Fuel = "Dizel", BigImageUrl = "/carbook-master/images/car-9.jpg" },
            new Car { CarId = 11, BrandId = 1, Model = "S 400 400", CoverImageUrl = "/carbook-master/images/car-10.jpg", Km = 5000, Transmission = "Otomatik", Seat = 5, Luggage = 3, Fuel = "Elektrik", BigImageUrl = "/carbook-master/images/car-10.jpg" },
            new Car { CarId = 12, BrandId = 1, Model = "S 500 500 L", CoverImageUrl = "/carbook-master/images/car-11.jpg", Km = 12000, Transmission = "Manuel", Seat = 5, Luggage = 2, Fuel = "Benzin", BigImageUrl = "/carbook-master/images/car-11.jpg" }
        );
    }

}