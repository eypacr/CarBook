using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class CarFeatureConfiguration : IEntityTypeConfiguration<CarFeature>
{
    public void Configure(EntityTypeBuilder<CarFeature> builder)
    {
        builder.HasData(
            new CarFeature { CarFeatureId = 1, CarId = 1, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 2, CarId = 1, FeatureId = 2, Available = true },
            new CarFeature { CarFeatureId = 3, CarId = 1, FeatureId = 3, Available = true },
            new CarFeature { CarFeatureId = 4, CarId = 1, FeatureId = 4, Available = false },
            new CarFeature { CarFeatureId = 5, CarId = 2, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 6, CarId = 2, FeatureId = 2, Available = true },
            new CarFeature { CarFeatureId = 7, CarId = 2, FeatureId = 5, Available = true },
            new CarFeature { CarFeatureId = 8, CarId = 3, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 9, CarId = 3, FeatureId = 6, Available = true },
            new CarFeature { CarFeatureId = 10, CarId = 4, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 11, CarId = 4, FeatureId = 3, Available = true },
            new CarFeature { CarFeatureId = 12, CarId = 4, FeatureId = 8, Available = false },
            new CarFeature { CarFeatureId = 13, CarId = 5, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 14, CarId = 5, FeatureId = 2, Available = true },
            new CarFeature { CarFeatureId = 15, CarId = 6, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 16, CarId = 6, FeatureId = 3, Available = true },
            new CarFeature { CarFeatureId = 17, CarId = 7, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 18, CarId = 7, FeatureId = 4, Available = false },
            new CarFeature { CarFeatureId = 19, CarId = 8, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 20, CarId = 8, FeatureId = 5, Available = true },
            new CarFeature { CarFeatureId = 21, CarId = 9, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 22, CarId = 9, FeatureId = 6, Available = true },
            new CarFeature { CarFeatureId = 23, CarId = 10, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 24, CarId = 10, FeatureId = 3, Available = true },
            new CarFeature { CarFeatureId = 25, CarId = 11, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 26, CarId = 11, FeatureId = 4, Available = true },
            new CarFeature { CarFeatureId = 27, CarId = 12, FeatureId = 1, Available = true },
            new CarFeature { CarFeatureId = 28, CarId = 12, FeatureId = 8, Available = true }
        );
    }
}