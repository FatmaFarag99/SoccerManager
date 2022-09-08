namespace Players.Server;

[Route("api/[controller]")]
[ApiController]
public class PlayersController : BaseController<Player, PlayerViewModel>
{
    public PlayersController(IPlayerUnitOfWork unitOfWork, IMapper mapper, IValidator<PlayerViewModel> validator) 
        : base(unitOfWork, mapper, validator)
    {
    }

}