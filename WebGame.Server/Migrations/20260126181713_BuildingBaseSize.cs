using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class BuildingBaseSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseHeight",
                table: "Buildings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseWidth",
                table: "Buildings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 1,
                columns: new[] { "BaseHeight", "BaseWidth" },
                values: new object[] { 6, 10 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 2,
                columns: new[] { "BaseHeight", "BaseWidth" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 3,
                columns: new[] { "BaseHeight", "BaseWidth" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 4,
                columns: new[] { "BaseHeight", "BaseWidth" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 5,
                columns: new[] { "BaseHeight", "BaseWidth" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 6,
                columns: new[] { "BaseHeight", "BaseWidth" },
                values: new object[] { 5, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseHeight",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "BaseWidth",
                table: "Buildings");
        }
    }
}
