using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class changesBuildingWidth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 1,
                columns: new[] { "Height", "Width" },
                values: new object[] { 6, 9 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 1,
                columns: new[] { "Height", "Width" },
                values: new object[] { 7, 10 });
        }
    }
}
