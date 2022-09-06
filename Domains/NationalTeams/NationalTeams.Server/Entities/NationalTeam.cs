namespace NationalTeams.Server;
public class NationalTeam : BaseEntity
{
    public string Name { get; set; }
    public string NickName { get; set; }
    public string FifaCode { get; set; }
    public string Association { get; set; }
    public string Confedration { get; set; }
    public string MostCaps { get; set; }

    //  public List<Player> Players { get; set; }
    // public Guid CoachId { get; set; }
    // public Guid CaptainId { get; set; }
    // public Guid TopScorerId { get; set; }
}