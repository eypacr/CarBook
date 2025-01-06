using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.HasOne(x => x.PickUpLocation)
                .WithMany(y => y.PickUpReservation)
                  .HasForeignKey(m => m.PickUpLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(x => x.DropOffLocation)
           .WithMany(y => y.DropOffReservation)
             .HasForeignKey(m => m.DropOffLocationId)
           .OnDelete(DeleteBehavior.ClientSetNull);

    }
}
