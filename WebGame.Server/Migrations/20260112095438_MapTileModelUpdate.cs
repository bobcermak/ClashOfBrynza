using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class MapTileModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MapTiles",
                table: "MapTiles");

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

            migrationBuilder.AddColumn<int>(
                name: "MapTileId",
                table: "MapTiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "ZIndex",
                table: "MapTiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MapTiles",
                table: "MapTiles",
                column: "MapTileId");

            migrationBuilder.InsertData(
                table: "MapTiles",
                columns: new[] { "MapTileId", "MapId", "TileId", "X", "Y", "ZIndex" },
                values: new object[,]
                {
                    { 1, 1, 9, 0, 18, 1 },
                    { 2, 1, 10, 1, 18, 1 },
                    { 3, 1, 10, 2, 18, 1 },
                    { 4, 1, 10, 3, 18, 1 },
                    { 5, 1, 10, 4, 18, 1 },
                    { 6, 1, 9, 0, 19, 1 },
                    { 7, 1, 10, 1, 19, 1 },
                    { 8, 1, 10, 2, 19, 1 },
                    { 9, 1, 10, 3, 19, 1 },
                    { 10, 1, 10, 4, 19, 1 },
                    { 11, 1, 9, 0, 20, 1 },
                    { 12, 1, 10, 1, 20, 1 },
                    { 13, 1, 10, 2, 20, 1 },
                    { 14, 1, 10, 3, 20, 1 },
                    { 15, 1, 10, 4, 20, 1 },
                    { 16, 1, 9, 0, 21, 1 },
                    { 17, 1, 10, 1, 21, 1 },
                    { 18, 1, 10, 2, 21, 1 },
                    { 19, 1, 10, 3, 21, 1 },
                    { 20, 1, 10, 4, 21, 1 },
                    { 21, 1, 10, 16, 21, 1 },
                    { 22, 1, 10, 17, 21, 1 },
                    { 23, 1, 10, 18, 21, 1 },
                    { 24, 1, 10, 19, 21, 1 },
                    { 25, 1, 10, 20, 21, 1 },
                    { 26, 1, 10, 21, 21, 1 },
                    { 27, 1, 10, 22, 21, 1 },
                    { 28, 1, 10, 23, 21, 1 },
                    { 29, 1, 10, 24, 21, 1 },
                    { 30, 1, 10, 25, 21, 1 },
                    { 31, 1, 18, 0, 22, 1 },
                    { 32, 1, 10, 1, 22, 1 },
                    { 33, 1, 10, 2, 22, 1 },
                    { 34, 1, 10, 3, 22, 1 },
                    { 35, 1, 10, 4, 22, 1 },
                    { 36, 1, 19, 5, 22, 1 },
                    { 37, 1, 19, 6, 22, 1 },
                    { 38, 1, 19, 7, 22, 1 },
                    { 39, 1, 19, 8, 22, 1 },
                    { 40, 1, 19, 9, 22, 1 },
                    { 41, 1, 19, 10, 22, 1 },
                    { 42, 1, 19, 11, 22, 1 },
                    { 43, 1, 19, 12, 22, 1 },
                    { 44, 1, 19, 13, 22, 1 },
                    { 45, 1, 19, 14, 22, 1 },
                    { 46, 1, 19, 15, 22, 1 },
                    { 47, 1, 15, 16, 22, 1 },
                    { 48, 1, 15, 17, 22, 1 },
                    { 49, 1, 15, 18, 22, 1 },
                    { 50, 1, 15, 19, 22, 1 },
                    { 51, 1, 15, 20, 22, 1 },
                    { 52, 1, 15, 21, 22, 1 },
                    { 53, 1, 15, 22, 22, 1 },
                    { 54, 1, 15, 23, 22, 1 },
                    { 55, 1, 15, 24, 22, 1 },
                    { 56, 1, 15, 25, 22, 1 },
                    { 57, 1, 15, 26, 22, 1 },
                    { 58, 1, 15, 27, 22, 1 },
                    { 59, 1, 15, 28, 22, 1 },
                    { 60, 1, 15, 29, 22, 1 },
                    { 61, 1, 15, 30, 22, 1 },
                    { 62, 1, 16, 31, 22, 1 },
                    { 63, 1, 9, 1, 23, 1 },
                    { 64, 1, 10, 2, 23, 1 },
                    { 65, 1, 10, 3, 23, 1 },
                    { 66, 1, 11, 4, 23, 1 },
                    { 67, 1, 9, 16, 23, 1 },
                    { 68, 1, 10, 17, 23, 1 },
                    { 69, 1, 10, 18, 23, 1 },
                    { 70, 1, 10, 19, 23, 1 },
                    { 71, 1, 10, 20, 23, 1 },
                    { 72, 1, 10, 21, 23, 1 },
                    { 73, 1, 10, 22, 23, 1 },
                    { 74, 1, 10, 23, 23, 1 },
                    { 75, 1, 10, 24, 23, 1 },
                    { 76, 1, 10, 25, 23, 1 },
                    { 77, 1, 10, 26, 23, 1 },
                    { 78, 1, 10, 27, 23, 1 },
                    { 79, 1, 10, 28, 23, 1 },
                    { 80, 1, 15, 29, 23, 1 },
                    { 81, 1, 15, 30, 23, 1 },
                    { 82, 1, 16, 31, 23, 1 },
                    { 83, 1, 9, 1, 24, 1 },
                    { 84, 1, 10, 2, 24, 1 },
                    { 85, 1, 10, 3, 24, 1 },
                    { 86, 1, 10, 4, 24, 1 },
                    { 87, 1, 6, 5, 24, 1 },
                    { 88, 1, 6, 6, 24, 1 },
                    { 89, 1, 6, 7, 24, 1 },
                    { 90, 1, 6, 8, 24, 1 },
                    { 91, 1, 6, 9, 24, 1 },
                    { 92, 1, 6, 10, 24, 1 },
                    { 93, 1, 6, 11, 24, 1 },
                    { 94, 1, 6, 12, 24, 1 },
                    { 95, 1, 6, 13, 24, 1 },
                    { 96, 1, 6, 14, 24, 1 },
                    { 97, 1, 6, 15, 24, 1 },
                    { 98, 1, 15, 16, 24, 1 },
                    { 99, 1, 15, 17, 24, 1 },
                    { 100, 1, 15, 18, 24, 1 },
                    { 101, 1, 15, 19, 24, 1 },
                    { 102, 1, 15, 20, 24, 1 },
                    { 103, 1, 15, 21, 24, 1 },
                    { 104, 1, 15, 22, 24, 1 },
                    { 105, 1, 15, 23, 24, 1 },
                    { 106, 1, 15, 24, 24, 1 },
                    { 107, 1, 15, 25, 24, 1 },
                    { 108, 1, 15, 26, 24, 1 },
                    { 109, 1, 15, 27, 24, 1 },
                    { 110, 1, 15, 28, 24, 1 },
                    { 111, 1, 24, 29, 24, 1 },
                    { 112, 1, 24, 30, 24, 1 },
                    { 113, 1, 25, 31, 24, 1 },
                    { 114, 1, 9, 1, 25, 1 },
                    { 115, 1, 10, 2, 25, 1 },
                    { 116, 1, 10, 3, 25, 1 },
                    { 117, 1, 10, 4, 25, 1 },
                    { 118, 1, 15, 5, 25, 1 },
                    { 119, 1, 15, 6, 25, 1 },
                    { 120, 1, 15, 7, 25, 1 },
                    { 121, 1, 15, 8, 25, 1 },
                    { 122, 1, 15, 9, 25, 1 },
                    { 123, 1, 15, 10, 25, 1 },
                    { 124, 1, 15, 11, 25, 1 },
                    { 125, 1, 15, 12, 25, 1 },
                    { 126, 1, 15, 13, 25, 1 },
                    { 127, 1, 15, 14, 25, 1 },
                    { 128, 1, 15, 15, 25, 1 },
                    { 129, 1, 24, 16, 25, 1 },
                    { 130, 1, 24, 17, 25, 1 },
                    { 131, 1, 24, 18, 25, 1 },
                    { 132, 1, 24, 19, 25, 1 },
                    { 133, 1, 24, 20, 25, 1 },
                    { 134, 1, 24, 21, 25, 1 },
                    { 135, 1, 24, 22, 25, 1 },
                    { 136, 1, 24, 23, 25, 1 },
                    { 137, 1, 24, 24, 25, 1 },
                    { 138, 1, 24, 25, 25, 1 },
                    { 139, 1, 24, 26, 25, 1 },
                    { 140, 1, 24, 27, 25, 1 },
                    { 141, 1, 24, 28, 25, 1 },
                    { 142, 1, 32, 29, 25, 1 },
                    { 143, 1, 33, 30, 25, 1 },
                    { 144, 1, 34, 31, 25, 1 },
                    { 145, 1, 9, 1, 26, 1 },
                    { 146, 1, 10, 2, 26, 1 },
                    { 147, 1, 10, 3, 26, 1 },
                    { 148, 1, 24, 4, 26, 1 },
                    { 149, 1, 24, 5, 26, 1 },
                    { 150, 1, 24, 6, 26, 1 },
                    { 151, 1, 24, 7, 26, 1 },
                    { 152, 1, 24, 8, 26, 1 },
                    { 153, 1, 24, 9, 26, 1 },
                    { 154, 1, 24, 10, 26, 1 },
                    { 155, 1, 24, 11, 26, 1 },
                    { 156, 1, 24, 12, 26, 1 },
                    { 157, 1, 24, 13, 26, 1 },
                    { 158, 1, 24, 14, 26, 1 },
                    { 159, 1, 25, 15, 26, 1 },
                    { 160, 1, 32, 16, 26, 1 },
                    { 161, 1, 33, 17, 26, 1 },
                    { 162, 1, 33, 18, 26, 1 },
                    { 163, 1, 33, 19, 26, 1 },
                    { 164, 1, 33, 20, 26, 1 },
                    { 165, 1, 33, 21, 26, 1 },
                    { 166, 1, 33, 22, 26, 1 },
                    { 167, 1, 33, 23, 26, 1 },
                    { 168, 1, 33, 24, 26, 1 },
                    { 169, 1, 33, 25, 26, 1 },
                    { 170, 1, 33, 26, 26, 1 },
                    { 171, 1, 33, 27, 26, 1 },
                    { 172, 1, 33, 28, 26, 1 },
                    { 173, 1, 36, 0, 27, 1 },
                    { 174, 1, 10, 1, 27, 1 },
                    { 175, 1, 10, 2, 27, 1 },
                    { 176, 1, 15, 3, 27, 1 },
                    { 177, 1, 32, 4, 27, 1 },
                    { 178, 1, 33, 5, 27, 1 },
                    { 179, 1, 33, 6, 27, 1 },
                    { 180, 1, 33, 7, 27, 1 },
                    { 181, 1, 33, 8, 27, 1 },
                    { 182, 1, 33, 9, 27, 1 },
                    { 183, 1, 33, 10, 27, 1 },
                    { 184, 1, 33, 11, 27, 1 },
                    { 185, 1, 33, 12, 27, 1 },
                    { 186, 1, 33, 13, 27, 1 },
                    { 187, 1, 33, 14, 27, 1 },
                    { 188, 1, 51, 15, 27, 1 },
                    { 189, 1, 45, 0, 28, 1 },
                    { 190, 1, 14, 1, 28, 1 },
                    { 191, 1, 15, 2, 28, 1 },
                    { 192, 1, 16, 3, 28, 1 },
                    { 193, 1, 23, 1, 29, 1 },
                    { 194, 1, 24, 2, 29, 1 },
                    { 195, 1, 25, 3, 29, 1 },
                    { 196, 1, 32, 1, 30, 1 },
                    { 197, 1, 33, 2, 30, 1 },
                    { 198, 1, 34, 3, 30, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MapTiles_MapId",
                table: "MapTiles",
                column: "MapId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MapTiles",
                table: "MapTiles");

            migrationBuilder.DropIndex(
                name: "IX_MapTiles_MapId",
                table: "MapTiles");

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyColumnType: "INTEGER",
                keyValue: 198);

            migrationBuilder.DropColumn(
                name: "MapTileId",
                table: "MapTiles");

            migrationBuilder.DropColumn(
                name: "ZIndex",
                table: "MapTiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MapTiles",
                table: "MapTiles",
                columns: new[] { "MapId", "X", "Y" });

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
