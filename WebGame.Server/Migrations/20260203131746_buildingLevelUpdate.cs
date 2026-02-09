using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class buildingLevelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GainIntervalSeconds",
                table: "BuildingLevels");

            migrationBuilder.RenameColumn(
                name: "ResourceGain",
                table: "BuildingLevels",
                newName: "Capacity");

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "MapBuildings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 1 },
                column: "Capacity",
                value: 32);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 2 },
                column: "Capacity",
                value: 34);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 3 },
                column: "Capacity",
                value: 36);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 4 },
                column: "Capacity",
                value: 38);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 5 },
                column: "Capacity",
                value: 40);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 6 },
                column: "Capacity",
                value: 42);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 7 },
                column: "Capacity",
                value: 44);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 8 },
                column: "Capacity",
                value: 46);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 9 },
                column: "Capacity",
                value: 48);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 10 },
                column: "Capacity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 2 },
                column: "Capacity",
                value: 12);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 3 },
                column: "Capacity",
                value: 14);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 4 },
                column: "Capacity",
                value: 16);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 5 },
                column: "Capacity",
                value: 18);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 6 },
                column: "Capacity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 7 },
                column: "Capacity",
                value: 22);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 8 },
                column: "Capacity",
                value: 24);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 9 },
                column: "Capacity",
                value: 26);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 10 },
                column: "Capacity",
                value: 28);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 1 },
                column: "Capacity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 2 },
                column: "Capacity",
                value: 22);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 3 },
                column: "Capacity",
                value: 24);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 4 },
                column: "Capacity",
                value: 26);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 5 },
                column: "Capacity",
                value: 28);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 6 },
                column: "Capacity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 7 },
                column: "Capacity",
                value: 32);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 8 },
                column: "Capacity",
                value: 34);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 9 },
                column: "Capacity",
                value: 36);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 10 },
                column: "Capacity",
                value: 38);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 1 },
                column: "Capacity",
                value: 17);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 2 },
                column: "Capacity",
                value: 19);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 3 },
                column: "Capacity",
                value: 21);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 4 },
                column: "Capacity",
                value: 23);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 5 },
                column: "Capacity",
                value: 25);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 6 },
                column: "Capacity",
                value: 27);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 7 },
                column: "Capacity",
                value: 29);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 8 },
                column: "Capacity",
                value: 31);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 9 },
                column: "Capacity",
                value: 33);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 10 },
                column: "Capacity",
                value: 35);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 1 },
                column: "Capacity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 2 },
                column: "Capacity",
                value: 22);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 3 },
                column: "Capacity",
                value: 24);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 4 },
                column: "Capacity",
                value: 26);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 5 },
                column: "Capacity",
                value: 28);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 6 },
                column: "Capacity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 7 },
                column: "Capacity",
                value: 32);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 8 },
                column: "Capacity",
                value: 34);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 9 },
                column: "Capacity",
                value: 36);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 10 },
                column: "Capacity",
                value: 38);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 1 },
                column: "Capacity",
                value: 12);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 2 },
                column: "Capacity",
                value: 14);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 3 },
                column: "Capacity",
                value: 16);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 4 },
                column: "Capacity",
                value: 18);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 5 },
                column: "Capacity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 6 },
                column: "Capacity",
                value: 22);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 7 },
                column: "Capacity",
                value: 24);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 8 },
                column: "Capacity",
                value: 26);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 9 },
                column: "Capacity",
                value: 28);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 10 },
                column: "Capacity",
                value: 30);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "MapBuildings");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "BuildingLevels",
                newName: "ResourceGain");

            migrationBuilder.AddColumn<int>(
                name: "GainIntervalSeconds",
                table: "BuildingLevels",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 10 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 30 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 40 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 50 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 60 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 7 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 70 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 80 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 90 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 1 },
                column: "GainIntervalSeconds",
                value: 30);

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 30 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 40 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 50 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 60 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 7 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 70 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 8 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 80 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 9 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 90 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 10 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 10 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 30 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 4 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 40 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 5 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 50 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 6 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 60 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 7 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 70 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 8 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 80 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 9 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 90 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 10 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 10 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 30 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 40 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 50 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 60 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 7 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 70 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 8 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 80 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 9 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 90 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 10 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 10 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 30 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 40 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 50 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 6 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 60 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 7 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 70 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 8 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 80 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 9 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 90 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 10 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 100 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 10 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 20 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 30 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 4 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 40 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 5 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 50 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 60 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 7 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 70 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 8 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 80 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 9 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 90 });

            migrationBuilder.UpdateData(
                table: "BuildingLevels",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 10 },
                columns: new[] { "GainIntervalSeconds", "ResourceGain" },
                values: new object[] { 30, 100 });
        }
    }
}
