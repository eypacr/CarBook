using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        builder.HasData(
            new Feature { FeatureId = 1, Name = "Klima" },
            new Feature { FeatureId = 2, Name = "GPS Navigasyon" },
            new Feature { FeatureId = 3, Name = "Bluetooth Bağlantısı" },
            new Feature { FeatureId = 4, Name = "Isıtmalı Koltuklar" },
            new Feature { FeatureId = 5, Name = "Sunroof" },
            new Feature { FeatureId = 6, Name = "Geri Görüş Kamerası" },
            new Feature { FeatureId = 7, Name = "Hız Sabitleyici" },
            new Feature { FeatureId = 8, Name = "Park Sensörleri" }
        );
    }
}