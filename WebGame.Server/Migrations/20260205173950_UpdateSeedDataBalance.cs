using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataBalance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "GameStates",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 17, 8 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 19, 11 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 21, 14 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 23, 17 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 25, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 27, 23 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 29, 26 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 31, 29 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 33, 32 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 35, 35 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 6, 8 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 8, 11 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 12, 17 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 14, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 16, 23 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 18, 26 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 20, 29 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 22, 32 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 24, 35 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 11, 8 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 13, 11 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 15, 14 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 17, 17 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 19, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 21, 23 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 23, 26 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 25, 29 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 27, 32 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 29, 35 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 13, 14 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 15, 17 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 17, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 19, 23 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 21, 26 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 23, 29 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 25, 32 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 27, 35 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 11, 8 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 13, 11 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 15, 14 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 17, 17 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 19, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 21, 23 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 23, 26 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 25, 29 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 27, 32 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 29, 35 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 7, 8 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 9, 11 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 11, 14 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 13, 17 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 15, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 17, 23 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 19, 26 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 21, 29 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 23, 32 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 25, 35 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 2,
                column: "InitialCost",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 3,
                column: "InitialCost",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 4,
                column: "InitialCost",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 5,
                column: "InitialCost",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 6,
                column: "InitialCost",
                value: 8);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "GameStates");

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 32, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 34, 200 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 36, 300 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 38, 400 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 40, 500 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 42, 600 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 44, 700 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 46, 800 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 48, 900 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 50, 1000 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 10, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 12, 200 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 14, 300 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 16, 400 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 18, 500 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 20, 600 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 22, 700 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 24, 800 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 26, 900 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 28, 1000 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 20, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 22, 200 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 24, 300 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 26, 400 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 28, 500 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 30, 600 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 32, 700 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 34, 800 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 36, 900 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 38, 1000 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 17, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 19, 200 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 21, 300 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 23, 400 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 25, 500 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 27, 600 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 29, 700 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 31, 800 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 33, 900 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 35, 1000 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 20, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 22, 200 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 24, 300 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 26, 400 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 28, 500 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 30, 600 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 32, 700 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 34, 800 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 36, 900 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 38, 1000 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 12, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 14, 200 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 16, 300 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 4 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 18, 400 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 5 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 20, 500 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 22, 600 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 7 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 24, 700 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 8 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 26, 800 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 9 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 28, 900 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 10 },
                columns: new[] { "Capacity", "UpgradeCost" },
                values: new object[] { 30, 1000 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 2,
                column: "InitialCost",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 3,
                column: "InitialCost",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 4,
                column: "InitialCost",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 5,
                column: "InitialCost",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 6,
                column: "InitialCost",
                value: 130);
        }
    }
}
