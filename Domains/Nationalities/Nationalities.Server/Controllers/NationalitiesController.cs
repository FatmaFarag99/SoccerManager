namespace Nationalities.Server;

[Route("api/[controller]")]
[ApiController]
public class NationalitiesController : BaseController<Nationality, NationalityViewModel>
{
    public NationalitiesController(INationalityUnitOfWork unitOfWork, IMapper mapper, IValidator<NationalityViewModel> validator) 
        : base(unitOfWork, mapper, validator)
    {
    }
}