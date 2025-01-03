using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration
{
    public class FooterAddressConfiguration : IEntityTypeConfiguration<FooterAddress>
    {
        public void Configure(EntityTypeBuilder<FooterAddress> builder)
        {
            builder.HasData(
                new FooterAddress
                {
                    FooterAddressId = 1,
                    Description = "Merkezi Ofis",
                    Address = "123 Ana Cadde, Şehir, Ülke",
                    Phone = "+90 123 456 7890",
                    Email = "info@AracKiralama.com"
                }
            );
        }
    }
}
