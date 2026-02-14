using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddUpgradeProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PlayTimeSeconds",
                table: "GameStates",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PlayTimeSeconds",
                table: "GameStates",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");
        }
    }
}
