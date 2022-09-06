namespace LeagueTeams.Server;
public class LeagueTeamRepository : BaseRepository<LeagueTeam> , ILeagueTeamRepository
{
    public LeagueTeamRepository(DbContext dbContext) : base(dbContext)
    {
    }
}