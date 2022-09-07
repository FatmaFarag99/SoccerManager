namespace Coaches.Shared;
public class CoachViewModel : PersonViewModel
{
    public Guid? LeagueTeamId { get; set; }
    public Guid? NationalTeamId { get; set; }
}