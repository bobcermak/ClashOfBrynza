using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    ResourceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.ResourceId);
                });

            migrationBuilder.CreateTable(
                name: "Bulding",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ResourceId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsTownHall = table.Column<bool>(type: "INTEGER", nullable: false),
                    InitialCost = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bulding", x => x.BuildingId);
                    table.ForeignKey(
                        name: "FK_Bulding_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resource",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuildingLevel",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    UpgradeCost = table.Column<int>(type: "INTEGER", nullable: false),
                    ResourceGain = table.Column<int>(type: "INTEGER", nullable: false),
                    GainIntervalSeconds = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingLevel", x => new { x.BuildingId, x.Level });
                    table.ForeignKey(
                        name: "FK_BuildingLevel_Bulding_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Bulding",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "ResourceId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Popis ovce", "Ovce" },
                    { 2, "Popis populace", "Populace" },
                    { 3, "Popis vojska", "Vojsko" }
                });

            migrationBuilder.InsertData(
                table: "Bulding",
                columns: new[] { "BuildingId", "Description", "Height", "InitialCost", "IsTownHall", "Name", "ResourceId", "Width" },
                values: new object[,]
                {
                    { 1, "Popis radnice", 7, 0, true, "Radnice", 2, 10 },
                    { 2, "Popis domu", 6, 90, false, "Domek", 2, 4 },
                    { 3, "Popis kostelu", 9, 100, false, "Kostel", 2, 6 },
                    { 4, "Popis střelnice", 7, 110, false, "Střelnice", 3, 6 },
                    { 5, "Popis zbrojírny", 7, 120, false, "Zbrojírna", 3, 6 },
                    { 6, "Popis věže", 7, 130, false, "Věž", 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bulding_ResourceId",
                table: "Bulding",
                column: "ResourceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingLevel");

            migrationBuilder.DropTable(
                name: "Bulding");

            migrationBuilder.DropTable(
                name: "Resource");
        }
    }
}
