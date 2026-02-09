using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMapV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 427,
                column: "TileId",
                value: 56);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MapTiles",
                keyColumn: "MapTileId",
                keyValue: 427,
                column: "TileId",
                value: 65);
        }
    }
}
