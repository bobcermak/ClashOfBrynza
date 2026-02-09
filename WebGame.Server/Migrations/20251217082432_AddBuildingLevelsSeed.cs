using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddBuildingLevelsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bulding_Resource_ResourceId",
                table: "Bulding");

            migrationBuilder.AlterColumn<int>(
                name: "ResourceId",
                table: "Bulding",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "BuildingLevel",
                columns: new[] { "BuildingId", "Level", "GainIntervalSeconds", "ResourceGain", "UpgradeCost" },
                values: new object[,]
                {
                    { 1, 1, 30, 10, 100 },
                    { 1, 2, 30, 20, 200 },
                    { 1, 3, 30, 30, 300 },
                    { 1, 4, 30, 40, 400 },
                    { 1, 5, 30, 50, 500 },
                    { 1, 6, 30, 60, 600 },
                    { 1, 7, 30, 70, 700 },
                    { 1, 8, 30, 80, 800 },
                    { 1, 9, 30, 90, 900 },
                    { 1, 10, 30, 100, 1000 },
                    { 2, 1, 30, 10, 100 },
                    { 2, 2, 30, 20, 200 },
                    { 2, 3, 30, 30, 300 },
                    { 2, 4, 30, 40, 400 },
                    { 2, 5, 30, 50, 500 },
                    { 2, 6, 30, 60, 600 },
                    { 2, 7, 30, 70, 700 },
                    { 2, 8, 30, 80, 800 },
                    { 2, 9, 30, 90, 900 },
                    { 2, 10, 30, 100, 1000 },
                    { 3, 1, 30, 10, 100 },
                    { 3, 2, 30, 20, 200 },
                    { 3, 3, 30, 30, 300 },
                    { 3, 4, 30, 40, 400 },
                    { 3, 5, 30, 50, 500 },
                    { 3, 6, 30, 60, 600 },
                    { 3, 7, 30, 70, 700 },
                    { 3, 8, 30, 80, 800 },
                    { 3, 9, 30, 90, 900 },
                    { 3, 10, 30, 100, 1000 },
                    { 4, 1, 30, 10, 100 },
                    { 4, 2, 30, 20, 200 },
                    { 4, 3, 30, 30, 300 },
                    { 4, 4, 30, 40, 400 },
                    { 4, 5, 30, 50, 500 },
                    { 4, 6, 30, 60, 600 },
                    { 4, 7, 30, 70, 700 },
                    { 4, 8, 30, 80, 800 },
                    { 4, 9, 30, 90, 900 },
                    { 4, 10, 30, 100, 1000 },
                    { 5, 1, 30, 10, 100 },
                    { 5, 2, 30, 20, 200 },
                    { 5, 3, 30, 30, 300 },
                    { 5, 4, 30, 40, 400 },
                    { 5, 5, 30, 50, 500 },
                    { 5, 6, 30, 60, 600 },
                    { 5, 7, 30, 70, 700 },
                    { 5, 8, 30, 80, 800 },
                    { 5, 9, 30, 90, 900 },
                    { 5, 10, 30, 100, 1000 },
                    { 6, 1, 30, 10, 100 },
                    { 6, 2, 30, 20, 200 },
                    { 6, 3, 30, 30, 300 },
                    { 6, 4, 30, 40, 400 },
                    { 6, 5, 30, 50, 500 },
                    { 6, 6, 30, 60, 600 },
                    { 6, 7, 30, 70, 700 },
                    { 6, 8, 30, 80, 800 },
                    { 6, 9, 30, 90, 900 },
                    { 6, 10, 30, 100, 1000 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Bulding_Resource_ResourceId",
                table: "Bulding",
                column: "ResourceId",
                principalTable: "Resource",
                principalColumn: "ResourceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bulding_Resource_ResourceId",
                table: "Bulding");

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "BuildingLevel",
                keyColumns: new[] { "BuildingId", "Level" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.AlterColumn<int>(
                name: "ResourceId",
                table: "Bulding",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bulding_Resource_ResourceId",
                table: "Bulding",
                column: "ResourceId",
                principalTable: "Resource",
                principalColumn: "ResourceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
