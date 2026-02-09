using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class TileIsEdgeProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEdge",
                table: "Tiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 1,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 2,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 3,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 5,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 6,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 7,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 8,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 9,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 10,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 11,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 12,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 14,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 15,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 16,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 17,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 18,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 19,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 20,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 21,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 23,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 24,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 25,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 26,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 27,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 28,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 29,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 30,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 32,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 33,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 34,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 35,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 36,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 39,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 41,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 42,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 43,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 44,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 45,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 48,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 50,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 51,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 52,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 53,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 54,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 55,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 56,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 57,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 59,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 60,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 61,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 62,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 63,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 64,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 65,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 66,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 68,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 69,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 70,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 71,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 72,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 73,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 74,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 75,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 77,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 78,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 79,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 80,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 81,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 82,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 83,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 84,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 86,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 87,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 88,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 89,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 90,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 93,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 95,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 96,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 97,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 98,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 99,
                column: "IsEdge",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 102,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 104,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 105,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 106,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 107,
                column: "IsEdge",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEdge",
                table: "Tiles");
        }
    }
}
