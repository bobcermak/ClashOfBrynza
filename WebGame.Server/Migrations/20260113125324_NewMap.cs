using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class NewMap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 695,
                column: "TileId",
                value: 63);

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 734,
                column: "TileId",
                value: 63);

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 778,
                column: "TileId",
                value: 63);

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 798,
                column: "TileId",
                value: 55);

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 799,
                column: "TileId",
                value: 55);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 695,
                column: "TileId",
                value: 64);

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 734,
                column: "TileId",
                value: 64);

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 778,
                column: "TileId",
                value: 64);

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 798,
                column: "TileId",
                value: 64);

            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 799,
                column: "TileId",
                value: 64);
        }
    }
}
