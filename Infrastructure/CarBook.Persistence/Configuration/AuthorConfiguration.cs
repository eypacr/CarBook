using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasData(
            new Author { AuthorId = 1, Name = "Ahmet Yılmaz", ImageUrl = "/carbook-master/images/Person_3.jpg", Description = "Deneyimli bir otomobil meraklısı ve blog yazarı." },
            new Author { AuthorId = 2, Name = "Mehmet Ak", ImageUrl = "/carbook-master/images/Person_2.jpg", Description = "Otomobil endüstrisinde uzmanlaşmış bir mühendis." },
            new Author { AuthorId = 3, Name = "Mustafa Çelik", ImageUrl = "/carbook-master/images/Person_1.jpg", Description = "Araç incelemeleri ve test sürüşleri konusunda uzman." },
            new Author { AuthorId = 4, Name = "Ali Vural", ImageUrl = "/carbook-master/images/Person_2.jpg", Description = "Otomobil teknolojileri ve yenilikler konusunda bilgili bir gazeteci." }
        );
    }

}
