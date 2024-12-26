using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBook.Persistence.Configuration;

public class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
{
    public void Configure(EntityTypeBuilder<Testimonial> builder)
    {
        builder.HasData(
            new Testimonial { TestimonialId = 1, Name = "Semih Sarı", Title = "Proje Yöneticisi", ImageUrl = "/carbook-master/images/person_1.jpg", Comment = "Proje Yöneticisi, projelerin zamanında, bütçeye uygun ve kaliteye uygun tamamlanmasını sağlar, ekipleri yönetir ve kaynakları etkin kullanır." },
            new Testimonial { TestimonialId = 2, Name = "Ahmet Öztürk", Title = "Endüstri Mühendisi", ImageUrl = "/carbook-master/images/person_2.jpg", Comment = "Endüstri Mühendisi, üretim süreçlerini ve kaynakları en verimli şekilde düzenleyerek verimliliği artıran ve maliyetleri düşüren bir profesyoneldir." },
            new Testimonial { TestimonialId = 3, Name = "Mehmet Ali Yıldız", Title = "Makine Mühendisi", ImageUrl = "/carbook-master/images/person_3.jpg", Comment = "Makine Mühendisi, mekanik sistemlerin tasarım, üretim ve bakım süreçlerini yöneterek verimliliği artıran ve teknik çözümler üreten uzmandır." },
            new Testimonial { TestimonialId = 4, Name = "Eyyüp Acar", Title = "Bilgisayar Mühendisi", ImageUrl = "/carbook-master/images/person_4.jpg", Comment = "Bilgisayar Mühendisi, yazılım ve donanım sistemlerini tasarlayan, geliştiren ve optimize eden, teknoloji çözümleri üreten uzmandır." }
            );
    }
}