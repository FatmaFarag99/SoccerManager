namespace LeagueTeams.Server;

[Route("api/[controller]")]
[ApiController]
public class LeagueTeamsController : BaseController<LeagueTeam, LeagueTeamViewModel>
{
    public LeagueTeamsController(ILeagueTeamUnitOfWork unitOfWork, IMapper mapper, IValidator<LeagueTeamViewModel> validator) 
        : base(unitOfWork, mapper, validator)
    {
    }
}