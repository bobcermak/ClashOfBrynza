using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActiveToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1,
                columns: new[] { "X", "Y" },
                values: new object[] { 17, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 2,
                columns: new[] { "X", "Y" },
                values: new object[] { 18, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 3,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 19, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 4,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 20, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 5,
                columns: new[] { "X", "Y" },
                values: new object[] { 21, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 6,
                columns: new[] { "X", "Y" },
                values: new object[] { 22, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 7,
                columns: new[] { "X", "Y" },
                values: new object[] { 23, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 8,
                columns: new[] { "X", "Y" },
                values: new object[] { 24, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 9,
                columns: new[] { "X", "Y" },
                values: new object[] { 25, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 10,
                columns: new[] { "X", "Y" },
                values: new object[] { 26, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 11,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 56, 27, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 12,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 36, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 13,
                columns: new[] { "X", "Y" },
                values: new object[] { 37, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 14,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 56, 38, 0 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 15,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 16,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 60, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 17,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 18,
                columns: new[] { "X", "Y" },
                values: new object[] { 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 19,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 20,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 21,
                columns: new[] { "X", "Y" },
                values: new object[] { 29, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 22,
                columns: new[] { "X", "Y" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 23,
                columns: new[] { "X", "Y" },
                values: new object[] { 31, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 24,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 56, 32, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 25,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 35, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 26,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 36, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 27,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 38, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 28,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 45, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 29,
                columns: new[] { "X", "Y" },
                values: new object[] { 46, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 30,
                columns: new[] { "X", "Y" },
                values: new object[] { 47, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 31,
                columns: new[] { "X", "Y" },
                values: new object[] { 48, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 32,
                columns: new[] { "X", "Y" },
                values: new object[] { 49, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 33,
                columns: new[] { "X", "Y" },
                values: new object[] { 50, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 34,
                columns: new[] { "X", "Y" },
                values: new object[] { 51, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 35,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 52, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 36,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 53, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 37,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 56, 54, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 38,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 12, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 39,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 13, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 40,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 14, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 41,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 15, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 42,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 16, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 43,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 44,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 45,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 28, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 46,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 29, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 47,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 30, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 48,
                columns: new[] { "X", "Y" },
                values: new object[] { 31, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 49,
                columns: new[] { "X", "Y" },
                values: new object[] { 32, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 50,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 33, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 51,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 34, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 52,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 35, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 53,
                columns: new[] { "X", "Y" },
                values: new object[] { 42, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 54,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 43, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 55,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 44, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 56,
                columns: new[] { "X", "Y" },
                values: new object[] { 45, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 57,
                columns: new[] { "X", "Y" },
                values: new object[] { 46, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 58,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 47, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 59,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 48, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 60,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 49, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 61,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 50, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 62,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 51, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 63,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 52, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 64,
                columns: new[] { "X", "Y" },
                values: new object[] { 53, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 65,
                columns: new[] { "X", "Y" },
                values: new object[] { 54, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 66,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 56, 55, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 67,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 11, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 68,
                columns: new[] { "X", "Y" },
                values: new object[] { 12, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 69,
                columns: new[] { "X", "Y" },
                values: new object[] { 13, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 70,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 14, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 71,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 15, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 72,
                columns: new[] { "X", "Y" },
                values: new object[] { 42, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 73,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 43, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 74,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 44, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 75,
                columns: new[] { "X", "Y" },
                values: new object[] { 45, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 76,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 46, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 77,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 47, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 78,
                columns: new[] { "X", "Y" },
                values: new object[] { 48, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 79,
                columns: new[] { "X", "Y" },
                values: new object[] { 49, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 80,
                columns: new[] { "X", "Y" },
                values: new object[] { 50, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 81,
                columns: new[] { "X", "Y" },
                values: new object[] { 51, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 82,
                columns: new[] { "X", "Y" },
                values: new object[] { 52, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 83,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 53, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 84,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 54, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 85,
                columns: new[] { "X", "Y" },
                values: new object[] { 55, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 86,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 56, 56, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 87,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 9, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 88,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 10, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 89,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 11, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 90,
                columns: new[] { "X", "Y" },
                values: new object[] { 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 91,
                columns: new[] { "X", "Y" },
                values: new object[] { 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 92,
                columns: new[] { "X", "Y" },
                values: new object[] { 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 93,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 94,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 44, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 95,
                columns: new[] { "X", "Y" },
                values: new object[] { 45, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 96,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 46, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 97,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 47, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 98,
                columns: new[] { "X", "Y" },
                values: new object[] { 48, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 99,
                columns: new[] { "X", "Y" },
                values: new object[] { 49, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 100,
                columns: new[] { "X", "Y" },
                values: new object[] { 50, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 101,
                columns: new[] { "X", "Y" },
                values: new object[] { 51, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 102,
                columns: new[] { "X", "Y" },
                values: new object[] { 52, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 103,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 53, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 104,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 54, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 105,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 55, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 106,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 56, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 107,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 56, 57, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 108,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 8, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 109,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 9, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 110,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 10, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 111,
                columns: new[] { "X", "Y" },
                values: new object[] { 11, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 112,
                columns: new[] { "X", "Y" },
                values: new object[] { 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 113,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 114,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 115,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 116,
                columns: new[] { "X", "Y" },
                values: new object[] { 45, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 117,
                columns: new[] { "X", "Y" },
                values: new object[] { 46, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 118,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 47, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 119,
                columns: new[] { "X", "Y" },
                values: new object[] { 48, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 120,
                columns: new[] { "X", "Y" },
                values: new object[] { 49, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 121,
                columns: new[] { "X", "Y" },
                values: new object[] { 50, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 122,
                columns: new[] { "X", "Y" },
                values: new object[] { 51, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 123,
                columns: new[] { "X", "Y" },
                values: new object[] { 52, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 124,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 53, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 125,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 54, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 126,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 55, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 127,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 56, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 128,
                columns: new[] { "X", "Y" },
                values: new object[] { 57, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 129,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 8, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 130,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 9, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 131,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 10, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 132,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 11, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 133,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 12, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 134,
                columns: new[] { "X", "Y" },
                values: new object[] { 13, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 135,
                columns: new[] { "X", "Y" },
                values: new object[] { 14, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 136,
                columns: new[] { "X", "Y" },
                values: new object[] { 15, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 137,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 44, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 138,
                columns: new[] { "X", "Y" },
                values: new object[] { 45, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 139,
                columns: new[] { "X", "Y" },
                values: new object[] { 46, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 140,
                columns: new[] { "X", "Y" },
                values: new object[] { 47, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 141,
                columns: new[] { "X", "Y" },
                values: new object[] { 48, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 142,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 49, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 143,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 50, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 144,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 51, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 145,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 52, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 146,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 53, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 147,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 54, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 148,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 55, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 149,
                columns: new[] { "X", "Y" },
                values: new object[] { 56, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 150,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 57, 6 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 151,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 8, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 152,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 9, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 153,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 69, 10, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 154,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 11, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 155,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 12, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 156,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 13, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 157,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 14, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 158,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 15, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 159,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 46, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 160,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 47, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 161,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 48, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 162,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 49, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 163,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 50, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 164,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 51, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 165,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 52, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 166,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 53, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 167,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 54, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 168,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 55, 7 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 169,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 56, 7, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 170,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 57, 7, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 171,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 54, 6, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 172,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 7, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 173,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 8, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 174,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 9, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 175,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 10, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 176,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 11, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 177,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 12, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 178,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 13, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 179,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 14, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 180,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 15, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 181,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 182,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 183,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 184,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 185,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 186,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 187,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 188,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 189,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 190,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 55, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 191,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 56, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 192,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 57, 8, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 193,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 6, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 194,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 7, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 195,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 8, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 196,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 9, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 197,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 10, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 198,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 11, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 199,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 12, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 200,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 13, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 201,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 14, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 202,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 15, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 203,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 204,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 205,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 206,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 207,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 208,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 209,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 210,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 211,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 55, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 212,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 56, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 213,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 74, 57, 9, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 214,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 6, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 215,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 7, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 216,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 8, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 217,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 9, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 218,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 10, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 219,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 11, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 220,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 12, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 221,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 13, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 222,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 14, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 223,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 15, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 224,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 225,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 226,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 227,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 228,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 229,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 230,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 231,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 55, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 232,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 56, 10, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 233,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 54, 5, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 234,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 6, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 235,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 7, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 236,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 8, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 237,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 9, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 238,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 10, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 239,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 11, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 240,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 12, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 241,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 13, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 242,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 14, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 243,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 15, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 244,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 40, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 245,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 41, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 246,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 42, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 247,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 43, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 248,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 249,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 250,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 251,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 252,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 253,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 254,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 55, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 255,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 74, 56, 11, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 256,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 54, 4, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 257,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 5, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 258,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 6, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 259,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 43, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 260,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 261,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 262,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 263,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 264,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 265,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 266,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 267,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 268,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 269,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 55, 12, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 270,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 4, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 271,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 43, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 272,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 273,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 274,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 275,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 276,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 277,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 278,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 279,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 280,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 281,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 282,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 54, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 283,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 74, 55, 13, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 284,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 54, 3, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 285,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 286,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 43, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 287,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 288,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 289,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 290,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 291,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 292,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 293,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 294,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 295,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 296,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 74, 53, 14, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 297,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 3, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 298,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 299,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 43, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 300,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 301,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 302,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 303,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 304,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 305,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 306,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 307,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 308,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 52, 15, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 309,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 54, 2, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 310,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 311,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 312,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 313,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 314,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 315,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 316,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 317,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 318,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 52, 16, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 319,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 54, 1, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 320,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 2, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 321,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 322,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 323,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 324,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 325,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 326,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 327,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 328,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 329,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 330,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 53, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 331,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 56, 54, 17, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 332,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 1, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 333,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 2, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 334,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 335,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 336,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 337,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 338,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 339,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 340,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 341,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 342,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 343,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 344,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 345,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 56, 55, 18, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 346,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 1, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 347,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 2, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 348,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 349,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 350,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 54, 43, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 351,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 44, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 352,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 56, 45, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 353,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 354,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 355,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 356,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 357,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 358,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 359,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 360,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 361,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 362,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 55, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 363,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 56, 56, 19, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 364,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 1, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 365,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 2, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 366,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 367,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 368,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 54, 30, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 369,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 31, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 370,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 32, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 371,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 33, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 372,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 34, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 373,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 35, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 374,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 36, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 375,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 37, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 376,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 38, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 377,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 39, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 378,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 40, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 379,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 41, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 380,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 42, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 381,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 43, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 382,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 383,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 384,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 385,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 386,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 387,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 388,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 389,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 390,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 391,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 392,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 393,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 55, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 394,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 56, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 395,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 57, 20, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 396,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 1, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 397,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 2, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 398,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 399,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 400,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 54, 15, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 401,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 16, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 402,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 17, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 403,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 18, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 404,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 19, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 405,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 20, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 406,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 21, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 407,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 22, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 408,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 23, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 409,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 24, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 410,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 25, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 411,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 26, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 412,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 27, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 413,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 28, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 414,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 29, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 415,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 30, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 416,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 31, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 417,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 32, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 418,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 33, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 419,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 34, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 420,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 35, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 421,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 36, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 422,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 37, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 423,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 38, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 424,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 39, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 425,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 40, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 426,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 41, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 427,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 42, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 428,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 43, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 429,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 44, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 430,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 45, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 431,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 46, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 432,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 47, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 433,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 48, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 434,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 435,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 50, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 436,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 51, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 437,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 52, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 438,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 53, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 439,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 54, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 440,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 55, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 441,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 56, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 442,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 74, 57, 21, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 443,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 1, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 444,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 2, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 445,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 446,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 447,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 54, 14, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 448,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 15, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 449,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 16, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 450,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 17, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 451,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 18, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 452,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 19, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 453,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 20, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 454,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 21, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 455,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 22, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 456,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 23, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 457,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 24, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 458,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 25, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 459,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 26, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 460,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 27, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 461,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 28, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 462,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 29, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 463,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 30, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 464,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 31, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 465,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 32, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 466,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 33, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 467,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 34, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 468,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 35, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 469,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 36, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 470,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 43, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 471,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 44, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 472,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 45, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 473,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 46, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 474,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 47, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 475,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 48, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 476,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 49, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 477,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 478,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 479,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 480,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 481,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 482,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 55, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 483,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 56, 22, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 484,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 72, 1, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 485,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 2, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 486,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 487,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 488,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 14, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 489,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 15, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 490,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 16, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 491,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 17, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 492,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 18, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 493,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 19, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 494,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 20, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 495,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 27, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 496,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 28, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 497,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 29, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 498,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 30, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 499,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 31, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 500,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 32, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 501,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 33, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 502,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 34, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 503,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 35, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 504,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 36, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 505,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 43, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 506,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 44, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 507,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 45, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 508,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 46, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 509,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 510,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 511,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 512,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 513,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 514,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 515,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 53, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 516,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 54, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 517,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 55, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 518,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 56, 23, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 519,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 2, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 520,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 521,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 522,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 5, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 523,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 6, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 524,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 7, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 525,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 8, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 526,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 9, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 527,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 10, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 528,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 11, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 529,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 12, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 530,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 13, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 531,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 14, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 532,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 15, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 533,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 16, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 534,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 17, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 535,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 18, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 536,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 19, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 537,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 20, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 538,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 84, 23, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 539,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 72, 27, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 540,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 28, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 541,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 29, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 542,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 30, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 543,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 31, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 544,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 32, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 545,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 33, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 546,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 34, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 547,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 35, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 548,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 74, 36, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 549,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 43, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 550,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 551,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 552,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 553,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 554,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 555,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 556,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 557,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 558,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 559,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 560,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 561,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 55, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 562,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 56, 24, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 563,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 2, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 564,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 565,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 566,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 5, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 567,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 6, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 568,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 7, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 569,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 8, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 570,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 9, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 571,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 10, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 572,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 11, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 573,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 12, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 574,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 13, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 575,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 14, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 576,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 15, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 577,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 16, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 578,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 17, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 579,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 18, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 580,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 19, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 581,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 20, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 582,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 82, 21, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 583,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 83, 22, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 584,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 33, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 585,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 34, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 586,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 81, 38, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 587,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 39, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 588,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 40, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 589,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 41, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 590,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 42, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 591,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 43, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 592,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 593,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 594,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 595,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 596,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 597,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 598,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 599,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 600,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 601,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 602,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 54, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 603,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 55, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 604,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 74, 56, 25, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 605,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 72, 2, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 606,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 3, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 607,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 4, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 608,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 5, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 609,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 6, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 610,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 7, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 611,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 8, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 612,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 9, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 613,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 10, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 614,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 11, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 615,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 12, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 616,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 13, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 617,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 14, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 618,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 15, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 619,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 16, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 620,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 17, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 621,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 18, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 622,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 19, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 623,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 20, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 624,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 84, 28, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 625,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 84, 31, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 626,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 72, 33, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 627,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 34, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 628,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 84, 36, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 629,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 72, 39, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 630,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 40, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 631,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 41, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 632,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 42, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 633,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 43, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 634,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 635,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 636,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 637,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 638,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 639,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 640,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 641,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 642,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 643,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 53, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 644,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 74, 54, 26, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 645,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 5, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 646,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 6, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 647,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 7, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 648,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 8, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 649,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 9, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 650,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 10, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 651,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 11, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 652,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 12, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 653,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 13, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 654,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 14, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 655,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 15, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 656,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 16, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 657,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 17, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 658,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 18, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 659,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 19, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 660,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 20, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 661,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 56, 21, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 662,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 84, 32, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 663,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 75, 34, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 664,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 72, 40, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 665,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 41, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 666,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 42, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 667,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 43, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 668,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 669,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 670,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 671,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 672,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 673,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 674,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 675,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 51, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 676,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 52, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 677,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 74, 53, 27, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 678,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 5, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 679,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 6, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 680,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 7, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 681,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 8, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 682,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 9, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 683,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 10, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 684,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 11, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 685,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 12, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 686,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 13, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 687,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 14, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 688,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 15, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 689,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 16, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 690,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 17, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 691,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 18, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 692,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 19, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 693,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 20, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 694,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 21, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 695,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 42, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 696,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 43, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 697,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 44, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 698,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 45, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 699,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 46, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 700,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 47, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 701,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 48, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 702,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 49, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 703,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 50, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 704,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 51, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 705,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 74, 52, 28, 1 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 706,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 63, 5, 29, 1 });

            migrationBuilder.InsertData(
                table: "MapTiles",
                columns: new[] { "MapTileId", "MapId", "TileId", "X", "Y", "ZIndex" },
                values: new object[,]
                {
                    { 707, 1, 64, 6, 29, 1 },
                    { 708, 1, 64, 7, 29, 1 },
                    { 709, 1, 64, 8, 29, 1 },
                    { 710, 1, 64, 9, 29, 1 },
                    { 711, 1, 64, 10, 29, 1 },
                    { 712, 1, 64, 11, 29, 1 },
                    { 713, 1, 64, 12, 29, 1 },
                    { 714, 1, 64, 13, 29, 1 },
                    { 715, 1, 64, 14, 29, 1 },
                    { 716, 1, 64, 15, 29, 1 },
                    { 717, 1, 64, 16, 29, 1 },
                    { 718, 1, 64, 17, 29, 1 },
                    { 719, 1, 64, 18, 29, 1 },
                    { 720, 1, 64, 19, 29, 1 },
                    { 721, 1, 64, 20, 29, 1 },
                    { 722, 1, 64, 21, 29, 1 },
                    { 723, 1, 55, 22, 29, 1 },
                    { 724, 1, 55, 23, 29, 1 },
                    { 725, 1, 55, 24, 29, 1 },
                    { 726, 1, 55, 25, 29, 1 },
                    { 727, 1, 55, 26, 29, 1 },
                    { 728, 1, 55, 27, 29, 1 },
                    { 729, 1, 55, 28, 29, 1 },
                    { 730, 1, 55, 29, 29, 1 },
                    { 731, 1, 55, 30, 29, 1 },
                    { 732, 1, 55, 31, 29, 1 },
                    { 733, 1, 56, 32, 29, 1 },
                    { 734, 1, 64, 42, 29, 1 },
                    { 735, 1, 64, 43, 29, 1 },
                    { 736, 1, 64, 44, 29, 1 },
                    { 737, 1, 64, 45, 29, 1 },
                    { 738, 1, 64, 46, 29, 1 },
                    { 739, 1, 64, 47, 29, 1 },
                    { 740, 1, 64, 48, 29, 1 },
                    { 741, 1, 64, 49, 29, 1 },
                    { 742, 1, 74, 50, 29, 1 },
                    { 743, 1, 72, 5, 30, 1 },
                    { 744, 1, 73, 6, 30, 1 },
                    { 745, 1, 73, 7, 30, 1 },
                    { 746, 1, 73, 8, 30, 1 },
                    { 747, 1, 73, 9, 30, 1 },
                    { 748, 1, 73, 10, 30, 1 },
                    { 749, 1, 73, 11, 30, 1 },
                    { 750, 1, 73, 12, 30, 1 },
                    { 751, 1, 73, 13, 30, 1 },
                    { 752, 1, 73, 14, 30, 1 },
                    { 753, 1, 73, 15, 30, 1 },
                    { 754, 1, 73, 16, 30, 1 },
                    { 755, 1, 73, 17, 30, 1 },
                    { 756, 1, 73, 18, 30, 1 },
                    { 757, 1, 73, 19, 30, 1 },
                    { 758, 1, 73, 20, 30, 1 },
                    { 759, 1, 73, 21, 30, 1 },
                    { 760, 1, 73, 22, 30, 1 },
                    { 761, 1, 73, 23, 30, 1 },
                    { 762, 1, 73, 24, 30, 1 },
                    { 763, 1, 73, 25, 30, 1 },
                    { 764, 1, 73, 26, 30, 1 },
                    { 765, 1, 73, 27, 30, 1 },
                    { 766, 1, 64, 28, 30, 1 },
                    { 767, 1, 64, 29, 30, 1 },
                    { 768, 1, 64, 30, 30, 1 },
                    { 769, 1, 64, 31, 30, 1 },
                    { 770, 1, 64, 32, 30, 1 },
                    { 771, 1, 55, 33, 30, 1 },
                    { 772, 1, 55, 34, 30, 1 },
                    { 773, 1, 55, 35, 30, 1 },
                    { 774, 1, 55, 36, 30, 1 },
                    { 775, 1, 55, 37, 30, 1 },
                    { 776, 1, 55, 38, 30, 1 },
                    { 777, 1, 56, 39, 30, 1 },
                    { 778, 1, 64, 42, 30, 1 },
                    { 779, 1, 64, 43, 30, 1 },
                    { 780, 1, 64, 44, 30, 1 },
                    { 781, 1, 64, 45, 30, 1 },
                    { 782, 1, 64, 46, 30, 1 },
                    { 783, 1, 64, 47, 30, 1 },
                    { 784, 1, 73, 48, 30, 1 },
                    { 785, 1, 74, 49, 30, 1 },
                    { 786, 1, 63, 28, 31, 1 },
                    { 787, 1, 64, 29, 31, 1 },
                    { 788, 1, 64, 30, 31, 1 },
                    { 789, 1, 64, 31, 31, 1 },
                    { 790, 1, 64, 32, 31, 1 },
                    { 791, 1, 64, 33, 31, 1 },
                    { 792, 1, 64, 34, 31, 1 },
                    { 793, 1, 64, 35, 31, 1 },
                    { 794, 1, 64, 36, 31, 1 },
                    { 795, 1, 64, 37, 31, 1 },
                    { 796, 1, 64, 38, 31, 1 },
                    { 797, 1, 64, 39, 31, 1 },
                    { 798, 1, 64, 40, 31, 1 },
                    { 799, 1, 64, 41, 31, 1 },
                    { 800, 1, 64, 42, 31, 1 },
                    { 801, 1, 64, 43, 31, 1 },
                    { 802, 1, 64, 44, 31, 1 },
                    { 803, 1, 64, 45, 31, 1 },
                    { 804, 1, 64, 46, 31, 1 },
                    { 805, 1, 65, 47, 31, 1 },
                    { 806, 1, 72, 28, 32, 1 },
                    { 807, 1, 73, 29, 32, 1 },
                    { 808, 1, 73, 30, 32, 1 },
                    { 809, 1, 73, 31, 32, 1 },
                    { 810, 1, 73, 32, 32, 1 },
                    { 811, 1, 73, 33, 32, 1 },
                    { 812, 1, 73, 34, 32, 1 },
                    { 813, 1, 73, 35, 32, 1 },
                    { 814, 1, 73, 36, 32, 1 },
                    { 815, 1, 73, 37, 32, 1 },
                    { 816, 1, 73, 38, 32, 1 },
                    { 817, 1, 73, 39, 32, 1 },
                    { 818, 1, 73, 40, 32, 1 },
                    { 819, 1, 73, 41, 32, 1 },
                    { 820, 1, 73, 42, 32, 1 },
                    { 821, 1, 64, 43, 32, 1 },
                    { 822, 1, 64, 44, 32, 1 },
                    { 823, 1, 64, 45, 32, 1 },
                    { 824, 1, 73, 46, 32, 1 },
                    { 825, 1, 74, 47, 32, 1 },
                    { 826, 1, 72, 43, 33, 1 },
                    { 827, 1, 73, 44, 33, 1 },
                    { 828, 1, 74, 45, 33, 1 },
                    { 829, 1, 5, 40, 4, 2 },
                    { 830, 1, 6, 41, 4, 2 },
                    { 831, 1, 6, 42, 4, 2 },
                    { 832, 1, 6, 43, 4, 2 },
                    { 833, 1, 7, 44, 4, 2 },
                    { 834, 1, 14, 40, 5, 2 },
                    { 835, 1, 15, 41, 5, 2 },
                    { 836, 1, 15, 42, 5, 2 },
                    { 837, 1, 15, 43, 5, 2 },
                    { 838, 1, 10, 44, 5, 2 },
                    { 839, 1, 6, 45, 5, 2 },
                    { 840, 1, 6, 46, 5, 2 },
                    { 841, 1, 6, 47, 5, 2 },
                    { 842, 1, 39, 48, 5, 2 },
                    { 843, 1, 14, 40, 6, 2 },
                    { 844, 1, 15, 41, 6, 2 },
                    { 845, 1, 15, 42, 6, 2 },
                    { 846, 1, 15, 43, 6, 2 },
                    { 847, 1, 15, 44, 6, 2 },
                    { 848, 1, 10, 45, 6, 2 },
                    { 849, 1, 10, 46, 6, 2 },
                    { 850, 1, 16, 47, 6, 2 },
                    { 851, 1, 48, 48, 6, 2 },
                    { 852, 1, 6, 39, 7, 2 },
                    { 853, 1, 10, 40, 7, 2 },
                    { 854, 1, 15, 41, 7, 2 },
                    { 855, 1, 15, 42, 7, 2 },
                    { 856, 1, 15, 43, 7, 2 },
                    { 857, 1, 15, 44, 7, 2 },
                    { 858, 1, 15, 45, 7, 2 },
                    { 859, 1, 10, 46, 7, 2 },
                    { 860, 1, 16, 47, 7, 2 },
                    { 861, 1, 15, 40, 8, 2 },
                    { 862, 1, 15, 41, 8, 2 },
                    { 863, 1, 15, 42, 8, 2 },
                    { 864, 1, 15, 43, 8, 2 },
                    { 865, 1, 15, 44, 8, 2 },
                    { 866, 1, 15, 45, 8, 2 },
                    { 867, 1, 10, 46, 8, 2 },
                    { 868, 1, 10, 47, 8, 2 },
                    { 869, 1, 7, 48, 8, 2 },
                    { 870, 1, 15, 40, 9, 2 },
                    { 871, 1, 15, 41, 9, 2 },
                    { 872, 1, 15, 42, 9, 2 },
                    { 873, 1, 15, 43, 9, 2 },
                    { 874, 1, 15, 44, 9, 2 },
                    { 875, 1, 15, 45, 9, 2 },
                    { 876, 1, 15, 46, 9, 2 },
                    { 877, 1, 10, 47, 9, 2 },
                    { 878, 1, 10, 48, 9, 2 },
                    { 879, 1, 7, 49, 9, 2 },
                    { 880, 1, 15, 40, 10, 2 },
                    { 881, 1, 15, 41, 10, 2 },
                    { 882, 1, 15, 42, 10, 2 },
                    { 883, 1, 24, 43, 10, 2 },
                    { 884, 1, 24, 44, 10, 2 },
                    { 885, 1, 24, 45, 10, 2 },
                    { 886, 1, 15, 46, 10, 2 },
                    { 887, 1, 15, 47, 10, 2 },
                    { 888, 1, 15, 48, 10, 2 },
                    { 889, 1, 15, 49, 10, 2 },
                    { 890, 1, 6, 50, 10, 2 },
                    { 891, 1, 7, 51, 10, 2 },
                    { 892, 1, 5, 36, 11, 2 },
                    { 893, 1, 6, 37, 11, 2 },
                    { 894, 1, 6, 38, 11, 2 },
                    { 895, 1, 6, 39, 11, 2 },
                    { 896, 1, 15, 40, 11, 2 },
                    { 897, 1, 15, 41, 11, 2 },
                    { 898, 1, 16, 42, 11, 2 },
                    { 899, 1, 33, 43, 11, 2 },
                    { 900, 1, 33, 44, 11, 2 },
                    { 901, 1, 33, 45, 11, 2 },
                    { 902, 1, 23, 46, 11, 2 },
                    { 903, 1, 24, 47, 11, 2 },
                    { 904, 1, 24, 48, 11, 2 },
                    { 905, 1, 15, 49, 11, 2 },
                    { 906, 1, 15, 50, 11, 2 },
                    { 907, 1, 16, 51, 11, 2 },
                    { 908, 1, 36, 4, 12, 2 },
                    { 909, 1, 6, 5, 12, 2 },
                    { 910, 1, 6, 6, 12, 2 },
                    { 911, 1, 6, 7, 12, 2 },
                    { 912, 1, 6, 8, 12, 2 },
                    { 913, 1, 6, 9, 12, 2 },
                    { 914, 1, 6, 10, 12, 2 },
                    { 915, 1, 6, 11, 12, 2 },
                    { 916, 1, 6, 12, 12, 2 },
                    { 917, 1, 6, 13, 12, 2 },
                    { 918, 1, 6, 14, 12, 2 },
                    { 919, 1, 6, 15, 12, 2 },
                    { 920, 1, 6, 16, 12, 2 },
                    { 921, 1, 6, 17, 12, 2 },
                    { 922, 1, 7, 18, 12, 2 },
                    { 923, 1, 10, 36, 12, 2 },
                    { 924, 1, 10, 37, 12, 2 },
                    { 925, 1, 10, 38, 12, 2 },
                    { 926, 1, 10, 39, 12, 2 },
                    { 927, 1, 10, 40, 12, 2 },
                    { 928, 1, 10, 41, 12, 2 },
                    { 929, 1, 15, 42, 12, 2 },
                    { 930, 1, 39, 43, 12, 2 },
                    { 931, 1, 32, 46, 12, 2 },
                    { 932, 1, 33, 47, 12, 2 },
                    { 933, 1, 33, 48, 12, 2 },
                    { 934, 1, 23, 49, 12, 2 },
                    { 935, 1, 24, 50, 12, 2 },
                    { 936, 1, 24, 51, 12, 2 },
                    { 937, 1, 39, 52, 12, 2 },
                    { 938, 1, 45, 4, 13, 2 },
                    { 939, 1, 14, 5, 13, 2 },
                    { 940, 1, 10, 6, 13, 2 },
                    { 941, 1, 10, 7, 13, 2 },
                    { 942, 1, 10, 8, 13, 2 },
                    { 943, 1, 10, 9, 13, 2 },
                    { 944, 1, 10, 10, 13, 2 },
                    { 945, 1, 10, 11, 13, 2 },
                    { 946, 1, 10, 12, 13, 2 },
                    { 947, 1, 10, 13, 13, 2 },
                    { 948, 1, 10, 14, 13, 2 },
                    { 949, 1, 10, 15, 13, 2 },
                    { 950, 1, 10, 16, 13, 2 },
                    { 951, 1, 10, 17, 13, 2 },
                    { 952, 1, 16, 18, 13, 2 },
                    { 953, 1, 10, 34, 13, 2 },
                    { 954, 1, 10, 35, 13, 2 },
                    { 955, 1, 10, 36, 13, 2 },
                    { 956, 1, 10, 37, 13, 2 },
                    { 957, 1, 10, 38, 13, 2 },
                    { 958, 1, 10, 39, 13, 2 },
                    { 959, 1, 10, 40, 13, 2 },
                    { 960, 1, 10, 41, 13, 2 },
                    { 961, 1, 16, 42, 13, 2 },
                    { 962, 1, 48, 43, 13, 2 },
                    { 963, 1, 32, 49, 13, 2 },
                    { 964, 1, 33, 50, 13, 2 },
                    { 965, 1, 33, 51, 13, 2 },
                    { 966, 1, 48, 52, 13, 2 },
                    { 967, 1, 14, 5, 14, 2 },
                    { 968, 1, 10, 6, 14, 2 },
                    { 969, 1, 10, 7, 14, 2 },
                    { 970, 1, 10, 8, 14, 2 },
                    { 971, 1, 10, 9, 14, 2 },
                    { 972, 1, 10, 10, 14, 2 },
                    { 973, 1, 10, 11, 14, 2 },
                    { 974, 1, 10, 12, 14, 2 },
                    { 975, 1, 10, 13, 14, 2 },
                    { 976, 1, 10, 14, 14, 2 },
                    { 977, 1, 10, 15, 14, 2 },
                    { 978, 1, 10, 16, 14, 2 },
                    { 979, 1, 10, 17, 14, 2 },
                    { 980, 1, 10, 18, 14, 2 },
                    { 981, 1, 10, 30, 14, 2 },
                    { 982, 1, 5, 31, 14, 2 },
                    { 983, 1, 6, 32, 14, 2 },
                    { 984, 1, 6, 33, 14, 2 },
                    { 985, 1, 10, 34, 14, 2 },
                    { 986, 1, 10, 35, 14, 2 },
                    { 987, 1, 10, 36, 14, 2 },
                    { 988, 1, 10, 37, 14, 2 },
                    { 989, 1, 10, 38, 14, 2 },
                    { 990, 1, 10, 39, 14, 2 },
                    { 991, 1, 10, 40, 14, 2 },
                    { 992, 1, 10, 41, 14, 2 },
                    { 993, 1, 16, 42, 14, 2 },
                    { 994, 1, 14, 5, 15, 2 },
                    { 995, 1, 10, 6, 15, 2 },
                    { 996, 1, 10, 7, 15, 2 },
                    { 997, 1, 10, 8, 15, 2 },
                    { 998, 1, 10, 9, 15, 2 },
                    { 999, 1, 10, 10, 15, 2 },
                    { 1000, 1, 10, 11, 15, 2 },
                    { 1001, 1, 10, 12, 15, 2 },
                    { 1002, 1, 10, 13, 15, 2 },
                    { 1003, 1, 10, 14, 15, 2 },
                    { 1004, 1, 10, 15, 15, 2 },
                    { 1005, 1, 10, 16, 15, 2 },
                    { 1006, 1, 10, 17, 15, 2 },
                    { 1007, 1, 10, 18, 15, 2 },
                    { 1008, 1, 10, 30, 15, 2 },
                    { 1009, 1, 10, 31, 15, 2 },
                    { 1010, 1, 10, 32, 15, 2 },
                    { 1011, 1, 10, 33, 15, 2 },
                    { 1012, 1, 10, 34, 15, 2 },
                    { 1013, 1, 10, 35, 15, 2 },
                    { 1014, 1, 10, 36, 15, 2 },
                    { 1015, 1, 10, 37, 15, 2 },
                    { 1016, 1, 10, 38, 15, 2 },
                    { 1017, 1, 10, 39, 15, 2 },
                    { 1018, 1, 10, 40, 15, 2 },
                    { 1019, 1, 10, 41, 15, 2 },
                    { 1020, 1, 15, 42, 15, 2 },
                    { 1021, 1, 6, 43, 15, 2 },
                    { 1022, 1, 6, 44, 15, 2 },
                    { 1023, 1, 7, 45, 15, 2 },
                    { 1024, 1, 14, 5, 16, 2 },
                    { 1025, 1, 10, 6, 16, 2 },
                    { 1026, 1, 10, 7, 16, 2 },
                    { 1027, 1, 10, 8, 16, 2 },
                    { 1028, 1, 10, 9, 16, 2 },
                    { 1029, 1, 10, 10, 16, 2 },
                    { 1030, 1, 10, 11, 16, 2 },
                    { 1031, 1, 10, 12, 16, 2 },
                    { 1032, 1, 10, 13, 16, 2 },
                    { 1033, 1, 10, 14, 16, 2 },
                    { 1034, 1, 10, 15, 16, 2 },
                    { 1035, 1, 10, 16, 16, 2 },
                    { 1036, 1, 10, 17, 16, 2 },
                    { 1037, 1, 10, 18, 16, 2 },
                    { 1038, 1, 19, 19, 16, 2 },
                    { 1039, 1, 19, 20, 16, 2 },
                    { 1040, 1, 19, 21, 16, 2 },
                    { 1041, 1, 19, 22, 16, 2 },
                    { 1042, 1, 19, 23, 16, 2 },
                    { 1043, 1, 19, 24, 16, 2 },
                    { 1044, 1, 19, 25, 16, 2 },
                    { 1045, 1, 19, 26, 16, 2 },
                    { 1046, 1, 19, 27, 16, 2 },
                    { 1047, 1, 19, 28, 16, 2 },
                    { 1048, 1, 19, 29, 16, 2 },
                    { 1049, 1, 15, 30, 16, 2 },
                    { 1050, 1, 15, 31, 16, 2 },
                    { 1051, 1, 15, 32, 16, 2 },
                    { 1052, 1, 15, 33, 16, 2 },
                    { 1053, 1, 15, 34, 16, 2 },
                    { 1054, 1, 15, 35, 16, 2 },
                    { 1055, 1, 15, 36, 16, 2 },
                    { 1056, 1, 15, 37, 16, 2 },
                    { 1057, 1, 15, 38, 16, 2 },
                    { 1058, 1, 15, 39, 16, 2 },
                    { 1059, 1, 15, 40, 16, 2 },
                    { 1060, 1, 15, 41, 16, 2 },
                    { 1061, 1, 15, 42, 16, 2 },
                    { 1062, 1, 15, 43, 16, 2 },
                    { 1063, 1, 15, 44, 16, 2 },
                    { 1064, 1, 15, 45, 16, 2 },
                    { 1065, 1, 39, 46, 16, 2 },
                    { 1066, 1, 14, 5, 17, 2 },
                    { 1067, 1, 10, 6, 17, 2 },
                    { 1068, 1, 10, 7, 17, 2 },
                    { 1069, 1, 10, 8, 17, 2 },
                    { 1070, 1, 10, 9, 17, 2 },
                    { 1071, 1, 10, 10, 17, 2 },
                    { 1072, 1, 10, 11, 17, 2 },
                    { 1073, 1, 10, 12, 17, 2 },
                    { 1074, 1, 10, 13, 17, 2 },
                    { 1075, 1, 10, 14, 17, 2 },
                    { 1076, 1, 10, 15, 17, 2 },
                    { 1077, 1, 10, 16, 17, 2 },
                    { 1078, 1, 10, 17, 17, 2 },
                    { 1079, 1, 11, 18, 17, 2 },
                    { 1080, 1, 9, 30, 17, 2 },
                    { 1081, 1, 10, 31, 17, 2 },
                    { 1082, 1, 10, 32, 17, 2 },
                    { 1083, 1, 10, 33, 17, 2 },
                    { 1084, 1, 10, 34, 17, 2 },
                    { 1085, 1, 10, 35, 17, 2 },
                    { 1086, 1, 10, 36, 17, 2 },
                    { 1087, 1, 10, 37, 17, 2 },
                    { 1088, 1, 10, 38, 17, 2 },
                    { 1089, 1, 10, 39, 17, 2 },
                    { 1090, 1, 10, 40, 17, 2 },
                    { 1091, 1, 10, 41, 17, 2 },
                    { 1092, 1, 10, 42, 17, 2 },
                    { 1093, 1, 15, 43, 17, 2 },
                    { 1094, 1, 15, 44, 17, 2 },
                    { 1095, 1, 16, 45, 17, 2 },
                    { 1096, 1, 48, 46, 17, 2 },
                    { 1097, 1, 14, 5, 18, 2 },
                    { 1098, 1, 10, 6, 18, 2 },
                    { 1099, 1, 10, 7, 18, 2 },
                    { 1100, 1, 10, 8, 18, 2 },
                    { 1101, 1, 10, 9, 18, 2 },
                    { 1102, 1, 10, 10, 18, 2 },
                    { 1103, 1, 10, 11, 18, 2 },
                    { 1104, 1, 10, 12, 18, 2 },
                    { 1105, 1, 10, 13, 18, 2 },
                    { 1106, 1, 10, 14, 18, 2 },
                    { 1107, 1, 10, 15, 18, 2 },
                    { 1108, 1, 10, 16, 18, 2 },
                    { 1109, 1, 10, 17, 18, 2 },
                    { 1110, 1, 10, 18, 18, 2 },
                    { 1111, 1, 6, 19, 18, 2 },
                    { 1112, 1, 6, 20, 18, 2 },
                    { 1113, 1, 6, 21, 18, 2 },
                    { 1114, 1, 6, 22, 18, 2 },
                    { 1115, 1, 6, 23, 18, 2 },
                    { 1116, 1, 6, 24, 18, 2 },
                    { 1117, 1, 6, 25, 18, 2 },
                    { 1118, 1, 6, 26, 18, 2 },
                    { 1119, 1, 6, 27, 18, 2 },
                    { 1120, 1, 6, 28, 18, 2 },
                    { 1121, 1, 6, 29, 18, 2 },
                    { 1122, 1, 15, 30, 18, 2 },
                    { 1123, 1, 15, 31, 18, 2 },
                    { 1124, 1, 15, 32, 18, 2 },
                    { 1125, 1, 15, 33, 18, 2 },
                    { 1126, 1, 15, 34, 18, 2 },
                    { 1127, 1, 15, 35, 18, 2 },
                    { 1128, 1, 15, 36, 18, 2 },
                    { 1129, 1, 15, 37, 18, 2 },
                    { 1130, 1, 15, 38, 18, 2 },
                    { 1131, 1, 15, 39, 18, 2 },
                    { 1132, 1, 15, 40, 18, 2 },
                    { 1133, 1, 15, 41, 18, 2 },
                    { 1134, 1, 15, 42, 18, 2 },
                    { 1135, 1, 24, 43, 18, 2 },
                    { 1136, 1, 24, 44, 18, 2 },
                    { 1137, 1, 25, 45, 18, 2 },
                    { 1138, 1, 14, 5, 19, 2 },
                    { 1139, 1, 10, 6, 19, 2 },
                    { 1140, 1, 10, 7, 19, 2 },
                    { 1141, 1, 10, 8, 19, 2 },
                    { 1142, 1, 10, 9, 19, 2 },
                    { 1143, 1, 10, 10, 19, 2 },
                    { 1144, 1, 10, 11, 19, 2 },
                    { 1145, 1, 10, 12, 19, 2 },
                    { 1146, 1, 10, 13, 19, 2 },
                    { 1147, 1, 10, 14, 19, 2 },
                    { 1148, 1, 10, 15, 19, 2 },
                    { 1149, 1, 10, 16, 19, 2 },
                    { 1150, 1, 10, 17, 19, 2 },
                    { 1151, 1, 10, 18, 19, 2 },
                    { 1152, 1, 15, 19, 19, 2 },
                    { 1153, 1, 15, 20, 19, 2 },
                    { 1154, 1, 15, 21, 19, 2 },
                    { 1155, 1, 15, 22, 19, 2 },
                    { 1156, 1, 15, 23, 19, 2 },
                    { 1157, 1, 15, 24, 19, 2 },
                    { 1158, 1, 15, 25, 19, 2 },
                    { 1159, 1, 15, 26, 19, 2 },
                    { 1160, 1, 15, 27, 19, 2 },
                    { 1161, 1, 15, 28, 19, 2 },
                    { 1162, 1, 15, 29, 19, 2 },
                    { 1163, 1, 24, 30, 19, 2 },
                    { 1164, 1, 24, 31, 19, 2 },
                    { 1165, 1, 24, 32, 19, 2 },
                    { 1166, 1, 24, 33, 19, 2 },
                    { 1167, 1, 24, 34, 19, 2 },
                    { 1168, 1, 24, 35, 19, 2 },
                    { 1169, 1, 24, 36, 19, 2 },
                    { 1170, 1, 24, 37, 19, 2 },
                    { 1171, 1, 24, 38, 19, 2 },
                    { 1172, 1, 24, 39, 19, 2 },
                    { 1173, 1, 24, 40, 19, 2 },
                    { 1174, 1, 24, 41, 19, 2 },
                    { 1175, 1, 24, 42, 19, 2 },
                    { 1176, 1, 32, 43, 19, 2 },
                    { 1177, 1, 33, 44, 19, 2 },
                    { 1178, 1, 34, 45, 19, 2 },
                    { 1179, 1, 14, 5, 20, 2 },
                    { 1180, 1, 10, 6, 20, 2 },
                    { 1181, 1, 10, 7, 20, 2 },
                    { 1182, 1, 10, 8, 20, 2 },
                    { 1183, 1, 10, 9, 20, 2 },
                    { 1184, 1, 10, 10, 20, 2 },
                    { 1185, 1, 10, 11, 20, 2 },
                    { 1186, 1, 10, 12, 20, 2 },
                    { 1187, 1, 10, 13, 20, 2 },
                    { 1188, 1, 10, 14, 20, 2 },
                    { 1189, 1, 10, 15, 20, 2 },
                    { 1190, 1, 10, 16, 20, 2 },
                    { 1191, 1, 10, 17, 20, 2 },
                    { 1192, 1, 24, 18, 20, 2 },
                    { 1193, 1, 24, 19, 20, 2 },
                    { 1194, 1, 24, 20, 20, 2 },
                    { 1195, 1, 24, 21, 20, 2 },
                    { 1196, 1, 24, 22, 20, 2 },
                    { 1197, 1, 24, 23, 20, 2 },
                    { 1198, 1, 24, 24, 20, 2 },
                    { 1199, 1, 24, 25, 20, 2 },
                    { 1200, 1, 24, 26, 20, 2 },
                    { 1201, 1, 24, 27, 20, 2 },
                    { 1202, 1, 24, 28, 20, 2 },
                    { 1203, 1, 24, 29, 20, 2 },
                    { 1204, 1, 32, 30, 20, 2 },
                    { 1205, 1, 33, 31, 20, 2 },
                    { 1206, 1, 33, 32, 20, 2 },
                    { 1207, 1, 33, 33, 20, 2 },
                    { 1208, 1, 33, 34, 20, 2 },
                    { 1209, 1, 33, 35, 20, 2 },
                    { 1210, 1, 33, 36, 20, 2 },
                    { 1211, 1, 33, 37, 20, 2 },
                    { 1212, 1, 33, 38, 20, 2 },
                    { 1213, 1, 33, 39, 20, 2 },
                    { 1214, 1, 33, 40, 20, 2 },
                    { 1215, 1, 33, 41, 20, 2 },
                    { 1216, 1, 33, 42, 20, 2 },
                    { 1217, 1, 36, 4, 21, 2 },
                    { 1218, 1, 10, 5, 21, 2 },
                    { 1219, 1, 10, 6, 21, 2 },
                    { 1220, 1, 10, 7, 21, 2 },
                    { 1221, 1, 10, 8, 21, 2 },
                    { 1222, 1, 10, 9, 21, 2 },
                    { 1223, 1, 10, 10, 21, 2 },
                    { 1224, 1, 10, 11, 21, 2 },
                    { 1225, 1, 10, 12, 21, 2 },
                    { 1226, 1, 10, 13, 21, 2 },
                    { 1227, 1, 10, 14, 21, 2 },
                    { 1228, 1, 10, 15, 21, 2 },
                    { 1229, 1, 10, 16, 21, 2 },
                    { 1230, 1, 15, 17, 21, 2 },
                    { 1231, 1, 32, 18, 21, 2 },
                    { 1232, 1, 33, 19, 21, 2 },
                    { 1233, 1, 33, 20, 21, 2 },
                    { 1234, 1, 33, 21, 21, 2 },
                    { 1235, 1, 33, 22, 21, 2 },
                    { 1236, 1, 33, 23, 21, 2 },
                    { 1237, 1, 33, 24, 21, 2 },
                    { 1238, 1, 33, 25, 21, 2 },
                    { 1239, 1, 33, 26, 21, 2 },
                    { 1240, 1, 33, 27, 21, 2 },
                    { 1241, 1, 33, 28, 21, 2 },
                    { 1242, 1, 33, 29, 21, 2 },
                    { 1243, 1, 45, 4, 22, 2 },
                    { 1244, 1, 14, 5, 22, 2 },
                    { 1245, 1, 15, 6, 22, 2 },
                    { 1246, 1, 15, 7, 22, 2 },
                    { 1247, 1, 15, 8, 22, 2 },
                    { 1248, 1, 15, 9, 22, 2 },
                    { 1249, 1, 15, 10, 22, 2 },
                    { 1250, 1, 15, 11, 22, 2 },
                    { 1251, 1, 15, 12, 22, 2 },
                    { 1252, 1, 15, 13, 22, 2 },
                    { 1253, 1, 15, 14, 22, 2 },
                    { 1254, 1, 15, 15, 22, 2 },
                    { 1255, 1, 15, 16, 22, 2 },
                    { 1256, 1, 16, 17, 22, 2 },
                    { 1257, 1, 23, 5, 23, 2 },
                    { 1258, 1, 24, 6, 23, 2 },
                    { 1259, 1, 24, 7, 23, 2 },
                    { 1260, 1, 24, 8, 23, 2 },
                    { 1261, 1, 24, 9, 23, 2 },
                    { 1262, 1, 24, 10, 23, 2 },
                    { 1263, 1, 24, 11, 23, 2 },
                    { 1264, 1, 24, 12, 23, 2 },
                    { 1265, 1, 24, 13, 23, 2 },
                    { 1266, 1, 24, 14, 23, 2 },
                    { 1267, 1, 24, 15, 23, 2 },
                    { 1268, 1, 24, 16, 23, 2 },
                    { 1269, 1, 25, 17, 23, 2 },
                    { 1270, 1, 32, 5, 24, 2 },
                    { 1271, 1, 33, 6, 24, 2 },
                    { 1272, 1, 33, 7, 24, 2 },
                    { 1273, 1, 33, 8, 24, 2 },
                    { 1274, 1, 33, 9, 24, 2 },
                    { 1275, 1, 33, 10, 24, 2 },
                    { 1276, 1, 33, 11, 24, 2 },
                    { 1277, 1, 33, 12, 24, 2 },
                    { 1278, 1, 33, 13, 24, 2 },
                    { 1279, 1, 33, 14, 24, 2 },
                    { 1280, 1, 33, 15, 24, 2 },
                    { 1281, 1, 33, 16, 24, 2 },
                    { 1282, 1, 34, 17, 24, 2 },
                    { 1283, 1, 39, 43, 19, 3 },
                    { 1284, 1, 39, 30, 20, 3 },
                    { 1285, 1, 48, 43, 20, 3 },
                    { 1286, 1, 39, 18, 21, 3 },
                    { 1287, 1, 48, 30, 21, 3 },
                    { 1288, 1, 48, 18, 22, 3 },
                    { 1289, 1, 59, 16, 1, 4 },
                    { 1290, 1, 60, 17, 1, 4 },
                    { 1291, 1, 60, 18, 1, 4 },
                    { 1292, 1, 60, 19, 1, 4 },
                    { 1293, 1, 60, 20, 1, 4 },
                    { 1294, 1, 60, 21, 1, 4 },
                    { 1295, 1, 60, 22, 1, 4 },
                    { 1296, 1, 60, 23, 1, 4 },
                    { 1297, 1, 60, 24, 1, 4 },
                    { 1298, 1, 60, 25, 1, 4 },
                    { 1299, 1, 61, 26, 1, 4 },
                    { 1300, 1, 59, 36, 1, 4 },
                    { 1301, 1, 60, 37, 1, 4 },
                    { 1302, 1, 60, 38, 1, 4 },
                    { 1303, 1, 60, 39, 1, 4 },
                    { 1304, 1, 60, 40, 1, 4 },
                    { 1305, 1, 60, 41, 1, 4 },
                    { 1306, 1, 61, 42, 1, 4 },
                    { 1307, 1, 68, 16, 2, 4 },
                    { 1308, 1, 69, 17, 2, 4 },
                    { 1309, 1, 69, 18, 2, 4 },
                    { 1310, 1, 69, 19, 2, 4 },
                    { 1311, 1, 69, 20, 2, 4 },
                    { 1312, 1, 69, 21, 2, 4 },
                    { 1313, 1, 64, 22, 2, 4 },
                    { 1314, 1, 64, 23, 2, 4 },
                    { 1315, 1, 64, 24, 2, 4 },
                    { 1316, 1, 64, 25, 2, 4 },
                    { 1317, 1, 70, 26, 2, 4 },
                    { 1318, 1, 59, 31, 2, 4 },
                    { 1319, 1, 60, 32, 2, 4 },
                    { 1320, 1, 60, 33, 2, 4 },
                    { 1321, 1, 60, 34, 2, 4 },
                    { 1322, 1, 60, 35, 2, 4 },
                    { 1323, 1, 64, 36, 2, 4 },
                    { 1324, 1, 64, 37, 2, 4 },
                    { 1325, 1, 64, 38, 2, 4 },
                    { 1326, 1, 64, 39, 2, 4 },
                    { 1327, 1, 64, 40, 2, 4 },
                    { 1328, 1, 69, 41, 2, 4 },
                    { 1329, 1, 70, 42, 2, 4 },
                    { 1330, 1, 68, 16, 3, 4 },
                    { 1331, 1, 69, 17, 3, 4 },
                    { 1332, 1, 69, 18, 3, 4 },
                    { 1333, 1, 69, 19, 3, 4 },
                    { 1334, 1, 69, 20, 3, 4 },
                    { 1335, 1, 69, 21, 3, 4 },
                    { 1336, 1, 69, 22, 3, 4 },
                    { 1337, 1, 64, 23, 3, 4 },
                    { 1338, 1, 64, 24, 3, 4 },
                    { 1339, 1, 64, 25, 3, 4 },
                    { 1340, 1, 69, 26, 3, 4 },
                    { 1341, 1, 60, 27, 3, 4 },
                    { 1342, 1, 60, 28, 3, 4 },
                    { 1343, 1, 60, 29, 3, 4 },
                    { 1344, 1, 60, 30, 3, 4 },
                    { 1345, 1, 69, 31, 3, 4 },
                    { 1346, 1, 64, 32, 3, 4 },
                    { 1347, 1, 64, 33, 3, 4 },
                    { 1348, 1, 64, 34, 3, 4 },
                    { 1349, 1, 64, 35, 3, 4 },
                    { 1350, 1, 64, 36, 3, 4 },
                    { 1351, 1, 64, 37, 3, 4 },
                    { 1352, 1, 69, 38, 3, 4 },
                    { 1353, 1, 69, 39, 3, 4 },
                    { 1354, 1, 69, 40, 3, 4 },
                    { 1355, 1, 69, 41, 3, 4 },
                    { 1356, 1, 70, 42, 3, 4 },
                    { 1357, 1, 68, 16, 4, 4 },
                    { 1358, 1, 69, 17, 4, 4 },
                    { 1359, 1, 69, 18, 4, 4 },
                    { 1360, 1, 69, 19, 4, 4 },
                    { 1361, 1, 69, 20, 4, 4 },
                    { 1362, 1, 69, 21, 4, 4 },
                    { 1363, 1, 69, 22, 4, 4 },
                    { 1364, 1, 69, 23, 4, 4 },
                    { 1365, 1, 69, 24, 4, 4 },
                    { 1366, 1, 69, 25, 4, 4 },
                    { 1367, 1, 69, 26, 4, 4 },
                    { 1368, 1, 69, 27, 4, 4 },
                    { 1369, 1, 69, 28, 4, 4 },
                    { 1370, 1, 69, 29, 4, 4 },
                    { 1371, 1, 69, 30, 4, 4 },
                    { 1372, 1, 69, 31, 4, 4 },
                    { 1373, 1, 69, 32, 4, 4 },
                    { 1374, 1, 69, 33, 4, 4 },
                    { 1375, 1, 69, 34, 4, 4 },
                    { 1376, 1, 69, 35, 4, 4 },
                    { 1377, 1, 64, 36, 4, 4 },
                    { 1378, 1, 69, 37, 4, 4 },
                    { 1379, 1, 69, 38, 4, 4 },
                    { 1380, 1, 69, 39, 4, 4 },
                    { 1381, 1, 69, 40, 4, 4 },
                    { 1382, 1, 69, 41, 4, 4 },
                    { 1383, 1, 70, 42, 4, 4 },
                    { 1384, 1, 68, 16, 5, 4 },
                    { 1385, 1, 69, 17, 5, 4 },
                    { 1386, 1, 69, 18, 5, 4 },
                    { 1387, 1, 69, 19, 5, 4 },
                    { 1388, 1, 69, 20, 5, 4 },
                    { 1389, 1, 69, 21, 5, 4 },
                    { 1390, 1, 69, 22, 5, 4 },
                    { 1391, 1, 69, 23, 5, 4 },
                    { 1392, 1, 69, 24, 5, 4 },
                    { 1393, 1, 69, 25, 5, 4 },
                    { 1394, 1, 69, 26, 5, 4 },
                    { 1395, 1, 69, 27, 5, 4 },
                    { 1396, 1, 69, 28, 5, 4 },
                    { 1397, 1, 69, 29, 5, 4 },
                    { 1398, 1, 69, 30, 5, 4 },
                    { 1399, 1, 69, 31, 5, 4 },
                    { 1400, 1, 69, 32, 5, 4 },
                    { 1401, 1, 69, 33, 5, 4 },
                    { 1402, 1, 69, 34, 5, 4 },
                    { 1403, 1, 69, 35, 5, 4 },
                    { 1404, 1, 69, 36, 5, 4 },
                    { 1405, 1, 69, 37, 5, 4 },
                    { 1406, 1, 69, 38, 5, 4 },
                    { 1407, 1, 69, 39, 5, 4 },
                    { 1408, 1, 78, 40, 5, 4 },
                    { 1409, 1, 78, 41, 5, 4 },
                    { 1410, 1, 78, 42, 5, 4 },
                    { 1411, 1, 93, 43, 5, 4 },
                    { 1412, 1, 68, 16, 6, 4 },
                    { 1413, 1, 69, 17, 6, 4 },
                    { 1414, 1, 69, 18, 6, 4 },
                    { 1415, 1, 69, 19, 6, 4 },
                    { 1416, 1, 69, 20, 6, 4 },
                    { 1417, 1, 69, 21, 6, 4 },
                    { 1418, 1, 69, 22, 6, 4 },
                    { 1419, 1, 69, 23, 6, 4 },
                    { 1420, 1, 69, 24, 6, 4 },
                    { 1421, 1, 69, 25, 6, 4 },
                    { 1422, 1, 69, 26, 6, 4 },
                    { 1423, 1, 69, 27, 6, 4 },
                    { 1424, 1, 69, 28, 6, 4 },
                    { 1425, 1, 69, 29, 6, 4 },
                    { 1426, 1, 69, 30, 6, 4 },
                    { 1427, 1, 69, 31, 6, 4 },
                    { 1428, 1, 69, 32, 6, 4 },
                    { 1429, 1, 69, 33, 6, 4 },
                    { 1430, 1, 69, 34, 6, 4 },
                    { 1431, 1, 69, 35, 6, 4 },
                    { 1432, 1, 69, 36, 6, 4 },
                    { 1433, 1, 69, 37, 6, 4 },
                    { 1434, 1, 69, 38, 6, 4 },
                    { 1435, 1, 70, 39, 6, 4 },
                    { 1436, 1, 86, 40, 6, 4 },
                    { 1437, 1, 87, 41, 6, 4 },
                    { 1438, 1, 87, 42, 6, 4 },
                    { 1439, 1, 102, 43, 6, 4 },
                    { 1440, 1, 68, 16, 7, 4 },
                    { 1441, 1, 69, 17, 7, 4 },
                    { 1442, 1, 69, 18, 7, 4 },
                    { 1443, 1, 69, 19, 7, 4 },
                    { 1444, 1, 69, 20, 7, 4 },
                    { 1445, 1, 69, 21, 7, 4 },
                    { 1446, 1, 69, 22, 7, 4 },
                    { 1447, 1, 69, 23, 7, 4 },
                    { 1448, 1, 69, 24, 7, 4 },
                    { 1449, 1, 69, 25, 7, 4 },
                    { 1450, 1, 69, 26, 7, 4 },
                    { 1451, 1, 69, 27, 7, 4 },
                    { 1452, 1, 69, 28, 7, 4 },
                    { 1453, 1, 69, 29, 7, 4 },
                    { 1454, 1, 69, 30, 7, 4 },
                    { 1455, 1, 69, 31, 7, 4 },
                    { 1456, 1, 69, 32, 7, 4 },
                    { 1457, 1, 69, 33, 7, 4 },
                    { 1458, 1, 69, 34, 7, 4 },
                    { 1459, 1, 69, 35, 7, 4 },
                    { 1460, 1, 69, 36, 7, 4 },
                    { 1461, 1, 69, 37, 7, 4 },
                    { 1462, 1, 69, 38, 7, 4 },
                    { 1463, 1, 70, 39, 7, 4 },
                    { 1464, 1, 68, 16, 8, 4 },
                    { 1465, 1, 69, 17, 8, 4 },
                    { 1466, 1, 69, 18, 8, 4 },
                    { 1467, 1, 69, 19, 8, 4 },
                    { 1468, 1, 69, 20, 8, 4 },
                    { 1469, 1, 69, 21, 8, 4 },
                    { 1470, 1, 69, 22, 8, 4 },
                    { 1471, 1, 69, 23, 8, 4 },
                    { 1472, 1, 69, 24, 8, 4 },
                    { 1473, 1, 69, 25, 8, 4 },
                    { 1474, 1, 69, 26, 8, 4 },
                    { 1475, 1, 69, 27, 8, 4 },
                    { 1476, 1, 69, 28, 8, 4 },
                    { 1477, 1, 69, 29, 8, 4 },
                    { 1478, 1, 69, 30, 8, 4 },
                    { 1479, 1, 69, 31, 8, 4 },
                    { 1480, 1, 69, 32, 8, 4 },
                    { 1481, 1, 69, 33, 8, 4 },
                    { 1482, 1, 69, 34, 8, 4 },
                    { 1483, 1, 69, 35, 8, 4 },
                    { 1484, 1, 69, 36, 8, 4 },
                    { 1485, 1, 69, 37, 8, 4 },
                    { 1486, 1, 69, 38, 8, 4 },
                    { 1487, 1, 69, 39, 8, 4 },
                    { 1488, 1, 93, 40, 8, 4 },
                    { 1489, 1, 68, 16, 9, 4 },
                    { 1490, 1, 69, 17, 9, 4 },
                    { 1491, 1, 69, 18, 9, 4 },
                    { 1492, 1, 69, 19, 9, 4 },
                    { 1493, 1, 69, 20, 9, 4 },
                    { 1494, 1, 69, 21, 9, 4 },
                    { 1495, 1, 69, 22, 9, 4 },
                    { 1496, 1, 69, 23, 9, 4 },
                    { 1497, 1, 69, 24, 9, 4 },
                    { 1498, 1, 69, 25, 9, 4 },
                    { 1499, 1, 69, 26, 9, 4 },
                    { 1500, 1, 69, 27, 9, 4 },
                    { 1501, 1, 69, 28, 9, 4 },
                    { 1502, 1, 69, 29, 9, 4 },
                    { 1503, 1, 69, 30, 9, 4 },
                    { 1504, 1, 69, 31, 9, 4 },
                    { 1505, 1, 69, 32, 9, 4 },
                    { 1506, 1, 69, 33, 9, 4 },
                    { 1507, 1, 69, 34, 9, 4 },
                    { 1508, 1, 69, 35, 9, 4 },
                    { 1509, 1, 69, 36, 9, 4 },
                    { 1510, 1, 69, 37, 9, 4 },
                    { 1511, 1, 69, 38, 9, 4 },
                    { 1512, 1, 70, 39, 9, 4 },
                    { 1513, 1, 102, 40, 9, 4 },
                    { 1514, 1, 68, 16, 10, 4 },
                    { 1515, 1, 69, 17, 10, 4 },
                    { 1516, 1, 69, 18, 10, 4 },
                    { 1517, 1, 69, 19, 10, 4 },
                    { 1518, 1, 69, 20, 10, 4 },
                    { 1519, 1, 69, 21, 10, 4 },
                    { 1520, 1, 69, 22, 10, 4 },
                    { 1521, 1, 69, 23, 10, 4 },
                    { 1522, 1, 69, 24, 10, 4 },
                    { 1523, 1, 69, 25, 10, 4 },
                    { 1524, 1, 69, 26, 10, 4 },
                    { 1525, 1, 69, 27, 10, 4 },
                    { 1526, 1, 69, 28, 10, 4 },
                    { 1527, 1, 69, 29, 10, 4 },
                    { 1528, 1, 69, 30, 10, 4 },
                    { 1529, 1, 69, 31, 10, 4 },
                    { 1530, 1, 69, 32, 10, 4 },
                    { 1531, 1, 69, 33, 10, 4 },
                    { 1532, 1, 69, 34, 10, 4 },
                    { 1533, 1, 69, 35, 10, 4 },
                    { 1534, 1, 69, 36, 10, 4 },
                    { 1535, 1, 69, 37, 10, 4 },
                    { 1536, 1, 69, 38, 10, 4 },
                    { 1537, 1, 70, 39, 10, 4 },
                    { 1538, 1, 77, 16, 11, 4 },
                    { 1539, 1, 78, 17, 11, 4 },
                    { 1540, 1, 78, 18, 11, 4 },
                    { 1541, 1, 69, 19, 11, 4 },
                    { 1542, 1, 69, 20, 11, 4 },
                    { 1543, 1, 69, 21, 11, 4 },
                    { 1544, 1, 69, 22, 11, 4 },
                    { 1545, 1, 69, 23, 11, 4 },
                    { 1546, 1, 69, 24, 11, 4 },
                    { 1547, 1, 69, 25, 11, 4 },
                    { 1548, 1, 69, 26, 11, 4 },
                    { 1549, 1, 69, 27, 11, 4 },
                    { 1550, 1, 69, 28, 11, 4 },
                    { 1551, 1, 69, 29, 11, 4 },
                    { 1552, 1, 69, 30, 11, 4 },
                    { 1553, 1, 69, 31, 11, 4 },
                    { 1554, 1, 69, 32, 11, 4 },
                    { 1555, 1, 69, 33, 11, 4 },
                    { 1556, 1, 69, 34, 11, 4 },
                    { 1557, 1, 69, 35, 11, 4 },
                    { 1558, 1, 69, 36, 11, 4 },
                    { 1559, 1, 78, 37, 11, 4 },
                    { 1560, 1, 78, 38, 11, 4 },
                    { 1561, 1, 78, 39, 11, 4 },
                    { 1562, 1, 93, 40, 11, 4 },
                    { 1563, 1, 86, 16, 12, 4 },
                    { 1564, 1, 87, 17, 12, 4 },
                    { 1565, 1, 88, 18, 12, 4 },
                    { 1566, 1, 68, 19, 12, 4 },
                    { 1567, 1, 69, 20, 12, 4 },
                    { 1568, 1, 69, 21, 12, 4 },
                    { 1569, 1, 69, 22, 12, 4 },
                    { 1570, 1, 69, 23, 12, 4 },
                    { 1571, 1, 69, 24, 12, 4 },
                    { 1572, 1, 69, 25, 12, 4 },
                    { 1573, 1, 69, 26, 12, 4 },
                    { 1574, 1, 69, 27, 12, 4 },
                    { 1575, 1, 69, 28, 12, 4 },
                    { 1576, 1, 69, 29, 12, 4 },
                    { 1577, 1, 69, 30, 12, 4 },
                    { 1578, 1, 69, 31, 12, 4 },
                    { 1579, 1, 69, 32, 12, 4 },
                    { 1580, 1, 64, 33, 12, 4 },
                    { 1581, 1, 78, 34, 12, 4 },
                    { 1582, 1, 78, 35, 12, 4 },
                    { 1583, 1, 79, 36, 12, 4 },
                    { 1584, 1, 87, 37, 12, 4 },
                    { 1585, 1, 87, 38, 12, 4 },
                    { 1586, 1, 87, 39, 12, 4 },
                    { 1587, 1, 102, 40, 12, 4 },
                    { 1588, 1, 69, 19, 13, 4 },
                    { 1589, 1, 69, 20, 13, 4 },
                    { 1590, 1, 69, 21, 13, 4 },
                    { 1591, 1, 69, 22, 13, 4 },
                    { 1592, 1, 69, 23, 13, 4 },
                    { 1593, 1, 69, 24, 13, 4 },
                    { 1594, 1, 69, 25, 13, 4 },
                    { 1595, 1, 69, 26, 13, 4 },
                    { 1596, 1, 69, 27, 13, 4 },
                    { 1597, 1, 69, 28, 13, 4 },
                    { 1598, 1, 69, 29, 13, 4 },
                    { 1599, 1, 78, 30, 13, 4 },
                    { 1600, 1, 78, 31, 13, 4 },
                    { 1601, 1, 78, 32, 13, 4 },
                    { 1602, 1, 79, 33, 13, 4 },
                    { 1603, 1, 87, 34, 13, 4 },
                    { 1604, 1, 87, 35, 13, 4 },
                    { 1605, 1, 88, 36, 13, 4 },
                    { 1606, 1, 68, 19, 14, 4 },
                    { 1607, 1, 69, 20, 14, 4 },
                    { 1608, 1, 69, 21, 14, 4 },
                    { 1609, 1, 69, 22, 14, 4 },
                    { 1610, 1, 69, 23, 14, 4 },
                    { 1611, 1, 69, 24, 14, 4 },
                    { 1612, 1, 69, 25, 14, 4 },
                    { 1613, 1, 69, 26, 14, 4 },
                    { 1614, 1, 69, 27, 14, 4 },
                    { 1615, 1, 69, 28, 14, 4 },
                    { 1616, 1, 70, 29, 14, 4 },
                    { 1617, 1, 87, 30, 14, 4 },
                    { 1618, 1, 87, 31, 14, 4 },
                    { 1619, 1, 87, 32, 14, 4 },
                    { 1620, 1, 88, 33, 14, 4 },
                    { 1621, 1, 77, 19, 15, 4 },
                    { 1622, 1, 78, 20, 15, 4 },
                    { 1623, 1, 78, 21, 15, 4 },
                    { 1624, 1, 78, 22, 15, 4 },
                    { 1625, 1, 78, 23, 15, 4 },
                    { 1626, 1, 78, 24, 15, 4 },
                    { 1627, 1, 78, 25, 15, 4 },
                    { 1628, 1, 78, 26, 15, 4 },
                    { 1629, 1, 78, 27, 15, 4 },
                    { 1630, 1, 78, 28, 15, 4 },
                    { 1631, 1, 78, 29, 15, 4 },
                    { 1632, 1, 86, 19, 16, 4 },
                    { 1633, 1, 87, 20, 16, 4 },
                    { 1634, 1, 87, 21, 16, 4 },
                    { 1635, 1, 87, 22, 16, 4 },
                    { 1636, 1, 87, 23, 16, 4 },
                    { 1637, 1, 87, 24, 16, 4 },
                    { 1638, 1, 87, 25, 16, 4 },
                    { 1639, 1, 87, 26, 16, 4 },
                    { 1640, 1, 87, 27, 16, 4 },
                    { 1641, 1, 87, 28, 16, 4 },
                    { 1642, 1, 87, 29, 16, 4 },
                    { 1643, 1, 90, 18, 13, 5 },
                    { 1644, 1, 99, 18, 14, 5 },
                    { 1645, 1, 93, 30, 15, 5 },
                    { 1646, 1, 102, 30, 16, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1646);

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 1,
                columns: new[] { "X", "Y" },
                values: new object[] { 29, 25 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 2,
                columns: new[] { "X", "Y" },
                values: new object[] { 30, 25 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 3,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 56, 31, 25 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 4,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 16, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 5,
                columns: new[] { "X", "Y" },
                values: new object[] { 17, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 6,
                columns: new[] { "X", "Y" },
                values: new object[] { 18, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 7,
                columns: new[] { "X", "Y" },
                values: new object[] { 19, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 8,
                columns: new[] { "X", "Y" },
                values: new object[] { 20, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 9,
                columns: new[] { "X", "Y" },
                values: new object[] { 21, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 10,
                columns: new[] { "X", "Y" },
                values: new object[] { 22, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 11,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 23, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 12,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 24, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 13,
                columns: new[] { "X", "Y" },
                values: new object[] { 25, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 14,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 26, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 15,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 27, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 16,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 28, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 17,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 29, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 18,
                columns: new[] { "X", "Y" },
                values: new object[] { 30, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 19,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 31, 26 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 20,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 1, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 21,
                columns: new[] { "X", "Y" },
                values: new object[] { 2, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 22,
                columns: new[] { "X", "Y" },
                values: new object[] { 3, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 23,
                columns: new[] { "X", "Y" },
                values: new object[] { 4, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 24,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 5, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 25,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 6, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 26,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 7, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 27,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 8, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 28,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 9, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 29,
                columns: new[] { "X", "Y" },
                values: new object[] { 10, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 30,
                columns: new[] { "X", "Y" },
                values: new object[] { 11, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 31,
                columns: new[] { "X", "Y" },
                values: new object[] { 12, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 32,
                columns: new[] { "X", "Y" },
                values: new object[] { 13, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 33,
                columns: new[] { "X", "Y" },
                values: new object[] { 14, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 34,
                columns: new[] { "X", "Y" },
                values: new object[] { 15, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 35,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 16, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 36,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 17, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 37,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 18, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 38,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 19, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 39,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 20, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 40,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 21, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 41,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 22, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 42,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 23, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 43,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 24, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 44,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 25, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 45,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 26, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 46,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 27, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 47,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 28, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 48,
                columns: new[] { "X", "Y" },
                values: new object[] { 29, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 49,
                columns: new[] { "X", "Y" },
                values: new object[] { 30, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 50,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 31, 27 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 51,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 54, 0, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 52,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 1, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 53,
                columns: new[] { "X", "Y" },
                values: new object[] { 2, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 54,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 3, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 55,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 4, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 56,
                columns: new[] { "X", "Y" },
                values: new object[] { 5, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 57,
                columns: new[] { "X", "Y" },
                values: new object[] { 6, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 58,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 7, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 59,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 8, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 60,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 9, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 61,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 10, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 62,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 11, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 63,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 12, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 64,
                columns: new[] { "X", "Y" },
                values: new object[] { 13, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 65,
                columns: new[] { "X", "Y" },
                values: new object[] { 14, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 66,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 15, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 67,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 16, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 68,
                columns: new[] { "X", "Y" },
                values: new object[] { 17, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 69,
                columns: new[] { "X", "Y" },
                values: new object[] { 18, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 70,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 19, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 71,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 20, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 72,
                columns: new[] { "X", "Y" },
                values: new object[] { 21, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 73,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 22, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 74,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 29, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 75,
                columns: new[] { "X", "Y" },
                values: new object[] { 30, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 76,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 31, 28 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 77,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 0, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 78,
                columns: new[] { "X", "Y" },
                values: new object[] { 1, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 79,
                columns: new[] { "X", "Y" },
                values: new object[] { 2, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 80,
                columns: new[] { "X", "Y" },
                values: new object[] { 3, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 81,
                columns: new[] { "X", "Y" },
                values: new object[] { 4, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 82,
                columns: new[] { "X", "Y" },
                values: new object[] { 5, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 83,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 6, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 84,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 13, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 85,
                columns: new[] { "X", "Y" },
                values: new object[] { 14, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 86,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 15, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 87,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 16, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 88,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 17, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 89,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 18, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 90,
                columns: new[] { "X", "Y" },
                values: new object[] { 19, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 91,
                columns: new[] { "X", "Y" },
                values: new object[] { 20, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 92,
                columns: new[] { "X", "Y" },
                values: new object[] { 21, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 93,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 22, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 94,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 29, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 95,
                columns: new[] { "X", "Y" },
                values: new object[] { 30, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 96,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 31, 29 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 97,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 0, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 98,
                columns: new[] { "X", "Y" },
                values: new object[] { 1, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 99,
                columns: new[] { "X", "Y" },
                values: new object[] { 2, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 100,
                columns: new[] { "X", "Y" },
                values: new object[] { 3, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 101,
                columns: new[] { "X", "Y" },
                values: new object[] { 4, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 102,
                columns: new[] { "X", "Y" },
                values: new object[] { 5, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 103,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 6, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 104,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 84, 9, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 105,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 72, 13, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 106,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 14, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 107,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 15, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 108,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 16, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 109,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 17, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 110,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 18, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 111,
                columns: new[] { "X", "Y" },
                values: new object[] { 19, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 112,
                columns: new[] { "X", "Y" },
                values: new object[] { 20, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 113,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 21, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 114,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 74, 22, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 115,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 29, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 116,
                columns: new[] { "X", "Y" },
                values: new object[] { 30, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 117,
                columns: new[] { "X", "Y" },
                values: new object[] { 31, 30 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 118,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 0, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 119,
                columns: new[] { "X", "Y" },
                values: new object[] { 1, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 120,
                columns: new[] { "X", "Y" },
                values: new object[] { 2, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 121,
                columns: new[] { "X", "Y" },
                values: new object[] { 3, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 122,
                columns: new[] { "X", "Y" },
                values: new object[] { 4, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 123,
                columns: new[] { "X", "Y" },
                values: new object[] { 5, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 124,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 6, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 125,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 82, 7, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 126,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 83, 8, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 127,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 19, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 128,
                columns: new[] { "X", "Y" },
                values: new object[] { 20, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 129,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 81, 24, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 130,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 25, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 131,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 26, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 132,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 27, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 133,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 55, 28, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 134,
                columns: new[] { "X", "Y" },
                values: new object[] { 29, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 135,
                columns: new[] { "X", "Y" },
                values: new object[] { 30, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 136,
                columns: new[] { "X", "Y" },
                values: new object[] { 31, 31 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 137,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 63, 0, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 138,
                columns: new[] { "X", "Y" },
                values: new object[] { 1, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 139,
                columns: new[] { "X", "Y" },
                values: new object[] { 2, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 140,
                columns: new[] { "X", "Y" },
                values: new object[] { 3, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 141,
                columns: new[] { "X", "Y" },
                values: new object[] { 4, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 142,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 5, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 143,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 84, 14, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 144,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 84, 17, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 145,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 72, 19, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 146,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 20, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 147,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 84, 22, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 148,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 72, 25, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 149,
                columns: new[] { "X", "Y" },
                values: new object[] { 26, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 150,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 27, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 151,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 28, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 152,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 29, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 153,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 64, 30, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 154,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 65, 31, 32 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 155,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 72, 0, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 156,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 1, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 157,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 2, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 158,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 3, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 159,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 4, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 160,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 74, 5, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 161,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 84, 18, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 162,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 75, 20, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 163,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 72, 26, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 164,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 27, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 165,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 28, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 166,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 29, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 167,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 73, 30, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 168,
                columns: new[] { "TileId", "X", "Y" },
                values: new object[] { 74, 31, 33 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 169,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 9, 0, 17, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 170,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 9, 0, 18, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 171,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 1, 18, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 172,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 2, 18, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 173,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 3, 18, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 174,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 4, 18, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 175,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 11, 31, 18, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 176,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 9, 0, 19, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 177,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 1, 19, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 178,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 2, 19, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 179,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 3, 19, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 180,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 4, 19, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 181,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 11, 31, 19, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 182,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 9, 0, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 183,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 1, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 184,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 2, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 185,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 3, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 186,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 4, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 187,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 16, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 188,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 17, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 189,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 18, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 190,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 19, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 191,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 20, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 192,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 21, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 193,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 22, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 194,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 23, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 195,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 24, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 196,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 25, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 197,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 11, 31, 20, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 198,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 9, 0, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 199,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 1, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 200,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 2, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 201,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 3, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 202,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 4, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 203,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 16, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 204,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 17, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 205,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 18, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 206,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 19, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 207,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 20, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 208,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 21, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 209,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 22, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 210,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 23, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 211,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 24, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 212,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 25, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 213,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 26, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 214,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 27, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 215,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 28, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 216,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 29, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 217,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 30, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 218,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 11, 31, 21, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 219,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 18, 0, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 220,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 1, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 221,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 2, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 222,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 3, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 223,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 4, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 224,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 5, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 225,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 6, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 226,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 7, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 227,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 8, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 228,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 9, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 229,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 10, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 230,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 11, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 231,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 12, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 232,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 13, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 233,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 14, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 234,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 19, 15, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 235,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 16, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 236,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 17, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 237,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 18, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 238,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 19, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 239,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 20, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 240,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 21, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 241,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 22, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 242,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 23, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 243,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 24, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 244,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 25, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 245,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 26, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 246,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 27, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 247,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 28, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 248,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 29, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 249,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 30, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 250,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 16, 31, 22, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 251,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 9, 1, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 252,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 2, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 253,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 3, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 254,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 11, 4, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 255,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 9, 16, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 256,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 17, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 257,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 18, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 258,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 19, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 259,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 20, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 260,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 21, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 261,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 22, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 262,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 23, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 263,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 24, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 264,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 25, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 265,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 26, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 266,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 27, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 267,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 28, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 268,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 29, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 269,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 30, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 270,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 16, 31, 23, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 271,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 9, 1, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 272,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 2, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 273,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 3, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 274,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 4, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 275,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 5, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 276,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 6, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 277,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 7, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 278,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 8, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 279,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 9, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 280,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 10, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 281,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 11, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 282,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 12, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 283,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 13, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 284,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 14, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 285,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 15, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 286,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 16, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 287,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 17, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 288,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 18, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 289,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 19, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 290,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 20, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 291,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 21, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 292,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 22, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 293,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 23, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 294,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 24, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 295,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 25, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 296,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 26, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 297,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 27, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 298,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 28, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 299,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 29, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 300,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 30, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 301,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 25, 31, 24, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 302,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 9, 1, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 303,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 2, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 304,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 3, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 305,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 4, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 306,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 5, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 307,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 6, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 308,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 7, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 309,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 8, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 310,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 9, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 311,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 10, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 312,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 11, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 313,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 12, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 314,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 13, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 315,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 14, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 316,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 15, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 317,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 16, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 318,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 17, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 319,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 18, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 320,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 19, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 321,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 20, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 322,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 21, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 323,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 22, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 324,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 23, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 325,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 24, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 326,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 25, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 327,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 26, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 328,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 27, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 329,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 28, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 330,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 32, 29, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 331,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 30, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 332,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 34, 31, 25, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 333,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 9, 1, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 334,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 2, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 335,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 3, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 336,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 4, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 337,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 5, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 338,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 6, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 339,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 7, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 340,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 8, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 341,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 9, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 342,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 10, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 343,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 11, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 344,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 12, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 345,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 13, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 346,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 14, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 347,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 25, 15, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 348,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 32, 16, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 349,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 17, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 350,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 18, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 351,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 19, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 352,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 20, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 353,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 21, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 354,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 22, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 355,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 23, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 356,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 24, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 357,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 25, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 358,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 26, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 359,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 27, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 360,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 28, 26, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 361,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 36, 0, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 362,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 1, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 363,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 10, 2, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 364,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 3, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 365,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 32, 4, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 366,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 5, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 367,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 6, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 368,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 7, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 369,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 8, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 370,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 9, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 371,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 10, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 372,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 11, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 373,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 12, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 374,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 13, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 375,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 14, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 376,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 51, 15, 27, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 377,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 45, 0, 28, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 378,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 14, 1, 28, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 379,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 2, 28, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 380,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 16, 3, 28, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 381,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 23, 1, 29, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 382,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 2, 29, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 383,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 25, 3, 29, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 384,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 32, 1, 30, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 385,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 2, 30, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 386,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 34, 3, 30, 2 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 387,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 39, 29, 25, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 388,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 39, 16, 26, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 389,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 48, 29, 26, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 390,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 39, 4, 27, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 391,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 48, 16, 27, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 392,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 48, 4, 28, 3 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 393,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 16, 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 394,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 17, 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 395,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 18, 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 396,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 19, 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 397,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 20, 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 398,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 21, 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 399,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 22, 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 400,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 23, 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 401,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 24, 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 402,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 56, 25, 12, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 403,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 16, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 404,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 17, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 405,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 18, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 406,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 19, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 407,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 20, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 408,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 21, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 409,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 22, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 410,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 23, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 411,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 24, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 412,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 25, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 413,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 84, 30, 13, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 414,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 16, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 415,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 17, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 416,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 18, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 417,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 19, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 418,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 20, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 419,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 21, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 420,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 22, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 421,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 23, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 422,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 24, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 423,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 25, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 424,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 84, 27, 14, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 425,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 16, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 426,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 17, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 427,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 18, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 428,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 19, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 429,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 20, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 430,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 21, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 431,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 22, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 432,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 23, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 433,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 24, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 434,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 25, 15, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 435,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 16, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 436,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 17, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 437,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 18, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 438,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 19, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 439,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 20, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 440,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 21, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 441,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 22, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 442,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 23, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 443,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 24, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 444,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 25, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 445,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 26, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 446,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 27, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 447,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 28, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 448,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 29, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 449,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 55, 30, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 450,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 56, 31, 16, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 451,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 68, 0, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 452,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 1, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 453,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 2, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 454,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 3, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 455,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 4, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 456,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 5, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 457,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 6, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 458,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 7, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 459,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 8, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 460,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 9, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 461,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 10, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 462,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 16, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 463,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 17, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 464,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 18, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 465,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 19, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 466,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 20, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 467,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 21, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 468,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 22, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 469,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 23, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 470,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 24, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 471,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 25, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 472,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 26, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 473,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 27, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 474,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 28, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 475,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 29, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 476,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 30, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 477,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 31, 17, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 478,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 77, 0, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 479,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 1, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 480,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 2, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 481,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 3, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 482,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 4, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 483,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 5, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 484,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 6, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 485,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 7, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 486,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 8, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 487,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 9, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 488,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 10, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 489,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 11, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 490,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 12, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 491,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 13, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 492,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 14, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 493,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 15, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 494,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 16, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 495,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 17, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 496,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 18, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 497,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 19, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 498,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 20, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 499,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 21, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 500,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 22, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 501,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 23, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 502,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 24, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 503,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 25, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 504,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 26, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 505,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 27, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 506,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 28, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 507,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 29, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 508,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 30, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 509,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 65, 31, 18, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 510,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 86, 0, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 511,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 1, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 512,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 2, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 513,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 3, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 514,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 4, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 515,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 5, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 516,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 6, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 517,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 7, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 518,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 8, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 519,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 9, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 520,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 10, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 521,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 11, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 522,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 12, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 523,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 13, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 524,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 14, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 525,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 64, 15, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 526,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 16, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 527,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 17, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 528,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 18, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 529,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 19, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 530,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 20, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 531,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 21, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 532,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 22, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 533,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 23, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 534,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 24, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 535,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 73, 25, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 536,
                columns: new[] { "X", "Y", "ZIndex" },
                values: new object[] { 26, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 537,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 27, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 538,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 28, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 539,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 29, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 540,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 30, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 541,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 70, 31, 19, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 542,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 68, 5, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 543,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 6, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 544,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 7, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 545,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 8, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 546,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 9, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 547,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 10, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 548,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 11, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 549,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 12, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 550,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 13, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 551,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 69, 14, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 552,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 70, 15, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 553,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 16, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 554,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 17, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 555,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 18, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 556,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 19, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 557,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 20, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 558,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 21, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 559,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 22, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 560,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 23, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 561,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 24, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 562,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 25, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 563,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 77, 26, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 564,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 27, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 565,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 28, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 566,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 29, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 567,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 30, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 568,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 79, 31, 20, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 569,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 77, 5, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 570,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 6, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 571,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 7, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 572,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 8, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 573,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 9, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 574,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 10, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 575,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 11, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 576,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 12, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 577,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 13, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 578,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 14, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 579,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 78, 15, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 580,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 86, 26, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 581,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 27, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 582,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 28, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 583,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 29, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 584,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 30, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 585,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 88, 31, 21, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 586,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 86, 5, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 587,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 6, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 588,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 7, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 589,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 8, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 590,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 9, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 591,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 10, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 592,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 11, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 593,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 12, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 594,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 13, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 595,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 14, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 596,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 87, 15, 22, 4 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 597,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 5, 0, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 598,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 1, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 599,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 2, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 600,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 3, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 601,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 4, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 602,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 5, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 603,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 6, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 604,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 7, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 605,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 8, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 606,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 9, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 607,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 10, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 608,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 11, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 609,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 12, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 610,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 13, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 611,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 14, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 612,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 6, 15, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 613,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 39, 16, 12, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 614,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 14, 0, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 615,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 1, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 616,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 2, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 617,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 3, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 618,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 4, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 619,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 5, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 620,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 6, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 621,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 7, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 622,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 8, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 623,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 9, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 624,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 10, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 625,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 11, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 626,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 12, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 627,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 13, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 628,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 14, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 629,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 16, 15, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 630,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 48, 16, 13, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 631,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 14, 0, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 632,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 1, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 633,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 2, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 634,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 3, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 635,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 4, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 636,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 5, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 637,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 6, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 638,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 7, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 639,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 8, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 640,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 9, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 641,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 10, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 642,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 11, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 643,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 12, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 644,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 13, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 645,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 14, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 646,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 16, 15, 14, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 647,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 14, 0, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 648,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 1, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 649,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 2, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 650,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 3, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 651,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 4, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 652,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 5, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 653,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 6, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 654,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 7, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 655,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 8, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 656,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 9, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 657,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 10, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 658,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 11, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 659,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 12, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 660,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 13, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 661,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 14, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 662,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 16, 15, 15, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 663,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 23, 0, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 664,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 1, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 665,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 2, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 666,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 3, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 667,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 4, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 668,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 5, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 669,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 6, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 670,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 7, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 671,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 8, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 672,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 9, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 673,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 10, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 674,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 11, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 675,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 12, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 676,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 13, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 677,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 15, 14, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 678,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 16, 15, 16, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 679,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 32, 0, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 680,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 1, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 681,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 2, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 682,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 3, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 683,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 4, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 684,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 5, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 685,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 6, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 686,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 7, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 687,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 8, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 688,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 9, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 689,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 23, 10, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 690,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 11, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 691,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 12, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 692,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 13, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 693,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 14, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 694,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 24, 15, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 695,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 39, 16, 17, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 696,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 32, 10, 18, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 697,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 11, 18, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 698,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 12, 18, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 699,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 13, 18, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 700,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 14, 18, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 701,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 33, 15, 18, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 702,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 48, 16, 18, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 703,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 90, 4, 19, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 704,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 99, 4, 20, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 705,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 93, 16, 21, 5 });

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 706,
                columns: new[] { "TileId", "X", "Y", "ZIndex" },
                values: new object[] { 102, 16, 22, 5 });
        }
    }
}
