using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoccerManager.Migrations
{
    public partial class UpdateCoach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "ck_NationalTeamIdOrLeagueTeamId",
                table: "Coach",
                sql: "(NationalTeamId is not null and LeagueTeamId is null) or (LeagueTeamId is not null and NationalTeamId is null)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "ck_NationalTeamIdOrLeagueTeamId",
                table: "Coach");
        }
    }
}
