namespace Players.Shared;
public class PlayerValidator : PersonValidator<PlayerViewModel>
{
	public PlayerValidator()
	{
		RuleFor(e => e.Weight).NotEmpty().GreaterThan(0);
		RuleFor(e => e.CurrentNumber).NotEmpty().GreaterThan(0);
		//RuleFor(e => e.Nationality).NotEmpty();
		//RuleFor(e => e.NationalityId).NotNull();
	}
}