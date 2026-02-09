using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class updateGameplay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: 150);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 3 },
                column: "PopulationCost",
                value: 175);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 4 },
                column: "PopulationCost",
                value: 200);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 5 },
                column: "PopulationCost",
                value: 225);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 6 },
                column: "PopulationCost",
                value: 250);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 7 },
                column: "PopulationCost",
                value: 275);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 8 },
                column: "PopulationCost",
                value: 300);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 9 },
                column: "PopulationCost",
                value: 325);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 10 },
                column: "PopulationCost",
                value: 350);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 1 },
                column: "PopulationCost",
                value: 30);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 2 },
                column: "PopulationCost",
                value: 60);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 3 },
                column: "PopulationCost",
                value: 90);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 4 },
                column: "PopulationCost",
                value: 120);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 5 },
                column: "PopulationCost",
                value: 150);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 6 },
                column: "PopulationCost",
                value: 180);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 7 },
                column: "PopulationCost",
                value: 210);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 8 },
                column: "PopulationCost",
                value: 240);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 9 },
                column: "PopulationCost",
                value: 270);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 10 },
                column: "PopulationCost",
                value: 300);
        }
    }
}
