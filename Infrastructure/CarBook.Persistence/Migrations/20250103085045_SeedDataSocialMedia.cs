using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataSocialMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FooterAddresses",
                keyColumn: "FooterAddressId",
                keyValue: 1,
                column: "Email",
                value: "info@AracKiralama.com");

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "SocialMediaId", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "fab fa-facebook", "Facebook", "https://www.facebook.com" },
                    { 2, "fab fa-twitter", "Twitter", "https://www.twitter.com" },
                    { 3, "fab fa-instagram", "Instagram", "https://www.instagram.com" },
                    { 4, "fab fa-linkedin", "LinkedIn", "https://www.linkedin.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMediaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMediaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMediaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMediaId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "FooterAddresses",
                keyColumn: "FooterAddressId",
                keyValue: 1,
                column: "Email",
                value: "info@carbook.com");
        }
    }
}
