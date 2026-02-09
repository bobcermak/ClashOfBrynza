using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class trackEdgeDirection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsEdge",
                table: "Tiles",
                newName: "IsEdgeWest");

            migrationBuilder.AddColumn<bool>(
                name: "IsEdgeEast",
                table: "Tiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEdgeNorth",
                table: "Tiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEdgeSouth",
                table: "Tiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 1,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 2,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 3,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 5,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 6,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { false, true, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 7,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, true, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 8,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 9,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 10,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 11,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 12,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 14,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 15,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 16,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 17,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 18,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 19,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 20,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 21,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 23,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, true });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 24,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { false, false, true, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 25,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, false, true, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 26,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 27,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 28,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 29,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 30,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 32,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 33,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 34,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 35,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 36,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 39,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 41,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 42,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 43,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 44,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 45,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 48,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 50,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 51,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 52,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 53,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 54,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, true, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 55,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { false, true, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 56,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, true, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 57,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 59,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, true, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 60,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { false, true, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 61,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, true, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 62,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 63,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 64,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 65,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 66,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 68,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 69,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 70,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 71,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 72,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, true });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 73,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { false, false, true, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 74,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, false, true, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 75,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { true, false, true });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 77,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, true });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 78,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { false, false, true, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 79,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, false, true, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 80,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 81,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, true, true });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 82,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { false, true, true, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 83,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth", "IsEdgeWest" },
                values: new object[] { true, true, true, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 84,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { true, true, true });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 86,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 87,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 88,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 89,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 90,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 93,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 95,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 96,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 97,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 98,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 99,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 102,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 104,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 105,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 106,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 107,
                columns: new[] { "IsEdgeEast", "IsEdgeNorth", "IsEdgeSouth" },
                values: new object[] { false, false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEdgeEast",
                table: "Tiles");

            migrationBuilder.DropColumn(
                name: "IsEdgeNorth",
                table: "Tiles");

            migrationBuilder.DropColumn(
                name: "IsEdgeSouth",
                table: "Tiles");

            migrationBuilder.RenameColumn(
                name: "IsEdgeWest",
                table: "Tiles",
                newName: "IsEdge");

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
                keyValue: 11,
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
                keyValue: 55,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 56,
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
                keyValue: 65,
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
                keyValue: 73,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 74,
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
                keyValue: 82,
                column: "IsEdge",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 83,
                column: "IsEdge",
                value: true);
        }
    }
}
