using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataFooterAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FooterAddresses",
                columns: new[] { "FooterAddressId", "Address", "Description", "Email", "Phone" },
                values: new object[,]
                {
                    { 1, "123 Ana Cadde, Şehir, Ülke", "Merkezi Ofis", "info@carbook.com", "+90 123 456 7890" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FooterAddresses",
                keyColumn: "FooterAddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FooterAddresses",
                keyColumn: "FooterAddressId",
                keyValue: 2);
        }
    }
}
