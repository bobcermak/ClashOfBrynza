using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class SyncDatabaseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingLevels_Buldings_BuildingId",
                table: "BuildingLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_Buldings_Resources_ResourceId",
                table: "Buldings");

            migrationBuilder.DropForeignKey(
                name: "FK_MapBuildings_Buldings_BuildingId",
                table: "MapBuildings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buldings",
                table: "Buldings");

            migrationBuilder.RenameTable(
                name: "Buldings",
                newName: "Buildings");

            migrationBuilder.RenameIndex(
                name: "IX_Buldings_ResourceId",
                table: "Buildings",
                newName: "IX_Buildings_ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buildings",
                table: "Buildings",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingLevels_Buildings_BuildingId",
                table: "BuildingLevels",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Resources_ResourceId",
                table: "Buildings",
                column: "ResourceId",
                principalTable: "Resources",
                principalColumn: "ResourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_MapBuildings_Buildings_BuildingId",
                table: "MapBuildings",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingLevels_Buildings_BuildingId",
                table: "BuildingLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Resources_ResourceId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_MapBuildings_Buildings_BuildingId",
                table: "MapBuildings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buildings",
                table: "Buildings");

            migrationBuilder.RenameTable(
                name: "Buildings",
                newName: "Buldings");

            migrationBuilder.RenameIndex(
                name: "IX_Buildings_ResourceId",
                table: "Buldings",
                newName: "IX_Buldings_ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buldings",
                table: "Buldings",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingLevels_Buldings_BuildingId",
                table: "BuildingLevels",
                column: "BuildingId",
                principalTable: "Buldings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buldings_Resources_ResourceId",
                table: "Buldings",
                column: "ResourceId",
                principalTable: "Resources",
                principalColumn: "ResourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_MapBuildings_Buldings_BuildingId",
                table: "MapBuildings",
                column: "BuildingId",
                principalTable: "Buldings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
