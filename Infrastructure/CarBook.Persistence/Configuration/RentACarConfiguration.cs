using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class RentACarConfiguration : IEntityTypeConfiguration<RentACar>
{
    public void Configure(EntityTypeBuilder<RentACar> builder)
    {
        builder.HasData(
            new RentACar { RentACarId = 1, LocationId = 1, CarId = 1, Available = true },
            new RentACar { RentACarId = 2, LocationId = 2, CarId = 2, Available = false },
            new RentACar { RentACarId = 3, LocationId = 3, CarId = 3, Available = true },
            new RentACar { RentACarId = 4, LocationId = 4, CarId = 4, Available = false },
            new RentACar { RentACarId = 5, LocationId = 5, CarId = 5, Available = true },
            new RentACar { RentACarId = 6, LocationId = 6, CarId = 6, Available = true },
            new RentACar { RentACarId = 7, LocationId = 1, CarId = 7, Available = true },
            new RentACar { RentACarId = 8, LocationId = 2, CarId = 8, Available = false },
            new RentACar { RentACarId = 9, LocationId = 3, CarId = 9, Available = true },
            new RentACar { RentACarId = 10, LocationId = 4, CarId = 10, Available = true },
            new RentACar { RentACarId = 11, LocationId = 5, CarId = 11, Available = true },
            new RentACar { RentACarId = 12, LocationId = 6, CarId = 12, Available = true }
        );
    }
}
