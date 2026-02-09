using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class SpellingFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameStates_Maps_buildingMapId",
                table: "GameStates");

            migrationBuilder.RenameColumn(
                name: "buildingMapId",
                table: "GameStates",
                newName: "BuildingMapId");

            migrationBuilder.RenameIndex(
                name: "IX_GameStates_buildingMapId",
                table: "GameStates",
                newName: "IX_GameStates_BuildingMapId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameStates_Maps_BuildingMapId",
                table: "GameStates",
                column: "BuildingMapId",
                principalTable: "Maps",
                principalColumn: "MapId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameStates_Maps_BuildingMapId",
                table: "GameStates");

            migrationBuilder.RenameColumn(
                name: "BuildingMapId",
                table: "GameStates",
                newName: "buildingMapId");

            migrationBuilder.RenameIndex(
                name: "IX_GameStates_BuildingMapId",
                table: "GameStates",
                newName: "IX_GameStates_buildingMapId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameStates_Maps_buildingMapId",
                table: "GameStates",
                column: "buildingMapId",
                principalTable: "Maps",
                principalColumn: "MapId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
