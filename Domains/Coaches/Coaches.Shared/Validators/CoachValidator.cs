namespace Coaches.Shared;
public class CoachValidator : PersonValidator<CoachViewModel>
{
	public CoachValidator()
	{
		RuleFor(e => e.Nationality).NotEmpty();
		RuleFor(e => e.NationalityId).NotNull();
	}
}