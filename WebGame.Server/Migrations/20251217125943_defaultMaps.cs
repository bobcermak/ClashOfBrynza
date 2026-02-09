using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class defaultMaps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingLevel_Bulding_BuildingId",
                table: "BuildingLevel");

            migrationBuilder.DropForeignKey(
                name: "FK_Bulding_Resource_ResourceId",
                table: "Bulding");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resource",
                table: "Resource");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bulding",
                table: "Bulding");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingLevel",
                table: "BuildingLevel");

            migrationBuilder.RenameTable(
                name: "Resource",
                newName: "Resources");

            migrationBuilder.RenameTable(
                name: "Bulding",
                newName: "Buldings");

            migrationBuilder.RenameTable(
                name: "BuildingLevel",
                newName: "BuildingLevels");

            migrationBuilder.RenameIndex(
                name: "IX_Bulding_ResourceId",
                table: "Buldings",
                newName: "IX_Buldings_ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resources",
                table: "Resources",
                column: "ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buldings",
                table: "Buldings",
                column: "BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingLevels",
                table: "BuildingLevels",
                columns: new[] { "BuildingId", "Level" });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    MapId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.MapId);
                });

            migrationBuilder.CreateTable(
                name: "Tiles",
                columns: table => new
                {
                    TileId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsPlaceable = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiles", x => x.TileId);
                });

            migrationBuilder.CreateTable(
                name: "MapBuildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "INTEGER", nullable: false),
                    MapId = table.Column<int>(type: "INTEGER", nullable: false),
                    TopLeftX = table.Column<int>(type: "INTEGER", nullable: false),
                    TopLeftY = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapBuildings", x => new { x.BuildingId, x.MapId });
                    table.ForeignKey(
                        name: "FK_MapBuildings_Buldings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buldings",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapBuildings_Maps_MapId",
                        column: x => x.MapId,
                        principalTable: "Maps",
                        principalColumn: "MapId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapTiles",
                columns: table => new
                {
                    TileId = table.Column<int>(type: "INTEGER", nullable: false),
                    MapId = table.Column<int>(type: "INTEGER", nullable: false),
                    X = table.Column<int>(type: "INTEGER", nullable: false),
                    Y = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapTiles", x => new { x.TileId, x.MapId });
                    table.ForeignKey(
                        name: "FK_MapTiles_Maps_MapId",
                        column: x => x.MapId,
                        principalTable: "Maps",
                        principalColumn: "MapId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapTiles_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "TileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "MapId", "Title" },
                values: new object[,]
                {
                    { 1, "Default ground layer" },
                    { 2, "Default building layer" }
                });

            migrationBuilder.InsertData(
                table: "MapBuildings",
                columns: new[] { "BuildingId", "MapId", "TopLeftX", "TopLeftY" },
                values: new object[] { 1, 2, 5, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_MapBuildings_MapId",
                table: "MapBuildings",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_MapTiles_MapId",
                table: "MapTiles",
                column: "MapId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingLevels_Buldings_BuildingId",
                table: "BuildingLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_Buldings_Resources_ResourceId",
                table: "Buldings");

            migrationBuilder.DropTable(
                name: "MapBuildings");

            migrationBuilder.DropTable(
                name: "MapTiles");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "Tiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resources",
                table: "Resources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buldings",
                table: "Buldings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildingLevels",
                table: "BuildingLevels");

            migrationBuilder.RenameTable(
                name: "Resources",
                newName: "Resource");

            migrationBuilder.RenameTable(
                name: "Buldings",
                newName: "Bulding");

            migrationBuilder.RenameTable(
                name: "BuildingLevels",
                newName: "BuildingLevel");

            migrationBuilder.RenameIndex(
                name: "IX_Buldings_ResourceId",
                table: "Bulding",
                newName: "IX_Bulding_ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resource",
                table: "Resource",
                column: "ResourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bulding",
                table: "Bulding",
                column: "BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildingLevel",
                table: "BuildingLevel",
                columns: new[] { "BuildingId", "Level" });

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingLevel_Bulding_BuildingId",
                table: "BuildingLevel",
                column: "BuildingId",
                principalTable: "Bulding",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bulding_Resource_ResourceId",
                table: "Bulding",
                column: "ResourceId",
                principalTable: "Resource",
                principalColumn: "ResourceId");
        }
    }
}
