using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaNET_SantiagoPineda.Migrations
{
    /// <inheritdoc />
    public partial class FixRoomTypeSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "description", "name" },
                values: new object[] { "a cozy basic room with a single bed, ideal for solo travelers.", "single room" });

            migrationBuilder.UpdateData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "description", "name" },
                values: new object[] { "offers flexibility with either two single beds or a double bed, perfect for couples or friends.", "double room" });

            migrationBuilder.UpdateData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "description", "name" },
                values: new object[] { "spacious and luxurious, with a king-size bed and a separate living area, ideal for those seeking comfort and exclusivity.", "suite" });

            migrationBuilder.UpdateData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "description", "name" },
                values: new object[] { "designed for families, with extra space and multiple beds for a comfortable stay.", "family room" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "description", "name" },
                values: new object[] { "A cozy basic room with a single bed, ideal for solo travelers.", "Single Room" });

            migrationBuilder.UpdateData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "description", "name" },
                values: new object[] { "Offers flexibility with either two single beds or a double bed, perfect for couples or friends.", "Double Room" });

            migrationBuilder.UpdateData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "description", "name" },
                values: new object[] { "Spacious and luxurious, with a king-size bed and a separate living area, ideal for those seeking comfort and exclusivity.", "Suite" });

            migrationBuilder.UpdateData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "description", "name" },
                values: new object[] { "Designed for families, with extra space and multiple beds for a comfortable stay.", "Family Room" });
        }
    }
}
