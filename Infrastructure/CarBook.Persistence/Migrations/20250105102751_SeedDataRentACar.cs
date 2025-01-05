using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataRentACar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RentACars",
                columns: new[] { "RentACarId", "Available", "CarId", "LocationId" },
                values: new object[,]
                {
                    { 1, true, 1, 1 },
                    { 2, false, 2, 2 },
                    { 3, true, 3, 3 },
                    { 4, false, 4, 4 },
                    { 5, true, 5, 5 },
                    { 6, true, 6, 6 },
                    { 7, true, 7, 1 },
                    { 8, false, 8, 2 },
                    { 9, true, 9, 3 },
                    { 10, true, 10, 4 },
                    { 11, true, 11, 5 },
                    { 12, true, 12, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "RentACarId",
                keyValue: 12);
        }
    }
}
