using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasData(
            new Review
            {
                ReviewId = 1,
                Name = "Ali",
                Surname = "Kaya",
                Email = "ali.kaya@example.com",
                Text = "Mükemmel bir araç, çok memnun kaldım.",
                ImageUrl = "https://i.pravatar.cc/150?img=1",
                CreatedDate = new DateTime(2025, 1, 10),
                IsApproved = true,
                CarId = 1
            },
            new Review
            {
                ReviewId = 2,
                Name = "Ayşe",
                Surname = "Demir",
                Email = "ayse.demir@example.com",
                Text = "Arazi şartlarında mükemmel performans.",
                ImageUrl = "https://i.pravatar.cc/150?img=2",
                CreatedDate = new DateTime(2025, 1, 9),
                IsApproved = false,
                CarId = 2
            },
            new Review
            {
                ReviewId = 3,
                Name = "Mehmet",
                Surname = "Çelik",
                Email = "mehmet.celik@example.com",
                Text = "Fiyatına göre çok iyi.",
                ImageUrl = "https://i.pravatar.cc/150?img=3",
                CreatedDate = new DateTime(2025, 1, 8),
                IsApproved = true,
                CarId = 3
            },
            new Review
            {
                ReviewId = 4,
                Name = "Fatma",
                Surname = "Koç",
                Email = "fatma.koc@example.com",
                Text = "Daha iyi bir alternatif bulmak zor.",
                ImageUrl = "https://i.pravatar.cc/150?img=4",
                CreatedDate = new DateTime(2025, 1, 7),
                IsApproved = true,
                CarId = 4
            },
            new Review
            {
                ReviewId = 5,
                Name = "Cem",
                Surname = "Aydın",
                Email = "cem.aydin@example.com",
                Text = "Yakıt tüketimi biraz fazla ama genel olarak iyi.",
                ImageUrl = "https://i.pravatar.cc/150?img=5",
                CreatedDate = new DateTime(2025, 1, 6),
                IsApproved = true,
                CarId = 5
            },
            new Review
            {
                ReviewId = 6,
                Name = "Zeynep",
                Surname = "Şahin",
                Email = "zeynep.sahin@example.com",
                Text = "Harika bir sürüş deneyimi sağlıyor.",
                ImageUrl = "https://i.pravatar.cc/150?img=6",
                CreatedDate = new DateTime(2025, 1, 5),
                IsApproved = true,
                CarId = 6
            },
            new Review
            {
                ReviewId = 7,
                Name = "Hakan",
                Surname = "Yılmaz",
                Email = "hakan.yilmaz@example.com",
                Text = "Geniş aileler için ideal bir araç.",
                ImageUrl = "https://i.pravatar.cc/150?img=7",
                CreatedDate = new DateTime(2025, 1, 4),
                IsApproved = true,
                CarId = 7
            },
            new Review
            {
                ReviewId = 8,
                Name = "Elif",
                Surname = "Demirci",
                Email = "elif.demirci@example.com",
                Text = "Elektrikli olduğu için çok çevre dostu.",
                ImageUrl = "https://i.pravatar.cc/150?img=8",
                CreatedDate = new DateTime(2025, 1, 3),
                IsApproved = true,
                CarId = 8
            },
            new Review
            {
                ReviewId = 9,
                Name = "Burak",
                Surname = "Tuna",
                Email = "burak.tuna@example.com",
                Text = "Konfor ve lüks bir arada.",
                ImageUrl = "https://i.pravatar.cc/150?img=9",
                CreatedDate = new DateTime(2025, 1, 2),
                IsApproved = true,
                CarId = 9
            },
            new Review
            {
                ReviewId = 10,
                Name = "Sevgi",
                Surname = "Dursun",
                Email = "sevgi.dursun@example.com",
                Text = "Çok dayanıklı bir araç, her koşulda kullanılabilir.",
                ImageUrl = "https://i.pravatar.cc/150?img=10",
                CreatedDate = new DateTime(2025, 1, 1),
                IsApproved = true,
                CarId = 10
            },
            new Review
            {
                ReviewId = 11,
                Name = "Ahmet",
                Surname = "Kılıç",
                Email = "ahmet.kilic@example.com",
                Text = "Mükemmel tasarım ve performans.",
                ImageUrl = "https://i.pravatar.cc/150?img=11",
                CreatedDate = new DateTime(2024, 12, 31),
                IsApproved = true,
                CarId = 11
            },
            new Review
            {
                ReviewId = 12,
                Name = "Selin",
                Surname = "Altın",
                Email = "selin.altin@example.com",
                Text = "Göz alıcı bir tasarımı var.",
                ImageUrl = "https://i.pravatar.cc/150?img=12",
                CreatedDate = new DateTime(2024, 12, 30),
                IsApproved = true,
                CarId = 12
            },
            new Review
            {
                ReviewId = 13,
                Name = "Emre",
                Surname = "Çetin",
                Email = "emre.cetin@example.com",
                Text = "Yakıt tasarrufu harika.",
                ImageUrl = "https://i.pravatar.cc/150?img=13",
                CreatedDate = new DateTime(2024, 12, 29),
                IsApproved = true,
                CarId = 12
            },
            new Review
            {
                ReviewId = 14,
                Name = "Gizem",
                Surname = "Topal",
                Email = "gizem.topal@example.com",
                Text = "Konfor ve teknoloji bir arada.",
                ImageUrl = "https://i.pravatar.cc/150?img=14",
                CreatedDate = new DateTime(2024, 12, 28),
                IsApproved = true,
                CarId = 11
            },
            new Review
            {
                ReviewId = 15,
                Name = "Barış",
                Surname = "Kurt",
                Email = "baris.kurt@example.com",
                Text = "Arazi performansı kusursuz.",
                ImageUrl = "https://i.pravatar.cc/150?img=15",
                CreatedDate = new DateTime(2024, 12, 27),
                IsApproved = true,
                CarId = 10
            },
            new Review
            {
                ReviewId = 16,
                Name = "Derya",
                Surname = "Aksoy",
                Email = "derya.aksoy@example.com",
                Text = "Tam bir aile aracı.",
                ImageUrl = "https://i.pravatar.cc/150?img=16",
                CreatedDate = new DateTime(2024, 12, 26),
                IsApproved = true,
                CarId = 9
            }
        );
    }
}
