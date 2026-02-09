using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MapBuildings",
                columns: new[] { "MapId", "TopLeftX", "TopLeftY", "BuildingId" },
                values: new object[] { 2, 4, 5, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapBuildings",
                keyColumns: new[] { "MapId", "TopLeftX", "TopLeftY" },
                keyValues: new object[] { 2, 4, 5 });
        }
    }
}
