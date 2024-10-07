using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaNET_SantiagoPineda.Migrations
{
    /// <inheritdoc />
    public partial class RoomAndRoomTypeSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "A cozy basic room with a single bed, ideal for solo travelers.", "Single Room" },
                    { 2, "Offers flexibility with either two single beds or a double bed, perfect for couples or friends.", "Double Room" },
                    { 3, "Spacious and luxurious, with a king-size bed and a separate living area, ideal for those seeking comfort and exclusivity.", "Suite" },
                    { 4, "Designed for families, with extra space and multiple beds for a comfortable stay.", "Family Room" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "max_occupancy_person", "price_per_night", "room_number", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, true, 1, 50.0, "101", 1 },
                    { 2, true, 2, 150.0, "102", 3 },
                    { 3, true, 2, 80.0, "103", 2 },
                    { 4, true, 4, 200.0, "104", 4 },
                    { 5, true, 1, 50.0, "105", 1 },
                    { 6, true, 2, 150.0, "106", 3 },
                    { 7, true, 2, 80.0, "107", 2 },
                    { 8, true, 4, 200.0, "108", 4 },
                    { 9, true, 1, 50.0, "109", 1 },
                    { 10, true, 2, 150.0, "110", 3 },
                    { 11, true, 4, 200.0, "201", 4 },
                    { 12, true, 2, 80.0, "202", 2 },
                    { 13, true, 1, 50.0, "203", 1 },
                    { 14, true, 2, 150.0, "204", 3 },
                    { 15, true, 4, 200.0, "205", 4 },
                    { 16, true, 2, 80.0, "206", 2 },
                    { 17, true, 1, 50.0, "207", 1 },
                    { 18, true, 2, 150.0, "208", 3 },
                    { 19, true, 4, 200.0, "209", 4 },
                    { 20, true, 2, 80.0, "210", 2 },
                    { 21, true, 1, 50.0, "301", 1 },
                    { 22, true, 2, 150.0, "302", 3 },
                    { 23, true, 2, 80.0, "303", 2 },
                    { 24, true, 4, 200.0, "304", 4 },
                    { 25, true, 1, 50.0, "305", 1 },
                    { 26, true, 2, 150.0, "306", 3 },
                    { 27, true, 2, 80.0, "307", 2 },
                    { 28, true, 4, 200.0, "308", 4 },
                    { 29, true, 1, 50.0, "309", 1 },
                    { 30, true, 2, 150.0, "310", 3 },
                    { 31, true, 2, 80.0, "401", 2 },
                    { 32, true, 4, 200.0, "402", 4 },
                    { 33, true, 1, 50.0, "403", 1 },
                    { 34, true, 2, 150.0, "404", 3 },
                    { 35, true, 2, 80.0, "405", 2 },
                    { 36, true, 4, 200.0, "406", 4 },
                    { 37, true, 1, 50.0, "407", 1 },
                    { 38, true, 2, 150.0, "408", 3 },
                    { 39, true, 2, 80.0, "409", 2 },
                    { 40, true, 4, 200.0, "410", 4 },
                    { 41, true, 1, 50.0, "501", 1 },
                    { 42, true, 2, 150.0, "502", 3 },
                    { 43, true, 2, 80.0, "503", 2 },
                    { 44, true, 4, 200.0, "504", 4 },
                    { 45, true, 1, 50.0, "505", 1 },
                    { 46, true, 2, 150.0, "506", 3 },
                    { 47, true, 2, 80.0, "507", 2 },
                    { 48, true, 4, 200.0, "508", 4 },
                    { 49, true, 1, 50.0, "509", 1 },
                    { 50, true, 2, 150.0, "510", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
