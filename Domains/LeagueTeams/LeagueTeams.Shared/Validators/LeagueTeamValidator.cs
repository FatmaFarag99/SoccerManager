namespace LeagueTeams.Shared;
public class LeagueTeamValidator : AbstractValidator<LeagueTeamViewModel>
{
	public LeagueTeamValidator()
	{
		RuleFor(x => x.Name).NotEmpty().WithMessage("Name is Required");
	}
}