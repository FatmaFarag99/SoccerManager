namespace Coaches.Server;

[Route("api/[controller]")]
[ApiController]
public class CoachesController : BaseController<Coach, CoachViewModel>
{
    public CoachesController(ICoachUnitOfWork unitOfWork, IMapper mapper, IValidator<CoachViewModel> validator) 
        : base(unitOfWork, mapper, validator)
    {
    }
}