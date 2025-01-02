using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "BlogId", "CreatedDate", "Email", "Name", "Surname", "Text" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 16, 10, 20, 0, 0, DateTimeKind.Unspecified), "ahmet.yilmaz@example.com", "Ahmet", "Yılmaz", "Elektrikli araçlar hakkında çok bilgilendirici bir yazı olmuş." },
                    { 2, 2, new DateTime(2023, 7, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), "mehmet.kaya@example.com", "Mehmet", "Kaya", "SUV araçları gerçekten çok kullanışlı ve konforlu. Güzel bir yazı." },
                    { 3, 3, new DateTime(2023, 8, 12, 9, 15, 0, 0, DateTimeKind.Unspecified), "ayse.demir@example.com", "Ayşe", "Demir", "Sedan arabaların konforu gerçekten çok güzel, ancak ben performansı biraz daha yüksek beklerdim." },
                    { 4, 4, new DateTime(2023, 9, 6, 16, 45, 0, 0, DateTimeKind.Unspecified), "fatma.can@example.com", "Fatma", "Can", "Kamyonlar çok dayanıklı ama şehir içi kullanımda zorlanıyorlar. Güzel yazı." },
                    { 5, 1, new DateTime(2023, 6, 17, 11, 10, 0, 0, DateTimeKind.Unspecified), "ali.sahin@example.com", "Ali", "Şahin", "Elektrikli araçların geleceği çok parlak görünüyor, yakından takip ediyorum." },
                    { 6, 2, new DateTime(2023, 7, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), "elif.acar@example.com", "Elif", "Acar", "SUV modellerinin avantajları gerçekten doğru tespit edilmiş, ancak fiyatları biraz yüksek." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6);
        }
    }
}
