using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaNET_SantiagoPineda.Migrations
{
    /// <inheritdoc />
    public partial class FixRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "max_occupancy_person",
                table: "rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "max_occupancy_person",
                table: "rooms",
                type: "tinyint unsigned",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
