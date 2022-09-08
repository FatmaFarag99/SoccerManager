namespace Coaches.Server;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class CoachesController : BaseController<Coach, CoachViewModel>
{
    public CoachesController(ICoachUnitOfWork unitOfWork, IMapper mapper, IValidator<CoachViewModel> validator) 
        : base(unitOfWork, mapper, validator)
    {
    }

    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] CoachViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Put([FromBody] CoachViewModel productViewModel)
    {
        return base.Put(productViewModel);
    }
}