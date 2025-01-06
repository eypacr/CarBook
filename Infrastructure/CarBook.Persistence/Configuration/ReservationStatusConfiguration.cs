using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class ReservationStatusConfiguration : IEntityTypeConfiguration<ReservationStatus>
{
    public void Configure(EntityTypeBuilder<ReservationStatus> builder)
    {
        builder.HasData(
            new ReservationStatus { ReservationStatusId = 1, Name = "Beklemede", Icon = "fa-clock" },
            new ReservationStatus { ReservationStatusId = 2, Name = "Onaylandı", Icon = "fa-check-circle" },
            new ReservationStatus { ReservationStatusId = 3, Name = "İptal Edildi", Icon = "fa-times-circle" },
            new ReservationStatus { ReservationStatusId = 4, Name = "Tamamlandı", Icon = "fa-check-square" },
            new ReservationStatus { ReservationStatusId = 5, Name = "Teslimat Sürecinde", Icon = "fa-car" },
            new ReservationStatus { ReservationStatusId = 6, Name = "Reddedildi", Icon = "fa-ban" },
            new ReservationStatus { ReservationStatusId = 7, Name = "Ödeme Bekleniyor", Icon = "fa-money-bill" },
            new ReservationStatus { ReservationStatusId = 8, Name = "Teslimat Bekleniyor", Icon = "fa-map-marker-alt" },
            new ReservationStatus { ReservationStatusId = 9, Name = "Gelmedi", Icon = "fa-user-slash" },
            new ReservationStatus { ReservationStatusId = 10, Name = "Ücret İade Edildi", Icon = "fa-undo" }
        );
    }
}
