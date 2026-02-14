using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebGame.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddLeaderboardAndCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "GameStates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "LeaderboardEntries",
                columns: table => new
                {
                    LeaderboardEntryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nickname = table.Column<string>(type: "TEXT", maxLength: 16, nullable: false),
                    TimeInSeconds = table.Column<int>(type: "INTEGER", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PlayerId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaderboardEntries", x => x.LeaderboardEntryId);
                    table.ForeignKey(
                        name: "FK_LeaderboardEntries_GameStates_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "GameStates",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaderboardEntries_PlayerId",
                table: "LeaderboardEntries",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaderboardEntries");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "GameStates");
        }
    }
}
