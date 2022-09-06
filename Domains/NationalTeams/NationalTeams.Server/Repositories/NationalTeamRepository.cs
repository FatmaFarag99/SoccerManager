namespace NationalTeams.Server;
public class NationalTeamRepository : BaseRepository<NationalTeam> , INationalTeamRepository
{
    public NationalTeamRepository(DbContext dbContext) : base(dbContext)
    {
    }
}