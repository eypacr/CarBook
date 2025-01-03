using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
{
    public void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        builder.HasData(
            new SocialMedia { SocialMediaId = 1, Name = "Facebook", Url = "https://www.facebook.com", Icon = "fab fa-facebook" },
            new SocialMedia { SocialMediaId = 2, Name = "Twitter", Url = "https://www.twitter.com", Icon = "fab fa-twitter" },
            new SocialMedia { SocialMediaId = 3, Name = "Instagram", Url = "https://www.instagram.com", Icon = "fab fa-instagram" },
            new SocialMedia { SocialMediaId = 4, Name = "LinkedIn", Url = "https://www.linkedin.com", Icon = "fab fa-linkedin" }
        );
    }
}