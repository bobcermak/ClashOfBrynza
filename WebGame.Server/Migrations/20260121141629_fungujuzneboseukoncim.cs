using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class fungujuzneboseukoncim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MapBuildings",
                keyColumns: new[] { "BottomLeftX", "BottomLeftY", "MapId" },
                keyValues: new object[] { 18, 3, 2 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumn: "MapId",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "MapId", "Title" },
                values: new object[] { 2, "Default building layer" });

            migrationBuilder.InsertData(
                table: "MapBuildings",
                columns: new[] { "BottomLeftX", "BottomLeftY", "MapId", "BuildingId" },
                values: new object[] { 18, 3, 2, 1 });
        }
    }
}
