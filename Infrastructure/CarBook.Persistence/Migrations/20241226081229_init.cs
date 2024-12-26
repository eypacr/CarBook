using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    BannerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.BannerId);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureId);
                });

            migrationBuilder.CreateTable(
                name: "FooterAddresses",
                columns: table => new
                {
                    FooterAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterAddresses", x => x.FooterAddressId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    PricingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.PricingId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaId);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seat = table.Column<byte>(type: "tinyint", nullable: false),
                    Luggage = table.Column<byte>(type: "tinyint", nullable: false),
                    Fuel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BigImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blogs_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarDescriptions",
                columns: table => new
                {
                    CarDescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDescriptions", x => x.CarDescriptionId);
                    table.ForeignKey(
                        name: "FK_CarDescriptions_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    CarFeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatures", x => x.CarFeatureId);
                    table.ForeignKey(
                        name: "FK_CarFeatures_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "FeatureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarPricings",
                columns: table => new
                {
                    CarPricingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    PricingId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPricings", x => x.CarPricingId);
                    table.ForeignKey(
                        name: "FK_CarPricings_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarPricings_Pricings_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricings",
                        principalColumn: "PricingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagClouds",
                columns: table => new
                {
                    TagCloudId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagClouds", x => x.TagCloudId);
                    table.ForeignKey(
                        name: "FK_TagClouds_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "AboutId", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, "CarBook, araç kiralama sektöründe en iyi hizmeti sunmak için kendini sürekli geliştiren bir platformdur. Modern teknoloji ile hızlı ve kolay araç kiralama imkanı sunarken, geniş araç yelpazesiyle her ihtiyaca uygun seçenekler sağlar. Müşteri memnuniyetini ön planda tutarak, güvenli ve pratik bir kiralama deneyimi sunuyoruz.", "/carbook-master/images/bg_3.jpg", "CarBook'a Hoş Geldiniz! Yola Çıkmaya Hazır Mısınız ?" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Deneyimli bir otomobil meraklısı ve blog yazarı.", "/carbook-master/images/Person_3.jpg", "Ahmet Yılmaz" },
                    { 2, "Otomobil endüstrisinde uzmanlaşmış bir mühendis.", "/carbook-master/images/Person_2.jpg", "Mehmet Ak" },
                    { 3, "Araç incelemeleri ve test sürüşleri konusunda uzman.", "/carbook-master/images/Person_1.jpg", "Mustafa Çelik" },
                    { 4, "Otomobil teknolojileri ve yenilikler konusunda bilgili bir gazeteci.", "/carbook-master/images/Person_2.jpg", "Ali Vural" }
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "BannerId", "Description", "Title", "VideoDescription", "VideoUrl" },
                values: new object[] { 1, "CarBook ile 7/24 kolay ve hızlı araç kiralama! Geniş araç seçenekleri, uygun fiyatlar ve kesintisiz hizmetle dilediğiniz zaman aracınızı kiralayın.", "Kolay Ve Hızlı Araç Kiralayın", "Tanıtım Videosu", "https://www.youtube.com/watch?v=ZlaVqOI3cCQ" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Name" },
                values: new object[,]
                {
                    { 1, "Mercedes" },
                    { 2, "Range Rover" },
                    { 3, "BMW" },
                    { 4, "Audi" },
                    { 5, "Renault" },
                    { 6, "Volkswogen" },
                    { 7, "Toyota" },
                    { 8, "Jeep" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Hibrit Araçlar" },
                    { 2, "Araç Bakımları" },
                    { 3, "Periyodik Muayeneler" },
                    { 4, "Elektrikli Araçlar" },
                    { 5, "Araç Temizliği" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "Name" },
                values: new object[,]
                {
                    { 1, "Klima" },
                    { 2, "GPS Navigasyon" },
                    { 3, "Bluetooth Bağlantısı" },
                    { 4, "Isıtmalı Koltuklar" },
                    { 5, "Sunroof" },
                    { 6, "Geri Görüş Kamerası" },
                    { 7, "Hız Sabitleyici" },
                    { 8, "Park Sensörleri" }
                });

            migrationBuilder.InsertData(
                table: "Pricings",
                columns: new[] { "PricingId", "Name" },
                values: new object[,]
                {
                    { 1, "Saatlik" },
                    { 2, "Günlük" },
                    { 3, "Haftalık" },
                    { 4, "Aylık" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "Description", "IconUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Düğün gününüzü unutulmaz kılmak için profesyonel ve kapsamlı düğün organizasyonu hizmetleri sunuyoruz.", "flaticon-wedding-car", "Düğün Organizasyonu" },
                    { 2, "Şehir turlarınızın unutulmaz olması için profesyonel ve kapsamlı hizmetler sunuyoruz.", "flaticon-transportation", "Şehir Turları" },
                    { 3, "VIP servislerimiz ile özel anlarınızı unutulmaz kılmak için profesyonel ve kapsamlı hizmetler sunuyoruz.", "flaticon-car", "VIP Servis" },
                    { 4, "Havalimanı aktarmalarınız için profesyonel ve güvenilir VIP servisler sunuyoruz.", "flaticon-rent", "Havalimanı Aktarmaları" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "TestimonialId", "Comment", "ImageUrl", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "Proje Yöneticisi, projelerin zamanında, bütçeye uygun ve kaliteye uygun tamamlanmasını sağlar, ekipleri yönetir ve kaynakları etkin kullanır.", "/carbook-master/images/person_1.jpg", "Semih Sarı", "Proje Yöneticisi" },
                    { 2, "Endüstri Mühendisi, üretim süreçlerini ve kaynakları en verimli şekilde düzenleyerek verimliliği artıran ve maliyetleri düşüren bir profesyoneldir.", "/carbook-master/images/person_2.jpg", "Ahmet Öztürk", "Endüstri Mühendisi" },
                    { 3, "Makine Mühendisi, mekanik sistemlerin tasarım, üretim ve bakım süreçlerini yöneterek verimliliği artıran ve teknik çözümler üreten uzmandır.", "/carbook-master/images/person_3.jpg", "Mehmet Ali Yıldız", "Makine Mühendisi" },
                    { 4, "Bilgisayar Mühendisi, yazılım ve donanım sistemlerini tasarlayan, geliştiren ve optimize eden, teknoloji çözümleri üreten uzmandır.", "/carbook-master/images/person_4.jpg", "Eyyüp Acar", "Bilgisayar Mühendisi" }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "AuthorID", "CategoryId", "CoverImageUrl", "CreatedDate", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 1, 4, "/carbook-master/images/bg_3.jpg", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektrikli araçların geleceği ve çevre üzerindeki etkileri hakkında bilgi veren bir yazı.", "Elektrikli Araçların Geleceği" },
                    { 2, 2, 2, "/carbook-master/images/image_1.jpg", new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "SUV araçlarının sağladığı avantajlar ve neden tercih edildikleri üzerine bir yazı.", "SUV Modellerinin Avantajları" },
                    { 3, 3, 1, "/carbook-master/images/image_2.jpg", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sedan araba modellerinin konfor ve performans açısından sundukları özellikler.", "Sedan Arabalar: Konfor ve Performans" },
                    { 4, 4, 3, "/carbook-master/images/image_3.jpg", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kamyonların güçlü motor yapıları ve dayanıklılıkları üzerine detaylı bir yazı.", "Kamyonların Dayanıklılığı ve Gücü" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "BigImageUrl", "BrandId", "CoverImageUrl", "Fuel", "Km", "Luggage", "Model", "Seat", "Transmission" },
                values: new object[,]
                {
                    { 1, "/carbook-master/images/car-1.jpg", 1, "/carbook-master/images/car-1.jpg", "Benzin", 0, (byte)2, "E-200", (byte)5, "Otomatik" },
                    { 2, "/carbook-master/images/car-2.jpg", 2, "/carbook-master/images/car-2.jpg", "Dizel", 0, (byte)2, "Velar", (byte)5, "Otomatik" },
                    { 3, "/carbook-master/images/car-5.jpg", 3, "/carbook-master/images/car-5.jpg", "Benzin", 0, (byte)2, "BMW Serisi", (byte)5, "Otomatik" },
                    { 4, "/carbook-master/images/car-12.jpg", 4, "/carbook-master/images/car-12.jpg", "Benzin", 0, (byte)2, "A3", (byte)5, "Manuel" },
                    { 5, "/carbook-master/images/car-4.jpg", 5, "/carbook-master/images/car-4.jpg", "Benzin", 0, (byte)2, "Clio", (byte)5, "Manuel" },
                    { 6, "/carbook-master/images/car-3.jpg", 6, "/carbook-master/images/car-3.jpg", "Dizel", 0, (byte)2, "Passat", (byte)5, "Otomatik" },
                    { 7, "/carbook-master/images/car-6.jpg", 7, "/carbook-master/images/car-6.jpg", "Dizel", 0, (byte)2, "Corolla", (byte)5, "Manuel" },
                    { 8, "/carbook-master/images/car-8.jpg", 8, "/carbook-master/images/car-8.jpg", "Benzin", 0, (byte)2, "Cherokee", (byte)5, "Manuel" },
                    { 9, "/carbook-master/images/car-7.jpg", 1, "/carbook-master/images/car-7.jpg", "Benzin", 0, (byte)2, " S 350 BlueTEC 4Matic ", (byte)5, "Manuel" },
                    { 10, "/carbook-master/images/car-9.jpg", 1, "/carbook-master/images/car-9.jpg", "Dizel", 0, (byte)2, "S 320 CDI ", (byte)5, "Otomatik" },
                    { 11, "/carbook-master/images/car-10.jpg", 1, "/carbook-master/images/car-10.jpg", "Dizel", 0, (byte)2, "S 400 400", (byte)5, "Otomatik" },
                    { 12, "/carbook-master/images/car-11.jpg", 1, "/carbook-master/images/car-11.jpg", "Benzin", 0, (byte)2, "S 500 500 L", (byte)5, "Otomatik" }
                });

            migrationBuilder.InsertData(
                table: "CarDescriptions",
                columns: new[] { "CarDescriptionId", "CarId", "Details" },
                values: new object[,]
                {
                    { 1, 1, "Mercedes E-200, şık ve güçlü bir sedan modelidir. Benzinli motoru, yüksek konforu ve zarif tasarımı ile öne çıkar." },
                    { 2, 2, "Range Rover Velar, lüks SUV sınıfında yer alır. Şık tasarımı, güçlü motoru ve 4x4 özellikleriyle dikkat çeker." },
                    { 3, 3, "BMW Serisi, dinamik sürüş deneyimi sunar. Modern tasarımı ve premium özellikleriyle uzun yolculuklarda konfor sağlar." },
                    { 4, 4, "Audi A3, kompakt sınıfta lüks bir seçenektir. Güçlü motorları ve şık tasarımı ile şehir içi kullanım için ideal." },
                    { 5, 5, "Renault Clio, ekonomik bir hatchback modelidir. Kompakt yapısı, pratikliği ve düşük yakıt tüketimi ile şehir içi kullanımda tercih edilir." },
                    { 6, 6, "Volkswogen Passat, orta sınıf sedan bir araçtır. Geniş iç hacmi ve sağlam yapısıyla uzun yolculuklar için idealdir." },
                    { 7, 7, "Toyota Corolla, güvenli ve dayanıklı bir sedan modelidir. Düşük bakım maliyetleri ve ekonomik yakıt tüketimi ile öne çıkar." },
                    { 8, 8, "Jeep Cherokee, arazi yetenekleri ile öne çıkan bir SUV'dur. Hem şehir içinde hem de zorlu yol koşullarında güçlü performans sergiler." }
                });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "Available", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { 1, true, 1, 1 },
                    { 2, true, 1, 2 },
                    { 3, true, 1, 3 },
                    { 4, false, 1, 4 },
                    { 5, true, 2, 1 },
                    { 6, true, 2, 2 },
                    { 7, true, 2, 5 },
                    { 8, true, 3, 1 },
                    { 9, true, 3, 6 },
                    { 10, true, 4, 1 },
                    { 11, true, 4, 3 },
                    { 12, false, 4, 8 },
                    { 13, true, 5, 1 },
                    { 14, true, 5, 2 },
                    { 15, true, 6, 1 },
                    { 16, true, 6, 3 },
                    { 17, true, 7, 1 },
                    { 18, false, 7, 4 },
                    { 19, true, 8, 1 },
                    { 20, true, 8, 5 },
                    { 21, true, 9, 1 },
                    { 22, true, 9, 6 },
                    { 23, true, 10, 1 },
                    { 24, true, 10, 3 },
                    { 25, true, 11, 1 },
                    { 26, true, 11, 4 },
                    { 27, true, 12, 1 },
                    { 28, true, 12, 8 }
                });

            migrationBuilder.InsertData(
                table: "CarPricings",
                columns: new[] { "CarPricingId", "Amount", "CarId", "PricingId" },
                values: new object[,]
                {
                    { 1, 900m, 1, 2 },
                    { 2, 950m, 2, 2 },
                    { 3, 1000m, 3, 2 },
                    { 4, 1050m, 4, 2 },
                    { 5, 1100m, 5, 2 },
                    { 6, 1150m, 6, 2 },
                    { 7, 1200m, 7, 2 },
                    { 8, 1250m, 8, 2 },
                    { 9, 1300m, 9, 2 },
                    { 10, 1350m, 10, 2 },
                    { 11, 1400m, 11, 2 },
                    { 12, 1450m, 12, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorID",
                table: "Blogs",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDescriptions_CarId",
                table: "CarDescriptions",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarId",
                table: "CarFeatures",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_FeatureId",
                table: "CarFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CarPricings_CarId",
                table: "CarPricings",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarPricings_PricingId",
                table: "CarPricings",
                column: "PricingId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_TagClouds_BlogId",
                table: "TagClouds",
                column: "BlogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "CarDescriptions");

            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "CarPricings");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "FooterAddresses");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "TagClouds");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Pricings");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
