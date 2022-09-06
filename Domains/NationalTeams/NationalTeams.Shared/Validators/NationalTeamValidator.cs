namespace NationalTeams.Shared;
public class NationalTeamValidator : AbstractValidator<NationalTeamViewModel>
{
	public NationalTeamValidator()
	{
		RuleFor(x => x.Name).NotEmpty().WithMessage("Name is Required");
	}
}