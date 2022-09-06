namespace LeagueTeams.Server
{
    using Common;

    public class LeagueTeamUnitOfWork : BaseUnitOfWork<LeagueTeam>, ILeagueTeamUnitOfWork
    {
        public LeagueTeamUnitOfWork(ILeagueTeamRepository repsitory) : base(repsitory)
        {
        }
    }
}
