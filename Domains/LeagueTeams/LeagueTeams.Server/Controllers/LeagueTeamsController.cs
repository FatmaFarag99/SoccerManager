namespace LeagueTeams.Server;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class LeagueTeamsController : BaseController<LeagueTeam, LeagueTeamViewModel>
{
    public LeagueTeamsController(ILeagueTeamUnitOfWork unitOfWork, IMapper mapper, IValidator<LeagueTeamViewModel> validator) 
        : base(unitOfWork, mapper, validator)
    {
    }

    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] LeagueTeamViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Put([FromBody] LeagueTeamViewModel productViewModel)
    {
        return base.Put(productViewModel);
    }
}