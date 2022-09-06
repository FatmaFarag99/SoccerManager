namespace Players.Server;
public class Player : Person
{
    public decimal Weight { get; set; }
    public int CurrentNumber { get; set; }
    public Guid NationalityId { get; set; }
    public Nationality Nationality { get; set; }
}