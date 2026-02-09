using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatePopulationsLimits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 1 },
                column: "PopulationCost",
                value: 75);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 2 },
                column: "PopulationCost",
                value: 150);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 3 },
                column: "PopulationCost",
                value: 225);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 4 },
                column: "PopulationCost",
                value: 300);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 5 },
                column: "PopulationCost",
                value: 375);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 6 },
                column: "PopulationCost",
                value: 450);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 7 },
                column: "PopulationCost",
                value: 525);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 8 },
                column: "PopulationCost",
                value: 600);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 9 },
                column: "PopulationCost",
                value: 675);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 10 },
                column: "PopulationCost",
                value: 750);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 1 },
                column: "PopulationCost",
                value: 100);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 2 },
                column: "PopulationCost",
                value: 200);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 3 },
                column: "PopulationCost",
                value: 300);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 4 },
                column: "PopulationCost",
                value: 400);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 5 },
                column: "PopulationCost",
                value: 500);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 6 },
                column: "PopulationCost",
                value: 600);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 7 },
                column: "PopulationCost",
                value: 700);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 8 },
                column: "PopulationCost",
                value: 800);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 9 },
                column: "PopulationCost",
                value: 900);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 10 },
                column: "PopulationCost",
                value: 1000);
        }
    }
}
