using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class BannerConfiguration : IEntityTypeConfiguration<Banner>
{
    public void Configure(EntityTypeBuilder<Banner> builder)
    {
        builder.HasData(
            new Banner { BannerId = 1, Title = "Kolay Ve Hızlı Araç Kiralayın", Description= "CarBook ile 7/24 kolay ve hızlı araç kiralama! Geniş araç seçenekleri, uygun fiyatlar ve kesintisiz hizmetle dilediğiniz zaman aracınızı kiralayın.", VideoDescription = "Tanıtım Videosu", VideoUrl= "https://www.youtube.com/watch?v=ZlaVqOI3cCQ" }
            );
    }
}