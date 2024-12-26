using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.HasData(
            new Blog
            {
                BlogId = 1,
                Title = "Elektrikli Araçların Geleceği",
                AuthorID = 1,
                CoverImageUrl = "/carbook-master/images/bg_3.jpg",
                CreatedDate = new DateTime(2023, 6, 15),
                CategoryId = 4,
                Description = "Elektrikli araçların geleceği ve çevre üzerindeki etkileri hakkında bilgi veren bir yazı."
            },
            new Blog
            {
                BlogId = 2,
                Title = "SUV Modellerinin Avantajları",
                AuthorID = 2,
                CoverImageUrl = "/carbook-master/images/image_1.jpg",
                CreatedDate = new DateTime(2023, 7, 20),
                CategoryId = 2,
                Description = "SUV araçlarının sağladığı avantajlar ve neden tercih edildikleri üzerine bir yazı."
            },
            new Blog
            {
                BlogId = 3,
                Title = "Sedan Arabalar: Konfor ve Performans",
                AuthorID = 3,
                CoverImageUrl = "/carbook-master/images/image_2.jpg",
                CreatedDate = new DateTime(2023, 8, 10),
                CategoryId = 1,
                Description = "Sedan araba modellerinin konfor ve performans açısından sundukları özellikler."
            },
            new Blog
            {
                BlogId = 4,
                Title = "Kamyonların Dayanıklılığı ve Gücü",
                AuthorID = 4,
                CoverImageUrl = "/carbook-master/images/image_3.jpg",
                CreatedDate = new DateTime(2023, 9, 5),
                CategoryId = 3,
                Description = "Kamyonların güçlü motor yapıları ve dayanıklılıkları üzerine detaylı bir yazı."
            }
        );
    }
}
