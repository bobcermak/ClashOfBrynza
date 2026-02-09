using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class Tiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPlaceable",
                table: "Tiles",
                newName: "IsPlacable");

            migrationBuilder.InsertData(
                table: "Tiles",
                columns: new[] { "TileId", "IsPlacable" },
                values: new object[,]
                {
                    { 1, true },
                    { 2, true },
                    { 3, true },
                    { 5, true },
                    { 6, true },
                    { 7, true },
                    { 8, true },
                    { 9, true },
                    { 10, true },
                    { 11, true },
                    { 12, true },
                    { 14, true },
                    { 15, true },
                    { 16, true },
                    { 17, true },
                    { 18, true },
                    { 19, true },
                    { 20, true },
                    { 21, true },
                    { 23, true },
                    { 24, true },
                    { 25, true },
                    { 26, true },
                    { 27, true },
                    { 28, true },
                    { 29, true },
                    { 30, true },
                    { 32, false },
                    { 33, false },
                    { 34, false },
                    { 35, false },
                    { 36, false },
                    { 39, false },
                    { 41, true },
                    { 42, true },
                    { 43, true },
                    { 44, true },
                    { 45, false },
                    { 48, false },
                    { 50, false },
                    { 51, false },
                    { 52, false },
                    { 53, false },
                    { 54, true },
                    { 55, true },
                    { 56, true },
                    { 57, true },
                    { 59, true },
                    { 60, true },
                    { 61, true },
                    { 62, true },
                    { 63, true },
                    { 64, true },
                    { 65, true },
                    { 66, true },
                    { 68, true },
                    { 69, true },
                    { 70, true },
                    { 71, true },
                    { 72, true },
                    { 73, true },
                    { 74, true },
                    { 75, true },
                    { 77, true },
                    { 78, true },
                    { 79, true },
                    { 80, true },
                    { 81, true },
                    { 82, true },
                    { 83, true },
                    { 84, true },
                    { 86, false },
                    { 87, false },
                    { 88, false },
                    { 89, false },
                    { 90, false },
                    { 93, false },
                    { 95, true },
                    { 96, true },
                    { 97, true },
                    { 98, true },
                    { 99, false },
                    { 102, false },
                    { 104, false },
                    { 105, false },
                    { 106, false },
                    { 107, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Tiles",
                keyColumn: "TileId",
                keyValue: 107);

            migrationBuilder.RenameColumn(
                name: "IsPlacable",
                table: "Tiles",
                newName: "IsPlaceable");
        }
    }
}
