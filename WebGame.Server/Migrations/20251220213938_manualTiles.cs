using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class manualTiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapBuildings",
                keyColumns: new[] { "MapId", "TopLeftX", "TopLeftY" },
                keyValues: new object[] { 2, 4, 5 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 0, 18 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 0, 19 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 0, 20 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 0, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 0, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 0, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 0, 28 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 18 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 19 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 20 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 28 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 29 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 30 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 18 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 19 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 20 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 28 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 29 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 2, 30 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 18 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 19 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 20 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 28 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 29 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 3, 30 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 4, 18 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 4, 19 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 4, 20 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 4, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 4, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 4, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 4, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 4, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 4, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 4, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 5, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 6, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 7, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 7, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 7, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 7, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 7, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 8, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 8, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 8, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 8, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 8, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 9, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 10, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 10, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 10, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 10, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 10, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 11, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 11, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 11, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 11, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 11, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 12, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 13, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 13, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 13, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 13, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 13, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 14, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 14, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 14, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 14, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 14, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 15, 27 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 16, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 17, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 17, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 17, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 17, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 17, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 17, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 18, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 18, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 18, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 18, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 18, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 18, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 19, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 20, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 20, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 20, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 20, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 20, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 20, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 21, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 21, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 21, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 21, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 21, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 21, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 22, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 22, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 22, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 22, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 22, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 22, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 23, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 23, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 23, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 23, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 23, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 23, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 24, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 24, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 24, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 24, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 24, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 24, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 25, 21 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 25, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 25, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 25, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 25, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 25, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 26, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 27, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 27, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 27, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 27, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 27, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 28, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 28, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 28, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 28, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 28, 26 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 29, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 30, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 30, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 30, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 30, 25 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 31, 22 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 31, 23 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 31, 24 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 31, 25 });

            migrationBuilder.InsertData(
                table: "MapTiles",
                columns: new[] { "MapId", "X", "Y", "TileId" },
                values: new object[,]
                {
                    { 1, 0, 0, 1 },
                    { 1, 1, 0, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 0, 0 });

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumns: new[] { "MapId", "X", "Y" },
                keyValues: new object[] { 1, 1, 0 });

            migrationBuilder.InsertData(
                table: "MapBuildings",
                columns: new[] { "MapId", "TopLeftX", "TopLeftY", "BuildingId" },
                values: new object[] { 2, 4, 5, 2 });

            migrationBuilder.InsertData(
                table: "MapTiles",
                columns: new[] { "MapId", "X", "Y", "TileId" },
                values: new object[,]
                {
                    { 1, 0, 18, 9 },
                    { 1, 0, 19, 9 },
                    { 1, 0, 20, 9 },
                    { 1, 0, 21, 9 },
                    { 1, 0, 22, 18 },
                    { 1, 0, 27, 36 },
                    { 1, 0, 28, 45 },
                    { 1, 1, 18, 10 },
                    { 1, 1, 19, 10 },
                    { 1, 1, 20, 10 },
                    { 1, 1, 21, 10 },
                    { 1, 1, 22, 10 },
                    { 1, 1, 23, 9 },
                    { 1, 1, 24, 9 },
                    { 1, 1, 25, 9 },
                    { 1, 1, 26, 9 },
                    { 1, 1, 27, 10 },
                    { 1, 1, 28, 14 },
                    { 1, 1, 29, 23 },
                    { 1, 1, 30, 32 },
                    { 1, 2, 18, 10 },
                    { 1, 2, 19, 10 },
                    { 1, 2, 20, 10 },
                    { 1, 2, 21, 10 },
                    { 1, 2, 22, 10 },
                    { 1, 2, 23, 10 },
                    { 1, 2, 24, 10 },
                    { 1, 2, 25, 10 },
                    { 1, 2, 26, 10 },
                    { 1, 2, 27, 10 },
                    { 1, 2, 28, 15 },
                    { 1, 2, 29, 24 },
                    { 1, 2, 30, 33 },
                    { 1, 3, 18, 10 },
                    { 1, 3, 19, 10 },
                    { 1, 3, 20, 10 },
                    { 1, 3, 21, 10 },
                    { 1, 3, 22, 10 },
                    { 1, 3, 23, 10 },
                    { 1, 3, 24, 10 },
                    { 1, 3, 25, 10 },
                    { 1, 3, 26, 10 },
                    { 1, 3, 27, 15 },
                    { 1, 3, 28, 16 },
                    { 1, 3, 29, 25 },
                    { 1, 3, 30, 34 },
                    { 1, 4, 18, 10 },
                    { 1, 4, 19, 10 },
                    { 1, 4, 20, 10 },
                    { 1, 4, 21, 10 },
                    { 1, 4, 22, 10 },
                    { 1, 4, 23, 11 },
                    { 1, 4, 24, 10 },
                    { 1, 4, 25, 10 },
                    { 1, 4, 26, 24 },
                    { 1, 4, 27, 32 },
                    { 1, 5, 22, 19 },
                    { 1, 5, 24, 6 },
                    { 1, 5, 25, 15 },
                    { 1, 5, 26, 24 },
                    { 1, 5, 27, 33 },
                    { 1, 6, 22, 19 },
                    { 1, 6, 24, 6 },
                    { 1, 6, 25, 15 },
                    { 1, 6, 26, 24 },
                    { 1, 6, 27, 33 },
                    { 1, 7, 22, 19 },
                    { 1, 7, 24, 6 },
                    { 1, 7, 25, 15 },
                    { 1, 7, 26, 24 },
                    { 1, 7, 27, 33 },
                    { 1, 8, 22, 19 },
                    { 1, 8, 24, 6 },
                    { 1, 8, 25, 15 },
                    { 1, 8, 26, 24 },
                    { 1, 8, 27, 33 },
                    { 1, 9, 22, 19 },
                    { 1, 9, 24, 6 },
                    { 1, 9, 25, 15 },
                    { 1, 9, 26, 24 },
                    { 1, 9, 27, 33 },
                    { 1, 10, 22, 19 },
                    { 1, 10, 24, 6 },
                    { 1, 10, 25, 15 },
                    { 1, 10, 26, 24 },
                    { 1, 10, 27, 33 },
                    { 1, 11, 22, 19 },
                    { 1, 11, 24, 6 },
                    { 1, 11, 25, 15 },
                    { 1, 11, 26, 24 },
                    { 1, 11, 27, 33 },
                    { 1, 12, 22, 19 },
                    { 1, 12, 24, 6 },
                    { 1, 12, 25, 15 },
                    { 1, 12, 26, 24 },
                    { 1, 12, 27, 33 },
                    { 1, 13, 22, 19 },
                    { 1, 13, 24, 6 },
                    { 1, 13, 25, 15 },
                    { 1, 13, 26, 24 },
                    { 1, 13, 27, 33 },
                    { 1, 14, 22, 19 },
                    { 1, 14, 24, 6 },
                    { 1, 14, 25, 15 },
                    { 1, 14, 26, 24 },
                    { 1, 14, 27, 33 },
                    { 1, 15, 22, 19 },
                    { 1, 15, 24, 6 },
                    { 1, 15, 25, 15 },
                    { 1, 15, 26, 25 },
                    { 1, 15, 27, 51 },
                    { 1, 16, 21, 10 },
                    { 1, 16, 22, 15 },
                    { 1, 16, 23, 9 },
                    { 1, 16, 24, 15 },
                    { 1, 16, 25, 24 },
                    { 1, 16, 26, 32 },
                    { 1, 17, 21, 10 },
                    { 1, 17, 22, 15 },
                    { 1, 17, 23, 10 },
                    { 1, 17, 24, 15 },
                    { 1, 17, 25, 24 },
                    { 1, 17, 26, 33 },
                    { 1, 18, 21, 10 },
                    { 1, 18, 22, 15 },
                    { 1, 18, 23, 10 },
                    { 1, 18, 24, 15 },
                    { 1, 18, 25, 24 },
                    { 1, 18, 26, 33 },
                    { 1, 19, 21, 10 },
                    { 1, 19, 22, 15 },
                    { 1, 19, 23, 10 },
                    { 1, 19, 24, 15 },
                    { 1, 19, 25, 24 },
                    { 1, 19, 26, 33 },
                    { 1, 20, 21, 10 },
                    { 1, 20, 22, 15 },
                    { 1, 20, 23, 10 },
                    { 1, 20, 24, 15 },
                    { 1, 20, 25, 24 },
                    { 1, 20, 26, 33 },
                    { 1, 21, 21, 10 },
                    { 1, 21, 22, 15 },
                    { 1, 21, 23, 10 },
                    { 1, 21, 24, 15 },
                    { 1, 21, 25, 24 },
                    { 1, 21, 26, 33 },
                    { 1, 22, 21, 10 },
                    { 1, 22, 22, 15 },
                    { 1, 22, 23, 10 },
                    { 1, 22, 24, 15 },
                    { 1, 22, 25, 24 },
                    { 1, 22, 26, 33 },
                    { 1, 23, 21, 10 },
                    { 1, 23, 22, 15 },
                    { 1, 23, 23, 10 },
                    { 1, 23, 24, 15 },
                    { 1, 23, 25, 24 },
                    { 1, 23, 26, 33 },
                    { 1, 24, 21, 10 },
                    { 1, 24, 22, 15 },
                    { 1, 24, 23, 10 },
                    { 1, 24, 24, 15 },
                    { 1, 24, 25, 24 },
                    { 1, 24, 26, 33 },
                    { 1, 25, 21, 10 },
                    { 1, 25, 22, 15 },
                    { 1, 25, 23, 10 },
                    { 1, 25, 24, 15 },
                    { 1, 25, 25, 24 },
                    { 1, 25, 26, 33 },
                    { 1, 26, 22, 15 },
                    { 1, 26, 23, 10 },
                    { 1, 26, 24, 15 },
                    { 1, 26, 25, 24 },
                    { 1, 26, 26, 33 },
                    { 1, 27, 22, 15 },
                    { 1, 27, 23, 10 },
                    { 1, 27, 24, 15 },
                    { 1, 27, 25, 24 },
                    { 1, 27, 26, 33 },
                    { 1, 28, 22, 15 },
                    { 1, 28, 23, 10 },
                    { 1, 28, 24, 15 },
                    { 1, 28, 25, 24 },
                    { 1, 28, 26, 33 },
                    { 1, 29, 22, 15 },
                    { 1, 29, 23, 15 },
                    { 1, 29, 24, 24 },
                    { 1, 29, 25, 32 },
                    { 1, 30, 22, 15 },
                    { 1, 30, 23, 15 },
                    { 1, 30, 24, 24 },
                    { 1, 30, 25, 33 },
                    { 1, 31, 22, 16 },
                    { 1, 31, 23, 16 },
                    { 1, 31, 24, 25 },
                    { 1, 31, 25, 34 }
                });
        }
    }
}
