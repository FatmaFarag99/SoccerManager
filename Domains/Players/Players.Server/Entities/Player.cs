namespace Players.Server;
public class Player : Person
{
    public decimal Weight { get; set; }
    public int CurrentNumber { get; set; }
    public Guid LeagueTeamId { get; set; }
    public Guid NationalTeamId { get; set; }

}