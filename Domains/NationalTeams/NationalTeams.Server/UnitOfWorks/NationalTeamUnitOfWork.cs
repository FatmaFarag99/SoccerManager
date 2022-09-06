namespace NationalTeams.Server
{
    using Common;

    public class NationalTeamUnitOfWork : BaseUnitOfWork<NationalTeam>, INationalTeamUnitOfWork
    {
        public NationalTeamUnitOfWork(INationalTeamRepository repsitory) : base(repsitory)
        {
        }
    }
}
