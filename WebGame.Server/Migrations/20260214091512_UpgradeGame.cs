using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpgradeGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayTimeSeconds",
                table: "GameStates",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayTimeSeconds",
                table: "GameStates");
        }
    }
}
