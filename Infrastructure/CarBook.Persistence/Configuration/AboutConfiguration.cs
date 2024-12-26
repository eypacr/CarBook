using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class AboutConfiguration : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.HasData(
            new About { AboutId = 1, Title = "CarBook'a Hoş Geldiniz! Yola Çıkmaya Hazır Mısınız ?", Description = "CarBook, araç kiralama sektöründe en iyi hizmeti sunmak için kendini sürekli geliştiren bir platformdur. Modern teknoloji ile hızlı ve kolay araç kiralama imkanı sunarken, geniş araç yelpazesiyle her ihtiyaca uygun seçenekler sağlar. Müşteri memnuniyetini ön planda tutarak, güvenli ve pratik bir kiralama deneyimi sunuyoruz.", ImageUrl = "/carbook-master/images/bg_3.jpg" }
            );
    }
}
