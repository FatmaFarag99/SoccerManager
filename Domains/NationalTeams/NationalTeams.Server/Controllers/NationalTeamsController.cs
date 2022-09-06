namespace NationalTeams.Server;

[Route("api/[controller]")]
[ApiController]
public class NationalTeamsController : BaseController<NationalTeam, NationalTeamViewModel>
{
    public NationalTeamsController(INationalTeamUnitOfWork unitOfWork, IMapper mapper, IValidator<NationalTeamViewModel> validator) 
        : base(unitOfWork, mapper, validator)
    {
    }
}