using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.HasData(
            new Location { LocationId = 1, Name = "İstanbul" },
            new Location { LocationId = 2, Name = "Ankara" },
            new Location { LocationId = 3, Name = "İzmir" },
            new Location { LocationId = 4, Name = "Bursa" },
            new Location { LocationId = 5, Name = "Antalya" },
            new Location { LocationId = 6, Name = "Adana" }
        );
    }
}