using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class bottomLeftOrientation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TopLeftY",
                table: "MapBuildings",
                newName: "BottomLeftY");

            migrationBuilder.RenameColumn(
                name: "TopLeftX",
                table: "MapBuildings",
                newName: "BottomLeftX");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BottomLeftY",
                table: "MapBuildings",
                newName: "TopLeftY");

            migrationBuilder.RenameColumn(
                name: "BottomLeftX",
                table: "MapBuildings",
                newName: "TopLeftX");
        }
    }
}
