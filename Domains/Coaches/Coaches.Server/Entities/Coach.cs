namespace Coaches.Server;
public class Coach : Person
{
    public Guid? LeagueTeamId { get; set; }
    public Guid? NationalTeamId { get; set; }
}