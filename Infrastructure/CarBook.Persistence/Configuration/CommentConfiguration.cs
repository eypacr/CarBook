using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasData(
            new Comment
            {
                CommentId = 1,
                Name = "Ahmet",
                Surname = "Yılmaz",
                Text = "Elektrikli araçlar hakkında çok bilgilendirici bir yazı olmuş.",
                Email = "ahmet.yilmaz@example.com",
                CreatedDate = new DateTime(2023, 6, 16, 10, 20, 0),
                BlogId = 1
            },
            new Comment
            {
                CommentId = 2,
                Name = "Mehmet",
                Surname = "Kaya",
                Text = "SUV araçları gerçekten çok kullanışlı ve konforlu. Güzel bir yazı.",
                Email = "mehmet.kaya@example.com",
                CreatedDate = new DateTime(2023, 7, 21, 14, 30, 0),
                BlogId = 2
            },
            new Comment
            {
                CommentId = 3,
                Name = "Ayşe",
                Surname = "Demir",
                Text = "Sedan arabaların konforu gerçekten çok güzel, ancak ben performansı biraz daha yüksek beklerdim.",
                Email = "ayse.demir@example.com",
                CreatedDate = new DateTime(2023, 8, 12, 9, 15, 0),
                BlogId = 3
            },
            new Comment
            {
                CommentId = 4,
                Name = "Fatma",
                Surname = "Can",
                Text = "Kamyonlar çok dayanıklı ama şehir içi kullanımda zorlanıyorlar. Güzel yazı.",
                Email = "fatma.can@example.com",
                CreatedDate = new DateTime(2023, 9, 6, 16, 45, 0),
                BlogId = 4
            },
            new Comment
            {
                CommentId = 5,
                Name = "Ali",
                Surname = "Şahin",
                Text = "Elektrikli araçların geleceği çok parlak görünüyor, yakından takip ediyorum.",
                Email = "ali.sahin@example.com",
                CreatedDate = new DateTime(2023, 6, 17, 11, 10, 0),
                BlogId = 1
            },
            new Comment
            {
                CommentId = 6,
                Name = "Elif",
                Surname = "Acar",
                Text = "SUV modellerinin avantajları gerçekten doğru tespit edilmiş, ancak fiyatları biraz yüksek.",
                Email = "elif.acar@example.com",
                CreatedDate = new DateTime(2023, 7, 22, 13, 0, 0),
                BlogId = 2
            }
        );
    }
}
