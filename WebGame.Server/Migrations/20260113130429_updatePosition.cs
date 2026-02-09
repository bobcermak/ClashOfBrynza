using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatePosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapBuildings",
                keyColumns: new[] { "BottomLeftX", "BottomLeftY", "MapId" },
                keyValues: new object[] { 1, 13, 2 });

            migrationBuilder.InsertData(
                table: "MapBuildings",
                columns: new[] { "BottomLeftX", "BottomLeftY", "MapId", "BuildingId" },
                values: new object[] { 18, 3, 2, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapBuildings",
                keyColumns: new[] { "BottomLeftX", "BottomLeftY", "MapId" },
                keyValues: new object[] { 18, 3, 2 });

            migrationBuilder.InsertData(
                table: "MapBuildings",
                columns: new[] { "BottomLeftX", "BottomLeftY", "MapId", "BuildingId" },
                values: new object[] { 1, 13, 2, 1 });
        }
    }
}
