using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class currentLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentLevel",
                table: "Buildings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentLevel",
                table: "Buildings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 1,
                column: "CurrentLevel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 2,
                column: "CurrentLevel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 3,
                column: "CurrentLevel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 4,
                column: "CurrentLevel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 5,
                column: "CurrentLevel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 6,
                column: "CurrentLevel",
                value: 1);
        }
    }
}
