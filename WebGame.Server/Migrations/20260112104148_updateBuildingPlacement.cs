using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class updateBuildingPlacement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapBuildings",
                keyColumns: new[] { "MapId", "TopLeftX", "TopLeftY" },
                keyValues: new object[] { 2, 5, 5 });

            migrationBuilder.InsertData(
                table: "MapBuildings",
                columns: new[] { "MapId", "TopLeftX", "TopLeftY", "BuildingId" },
                values: new object[] { 2, 1, 13, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapBuildings",
                keyColumns: new[] { "MapId", "TopLeftX", "TopLeftY" },
                keyValues: new object[] { 2, 1, 13 });

            migrationBuilder.InsertData(
                table: "MapBuildings",
                columns: new[] { "MapId", "TopLeftX", "TopLeftY", "BuildingId" },
                values: new object[] { 2, 5, 5, 1 });
        }
    }
}
