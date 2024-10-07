using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaNET_SantiagoPineda.Migrations
{
    /// <inheritdoc />
    public partial class FixRoomSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50,
                column: "availability",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50,
                column: "availability",
                value: true);
        }
    }
}
