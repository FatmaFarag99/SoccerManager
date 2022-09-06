namespace Players.Shared;
public class PlayerViewModel : PersonViewModel
{
    public decimal Weight { get; set; }
    public int CurrentNumber { get; set; }
    public Guid NationalityId { get; set; }
    public NationalityViewModel Nationality { get; set; }
}