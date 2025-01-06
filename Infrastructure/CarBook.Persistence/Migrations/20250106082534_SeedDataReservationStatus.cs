using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataReservationStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReservationStatuses",
                columns: new[] { "ReservationStatusId", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "fa-clock", "Beklemede" },
                    { 2, "fa-check-circle", "Onaylandı" },
                    { 3, "fa-times-circle", "İptal Edildi" },
                    { 4, "fa-check-square", "Tamamlandı" },
                    { 5, "fa-car", "Teslimat Sürecinde" },
                    { 6, "fa-ban", "Reddedildi" },
                    { 7, "fa-money-bill", "Ödeme Bekleniyor" },
                    { 8, "fa-map-marker-alt", "Teslimat Bekleniyor" },
                    { 9, "fa-user-slash", "Gelmedi" },
                    { 10, "fa-undo", "Ücret İade Edildi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "ReservationStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "ReservationStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "ReservationStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "ReservationStatusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "ReservationStatusId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "ReservationStatusId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "ReservationStatusId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "ReservationStatusId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "ReservationStatusId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "ReservationStatusId",
                keyValue: 10);
        }
    }
}
