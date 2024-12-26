using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.HasData(
            new Service { ServiceId = 1, Title = "Düğün Organizasyonu", Description = "Düğün gününüzü unutulmaz kılmak için profesyonel ve kapsamlı düğün organizasyonu hizmetleri sunuyoruz.", IconUrl = "flaticon-wedding-car" },
            new Service { ServiceId = 2, Title = "Şehir Turları", Description = "Şehir turlarınızın unutulmaz olması için profesyonel ve kapsamlı hizmetler sunuyoruz.", IconUrl = "flaticon-transportation" },
            new Service { ServiceId = 3, Title = "VIP Servis", Description = "VIP servislerimiz ile özel anlarınızı unutulmaz kılmak için profesyonel ve kapsamlı hizmetler sunuyoruz.", IconUrl = "flaticon-car" },
            new Service { ServiceId = 4, Title = "Havalimanı Aktarmaları", Description = "Havalimanı aktarmalarınız için profesyonel ve güvenilir VIP servisler sunuyoruz.", IconUrl = "flaticon-rent" }
            );
    }
}