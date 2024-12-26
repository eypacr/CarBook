using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class CarDescriptionConfiguration : IEntityTypeConfiguration<CarDescription>
{
    public void Configure(EntityTypeBuilder<CarDescription> builder)
    {
        builder.HasData(
                 new CarDescription
                 {
                     CarDescriptionId = 1,
                     CarId = 1, 
                     Details = "Mercedes E-200, şık ve güçlü bir sedan modelidir. Benzinli motoru, yüksek konforu ve zarif tasarımı ile öne çıkar."
                 },
                 new CarDescription
                 {
                     CarDescriptionId = 2,
                     CarId = 2, 
                     Details = "Range Rover Velar, lüks SUV sınıfında yer alır. Şık tasarımı, güçlü motoru ve 4x4 özellikleriyle dikkat çeker."
                 },
                 new CarDescription
                 {
                     CarDescriptionId = 3,
                     CarId = 3, 
                     Details = "BMW Serisi, dinamik sürüş deneyimi sunar. Modern tasarımı ve premium özellikleriyle uzun yolculuklarda konfor sağlar."
                 },
                 new CarDescription
                 {
                     CarDescriptionId = 4,
                     CarId = 4,
                     Details = "Audi A3, kompakt sınıfta lüks bir seçenektir. Güçlü motorları ve şık tasarımı ile şehir içi kullanım için ideal."
                 },
                 new CarDescription
                 {
                     CarDescriptionId = 5,
                     CarId = 5, 
                     Details = "Renault Clio, ekonomik bir hatchback modelidir. Kompakt yapısı, pratikliği ve düşük yakıt tüketimi ile şehir içi kullanımda tercih edilir."
                 },
                 new CarDescription
                 {
                     CarDescriptionId = 6,
                     CarId = 6, 
                     Details = "Volkswogen Passat, orta sınıf sedan bir araçtır. Geniş iç hacmi ve sağlam yapısıyla uzun yolculuklar için idealdir."
                 },
                 new CarDescription
                 {
                     CarDescriptionId = 7,
                     CarId = 7, 
                     Details = "Toyota Corolla, güvenli ve dayanıklı bir sedan modelidir. Düşük bakım maliyetleri ve ekonomik yakıt tüketimi ile öne çıkar."
                 },
                 new CarDescription
                 {
                     CarDescriptionId = 8,
                     CarId = 8,
                     Details = "Jeep Cherokee, arazi yetenekleri ile öne çıkan bir SUV'dur. Hem şehir içinde hem de zorlu yol koşullarında güçlü performans sergiler."
                 }
             );
    }
}
