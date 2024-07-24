using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchGolf.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Team1Hole1 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole2 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole3 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole4 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole5 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole6 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole7 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole8 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole9 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole10 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole11 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole12 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole13 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole14 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole15 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole16 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole17 = table.Column<int>(type: "int", nullable: false),
                    Team1Hole18 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole1 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole2 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole3 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole4 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole5 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole6 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole7 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole8 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole9 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole10 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole11 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole12 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole13 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole14 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole15 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole16 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole17 = table.Column<int>(type: "int", nullable: false),
                    Team2Hole18 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Team1Id = table.Column<int>(type: "int", nullable: false),
                    Team2Id = table.Column<int>(type: "int", nullable: false),
                    ScoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Scores_ScoreId",
                        column: x => x.ScoreId,
                        principalTable: "Scores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_Team1Id",
                        column: x => x.Team1Id,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Matches_Teams_Team2Id",
                        column: x => x.Team2Id,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Matches_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TeamTournament",
                columns: table => new
                {
                    TeamsId = table.Column<int>(type: "int", nullable: false),
                    TournamentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTournament", x => new { x.TeamsId, x.TournamentsId });
                    table.ForeignKey(
                        name: "FK_TeamTournament_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamTournament_Tournaments_TournamentsId",
                        column: x => x.TournamentsId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_ScoreId",
                table: "Matches",
                column: "ScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Team1Id",
                table: "Matches",
                column: "Team1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Team2Id",
                table: "Matches",
                column: "Team2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamTournament_TournamentsId",
                table: "TeamTournament",
                column: "TournamentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "TeamTournament");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Tournaments");
        }
    }
}
